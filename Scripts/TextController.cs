using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour {

    public Text gametxt;
    public Text moneytxt;
    public Text lifetxt;
    private int money;
    private int life;

    private enum location { Loc, intro, start, house_0, house_1, house_2, house_2A, house_3A, house_2B, park_0A, park_0B, park_1A, park_1B, park_2A,
                            forest_0, forest_1, store_0, store_0A, store_1, store_1A, store_1B, store_1C, store_2, store_2A, store_2B,
                            ending_1, ending_2, ending_3, ending_4, ending_5, ending_6 }
    private location currentLocation;

    //house 0 = go get fortune cookie task
    //house 1 = at home without finish task
    //house 2 = at home after finished task
    //park = park story
    //forest = adventure
    //store = buy/sell

	void Start () {
        currentLocation = location.Loc;
        money = 0;
        life = 3;

        gametxt.text = "Oh...new face. \n" +
                        "I'll tell you something useful... \n\n" +
                        "Your story is yours alone. \n" +
                        "Everything can be changed base on what you did. \n\n" +
                        "I hope you are doing well here. \n\n" +
                        "Well then... \n\n(Press spacebar to begin your story)";

        currentLocation = location.intro;
    }
	
	void Update () {
        moneytxt.text = money.ToString();
        lifetxt.text = life.ToString();

        if      (currentLocation == location.intro)     { intro(); }
        else if (currentLocation == location.start)     { start(); }
        else if (currentLocation == location.house_0)   { house_0(); }
        else if (currentLocation == location.house_1)   { house_1(); }
        else if (currentLocation == location.house_2)   { house_2(); }
        else if (currentLocation == location.house_2A)  { house_2A(); }
        else if (currentLocation == location.house_2B)  { house_2B(); }
        else if (currentLocation == location.house_3A)  { house_3A(); }
        else if (currentLocation == location.park_0A)   { park_0A(); }
        else if (currentLocation == location.park_0B)   { park_0B(); }
        else if (currentLocation == location.park_1A)   { park_1A(); }
        else if (currentLocation == location.park_1B)   { park_1B(); }
        else if (currentLocation == location.park_2A)   { park_2A(); }
        else if (currentLocation == location.forest_0)  { forest_0(); }
        else if (currentLocation == location.forest_1)  { forest_1(); }
        else if (currentLocation == location.store_0)   { store_0(); }
        else if (currentLocation == location.store_0A) { store_0A(); }
        else if (currentLocation == location.store_1)   { store_1(); }
        else if (currentLocation == location.store_1A)  { store_1A(); }
        else if (currentLocation == location.store_1B)  { store_1B(); }
        else if (currentLocation == location.store_2)   { store_2(); }
        else if (currentLocation == location.store_2A)  { store_2A(); }
        else if (currentLocation == location.store_2B)  { store_2B(); }
        else if (currentLocation == location.ending_1) { ending_1(); }
        else if (currentLocation == location.ending_2) { ending_2(); }
        else if (currentLocation == location.ending_3) { ending_3(); }
        else if (currentLocation == location.ending_4) { ending_4(); }
        else if (currentLocation == location.ending_5) { ending_5(); }
        else if (currentLocation == location.ending_6) { ending_6(); }
    }

    void intro()
    {
        if (Input.GetKeyDown("space"))
        {
            //TODO Show tree image

            gametxt.text = "You visit your grandmother during a long holiday. \n" +
                            "There is nothing much around here, but a giantic tree at a park nearby your grandmother's place.";
            /*gametxt.text = "You visit your grandmother during a long holiday. \n\n\n\n\n\n\n\n\n\n" +
                            "There is nothing much around here, but a giantic tree at a park nearby your grandmother's place.";*/
            if (Input.GetKeyDown("space")) { currentLocation = location.start; }
        }
    }

    void start()
    {
        //TODO Hide tree image

        if (Input.GetKeyDown("space"))
            gametxt.text = "While you are sketching some flowers picture at the park, you hear your granmother is calling for you, " +
                            "but you almost done your drawing. \n" +
                            "What would you do? \n\n" +
                            "A) Pack your belonging and go to her right away \n" +
                            "B) Stay here and try to finish your picture ";

        if (Input.GetKeyDown(KeyCode.A))
        {
            money += 300;
            currentLocation = location.house_0;
        }
        else if (Input.GetKeyDown(KeyCode.B)) { currentLocation = location.park_0A; }
    }

    void house_0()
    {
        gametxt.text = "When you open the door, you see your grandmother walks to you with huge relief.\n" +
                        "She puts money and into your hands and asks you to bring her ingredients for her cookie. \n" +
                        "(Now you can hold L to see the list) \n\n" +
                        "You see your grandmother smile gently at you. What would you do? \n\n" +
                        "A) Go buy ingredients at shopping area. \n" +
                        "B) Go to the park \n" +
                        "C) Tell her that you'll do it later then go back to your room ";

        if (Input.GetKeyDown(KeyCode.A))
        {
            currentLocation = location.store_0;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            currentLocation = location.park_0B;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            currentLocation = location.house_1;
        }

        if (Input.GetKey(KeyCode.L))
        {
            gametxt.text = "Shopping List \n" +
                            "- 1 egg white \n" +
                            "- 1 bag of flour \n" +
                            "- 1 bag of salt \n" +
                            "- 1 bag of sugar \n" +
                            "- 1 bottle of vanilla extract";
        }
    }

    void house_1()
    {
        gametxt.text = "You hear your grandmother sigh, but you didn't care. \n" +
                        "You enter you room and lie down on your bed.\n\n You don't know when did you fall sleep, " +
                        "but the sky is still bright. \n" +
                        "What would you do?\n\n" +
                        "A) Go buy ingredients at shopping area. \n" +
                        "B) Go to the park";

        if (Input.GetKeyDown(KeyCode.A))
        {
            currentLocation = location.store_0;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            currentLocation = location.park_0B;
        }

        if (Input.GetKey(KeyCode.L))
        {
            gametxt.text = "Shopping List \n" +
                            "- 1 egg white \n" +
                            "- 1 bag of flour \n" +
                            "- 1 bag of salt \n" +
                            "- 1 bag of sugar \n" +
                            "- 1 bottle of vanilla extract";
        }
    }

    void house_2()
    {
        gametxt.text = "You carry all ingredients to your grandmother in the kitchen.\n" +
                        "She thanks and hugs you before begin baking cookie." +
                        "What would you do?\n\n" +
                        "A) Help her \n" +
                        "B) Wait until her finish baking without helping her";

        if (Input.GetKeyDown(KeyCode.A))
        {
            currentLocation = location.house_2A;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            currentLocation = location.house_2B;
        }

        if (Input.GetKey(KeyCode.L))
        {
            gametxt.text = "Shopping List \n" +
                            "- 1 egg white \n" +
                            "- 1 bag of flour \n" +
                            "- 1 bag of salt \n" +
                            "- 1 bag of sugar \n" +
                            "- 1 bottle of vanilla extract";
        }
    }
    
    void house_2A()
    {
        gametxt.text = "You granmother show you the recipe of fortune cookie. \n" +
                        "(Now you can hold L to see ingredient list and R to see the recipe) \n\n" +
                        "She asks you to write down fortune papers. What would you write? \n\n" +
                        "A) Write very good fortune \n" +
                        "B) Write random fortune \n" +
                        "C) Write nothing";

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.C))
        {
            currentLocation = location.house_3A;
        }

        if (Input.GetKey(KeyCode.L))
        {
            gametxt.text = "Ingredients for good luck fortune cookies \n" +
                            " 1 egg white \n" +
                            " 1/4 teaspoon vanilla extract \n" +
                            " 30 grams plain flour \n" +
                            " 50 grams granulated sugar \n" +
                            " salt";
        }
        if (Input.GetKey(KeyCode.R))
        {
            gametxt.text = "1. Line baking sheets with greaseproof paper and trace three 7.5 cm circle on each, well apart. " +
                            "Write fortunes on paper stripe about 10x1 cm. Mix the egg white and vanilla until very foamy. " +
                            "Sift the flour, sugar and a pinch of salt and fold into the egg white mixture. \n" +
                            "2. Place teaspoonfuls of the batter in the center and spread to cover the circles as round and as even as possible. \n" +
                            "3. Bake for 5 minutes in a preheated oven, 200°C, until they have turned golden around the outer edge. \n" +
                            "4. Remove from the oven and quickly transfer each cookie with a wide spatula, placing it upside down then " +
                            "place a fortune on the cookie and fold the cookie in half. Gently squeeze the ends of the cookie and " +
                            "pulling the pointed edges down.";
        }
    }

    void house_2B()
    {
        gametxt.text = "Your grandmother bring out a tray of fortune cookies. \n" +
                        "\"Please take one\" she tells you with gentle smile." +
                        "A) Eat one with beautiful golden color \n" +
                        "B) Eat one with slightly burn on the border";

        if (Input.GetKeyDown(KeyCode.A))
        {
            life = 0;
            currentLocation = location.ending_5;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            life = 1;
            currentLocation = location.ending_6;
        }
    }

    void house_3A()
    {
        gametxt.text = "You put fortune papers on cookies and fold them in half. Your grandmother and you place them on the tray. \n" +
                        "\"Please take one\" she tells you with gentle smile. \n" +
                        "A) Eat one with beautiful golden color \n" +
                        "B) Eat one with slightly burn on the border";

        if (Input.GetKeyDown(KeyCode.A))
        {
            currentLocation = location.ending_1;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            currentLocation = location.ending_3;
        }
    }

    void park_0A()
    {
        gametxt.text = "You continue sketching flowers until it's finished. You packed your things and prepare to go home. " +
                        "You look at the flowers again and found that their positions are not the same as your picture. \n" +
                        "What would you do? \n\n" +
                        "A) Touch the flowers \n" +
                        "B) Go back home";

        if (Input.GetKeyDown(KeyCode.A))
        {
            currentLocation = location.park_1A;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            money += 300;
            currentLocation = location.house_0;
        }
    }

    void park_1A()
    {
        gametxt.text = "You reach to the flower, but before you can touch them, they start to scream and ran. \n" +
                        "What would you do? \n\n" +
                        "A) Follow them \n" +
                        "B) Go back home";

        if (Input.GetKeyDown(KeyCode.A))
        {
            currentLocation = location.park_2A;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            money += 300;
            currentLocation = location.house_0;
        }
    }

    void park_2A()
    {
        gametxt.text = "You keep following the flowers and see they go into the hole at the bottom of giantic tree. \n" +
                        "The hole is big enough for you to go insde. \n" +
                        "What would you do? \n\n" +
                        "A) Go inside \n" +
                        "B) Go back home";

        if (Input.GetKeyDown(KeyCode.A))
        {
            currentLocation = location.forest_0;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            money += 300;
            currentLocation = location.house_0;
        }
    }

    void park_0B()
    {
        gametxt.text = "While you're walking through the park, you hear someone's talking. You look around, but there's no one. \n" +
                        "You believe that the sound come from the middle of the park, the giantic tree. \n" +
                        "What would you do? \n\n" +
                        "A) Walk to the tree \n" +
                        "B) Go buy ingredients at shopping area \n" +
                        "C) Go back home";

        if (Input.GetKeyDown(KeyCode.A))
        {
            currentLocation = location.park_1B;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            currentLocation = location.store_0;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            currentLocation = location.house_1;
        }
    }

    void park_1B()
    {
        gametxt.text = "You see a hole big enough for you to enter at the root of the tree. The sound might came from inside. \n" +
                            "What would you do? \n\n" +
                            "A) Go inside \n" +
                            "B) Go buy ingredients at shopping area \n" +
                            "C) Go back home";

        if (Input.GetKeyDown(KeyCode.A))
        {
            currentLocation = location.forest_0;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            currentLocation = location.store_0;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            currentLocation = location.house_1;
        }
    }

    void forest_0()
    {
        gametxt.text = "Once you enter the forest, you feel the force push you back outside the tree. \n" +
                        "You try to get inside again, but there's invisible wall forbid you to enter." +
                        "You have no choice so you go back to your grandmother.";

        if (Input.GetKeyDown("space"))
        {
            money += 300;
            currentLocation = location.house_0;
        }
    }

    void forest_1()
    {
        gametxt.text = "Once you enter the forest, you feel the force push you back outside the tree. \n" +
                        "You try to get inside again, but there's invisible wall forbid you to enter." +
                        "You have no choice so you go to buy the ingredients for your grandmother.";

        if (Input.GetKeyDown("space"))
        {
            currentLocation = location.store_0;
        }

        if (Input.GetKey(KeyCode.L))
        {
            gametxt.text = "Shopping List \n" +
                            "- 1 egg white \n" +
                            "- 1 bag of flour \n" +
                            "- 1 bag of salt \n" +
                            "- 1 bag of sugar \n" +
                            "- 1 bottle of vanilla extract";
        }
    }

    void store_0()
    {
        gametxt.text = "You enter the store and see owner behind the counter smile at you. \n" +
                        "Everything on your list is here.\n" +
                        "What would you do? \n\n" +
                        "A) Buy all ingredients needed \n" +
                        "B) Sell something \n" +
                        "C) Leave the store ";

        if (Input.GetKeyDown(KeyCode.A))
        {
            money = 0;
            currentLocation = location.store_0A;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            currentLocation = location.store_1;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            currentLocation = location.store_1B;
        }

        if (Input.GetKey(KeyCode.L))
        {
            gametxt.text = "Shopping List \n" +
                            "- 1 egg white \n" +
                            "- 1 bag of flour \n" +
                            "- 1 bag of salt \n" +
                            "- 1 bag of sugar \n" +
                            "- 1 bottle of vanilla extract";
        }
    }

    void store_0A()
    {
        gametxt.text = "You get all of your ingredients in the list. \n" +
                        "You pick everything up and go back to your grandmother's home.";

        if (Input.GetKeyDown("space"))
        {
            currentLocation = location.house_2;
        }

        if (Input.GetKey(KeyCode.L))
        {
            gametxt.text = "Shopping List \n" +
                            "- 1 egg white \n" +
                            "- 1 bag of flour \n" +
                            "- 1 bag of salt \n" +
                            "- 1 bag of sugar \n" +
                            "- 1 bottle of vanilla extract";
        }
    }

    void store_1()
    {
        gametxt.text = "The huge smile on shop owner's face is gone. He asked you to put on items you want to sell on the counter. " +
                        "However, you don't have anything to sell. The owner's face become scarier as he wait for you. \n" +
                        "What would you do? \n\n" +
                        "A) Insist selling something \n" +
                        "B) Apologize him \n" +
                        "C) Leave immediately";

        if (Input.GetKeyDown(KeyCode.A))
        {
            life = 0;
            currentLocation = location.ending_2;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            life -= 1;
            if (life <= 0)
            {
                currentLocation = location.ending_4;
            }
            else
            {
                currentLocation = location.store_1A;
            }
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            life -= 2;
            if (life <= 0)
            {
                currentLocation = location.ending_4;
            }
            else
            {
                currentLocation = location.store_1B;
            }
        }
    }

    void store_1A()
    {
        gametxt.text = "He hits you on the head and give you warning with plain voice.\n" +
                        "\"Don't ever try to joke with someone you shouldn't again.\"\n\n" +
                        "You were kicked out from the store.";

        if (Input.GetKeyDown("space"))
        {
            currentLocation = location.store_1B;
        }
    }

    void store_1B()
    {
        gametxt.text = "You stand in front of the store. You need to buy things, so you get back inside again.";

        if (Input.GetKeyDown("space"))
        {
            currentLocation = location.store_0;
        }
            
    }

    void store_2()
    {
        gametxt.text = "He asked you to put on items you want to sell on the counter. " +
                        "What would you do? \n\n" +
                        "A) Put all of your unuseable items on the counter \n" +
                        "B) Leave immediately ";

        if (Input.GetKeyDown(KeyCode.A))
        {
            //TODO add money based on 'exist' items that isn't in the list
            currentLocation = location.store_2A;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            currentLocation = location.store_2B;
        }
    }

    void store_2A()
    {
        gametxt.text = "You keep received money into your bag and walk to the front of the store. \n" +
                        "What are you going to do?\n\n" +
                        "A) Go back inside \n" +
                        "B) Go go the park \n" +
                        "C) Go back home";

        //TODO move to location
    }

    void store_2B()
    {
        gametxt.text = "You stand in front of the store. What are you going to do?\n\n" +
                        "A) Go inside \n" +
                        "B) Go go the park \n" +
                        "C) Go back home";

        //TODO move to location
    }

    void ending_1()
    {
        gametxt.text = "The cookie is very delicious. Your grandmother smile happily while looking at you enjoy your cookie and good fortune.";

        if (Input.GetKeyDown("space")) { SceneManager.LoadScene("Ending"); }
    }

    void ending_2()
    {
        gametxt.text = "Since you don't have anything on you, the owner's face become red.\n" +
                        "The light is off. The door is locked. You are trapped inside the store.\n\n" +
                        "\"I'll buy your life.\"\n\n is last thing you hear...";

        if (Input.GetKeyDown("space")) { SceneManager.LoadScene("GameOver"); }
    }

    void ending_3()
    {
        gametxt.text = "The cookie is crispy and a little bit bitter, but still delicious. \n" +
                        "\"You're so kind. Thank you for concerning about burnt one\" she said." +
                        "Your grandmother smile happily while looking at you enjoy your cookie and good fortune.";

        if (Input.GetKeyDown("space")) { SceneManager.LoadScene("Ending"); }
    }

    void ending_4()
    {
        gametxt.text = "You suddenly feel tired and collapse to the floor. \n" +
                        "Everything become darker and darker. " +
                        "You no longer see or hear anything. You just sleep there ... in peace";

        if (Input.GetKeyDown("space")) { SceneManager.LoadScene("GameOver"); }
    }

    void ending_5()
    {
        gametxt.text = "The cookie is too spicy for you. You cough and see that cookie is filled with chili. \n" +
                        "Your throat burnt and you cry for water, but you see your grandmother is laughing nonstop. \n" +
                        "You writhe until you exhuast and faint";

        if (Input.GetKeyDown("space")) { SceneManager.LoadScene("GameOver"); }
    }

    void ending_6()
    {
        gametxt.text = "You cough because it's bitter than you think. Your grandmother laugh at you and hand you a glass of water. \n" +
                        "You feel a lot better. You and your grandmother laugh together. \n\n" +
                        "...It's weird. You don't remember anything after that. You hear your grandmother laugh before you become unconscious.";

        if (Input.GetKeyDown("space")) { SceneManager.LoadScene("GameOver"); }
    }
}

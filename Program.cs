using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace vg_the_game
{
    public struct enemy
    {
        public string name;
        public int enemyHealth;
    }
    internal class Program
    {

        public static double enemyHealth, health, damage, filament, energy, armour, difficulty, weapon, xp, damageMod;
        public static int pen, roomID, card, hallwayID, spareKey, bitcoinWallet;
        public static string enemyName;

        public static int officeid, hallwayintro, closetid, boom1id, broom2id;  //first floor 
        public static int printerid, studioid, mathsid,commonid; //second floor
        public static int hallwayintro3; //third floor


        public static int achev;


        static void Main()
        {
            officeid = 0;
            hallwayintro = 0;
            closetid = 0;
            boom1id = 0;
            broom2id = 0;
            printerid = 0;
            studioid = 0;
            commonid = 0;
            mathsid = 0;
            energy = 100;
            health = 100;
            armour = 0.1;
            xp = 0;
            filament = 49;
            weapon = 0.5;
            difficulty = 0.1;
            damageMod = 1;
            pen = 0;
            card = 0;
            hallwayID = 0;
            spareKey = 0;
            hallwayintro3 = 0;
            bitcoinWallet = 0;
            achev = 0;
            ReadStartingPage();
            Start();
        }

        static void ReadStartingPage()// method that reads the StartingPage.txt
        {
            List<string> lines = new List<string>();

            
            var file = File.ReadAllLines("StartImage.txt");
            foreach (var line in file)
            {
                lines.Add(line);
            }

            foreach (var line in lines)
            {
                Console.WriteLine(line);
              
            }
            Thread.Sleep(2000);
        }

        static void will()//method to add a enemy copy this when adding someone to the game
        {
            enemy will;
            will.name = "Office Lady";//sets enemy name
            will.enemyHealth = 25;// sets enemyHealth
            enemyHealth = will.enemyHealth;// overrides the last enemies health
            enemyName = will.name;
            damageMod = 1;
        }
        static void BussinessGuy()
        {
            enemy BussinessStudent;
            BussinessStudent.name = "Business Student";//sets enemy name
            BussinessStudent.enemyHealth = 20;// sets enemyHealth
            enemyHealth = BussinessStudent.enemyHealth;// overrides the last enemies health
            enemyName = BussinessStudent.name;
            damageMod = 1;
        }
        static void Krissi()
        {
            enemy Krissi;
            Krissi.name = "Krissi Wood";//sets enemy name
            Krissi.enemyHealth = 50;// sets enemyHealth
            enemyHealth = Krissi.enemyHealth;// overrides the last enemies health
            enemyName = Krissi.name;
            damageMod = 1.5;
        }
        static void FarmBot()
        {
            enemy farmBot;
            farmBot.name = "Farm Bot";//sets enemy name
            farmBot.enemyHealth = 100;// sets enemyHealth
            enemyHealth = farmBot.enemyHealth;// overrides the last enemies health
            enemyName = farmBot.name;
            damageMod = 1.5;
        }
        static void Printer()
        {
            enemy printer;
            printer.name = "3D Printer";//sets enemy name
            printer.enemyHealth = 30;// sets enemyHealth
            enemyHealth = printer.enemyHealth;// overrides the last enemies health
            enemyName = printer.name;
            damageMod = 1.25;
        }
        static void MathsStudent()
        {
            enemy mathStudent;
            mathStudent.name = "Deacon";//sets enemy name
            mathStudent.enemyHealth = 20;// sets enemyHealth
            enemyHealth = mathStudent.enemyHealth;// overrides the last enemies health
            enemyName = mathStudent.name;
            damageMod = 1.33;
        }
        static void Victor()
        {
            enemy Victor;
            Victor.name = "Victor";//sets enemy name
            Victor.enemyHealth = 75;// sets enemyHealth
            enemyHealth = Victor.enemyHealth;// overrides the last enemies health
            enemyName = Victor.name;
            damageMod = 1.6;
        }
        static void empoweredBuisnessStudent()
        {
            enemy buisnessStudent2;
            buisnessStudent2.name = "Empowered Buisness Student";//sets enemy name
            buisnessStudent2.enemyHealth = 125;// sets enemyHealth
            enemyHealth = buisnessStudent2.enemyHealth;// overrides the last enemies health
            enemyName = buisnessStudent2.name;
            damageMod = 2;
        }

        static void Emily()
        {
            enemy Emily;
            Emily.name = "Emily";//sets enemy name
            Emily.enemyHealth = 20;// sets enemyHealth
            enemyHealth = Emily.enemyHealth;// overrides the last enemies health
            enemyName = Emily.name;
            damageMod = 1.33;
        }

        static void Equiptment()
        {

            if (weapon == 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" You have no weapon");
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (weapon == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" You have weapon 1");
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (weapon == 1.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" You have weapon 2");
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (weapon == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" You have weapon 3 (Highest Level)");
                Console.ForegroundColor = ConsoleColor.White;
            }


            if (armour == 0.1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" You have no Armour");
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (armour == 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" You have Vaughn boots, maybe you should go tramping");
                armour = 0.5;
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (armour == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" You have Ginmail");
                armour = 1;
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (armour == 1.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" You have weapon ResinRanger Rain Coat ");
                armour = 1.5;
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (armour == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" You have PLA Power Vest (Highest Level)");
                armour = 2;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
      
        static void callroom()
        {
            switch (hallwayID)
            {
                case 0:
                    hallway();
                    break;
                case 1:
                    hallway2();
                    break;
                case 2:
                    hallway3();
                    break;
            }
        }

        static void Start()
        {
            Console.Clear();
            Console.WriteLine("\n You are the one and only Vaughn Malkin. \n You wake up in a cold sweat, first year math exams cover you. ");
            Thread.Sleep(1000);
            Console.WriteLine(" Just before you leave to go home to the 'Space Station' which is what you refer to as your house as.\n You realise you are missing your trusty bottle of gin!");
            Thread.Sleep(2000);
            Console.WriteLine("\n\n       Your mission!\n  Find your bottle of Gin!\n   -So you can go home. \n   -Have a great weekend!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\n\n\n\n\n  Press enter to start");
            Console.ForegroundColor= ConsoleColor.White;
            Console.ReadLine();
            roomID = 0;
            armour = 0;
            weapon = 0;
            hallway2();
        }

        //admin/office - item room
        static void office()
        {
            string userInput = null;

            if (officeid == 1)
            {

                Console.WriteLine(" You have already been in this room.\n You have been sent back to the hallway.");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\n\n Press ENTER to continue");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                hallway();
            }

            Console.Clear();

            roomID = 1;
            Console.WriteLine("\n You are in the Office\n");
            Thread.Sleep(1000);
            Console.WriteLine(" Your environmental impact of printing off a rain forest of paper for your math exams, has enraged the office lady who\n appears to have a blob of glue and staples for hands ");
            Thread.Sleep(1000);
            Console.WriteLine(" You must now fight your way out of this one!");
            do {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" Do you wish to do the combat tutorial? yes or no?\n");
                Console.ForegroundColor = ConsoleColor.White;
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "yes")
                {

                    Console.WriteLine("\n Whenever you need to fight someone, there will be five options available to you: \n\n A strong attack.\n A medium attack.\n A low attack\n A charge attack\n And finally a gain energy\n\n");
                    Console.WriteLine(" Every attack uses energy, The stronger attacks deal higher damage, but have a higher chance for Vaughn to miss and deal no damage, as well as taking more energy to use, and if you don't have enough, the attack wont work.\n The weaker attacks, by extension do less damage and use less energy, but have a higher chance to hit.\n\n");
                    Console.WriteLine(" The gain energy button is to be used when you feel Vaughn is too low on energy, and needs some more. \n And the charge attack takes 3 turns of using charge attack to fully charge, but will deal immense damage. \n Your HP and Energy are displayed above the fight options, and your opponents HP is visable on side opposite to yours.\n\n Thats all for the tutorial, press Enter when you are ready to continue! And have fun!\n");
                    Console.ReadLine();
                }
            } while (userInput != "yes" && userInput != "no" );

            Thread.Sleep(1000);
            will(); //Will is known as the office lady
            fight(); //I believe this should be moved into the office yes you are correct i have moved it there now
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "office":
                    Console.WriteLine(" Your are already here\n");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(" press ENTER to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    office();
                    break;
                case "hallway":
                    hallway();
                    break;
            }
        }

        static void hallway()
        {
            string temp;
            int input;

            roomID = 2;
            Console.Clear();
            Console.WriteLine("\n You are in the Hallway\n");
            Thread.Sleep(1000);

            if (hallwayintro == 0)
            {
                Console.WriteLine(" You spot a pen lying on the ground, it appears to be the last Te Pūkenga BIT pen. ");
                Thread.Sleep(1000);

                do
                {
                    temp = "";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(" Would you like to pick up the pen (1) or leave it on the ground as there could be better things to find (0).");
                    Console.ForegroundColor = ConsoleColor.White;
                    temp = Console.ReadLine();

                } while (temp != "1" && temp != "0");


                input = Convert.ToInt32(temp);


                if (input == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" You have picked up the pen!");
                    pen = 1;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    pen = 0; //If there is a chance they somehow go back and don't pick up the pen (Can be removed later)
                    Console.WriteLine(" You choose not to pick up the pen, it probably wasn't important.");
                }
            }

            string choice;
            hallwayintro = 1;

            while (officeid == 0 || closetid == 0 || boom1id == 0 || broom2id == 0)
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(" You stand in the hallway you can navigate to the (office), (broom1), (broom2), (closet)"); //Need to rename broom1 and broom2
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" Once you've explored all rooms on level 1, you will progress to the second level");
                    choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "hallway":
                            Console.WriteLine(" You are already here");
                            Thread.Sleep(3000);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(" Press ENTER to continue");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadLine();
                            hallway();
                            break;
                        case "office":
                            office();
                            break;
                        case "broom1":
                            broom1();
                            break;
                        case "broom2":
                            broom2();
                            break;
                        case "closet":
                            closet();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Please enter a valid input");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                }
                while (choice != "hallway" || choice != "office" || choice != "broom1" || choice != "broom2" || choice != "closet");

            }
           /* if (officeid == 1 && closetid == 1 && boom1id == 1 && broom2id== 1) //I feel like this should be a while loop and while not equal to this everything else runs for level 1?
            {*/
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Congrats you have explored all of level 1!");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
                Console.WriteLine(" The elevator is going up...");
                Thread.Sleep(2000);
                hallwayID = 1;
                hallway2();
            //}

        }



        //Janitor Closet 
        static void closet()
        {

            if (closetid == 1)
            {
                Console.WriteLine(" You have already visited here, you have been sent back to the hallway.");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n Press ENTER to continue");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                hallway();
            }


            Console.Clear();

            roomID = 3;
            Console.WriteLine("You are in Janitor Closet");

            Thread.Sleep(2000);
            Console.WriteLine(" You enter a dark gloomy room, Krissi appears from the shadows in front of you.");
            Thread.Sleep(2000);
            Console.WriteLine(" [Krissi]: Vaughn... Have you brought me a pen??\n If you would like you see your boots again, I would need a pen in return.\n I trust you would have one on you as you are marking math exams.");
            Thread.Sleep(2000);

            if (pen == 1)
            {
                Console.WriteLine(" [Krissi]: Thank you for giving me a pen, you know I am a true pen thief, thank you.");
                Thread.Sleep(2000);
                Console.WriteLine(" [Krissi]: Here are your special boots.");
                Thread.Sleep(1000);
                armour = 0.5;
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" [YOU EQUIPED YOUR BOOTS]");
                Console.ForegroundColor = ConsoleColor.White;
            }

            else
            {
                Console.WriteLine(" [Krissi]: Disappointing, you didn't bing me a pen. Now I can not let you pass without a fight."); //Change to Fight Code
                Krissi();
                fight();
            }

            closetid = 1;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" You stand in the closet you can navigate to the (closet), (hallway).");
            Console.ForegroundColor = ConsoleColor.White;
            string choice;
            do
            {
                choice = Console.ReadLine();  
                
                switch (choice)
                {
                    case "closet":
                        Console.WriteLine(" You can't go back into a room you are already in! Try the hallway instead");
                        Thread.Sleep(3000);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(" Press ENTER to continue");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        hallway();
                        break;
                    case "hallway":
                        hallway();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Please enter a valid input");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }while (choice != "closet" && choice != "hallway");
        }


        //Boss Room
        static void broom1()
        {
            string choice;

            if (boom1id == 1)
            {
                Console.WriteLine(" You have already visited here, you have been sent back to the hallway.");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n Press ENTER to continue");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                hallway();
            }


            //Angry Student Boss
            Console.Clear();

            Console.WriteLine("\n You are in broom1\n");
            roomID = 4;
            Console.WriteLine("[First Year Student]: Hi Vaughn, I was just wondering if you had marked my math exam?");
            Thread.Sleep(1000);
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n You can respond with either 'yes' or 'no'\n");
            Console.ForegroundColor = ConsoleColor.White;

            boom1id = 1;
            string response;

            do
            {
                response = Console.ReadLine().ToLower();

                if (response == "yes")
                {
                    Console.WriteLine("\n Yes, I'll get round to marking the math papers, I just have to find my gin");
                }
                else if (response == "no")
                {
                    Console.WriteLine(" No!, I need to find my gin, I don't have time to mark math papers");
                    BussinessGuy();// using his status
                    fight();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Please enter a valid input");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (response != "yes" && response != "no");

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" You stand in the broom1 you can navigate to the (broom1), (hallway).");
                Console.ForegroundColor = ConsoleColor.White;
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "broom1":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(" You are already here.\n\n press ENTER to continue");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        broom1();
                        break;
                    case "hallway":
                        hallway();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Please enter a valid input");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            } while (choice != "broom1" && choice != "hallway");
        }

        //Boss Room
        static void broom2()
        {
            string response;

            if (broom2id == 1)
            {
                Console.WriteLine(" You have already visited here, you have been sent back to the hallway.");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n Press ENTER to continue");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                hallway();
            }



            //Business Student Boss
            Console.Clear();

            Console.WriteLine("\n You are in broom2\n");
            roomID = 5;

            broom2id = 1;
            Console.WriteLine(" You enter one of the business studies class rooms.");
            Thread.Sleep(1000);
            Console.WriteLine(" The student comes over, trying to sell you crypto, they are quite the sales person.");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" Do you wish to buy some crypto from the business studies student? (yes or no)");
            Thread.Sleep(1000);
            if (bitcoinWallet == 1)
            {
                Console.WriteLine("...Or, you could give him the Bitcoin wallet you found... (give wallet)");
            }
            Console.ForegroundColor = ConsoleColor.White;
            response = Console.ReadLine();
            if (response == "yes")
            {
                Console.WriteLine(" [Business Studies Student]: Great I will sign you up!");
                Thread.Sleep(3000);

                Console.WriteLine(" [Business Studies Student]: Hey there! Want to skyrocket your bank account to the moon?");
                Thread.Sleep(3000); 
                Console.WriteLine(" [Business Studies Student]: Well, hold onto your seatbelt because I've got something hotter than Elon's tweets:\n                             cryptocurrencies!");
                Thread.Sleep(3000); 
                Console.WriteLine(" [Business Studies Student]: Picture this: you, sipping champagne on a yacht, courtesy of your crypto investments.");
                Thread.Sleep(3000); 
                Console.WriteLine(" [Business Studies Student]: Gone are the days of boring stocks and bonds. We're talking about digital gold, baby!");
                Thread.Sleep(3000); 
                Console.WriteLine(" [Business Studies Student]: With crypto, you're not just an investor, you're a pioneer in the wild west of finance.");
                Thread.Sleep(3000); 
                Console.WriteLine(" [Business Studies Student]: And guess what? You don't need a fancy suit or a Wall Street address to get started.");
                Thread.Sleep(3000); 
                Console.WriteLine(" [Business Studies Student]: In the crypto world, everyone's welcome, from the hoodie-wearing tech geek to the hipster\n                             barista.");
                Thread.Sleep(3000); 
                Console.WriteLine(" [Business Studies Student]: So, what are you waiting for? Let's make those dreams of Lambos and private islands a\n                             reality!");
                Thread.Sleep(3000); 
                Console.WriteLine(" [Business Studies Student]: Are you ready to dive into the crypto ocean with me?");
                Thread.Sleep(3000); 
                Console.WriteLine(" [Business Studies Student]: Just imagine the thrill of riding the waves of Bitcoin highs and dodging the lows.");
                Thread.Sleep(3000); 
                Console.WriteLine(" [Business Studies Student]: It's like being a surfer on the biggest financial wave of the century!");
                Thread.Sleep(3000); 
                Console.WriteLine(" [Business Studies Student]: And hey, even if you wipe out, there's always another wave waiting to lift you back up.");
                Thread.Sleep(3000); 
                Console.WriteLine(" [Business Studies Student]: So, grab your board and let's catch that crypto wave together!");
                Thread.Sleep(3000);
                Console.WriteLine("\n\n      Achievement Unlocked!\n  Useless Story Line Unlocked!\n   -Did you really want this? \n   -You have been distracted from the missions.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\n\n\n\n\n\n\n  Press enter to start");
                Console.ForegroundColor = ConsoleColor.White;
                achev++;
                Console.ReadLine();
                Console.Clear();

            }
            if (response == "no")
            {
                Console.WriteLine(" [Business Studies Student]: HOW DEAR YOU! YOU HAVEN'T EVEN LISTEND TO MY PITCH!");
                BussinessGuy();
                fight();
            }
            if (response == "give wallet")
            {
                Console.WriteLine(" \n[Business Studies Student]: A Bitcoin wallet! With this I'll be unstoppable! Watch what I do next! ;)");
                Console.WriteLine(" An Empowered Business Studies Student approaches!");
                empoweredBuisnessStudent();
                fight();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" You stand in the broom2 you can navigate to the (broom2), (hallway).");
            Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine(" You can now navigate to (broom2) or (hallway)");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "broom2":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(" You are already here.\n\n press ENTER to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    //broom2();
                    Console.WriteLine(" You can't go back into a room you are already in! Try the hallway instead.");
                    hallway();
                    break;
                case "hallway":
                    hallway();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Please enter a valid input");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }



        //Second Floor

        static void hallway2()
        {
            Console.Clear();
            Console.WriteLine("\n You are now on the 2nd floor\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" You stand in the second floor hallway you can navigate to the (printer), (studio), (maths)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Once you've explored all rooms on level 2, you will progress to the third level");
            string choice;
            while (printerid == 0 || studioid == 0 || mathsid == 0 || commonid == 0)
            {
                do
                {
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "printer":
                            if (card == 1)
                            {
                                printerRoom();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(" You need a card to unlock this room, You can get this by visiting the maths room (Press ENTER to continue");
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(3000);
                                hallway2();
                            }
                            break;
                        case "studio":
                            studioRoom();
                            break;
                        case "maths":
                            mathsRoom();
                            break;
                        case "common room":
                            commonRoom();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Please enter a valid input");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                } while (choice != "printer" && choice != "studio" && choice != "maths" && choice!= "common room");
            }
            /*if (printerid == 1 && studioid == 1 && mathsid == 1) //I feel like this should be a while loop and while not equal to this everything else runs for level 1?
            {*/
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n Congrats you have explored all of level 2");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(3000);
            Console.WriteLine(" The elevator is going up...");
            Thread.Sleep(3000);
            hallwayID = 2;
            hallway3();
        }
        static void mathsRoom()
        {

            if (mathsid == 1)
            {
                Console.WriteLine(" You have already visited here, you will be sent back to the hallway");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n Press ENTER to continue");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                hallway2();
            }

            mathsid = 1;

            Console.WriteLine("\n You are in the Maths Room\n");
            Console.WriteLine(" Deacon is there and he does not look happy");
            Thread.Sleep(1000);
            Console.WriteLine(" [Deacon]: Vaughn you are making the tutorials a living nightmare\n None of the questions make sense, why don't you try answer one!");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" [Deacon]: What is  eiπ + ln(−1) = x2 +∫0∞​xsin(x)​dx? (Write an answer)");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" [Deacon]: Wrong! I will have to tech you a lesson about maths");
            card = 1;
            MathsStudent();
            fight();
        }
        static void studioRoom()
        {

            if (studioid == 1)
            {
                Console.WriteLine(" You have already visited here, you will be sent back to the hallway");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n Press ENTER to continue");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                hallway2();
            }


            studioid = 1;

            Console.WriteLine("\n You are in the Studio Room\n");
            Console.WriteLine(" Vic is here\n He asks a serious question to ask of you");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" [Vic]: How many seasons of The Simpsons are there? (Write an answer)");
            Console.ForegroundColor = ConsoleColor.White;
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp == 35)
            {
                Console.WriteLine(" [Vic]: Wow! I didn't expect you to get that right! Well done");
                Console.WriteLine(" Go explore the hallway (Press ENTER to continue)");

                Console.ReadLine();
                hallway2();
            }

            else
            {
                Console.WriteLine(" [Vic]: How didn't you know that? Lets dance!");
                Victor();
                fight();
            }

        }


        static void printerRoom()
        {

            if (printerid == 1)
            {
                Console.WriteLine(" You have already visited here, you will be sent back to the hallway");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n Press ENTER to continue");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                hallway2();
            }


            printerid = 1;

            Console.WriteLine("\n You are in the Printer Room\n");
            int choice;
            Console.WriteLine(" There is only enough filament to print one thing");
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" 1. Make a Weapon: which increases your damage dealt to enemies\n 2. Make Armor: which decreases damage dealt to you by those you fight");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                if (choice == 1)
                {
                    armour = 10;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" You got a Shield");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (choice == 2)
                {
                    weapon = 10;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" You got a Sword");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Please enter a valid input");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (choice != 1 && choice !=2);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n Press ENTER to continue");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();

            hallway2();
        }

        static void commonRoom()
        {
            if (commonid == 1)
            {
                Console.WriteLine("You have already visited here, you have been sent back to the hallway");
                Console.ReadLine();
                hallway2();
            }

            commonid = 1;
            
            Console.WriteLine("\n Common Room \n");
            Console.WriteLine(" You are in the common room, a group of Studio 1 students are working on the projects");
            Thread.Sleep(1000);
            Console.Write(" You notice that each and every student is using ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("CHATGPT!!");
            
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n [Emily] : WHAT ARE YOU DOING HERE VAUGHN !");
            Thread.Sleep(1000);
            Console.WriteLine(" [Vaughn] : What did I tell you guys about using Chatgpt! This is how you fail Studio 1 by cheating");
            Thread.Sleep(1000);
            LaughBeep();
            Console.WriteLine(" [Emily] : VAUGHN NOBOBY LIKES SNITCHES ");
            Emily();
            fight();

        }
        static void LaughBeep()
        {
            // Series of beeps to simulate a laugh
            int[] frequencies = { 900, 800, 900, 800, 900 };//
                                      //900, 1000, 1100, 1200, 1300 };
            int duration = 100; // Duration of each beep in milliseconds

            Console.WriteLine(" Laughing");
            
            foreach (int freq in frequencies)
            {
                Console.Beep(freq, duration);
                Thread.Sleep(150); // Short pause between beeps
            }

            

        }


        //Third Floor

        static void hallway3()
        {

            if (hallwayintro3 == 0)
            {
            Console.WriteLine("\n You are now on the 3rd floor\n");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" You stand in the third floor hallway you can navigate to the (office), (D312)");
            Console.ForegroundColor = ConsoleColor.White;            
            hallwayintro3 = 1;

            string choice;
            do
            {
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "hallway":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(" You are already here press ENTER to continue");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();

                        hallway3();
                        break;
                    case "office":
                        VaughnOffice();
                        break;
                    case "D312":
                        platformsanddevices();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Please enter a valid input");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                }
            } while (choice != "hallway" || choice != "office");

        }


        static void VaughnOffice()
        {

            if (spareKey == 0)
            {
                Console.WriteLine("It appears you don't have your keys");
                Thread.Sleep(1000);
                Console.WriteLine("Try visting Paul in D312");
                Thread.Sleep(2000);
                Console.Clear();
                hallway3();
            }
            

            Console.WriteLine("\n Vaughn's Office\n");
            Console.WriteLine(" You entered Vaughn's office");

            Thread.Sleep(1000);
            Console.WriteLine(" It's dark and gloomy...");
            Thread.Sleep(1000);
            Console.WriteLine(" A robot figure appears, it's Farm Bot!");
            Thread.Sleep(1000);
            Console.WriteLine(" He has returned to get his revenge!");
            FarmBot();
            fight();
            Console.WriteLine(" You have defeated Farm bot!");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(" You look around your office...");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" You found your gin!");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            //Environment.Exit(0); Add in connection to Win screen here
            Win();
        }

        static void platformsanddevices()
        {
            string response;
            Console.WriteLine("You enter D312, the lights illuminate");
            Thread.Sleep(1000);
            Console.WriteLine("[Vaughn]: Hi Paul, I've lost my keys just wondering if I could use yours");
            Thread.Sleep(1000);
            Console.WriteLine("[Paul]: I'll have a look...");
            Thread.Sleep(1000);
            Console.WriteLine("[Paul]: Just wondering if you've got any tech news");
            Thread.Sleep(1000);
            Console.WriteLine("You can either respond to Paul with 'yes' or 'No'");
            do
            {
                response = Console.ReadLine();
                if (response == "yes")
                {
                    Console.WriteLine("[Paul]: Great to hear, you'll have to present that to the class today!");
                    Thread.Sleep(2000);
                }
                else if (response == "no")
                {
                    Console.WriteLine("Maybe you should check out the latest Elon Musk news on Wired.com");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Please enter a valid input");
                }
            } while (response != "yes" && response != "no");

            Console.Clear();

            do
            {
                Console.WriteLine("[Paul]: What do you think of Elon Musk?");
                Console.WriteLine("You can respond with:");
                Console.WriteLine("(1) He ruined Twitter!");
                Console.WriteLine("(2) Tesla is going to destroy the world");
                Console.WriteLine("(3) He's a rich prick");
                response = Console.ReadLine();
                if (response == "1")
                {
                    Console.WriteLine("[Paul]: Elon is actually working to make Twitter better by introducing new features and improving the platform.");
                    Thread.Sleep(1000);
                    Console.WriteLine("[Paul]: Sometimes big changes can be challenging, but he's got a track record of transforming industries for the better.");
                    Thread.Sleep(1000);
                    Console.WriteLine("[Paul]: It’s worth giving his vision a chance to see how it plays out.");
                }
                else if (response == "2")
                {
                    Console.WriteLine("[Paul]: Tesla is actually working towards a more sustainable future with electric vehicles and renewable energy solutions.");
                    Thread.Sleep(1000);
                    Console.WriteLine("[Paul]: Their goal is to reduce reliance on fossil fuels and lower emissions, which can help combat climate change.");
                    Thread.Sleep(1000);
                    Console.WriteLine("[Paul]: While no company is perfect, Tesla’s innovations are aimed at creating a better world, not destroying it.");
                }
                else if (response == "3")
                {
                    Console.WriteLine("[Paul]: It's easy to focus on someone's wealth and label them negatively, but it's also important to consider their contributions and intentions.");
                    Thread.Sleep(1000);
                    Console.WriteLine("[Paul]: Elon Musk has invested heavily in technology and innovation with the aim of solving big problems like climate change and space exploration.");
                    Thread.Sleep(1000);
                    Console.WriteLine("[Paul]: Criticizing someone based on their wealth alone might overlook the broader impact of their work and efforts.");
                }
                else
                {
                    Console.WriteLine("Please enter a valid input");
                }
            } while (response != "1" && response != "2" && response != "3");
            
            Thread.Sleep(2000);
            Console.WriteLine("[Paul]: While I don't agree with everything you have said today, Vaughn");
            Thread.Sleep(1000);
            Console.WriteLine("[Paul]: Here is my spare key for your office");
            spareKey = 1;
            hallway3();
        }


        static void fight()
        {

            health = 100;
            energy = 100;

            int charge = 0;
            string userInput = null;
            int option;
            string input = "";

            Random random = new Random();
            do
            {
                do
                {
                    Console.WriteLine($"\n You have {health} HP and {energy} Energy.                                                          {enemyName} has {enemyHealth} HP");//Change to name from list
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" Choose your move!: \n  1: Strong Attack \n  2: Medium Attack \n  3: Low Attack \n  4: Charge Attack \n  5: Gain Energy \n  6: Tips\n");
                    userInput = Console.ReadLine();

                    if (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4" && userInput != "5" && userInput != "6")
                    {
                        Console.WriteLine("\n Please enter a valid input.");
                    }
                } while (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4" && userInput != "5" && userInput != "6");

                option = Convert.ToInt32(userInput);
                int hit = random.Next(101);
                userInput = null;

                switch (option)
                {
                    case 1:
                        if (energy >= 40)
                        {
                            energy -= 40;
                            damage = random.Next(30, 41);

                            if (hit > 84)
                            {
                                Console.WriteLine($"\n You hit the enemy for {damage} damage!\n");

                                enemyHealth -= damage + weapon;
                            }

                            else
                                Console.WriteLine("\n You missed!");
                        }

                        else
                            Console.WriteLine("\n You dont have enough energy for the Strong Attack.\n");
                        break;

                    case 2:
                        if (energy >= 20)
                        {
                            energy -= 20;
                            damage = random.Next(19, 32);

                            if (hit > 50)
                            {
                                Console.WriteLine($"\n You hit the enemy for {damage} damage!\n");
                                enemyHealth -= damage + weapon;
                            }

                            else
                                Console.WriteLine("\n You missed!");
                        }

                        else
                            Console.WriteLine("\n You don't have enough energy for the Medium Attack.\n");
                        break;

                    case 3:
                        {
                            if (energy >= 10)
                            {
                                energy -= 10;
                                damage = random.Next(9, 22);

                                if (hit > 25)
                                {
                                    Console.WriteLine($"\n You hit the enemy for {damage} damage!\n");
                                    enemyHealth -= damage + weapon;
                                }

                                else
                                    Console.WriteLine("\n You missed!");
                            }
                            else
                                Console.WriteLine("\n You don't have enough energy for the Low Attack.\n");
                            break;
                        }
                    case 4:
                        {
                            if (charge == 3)
                            {
                                damage = random.Next(50, 80);
                                Console.WriteLine($"\n You hit the enemy for {damage} damage!\n");
                                enemyHealth -= damage + weapon;
                                charge = 0;
                            }

                            else
                                charge++; break;
                        }
                    case 5:
                        {
                            int energyGained = random.Next(25, 50);
                            energy = Math.Min(100, energy + energyGained);
                            break;
                        }
                    case 6:
                        TipsMenu();
                        break;
                }

                if (enemyHealth > 0 && option != 6) enemyAttack() ; // Enemy attacks only if it's still alive and the player didn't go into the tips menu.
                Console.WriteLine("\n\n");
            } while (health > 0 && enemyHealth > 0);

            if (health <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n       You have been defeated");
                Console.WriteLine("\n             Game Over!");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
                Lose();

            }
            else if (enemyHealth <= 0)
            {
                Console.WriteLine(" You have defeated the enemy!");

                if (officeid == 0)
                {
                    Console.WriteLine("\n You find a USB of some kind in her pocket, it seems to be a crypto wallet, full of bitcoin!");
                    do
                    {
                        Console.WriteLine(" Do you take the Bitcoin wallet?");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(" yes or no");
                        Console.ForegroundColor = ConsoleColor.White;

                        input = Console.ReadLine();
                    } while (input != "yes" && input != "no");

                    if (input == "yes")
                    {
                        Console.WriteLine("\n You grab the bitcoin wallet and put it in your pocket");
                        bitcoinWallet = 1;
                    }
                    else
                    {
                        Console.WriteLine("\n You leave the bitcoin wallet where it is. No need to steal now.");
                    }
                    officeid = 1;

                }
                // Implement logic to reward the player or move to the next part of the game

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" Press Enter To Continue");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                difficulty++;
                Console.Clear();
                Console.WriteLine(" You've been kicked out into the hallway"); //Added here since you get kicked out here everytime to kill a boss

                callroom();

            }
        }

        static void TipsMenu()
        {
          Console.Clear();
            Console.WriteLine("                 Tip Menu ");
            Console.WriteLine("____________________________________________________");
            Console.WriteLine(" When your energy is low you will not be able attack");
            Console.WriteLine(" Only way to gain enery to choose the gain enery option ");
            Console.WriteLine(" but you might sustain damage if enemy decides to attack and you might die");
            Console.WriteLine("\n You energy for ");
            Console.WriteLine("\n The chances of missing each attack is:");
            Console.WriteLine("\n 1: Strong Attack 84 % \n2: Medium Attack 50% \n3: Low Attack 25% ");
            Console.WriteLine("\n\n To activate the charge attack you must choose the option twice and deals\ndamage on the enemy between 50 and 80");
            Console.WriteLine("\n The chances of missing each attack is :");
            Console.WriteLine("\n 1: Strong Attack 84% \n2: Medium Attack 50% \n3: Low Attack 25% ");
            Console.WriteLine("\n\n To activate the charge attack you must choose the option twice and deals\ndamage on the enemy between 50 and 80");
            Console.ReadLine();
            Console.Clear();
        }


        static void enemyAttack()
        {
            Random random = new Random();
            int hit = random.Next(101);
            int enemyChoice = random.Next(1, 5);

            switch (enemyChoice)
            {
                case 1:
                    {
                        damage = 30;
                        if (hit > 75)
                            if (damage < armour)
                            {
                                health = damage * 0.05;
                            }
                            else
                            {
                                health -= (damage - armour);
                            }
                        else Console.WriteLine(" Enemy missed.\n");
                        break;//replace enemy name with one from a list
                    }
                case 2:
                    {
                        damage = 20;
                        if (hit > 50)
                            if (damage < armour)
                            {
                                health = damage * 0.05;
                            }
                            else
                            {
                                health -= (damage - armour);
                            }
                        else Console.WriteLine(" Enemy missed.\n");
                        break;
                    }
                case 3:
                    {
                        damage = 10;
                        if (hit > 25)
                            if (damage < armour)
                            {
                                health = damage * 0.05;
                            }
                            else
                            {
                                health -= (damage - armour);
                            }
                        else Console.WriteLine(" Enemy missed.\n");
                        break;
                    }
                case 4:
                    {
                        damage = 5;
                        if (hit > 1)
                            if (damage < armour)
                            {
                                health = damage * 0.05;
                            }
                            else
                            {
                                health -= (damage - armour);
                            }
                        else Console.WriteLine(" Enemy missed.\n");
                        break;
                    }
            }
        }
        static void Win()
        {
            //To be attached to the final room
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n  █████ █████                        █████   ███   █████  ███             ███\r\n░░███ ░░███                        ░░███   ░███  ░░███  ░░░             ░███\r\n ░░███ ███    ██████  █████ ████    ░███   ░███   ░███  ████  ████████  ░███\r\n  ░░█████    ███░░███░░███ ░███     ░███   ░███   ░███ ░░███ ░░███░░███ ░███\r\n   ░░███    ░███ ░███ ░███ ░███     ░░███  █████  ███   ░███  ░███ ░███ ░███\r\n    ░███    ░███ ░███ ░███ ░███      ░░░█████░█████░    ░███  ░███ ░███ ░░░ \r\n    █████   ░░██████  ░░████████       ░░███ ░░███      █████ ████ █████ ███\r\n   ░░░░░     ░░░░░░    ░░░░░░░░         ░░░   ░░░      ░░░░░ ░░░░ ░░░░░ ░░░ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" You acheved {achev}/3 achevments");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("\n Would you like to play again (yes or no)?");
            string temp = Console.ReadLine().ToLower();
            switch (temp)
            {
                case "yes":
                case "y":
                    Main();
                    break;
                case "no":
                case "n":
                    break;
            }

            Thread.Sleep(3000);
            Environment.Exit(0);
        }
        static void Lose()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n  █████ █████                        ██████████    ███               █████ ███\r\n░░███ ░░███                        ░░███░░░░███  ░░░               ░░███ ░███\r\n ░░███ ███    ██████  █████ ████    ░███   ░░███ ████   ██████   ███████ ░███\r\n  ░░█████    ███░░███░░███ ░███     ░███    ░███░░███  ███░░███ ███░░███ ░███\r\n   ░░███    ░███ ░███ ░███ ░███     ░███    ░███ ░███ ░███████ ░███ ░███ ░███\r\n    ░███    ░███ ░███ ░███ ░███     ░███    ███  ░███ ░███░░░  ░███ ░███ ░░░ \r\n    █████   ░░██████  ░░████████    ██████████   █████░░██████ ░░████████ ███\r\n   ░░░░░     ░░░░░░    ░░░░░░░░    ░░░░░░░░░░   ░░░░░  ░░░░░░   ░░░░░░░░ ░░░ ");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("\n Would you like to play again (yes or no)?");
            string temp = Console.ReadLine().ToLower();
            switch (temp)
            {
                case "yes":
                case "y":
                    Main();
                    break;
                case "no":
                case "n":
                    break;
            }

            Thread.Sleep(3000);
            Environment.Exit(0);
        }
    }
}
string box11 = " ";
string box12 = " ";
string box13 = " ";
string box21 = " ";
string box22 = " ";
string box23 = " ";
string box31 = " ";
string box32 = " ";
string box33 = " ";

string playerx = null;
string playero = null;

ushort round = 0;
string choice;

bool validChoice = true;
Console.WriteLine("Please enter the name of the X Player");
playerx = Console.ReadLine();
Console.WriteLine("Please enter the name of the O Player");
playero = Console.ReadLine();

Console.WriteLine(playerx + " will go first");
startingScreen();
Console.WriteLine("Each box has a cordinate representation\nThe top left box is 11 the top middle is 12 the top right is 13");
Console.WriteLine("The second row is 21, 22, 23");
Console.WriteLine("And the Third row is 31,32,33");
Console.WriteLine("Type the cordinants of the location you want to claim");
while (round < 9)
{
    if (round % 2 == 0)
    {
        Console.WriteLine(playerx + " your turn");
        choice = Console.ReadLine();
        if (choice == "11")
        {
            if (box11 == " ")
                box11 = "X";
        }
        else if (choice == "12")
        {
            if (box12 == " ")
                box12 = "X";
        }
        else if (choice == "13")
        {
            if (box13 == " ")
                box13 = "X";
        }
        else if (choice == "21")
        {
            if (box21 == " ")
                box21 = "X";
        }
        else if (choice == "22")
        {
            if (box22 == " ")
                box22 = "X";
        }
        else if (choice == "23")
        {
            if (box23 == " ")
                box23 = "X";
        }
        else if (choice == "31")
        {
            if (box31 == " ")
                box31 = "X";
        }
        else if (choice == "32")
        {
            if (box32 == " ")
                box32 = "X";
        }
        else if (choice == "33")
        {
            if (box33 == " ")
                box33 = "X";
        }
        else
        {
            Console.WriteLine("Invalid Location");
        }

    }
    else
    {
        Console.WriteLine(playero + " Your turn");
        choice = Console.ReadLine();
        if (choice == "11")
        {
            if (box11 == " ")
                box11 = "O";
        }
        else if (choice == "12")
        {
            if (box12 == " ")
                box12 = "O";
        }
        else if (choice == "13")
        {
            if (box13 == " ")
                box13 = "O";
        }
        else if (choice == "21")
        {
            if (box21 == " ")
                box21 = "O";
        }
        else if (choice == "22")
        {
            if (box22 == " ")
                box22 = "O";
        }
        else if (choice == "23")
        {
            if (box23 == " ")
                box23 = "O";
        }
        else if (choice == "31")
        {
            if (box31 == " ")
                box31 = "O";
        }
        else if (choice == "32")
        {
            if (box32 == " ")
                box32 = "O";
        }
        else if (choice == "33")
        {
            if (box33 == " ")
                box33 = "O";
        }
        else
        {
            Console.WriteLine("Invalid Location");
        }
    }
    if (xWon())
    {
        Console.WriteLine(playerx + " You Won Way to go.");
        round = 9;
    }
    else if (oWon())
    {
        Console.WriteLine(playero + " You Won Way to go.");
        round =9;
    }
    else if (round == 8)
    {
        Console.WriteLine("No One Won");
    }
    printScreen();
    round++;
}

void printScreen()
{
    if (box11 != null)
    {
        Console.Write(box11 + "|");
    }
    if (box12 != null)
    {
        Console.Write(box12 + "|");
    }
    if (box13 != null)
    {
        Console.WriteLine(box13);
        Console.WriteLine("- - -");
    }
    if (box21 != null)
    {
        Console.Write(box21 + "|");
    }
    if (box22 != null)
    {
        Console.Write(box22 + "|");
    }
    if (box23 != null)
    {
        Console.WriteLine(box23);
        Console.WriteLine("- - -");
    }
    if (box31 != null)
    {
        Console.Write(box31 + "|");
    }
    if (box32 != null)
    {
        Console.Write(box32 + "|");
    }
    if (box33 != null)
    {
        Console.WriteLine(box33);
    }

}

void startingScreen()
{
    Console.WriteLine("11|12|13");
    Console.WriteLine("-- -- --");
    Console.WriteLine("21|22|23");
    Console.WriteLine("-- -- --");
    Console.WriteLine("31|32|33");
}


// 8 possible win states
bool xWon()
{
    if (box11 == "X" && box12 == "X" && box13 == "X")
        return true;
    else if (box21 == "X" && box22 == "X" && box23 == "X")
        return true;
    else if (box31 == "X" && box32 == "X" && box33 == "X")
        return true;
    else if (box11 == "X" && box21 == "X" && box31 == "X")
        return true;
    else if (box12 == "X" && box22 == "X" && box32 == "X")
        return true;
    else if (box13 == "X" && box23 == "X" && box33 == "X")
        return true;
    else if (box11 == "X" && box22 == "X" && box33 == "X")
        return true;
    else if (box31 == "X" && box22 == "X" && box13 == "X")
        return true;
    else
        return false;
}

bool oWon()
{
    if (box11 == "O" && box12 == "O" && box13 == "O")
        return true;
    else if (box21 == "O" && box22 == "O" && box23 == "O")
        return true;
    else if (box31 == "O" && box32 == "O" && box33 == "O")
        return true;
    else if (box11 == "O" && box21 == "O" && box31 == "O")
        return true;
    else if (box12 == "O" && box22 == "O" && box32 == "O")
        return true;
    else if (box13 == "O" && box23 == "O" && box33 == "O")
        return true;
    else if (box11 == "O" && box22 == "O" && box33 == "O")
        return true;
    else if (box31 == "O" && box22 == "O" && box13 == "O")
        return true;
    else
        return false;
}

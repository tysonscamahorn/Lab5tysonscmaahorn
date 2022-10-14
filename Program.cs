void cat(){
Console.WriteLine(@"    /\__/\");
Console.WriteLine(@"   /      \");
Console.WriteLine(@"  /  0  0  \");
Console.WriteLine(@"  \    m   /");
Console.WriteLine(@"   \      /");
Console.WriteLine(@"   |      |");
Console.WriteLine(@"  /        \ ");
Console.WriteLine(@" /          \");
Console.WriteLine(@"|            |");
Console.WriteLine(@"|  |      |  |\");
Console.WriteLine(@"|  |      |  | \");
Console.WriteLine(@"|  |      |  |\ \");
Console.WriteLine(@"|  |______|  | \ \");
Console.WriteLine(@"UUU        UUU");
}
cat();
Console.WriteLine("Do you like the picture of my cat, yes or no");
string answer = (Console.ReadLine ());
    if (answer == "yes")
    {
        Console.WriteLine ("Thank you so much");

    } 
    if (answer != "yes"){
        Console.WriteLine ("you are wrong");
    }
    
Console.WriteLine ("5+6=");
int x = 5;
int y = 6;
int sum = x + y;
Console.WriteLine(sum); // Print the sum of x + y

Console.WriteLine("500-200=");
int b = 500;
int c = 200;
int difference = b - c ;
Console.WriteLine(difference);

Console.WriteLine("234 * 567 =");
int e = 234;
int f = 567;
int multiple = e * f ;
Console.WriteLine(multiple);

Console.WriteLine("789 / 15 =");
int g = 789;
int h = 15;
int divide = g / h ;
Console.WriteLine(divide);


bool terminate = true;
 while(terminate == true)
 {
     int one;
     int two;
    Console.WriteLine ("please choose your operator, type out add, subtract, multiply, or divide.");
    Console.WriteLine("type exit to end.");
    string opperator = Console.ReadLine();
     Console.WriteLine("please chose your first number");
     one = int.Parse(Console.ReadLine());
     Console.WriteLine("please chose your second number");
     two = int.Parse(Console.ReadLine());
   if(opperator == "exit")
    {
        terminate = false;
        Console.WriteLine("thank you for playing");
        break;
    }
    if(opperator == "add"){
        Console.WriteLine(one+two);
    }
    if(opperator == "subtract"){
        Console.WriteLine(one-two);
    }
    if(opperator == "multiply"){
        Console.WriteLine(one*two);
    }
    if(opperator == "divide"){
        Console.WriteLine(one/two);
    }
 }
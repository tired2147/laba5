
Console.WriteLine("Введите а:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Введите знак (+, -, *, /):");
string znak = Console.ReadLine();

switch (znak)
{
    case "+":
        Console.WriteLine("Ответ: " + (a + b));
        break;
    case "-":
        Console.WriteLine("Ответ: " + (a - b));
        break;
    case "*":
        Console.WriteLine("Ответ: " + (a * b));
        break;
    case "/":
        Console.WriteLine("Ответ: " + (a / b));
        break;

}

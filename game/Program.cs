

string duzgunSoz = "Baku";
int haqq = 5;

Console.WriteLine("Duzgun cavabi daxil edin:");
string cavab = Console.ReadLine();
while (haqq >0)
{
    if (cavab == duzgunSoz)
    {
        Console.WriteLine("Tebrikler cavab dogrudur");
        break;
    }
    else
    {
        haqq--;
        Console.WriteLine($"Cavab sehfdir. Qalan haqqinizin say; {haqq}");
        Console.WriteLine("Bir daha sinayin");
        cavab = Console.ReadLine();
    }

    if (haqq == 0)
    {
        Console.WriteLine("Meqlub oldunuz");
    }
    Console.ReadLine();
}
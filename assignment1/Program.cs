decimal invoice = 0;
decimal discount = 0;
Console.WriteLine("enter the invoice amount");
invoice =decimal.Parse(Console.ReadLine());
Console.WriteLine("enter customer type regular / silver /gold");
string type=Console.ReadLine().ToUpper();
if (invoice > 0)
{
    if (type == "REGULAR")
    {
        discount = 5;
        if (invoice > 100)
        {
            discount += 2;
        }

    }
    else if (type == "GOLD")
    {
        discount = 20;
        if (invoice > 100)
        {
            discount += 5;
        }
    }
    else if (type == "SILVER")
    {
        discount = 10;
        if (invoice > 100)
        {
            discount += 3;
        }
    }
    else
    {
        Console.WriteLine("invalid type");
        return;
    }
}
else { Console.WriteLine("invalid amount"); return; }

invoice = invoice -(invoice * (discount / 100));
Console.WriteLine($"the total discount you have it {discount}%\nthe invoice after discount ={invoice}");
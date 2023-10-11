using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone phone = new Iphone("+55 10 555-2345", "15", "IMEI15", 128);

phone.Ligar();
phone.ReceberLigacao();
phone.InstalarAplicativo("Whatsapp");

Smartphone nokia = new Nokia("+55 10 555-5432", "2133", "IMEINK2133", 16);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");
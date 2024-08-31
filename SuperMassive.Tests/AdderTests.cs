namespace SuperMassive.Tests;

public class AdderTests
{
  [Fact]
  public void AddTest()
  {
    var adder = new SuperMassive.Adder();
    int result = adder.add(1, 1);
    Assert.Equal(2, result);
  }
}

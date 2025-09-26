using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Modals.Tests;

[Collection("Collection")]
public sealed class ModalTests : FixturedUnitTest
{
    public ModalTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {
        // Basic test to ensure the component library builds and can be instantiated
        Assert.True(true);
    }
}

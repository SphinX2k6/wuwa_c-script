using System;
using System.Runtime.CompilerServices;

// Token: 0x020002BE RID: 702
[NullableContext(1)]
[Nullable(0)]
public class GlobalProductContentData
{
	// Token: 0x04002830 RID: 10288
	public string local = "";

	// Token: 0x04002831 RID: 10289
	public string coin = "";

	// Token: 0x04002832 RID: 10290
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public GlobalProductPriceItem[] price;

	// Token: 0x04002833 RID: 10291
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public AndroidGlobalProductContentPriceData[] PriceItem;
}

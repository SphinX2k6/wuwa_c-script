using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E0B RID: 3595
[NullableContext(1)]
[Nullable(0)]
public class GlobalProductContentData
{
	// Token: 0x0400279F RID: 10143
	public string local = "";

	// Token: 0x040027A0 RID: 10144
	public string coin = "";

	// Token: 0x040027A1 RID: 10145
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public GlobalProductPriceItem[] price;

	// Token: 0x040027A2 RID: 10146
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public AndroidGlobalProductContentPriceData[] PriceItem;
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02001B74 RID: 7028
[NullableContext(1)]
[Nullable(0)]
public struct FloroRanchShopTipViewParam
{
	// Token: 0x04005FF1 RID: 24561
	public int ToyPoint;

	// Token: 0x04005FF2 RID: 24562
	public Action<int> SellCallback;

	// Token: 0x04005FF3 RID: 24563
	public Action<bool> ShowToyListCallback;
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02001033 RID: 4147
[NullableContext(1)]
[Nullable(0)]
public struct FloroRanchShopTipViewParam
{
	// Token: 0x040060C0 RID: 24768
	public int ToyPoint;

	// Token: 0x040060C1 RID: 24769
	public Action<int> SellCallback;

	// Token: 0x040060C2 RID: 24770
	public Action<bool> ShowToyListCallback;
}

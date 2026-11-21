using System;
using System.Runtime.CompilerServices;

// Token: 0x020014A5 RID: 5285
public class ItemRewardSelectViewOpenParam
{
	// Token: 0x0400770F RID: 30479
	public int GiftPackageId;

	// Token: 0x04007710 RID: 30480
	public int ShowType;

	// Token: 0x04007711 RID: 30481
	public int AccumulateSourceId;

	// Token: 0x04007712 RID: 30482
	[Nullable(2)]
	public Action<int, int> OnSelectItemCallBack;
}

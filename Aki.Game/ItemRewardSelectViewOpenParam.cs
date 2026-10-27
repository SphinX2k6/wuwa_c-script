using System;
using System.Runtime.CompilerServices;

// Token: 0x02001FD2 RID: 8146
public class ItemRewardSelectViewOpenParam
{
	// Token: 0x04007626 RID: 30246
	public int GiftPackageId;

	// Token: 0x04007627 RID: 30247
	public int ShowType;

	// Token: 0x04007628 RID: 30248
	public int AccumulateSourceId;

	// Token: 0x04007629 RID: 30249
	[Nullable(2)]
	public Action<int, int> OnSelectItemCallBack;
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x020014B7 RID: 5303
[NullableContext(2)]
[Nullable(0)]
public class PhantomStackCountPopupData
{
	// Token: 0x04007748 RID: 30536
	[Nullable(1)]
	public string FrameTitleText = "";

	// Token: 0x04007749 RID: 30537
	[Nullable(1)]
	public string TitleText = "";

	// Token: 0x0400774A RID: 30538
	public int IncId;

	// Token: 0x0400774B RID: 30539
	public int MaxCount = 1;

	// Token: 0x0400774C RID: 30540
	public int MinCount = 1;

	// Token: 0x0400774D RID: 30541
	public int InitCount = 1;

	// Token: 0x0400774E RID: 30542
	public string TipsText;

	// Token: 0x0400774F RID: 30543
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<int, TableTextArgNew> GetCountText;

	// Token: 0x04007750 RID: 30544
	public string ConfirmText;

	// Token: 0x04007751 RID: 30545
	public string CancelText;

	// Token: 0x04007752 RID: 30546
	public Action<int> OnConfirm;

	// Token: 0x04007753 RID: 30547
	public Action OnCancel;
}

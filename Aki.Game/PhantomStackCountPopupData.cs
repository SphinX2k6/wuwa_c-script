using System;
using System.Runtime.CompilerServices;

// Token: 0x02001FE4 RID: 8164
[NullableContext(2)]
[Nullable(0)]
public class PhantomStackCountPopupData
{
	// Token: 0x0400765F RID: 30303
	[Nullable(1)]
	public string FrameTitleText = "";

	// Token: 0x04007660 RID: 30304
	[Nullable(1)]
	public string TitleText = "";

	// Token: 0x04007661 RID: 30305
	public int IncId;

	// Token: 0x04007662 RID: 30306
	public int MaxCount = 1;

	// Token: 0x04007663 RID: 30307
	public int MinCount = 1;

	// Token: 0x04007664 RID: 30308
	public int InitCount = 1;

	// Token: 0x04007665 RID: 30309
	public string TipsText;

	// Token: 0x04007666 RID: 30310
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<int, TableTextArgNew> GetCountText;

	// Token: 0x04007667 RID: 30311
	public string ConfirmText;

	// Token: 0x04007668 RID: 30312
	public string CancelText;

	// Token: 0x04007669 RID: 30313
	public Action<int> OnConfirm;

	// Token: 0x0400766A RID: 30314
	public Action OnCancel;
}

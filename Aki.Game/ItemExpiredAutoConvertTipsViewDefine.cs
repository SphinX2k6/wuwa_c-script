using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020014A4 RID: 5284
[NullableContext(1)]
[Nullable(0)]
public class ItemExpiredAutoConvertTipsViewDefine
{
	// Token: 0x04007706 RID: 30470
	public string TitleText = "";

	// Token: 0x04007707 RID: 30471
	public string BeforeTitleText = "";

	// Token: 0x04007708 RID: 30472
	public string AfterTitleText = "";

	// Token: 0x04007709 RID: 30473
	public IReadOnlyList<TItem> BeforeItemList = Array.Empty<TItem>();

	// Token: 0x0400770A RID: 30474
	public IReadOnlyList<TItem> AfterItemList = Array.Empty<TItem>();

	// Token: 0x0400770B RID: 30475
	public string CancelButtonText = "";

	// Token: 0x0400770C RID: 30476
	public string ConfirmButtonText = "";

	// Token: 0x0400770D RID: 30477
	[Nullable(2)]
	public Action<int> OnCancelCallBack;

	// Token: 0x0400770E RID: 30478
	[Nullable(2)]
	public Action<int> OnConfirmCallBack;
}

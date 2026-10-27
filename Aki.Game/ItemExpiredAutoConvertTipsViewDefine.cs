using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001FD1 RID: 8145
[NullableContext(1)]
[Nullable(0)]
public class ItemExpiredAutoConvertTipsViewDefine
{
	// Token: 0x0400761D RID: 30237
	public string TitleText = "";

	// Token: 0x0400761E RID: 30238
	public string BeforeTitleText = "";

	// Token: 0x0400761F RID: 30239
	public string AfterTitleText = "";

	// Token: 0x04007620 RID: 30240
	public IReadOnlyList<TItem> BeforeItemList = Array.Empty<TItem>();

	// Token: 0x04007621 RID: 30241
	public IReadOnlyList<TItem> AfterItemList = Array.Empty<TItem>();

	// Token: 0x04007622 RID: 30242
	public string CancelButtonText = "";

	// Token: 0x04007623 RID: 30243
	public string ConfirmButtonText = "";

	// Token: 0x04007624 RID: 30244
	[Nullable(2)]
	public Action<int> OnCancelCallBack;

	// Token: 0x04007625 RID: 30245
	[Nullable(2)]
	public Action<int> OnConfirmCallBack;
}

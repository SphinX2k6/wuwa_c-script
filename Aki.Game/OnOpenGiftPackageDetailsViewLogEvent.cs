using System;
using System.Runtime.CompilerServices;

// Token: 0x020015CC RID: 5580
[NullableContext(1)]
[Nullable(0)]
public class OnOpenGiftPackageDetailsViewLogEvent : PlayerCommonLogData
{
	// Token: 0x170014C8 RID: 5320
	// (get) Token: 0x0600DD8B RID: 56715 RVA: 0x00417767 File Offset: 0x00415967
	// (set) Token: 0x0600DD8C RID: 56716 RVA: 0x0041776F File Offset: 0x0041596F
	public override string event_id { get; set; } = "1828";

	// Token: 0x04007D3F RID: 32063
	public int i_id;

	// Token: 0x04007D40 RID: 32064
	public int i_shop_id;

	// Token: 0x04007D41 RID: 32065
	public int i_tab_id;

	// Token: 0x04007D42 RID: 32066
	public int i_buy_through_third_party;
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x020015CD RID: 5581
[NullableContext(1)]
[Nullable(0)]
public class OnClickPayShopItemLogEvent : PlayerCommonLogData
{
	// Token: 0x170014C9 RID: 5321
	// (get) Token: 0x0600DD8E RID: 56718 RVA: 0x0041778B File Offset: 0x0041598B
	// (set) Token: 0x0600DD8F RID: 56719 RVA: 0x00417793 File Offset: 0x00415993
	public override string event_id { get; set; } = "1829";

	// Token: 0x04007D44 RID: 32068
	public int i_id;

	// Token: 0x04007D45 RID: 32069
	public int i_shop_id;

	// Token: 0x04007D46 RID: 32070
	public int i_tab_id;
}

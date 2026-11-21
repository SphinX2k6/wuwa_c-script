using System;
using System.Runtime.CompilerServices;

// Token: 0x020015C9 RID: 5577
[NullableContext(1)]
[Nullable(0)]
public class OnClickPayShopTabLogEvent : PlayerCommonLogData
{
	// Token: 0x170014C5 RID: 5317
	// (get) Token: 0x0600DD82 RID: 56706 RVA: 0x004176FB File Offset: 0x004158FB
	// (set) Token: 0x0600DD83 RID: 56707 RVA: 0x00417703 File Offset: 0x00415903
	public override string event_id { get; set; } = "1826";

	// Token: 0x04007D36 RID: 32054
	public int i_shop_id;

	// Token: 0x04007D37 RID: 32055
	public int i_tab_id;
}

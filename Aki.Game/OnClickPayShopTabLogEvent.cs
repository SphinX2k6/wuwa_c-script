using System;
using System.Runtime.CompilerServices;

// Token: 0x020020F2 RID: 8434
[NullableContext(1)]
[Nullable(0)]
public class OnClickPayShopTabLogEvent : PlayerCommonLogData
{
	// Token: 0x17001498 RID: 5272
	// (get) Token: 0x06010912 RID: 67858 RVA: 0x0040AFEB File Offset: 0x004091EB
	// (set) Token: 0x06010913 RID: 67859 RVA: 0x0040AFF3 File Offset: 0x004091F3
	public override string event_id { get; set; } = "1826";

	// Token: 0x04007C37 RID: 31799
	public int i_shop_id;

	// Token: 0x04007C38 RID: 31800
	public int i_tab_id;
}

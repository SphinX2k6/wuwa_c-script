using System;
using System.Runtime.CompilerServices;

// Token: 0x020020F5 RID: 8437
[NullableContext(1)]
[Nullable(0)]
public class OnClickPayShopItemLogEvent : PlayerCommonLogData
{
	// Token: 0x1700149B RID: 5275
	// (get) Token: 0x0601091B RID: 67867 RVA: 0x0040B057 File Offset: 0x00409257
	// (set) Token: 0x0601091C RID: 67868 RVA: 0x0040B05F File Offset: 0x0040925F
	public override string event_id { get; set; } = "1829";

	// Token: 0x04007C42 RID: 31810
	public int i_id;

	// Token: 0x04007C43 RID: 31811
	public int i_shop_id;

	// Token: 0x04007C44 RID: 31812
	public int i_tab_id;
}

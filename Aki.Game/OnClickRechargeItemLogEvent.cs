using System;
using System.Runtime.CompilerServices;

// Token: 0x020020F6 RID: 8438
[NullableContext(1)]
[Nullable(0)]
public class OnClickRechargeItemLogEvent : PlayerCommonLogData
{
	// Token: 0x1700149C RID: 5276
	// (get) Token: 0x0601091E RID: 67870 RVA: 0x0040B07B File Offset: 0x0040927B
	// (set) Token: 0x0601091F RID: 67871 RVA: 0x0040B083 File Offset: 0x00409283
	public override string event_id { get; set; } = "1830";

	// Token: 0x04007C46 RID: 31814
	public int i_id;

	// Token: 0x04007C47 RID: 31815
	public int i_shop_id;
}

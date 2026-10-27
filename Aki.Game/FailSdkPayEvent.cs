using System;
using System.Runtime.CompilerServices;

// Token: 0x020020E8 RID: 8424
[NullableContext(1)]
[Nullable(0)]
public class FailSdkPayEvent : PlayerCommonLogData
{
	// Token: 0x1700148E RID: 5262
	// (get) Token: 0x060108F4 RID: 67828 RVA: 0x0040AE57 File Offset: 0x00409057
	// (set) Token: 0x060108F5 RID: 67829 RVA: 0x0040AE5F File Offset: 0x0040905F
	public override string event_id { get; set; } = "1042";

	// Token: 0x04007C1B RID: 31771
	public string s_sdk_pay_order = "";

	// Token: 0x04007C1C RID: 31772
	public string s_reason = "";
}

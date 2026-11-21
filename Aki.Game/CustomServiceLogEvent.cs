using System;
using System.Runtime.CompilerServices;

// Token: 0x0200160C RID: 5644
[NullableContext(1)]
[Nullable(0)]
public class CustomServiceLogEvent : PlayerCommonLogData
{
	// Token: 0x17001508 RID: 5384
	// (get) Token: 0x0600DE4B RID: 56907 RVA: 0x0041828E File Offset: 0x0041648E
	// (set) Token: 0x0600DE4C RID: 56908 RVA: 0x00418296 File Offset: 0x00416496
	public override string event_id { get; set; } = "1810";

	// Token: 0x04007E53 RID: 32339
	public string s_trace_id = "";

	// Token: 0x04007E54 RID: 32340
	public int log_status;
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02002134 RID: 8500
[NullableContext(1)]
[Nullable(0)]
public class CustomServiceLogEvent : PlayerCommonLogData
{
	// Token: 0x170014DA RID: 5338
	// (get) Token: 0x060109D8 RID: 68056 RVA: 0x0040BB46 File Offset: 0x00409D46
	// (set) Token: 0x060109D9 RID: 68057 RVA: 0x0040BB4E File Offset: 0x00409D4E
	public override string event_id { get; set; } = "1810";

	// Token: 0x04007D43 RID: 32067
	public string s_trace_id = "";

	// Token: 0x04007D44 RID: 32068
	public int log_status;
}

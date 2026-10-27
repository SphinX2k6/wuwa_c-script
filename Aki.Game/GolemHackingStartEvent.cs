using System;
using System.Runtime.CompilerServices;

// Token: 0x02002165 RID: 8549
[NullableContext(1)]
[Nullable(0)]
public class GolemHackingStartEvent : PlayerCommonLogData
{
	// Token: 0x17001507 RID: 5383
	// (get) Token: 0x06010A63 RID: 68195 RVA: 0x0040C30E File Offset: 0x0040A50E
	// (set) Token: 0x06010A64 RID: 68196 RVA: 0x0040C316 File Offset: 0x0040A516
	public override string event_id { get; set; } = "1921";

	// Token: 0x04007E3D RID: 32317
	public int i_id;

	// Token: 0x04007E3E RID: 32318
	public int i_type;

	// Token: 0x04007E3F RID: 32319
	public int i_first_pass;

	// Token: 0x04007E40 RID: 32320
	public string s_trace_id = "";
}

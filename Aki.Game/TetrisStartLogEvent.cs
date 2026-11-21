using System;
using System.Runtime.CompilerServices;

// Token: 0x020015ED RID: 5613
[NullableContext(1)]
[Nullable(0)]
public class TetrisStartLogEvent : PlayerCommonLogData
{
	// Token: 0x170014E9 RID: 5353
	// (get) Token: 0x0600DDEE RID: 56814 RVA: 0x00417C83 File Offset: 0x00415E83
	// (set) Token: 0x0600DDEF RID: 56815 RVA: 0x00417C8B File Offset: 0x00415E8B
	public override string event_id { get; set; } = "1913";

	// Token: 0x04007DAF RID: 32175
	public int i_activity_id;

	// Token: 0x04007DB0 RID: 32176
	public int i_inst_id;

	// Token: 0x04007DB1 RID: 32177
	public int i_type;

	// Token: 0x04007DB2 RID: 32178
	public int i_first_pass;

	// Token: 0x04007DB3 RID: 32179
	public string s_trace_id = "";
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x02002115 RID: 8469
[NullableContext(1)]
[Nullable(0)]
public class TetrisStartLogEvent : PlayerCommonLogData
{
	// Token: 0x170014BB RID: 5307
	// (get) Token: 0x0601097B RID: 67963 RVA: 0x0040B54F File Offset: 0x0040974F
	// (set) Token: 0x0601097C RID: 67964 RVA: 0x0040B557 File Offset: 0x00409757
	public override string event_id { get; set; } = "1913";

	// Token: 0x04007CAD RID: 31917
	public int i_activity_id;

	// Token: 0x04007CAE RID: 31918
	public int i_inst_id;

	// Token: 0x04007CAF RID: 31919
	public int i_type;

	// Token: 0x04007CB0 RID: 31920
	public int i_first_pass;

	// Token: 0x04007CB1 RID: 31921
	public string s_trace_id = "";
}

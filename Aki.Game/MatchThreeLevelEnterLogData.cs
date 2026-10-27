using System;
using System.Runtime.CompilerServices;

// Token: 0x02002182 RID: 8578
[NullableContext(1)]
[Nullable(0)]
public class MatchThreeLevelEnterLogData : PlayerCommonLogData
{
	// Token: 0x17001520 RID: 5408
	// (get) Token: 0x06010AB2 RID: 68274 RVA: 0x0040C76A File Offset: 0x0040A96A
	// (set) Token: 0x06010AB3 RID: 68275 RVA: 0x0040C772 File Offset: 0x0040A972
	public override string event_id { get; set; } = "1942";

	// Token: 0x04007ED9 RID: 32473
	public int i_activity_id;

	// Token: 0x04007EDA RID: 32474
	public int i_activity_type;

	// Token: 0x04007EDB RID: 32475
	public int i_level_id;

	// Token: 0x04007EDC RID: 32476
	public int i_inst_diff;

	// Token: 0x04007EDD RID: 32477
	public string s_trace_id = "";

	// Token: 0x04007EDE RID: 32478
	public int i_role_id;

	// Token: 0x04007EDF RID: 32479
	public int i_i_first_pass;
}

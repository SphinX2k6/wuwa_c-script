using System;
using System.Runtime.CompilerServices;

// Token: 0x0200165A RID: 5722
[NullableContext(1)]
[Nullable(0)]
public class MatchThreeLevelEnterLogData : PlayerCommonLogData
{
	// Token: 0x1700154E RID: 5454
	// (get) Token: 0x0600DF25 RID: 57125 RVA: 0x00418EB2 File Offset: 0x004170B2
	// (set) Token: 0x0600DF26 RID: 57126 RVA: 0x00418EBA File Offset: 0x004170BA
	public override string event_id { get; set; } = "1942";

	// Token: 0x04007FE9 RID: 32745
	public int i_activity_id;

	// Token: 0x04007FEA RID: 32746
	public int i_activity_type;

	// Token: 0x04007FEB RID: 32747
	public int i_level_id;

	// Token: 0x04007FEC RID: 32748
	public int i_inst_diff;

	// Token: 0x04007FED RID: 32749
	public string s_trace_id = "";

	// Token: 0x04007FEE RID: 32750
	public int i_role_id;

	// Token: 0x04007FEF RID: 32751
	public int i_i_first_pass;
}

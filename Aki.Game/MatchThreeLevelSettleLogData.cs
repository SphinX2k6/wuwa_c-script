using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200165B RID: 5723
[NullableContext(1)]
[Nullable(0)]
public class MatchThreeLevelSettleLogData : PlayerCommonLogData
{
	// Token: 0x1700154F RID: 5455
	// (get) Token: 0x0600DF28 RID: 57128 RVA: 0x00418EE1 File Offset: 0x004170E1
	// (set) Token: 0x0600DF29 RID: 57129 RVA: 0x00418EE9 File Offset: 0x004170E9
	public override string event_id { get; set; } = "1943";

	// Token: 0x04007FF1 RID: 32753
	public int i_activity_id;

	// Token: 0x04007FF2 RID: 32754
	public int i_activity_type;

	// Token: 0x04007FF3 RID: 32755
	public int i_level_id;

	// Token: 0x04007FF4 RID: 32756
	public int i_inst_diff;

	// Token: 0x04007FF5 RID: 32757
	public string s_trace_id = "";

	// Token: 0x04007FF6 RID: 32758
	public int i_role_id;

	// Token: 0x04007FF7 RID: 32759
	public int i_result;

	// Token: 0x04007FF8 RID: 32760
	public int i_reason;

	// Token: 0x04007FF9 RID: 32761
	public int i_score;

	// Token: 0x04007FFA RID: 32762
	public int i_score_limit;

	// Token: 0x04007FFB RID: 32763
	public int i_round;

	// Token: 0x04007FFC RID: 32764
	public int i_count;

	// Token: 0x04007FFD RID: 32765
	public int i_first_pass;

	// Token: 0x04007FFE RID: 32766
	public int i_cost_time;

	// Token: 0x04007FFF RID: 32767
	public string s_tag = "";

	// Token: 0x04008000 RID: 32768
	public List<MatchThreeTargetDetailData> o_target_detail = new List<MatchThreeTargetDetailData>();
}

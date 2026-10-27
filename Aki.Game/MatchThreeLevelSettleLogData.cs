using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002183 RID: 8579
[NullableContext(1)]
[Nullable(0)]
public class MatchThreeLevelSettleLogData : PlayerCommonLogData
{
	// Token: 0x17001521 RID: 5409
	// (get) Token: 0x06010AB5 RID: 68277 RVA: 0x0040C799 File Offset: 0x0040A999
	// (set) Token: 0x06010AB6 RID: 68278 RVA: 0x0040C7A1 File Offset: 0x0040A9A1
	public override string event_id { get; set; } = "1943";

	// Token: 0x04007EE1 RID: 32481
	public int i_activity_id;

	// Token: 0x04007EE2 RID: 32482
	public int i_activity_type;

	// Token: 0x04007EE3 RID: 32483
	public int i_level_id;

	// Token: 0x04007EE4 RID: 32484
	public int i_inst_diff;

	// Token: 0x04007EE5 RID: 32485
	public string s_trace_id = "";

	// Token: 0x04007EE6 RID: 32486
	public int i_role_id;

	// Token: 0x04007EE7 RID: 32487
	public int i_result;

	// Token: 0x04007EE8 RID: 32488
	public int i_reason;

	// Token: 0x04007EE9 RID: 32489
	public int i_score;

	// Token: 0x04007EEA RID: 32490
	public int i_score_limit;

	// Token: 0x04007EEB RID: 32491
	public int i_round;

	// Token: 0x04007EEC RID: 32492
	public int i_count;

	// Token: 0x04007EED RID: 32493
	public int i_first_pass;

	// Token: 0x04007EEE RID: 32494
	public int i_cost_time;

	// Token: 0x04007EEF RID: 32495
	public string s_tag = "";

	// Token: 0x04007EF0 RID: 32496
	public List<MatchThreeTargetDetailData> o_target_detail = new List<MatchThreeTargetDetailData>();
}

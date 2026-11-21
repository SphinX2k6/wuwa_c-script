using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001627 RID: 5671
[NullableContext(1)]
[Nullable(0)]
public class DrinksGameplayResultLogEvent : PlayerCommonLogData
{
	// Token: 0x17001522 RID: 5410
	// (get) Token: 0x0600DE9A RID: 56986 RVA: 0x0041870F File Offset: 0x0041690F
	// (set) Token: 0x0600DE9B RID: 56987 RVA: 0x00418717 File Offset: 0x00416917
	public override string event_id { get; set; } = "1834";

	// Token: 0x04007EDB RID: 32475
	public int i_activity_id;

	// Token: 0x04007EDC RID: 32476
	public int i_role_id;

	// Token: 0x04007EDD RID: 32477
	public int i_inst_id;

	// Token: 0x04007EDE RID: 32478
	public int i_first_pass;

	// Token: 0x04007EDF RID: 32479
	public int i_result;

	// Token: 0x04007EE0 RID: 32480
	public int i_first_tab;

	// Token: 0x04007EE1 RID: 32481
	public int i_first_count;

	// Token: 0x04007EE2 RID: 32482
	public int i_second_tab;

	// Token: 0x04007EE3 RID: 32483
	public int i_second_count;

	// Token: 0x04007EE4 RID: 32484
	public int i_third_tab = -1;

	// Token: 0x04007EE5 RID: 32485
	public int i_fourth_tab = -1;

	// Token: 0x04007EE6 RID: 32486
	public int i_fifth_tab = -1;

	// Token: 0x04007EE7 RID: 32487
	public int i_cost_time;

	// Token: 0x04007EE8 RID: 32488
	public int i_require_id;

	// Token: 0x04007EE9 RID: 32489
	public List<int> o_score_buff = new List<int>();

	// Token: 0x04007EEA RID: 32490
	public string s_trace_id = "";
}

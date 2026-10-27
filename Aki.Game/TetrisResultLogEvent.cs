using System;
using System.Runtime.CompilerServices;

// Token: 0x02002116 RID: 8470
[NullableContext(1)]
[Nullable(0)]
public class TetrisResultLogEvent : PlayerCommonLogData
{
	// Token: 0x170014BC RID: 5308
	// (get) Token: 0x0601097E RID: 67966 RVA: 0x0040B57E File Offset: 0x0040977E
	// (set) Token: 0x0601097F RID: 67967 RVA: 0x0040B586 File Offset: 0x00409786
	public override string event_id { get; set; } = "1914";

	// Token: 0x04007CB3 RID: 31923
	public int i_activity_id;

	// Token: 0x04007CB4 RID: 31924
	public int i_inst_id;

	// Token: 0x04007CB5 RID: 31925
	public int i_type;

	// Token: 0x04007CB6 RID: 31926
	public int i_first_pass;

	// Token: 0x04007CB7 RID: 31927
	public string s_trace_id = "";

	// Token: 0x04007CB8 RID: 31928
	public int i_if_back;

	// Token: 0x04007CB9 RID: 31929
	public int i_inst_diff;

	// Token: 0x04007CBA RID: 31930
	public int i_result;

	// Token: 0x04007CBB RID: 31931
	public int i_display_mode;

	// Token: 0x04007CBC RID: 31932
	public int i_get_score;

	// Token: 0x04007CBD RID: 31933
	public int i_combo_max;

	// Token: 0x04007CBE RID: 31934
	public string o_reward_items_new = "";

	// Token: 0x04007CBF RID: 31935
	public int i_round;

	// Token: 0x04007CC0 RID: 31936
	public int i_count;

	// Token: 0x04007CC1 RID: 31937
	public int i_cost_time;

	// Token: 0x04007CC2 RID: 31938
	public string i_first_tab = "";

	// Token: 0x04007CC3 RID: 31939
	public string i_second_tab = "";

	// Token: 0x04007CC4 RID: 31940
	public string o_line_end1 = "";

	// Token: 0x04007CC5 RID: 31941
	public string o_line_end2 = "";

	// Token: 0x04007CC6 RID: 31942
	public string o_line_end3 = "";

	// Token: 0x04007CC7 RID: 31943
	public string o_line_end4 = "";

	// Token: 0x04007CC8 RID: 31944
	public string o_line_end5 = "";

	// Token: 0x04007CC9 RID: 31945
	public string o_line_end6 = "";
}

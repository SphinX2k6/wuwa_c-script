using System;
using System.Runtime.CompilerServices;

// Token: 0x02002117 RID: 8471
[NullableContext(1)]
[Nullable(0)]
public class TetrisRoundLogEvent : PlayerCommonLogData
{
	// Token: 0x170014BD RID: 5309
	// (get) Token: 0x06010981 RID: 67969 RVA: 0x0040B61C File Offset: 0x0040981C
	// (set) Token: 0x06010982 RID: 67970 RVA: 0x0040B624 File Offset: 0x00409824
	public override string event_id { get; set; } = "1915";

	// Token: 0x04007CCB RID: 31947
	public int i_activity_id;

	// Token: 0x04007CCC RID: 31948
	public int i_inst_id;

	// Token: 0x04007CCD RID: 31949
	public int i_type;

	// Token: 0x04007CCE RID: 31950
	public int i_first_pass;

	// Token: 0x04007CCF RID: 31951
	public string s_trace_id = "";

	// Token: 0x04007CD0 RID: 31952
	public int i_if_back;

	// Token: 0x04007CD1 RID: 31953
	public int i_inst_diff;

	// Token: 0x04007CD2 RID: 31954
	public int i_round;

	// Token: 0x04007CD3 RID: 31955
	public int i_result;

	// Token: 0x04007CD4 RID: 31956
	public int i_display_mode;

	// Token: 0x04007CD5 RID: 31957
	public int i_get_score;

	// Token: 0x04007CD6 RID: 31958
	public int if_con_combo;

	// Token: 0x04007CD7 RID: 31959
	public int i_combo_max;

	// Token: 0x04007CD8 RID: 31960
	public string o_reward_items_new = "";

	// Token: 0x04007CD9 RID: 31961
	public string i_first_tab = "";

	// Token: 0x04007CDA RID: 31962
	public int i_count;

	// Token: 0x04007CDB RID: 31963
	public int i_cost_time;

	// Token: 0x04007CDC RID: 31964
	public string o_line_start1 = "";

	// Token: 0x04007CDD RID: 31965
	public string o_line_start2 = "";

	// Token: 0x04007CDE RID: 31966
	public string o_line_start3 = "";

	// Token: 0x04007CDF RID: 31967
	public string o_line_start4 = "";

	// Token: 0x04007CE0 RID: 31968
	public string o_line_start5 = "";

	// Token: 0x04007CE1 RID: 31969
	public string o_line_start6 = "";

	// Token: 0x04007CE2 RID: 31970
	public string o_line_start7 = "";

	// Token: 0x04007CE3 RID: 31971
	public string o_line_start8 = "";

	// Token: 0x04007CE4 RID: 31972
	public string o_line_end1 = "";

	// Token: 0x04007CE5 RID: 31973
	public string o_line_end2 = "";

	// Token: 0x04007CE6 RID: 31974
	public string o_line_end3 = "";

	// Token: 0x04007CE7 RID: 31975
	public string o_line_end4 = "";

	// Token: 0x04007CE8 RID: 31976
	public string o_line_end5 = "";

	// Token: 0x04007CE9 RID: 31977
	public string o_line_end6 = "";

	// Token: 0x04007CEA RID: 31978
	public string o_line_end7 = "";

	// Token: 0x04007CEB RID: 31979
	public string o_line_end8 = "";
}

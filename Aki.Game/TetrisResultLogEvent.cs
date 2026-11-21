using System;
using System.Runtime.CompilerServices;

// Token: 0x020015EE RID: 5614
[NullableContext(1)]
[Nullable(0)]
public class TetrisResultLogEvent : PlayerCommonLogData
{
	// Token: 0x170014EA RID: 5354
	// (get) Token: 0x0600DDF1 RID: 56817 RVA: 0x00417CB2 File Offset: 0x00415EB2
	// (set) Token: 0x0600DDF2 RID: 56818 RVA: 0x00417CBA File Offset: 0x00415EBA
	public override string event_id { get; set; } = "1914";

	// Token: 0x04007DB5 RID: 32181
	public int i_activity_id;

	// Token: 0x04007DB6 RID: 32182
	public int i_inst_id;

	// Token: 0x04007DB7 RID: 32183
	public int i_type;

	// Token: 0x04007DB8 RID: 32184
	public int i_first_pass;

	// Token: 0x04007DB9 RID: 32185
	public string s_trace_id = "";

	// Token: 0x04007DBA RID: 32186
	public int i_if_back;

	// Token: 0x04007DBB RID: 32187
	public int i_inst_diff;

	// Token: 0x04007DBC RID: 32188
	public int i_result;

	// Token: 0x04007DBD RID: 32189
	public int i_display_mode;

	// Token: 0x04007DBE RID: 32190
	public int i_get_score;

	// Token: 0x04007DBF RID: 32191
	public int i_combo_max;

	// Token: 0x04007DC0 RID: 32192
	public string o_reward_items_new = "";

	// Token: 0x04007DC1 RID: 32193
	public int i_round;

	// Token: 0x04007DC2 RID: 32194
	public int i_count;

	// Token: 0x04007DC3 RID: 32195
	public int i_cost_time;

	// Token: 0x04007DC4 RID: 32196
	public string i_first_tab = "";

	// Token: 0x04007DC5 RID: 32197
	public string i_second_tab = "";

	// Token: 0x04007DC6 RID: 32198
	public string o_line_end1 = "";

	// Token: 0x04007DC7 RID: 32199
	public string o_line_end2 = "";

	// Token: 0x04007DC8 RID: 32200
	public string o_line_end3 = "";

	// Token: 0x04007DC9 RID: 32201
	public string o_line_end4 = "";

	// Token: 0x04007DCA RID: 32202
	public string o_line_end5 = "";

	// Token: 0x04007DCB RID: 32203
	public string o_line_end6 = "";

	// Token: 0x04007DCC RID: 32204
	public string o_line_end7 = "";

	// Token: 0x04007DCD RID: 32205
	public string o_line_end8 = "";

	// Token: 0x04007DCE RID: 32206
	public int i_rotate_count1;

	// Token: 0x04007DCF RID: 32207
	public int i_rotate_count2;

	// Token: 0x04007DD0 RID: 32208
	public int i_rotate_count3;

	// Token: 0x04007DD1 RID: 32209
	public int i_rotate_count4;

	// Token: 0x04007DD2 RID: 32210
	public int i_explosion_count;
}

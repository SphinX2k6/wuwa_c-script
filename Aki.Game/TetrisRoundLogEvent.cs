using System;
using System.Runtime.CompilerServices;

// Token: 0x020015EF RID: 5615
[NullableContext(1)]
[Nullable(0)]
public class TetrisRoundLogEvent : PlayerCommonLogData
{
	// Token: 0x170014EB RID: 5355
	// (get) Token: 0x0600DDF4 RID: 56820 RVA: 0x00417D66 File Offset: 0x00415F66
	// (set) Token: 0x0600DDF5 RID: 56821 RVA: 0x00417D6E File Offset: 0x00415F6E
	public override string event_id { get; set; } = "1915";

	// Token: 0x04007DD4 RID: 32212
	public int i_activity_id;

	// Token: 0x04007DD5 RID: 32213
	public int i_inst_id;

	// Token: 0x04007DD6 RID: 32214
	public int i_type;

	// Token: 0x04007DD7 RID: 32215
	public int i_first_pass;

	// Token: 0x04007DD8 RID: 32216
	public string s_trace_id = "";

	// Token: 0x04007DD9 RID: 32217
	public int i_if_back;

	// Token: 0x04007DDA RID: 32218
	public int i_inst_diff;

	// Token: 0x04007DDB RID: 32219
	public int i_round;

	// Token: 0x04007DDC RID: 32220
	public int i_result;

	// Token: 0x04007DDD RID: 32221
	public int i_display_mode;

	// Token: 0x04007DDE RID: 32222
	public int i_get_score;

	// Token: 0x04007DDF RID: 32223
	public int if_con_combo;

	// Token: 0x04007DE0 RID: 32224
	public int i_combo_max;

	// Token: 0x04007DE1 RID: 32225
	public string o_reward_items_new = "";

	// Token: 0x04007DE2 RID: 32226
	public string i_first_tab = "";

	// Token: 0x04007DE3 RID: 32227
	public int i_count;

	// Token: 0x04007DE4 RID: 32228
	public int i_cost_time;

	// Token: 0x04007DE5 RID: 32229
	public string o_line_start1 = "";

	// Token: 0x04007DE6 RID: 32230
	public string o_line_start2 = "";

	// Token: 0x04007DE7 RID: 32231
	public string o_line_start3 = "";

	// Token: 0x04007DE8 RID: 32232
	public string o_line_start4 = "";

	// Token: 0x04007DE9 RID: 32233
	public string o_line_start5 = "";

	// Token: 0x04007DEA RID: 32234
	public string o_line_start6 = "";

	// Token: 0x04007DEB RID: 32235
	public string o_line_start7 = "";

	// Token: 0x04007DEC RID: 32236
	public string o_line_start8 = "";

	// Token: 0x04007DED RID: 32237
	public string o_line_end1 = "";

	// Token: 0x04007DEE RID: 32238
	public string o_line_end2 = "";

	// Token: 0x04007DEF RID: 32239
	public string o_line_end3 = "";

	// Token: 0x04007DF0 RID: 32240
	public string o_line_end4 = "";

	// Token: 0x04007DF1 RID: 32241
	public string o_line_end5 = "";

	// Token: 0x04007DF2 RID: 32242
	public string o_line_end6 = "";

	// Token: 0x04007DF3 RID: 32243
	public string o_line_end7 = "";

	// Token: 0x04007DF4 RID: 32244
	public string o_line_end8 = "";

	// Token: 0x04007DF5 RID: 32245
	public int i_rotate_count1;

	// Token: 0x04007DF6 RID: 32246
	public int i_rotate_count2;

	// Token: 0x04007DF7 RID: 32247
	public int i_rotate_count3;

	// Token: 0x04007DF8 RID: 32248
	public int i_rotate_count4;

	// Token: 0x04007DF9 RID: 32249
	public int i_explosion_count;
}

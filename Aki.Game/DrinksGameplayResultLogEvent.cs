using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200214F RID: 8527
[NullableContext(1)]
[Nullable(0)]
public class DrinksGameplayResultLogEvent : PlayerCommonLogData
{
	// Token: 0x170014F4 RID: 5364
	// (get) Token: 0x06010A27 RID: 68135 RVA: 0x0040BFC7 File Offset: 0x0040A1C7
	// (set) Token: 0x06010A28 RID: 68136 RVA: 0x0040BFCF File Offset: 0x0040A1CF
	public override string event_id { get; set; } = "1834";

	// Token: 0x04007DCB RID: 32203
	public int i_activity_id;

	// Token: 0x04007DCC RID: 32204
	public int i_role_id;

	// Token: 0x04007DCD RID: 32205
	public int i_inst_id;

	// Token: 0x04007DCE RID: 32206
	public int i_first_pass;

	// Token: 0x04007DCF RID: 32207
	public int i_result;

	// Token: 0x04007DD0 RID: 32208
	public int i_first_tab;

	// Token: 0x04007DD1 RID: 32209
	public int i_first_count;

	// Token: 0x04007DD2 RID: 32210
	public int i_second_tab;

	// Token: 0x04007DD3 RID: 32211
	public int i_second_count;

	// Token: 0x04007DD4 RID: 32212
	public int i_third_tab = -1;

	// Token: 0x04007DD5 RID: 32213
	public int i_fourth_tab = -1;

	// Token: 0x04007DD6 RID: 32214
	public int i_fifth_tab = -1;

	// Token: 0x04007DD7 RID: 32215
	public int i_cost_time;

	// Token: 0x04007DD8 RID: 32216
	public int i_require_id;

	// Token: 0x04007DD9 RID: 32217
	public List<int> o_score_buff = new List<int>();

	// Token: 0x04007DDA RID: 32218
	public string s_trace_id = "";
}

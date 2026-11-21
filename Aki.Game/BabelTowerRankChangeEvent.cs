using System;
using System.Runtime.CompilerServices;

// Token: 0x02001648 RID: 5704
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerRankChangeEvent : PlayerCommonLogData
{
	// Token: 0x17001540 RID: 5440
	// (get) Token: 0x0600DEF7 RID: 57079 RVA: 0x00418BF8 File Offset: 0x00416DF8
	// (set) Token: 0x0600DEF8 RID: 57080 RVA: 0x00418C00 File Offset: 0x00416E00
	public override string event_id { get; set; } = "1931";

	// Token: 0x04007F77 RID: 32631
	public int i_best_star;

	// Token: 0x04007F78 RID: 32632
	public int i_current_star;

	// Token: 0x04007F79 RID: 32633
	public int i_target_star;

	// Token: 0x04007F7A RID: 32634
	public int i_dungeon_id;

	// Token: 0x04007F7B RID: 32635
	public string s_trace_id = "";

	// Token: 0x04007F7C RID: 32636
	public string s_battle_id = "";

	// Token: 0x04007F7D RID: 32637
	public int i_old_exp;

	// Token: 0x04007F7E RID: 32638
	public int i_new_exp;

	// Token: 0x04007F7F RID: 32639
	public int i_old_level;

	// Token: 0x04007F80 RID: 32640
	public int i_new_level;
}

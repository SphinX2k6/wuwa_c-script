using System;
using System.Runtime.CompilerServices;

// Token: 0x02002170 RID: 8560
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerRankChangeEvent : PlayerCommonLogData
{
	// Token: 0x17001512 RID: 5394
	// (get) Token: 0x06010A84 RID: 68228 RVA: 0x0040C4B0 File Offset: 0x0040A6B0
	// (set) Token: 0x06010A85 RID: 68229 RVA: 0x0040C4B8 File Offset: 0x0040A6B8
	public override string event_id { get; set; } = "1931";

	// Token: 0x04007E67 RID: 32359
	public int i_best_star;

	// Token: 0x04007E68 RID: 32360
	public int i_current_star;

	// Token: 0x04007E69 RID: 32361
	public int i_target_star;

	// Token: 0x04007E6A RID: 32362
	public int i_dungeon_id;

	// Token: 0x04007E6B RID: 32363
	public string s_trace_id = "";

	// Token: 0x04007E6C RID: 32364
	public string s_battle_id = "";

	// Token: 0x04007E6D RID: 32365
	public int i_old_exp;

	// Token: 0x04007E6E RID: 32366
	public int i_new_exp;

	// Token: 0x04007E6F RID: 32367
	public int i_old_level;

	// Token: 0x04007E70 RID: 32368
	public int i_new_level;
}

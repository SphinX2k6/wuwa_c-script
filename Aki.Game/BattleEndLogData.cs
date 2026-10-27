using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020020B7 RID: 8375
[NullableContext(1)]
[Nullable(0)]
public class BattleEndLogData : PlayerCommonLogData
{
	// Token: 0x17001464 RID: 5220
	// (get) Token: 0x0601086A RID: 67690 RVA: 0x0040A093 File Offset: 0x00408293
	// (set) Token: 0x0601086B RID: 67691 RVA: 0x0040A09B File Offset: 0x0040829B
	public override string event_id { get; set; } = "102705";

	// Token: 0x04007A40 RID: 31296
	public int i_area_id;

	// Token: 0x04007A41 RID: 31297
	public double f_x;

	// Token: 0x04007A42 RID: 31298
	public double f_y;

	// Token: 0x04007A43 RID: 31299
	public double f_z;

	// Token: 0x04007A44 RID: 31300
	public string s_battle_id = "";

	// Token: 0x04007A45 RID: 31301
	public List<int> s_team_character = new List<int>();

	// Token: 0x04007A46 RID: 31302
	public List<int> s_team_hp_per = new List<int>();

	// Token: 0x04007A47 RID: 31303
	public List<MonsterInfoLogData> s_monster_hate = new List<MonsterInfoLogData>();

	// Token: 0x04007A48 RID: 31304
	public List<MonsterInfoLogData> s_death_monster = new List<MonsterInfoLogData>();

	// Token: 0x04007A49 RID: 31305
	public List<MonsterInfoLogData> s_run_monster = new List<MonsterInfoLogData>();

	// Token: 0x04007A4A RID: 31306
	public int i_result;

	// Token: 0x04007A4B RID: 31307
	public int i_death_role_count;

	// Token: 0x04007A4C RID: 31308
	public int i_revive_times;

	// Token: 0x04007A4D RID: 31309
	public int i_change_character_times;

	// Token: 0x04007A4E RID: 31310
	public int i_qte_times;

	// Token: 0x04007A4F RID: 31311
	public long l_acc_damage;

	// Token: 0x04007A50 RID: 31312
	public long l_acc_shield_damage;

	// Token: 0x04007A51 RID: 31313
	public long l_acc_self_damage;

	// Token: 0x04007A52 RID: 31314
	public long l_acc_skill_heal;

	// Token: 0x04007A53 RID: 31315
	public long l_acc_item_heal;

	// Token: 0x04007A54 RID: 31316
	public int i_stop_times;

	// Token: 0x04007A55 RID: 31317
	public int i_damage_max;

	// Token: 0x04007A56 RID: 31318
	public int i_acc_dodge_times;

	// Token: 0x04007A57 RID: 31319
	public int i_dodge_succ_times;

	// Token: 0x04007A58 RID: 31320
	public int i_non_character_damage;

	// Token: 0x04007A59 RID: 31321
	public int i_non_character_shield_damage;

	// Token: 0x04007A5A RID: 31322
	public int i_cost_time;

	// Token: 0x04007A5B RID: 31323
	public int i_counter_attack_times;

	// Token: 0x04007A5C RID: 31324
	public int i_bullet_rebound_times;

	// Token: 0x04007A5D RID: 31325
	public double i_move_duration;

	// Token: 0x04007A5E RID: 31326
	public double i_swim_duration;

	// Token: 0x04007A5F RID: 31327
	public double i_glide_duration;

	// Token: 0x04007A60 RID: 31328
	public double i_climb_duration;

	// Token: 0x04007A61 RID: 31329
	public double i_behit_duration;

	// Token: 0x04007A62 RID: 31330
	public double i_skill_duration;

	// Token: 0x04007A63 RID: 31331
	public double i_dash_duration;

	// Token: 0x04007A64 RID: 31332
	public double i_other_duration;
}

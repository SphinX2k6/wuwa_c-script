using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200158E RID: 5518
[NullableContext(1)]
[Nullable(0)]
public class BattleEndLogData : PlayerCommonLogData
{
	// Token: 0x17001491 RID: 5265
	// (get) Token: 0x0600DCDA RID: 56538 RVA: 0x0041679B File Offset: 0x0041499B
	// (set) Token: 0x0600DCDB RID: 56539 RVA: 0x004167A3 File Offset: 0x004149A3
	public override string event_id { get; set; } = "102705";

	// Token: 0x04007B3E RID: 31550
	public int i_area_id;

	// Token: 0x04007B3F RID: 31551
	public double f_x;

	// Token: 0x04007B40 RID: 31552
	public double f_y;

	// Token: 0x04007B41 RID: 31553
	public double f_z;

	// Token: 0x04007B42 RID: 31554
	public string s_battle_id = "";

	// Token: 0x04007B43 RID: 31555
	public List<int> s_team_character = new List<int>();

	// Token: 0x04007B44 RID: 31556
	public List<int> s_team_hp_per = new List<int>();

	// Token: 0x04007B45 RID: 31557
	public List<MonsterInfoLogData> s_monster_hate = new List<MonsterInfoLogData>();

	// Token: 0x04007B46 RID: 31558
	public List<MonsterInfoLogData> s_death_monster = new List<MonsterInfoLogData>();

	// Token: 0x04007B47 RID: 31559
	public List<MonsterInfoLogData> s_run_monster = new List<MonsterInfoLogData>();

	// Token: 0x04007B48 RID: 31560
	public int i_result;

	// Token: 0x04007B49 RID: 31561
	public int i_death_role_count;

	// Token: 0x04007B4A RID: 31562
	public int i_revive_times;

	// Token: 0x04007B4B RID: 31563
	public int i_change_character_times;

	// Token: 0x04007B4C RID: 31564
	public int i_qte_times;

	// Token: 0x04007B4D RID: 31565
	public long l_acc_damage;

	// Token: 0x04007B4E RID: 31566
	public long l_acc_shield_damage;

	// Token: 0x04007B4F RID: 31567
	public long l_acc_self_damage;

	// Token: 0x04007B50 RID: 31568
	public long l_acc_skill_heal;

	// Token: 0x04007B51 RID: 31569
	public long l_acc_item_heal;

	// Token: 0x04007B52 RID: 31570
	public int i_stop_times;

	// Token: 0x04007B53 RID: 31571
	public int i_damage_max;

	// Token: 0x04007B54 RID: 31572
	public int i_acc_dodge_times;

	// Token: 0x04007B55 RID: 31573
	public int i_dodge_succ_times;

	// Token: 0x04007B56 RID: 31574
	public int i_non_character_damage;

	// Token: 0x04007B57 RID: 31575
	public int i_non_character_shield_damage;

	// Token: 0x04007B58 RID: 31576
	public int i_cost_time;

	// Token: 0x04007B59 RID: 31577
	public int i_counter_attack_times;

	// Token: 0x04007B5A RID: 31578
	public int i_bullet_rebound_times;

	// Token: 0x04007B5B RID: 31579
	public double i_move_duration;

	// Token: 0x04007B5C RID: 31580
	public double i_swim_duration;

	// Token: 0x04007B5D RID: 31581
	public double i_glide_duration;

	// Token: 0x04007B5E RID: 31582
	public double i_climb_duration;

	// Token: 0x04007B5F RID: 31583
	public double i_behit_duration;

	// Token: 0x04007B60 RID: 31584
	public double i_skill_duration;

	// Token: 0x04007B61 RID: 31585
	public double i_dash_duration;

	// Token: 0x04007B62 RID: 31586
	public double i_other_duration;
}

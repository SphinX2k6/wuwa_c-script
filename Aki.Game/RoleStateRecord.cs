using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200158F RID: 5519
[NullableContext(1)]
[Nullable(0)]
public class RoleStateRecord : PlayerCommonLogData
{
	// Token: 0x0600DCDD RID: 56541 RVA: 0x0041680C File Offset: 0x00414A0C
	public RoleStateRecord(int roleId)
	{
		this.i_role_id = roleId;
	}

	// Token: 0x17001492 RID: 5266
	// (get) Token: 0x0600DCDE RID: 56542 RVA: 0x00416831 File Offset: 0x00414A31
	// (set) Token: 0x0600DCDF RID: 56543 RVA: 0x00416839 File Offset: 0x00414A39
	public override string event_id { get; set; } = "102700";

	// Token: 0x04007B64 RID: 31588
	public string s_battle_id = "";

	// Token: 0x04007B65 RID: 31589
	public int i_role_id;

	// Token: 0x04007B66 RID: 31590
	public int i_role_type;

	// Token: 0x04007B67 RID: 31591
	public int i_role_level;

	// Token: 0x04007B68 RID: 31592
	public int i_role_quality;

	// Token: 0x04007B69 RID: 31593
	public int i_role_reson;

	// Token: 0x04007B6A RID: 31594
	public int i_vision_skill_id;

	// Token: 0x04007B6B RID: 31595
	public int i_vision_skill_level;

	// Token: 0x04007B6C RID: 31596
	public int i_weapon_id;

	// Token: 0x04007B6D RID: 31597
	public int i_weapon_type;

	// Token: 0x04007B6E RID: 31598
	public int i_weapon_quality;

	// Token: 0x04007B6F RID: 31599
	public int i_weapon_level;

	// Token: 0x04007B70 RID: 31600
	public double i_hp_max;

	// Token: 0x04007B71 RID: 31601
	public double i_begin_hp;

	// Token: 0x04007B72 RID: 31602
	public double i_end_hp;

	// Token: 0x04007B73 RID: 31603
	public int i_death_times;

	// Token: 0x04007B74 RID: 31604
	public int i_revive_times;

	// Token: 0x04007B75 RID: 31605
	public long l_acc_damage;

	// Token: 0x04007B76 RID: 31606
	public long l_acc_shield_damage;

	// Token: 0x04007B77 RID: 31607
	public int TotalGetDamage;

	// Token: 0x04007B78 RID: 31608
	public int TotalGetDamageTimes;

	// Token: 0x04007B79 RID: 31609
	public long l_acc_heal_self;

	// Token: 0x04007B7A RID: 31610
	public long l_acc_heal_other;

	// Token: 0x04007B7B RID: 31611
	public long l_acc_item_heal;

	// Token: 0x04007B7C RID: 31612
	public int i_acc_dodge_times;

	// Token: 0x04007B7D RID: 31613
	public int i_dodge_succ_times;

	// Token: 0x04007B7E RID: 31614
	public int i_enter_times;

	// Token: 0x04007B7F RID: 31615
	public int i_leave_times;

	// Token: 0x04007B80 RID: 31616
	public double LastGoToBattleTimePoint;

	// Token: 0x04007B81 RID: 31617
	public double i_acc_time;

	// Token: 0x04007B82 RID: 31618
	public int i_use_item_count;

	// Token: 0x04007B83 RID: 31619
	public int i_counter_attack_times;

	// Token: 0x04007B84 RID: 31620
	public int i_bullet_rebound_times;

	// Token: 0x04007B85 RID: 31621
	public int i_full_element_times;

	// Token: 0x04007B86 RID: 31622
	public float l_acc_element;

	// Token: 0x04007B87 RID: 31623
	public int i_full_energy_times;

	// Token: 0x04007B88 RID: 31624
	public float l_acc_energy;

	// Token: 0x04007B89 RID: 31625
	public int i_team_position;

	// Token: 0x04007B8A RID: 31626
	public long i_enter_battle_score;

	// Token: 0x04007B8B RID: 31627
	public Dictionary<string, int> s_role_skill;

	// Token: 0x04007B8C RID: 31628
	public List<List<int>> s_phantom_battle_data;

	// Token: 0x04007B8D RID: 31629
	public List<int> s_phantom_fetter_list;

	// Token: 0x04007B8E RID: 31630
	public int i_main_page;

	// Token: 0x04007B8F RID: 31631
	public int i_sub_page;
}

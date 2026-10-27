using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020020B8 RID: 8376
[NullableContext(1)]
[Nullable(0)]
public class RoleStateRecord : PlayerCommonLogData
{
	// Token: 0x0601086D RID: 67693 RVA: 0x0040A104 File Offset: 0x00408304
	public RoleStateRecord(int roleId)
	{
		this.i_role_id = roleId;
	}

	// Token: 0x17001465 RID: 5221
	// (get) Token: 0x0601086E RID: 67694 RVA: 0x0040A129 File Offset: 0x00408329
	// (set) Token: 0x0601086F RID: 67695 RVA: 0x0040A131 File Offset: 0x00408331
	public override string event_id { get; set; } = "102700";

	// Token: 0x04007A66 RID: 31334
	public string s_battle_id = "";

	// Token: 0x04007A67 RID: 31335
	public int i_role_id;

	// Token: 0x04007A68 RID: 31336
	public int i_role_type;

	// Token: 0x04007A69 RID: 31337
	public int i_role_level;

	// Token: 0x04007A6A RID: 31338
	public int i_role_quality;

	// Token: 0x04007A6B RID: 31339
	public int i_role_reson;

	// Token: 0x04007A6C RID: 31340
	public int i_vision_skill_id;

	// Token: 0x04007A6D RID: 31341
	public int i_vision_skill_level;

	// Token: 0x04007A6E RID: 31342
	public int i_weapon_id;

	// Token: 0x04007A6F RID: 31343
	public int i_weapon_type;

	// Token: 0x04007A70 RID: 31344
	public int i_weapon_quality;

	// Token: 0x04007A71 RID: 31345
	public int i_weapon_level;

	// Token: 0x04007A72 RID: 31346
	public double i_hp_max;

	// Token: 0x04007A73 RID: 31347
	public double i_begin_hp;

	// Token: 0x04007A74 RID: 31348
	public double i_end_hp;

	// Token: 0x04007A75 RID: 31349
	public int i_death_times;

	// Token: 0x04007A76 RID: 31350
	public int i_revive_times;

	// Token: 0x04007A77 RID: 31351
	public long l_acc_damage;

	// Token: 0x04007A78 RID: 31352
	public long l_acc_shield_damage;

	// Token: 0x04007A79 RID: 31353
	public int TotalGetDamage;

	// Token: 0x04007A7A RID: 31354
	public int TotalGetDamageTimes;

	// Token: 0x04007A7B RID: 31355
	public long l_acc_heal_self;

	// Token: 0x04007A7C RID: 31356
	public long l_acc_heal_other;

	// Token: 0x04007A7D RID: 31357
	public long l_acc_item_heal;

	// Token: 0x04007A7E RID: 31358
	public int i_acc_dodge_times;

	// Token: 0x04007A7F RID: 31359
	public int i_dodge_succ_times;

	// Token: 0x04007A80 RID: 31360
	public int i_enter_times;

	// Token: 0x04007A81 RID: 31361
	public int i_leave_times;

	// Token: 0x04007A82 RID: 31362
	public double LastGoToBattleTimePoint;

	// Token: 0x04007A83 RID: 31363
	public double i_acc_time;

	// Token: 0x04007A84 RID: 31364
	public int i_use_item_count;

	// Token: 0x04007A85 RID: 31365
	public int i_counter_attack_times;

	// Token: 0x04007A86 RID: 31366
	public int i_bullet_rebound_times;

	// Token: 0x04007A87 RID: 31367
	public int i_full_element_times;

	// Token: 0x04007A88 RID: 31368
	public float l_acc_element;

	// Token: 0x04007A89 RID: 31369
	public int i_full_energy_times;

	// Token: 0x04007A8A RID: 31370
	public float l_acc_energy;

	// Token: 0x04007A8B RID: 31371
	public int i_team_position;

	// Token: 0x04007A8C RID: 31372
	public long i_enter_battle_score;

	// Token: 0x04007A8D RID: 31373
	public Dictionary<string, int> s_role_skill;

	// Token: 0x04007A8E RID: 31374
	public List<List<int>> s_phantom_battle_data;

	// Token: 0x04007A8F RID: 31375
	public List<int> s_phantom_fetter_list;

	// Token: 0x04007A90 RID: 31376
	public int i_main_page;

	// Token: 0x04007A91 RID: 31377
	public int i_sub_page;
}

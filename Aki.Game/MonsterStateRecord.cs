using System;
using System.Runtime.CompilerServices;

// Token: 0x02001590 RID: 5520
[NullableContext(1)]
[Nullable(0)]
public class MonsterStateRecord : PlayerCommonLogData
{
	// Token: 0x0600DCE0 RID: 56544 RVA: 0x00416842 File Offset: 0x00414A42
	public MonsterStateRecord(int monsterId, string pbModelConfigId)
	{
		this.i_monster_id = monsterId;
		this.s_pb_model_config_id = pbModelConfigId;
	}

	// Token: 0x17001493 RID: 5267
	// (get) Token: 0x0600DCE1 RID: 56545 RVA: 0x00416880 File Offset: 0x00414A80
	// (set) Token: 0x0600DCE2 RID: 56546 RVA: 0x00416888 File Offset: 0x00414A88
	public override string event_id { get; set; } = "102701";

	// Token: 0x04007B91 RID: 31633
	public string s_battle_id = "";

	// Token: 0x04007B92 RID: 31634
	public int i_monster_id;

	// Token: 0x04007B93 RID: 31635
	public int i_monster_level;

	// Token: 0x04007B94 RID: 31636
	public int i_kill_role_times;

	// Token: 0x04007B95 RID: 31637
	public long l_acc_damage;

	// Token: 0x04007B96 RID: 31638
	public long l_acc_shield_damage;

	// Token: 0x04007B97 RID: 31639
	public long l_acc_heal_other;

	// Token: 0x04007B98 RID: 31640
	public long l_acc_heal_self;

	// Token: 0x04007B99 RID: 31641
	public int i_monster_result = 1;

	// Token: 0x04007B9A RID: 31642
	public float f_pos_x;

	// Token: 0x04007B9B RID: 31643
	public float f_pos_y;

	// Token: 0x04007B9C RID: 31644
	public float f_pos_z;

	// Token: 0x04007B9D RID: 31645
	public double InitTime;

	// Token: 0x04007B9E RID: 31646
	public int i_acc_time;

	// Token: 0x04007B9F RID: 31647
	public int i_counter_attack_times;

	// Token: 0x04007BA0 RID: 31648
	public int i_monster_score;

	// Token: 0x04007BA1 RID: 31649
	public long l_acc_hardness;

	// Token: 0x04007BA2 RID: 31650
	public float l_acc_rage;

	// Token: 0x04007BA3 RID: 31651
	public long l_acc_rage_normal;

	// Token: 0x04007BA4 RID: 31652
	public float l_acc_rage_counter;

	// Token: 0x04007BA5 RID: 31653
	public long l_acc_rage_vision;

	// Token: 0x04007BA6 RID: 31654
	public long l_acc_rage_other;

	// Token: 0x04007BA7 RID: 31655
	public string s_pb_model_config_id = "";

	// Token: 0x04007BA8 RID: 31656
	public int i_paralysis_times;

	// Token: 0x04007BA9 RID: 31657
	public int i_bullet_rebound_times;

	// Token: 0x04007BAA RID: 31658
	public long l_acc_be_damaged;

	// Token: 0x04007BAB RID: 31659
	public long l_acc_part_destroy;

	// Token: 0x04007BAC RID: 31660
	public long l_acc_weakness;

	// Token: 0x04007BAD RID: 31661
	public int i_from_quest;

	// Token: 0x04007BAE RID: 31662
	public int i_from_play;
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x020020B9 RID: 8377
[NullableContext(1)]
[Nullable(0)]
public class MonsterStateRecord : PlayerCommonLogData
{
	// Token: 0x06010870 RID: 67696 RVA: 0x0040A13A File Offset: 0x0040833A
	public MonsterStateRecord(int monsterId, string pbModelConfigId)
	{
		this.i_monster_id = monsterId;
		this.s_pb_model_config_id = pbModelConfigId;
	}

	// Token: 0x17001466 RID: 5222
	// (get) Token: 0x06010871 RID: 67697 RVA: 0x0040A178 File Offset: 0x00408378
	// (set) Token: 0x06010872 RID: 67698 RVA: 0x0040A180 File Offset: 0x00408380
	public override string event_id { get; set; } = "102701";

	// Token: 0x04007A93 RID: 31379
	public string s_battle_id = "";

	// Token: 0x04007A94 RID: 31380
	public int i_monster_id;

	// Token: 0x04007A95 RID: 31381
	public int i_monster_level;

	// Token: 0x04007A96 RID: 31382
	public int i_kill_role_times;

	// Token: 0x04007A97 RID: 31383
	public long l_acc_damage;

	// Token: 0x04007A98 RID: 31384
	public long l_acc_shield_damage;

	// Token: 0x04007A99 RID: 31385
	public long l_acc_heal_other;

	// Token: 0x04007A9A RID: 31386
	public long l_acc_heal_self;

	// Token: 0x04007A9B RID: 31387
	public int i_monster_result = 1;

	// Token: 0x04007A9C RID: 31388
	public float f_pos_x;

	// Token: 0x04007A9D RID: 31389
	public float f_pos_y;

	// Token: 0x04007A9E RID: 31390
	public float f_pos_z;

	// Token: 0x04007A9F RID: 31391
	public double InitTime;

	// Token: 0x04007AA0 RID: 31392
	public int i_acc_time;

	// Token: 0x04007AA1 RID: 31393
	public int i_counter_attack_times;

	// Token: 0x04007AA2 RID: 31394
	public int i_monster_score;

	// Token: 0x04007AA3 RID: 31395
	public long l_acc_hardness;

	// Token: 0x04007AA4 RID: 31396
	public float l_acc_rage;

	// Token: 0x04007AA5 RID: 31397
	public long l_acc_rage_normal;

	// Token: 0x04007AA6 RID: 31398
	public float l_acc_rage_counter;

	// Token: 0x04007AA7 RID: 31399
	public long l_acc_rage_vision;

	// Token: 0x04007AA8 RID: 31400
	public long l_acc_rage_other;

	// Token: 0x04007AA9 RID: 31401
	public string s_pb_model_config_id = "";

	// Token: 0x04007AAA RID: 31402
	public int i_paralysis_times;

	// Token: 0x04007AAB RID: 31403
	public int i_bullet_rebound_times;

	// Token: 0x04007AAC RID: 31404
	public long l_acc_be_damaged;

	// Token: 0x04007AAD RID: 31405
	public long l_acc_part_destroy;

	// Token: 0x04007AAE RID: 31406
	public long l_acc_weakness;

	// Token: 0x04007AAF RID: 31407
	public int i_from_quest;

	// Token: 0x04007AB0 RID: 31408
	public int i_from_play;
}

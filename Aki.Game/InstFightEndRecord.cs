using System;
using System.Runtime.CompilerServices;

// Token: 0x020020C1 RID: 8385
[NullableContext(1)]
[Nullable(0)]
public class InstFightEndRecord : PlayerCommonLogData
{
	// Token: 0x06010883 RID: 67715 RVA: 0x0040A2F0 File Offset: 0x004084F0
	public InstFightEndRecord()
	{
		this.i_inst_id = 0;
		this.s_fight_roles = "";
		this.s_fight_id = "";
		this.i_result = 0;
		this.i_reason = 0;
		this.i_inst_use_time = 0;
		this.i_fight_use_time = 0;
		this.l_acc_self_damage = 0L;
		this.l_acc_damage = 0L;
		this.l_acc_shield_damage = 0L;
		this.l_acc_skill_heal = 0L;
		this.l_acc_item_heal = 0L;
		this.i_acc_dodge_times = 0;
		this.i_dodge_succ_times = 0;
		this.i_stop_times = 0;
		this.i_damage_max = 0;
		this.i_death_role_count = 0;
		this.i_revive_times = 0;
		this.i_counter_attack_times = 0;
		this.i_bullet_rebound_times = 0;
	}

	// Token: 0x1700146B RID: 5227
	// (get) Token: 0x06010884 RID: 67716 RVA: 0x0040A3BD File Offset: 0x004085BD
	// (set) Token: 0x06010885 RID: 67717 RVA: 0x0040A3C5 File Offset: 0x004085C5
	public override string event_id { get; set; } = "102801";

	// Token: 0x06010886 RID: 67718 RVA: 0x0040A3D0 File Offset: 0x004085D0
	public void Clear()
	{
		this.i_inst_id = 0;
		this.s_fight_roles = "";
		this.s_fight_id = "";
		this.i_result = 0;
		this.i_reason = 0;
		this.i_inst_use_time = 0;
		this.i_fight_use_time = 0;
		this.l_acc_self_damage = 0L;
		this.l_acc_damage = 0L;
		this.l_acc_shield_damage = 0L;
		this.l_acc_skill_heal = 0L;
		this.l_acc_item_heal = 0L;
		this.i_acc_dodge_times = 0;
		this.i_dodge_succ_times = 0;
		this.i_stop_times = 0;
		this.i_damage_max = 0;
		this.i_death_role_count = 0;
		this.i_revive_times = 0;
		this.i_counter_attack_times = 0;
		this.i_bullet_rebound_times = 0;
		this.i_move_duration = 0.0;
		this.i_swim_duration = 0.0;
		this.i_glide_duration = 0.0;
		this.i_climb_duration = 0.0;
		this.i_behit_duration = 0.0;
		this.i_skill_duration = 0.0;
		this.i_dash_duration = 0.0;
		this.i_other_duration = 0.0;
		this.i_area_index = 0;
	}

	// Token: 0x04007ADA RID: 31450
	public int i_inst_id;

	// Token: 0x04007ADB RID: 31451
	public string s_fight_roles = "";

	// Token: 0x04007ADC RID: 31452
	public string s_fight_id = "";

	// Token: 0x04007ADD RID: 31453
	public int i_result;

	// Token: 0x04007ADE RID: 31454
	public int i_reason;

	// Token: 0x04007ADF RID: 31455
	public int i_inst_use_time;

	// Token: 0x04007AE0 RID: 31456
	public int i_fight_use_time;

	// Token: 0x04007AE1 RID: 31457
	public long l_acc_damage;

	// Token: 0x04007AE2 RID: 31458
	public long l_acc_shield_damage;

	// Token: 0x04007AE3 RID: 31459
	public long l_acc_self_damage;

	// Token: 0x04007AE4 RID: 31460
	public long l_acc_skill_heal;

	// Token: 0x04007AE5 RID: 31461
	public long l_acc_item_heal;

	// Token: 0x04007AE6 RID: 31462
	public int i_stop_times;

	// Token: 0x04007AE7 RID: 31463
	public int i_damage_max;

	// Token: 0x04007AE8 RID: 31464
	public int i_acc_dodge_times;

	// Token: 0x04007AE9 RID: 31465
	public int i_dodge_succ_times;

	// Token: 0x04007AEA RID: 31466
	public int i_death_role_count;

	// Token: 0x04007AEB RID: 31467
	public int i_revive_times;

	// Token: 0x04007AEC RID: 31468
	public int i_counter_attack_times;

	// Token: 0x04007AED RID: 31469
	public int i_bullet_rebound_times;

	// Token: 0x04007AEE RID: 31470
	public double i_move_duration;

	// Token: 0x04007AEF RID: 31471
	public double i_swim_duration;

	// Token: 0x04007AF0 RID: 31472
	public double i_glide_duration;

	// Token: 0x04007AF1 RID: 31473
	public double i_climb_duration;

	// Token: 0x04007AF2 RID: 31474
	public double i_behit_duration;

	// Token: 0x04007AF3 RID: 31475
	public double i_skill_duration;

	// Token: 0x04007AF4 RID: 31476
	public double i_dash_duration;

	// Token: 0x04007AF5 RID: 31477
	public double i_other_duration;

	// Token: 0x04007AF6 RID: 31478
	public int i_area_index;
}

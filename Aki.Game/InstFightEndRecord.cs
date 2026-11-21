using System;
using System.Runtime.CompilerServices;

// Token: 0x02001598 RID: 5528
[NullableContext(1)]
[Nullable(0)]
public class InstFightEndRecord : PlayerCommonLogData
{
	// Token: 0x0600DCF3 RID: 56563 RVA: 0x004169F8 File Offset: 0x00414BF8
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

	// Token: 0x17001498 RID: 5272
	// (get) Token: 0x0600DCF4 RID: 56564 RVA: 0x00416AC5 File Offset: 0x00414CC5
	// (set) Token: 0x0600DCF5 RID: 56565 RVA: 0x00416ACD File Offset: 0x00414CCD
	public override string event_id { get; set; } = "102801";

	// Token: 0x0600DCF6 RID: 56566 RVA: 0x00416AD8 File Offset: 0x00414CD8
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

	// Token: 0x04007BD8 RID: 31704
	public int i_inst_id;

	// Token: 0x04007BD9 RID: 31705
	public string s_fight_roles = "";

	// Token: 0x04007BDA RID: 31706
	public string s_fight_id = "";

	// Token: 0x04007BDB RID: 31707
	public int i_result;

	// Token: 0x04007BDC RID: 31708
	public int i_reason;

	// Token: 0x04007BDD RID: 31709
	public int i_inst_use_time;

	// Token: 0x04007BDE RID: 31710
	public int i_fight_use_time;

	// Token: 0x04007BDF RID: 31711
	public long l_acc_damage;

	// Token: 0x04007BE0 RID: 31712
	public long l_acc_shield_damage;

	// Token: 0x04007BE1 RID: 31713
	public long l_acc_self_damage;

	// Token: 0x04007BE2 RID: 31714
	public long l_acc_skill_heal;

	// Token: 0x04007BE3 RID: 31715
	public long l_acc_item_heal;

	// Token: 0x04007BE4 RID: 31716
	public int i_stop_times;

	// Token: 0x04007BE5 RID: 31717
	public int i_damage_max;

	// Token: 0x04007BE6 RID: 31718
	public int i_acc_dodge_times;

	// Token: 0x04007BE7 RID: 31719
	public int i_dodge_succ_times;

	// Token: 0x04007BE8 RID: 31720
	public int i_death_role_count;

	// Token: 0x04007BE9 RID: 31721
	public int i_revive_times;

	// Token: 0x04007BEA RID: 31722
	public int i_counter_attack_times;

	// Token: 0x04007BEB RID: 31723
	public int i_bullet_rebound_times;

	// Token: 0x04007BEC RID: 31724
	public double i_move_duration;

	// Token: 0x04007BED RID: 31725
	public double i_swim_duration;

	// Token: 0x04007BEE RID: 31726
	public double i_glide_duration;

	// Token: 0x04007BEF RID: 31727
	public double i_climb_duration;

	// Token: 0x04007BF0 RID: 31728
	public double i_behit_duration;

	// Token: 0x04007BF1 RID: 31729
	public double i_skill_duration;

	// Token: 0x04007BF2 RID: 31730
	public double i_dash_duration;

	// Token: 0x04007BF3 RID: 31731
	public double i_other_duration;

	// Token: 0x04007BF4 RID: 31732
	public int i_area_index;
}

using System;

// Token: 0x02001594 RID: 5524
public class MonsterSkillRecord
{
	// Token: 0x0600DCEA RID: 56554 RVA: 0x00416946 File Offset: 0x00414B46
	public MonsterSkillRecord(int skillId)
	{
		this.skill_id = (long)skillId;
	}

	// Token: 0x04007BC2 RID: 31682
	public long skill_id;

	// Token: 0x04007BC3 RID: 31683
	public int use_count;

	// Token: 0x04007BC4 RID: 31684
	public int hit_count;

	// Token: 0x04007BC5 RID: 31685
	public int real_hit_count;

	// Token: 0x04007BC6 RID: 31686
	public int damage;

	// Token: 0x04007BC7 RID: 31687
	public int counter_attack_times;

	// Token: 0x04007BC8 RID: 31688
	public int bullet_rebound_times;

	// Token: 0x04007BC9 RID: 31689
	public int dodge_succ_times;
}

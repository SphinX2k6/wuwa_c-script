using System;

// Token: 0x020020BD RID: 8381
public class MonsterSkillRecord
{
	// Token: 0x0601087A RID: 67706 RVA: 0x0040A23E File Offset: 0x0040843E
	public MonsterSkillRecord(int skillId)
	{
		this.skill_id = (long)skillId;
	}

	// Token: 0x04007AC4 RID: 31428
	public long skill_id;

	// Token: 0x04007AC5 RID: 31429
	public int use_count;

	// Token: 0x04007AC6 RID: 31430
	public int hit_count;

	// Token: 0x04007AC7 RID: 31431
	public int real_hit_count;

	// Token: 0x04007AC8 RID: 31432
	public int damage;

	// Token: 0x04007AC9 RID: 31433
	public int counter_attack_times;

	// Token: 0x04007ACA RID: 31434
	public int bullet_rebound_times;

	// Token: 0x04007ACB RID: 31435
	public int dodge_succ_times;
}

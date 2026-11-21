using System;
using System.Runtime.CompilerServices;

// Token: 0x02001592 RID: 5522
public class RoleSkillRecord
{
	// Token: 0x0600DCE6 RID: 56550 RVA: 0x004168CB File Offset: 0x00414ACB
	public RoleSkillRecord(int skillId)
	{
		this.skill_id = (long)skillId;
	}

	// Token: 0x04007BB5 RID: 31669
	public long skill_id;

	// Token: 0x04007BB6 RID: 31670
	public int use_count;

	// Token: 0x04007BB7 RID: 31671
	public int hit_count;

	// Token: 0x04007BB8 RID: 31672
	public int real_hit_count;

	// Token: 0x04007BB9 RID: 31673
	public int damage;

	// Token: 0x04007BBA RID: 31674
	[Nullable(1)]
	public int[] skill_type = Array.Empty<int>();

	// Token: 0x04007BBB RID: 31675
	public int acc_energy;
}

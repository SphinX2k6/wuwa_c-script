using System;
using System.Runtime.CompilerServices;

// Token: 0x020020BB RID: 8379
public class RoleSkillRecord
{
	// Token: 0x06010876 RID: 67702 RVA: 0x0040A1C3 File Offset: 0x004083C3
	public RoleSkillRecord(int skillId)
	{
		this.skill_id = (long)skillId;
	}

	// Token: 0x04007AB7 RID: 31415
	public long skill_id;

	// Token: 0x04007AB8 RID: 31416
	public int use_count;

	// Token: 0x04007AB9 RID: 31417
	public int hit_count;

	// Token: 0x04007ABA RID: 31418
	public int real_hit_count;

	// Token: 0x04007ABB RID: 31419
	public int damage;

	// Token: 0x04007ABC RID: 31420
	[Nullable(1)]
	public int[] skill_type = Array.Empty<int>();

	// Token: 0x04007ABD RID: 31421
	public int acc_energy;
}

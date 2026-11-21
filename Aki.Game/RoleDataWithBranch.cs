using System;

// Token: 0x02001D4B RID: 7499
public class RoleDataWithBranch
{
	// Token: 0x0601291C RID: 76060 RVA: 0x0057B9C0 File Offset: 0x00579BC0
	public RoleDataWithBranch(int roleId, int skillBranchId)
	{
		this.RoleId = roleId;
		this.SkillBranchId = skillBranchId;
		if (this.RoleId <= 0 || this.SkillBranchId <= 0)
		{
			this.SkillBranchIndex = -1;
			return;
		}
		this.SkillBranchIndex = RoleModel.Instance.GetRoleBranchIndexById(this.RoleId, this.SkillBranchId);
	}

	// Token: 0x0400A16F RID: 41327
	public int RoleId;

	// Token: 0x0400A170 RID: 41328
	public int SkillBranchId;

	// Token: 0x0400A171 RID: 41329
	public int SkillBranchIndex;
}

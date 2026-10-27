using System;

// Token: 0x020027D0 RID: 10192
public class RoleDataWithBranch
{
	// Token: 0x06014F1C RID: 85788 RVA: 0x00550C50 File Offset: 0x0054EE50
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

	// Token: 0x04009D86 RID: 40326
	public int RoleId;

	// Token: 0x04009D87 RID: 40327
	public int SkillBranchId;

	// Token: 0x04009D88 RID: 40328
	public int SkillBranchIndex;
}

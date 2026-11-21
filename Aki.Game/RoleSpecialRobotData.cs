using System;

// Token: 0x02001D36 RID: 7478
public class RoleSpecialRobotData : RoleRobotData
{
	// Token: 0x060128DE RID: 75998 RVA: 0x0057B658 File Offset: 0x00579858
	public RoleSpecialRobotData(int id) : base(id)
	{
		base.SetDefaultData();
	}

	// Token: 0x060128DF RID: 75999 RVA: 0x0057B667 File Offset: 0x00579867
	public bool IsUnlock()
	{
		return this.IsUnlockInternal;
	}

	// Token: 0x060128E0 RID: 76000 RVA: 0x0057B66F File Offset: 0x0057986F
	public void SetIsUnlock(bool value)
	{
		this.IsUnlockInternal = value;
	}

	// Token: 0x060128E1 RID: 76001 RVA: 0x0057B678 File Offset: 0x00579878
	public override bool CanEditInFormation()
	{
		return true;
	}

	// Token: 0x060128E2 RID: 76002 RVA: 0x0057B67B File Offset: 0x0057987B
	public override bool IsVisibleInFormation()
	{
		return this.IsVisibleInFormationInternal;
	}

	// Token: 0x060128E3 RID: 76003 RVA: 0x0057B683 File Offset: 0x00579883
	public void SetIsVisibleInFormation(bool value)
	{
		this.IsVisibleInFormationInternal = value;
	}

	// Token: 0x060128E4 RID: 76004 RVA: 0x0057B68C File Offset: 0x0057988C
	public bool IsVisibleInRoleSystem()
	{
		return this.IsVisibleInRoleSystemInternal;
	}

	// Token: 0x060128E5 RID: 76005 RVA: 0x0057B694 File Offset: 0x00579894
	public void SetIsVisibleInRoleSystem(bool value)
	{
		this.IsVisibleInRoleSystemInternal = value;
	}

	// Token: 0x0400A103 RID: 41219
	protected bool IsUnlockInternal;

	// Token: 0x0400A104 RID: 41220
	protected bool IsVisibleInFormationInternal;

	// Token: 0x0400A105 RID: 41221
	protected bool IsVisibleInRoleSystemInternal;
}

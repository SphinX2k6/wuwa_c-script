using System;

// Token: 0x020027BB RID: 10171
public class RoleSpecialRobotData : RoleRobotData
{
	// Token: 0x06014EDF RID: 85727 RVA: 0x00550934 File Offset: 0x0054EB34
	public RoleSpecialRobotData(int id) : base(id)
	{
		base.SetDefaultData();
	}

	// Token: 0x06014EE0 RID: 85728 RVA: 0x00550943 File Offset: 0x0054EB43
	public bool IsUnlock()
	{
		return this.IsUnlockInternal;
	}

	// Token: 0x06014EE1 RID: 85729 RVA: 0x0055094B File Offset: 0x0054EB4B
	public void SetIsUnlock(bool value)
	{
		this.IsUnlockInternal = value;
	}

	// Token: 0x06014EE2 RID: 85730 RVA: 0x00550954 File Offset: 0x0054EB54
	public override bool CanEditInFormation()
	{
		return true;
	}

	// Token: 0x06014EE3 RID: 85731 RVA: 0x00550957 File Offset: 0x0054EB57
	public override bool IsVisibleInFormation()
	{
		return this.IsVisibleInFormationInternal;
	}

	// Token: 0x06014EE4 RID: 85732 RVA: 0x0055095F File Offset: 0x0054EB5F
	public void SetIsVisibleInFormation(bool value)
	{
		this.IsVisibleInFormationInternal = value;
	}

	// Token: 0x06014EE5 RID: 85733 RVA: 0x00550968 File Offset: 0x0054EB68
	public bool IsVisibleInRoleSystem()
	{
		return this.IsVisibleInRoleSystemInternal;
	}

	// Token: 0x06014EE6 RID: 85734 RVA: 0x00550970 File Offset: 0x0054EB70
	public void SetIsVisibleInRoleSystem(bool value)
	{
		this.IsVisibleInRoleSystemInternal = value;
	}

	// Token: 0x04009D20 RID: 40224
	protected bool IsUnlockInternal;

	// Token: 0x04009D21 RID: 40225
	protected bool IsVisibleInFormationInternal;

	// Token: 0x04009D22 RID: 40226
	protected bool IsVisibleInRoleSystemInternal;
}

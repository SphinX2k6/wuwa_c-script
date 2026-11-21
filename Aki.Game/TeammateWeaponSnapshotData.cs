using System;

// Token: 0x020010B0 RID: 4272
public class TeammateWeaponSnapshotData : WeaponDataBase
{
	// Token: 0x0600A93C RID: 43324 RVA: 0x0031C885 File Offset: 0x0031AA85
	public TeammateWeaponSnapshotData(int itemId, int breachLevel)
	{
		this.ItemId = itemId;
		this.BreachLevel = breachLevel;
	}

	// Token: 0x0600A93D RID: 43325 RVA: 0x0031C89B File Offset: 0x0031AA9B
	public override int GetItemId()
	{
		return this.ItemId;
	}

	// Token: 0x0600A93E RID: 43326 RVA: 0x0031C8A3 File Offset: 0x0031AAA3
	public override int GetBreachLevel()
	{
		return this.BreachLevel;
	}

	// Token: 0x0600A93F RID: 43327 RVA: 0x0031C8AB File Offset: 0x0031AAAB
	public override int GetLevel()
	{
		return 1;
	}

	// Token: 0x0600A940 RID: 43328 RVA: 0x0031C8AE File Offset: 0x0031AAAE
	public override int GetResonanceLevel()
	{
		return 1;
	}

	// Token: 0x0600A941 RID: 43329 RVA: 0x0031C8B1 File Offset: 0x0031AAB1
	public override bool IsTrial()
	{
		return false;
	}

	// Token: 0x0600A942 RID: 43330 RVA: 0x0031C8B4 File Offset: 0x0031AAB4
	public override bool HasRole()
	{
		return this.RoleId != 0;
	}

	// Token: 0x0600A943 RID: 43331 RVA: 0x0031C8BF File Offset: 0x0031AABF
	public override void SetRoleId(int roleId)
	{
		this.RoleId = roleId;
	}

	// Token: 0x0600A944 RID: 43332 RVA: 0x0031C8C8 File Offset: 0x0031AAC8
	public override int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x04006270 RID: 25200
	private readonly int ItemId;

	// Token: 0x04006271 RID: 25201
	private readonly int BreachLevel;

	// Token: 0x04006272 RID: 25202
	private int RoleId;
}

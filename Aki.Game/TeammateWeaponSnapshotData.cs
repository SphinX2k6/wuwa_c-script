using System;

// Token: 0x02001BF1 RID: 7153
public class TeammateWeaponSnapshotData : WeaponDataBase
{
	// Token: 0x0600D529 RID: 54569 RVA: 0x00311641 File Offset: 0x0030F841
	public TeammateWeaponSnapshotData(int itemId, int breachLevel)
	{
		this.ItemId = itemId;
		this.BreachLevel = breachLevel;
	}

	// Token: 0x0600D52A RID: 54570 RVA: 0x00311657 File Offset: 0x0030F857
	public override int GetItemId()
	{
		return this.ItemId;
	}

	// Token: 0x0600D52B RID: 54571 RVA: 0x0031165F File Offset: 0x0030F85F
	public override int GetBreachLevel()
	{
		return this.BreachLevel;
	}

	// Token: 0x0600D52C RID: 54572 RVA: 0x00311667 File Offset: 0x0030F867
	public override int GetLevel()
	{
		return 1;
	}

	// Token: 0x0600D52D RID: 54573 RVA: 0x0031166A File Offset: 0x0030F86A
	public override int GetResonanceLevel()
	{
		return 1;
	}

	// Token: 0x0600D52E RID: 54574 RVA: 0x0031166D File Offset: 0x0030F86D
	public override bool IsTrial()
	{
		return false;
	}

	// Token: 0x0600D52F RID: 54575 RVA: 0x00311670 File Offset: 0x0030F870
	public override bool HasRole()
	{
		return this.RoleId != 0;
	}

	// Token: 0x0600D530 RID: 54576 RVA: 0x0031167B File Offset: 0x0030F87B
	public override void SetRoleId(int roleId)
	{
		this.RoleId = roleId;
	}

	// Token: 0x0600D531 RID: 54577 RVA: 0x00311684 File Offset: 0x0030F884
	public override int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x040061A1 RID: 24993
	private readonly int ItemId;

	// Token: 0x040061A2 RID: 24994
	private readonly int BreachLevel;

	// Token: 0x040061A3 RID: 24995
	private int RoleId;
}

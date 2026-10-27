using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020027B9 RID: 10169
[NullableContext(2)]
[Nullable(0)]
public class RoleOnlineInstanceData : RoleDataBase
{
	// Token: 0x06014EBE RID: 85694 RVA: 0x005501BA File Offset: 0x0054E3BA
	public RoleOnlineInstanceData(int id) : base(id)
	{
		this.SetDefaultData();
	}

	// Token: 0x06014EBF RID: 85695 RVA: 0x005501CC File Offset: 0x0054E3CC
	protected void SetDefaultData()
	{
		RoleInfo roleConfig = base.GetRoleConfig();
		this.WeaponTrialData = new WeaponTrialData();
		this.WeaponTrialData.SetTrialId(roleConfig.WeaponType, true);
	}

	// Token: 0x06014EC0 RID: 85696 RVA: 0x005501FE File Offset: 0x0054E3FE
	public override bool IsTrialRole()
	{
		return false;
	}

	// Token: 0x06014EC1 RID: 85697 RVA: 0x00550201 File Offset: 0x0054E401
	public override int GetRoleId()
	{
		return this.Id;
	}

	// Token: 0x06014EC2 RID: 85698 RVA: 0x0055020C File Offset: 0x0054E40C
	[NullableContext(1)]
	public override string GetName(int? playerId = null)
	{
		RoleInfo roleConfig = base.GetRoleConfig();
		return RoleConfig.Instance.GetRoleName(roleConfig.Name);
	}

	// Token: 0x06014EC3 RID: 85699 RVA: 0x00550231 File Offset: 0x0054E431
	public override bool CanChangeName()
	{
		return false;
	}

	// Token: 0x06014EC4 RID: 85700 RVA: 0x00550234 File Offset: 0x0054E434
	public override float GetShowAttributeValueById(int id)
	{
		return 0f;
	}

	// Token: 0x06014EC5 RID: 85701 RVA: 0x0055023B File Offset: 0x0054E43B
	public override bool IsOnlineRole()
	{
		return true;
	}

	// Token: 0x06014EC6 RID: 85702 RVA: 0x0055023E File Offset: 0x0054E43E
	public WeaponTrialData GetWeaponData()
	{
		return this.WeaponTrialData;
	}

	// Token: 0x06014EC7 RID: 85703 RVA: 0x00550246 File Offset: 0x0054E446
	public override int GetRoleCreateTime()
	{
		return 0;
	}

	// Token: 0x06014EC8 RID: 85704 RVA: 0x00550249 File Offset: 0x0054E449
	public override bool GetIsNew()
	{
		return false;
	}

	// Token: 0x04009D1E RID: 40222
	protected WeaponTrialData WeaponTrialData;
}

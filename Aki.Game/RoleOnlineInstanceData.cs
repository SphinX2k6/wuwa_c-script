using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001D34 RID: 7476
[NullableContext(2)]
[Nullable(0)]
public class RoleOnlineInstanceData : RoleDataBase
{
	// Token: 0x060128BD RID: 75965 RVA: 0x0057AEDE File Offset: 0x005790DE
	public RoleOnlineInstanceData(int id) : base(id)
	{
		this.SetDefaultData();
	}

	// Token: 0x060128BE RID: 75966 RVA: 0x0057AEF0 File Offset: 0x005790F0
	protected void SetDefaultData()
	{
		RoleInfo roleConfig = base.GetRoleConfig();
		this.WeaponTrialData = new WeaponTrialData();
		this.WeaponTrialData.SetTrialId(roleConfig.WeaponType, true);
	}

	// Token: 0x060128BF RID: 75967 RVA: 0x0057AF22 File Offset: 0x00579122
	public override bool IsTrialRole()
	{
		return false;
	}

	// Token: 0x060128C0 RID: 75968 RVA: 0x0057AF25 File Offset: 0x00579125
	public override int GetRoleId()
	{
		return this.Id;
	}

	// Token: 0x060128C1 RID: 75969 RVA: 0x0057AF30 File Offset: 0x00579130
	[NullableContext(1)]
	public override string GetName(int? playerId = null)
	{
		RoleInfo roleConfig = base.GetRoleConfig();
		return RoleConfig.Instance.GetRoleName(roleConfig.Name);
	}

	// Token: 0x060128C2 RID: 75970 RVA: 0x0057AF55 File Offset: 0x00579155
	public override bool CanChangeName()
	{
		return false;
	}

	// Token: 0x060128C3 RID: 75971 RVA: 0x0057AF58 File Offset: 0x00579158
	public override float GetShowAttributeValueById(int id)
	{
		return 0f;
	}

	// Token: 0x060128C4 RID: 75972 RVA: 0x0057AF5F File Offset: 0x0057915F
	public override bool IsOnlineRole()
	{
		return true;
	}

	// Token: 0x060128C5 RID: 75973 RVA: 0x0057AF62 File Offset: 0x00579162
	public WeaponTrialData GetWeaponData()
	{
		return this.WeaponTrialData;
	}

	// Token: 0x060128C6 RID: 75974 RVA: 0x0057AF6A File Offset: 0x0057916A
	public override int GetRoleCreateTime()
	{
		return 0;
	}

	// Token: 0x060128C7 RID: 75975 RVA: 0x0057AF6D File Offset: 0x0057916D
	public override bool GetIsNew()
	{
		return false;
	}

	// Token: 0x0400A101 RID: 41217
	protected WeaponTrialData WeaponTrialData;
}

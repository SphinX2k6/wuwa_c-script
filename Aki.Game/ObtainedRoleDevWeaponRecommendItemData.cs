using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002830 RID: 10288
public class ObtainedRoleDevWeaponRecommendItemData : RoleDevWeaponRecommendItemDataBase
{
	// Token: 0x06015336 RID: 86838 RVA: 0x0055CA54 File Offset: 0x0055AC54
	protected override void InitByRoleType(int roleId)
	{
		base.InitSubRecommendItems(roleId);
	}

	// Token: 0x06015337 RID: 86839 RVA: 0x0055CA60 File Offset: 0x0055AC60
	protected override int GetWeaponConfigId()
	{
		return WeaponModel.Instance.GetWeaponIdByRoleDataId(base.RoleId).GetValueOrDefault();
	}

	// Token: 0x06015338 RID: 86840 RVA: 0x0055CA88 File Offset: 0x0055AC88
	[NullableContext(1)]
	protected override string GetWeaponName()
	{
		WeaponInstance weaponInstanceByRoleId = WeaponModel.Instance.GetWeaponInstanceByRoleId(base.RoleId);
		if (weaponInstanceByRoleId == null)
		{
			return "";
		}
		WeaponConf? weaponConfig = weaponInstanceByRoleId.GetWeaponConfig();
		if (weaponConfig == null)
		{
			return "";
		}
		return weaponConfig.Value.WeaponName;
	}

	// Token: 0x06015339 RID: 86841 RVA: 0x0055CAD4 File Offset: 0x0055ACD4
	protected override int GetWeaponLevel()
	{
		WeaponInstance weaponInstanceByRoleId = WeaponModel.Instance.GetWeaponInstanceByRoleId(base.RoleId);
		if (weaponInstanceByRoleId == null)
		{
			return 0;
		}
		return weaponInstanceByRoleId.GetLevel();
	}

	// Token: 0x0601533A RID: 86842 RVA: 0x0055CAF4 File Offset: 0x0055ACF4
	protected override int GetWeaponGoalUpgradeLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.WeaponLevel;
	}

	// Token: 0x0601533B RID: 86843 RVA: 0x0055CB27 File Offset: 0x0055AD27
	protected override bool GetIsCall()
	{
		return RoleDevUtils.GetRoleGachaIds(base.WeaponConfigId).Length != 0;
	}

	// Token: 0x0601533C RID: 86844 RVA: 0x0055CB38 File Offset: 0x0055AD38
	protected override int GetGachaId()
	{
		int[] roleGachaIds = RoleDevUtils.GetRoleGachaIds(base.WeaponConfigId);
		if (roleGachaIds.Length != 0)
		{
			return roleGachaIds[0];
		}
		return 0;
	}

	// Token: 0x0601533D RID: 86845 RVA: 0x0055CB5C File Offset: 0x0055AD5C
	protected override bool GetIsWeaponHighQuality()
	{
		WeaponInstance weaponInstanceByRoleId = WeaponModel.Instance.GetWeaponInstanceByRoleId(base.RoleId);
		return weaponInstanceByRoleId == null || WeaponModel.Instance.IsWeaponHighQuality(weaponInstanceByRoleId);
	}

	// Token: 0x0601533E RID: 86846 RVA: 0x0055CB8A File Offset: 0x0055AD8A
	protected override bool GetIsObtained()
	{
		return this.GetWeaponConfigId() > 0;
	}

	// Token: 0x0601533F RID: 86847 RVA: 0x0055CB95 File Offset: 0x0055AD95
	protected override bool GetIsForecast()
	{
		return false;
	}
}

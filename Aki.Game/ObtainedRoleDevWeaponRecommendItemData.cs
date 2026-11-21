using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DAB RID: 7595
public class ObtainedRoleDevWeaponRecommendItemData : RoleDevWeaponRecommendItemDataBase
{
	// Token: 0x06012D34 RID: 77108 RVA: 0x005877B0 File Offset: 0x005859B0
	protected override void InitByRoleType(int roleId)
	{
		base.InitSubRecommendItems(roleId);
	}

	// Token: 0x06012D35 RID: 77109 RVA: 0x005877BC File Offset: 0x005859BC
	protected override int GetWeaponConfigId()
	{
		return WeaponModel.Instance.GetWeaponIdByRoleDataId(base.RoleId).GetValueOrDefault();
	}

	// Token: 0x06012D36 RID: 77110 RVA: 0x005877E4 File Offset: 0x005859E4
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

	// Token: 0x06012D37 RID: 77111 RVA: 0x00587830 File Offset: 0x00585A30
	protected override int GetWeaponLevel()
	{
		WeaponInstance weaponInstanceByRoleId = WeaponModel.Instance.GetWeaponInstanceByRoleId(base.RoleId);
		if (weaponInstanceByRoleId == null)
		{
			return 0;
		}
		return weaponInstanceByRoleId.GetLevel();
	}

	// Token: 0x06012D38 RID: 77112 RVA: 0x00587850 File Offset: 0x00585A50
	protected override int GetWeaponGoalUpgradeLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.WeaponLevel;
	}

	// Token: 0x06012D39 RID: 77113 RVA: 0x00587883 File Offset: 0x00585A83
	protected override bool GetIsCall()
	{
		return RoleDevUtils.GetRoleGachaIds(base.WeaponConfigId).Length != 0;
	}

	// Token: 0x06012D3A RID: 77114 RVA: 0x00587894 File Offset: 0x00585A94
	protected override int GetGachaId()
	{
		int[] roleGachaIds = RoleDevUtils.GetRoleGachaIds(base.WeaponConfigId);
		if (roleGachaIds.Length != 0)
		{
			return roleGachaIds[0];
		}
		return 0;
	}

	// Token: 0x06012D3B RID: 77115 RVA: 0x005878B8 File Offset: 0x00585AB8
	protected override bool GetIsWeaponHighQuality()
	{
		WeaponInstance weaponInstanceByRoleId = WeaponModel.Instance.GetWeaponInstanceByRoleId(base.RoleId);
		return weaponInstanceByRoleId == null || WeaponModel.Instance.IsWeaponHighQuality(weaponInstanceByRoleId);
	}

	// Token: 0x06012D3C RID: 77116 RVA: 0x005878E6 File Offset: 0x00585AE6
	protected override bool GetIsObtained()
	{
		return this.GetWeaponConfigId() > 0;
	}

	// Token: 0x06012D3D RID: 77117 RVA: 0x005878F1 File Offset: 0x00585AF1
	protected override bool GetIsForecast()
	{
		return false;
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DA7 RID: 7591
public class NotObtainedRoleDevWeaponRecommendItemData : RoleDevWeaponRecommendItemDataBase
{
	// Token: 0x06012CFE RID: 77054 RVA: 0x00586E0B File Offset: 0x0058500B
	protected override void InitByRoleType(int roleId)
	{
		base.InitSubRecommendItems(roleId);
	}

	// Token: 0x06012CFF RID: 77055 RVA: 0x00586E14 File Offset: 0x00585014
	protected override int GetWeaponConfigId()
	{
		return 0;
	}

	// Token: 0x06012D00 RID: 77056 RVA: 0x00586E18 File Offset: 0x00585018
	[NullableContext(1)]
	protected override string GetWeaponName()
	{
		RoleDevProject? roleDevProjectConfig = RoleDevConfig.Instance.GetRoleDevProjectConfig(base.RoleId);
		if (roleDevProjectConfig == null)
		{
			return "";
		}
		RoleDevWeaponItem? roleDevWeaponItemConfig = RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(roleDevProjectConfig.Value.WeaponType);
		if (roleDevWeaponItemConfig == null)
		{
			return "";
		}
		return roleDevWeaponItemConfig.Value.WeaponTypeDescribe;
	}

	// Token: 0x06012D01 RID: 77057 RVA: 0x00586E7D File Offset: 0x0058507D
	protected override int GetWeaponLevel()
	{
		return 1;
	}

	// Token: 0x06012D02 RID: 77058 RVA: 0x00586E80 File Offset: 0x00585080
	protected override int GetWeaponGoalUpgradeLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.WeaponLevel;
	}

	// Token: 0x06012D03 RID: 77059 RVA: 0x00586EB3 File Offset: 0x005850B3
	protected override bool GetIsCall()
	{
		return false;
	}

	// Token: 0x06012D04 RID: 77060 RVA: 0x00586EB6 File Offset: 0x005850B6
	protected override int GetGachaId()
	{
		return 0;
	}

	// Token: 0x06012D05 RID: 77061 RVA: 0x00586EB9 File Offset: 0x005850B9
	protected override bool GetIsWeaponHighQuality()
	{
		return true;
	}

	// Token: 0x06012D06 RID: 77062 RVA: 0x00586EBC File Offset: 0x005850BC
	protected override bool GetIsObtained()
	{
		return false;
	}

	// Token: 0x06012D07 RID: 77063 RVA: 0x00586EBF File Offset: 0x005850BF
	protected override bool GetIsForecast()
	{
		return false;
	}
}

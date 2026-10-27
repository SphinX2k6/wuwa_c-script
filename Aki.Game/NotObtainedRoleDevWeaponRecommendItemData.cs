using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200282C RID: 10284
public class NotObtainedRoleDevWeaponRecommendItemData : RoleDevWeaponRecommendItemDataBase
{
	// Token: 0x06015300 RID: 86784 RVA: 0x0055C0D3 File Offset: 0x0055A2D3
	protected override void InitByRoleType(int roleId)
	{
		base.InitSubRecommendItems(roleId);
	}

	// Token: 0x06015301 RID: 86785 RVA: 0x0055C0DC File Offset: 0x0055A2DC
	protected override int GetWeaponConfigId()
	{
		return 0;
	}

	// Token: 0x06015302 RID: 86786 RVA: 0x0055C0E0 File Offset: 0x0055A2E0
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

	// Token: 0x06015303 RID: 86787 RVA: 0x0055C145 File Offset: 0x0055A345
	protected override int GetWeaponLevel()
	{
		return 1;
	}

	// Token: 0x06015304 RID: 86788 RVA: 0x0055C148 File Offset: 0x0055A348
	protected override int GetWeaponGoalUpgradeLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.WeaponLevel;
	}

	// Token: 0x06015305 RID: 86789 RVA: 0x0055C17B File Offset: 0x0055A37B
	protected override bool GetIsCall()
	{
		return false;
	}

	// Token: 0x06015306 RID: 86790 RVA: 0x0055C17E File Offset: 0x0055A37E
	protected override int GetGachaId()
	{
		return 0;
	}

	// Token: 0x06015307 RID: 86791 RVA: 0x0055C181 File Offset: 0x0055A381
	protected override bool GetIsWeaponHighQuality()
	{
		return true;
	}

	// Token: 0x06015308 RID: 86792 RVA: 0x0055C184 File Offset: 0x0055A384
	protected override bool GetIsObtained()
	{
		return false;
	}

	// Token: 0x06015309 RID: 86793 RVA: 0x0055C187 File Offset: 0x0055A387
	protected override bool GetIsForecast()
	{
		return false;
	}
}

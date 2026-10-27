using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002828 RID: 10280
public class ForecastRoleDevWeaponRecommendItemData : RoleDevWeaponRecommendItemDataBase
{
	// Token: 0x060152C9 RID: 86729 RVA: 0x0055B922 File Offset: 0x00559B22
	protected override void InitByRoleType(int roleId)
	{
		this.SubRecommendItemsInternal.Clear();
	}

	// Token: 0x060152CA RID: 86730 RVA: 0x0055B92F File Offset: 0x00559B2F
	protected override int GetWeaponConfigId()
	{
		return 0;
	}

	// Token: 0x060152CB RID: 86731 RVA: 0x0055B932 File Offset: 0x00559B32
	[NullableContext(1)]
	protected override string GetWeaponName()
	{
		return "";
	}

	// Token: 0x060152CC RID: 86732 RVA: 0x0055B939 File Offset: 0x00559B39
	protected override int GetWeaponLevel()
	{
		return 1;
	}

	// Token: 0x060152CD RID: 86733 RVA: 0x0055B93C File Offset: 0x00559B3C
	protected override int GetWeaponGoalUpgradeLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.WeaponLevel;
	}

	// Token: 0x060152CE RID: 86734 RVA: 0x0055B96F File Offset: 0x00559B6F
	protected override bool GetIsCall()
	{
		return false;
	}

	// Token: 0x060152CF RID: 86735 RVA: 0x0055B972 File Offset: 0x00559B72
	protected override int GetGachaId()
	{
		return 0;
	}

	// Token: 0x060152D0 RID: 86736 RVA: 0x0055B975 File Offset: 0x00559B75
	protected override bool GetIsWeaponHighQuality()
	{
		return false;
	}

	// Token: 0x060152D1 RID: 86737 RVA: 0x0055B978 File Offset: 0x00559B78
	protected override bool GetIsObtained()
	{
		return false;
	}

	// Token: 0x060152D2 RID: 86738 RVA: 0x0055B97B File Offset: 0x00559B7B
	protected override bool GetIsForecast()
	{
		return true;
	}
}

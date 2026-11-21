using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DA3 RID: 7587
public class ForecastRoleDevWeaponRecommendItemData : RoleDevWeaponRecommendItemDataBase
{
	// Token: 0x06012CC7 RID: 76999 RVA: 0x00586636 File Offset: 0x00584836
	protected override void InitByRoleType(int roleId)
	{
		this.SubRecommendItemsInternal.Clear();
	}

	// Token: 0x06012CC8 RID: 77000 RVA: 0x00586643 File Offset: 0x00584843
	protected override int GetWeaponConfigId()
	{
		return 0;
	}

	// Token: 0x06012CC9 RID: 77001 RVA: 0x00586646 File Offset: 0x00584846
	[NullableContext(1)]
	protected override string GetWeaponName()
	{
		return "";
	}

	// Token: 0x06012CCA RID: 77002 RVA: 0x0058664D File Offset: 0x0058484D
	protected override int GetWeaponLevel()
	{
		return 1;
	}

	// Token: 0x06012CCB RID: 77003 RVA: 0x00586650 File Offset: 0x00584850
	protected override int GetWeaponGoalUpgradeLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.WeaponLevel;
	}

	// Token: 0x06012CCC RID: 77004 RVA: 0x00586683 File Offset: 0x00584883
	protected override bool GetIsCall()
	{
		return false;
	}

	// Token: 0x06012CCD RID: 77005 RVA: 0x00586686 File Offset: 0x00584886
	protected override int GetGachaId()
	{
		return 0;
	}

	// Token: 0x06012CCE RID: 77006 RVA: 0x00586689 File Offset: 0x00584889
	protected override bool GetIsWeaponHighQuality()
	{
		return false;
	}

	// Token: 0x06012CCF RID: 77007 RVA: 0x0058668C File Offset: 0x0058488C
	protected override bool GetIsObtained()
	{
		return false;
	}

	// Token: 0x06012CD0 RID: 77008 RVA: 0x0058668F File Offset: 0x0058488F
	protected override bool GetIsForecast()
	{
		return true;
	}
}

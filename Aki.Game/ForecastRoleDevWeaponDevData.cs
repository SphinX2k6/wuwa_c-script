using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

// Token: 0x02001DA2 RID: 7586
[NullableContext(1)]
[Nullable(0)]
public class ForecastRoleDevWeaponDevData : RoleDevWeaponDevItemDataBase
{
	// Token: 0x06012CB7 RID: 76983 RVA: 0x00586550 File Offset: 0x00584750
	protected override void InitByRoleType(int roleId)
	{
		IRoleDevProsProjectConfig roleDevProsProjectConfig = RoleDevConfig.Instance.GetRoleDevProsProjectConfig(roleId);
		if (roleDevProsProjectConfig == null)
		{
			return;
		}
		this.WeaponTypeInternal = roleDevProsProjectConfig.WeaponType;
		this.InitDetailItemData();
	}

	// Token: 0x06012CB8 RID: 76984 RVA: 0x0058657F File Offset: 0x0058477F
	private void InitDetailItemData()
	{
		this.DetailItemDataInternal.InitByWeaponType(base.RoleId, this.WeaponTypeInternal);
	}

	// Token: 0x06012CB9 RID: 76985 RVA: 0x00586598 File Offset: 0x00584798
	protected override int GetWeaponLevel()
	{
		return 1;
	}

	// Token: 0x06012CBA RID: 76986 RVA: 0x0058659B File Offset: 0x0058479B
	protected override int GetWeaponBreachLevel()
	{
		return 0;
	}

	// Token: 0x06012CBB RID: 76987 RVA: 0x0058659E File Offset: 0x0058479E
	protected override int GetWeaponGoalUpgradeLevel()
	{
		IRoleDevProsProjectConfig roleDevProsProjectConfig = RoleDevConfig.Instance.GetRoleDevProsProjectConfig(base.RoleId);
		if (roleDevProsProjectConfig == null)
		{
			return 0;
		}
		return roleDevProsProjectConfig.WeaponGoalLevel;
	}

	// Token: 0x06012CBC RID: 76988 RVA: 0x005865BB File Offset: 0x005847BB
	protected override int GetWeaponGoalBreakLevel()
	{
		return 0;
	}

	// Token: 0x06012CBD RID: 76989 RVA: 0x005865BE File Offset: 0x005847BE
	protected override int GetMaxLevel()
	{
		return 0;
	}

	// Token: 0x06012CBE RID: 76990 RVA: 0x005865C1 File Offset: 0x005847C1
	protected override List<IRoleDevDetailItemData> GetDetailItems()
	{
		return this.DetailItemDataInternal.DetailItems;
	}

	// Token: 0x06012CBF RID: 76991 RVA: 0x005865D0 File Offset: 0x005847D0
	protected override string GetWeaponName()
	{
		RoleDevWeaponItem? roleDevWeaponItemConfig = RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(this.WeaponTypeInternal);
		if (roleDevWeaponItemConfig == null)
		{
			return "";
		}
		return roleDevWeaponItemConfig.Value.WeaponTypeDescribe;
	}

	// Token: 0x06012CC0 RID: 76992 RVA: 0x0058660C File Offset: 0x0058480C
	protected override bool GetIsCanUpgrade()
	{
		return base.IsCanShowUpgradeItem;
	}

	// Token: 0x06012CC1 RID: 76993 RVA: 0x00586614 File Offset: 0x00584814
	protected override bool GetIsCanBreach()
	{
		return false;
	}

	// Token: 0x06012CC2 RID: 76994 RVA: 0x00586617 File Offset: 0x00584817
	protected override bool GetIsCall()
	{
		return false;
	}

	// Token: 0x06012CC3 RID: 76995 RVA: 0x0058661A File Offset: 0x0058481A
	protected override int GetGachaId()
	{
		return 0;
	}

	// Token: 0x06012CC4 RID: 76996 RVA: 0x0058661D File Offset: 0x0058481D
	protected override int GetWeaponConfigId()
	{
		return 0;
	}

	// Token: 0x06012CC5 RID: 76997 RVA: 0x00586620 File Offset: 0x00584820
	protected override bool GetIsHighQuality()
	{
		return false;
	}

	// Token: 0x0400A274 RID: 41588
	private int WeaponTypeInternal;

	// Token: 0x0400A275 RID: 41589
	private readonly ForecastRoleDevWeaponDetailItemData DetailItemDataInternal = new ForecastRoleDevWeaponDetailItemData();
}

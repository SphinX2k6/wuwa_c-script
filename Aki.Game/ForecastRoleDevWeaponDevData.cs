using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

// Token: 0x02002827 RID: 10279
[NullableContext(1)]
[Nullable(0)]
public class ForecastRoleDevWeaponDevData : RoleDevWeaponDevItemDataBase
{
	// Token: 0x060152B9 RID: 86713 RVA: 0x0055B83C File Offset: 0x00559A3C
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

	// Token: 0x060152BA RID: 86714 RVA: 0x0055B86B File Offset: 0x00559A6B
	private void InitDetailItemData()
	{
		this.DetailItemDataInternal.InitByWeaponType(base.RoleId, this.WeaponTypeInternal);
	}

	// Token: 0x060152BB RID: 86715 RVA: 0x0055B884 File Offset: 0x00559A84
	protected override int GetWeaponLevel()
	{
		return 1;
	}

	// Token: 0x060152BC RID: 86716 RVA: 0x0055B887 File Offset: 0x00559A87
	protected override int GetWeaponBreachLevel()
	{
		return 0;
	}

	// Token: 0x060152BD RID: 86717 RVA: 0x0055B88A File Offset: 0x00559A8A
	protected override int GetWeaponGoalUpgradeLevel()
	{
		IRoleDevProsProjectConfig roleDevProsProjectConfig = RoleDevConfig.Instance.GetRoleDevProsProjectConfig(base.RoleId);
		if (roleDevProsProjectConfig == null)
		{
			return 0;
		}
		return roleDevProsProjectConfig.WeaponGoalLevel;
	}

	// Token: 0x060152BE RID: 86718 RVA: 0x0055B8A7 File Offset: 0x00559AA7
	protected override int GetWeaponGoalBreakLevel()
	{
		return 0;
	}

	// Token: 0x060152BF RID: 86719 RVA: 0x0055B8AA File Offset: 0x00559AAA
	protected override int GetMaxLevel()
	{
		return 0;
	}

	// Token: 0x060152C0 RID: 86720 RVA: 0x0055B8AD File Offset: 0x00559AAD
	protected override List<IRoleDevDetailItemData> GetDetailItems()
	{
		return this.DetailItemDataInternal.DetailItems;
	}

	// Token: 0x060152C1 RID: 86721 RVA: 0x0055B8BC File Offset: 0x00559ABC
	protected override string GetWeaponName()
	{
		RoleDevWeaponItem? roleDevWeaponItemConfig = RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(this.WeaponTypeInternal);
		if (roleDevWeaponItemConfig == null)
		{
			return "";
		}
		return roleDevWeaponItemConfig.Value.WeaponTypeDescribe;
	}

	// Token: 0x060152C2 RID: 86722 RVA: 0x0055B8F8 File Offset: 0x00559AF8
	protected override bool GetIsCanUpgrade()
	{
		return base.IsCanShowUpgradeItem;
	}

	// Token: 0x060152C3 RID: 86723 RVA: 0x0055B900 File Offset: 0x00559B00
	protected override bool GetIsCanBreach()
	{
		return false;
	}

	// Token: 0x060152C4 RID: 86724 RVA: 0x0055B903 File Offset: 0x00559B03
	protected override bool GetIsCall()
	{
		return false;
	}

	// Token: 0x060152C5 RID: 86725 RVA: 0x0055B906 File Offset: 0x00559B06
	protected override int GetGachaId()
	{
		return 0;
	}

	// Token: 0x060152C6 RID: 86726 RVA: 0x0055B909 File Offset: 0x00559B09
	protected override int GetWeaponConfigId()
	{
		return 0;
	}

	// Token: 0x060152C7 RID: 86727 RVA: 0x0055B90C File Offset: 0x00559B0C
	protected override bool GetIsHighQuality()
	{
		return false;
	}

	// Token: 0x04009E8B RID: 40587
	private int WeaponTypeInternal;

	// Token: 0x04009E8C RID: 40588
	private readonly ForecastRoleDevWeaponDetailItemData DetailItemDataInternal = new ForecastRoleDevWeaponDetailItemData();
}

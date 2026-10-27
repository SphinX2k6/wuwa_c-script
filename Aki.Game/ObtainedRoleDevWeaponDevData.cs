using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200282F RID: 10287
[NullableContext(1)]
[Nullable(0)]
public class ObtainedRoleDevWeaponDevData : RoleDevWeaponDevItemDataBase
{
	// Token: 0x06015325 RID: 86821 RVA: 0x0055C7D0 File Offset: 0x0055A9D0
	protected override void InitByRoleType(int roleId)
	{
		this.WeaponInstanceInternal = WeaponModel.Instance.GetWeaponInstanceByRoleId(roleId);
		if (this.WeaponInstanceInternal == null)
		{
			return;
		}
		this.InitDetailItemData();
	}

	// Token: 0x06015326 RID: 86822 RVA: 0x0055C7F2 File Offset: 0x0055A9F2
	private void InitDetailItemData()
	{
		if (this.WeaponInstanceInternal == null)
		{
			return;
		}
		this.DetailItemDataInternal.InitByWeaponInstance(base.RoleId, this.WeaponInstanceInternal);
	}

	// Token: 0x06015327 RID: 86823 RVA: 0x0055C814 File Offset: 0x0055AA14
	protected override int GetWeaponLevel()
	{
		WeaponInstance weaponInstanceInternal = this.WeaponInstanceInternal;
		if (weaponInstanceInternal == null)
		{
			return 1;
		}
		return weaponInstanceInternal.GetLevel();
	}

	// Token: 0x06015328 RID: 86824 RVA: 0x0055C827 File Offset: 0x0055AA27
	protected override int GetWeaponBreachLevel()
	{
		WeaponInstance weaponInstanceInternal = this.WeaponInstanceInternal;
		if (weaponInstanceInternal == null)
		{
			return 0;
		}
		return weaponInstanceInternal.GetBreachLevel();
	}

	// Token: 0x06015329 RID: 86825 RVA: 0x0055C83C File Offset: 0x0055AA3C
	protected override int GetWeaponGoalUpgradeLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.WeaponLevel;
	}

	// Token: 0x0601532A RID: 86826 RVA: 0x0055C870 File Offset: 0x0055AA70
	protected override int GetWeaponGoalBreakLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.WeaponBreachLevel;
	}

	// Token: 0x0601532B RID: 86827 RVA: 0x0055C8A3 File Offset: 0x0055AAA3
	protected override int GetMaxLevel()
	{
		WeaponInstance weaponInstanceInternal = this.WeaponInstanceInternal;
		if (weaponInstanceInternal == null)
		{
			return 0;
		}
		return weaponInstanceInternal.GetMaxLevel();
	}

	// Token: 0x0601532C RID: 86828 RVA: 0x0055C8B6 File Offset: 0x0055AAB6
	protected override List<IRoleDevDetailItemData> GetDetailItems()
	{
		return this.DetailItemDataInternal.DetailItems;
	}

	// Token: 0x0601532D RID: 86829 RVA: 0x0055C8C4 File Offset: 0x0055AAC4
	protected override string GetWeaponName()
	{
		if (this.WeaponInstanceInternal == null)
		{
			return "";
		}
		WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(this.WeaponInstanceInternal.GetItemId());
		if (weaponConfigByItemId == null)
		{
			return "";
		}
		return weaponConfigByItemId.Value.WeaponName;
	}

	// Token: 0x0601532E RID: 86830 RVA: 0x0055C913 File Offset: 0x0055AB13
	protected override bool GetIsCanUpgrade()
	{
		return this.WeaponInstanceInternal != null && base.IsCanShowUpgradeItem && this.WeaponInstanceInternal.GetLevel() < this.WeaponInstanceInternal.GetCurrentMaxLevel();
	}

	// Token: 0x0601532F RID: 86831 RVA: 0x0055C944 File Offset: 0x0055AB44
	protected override bool GetIsCanBreach()
	{
		if (this.WeaponInstanceInternal == null)
		{
			return false;
		}
		int? incId = this.WeaponInstanceInternal.GetIncId();
		if (incId == null)
		{
			return false;
		}
		EWeaponBreachState weaponBreachState = WeaponModel.Instance.GetWeaponBreachState(incId.Value);
		return base.IsCanShowBreachItem && weaponBreachState == EWeaponBreachState.CanBreach;
	}

	// Token: 0x06015330 RID: 86832 RVA: 0x0055C994 File Offset: 0x0055AB94
	protected override bool GetIsCall()
	{
		return RoleDevUtils.GetRoleGachaIds(WeaponModel.Instance.GetWeaponIdByRoleDataId(base.RoleId).GetValueOrDefault()).Length != 0;
	}

	// Token: 0x06015331 RID: 86833 RVA: 0x0055C9C4 File Offset: 0x0055ABC4
	protected override int GetGachaId()
	{
		int[] roleGachaIds = RoleDevUtils.GetRoleGachaIds(WeaponModel.Instance.GetWeaponIdByRoleDataId(base.RoleId).GetValueOrDefault());
		if (roleGachaIds.Length != 0)
		{
			return roleGachaIds[0];
		}
		return 0;
	}

	// Token: 0x06015332 RID: 86834 RVA: 0x0055C9F8 File Offset: 0x0055ABF8
	protected override int GetWeaponConfigId()
	{
		return WeaponModel.Instance.GetWeaponIdByRoleDataId(base.RoleId).GetValueOrDefault();
	}

	// Token: 0x06015333 RID: 86835 RVA: 0x0055CA1D File Offset: 0x0055AC1D
	protected override bool GetIsHighQuality()
	{
		return this.WeaponInstanceInternal != null && WeaponModel.Instance.IsWeaponHighQuality(this.WeaponInstanceInternal);
	}

	// Token: 0x17001C14 RID: 7188
	// (get) Token: 0x06015334 RID: 86836 RVA: 0x0055CA39 File Offset: 0x0055AC39
	public ObtainedRoleDevWeaponDetailItemData DetailItemData
	{
		get
		{
			return this.DetailItemDataInternal;
		}
	}

	// Token: 0x04009E97 RID: 40599
	[Nullable(2)]
	private WeaponInstance WeaponInstanceInternal;

	// Token: 0x04009E98 RID: 40600
	private readonly ObtainedRoleDevWeaponDetailItemData DetailItemDataInternal = new ObtainedRoleDevWeaponDetailItemData();
}

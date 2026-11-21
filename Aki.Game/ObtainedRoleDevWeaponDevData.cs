using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DAA RID: 7594
[NullableContext(1)]
[Nullable(0)]
public class ObtainedRoleDevWeaponDevData : RoleDevWeaponDevItemDataBase
{
	// Token: 0x06012D23 RID: 77091 RVA: 0x0058752C File Offset: 0x0058572C
	protected override void InitByRoleType(int roleId)
	{
		this.WeaponInstanceInternal = WeaponModel.Instance.GetWeaponInstanceByRoleId(roleId);
		if (this.WeaponInstanceInternal == null)
		{
			return;
		}
		this.InitDetailItemData();
	}

	// Token: 0x06012D24 RID: 77092 RVA: 0x0058754E File Offset: 0x0058574E
	private void InitDetailItemData()
	{
		if (this.WeaponInstanceInternal == null)
		{
			return;
		}
		this.DetailItemDataInternal.InitByWeaponInstance(base.RoleId, this.WeaponInstanceInternal);
	}

	// Token: 0x06012D25 RID: 77093 RVA: 0x00587570 File Offset: 0x00585770
	protected override int GetWeaponLevel()
	{
		WeaponInstance weaponInstanceInternal = this.WeaponInstanceInternal;
		if (weaponInstanceInternal == null)
		{
			return 1;
		}
		return weaponInstanceInternal.GetLevel();
	}

	// Token: 0x06012D26 RID: 77094 RVA: 0x00587583 File Offset: 0x00585783
	protected override int GetWeaponBreachLevel()
	{
		WeaponInstance weaponInstanceInternal = this.WeaponInstanceInternal;
		if (weaponInstanceInternal == null)
		{
			return 0;
		}
		return weaponInstanceInternal.GetBreachLevel();
	}

	// Token: 0x06012D27 RID: 77095 RVA: 0x00587598 File Offset: 0x00585798
	protected override int GetWeaponGoalUpgradeLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.WeaponLevel;
	}

	// Token: 0x06012D28 RID: 77096 RVA: 0x005875CC File Offset: 0x005857CC
	protected override int GetWeaponGoalBreakLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.WeaponBreachLevel;
	}

	// Token: 0x06012D29 RID: 77097 RVA: 0x005875FF File Offset: 0x005857FF
	protected override int GetMaxLevel()
	{
		WeaponInstance weaponInstanceInternal = this.WeaponInstanceInternal;
		if (weaponInstanceInternal == null)
		{
			return 0;
		}
		return weaponInstanceInternal.GetMaxLevel();
	}

	// Token: 0x06012D2A RID: 77098 RVA: 0x00587612 File Offset: 0x00585812
	protected override List<IRoleDevDetailItemData> GetDetailItems()
	{
		return this.DetailItemDataInternal.DetailItems;
	}

	// Token: 0x06012D2B RID: 77099 RVA: 0x00587620 File Offset: 0x00585820
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

	// Token: 0x06012D2C RID: 77100 RVA: 0x0058766F File Offset: 0x0058586F
	protected override bool GetIsCanUpgrade()
	{
		return this.WeaponInstanceInternal != null && base.IsCanShowUpgradeItem && this.WeaponInstanceInternal.GetLevel() < this.WeaponInstanceInternal.GetCurrentMaxLevel();
	}

	// Token: 0x06012D2D RID: 77101 RVA: 0x005876A0 File Offset: 0x005858A0
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

	// Token: 0x06012D2E RID: 77102 RVA: 0x005876F0 File Offset: 0x005858F0
	protected override bool GetIsCall()
	{
		return RoleDevUtils.GetRoleGachaIds(WeaponModel.Instance.GetWeaponIdByRoleDataId(base.RoleId).GetValueOrDefault()).Length != 0;
	}

	// Token: 0x06012D2F RID: 77103 RVA: 0x00587720 File Offset: 0x00585920
	protected override int GetGachaId()
	{
		int[] roleGachaIds = RoleDevUtils.GetRoleGachaIds(WeaponModel.Instance.GetWeaponIdByRoleDataId(base.RoleId).GetValueOrDefault());
		if (roleGachaIds.Length != 0)
		{
			return roleGachaIds[0];
		}
		return 0;
	}

	// Token: 0x06012D30 RID: 77104 RVA: 0x00587754 File Offset: 0x00585954
	protected override int GetWeaponConfigId()
	{
		return WeaponModel.Instance.GetWeaponIdByRoleDataId(base.RoleId).GetValueOrDefault();
	}

	// Token: 0x06012D31 RID: 77105 RVA: 0x00587779 File Offset: 0x00585979
	protected override bool GetIsHighQuality()
	{
		return this.WeaponInstanceInternal != null && WeaponModel.Instance.IsWeaponHighQuality(this.WeaponInstanceInternal);
	}

	// Token: 0x17001C6C RID: 7276
	// (get) Token: 0x06012D32 RID: 77106 RVA: 0x00587795 File Offset: 0x00585995
	public ObtainedRoleDevWeaponDetailItemData DetailItemData
	{
		get
		{
			return this.DetailItemDataInternal;
		}
	}

	// Token: 0x0400A280 RID: 41600
	[Nullable(2)]
	private WeaponInstance WeaponInstanceInternal;

	// Token: 0x0400A281 RID: 41601
	private readonly ObtainedRoleDevWeaponDetailItemData DetailItemDataInternal = new ObtainedRoleDevWeaponDetailItemData();
}

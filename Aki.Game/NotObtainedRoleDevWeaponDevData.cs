using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DA6 RID: 7590
[NullableContext(1)]
[Nullable(0)]
public class NotObtainedRoleDevWeaponDevData : RoleDevWeaponDevItemDataBase
{
	// Token: 0x06012CED RID: 77037 RVA: 0x00586CC0 File Offset: 0x00584EC0
	protected override void InitByRoleType(int roleId)
	{
		RoleDevProject? roleDevProjectConfig = RoleDevConfig.Instance.GetRoleDevProjectConfig(roleId);
		if (roleDevProjectConfig == null)
		{
			return;
		}
		this.WeaponTypeInternal = roleDevProjectConfig.Value.WeaponType;
		this.InitDetailItemData();
	}

	// Token: 0x06012CEE RID: 77038 RVA: 0x00586CFE File Offset: 0x00584EFE
	private void InitDetailItemData()
	{
		this.DetailItemDataInternal.InitByWeaponType(base.RoleId, this.WeaponTypeInternal);
	}

	// Token: 0x06012CEF RID: 77039 RVA: 0x00586D17 File Offset: 0x00584F17
	protected override int GetWeaponLevel()
	{
		return 1;
	}

	// Token: 0x06012CF0 RID: 77040 RVA: 0x00586D1A File Offset: 0x00584F1A
	protected override int GetWeaponBreachLevel()
	{
		return 0;
	}

	// Token: 0x06012CF1 RID: 77041 RVA: 0x00586D20 File Offset: 0x00584F20
	protected override int GetWeaponGoalUpgradeLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.WeaponLevel;
	}

	// Token: 0x06012CF2 RID: 77042 RVA: 0x00586D54 File Offset: 0x00584F54
	protected override int GetWeaponGoalBreakLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.WeaponBreachLevel;
	}

	// Token: 0x06012CF3 RID: 77043 RVA: 0x00586D87 File Offset: 0x00584F87
	protected override int GetMaxLevel()
	{
		return 0;
	}

	// Token: 0x06012CF4 RID: 77044 RVA: 0x00586D8A File Offset: 0x00584F8A
	protected override List<IRoleDevDetailItemData> GetDetailItems()
	{
		return this.DetailItemDataInternal.DetailItems;
	}

	// Token: 0x06012CF5 RID: 77045 RVA: 0x00586D98 File Offset: 0x00584F98
	protected override string GetWeaponName()
	{
		RoleDevWeaponItem? roleDevWeaponItemConfig = RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(this.WeaponTypeInternal);
		if (roleDevWeaponItemConfig == null)
		{
			return "";
		}
		return roleDevWeaponItemConfig.Value.WeaponTypeDescribe;
	}

	// Token: 0x06012CF6 RID: 77046 RVA: 0x00586DD4 File Offset: 0x00584FD4
	protected override bool GetIsCanUpgrade()
	{
		return base.IsCanShowUpgradeItem;
	}

	// Token: 0x06012CF7 RID: 77047 RVA: 0x00586DDC File Offset: 0x00584FDC
	protected override bool GetIsCanBreach()
	{
		return base.IsCanShowBreachItem;
	}

	// Token: 0x06012CF8 RID: 77048 RVA: 0x00586DE4 File Offset: 0x00584FE4
	protected override bool GetIsCall()
	{
		return false;
	}

	// Token: 0x06012CF9 RID: 77049 RVA: 0x00586DE7 File Offset: 0x00584FE7
	protected override int GetGachaId()
	{
		return 0;
	}

	// Token: 0x06012CFA RID: 77050 RVA: 0x00586DEA File Offset: 0x00584FEA
	protected override int GetWeaponConfigId()
	{
		return 0;
	}

	// Token: 0x06012CFB RID: 77051 RVA: 0x00586DED File Offset: 0x00584FED
	protected override bool GetIsHighQuality()
	{
		return false;
	}

	// Token: 0x17001C6A RID: 7274
	// (get) Token: 0x06012CFC RID: 77052 RVA: 0x00586DF0 File Offset: 0x00584FF0
	public NotObtainedRoleDevWeaponDetailItemData DetailItemData
	{
		get
		{
			return this.DetailItemDataInternal;
		}
	}

	// Token: 0x0400A27A RID: 41594
	private int WeaponTypeInternal;

	// Token: 0x0400A27B RID: 41595
	private readonly NotObtainedRoleDevWeaponDetailItemData DetailItemDataInternal = new NotObtainedRoleDevWeaponDetailItemData();
}

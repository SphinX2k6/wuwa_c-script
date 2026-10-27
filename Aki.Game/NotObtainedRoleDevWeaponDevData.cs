using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200282B RID: 10283
[NullableContext(1)]
[Nullable(0)]
public class NotObtainedRoleDevWeaponDevData : RoleDevWeaponDevItemDataBase
{
	// Token: 0x060152EF RID: 86767 RVA: 0x0055BF88 File Offset: 0x0055A188
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

	// Token: 0x060152F0 RID: 86768 RVA: 0x0055BFC6 File Offset: 0x0055A1C6
	private void InitDetailItemData()
	{
		this.DetailItemDataInternal.InitByWeaponType(base.RoleId, this.WeaponTypeInternal);
	}

	// Token: 0x060152F1 RID: 86769 RVA: 0x0055BFDF File Offset: 0x0055A1DF
	protected override int GetWeaponLevel()
	{
		return 1;
	}

	// Token: 0x060152F2 RID: 86770 RVA: 0x0055BFE2 File Offset: 0x0055A1E2
	protected override int GetWeaponBreachLevel()
	{
		return 0;
	}

	// Token: 0x060152F3 RID: 86771 RVA: 0x0055BFE8 File Offset: 0x0055A1E8
	protected override int GetWeaponGoalUpgradeLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.WeaponLevel;
	}

	// Token: 0x060152F4 RID: 86772 RVA: 0x0055C01C File Offset: 0x0055A21C
	protected override int GetWeaponGoalBreakLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.WeaponBreachLevel;
	}

	// Token: 0x060152F5 RID: 86773 RVA: 0x0055C04F File Offset: 0x0055A24F
	protected override int GetMaxLevel()
	{
		return 0;
	}

	// Token: 0x060152F6 RID: 86774 RVA: 0x0055C052 File Offset: 0x0055A252
	protected override List<IRoleDevDetailItemData> GetDetailItems()
	{
		return this.DetailItemDataInternal.DetailItems;
	}

	// Token: 0x060152F7 RID: 86775 RVA: 0x0055C060 File Offset: 0x0055A260
	protected override string GetWeaponName()
	{
		RoleDevWeaponItem? roleDevWeaponItemConfig = RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(this.WeaponTypeInternal);
		if (roleDevWeaponItemConfig == null)
		{
			return "";
		}
		return roleDevWeaponItemConfig.Value.WeaponTypeDescribe;
	}

	// Token: 0x060152F8 RID: 86776 RVA: 0x0055C09C File Offset: 0x0055A29C
	protected override bool GetIsCanUpgrade()
	{
		return base.IsCanShowUpgradeItem;
	}

	// Token: 0x060152F9 RID: 86777 RVA: 0x0055C0A4 File Offset: 0x0055A2A4
	protected override bool GetIsCanBreach()
	{
		return base.IsCanShowBreachItem;
	}

	// Token: 0x060152FA RID: 86778 RVA: 0x0055C0AC File Offset: 0x0055A2AC
	protected override bool GetIsCall()
	{
		return false;
	}

	// Token: 0x060152FB RID: 86779 RVA: 0x0055C0AF File Offset: 0x0055A2AF
	protected override int GetGachaId()
	{
		return 0;
	}

	// Token: 0x060152FC RID: 86780 RVA: 0x0055C0B2 File Offset: 0x0055A2B2
	protected override int GetWeaponConfigId()
	{
		return 0;
	}

	// Token: 0x060152FD RID: 86781 RVA: 0x0055C0B5 File Offset: 0x0055A2B5
	protected override bool GetIsHighQuality()
	{
		return false;
	}

	// Token: 0x17001C12 RID: 7186
	// (get) Token: 0x060152FE RID: 86782 RVA: 0x0055C0B8 File Offset: 0x0055A2B8
	public NotObtainedRoleDevWeaponDetailItemData DetailItemData
	{
		get
		{
			return this.DetailItemDataInternal;
		}
	}

	// Token: 0x04009E91 RID: 40593
	private int WeaponTypeInternal;

	// Token: 0x04009E92 RID: 40594
	private readonly NotObtainedRoleDevWeaponDetailItemData DetailItemDataInternal = new NotObtainedRoleDevWeaponDetailItemData();
}

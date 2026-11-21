using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02001DAC RID: 7596
[NullableContext(2)]
[Nullable(0)]
public class ObtainedRoleDevWeaponViewItemData : RoleDevWeaponViewItemDataBase
{
	// Token: 0x06012D3F RID: 77119 RVA: 0x005878FC File Offset: 0x00585AFC
	[NullableContext(1)]
	protected override void InitByRoleType(int roleId, RoleDevViewModel roleDevViewModel)
	{
		this.InitBaseInfo(roleId);
		this.InitItemData(roleId);
		if (this.RoleDevViewModelInternal == null || !this.RoleDevViewModelInternal.CheckRoleIdIsCreated(roleId))
		{
			ERoleDevWeaponTabType weaponTabType = this.IsWeaponHighQualityInternal ? ERoleDevWeaponTabType.WeaponDev : ERoleDevWeaponTabType.WeaponRecommend;
			this.RoleDevViewModelInternal.SetRoleWeaponTabType(roleId, weaponTabType);
			return;
		}
		if (!this.IsWeaponHighQualityInternal)
		{
			this.RoleDevViewModelInternal.SetRoleWeaponTabType(roleId, ERoleDevWeaponTabType.WeaponRecommend);
		}
	}

	// Token: 0x06012D40 RID: 77120 RVA: 0x00587960 File Offset: 0x00585B60
	private void InitBaseInfo(int roleId)
	{
		WeaponInstance weaponInstanceByRoleId = WeaponModel.Instance.GetWeaponInstanceByRoleId(roleId);
		if (weaponInstanceByRoleId == null)
		{
			this.IsWeaponHighQualityInternal = true;
			return;
		}
		this.IsWeaponHighQualityInternal = WeaponModel.Instance.IsWeaponHighQuality(weaponInstanceByRoleId);
	}

	// Token: 0x06012D41 RID: 77121 RVA: 0x00587995 File Offset: 0x00585B95
	private void InitItemData(int roleId)
	{
		this.DevItemDataInternal = RoleDevWeaponDevItemDataFactory.Create(roleId);
		this.RecommendItemDataInternal = RoleDevWeaponRecommendItemDataFactory.Create(roleId);
	}

	// Token: 0x06012D42 RID: 77122 RVA: 0x005879AF File Offset: 0x00585BAF
	protected override bool GetIsRoleObtained()
	{
		return true;
	}

	// Token: 0x06012D43 RID: 77123 RVA: 0x005879B2 File Offset: 0x00585BB2
	protected override RoleDevWeaponDevItemDataBase GetDevItemData()
	{
		return this.DevItemDataInternal;
	}

	// Token: 0x06012D44 RID: 77124 RVA: 0x005879BA File Offset: 0x00585BBA
	protected override RoleDevWeaponRecommendItemDataBase GetRecommendItemData()
	{
		return this.RecommendItemDataInternal;
	}

	// Token: 0x06012D45 RID: 77125 RVA: 0x005879C2 File Offset: 0x00585BC2
	protected override bool GetIsWeaponHighQuality()
	{
		return this.IsWeaponHighQualityInternal;
	}

	// Token: 0x0400A282 RID: 41602
	private RoleDevWeaponDevItemDataBase DevItemDataInternal;

	// Token: 0x0400A283 RID: 41603
	private RoleDevWeaponRecommendItemDataBase RecommendItemDataInternal;

	// Token: 0x0400A284 RID: 41604
	private bool IsWeaponHighQualityInternal;
}

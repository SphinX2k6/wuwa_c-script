using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02002831 RID: 10289
[NullableContext(2)]
[Nullable(0)]
public class ObtainedRoleDevWeaponViewItemData : RoleDevWeaponViewItemDataBase
{
	// Token: 0x06015341 RID: 86849 RVA: 0x0055CBA0 File Offset: 0x0055ADA0
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

	// Token: 0x06015342 RID: 86850 RVA: 0x0055CC04 File Offset: 0x0055AE04
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

	// Token: 0x06015343 RID: 86851 RVA: 0x0055CC39 File Offset: 0x0055AE39
	private void InitItemData(int roleId)
	{
		this.DevItemDataInternal = RoleDevWeaponDevItemDataFactory.Create(roleId);
		this.RecommendItemDataInternal = RoleDevWeaponRecommendItemDataFactory.Create(roleId);
	}

	// Token: 0x06015344 RID: 86852 RVA: 0x0055CC53 File Offset: 0x0055AE53
	protected override bool GetIsRoleObtained()
	{
		return true;
	}

	// Token: 0x06015345 RID: 86853 RVA: 0x0055CC56 File Offset: 0x0055AE56
	protected override RoleDevWeaponDevItemDataBase GetDevItemData()
	{
		return this.DevItemDataInternal;
	}

	// Token: 0x06015346 RID: 86854 RVA: 0x0055CC5E File Offset: 0x0055AE5E
	protected override RoleDevWeaponRecommendItemDataBase GetRecommendItemData()
	{
		return this.RecommendItemDataInternal;
	}

	// Token: 0x06015347 RID: 86855 RVA: 0x0055CC66 File Offset: 0x0055AE66
	protected override bool GetIsWeaponHighQuality()
	{
		return this.IsWeaponHighQualityInternal;
	}

	// Token: 0x04009E99 RID: 40601
	private RoleDevWeaponDevItemDataBase DevItemDataInternal;

	// Token: 0x04009E9A RID: 40602
	private RoleDevWeaponRecommendItemDataBase RecommendItemDataInternal;

	// Token: 0x04009E9B RID: 40603
	private bool IsWeaponHighQualityInternal;
}

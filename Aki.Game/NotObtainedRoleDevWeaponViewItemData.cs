using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x0200282D RID: 10285
[NullableContext(2)]
[Nullable(0)]
public class NotObtainedRoleDevWeaponViewItemData : RoleDevWeaponViewItemDataBase
{
	// Token: 0x0601530B RID: 86795 RVA: 0x0055C192 File Offset: 0x0055A392
	[NullableContext(1)]
	protected override void InitByRoleType(int roleId, RoleDevViewModel roleDevViewModel)
	{
		this.InitBaseInfo(roleId);
		this.InitItemData(roleId);
		if (this.RoleDevViewModelInternal == null || !this.RoleDevViewModelInternal.CheckRoleIdIsCreated(roleId))
		{
			RoleDevViewModel roleDevViewModelInternal = this.RoleDevViewModelInternal;
			if (roleDevViewModelInternal == null)
			{
				return;
			}
			roleDevViewModelInternal.SetRoleWeaponTabType(roleId, ERoleDevWeaponTabType.WeaponDev);
		}
	}

	// Token: 0x0601530C RID: 86796 RVA: 0x0055C1CC File Offset: 0x0055A3CC
	private void InitBaseInfo(int roleId)
	{
		if (RoleDevConfig.Instance.GetRoleDevProjectConfig(roleId) == null)
		{
			return;
		}
		this.IsWeaponHighQualityInternal = true;
	}

	// Token: 0x0601530D RID: 86797 RVA: 0x0055C1F6 File Offset: 0x0055A3F6
	private void InitItemData(int roleId)
	{
		this.DevItemDataInternal = RoleDevWeaponDevItemDataFactory.Create(roleId);
		this.RecommendItemDataInternal = RoleDevWeaponRecommendItemDataFactory.Create(roleId);
	}

	// Token: 0x0601530E RID: 86798 RVA: 0x0055C210 File Offset: 0x0055A410
	protected override bool GetIsRoleObtained()
	{
		return false;
	}

	// Token: 0x0601530F RID: 86799 RVA: 0x0055C213 File Offset: 0x0055A413
	protected override RoleDevWeaponDevItemDataBase GetDevItemData()
	{
		return this.DevItemDataInternal;
	}

	// Token: 0x06015310 RID: 86800 RVA: 0x0055C21B File Offset: 0x0055A41B
	protected override RoleDevWeaponRecommendItemDataBase GetRecommendItemData()
	{
		return this.RecommendItemDataInternal;
	}

	// Token: 0x06015311 RID: 86801 RVA: 0x0055C223 File Offset: 0x0055A423
	protected override bool GetIsWeaponHighQuality()
	{
		return this.IsWeaponHighQualityInternal;
	}

	// Token: 0x04009E93 RID: 40595
	private RoleDevWeaponDevItemDataBase DevItemDataInternal;

	// Token: 0x04009E94 RID: 40596
	private RoleDevWeaponRecommendItemDataBase RecommendItemDataInternal;

	// Token: 0x04009E95 RID: 40597
	private bool IsWeaponHighQualityInternal;
}

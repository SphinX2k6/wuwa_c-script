using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02001DA8 RID: 7592
[NullableContext(2)]
[Nullable(0)]
public class NotObtainedRoleDevWeaponViewItemData : RoleDevWeaponViewItemDataBase
{
	// Token: 0x06012D09 RID: 77065 RVA: 0x00586ECA File Offset: 0x005850CA
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

	// Token: 0x06012D0A RID: 77066 RVA: 0x00586F04 File Offset: 0x00585104
	private void InitBaseInfo(int roleId)
	{
		if (RoleDevConfig.Instance.GetRoleDevProjectConfig(roleId) == null)
		{
			return;
		}
		this.IsWeaponHighQualityInternal = true;
	}

	// Token: 0x06012D0B RID: 77067 RVA: 0x00586F2E File Offset: 0x0058512E
	private void InitItemData(int roleId)
	{
		this.DevItemDataInternal = RoleDevWeaponDevItemDataFactory.Create(roleId);
		this.RecommendItemDataInternal = RoleDevWeaponRecommendItemDataFactory.Create(roleId);
	}

	// Token: 0x06012D0C RID: 77068 RVA: 0x00586F48 File Offset: 0x00585148
	protected override bool GetIsRoleObtained()
	{
		return false;
	}

	// Token: 0x06012D0D RID: 77069 RVA: 0x00586F4B File Offset: 0x0058514B
	protected override RoleDevWeaponDevItemDataBase GetDevItemData()
	{
		return this.DevItemDataInternal;
	}

	// Token: 0x06012D0E RID: 77070 RVA: 0x00586F53 File Offset: 0x00585153
	protected override RoleDevWeaponRecommendItemDataBase GetRecommendItemData()
	{
		return this.RecommendItemDataInternal;
	}

	// Token: 0x06012D0F RID: 77071 RVA: 0x00586F5B File Offset: 0x0058515B
	protected override bool GetIsWeaponHighQuality()
	{
		return this.IsWeaponHighQualityInternal;
	}

	// Token: 0x0400A27C RID: 41596
	private RoleDevWeaponDevItemDataBase DevItemDataInternal;

	// Token: 0x0400A27D RID: 41597
	private RoleDevWeaponRecommendItemDataBase RecommendItemDataInternal;

	// Token: 0x0400A27E RID: 41598
	private bool IsWeaponHighQualityInternal;
}

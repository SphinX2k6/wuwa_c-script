using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02002829 RID: 10281
[NullableContext(2)]
[Nullable(0)]
public class ForecastRoleDevWeaponViewItemData : RoleDevWeaponViewItemDataBase
{
	// Token: 0x060152D4 RID: 86740 RVA: 0x0055B986 File Offset: 0x00559B86
	[NullableContext(1)]
	protected override void InitByRoleType(int roleId, RoleDevViewModel roleDevViewModel)
	{
		this.InitBaseInfo(roleId);
		this.InitItemData(roleId);
		RoleDevViewModel roleDevViewModelInternal = this.RoleDevViewModelInternal;
		if (roleDevViewModelInternal == null)
		{
			return;
		}
		roleDevViewModelInternal.SetRoleWeaponTabType(roleId, ERoleDevWeaponTabType.WeaponDev);
	}

	// Token: 0x060152D5 RID: 86741 RVA: 0x0055B9A8 File Offset: 0x00559BA8
	private void InitBaseInfo(int roleId)
	{
		this.IsWeaponHighQualityInternal = true;
	}

	// Token: 0x060152D6 RID: 86742 RVA: 0x0055B9B1 File Offset: 0x00559BB1
	private void InitItemData(int roleId)
	{
		this.DevItemDataInternal = RoleDevWeaponDevItemDataFactory.Create(roleId);
	}

	// Token: 0x060152D7 RID: 86743 RVA: 0x0055B9BF File Offset: 0x00559BBF
	protected override bool GetIsRoleObtained()
	{
		return false;
	}

	// Token: 0x060152D8 RID: 86744 RVA: 0x0055B9C2 File Offset: 0x00559BC2
	protected override RoleDevWeaponDevItemDataBase GetDevItemData()
	{
		return this.DevItemDataInternal;
	}

	// Token: 0x060152D9 RID: 86745 RVA: 0x0055B9CA File Offset: 0x00559BCA
	protected override RoleDevWeaponRecommendItemDataBase GetRecommendItemData()
	{
		return this.RecommendItemDataInternal;
	}

	// Token: 0x060152DA RID: 86746 RVA: 0x0055B9D2 File Offset: 0x00559BD2
	protected override bool GetIsWeaponHighQuality()
	{
		return this.IsWeaponHighQualityInternal;
	}

	// Token: 0x04009E8D RID: 40589
	private RoleDevWeaponDevItemDataBase DevItemDataInternal;

	// Token: 0x04009E8E RID: 40590
	private readonly RoleDevWeaponRecommendItemDataBase RecommendItemDataInternal;

	// Token: 0x04009E8F RID: 40591
	private bool IsWeaponHighQualityInternal;
}

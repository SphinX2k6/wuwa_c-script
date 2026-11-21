using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02001DA4 RID: 7588
[NullableContext(2)]
[Nullable(0)]
public class ForecastRoleDevWeaponViewItemData : RoleDevWeaponViewItemDataBase
{
	// Token: 0x06012CD2 RID: 77010 RVA: 0x0058669A File Offset: 0x0058489A
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

	// Token: 0x06012CD3 RID: 77011 RVA: 0x005866BC File Offset: 0x005848BC
	private void InitBaseInfo(int roleId)
	{
		this.IsWeaponHighQualityInternal = true;
	}

	// Token: 0x06012CD4 RID: 77012 RVA: 0x005866C5 File Offset: 0x005848C5
	private void InitItemData(int roleId)
	{
		this.DevItemDataInternal = RoleDevWeaponDevItemDataFactory.Create(roleId);
	}

	// Token: 0x06012CD5 RID: 77013 RVA: 0x005866D3 File Offset: 0x005848D3
	protected override bool GetIsRoleObtained()
	{
		return false;
	}

	// Token: 0x06012CD6 RID: 77014 RVA: 0x005866D6 File Offset: 0x005848D6
	protected override RoleDevWeaponDevItemDataBase GetDevItemData()
	{
		return this.DevItemDataInternal;
	}

	// Token: 0x06012CD7 RID: 77015 RVA: 0x005866DE File Offset: 0x005848DE
	protected override RoleDevWeaponRecommendItemDataBase GetRecommendItemData()
	{
		return this.RecommendItemDataInternal;
	}

	// Token: 0x06012CD8 RID: 77016 RVA: 0x005866E6 File Offset: 0x005848E6
	protected override bool GetIsWeaponHighQuality()
	{
		return this.IsWeaponHighQualityInternal;
	}

	// Token: 0x0400A276 RID: 41590
	private RoleDevWeaponDevItemDataBase DevItemDataInternal;

	// Token: 0x0400A277 RID: 41591
	private readonly RoleDevWeaponRecommendItemDataBase RecommendItemDataInternal;

	// Token: 0x0400A278 RID: 41592
	private bool IsWeaponHighQualityInternal;
}

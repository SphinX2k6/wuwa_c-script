using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;

// Token: 0x02002A1F RID: 10783
[NullableContext(1)]
[Nullable(0)]
public class RoleSkinData
{
	// Token: 0x0601663A RID: 91706 RVA: 0x005A9F40 File Offset: 0x005A8140
	public RoleSkinData(int itemId)
	{
		this.ItemId = itemId;
		this.RoleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(this.ItemId).GetValueOrDefault();
	}

	// Token: 0x0601663B RID: 91707 RVA: 0x005A9F7F File Offset: 0x005A817F
	public ItemConfig GetItemConfig()
	{
		return InventoryConfig.Instance.GetItemConfigData(this.ItemId);
	}

	// Token: 0x0601663C RID: 91708 RVA: 0x005A9F91 File Offset: 0x005A8191
	public int GetItemId()
	{
		return this.ItemId;
	}

	// Token: 0x0601663D RID: 91709 RVA: 0x005A9F99 File Offset: 0x005A8199
	public string GetName()
	{
		return this.GetItemConfig().Name;
	}

	// Token: 0x0601663E RID: 91710 RVA: 0x005A9FA8 File Offset: 0x005A81A8
	public string GetTitleName()
	{
		return this.GetRoleSkinConfig().TitleName;
	}

	// Token: 0x0601663F RID: 91711 RVA: 0x005A9FC4 File Offset: 0x005A81C4
	public string GetSubTitle()
	{
		return this.GetRoleSkinConfig().SubDecName;
	}

	// Token: 0x06016640 RID: 91712 RVA: 0x005A9FDF File Offset: 0x005A81DF
	public string GetDesc()
	{
		return this.GetItemConfig().BgDescription;
	}

	// Token: 0x06016641 RID: 91713 RVA: 0x005A9FEC File Offset: 0x005A81EC
	public string GetFunctionDesc()
	{
		return this.GetRoleSkinConfig().FunctionDesc;
	}

	// Token: 0x06016642 RID: 91714 RVA: 0x005AA007 File Offset: 0x005A8207
	public int GetQuality()
	{
		return this.GetItemConfig().QualityId;
	}

	// Token: 0x06016643 RID: 91715 RVA: 0x005AA014 File Offset: 0x005A8214
	public bool IsLocked()
	{
		return this.IsLock;
	}

	// Token: 0x06016644 RID: 91716 RVA: 0x005AA01C File Offset: 0x005A821C
	public void LockSkin()
	{
		this.IsLock = true;
	}

	// Token: 0x06016645 RID: 91717 RVA: 0x005AA025 File Offset: 0x005A8225
	public void UnlockSkin()
	{
		this.IsLock = false;
	}

	// Token: 0x06016646 RID: 91718 RVA: 0x005AA030 File Offset: 0x005A8230
	public bool IsWear()
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.GetRoleId());
		return roleInstanceById != null && roleInstanceById.GetRoleSkinId() == this.ItemId;
	}

	// Token: 0x06016647 RID: 91719 RVA: 0x005AA064 File Offset: 0x005A8264
	public bool IsOriginalSkin()
	{
		int roleId = this.RoleSkinConfig.RoleId;
		return RoleConfig.Instance.GetRoleConfig(roleId).Value.SkinId == this.ItemId;
	}

	// Token: 0x06016648 RID: 91720 RVA: 0x005AA0A3 File Offset: 0x005A82A3
	public int GetItemCount()
	{
		return (!this.IsLocked()) ? 1 : 0;
	}

	// Token: 0x06016649 RID: 91721 RVA: 0x005AA0AE File Offset: 0x005A82AE
	public RoleSkin GetRoleSkinConfig()
	{
		return this.RoleSkinConfig;
	}

	// Token: 0x0601664A RID: 91722 RVA: 0x005AA0B8 File Offset: 0x005A82B8
	public int GetRoleId()
	{
		return this.GetRoleSkinConfig().RoleId;
	}

	// Token: 0x0601664B RID: 91723 RVA: 0x005AA0D4 File Offset: 0x005A82D4
	public int GetUiMeshId()
	{
		return this.RoleSkinConfig.UiMeshId;
	}

	// Token: 0x0601664C RID: 91724 RVA: 0x005AA0EF File Offset: 0x005A82EF
	public bool GetIfHaveRole()
	{
		return RoleModel.Instance.GetRoleInstanceById(this.GetRoleId()) != null;
	}

	// Token: 0x0601664D RID: 91725 RVA: 0x005AA104 File Offset: 0x005A8304
	public bool IsWearWeaponSkin()
	{
		if (this.IsLocked())
		{
			return false;
		}
		if (!this.IsWear())
		{
			return false;
		}
		int suitWeaponSkinId = this.RoleSkinConfig.SuitWeaponSkinId;
		return suitWeaponSkinId > 0 && WeaponSkinModel.Instance.GetSkinIdByRoleId(this.GetRoleId()) == suitWeaponSkinId;
	}

	// Token: 0x0601664E RID: 91726 RVA: 0x005AA150 File Offset: 0x005A8350
	public string GetBuyPreviewRoleCardPath()
	{
		return this.GetRoleSkinConfig().PreviewRoleCard;
	}

	// Token: 0x0601664F RID: 91727 RVA: 0x005AA16C File Offset: 0x005A836C
	public string GetBuyPreviewRoleQualityBgPath()
	{
		return ConfigQualityInfoById.GetConfig(this.GetQuality(), true).Value.RoleSkinQualityBg;
	}

	// Token: 0x06016650 RID: 91728 RVA: 0x005AA198 File Offset: 0x005A8398
	public string GetShopBuyPreviewCardPath()
	{
		return this.GetRoleSkinConfig().BuyShopPreviewRoleCard;
	}

	// Token: 0x06016651 RID: 91729 RVA: 0x005AA1B4 File Offset: 0x005A83B4
	public string GetSuitWeaponPreviewTexturePath()
	{
		WeaponSkin? suitWeaponSkinConfig = this.GetSuitWeaponSkinConfig();
		return ((suitWeaponSkinConfig != null) ? suitWeaponSkinConfig.GetValueOrDefault().CardIconPath : null) ?? "";
	}

	// Token: 0x06016652 RID: 91730 RVA: 0x005AA1EC File Offset: 0x005A83EC
	public string GetSuitWeaponQualityBgPath()
	{
		WeaponSkin? suitWeaponSkinConfig = this.GetSuitWeaponSkinConfig();
		return ConfigQualityInfoById.GetConfig((suitWeaponSkinConfig != null) ? suitWeaponSkinConfig.GetValueOrDefault().QualityId : 0, true).Value.WeaponSkinQualityBg;
	}

	// Token: 0x06016653 RID: 91731 RVA: 0x005AA234 File Offset: 0x005A8434
	public WeaponSkin? GetSuitWeaponSkinConfig()
	{
		if (this.GetSuitWeaponSkinId() <= 0)
		{
			return null;
		}
		return new WeaponSkin?(SkinConfig.Instance.GetWeaponSkinConfig(this.GetSuitWeaponSkinId()));
	}

	// Token: 0x06016654 RID: 91732 RVA: 0x005AA26C File Offset: 0x005A846C
	public int[] GetSuitWeaponMeshData()
	{
		WeaponSkin? suitWeaponSkinConfig = this.GetSuitWeaponSkinConfig();
		if (suitWeaponSkinConfig == null)
		{
			return Array.Empty<int>();
		}
		return suitWeaponSkinConfig.Value.GetModelsArray();
	}

	// Token: 0x06016655 RID: 91733 RVA: 0x005AA2A0 File Offset: 0x005A84A0
	public int GetRoleMeshId()
	{
		return this.GetRoleSkinConfig().MeshId;
	}

	// Token: 0x06016656 RID: 91734 RVA: 0x005AA2BC File Offset: 0x005A84BC
	public int GetRoleUiMeshId()
	{
		return this.GetRoleSkinConfig().UiMeshId;
	}

	// Token: 0x06016657 RID: 91735 RVA: 0x005AA2D8 File Offset: 0x005A84D8
	public string GetRoleBody()
	{
		return this.GetRoleSkinConfig().RoleBody;
	}

	// Token: 0x06016658 RID: 91736 RVA: 0x005AA2F4 File Offset: 0x005A84F4
	public int GetSuitWeaponSkinId()
	{
		int suitWeaponSkinId = this.GetRoleSkinConfig().SuitWeaponSkinId;
		if (suitWeaponSkinId <= 0)
		{
			return -1;
		}
		return suitWeaponSkinId;
	}

	// Token: 0x06016659 RID: 91737 RVA: 0x005AA318 File Offset: 0x005A8518
	public string GetRoleStandPath()
	{
		return this.GetRoleSkinConfig().RoleStand;
	}

	// Token: 0x0601665A RID: 91738 RVA: 0x005AA334 File Offset: 0x005A8534
	public string GetSpineSkeletonData()
	{
		return this.GetRoleSkinConfig().SpineSkeletonData;
	}

	// Token: 0x0601665B RID: 91739 RVA: 0x005AA350 File Offset: 0x005A8550
	public string GetSmallSpineAtlas()
	{
		return this.GetRoleSkinConfig().SmallSpineAtlas;
	}

	// Token: 0x0601665C RID: 91740 RVA: 0x005AA36C File Offset: 0x005A856C
	public string GetPayShopPreviewRoleTexturePath()
	{
		return this.GetRoleSkinConfig().PayShopPreviewRoleTexturePath;
	}

	// Token: 0x0601665D RID: 91741 RVA: 0x005AA388 File Offset: 0x005A8588
	public string GetPayShopPreviewRoleTextureBgPath()
	{
		return this.GetRoleSkinConfig().PayShopPreviewRoleTextureBgPath;
	}

	// Token: 0x0601665E RID: 91742 RVA: 0x005AA3A4 File Offset: 0x005A85A4
	public string GetPayShopPreviewWeaponTexturePath()
	{
		return this.GetRoleSkinConfig().PayShopPreviewWeaponTexturePath;
	}

	// Token: 0x0601665F RID: 91743 RVA: 0x005AA3C0 File Offset: 0x005A85C0
	public string GetObtainFrameColor1()
	{
		return this.GetRoleSkinConfig().RoleObtainColor1;
	}

	// Token: 0x06016660 RID: 91744 RVA: 0x005AA3DC File Offset: 0x005A85DC
	public string GetObtainFrameColor2()
	{
		return this.GetRoleSkinConfig().RoleObtainColor2;
	}

	// Token: 0x06016661 RID: 91745 RVA: 0x005AA3F8 File Offset: 0x005A85F8
	public string GetPayShopPreviewBuyRoleTexturePath()
	{
		return this.GetRoleSkinConfig().PayShopPreviewBuyRoleTexturePath;
	}

	// Token: 0x06016662 RID: 91746 RVA: 0x005AA414 File Offset: 0x005A8614
	public string GetPayShopPreviewBuyRoleSuitWeaponTexturePath()
	{
		return this.GetRoleSkinConfig().PayShopPreviewBuyRoleSuitWeaponTexturePath;
	}

	// Token: 0x06016663 RID: 91747 RVA: 0x005AA430 File Offset: 0x005A8630
	public string GetShareTexturePath()
	{
		return this.GetRoleSkinConfig().ShareTexturePath;
	}

	// Token: 0x06016664 RID: 91748 RVA: 0x005AA44B File Offset: 0x005A864B
	public bool GetHasNewFlag()
	{
		return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.RoleSkinRedDot, this.GetItemId());
	}

	// Token: 0x0400A693 RID: 42643
	public readonly int ItemId;

	// Token: 0x0400A694 RID: 42644
	private readonly RoleSkin RoleSkinConfig;

	// Token: 0x0400A695 RID: 42645
	private bool IsLock = true;
}

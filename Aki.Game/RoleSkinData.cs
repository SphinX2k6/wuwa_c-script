using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;

// Token: 0x02001F9A RID: 8090
[NullableContext(1)]
[Nullable(0)]
public class RoleSkinData
{
	// Token: 0x06014040 RID: 81984 RVA: 0x005D4F1C File Offset: 0x005D311C
	public RoleSkinData(int itemId)
	{
		this.ItemId = itemId;
		this.RoleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(this.ItemId).GetValueOrDefault();
	}

	// Token: 0x06014041 RID: 81985 RVA: 0x005D4F5B File Offset: 0x005D315B
	public ItemConfig GetItemConfig()
	{
		return InventoryConfig.Instance.GetItemConfigData(this.ItemId);
	}

	// Token: 0x06014042 RID: 81986 RVA: 0x005D4F6D File Offset: 0x005D316D
	public int GetItemId()
	{
		return this.ItemId;
	}

	// Token: 0x06014043 RID: 81987 RVA: 0x005D4F75 File Offset: 0x005D3175
	public string GetName()
	{
		return this.GetItemConfig().Name;
	}

	// Token: 0x06014044 RID: 81988 RVA: 0x005D4F84 File Offset: 0x005D3184
	public string GetTitleName()
	{
		return this.GetRoleSkinConfig().TitleName;
	}

	// Token: 0x06014045 RID: 81989 RVA: 0x005D4FA0 File Offset: 0x005D31A0
	public string GetSubTitle()
	{
		return this.GetRoleSkinConfig().SubDecName;
	}

	// Token: 0x06014046 RID: 81990 RVA: 0x005D4FBB File Offset: 0x005D31BB
	public string GetDesc()
	{
		return this.GetItemConfig().BgDescription;
	}

	// Token: 0x06014047 RID: 81991 RVA: 0x005D4FC8 File Offset: 0x005D31C8
	public string GetFunctionDesc()
	{
		return this.GetRoleSkinConfig().FunctionDesc;
	}

	// Token: 0x06014048 RID: 81992 RVA: 0x005D4FE3 File Offset: 0x005D31E3
	public int GetQuality()
	{
		return this.GetItemConfig().QualityId;
	}

	// Token: 0x06014049 RID: 81993 RVA: 0x005D4FF0 File Offset: 0x005D31F0
	public bool IsLocked()
	{
		return this.IsLock;
	}

	// Token: 0x0601404A RID: 81994 RVA: 0x005D4FF8 File Offset: 0x005D31F8
	public void LockSkin()
	{
		this.IsLock = true;
	}

	// Token: 0x0601404B RID: 81995 RVA: 0x005D5001 File Offset: 0x005D3201
	public void UnlockSkin()
	{
		this.IsLock = false;
	}

	// Token: 0x0601404C RID: 81996 RVA: 0x005D500C File Offset: 0x005D320C
	public bool IsWear()
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.GetRoleId());
		return roleInstanceById != null && roleInstanceById.GetRoleSkinId() == this.ItemId;
	}

	// Token: 0x0601404D RID: 81997 RVA: 0x005D5040 File Offset: 0x005D3240
	public bool IsOriginalSkin()
	{
		int roleId = this.RoleSkinConfig.RoleId;
		return RoleConfig.Instance.GetRoleConfig(roleId).Value.SkinId == this.ItemId;
	}

	// Token: 0x0601404E RID: 81998 RVA: 0x005D507F File Offset: 0x005D327F
	public int GetItemCount()
	{
		return (!this.IsLocked()) ? 1 : 0;
	}

	// Token: 0x0601404F RID: 81999 RVA: 0x005D508A File Offset: 0x005D328A
	public RoleSkin GetRoleSkinConfig()
	{
		return this.RoleSkinConfig;
	}

	// Token: 0x06014050 RID: 82000 RVA: 0x005D5094 File Offset: 0x005D3294
	public int GetRoleId()
	{
		return this.GetRoleSkinConfig().RoleId;
	}

	// Token: 0x06014051 RID: 82001 RVA: 0x005D50B0 File Offset: 0x005D32B0
	public int GetUiMeshId()
	{
		return this.RoleSkinConfig.UiMeshId;
	}

	// Token: 0x06014052 RID: 82002 RVA: 0x005D50CB File Offset: 0x005D32CB
	public bool GetIfHaveRole()
	{
		return RoleModel.Instance.GetRoleInstanceById(this.GetRoleId()) != null;
	}

	// Token: 0x06014053 RID: 82003 RVA: 0x005D50E0 File Offset: 0x005D32E0
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

	// Token: 0x06014054 RID: 82004 RVA: 0x005D512C File Offset: 0x005D332C
	public string GetBuyPreviewRoleCardPath()
	{
		return this.GetRoleSkinConfig().PreviewRoleCard;
	}

	// Token: 0x06014055 RID: 82005 RVA: 0x005D5148 File Offset: 0x005D3348
	public string GetBuyPreviewRoleQualityBgPath()
	{
		return ConfigQualityInfoById.GetConfig(this.GetQuality(), true).Value.RoleSkinQualityBg;
	}

	// Token: 0x06014056 RID: 82006 RVA: 0x005D5174 File Offset: 0x005D3374
	public string GetShopBuyPreviewCardPath()
	{
		return this.GetRoleSkinConfig().BuyShopPreviewRoleCard;
	}

	// Token: 0x06014057 RID: 82007 RVA: 0x005D5190 File Offset: 0x005D3390
	public string GetSuitWeaponPreviewTexturePath()
	{
		WeaponSkin? suitWeaponSkinConfig = this.GetSuitWeaponSkinConfig();
		return ((suitWeaponSkinConfig != null) ? suitWeaponSkinConfig.GetValueOrDefault().CardIconPath : null) ?? "";
	}

	// Token: 0x06014058 RID: 82008 RVA: 0x005D51C8 File Offset: 0x005D33C8
	public string GetSuitWeaponQualityBgPath()
	{
		WeaponSkin? suitWeaponSkinConfig = this.GetSuitWeaponSkinConfig();
		return ConfigQualityInfoById.GetConfig((suitWeaponSkinConfig != null) ? suitWeaponSkinConfig.GetValueOrDefault().QualityId : 0, true).Value.WeaponSkinQualityBg;
	}

	// Token: 0x06014059 RID: 82009 RVA: 0x005D5210 File Offset: 0x005D3410
	public WeaponSkin? GetSuitWeaponSkinConfig()
	{
		if (this.GetSuitWeaponSkinId() <= 0)
		{
			return null;
		}
		return new WeaponSkin?(SkinConfig.Instance.GetWeaponSkinConfig(this.GetSuitWeaponSkinId()));
	}

	// Token: 0x0601405A RID: 82010 RVA: 0x005D5248 File Offset: 0x005D3448
	public int[] GetSuitWeaponMeshData()
	{
		WeaponSkin? suitWeaponSkinConfig = this.GetSuitWeaponSkinConfig();
		if (suitWeaponSkinConfig == null)
		{
			return Array.Empty<int>();
		}
		return suitWeaponSkinConfig.Value.GetModelsArray();
	}

	// Token: 0x0601405B RID: 82011 RVA: 0x005D527C File Offset: 0x005D347C
	public int GetRoleMeshId()
	{
		return this.GetRoleSkinConfig().MeshId;
	}

	// Token: 0x0601405C RID: 82012 RVA: 0x005D5298 File Offset: 0x005D3498
	public int GetRoleUiMeshId()
	{
		return this.GetRoleSkinConfig().UiMeshId;
	}

	// Token: 0x0601405D RID: 82013 RVA: 0x005D52B4 File Offset: 0x005D34B4
	public string GetRoleBody()
	{
		return this.GetRoleSkinConfig().RoleBody;
	}

	// Token: 0x0601405E RID: 82014 RVA: 0x005D52D0 File Offset: 0x005D34D0
	public int GetSuitWeaponSkinId()
	{
		int suitWeaponSkinId = this.GetRoleSkinConfig().SuitWeaponSkinId;
		if (suitWeaponSkinId <= 0)
		{
			return -1;
		}
		return suitWeaponSkinId;
	}

	// Token: 0x0601405F RID: 82015 RVA: 0x005D52F4 File Offset: 0x005D34F4
	public string GetRoleStandPath()
	{
		return this.GetRoleSkinConfig().RoleStand;
	}

	// Token: 0x06014060 RID: 82016 RVA: 0x005D5310 File Offset: 0x005D3510
	public string GetSpineSkeletonData()
	{
		return this.GetRoleSkinConfig().SpineSkeletonData;
	}

	// Token: 0x06014061 RID: 82017 RVA: 0x005D532C File Offset: 0x005D352C
	public string GetSmallSpineAtlas()
	{
		return this.GetRoleSkinConfig().SmallSpineAtlas;
	}

	// Token: 0x06014062 RID: 82018 RVA: 0x005D5348 File Offset: 0x005D3548
	public string GetPayShopPreviewRoleTexturePath()
	{
		return this.GetRoleSkinConfig().PayShopPreviewRoleTexturePath;
	}

	// Token: 0x06014063 RID: 82019 RVA: 0x005D5364 File Offset: 0x005D3564
	public string GetPayShopPreviewRoleTextureBgPath()
	{
		return this.GetRoleSkinConfig().PayShopPreviewRoleTextureBgPath;
	}

	// Token: 0x06014064 RID: 82020 RVA: 0x005D5380 File Offset: 0x005D3580
	public string GetPayShopPreviewWeaponTexturePath()
	{
		return this.GetRoleSkinConfig().PayShopPreviewWeaponTexturePath;
	}

	// Token: 0x06014065 RID: 82021 RVA: 0x005D539C File Offset: 0x005D359C
	public string GetObtainFrameColor1()
	{
		return this.GetRoleSkinConfig().RoleObtainColor1;
	}

	// Token: 0x06014066 RID: 82022 RVA: 0x005D53B8 File Offset: 0x005D35B8
	public string GetObtainFrameColor2()
	{
		return this.GetRoleSkinConfig().RoleObtainColor2;
	}

	// Token: 0x06014067 RID: 82023 RVA: 0x005D53D4 File Offset: 0x005D35D4
	public string GetPayShopPreviewBuyRoleTexturePath()
	{
		return this.GetRoleSkinConfig().PayShopPreviewBuyRoleTexturePath;
	}

	// Token: 0x06014068 RID: 82024 RVA: 0x005D53F0 File Offset: 0x005D35F0
	public string GetPayShopPreviewBuyRoleSuitWeaponTexturePath()
	{
		return this.GetRoleSkinConfig().PayShopPreviewBuyRoleSuitWeaponTexturePath;
	}

	// Token: 0x06014069 RID: 82025 RVA: 0x005D540C File Offset: 0x005D360C
	public string GetShareTexturePath()
	{
		return this.GetRoleSkinConfig().ShareTexturePath;
	}

	// Token: 0x0601406A RID: 82026 RVA: 0x005D5427 File Offset: 0x005D3627
	public bool GetHasNewFlag()
	{
		return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.RoleSkinRedDot, this.GetItemId());
	}

	// Token: 0x0400AA7C RID: 43644
	public readonly int ItemId;

	// Token: 0x0400AA7D RID: 43645
	private readonly RoleSkin RoleSkinConfig;

	// Token: 0x0400AA7E RID: 43646
	private bool IsLock = true;
}

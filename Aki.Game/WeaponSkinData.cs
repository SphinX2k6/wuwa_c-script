using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;

// Token: 0x02002A60 RID: 10848
[NullableContext(1)]
[Nullable(0)]
public class WeaponSkinData
{
	// Token: 0x17001E01 RID: 7681
	// (get) Token: 0x060169C6 RID: 92614 RVA: 0x005BB3D1 File Offset: 0x005B95D1
	public bool IsEmptyData
	{
		get
		{
			return this.SkinId == -1;
		}
	}

	// Token: 0x17001E02 RID: 7682
	// (get) Token: 0x060169C7 RID: 92615 RVA: 0x005BB3DC File Offset: 0x005B95DC
	public int? QualityId
	{
		get
		{
			if (this.IsEmptyData)
			{
				return null;
			}
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.SkinId);
			if (itemConfigData == null)
			{
				return null;
			}
			return new int?(itemConfigData.QualityId);
		}
	}

	// Token: 0x060169C8 RID: 92616 RVA: 0x005BB423 File Offset: 0x005B9623
	public WeaponSkinData(int skinId, int roleId)
	{
		this.SkinId = skinId;
		this.RoleId = roleId;
	}

	// Token: 0x060169C9 RID: 92617 RVA: 0x005BB439 File Offset: 0x005B9639
	public bool GetIsLock()
	{
		return !this.IsEmptyData && InventoryModel.Instance.GetItemCountByConfigId(this.SkinId, 0) <= 0;
	}

	// Token: 0x060169CA RID: 92618 RVA: 0x005BB45C File Offset: 0x005B965C
	public bool IsCurrentEquipSkinId()
	{
		int skinIdByRoleId = WeaponSkinModel.Instance.GetSkinIdByRoleId(this.RoleId);
		return this.SkinId == skinIdByRoleId;
	}

	// Token: 0x17001E03 RID: 7683
	// (get) Token: 0x060169CB RID: 92619 RVA: 0x005BB484 File Offset: 0x005B9684
	public string Name
	{
		get
		{
			if (this.IsEmptyData)
			{
				return SkinConfig.Instance.GetDefaultWeaponSkinName();
			}
			return SkinConfig.Instance.GetWeaponSkinConfig(this.SkinId).Name;
		}
	}

	// Token: 0x17001E04 RID: 7684
	// (get) Token: 0x060169CC RID: 92620 RVA: 0x005BB4BC File Offset: 0x005B96BC
	public string Description
	{
		get
		{
			if (this.IsEmptyData)
			{
				return SkinConfig.Instance.GetDefaultWeaponSkinDescription();
			}
			return SkinConfig.Instance.GetWeaponSkinConfig(this.SkinId).BgDescription;
		}
	}

	// Token: 0x17001E05 RID: 7685
	// (get) Token: 0x060169CD RID: 92621 RVA: 0x005BB4F4 File Offset: 0x005B96F4
	public bool IsNew
	{
		get
		{
			return !this.IsEmptyData && NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.WeaponSkinRedDot, this.SkinId);
		}
	}

	// Token: 0x0400A7B7 RID: 42935
	public readonly int SkinId;

	// Token: 0x0400A7B8 RID: 42936
	public readonly int RoleId;
}

using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;

// Token: 0x02001FDB RID: 8155
[NullableContext(1)]
[Nullable(0)]
public class WeaponSkinData
{
	// Token: 0x17001E59 RID: 7769
	// (get) Token: 0x060143E7 RID: 82919 RVA: 0x005E7559 File Offset: 0x005E5759
	public bool IsEmptyData
	{
		get
		{
			return this.SkinId == -1;
		}
	}

	// Token: 0x17001E5A RID: 7770
	// (get) Token: 0x060143E8 RID: 82920 RVA: 0x005E7564 File Offset: 0x005E5764
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

	// Token: 0x060143E9 RID: 82921 RVA: 0x005E75AB File Offset: 0x005E57AB
	public WeaponSkinData(int skinId, int roleId)
	{
		this.SkinId = skinId;
		this.RoleId = roleId;
	}

	// Token: 0x060143EA RID: 82922 RVA: 0x005E75C1 File Offset: 0x005E57C1
	public bool GetIsLock()
	{
		return !this.IsEmptyData && InventoryModel.Instance.GetItemCountByConfigId(this.SkinId, 0) <= 0;
	}

	// Token: 0x060143EB RID: 82923 RVA: 0x005E75E4 File Offset: 0x005E57E4
	public bool IsCurrentEquipSkinId()
	{
		int skinIdByRoleId = WeaponSkinModel.Instance.GetSkinIdByRoleId(this.RoleId);
		return this.SkinId == skinIdByRoleId;
	}

	// Token: 0x17001E5B RID: 7771
	// (get) Token: 0x060143EC RID: 82924 RVA: 0x005E760C File Offset: 0x005E580C
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

	// Token: 0x17001E5C RID: 7772
	// (get) Token: 0x060143ED RID: 82925 RVA: 0x005E7644 File Offset: 0x005E5844
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

	// Token: 0x17001E5D RID: 7773
	// (get) Token: 0x060143EE RID: 82926 RVA: 0x005E767C File Offset: 0x005E587C
	public bool IsNew
	{
		get
		{
			return !this.IsEmptyData && NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.WeaponSkinRedDot, this.SkinId);
		}
	}

	// Token: 0x0400ABBB RID: 43963
	public readonly int SkinId;

	// Token: 0x0400ABBC RID: 43964
	public readonly int RoleId;
}

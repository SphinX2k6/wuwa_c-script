using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;
using UnrealEngine;

// Token: 0x02001993 RID: 6547
[NullableContext(1)]
[Nullable(0)]
public class SmallItemGridSkinComponent : SmallItemGridComponent
{
	// Token: 0x0600BF43 RID: 48963 RVA: 0x002B37A3 File Offset: 0x002B19A3
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBSkin";
	}

	// Token: 0x0600BF44 RID: 48964 RVA: 0x002B37AC File Offset: 0x002B19AC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BF45 RID: 48965 RVA: 0x002B389C File Offset: 0x002B1A9C
	[NullableContext(2)]
	protected override void OnRefresh(object tempData)
	{
		ISmallItemGridSkinComponentParams param = (ISmallItemGridSkinComponentParams)tempData;
		this.SetActive(true);
		this.RefreshTexture(param);
		this.RefreshQualitySprite(param);
		this.RefreshWeaponIcon(param);
		this.RefreshNum(param);
	}

	// Token: 0x0600BF46 RID: 48966 RVA: 0x002B38D4 File Offset: 0x002B1AD4
	private void RefreshTexture(ISmallItemGridSkinComponentParams param)
	{
		string texturePath = this.GetTexturePath(param);
		if (StringUtils.IsEmpty(texturePath))
		{
			base.GetTexture(1).SetUIActive(false);
			return;
		}
		base.GetTexture(1).SetUIActive(true);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(texturePath);
		base.SetTextureByPath(resourcePath, base.GetTexture(1), null, null);
	}

	// Token: 0x0600BF47 RID: 48967 RVA: 0x002B3930 File Offset: 0x002B1B30
	private void RefreshQualitySprite(ISmallItemGridSkinComponentParams param)
	{
		string qualitySpritePath = this.GetQualitySpritePath(param);
		this.SetSpriteByPath(qualitySpritePath, base.GetSprite(0), false, null, null);
	}

	// Token: 0x0600BF48 RID: 48968 RVA: 0x002B3960 File Offset: 0x002B1B60
	private string GetQualitySpritePath(ISmallItemGridSkinComponentParams param)
	{
		int? qualityId = param.QualityId;
		if (qualityId == null)
		{
			int? skinId = param.SkinId;
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(skinId.Value);
			if (itemConfigData == null)
			{
				return "";
			}
			qualityId = new int?(itemConfigData.QualityId);
		}
		return CommonConfig.Instance.GetItemQualityById(qualityId.Value).Value.SkinItemBg;
	}

	// Token: 0x0600BF49 RID: 48969 RVA: 0x002B39D0 File Offset: 0x002B1BD0
	private string GetTexturePath(ISmallItemGridSkinComponentParams param)
	{
		int? skinId = param.SkinId;
		if (skinId == null)
		{
			return "";
		}
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(skinId.Value));
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.WeaponSkinItem)
		{
			return "T_IconFilterSkin3";
		}
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleSkinItem)
		{
			if (RoleSkinModel.Instance.GetRoleSkinData(skinId.Value).GetSuitWeaponSkinId() > 0)
			{
				return "T_IconFilterSkin1";
			}
			return "T_IconFilterSkin2";
		}
		else
		{
			if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.FlySkinItem)
			{
				FlySkinConfig? flySkinConfig = SkinConfig.Instance.GetFlySkinConfig(skinId.Value);
				return SkinConfig.Instance.GetFlySkinBottomIconResourceId((EFlySkinType)flySkinConfig.Value.SkinType);
			}
			if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.CalabashSkinItem)
			{
				return "T_IconFilterSkin6";
			}
			if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.OrnamentItem)
			{
				return "T_IconFilterSkin7";
			}
			return "";
		}
	}

	// Token: 0x0600BF4A RID: 48970 RVA: 0x002B3A8C File Offset: 0x002B1C8C
	private void RefreshWeaponIcon(ISmallItemGridSkinComponentParams param)
	{
		int? skinId = param.SkinId;
		if (skinId == null)
		{
			base.GetItem(2).SetUIActive(false);
			return;
		}
		int itemDataTypeByConfigId = (int)InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(skinId.Value));
		bool flag = false;
		if (itemDataTypeByConfigId == 11 && RoleSkinModel.Instance.GetRoleSkinData(skinId.Value).GetSuitWeaponSkinId() > 0)
		{
			flag = true;
		}
		base.GetItem(2).SetUIActive(flag);
		if (flag)
		{
			string payShopPreviewBuyRoleSuitWeaponTexturePath = RoleSkinModel.Instance.GetRoleSkinData(skinId.Value).GetPayShopPreviewBuyRoleSuitWeaponTexturePath();
			base.SetTextureByPath(payShopPreviewBuyRoleSuitWeaponTexturePath, base.GetTexture(3), null, null);
		}
	}

	// Token: 0x0600BF4B RID: 48971 RVA: 0x002B3B30 File Offset: 0x002B1D30
	private void RefreshNum(ISmallItemGridSkinComponentParams param)
	{
		string bottomText = param.BottomText;
		bool flag = !StringUtils.IsEmpty(bottomText);
		base.GetItem(4).SetUIActive(flag);
		if (flag)
		{
			base.GetText(5).SetText(bottomText, true);
		}
	}

	// Token: 0x0600BF4C RID: 48972 RVA: 0x002B3B6C File Offset: 0x002B1D6C
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x02007ECE RID: 32462
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029713 RID: 169747
		QualitySprite,
		// Token: 0x04029714 RID: 169748
		Texture,
		// Token: 0x04029715 RID: 169749
		WeaponItem,
		// Token: 0x04029716 RID: 169750
		WeaponTexture,
		// Token: 0x04029717 RID: 169751
		NumItem,
		// Token: 0x04029718 RID: 169752
		NumText
	}
}

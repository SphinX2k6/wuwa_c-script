using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;
using UnrealEngine;

// Token: 0x02000E50 RID: 3664
[NullableContext(1)]
[Nullable(0)]
public class SmallItemGridSkinComponent : SmallItemGridComponent
{
	// Token: 0x0600934B RID: 37707 RVA: 0x002BE727 File Offset: 0x002BC927
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBSkin";
	}

	// Token: 0x0600934C RID: 37708 RVA: 0x002BE730 File Offset: 0x002BC930
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

	// Token: 0x0600934D RID: 37709 RVA: 0x002BE820 File Offset: 0x002BCA20
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

	// Token: 0x0600934E RID: 37710 RVA: 0x002BE858 File Offset: 0x002BCA58
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

	// Token: 0x0600934F RID: 37711 RVA: 0x002BE8B4 File Offset: 0x002BCAB4
	private void RefreshQualitySprite(ISmallItemGridSkinComponentParams param)
	{
		string qualitySpritePath = this.GetQualitySpritePath(param);
		this.SetSpriteByPath(qualitySpritePath, base.GetSprite(0), false, null, null);
	}

	// Token: 0x06009350 RID: 37712 RVA: 0x002BE8E4 File Offset: 0x002BCAE4
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

	// Token: 0x06009351 RID: 37713 RVA: 0x002BE954 File Offset: 0x002BCB54
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

	// Token: 0x06009352 RID: 37714 RVA: 0x002BEA10 File Offset: 0x002BCC10
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

	// Token: 0x06009353 RID: 37715 RVA: 0x002BEAB4 File Offset: 0x002BCCB4
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

	// Token: 0x06009354 RID: 37716 RVA: 0x002BEAF0 File Offset: 0x002BCCF0
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x0200705D RID: 28765
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024A50 RID: 150096
		QualitySprite,
		// Token: 0x04024A51 RID: 150097
		Texture,
		// Token: 0x04024A52 RID: 150098
		WeaponItem,
		// Token: 0x04024A53 RID: 150099
		WeaponTexture,
		// Token: 0x04024A54 RID: 150100
		NumItem,
		// Token: 0x04024A55 RID: 150101
		NumText
	}
}

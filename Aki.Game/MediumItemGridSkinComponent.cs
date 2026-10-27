using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;
using UnrealEngine;

// Token: 0x02001933 RID: 6451
public class MediumItemGridSkinComponent : MediumItemGridComponent
{
	// Token: 0x0600BCB7 RID: 48311 RVA: 0x002AB436 File Offset: 0x002A9636
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemASkin";
	}

	// Token: 0x0600BCB8 RID: 48312 RVA: 0x002AB440 File Offset: 0x002A9640
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BCB9 RID: 48313 RVA: 0x002AB488 File Offset: 0x002A9688
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		if (data is int)
		{
			int itemConfigId = (int)data;
			this.SetActive(true);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(this.GetTexturePath(itemConfigId));
			base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
			return;
		}
	}

	// Token: 0x0600BCBA RID: 48314 RVA: 0x002AB4D8 File Offset: 0x002A96D8
	[NullableContext(1)]
	private string GetTexturePath(int itemConfigId)
	{
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemConfigId));
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.WeaponSkinItem)
		{
			return "T_IconFilterSkin3";
		}
		if (itemDataTypeByConfigId != InventoryDefine.EItemDataType.RoleSkinItem)
		{
			if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.FlySkinItem)
			{
				FlySkinConfig? flySkinConfig = SkinConfig.Instance.GetFlySkinConfig(itemConfigId);
				if (flySkinConfig != null)
				{
					return SkinConfig.Instance.GetFlySkinBottomIconResourceId((EFlySkinType)flySkinConfig.Value.SkinType);
				}
			}
			else
			{
				if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.CalabashSkinItem)
				{
					return "T_IconFilterSkin6";
				}
				if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.OrnamentItem)
				{
					return "T_IconFilterSkin7";
				}
			}
			return "";
		}
		RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(itemConfigId);
		if (roleSkinData != null && roleSkinData.GetSuitWeaponSkinId() > 0)
		{
			return "T_IconFilterSkin1";
		}
		return "T_IconFilterSkin2";
	}

	// Token: 0x0600BCBB RID: 48315 RVA: 0x002AB579 File Offset: 0x002A9779
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x02007E98 RID: 32408
	private class EChildType
	{
		// Token: 0x04029676 RID: 169590
		public const int WeaponTexture = 0;
	}
}

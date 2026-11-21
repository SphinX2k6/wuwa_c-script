using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;
using UnrealEngine;

// Token: 0x02000DEF RID: 3567
public class MediumItemGridSkinComponent : MediumItemGridComponent
{
	// Token: 0x060090B2 RID: 37042 RVA: 0x002B5F05 File Offset: 0x002B4105
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemASkin";
	}

	// Token: 0x060090B3 RID: 37043 RVA: 0x002B5F0C File Offset: 0x002B410C
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

	// Token: 0x060090B4 RID: 37044 RVA: 0x002B5F54 File Offset: 0x002B4154
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

	// Token: 0x060090B5 RID: 37045 RVA: 0x002B5FA4 File Offset: 0x002B41A4
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

	// Token: 0x060090B6 RID: 37046 RVA: 0x002B6045 File Offset: 0x002B4245
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x02007025 RID: 28709
	private class EChildType
	{
		// Token: 0x040249AE RID: 149934
		public const int WeaponTexture = 0;
	}
}

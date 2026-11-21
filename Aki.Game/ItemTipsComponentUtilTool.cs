using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x02000DA1 RID: 3489
[NullableContext(2)]
[Nullable(0)]
public class ItemTipsComponentUtilTool : IStaticVariableResetter
{
	// Token: 0x06008EB6 RID: 36534 RVA: 0x002AF5B5 File Offset: 0x002AD7B5
	static ItemTipsComponentUtilTool()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ItemTipsComponentUtilTool.CreateStaticDefaultValue), new Action(ItemTipsComponentUtilTool.ResetStaticDefaultValue));
	}

	// Token: 0x06008EB7 RID: 36535 RVA: 0x002AF5D4 File Offset: 0x002AD7D4
	public static void CreateStaticDefaultValue()
	{
		ItemTipsComponentUtilTool.TypeDataRelationMap = new Dictionary<EItemTipsType, Type>
		{
			{
				EItemTipsType.Normal,
				typeof(TipsMaterialData)
			},
			{
				EItemTipsType.Weapon,
				typeof(TipsWeaponData)
			},
			{
				EItemTipsType.Vision,
				typeof(TipsVisionData)
			},
			{
				EItemTipsType.Character,
				typeof(TipsCharacterData)
			},
			{
				EItemTipsType.OverPower,
				typeof(TipsOverPowerData)
			},
			{
				EItemTipsType.Card,
				typeof(TipsCardData)
			},
			{
				EItemTipsType.Head,
				typeof(TipsHeadData)
			},
			{
				EItemTipsType.AbyssDango,
				typeof(TipsAbyssDangoData)
			},
			{
				EItemTipsType.HonamiStory,
				typeof(TipsHonamiStoryData)
			},
			{
				EItemTipsType.Furniture,
				typeof(TipsFurnitureData)
			},
			{
				EItemTipsType.RoleSkin,
				typeof(TipsRoleSkinData)
			},
			{
				EItemTipsType.PinballItem,
				typeof(TipsPinballItemData)
			}
		};
		ItemTipsComponentUtilTool.TypeUiTypeRelationMap = new Dictionary<EItemTipsType, ETipsUiType>
		{
			{
				EItemTipsType.Normal,
				ETipsUiType.ItemTipsComponent
			},
			{
				EItemTipsType.Weapon,
				ETipsUiType.ItemTipsComponent
			},
			{
				EItemTipsType.Vision,
				ETipsUiType.ItemTipsComponent
			},
			{
				EItemTipsType.Character,
				ETipsUiType.ItemTipsComponent
			},
			{
				EItemTipsType.OverPower,
				ETipsUiType.PowerTipsItem
			},
			{
				EItemTipsType.Card,
				ETipsUiType.PersonalCardPreviewComponent
			},
			{
				EItemTipsType.Head,
				ETipsUiType.PersonalHeadPreviewComponent
			},
			{
				EItemTipsType.AbyssDango,
				ETipsUiType.ItemTipsComponent
			},
			{
				EItemTipsType.HonamiStory,
				ETipsUiType.HonamiStoryTipsItem
			},
			{
				EItemTipsType.Furniture,
				ETipsUiType.FurnitureTipsItem
			},
			{
				EItemTipsType.RoleSkin,
				ETipsUiType.ItemTipsComponent
			},
			{
				EItemTipsType.PinballItem,
				ETipsUiType.PinballTipsItem
			}
		};
		ItemTipsComponentUtilTool.TypeItemDataRelationMap = new Dictionary<InventoryDefine.EItemDataType, EItemTipsType>
		{
			{
				InventoryDefine.EItemDataType.PhantomItem,
				EItemTipsType.Vision
			},
			{
				InventoryDefine.EItemDataType.WeaponItem,
				EItemTipsType.Weapon
			},
			{
				InventoryDefine.EItemDataType.RoleItem,
				EItemTipsType.Character
			},
			{
				InventoryDefine.EItemDataType.CardItem,
				EItemTipsType.Card
			},
			{
				InventoryDefine.EItemDataType.DangoAbyssItem,
				EItemTipsType.AbyssDango
			},
			{
				InventoryDefine.EItemDataType.HonamiStoryItem,
				EItemTipsType.HonamiStory
			},
			{
				InventoryDefine.EItemDataType.FurnitureItem,
				EItemTipsType.Furniture
			},
			{
				InventoryDefine.EItemDataType.RoleSkinItem,
				EItemTipsType.RoleSkin
			},
			{
				InventoryDefine.EItemDataType.PinballWeaponItem,
				EItemTipsType.PinballItem
			},
			{
				InventoryDefine.EItemDataType.PinballRoleItem,
				EItemTipsType.PinballItem
			}
		};
		ItemTipsComponentUtilTool.ItemIdRelationMap = new Dictionary<int, EItemTipsType>
		{
			{
				6,
				EItemTipsType.OverPower
			}
		};
	}

	// Token: 0x06008EB8 RID: 36536 RVA: 0x002AF7CD File Offset: 0x002AD9CD
	public static void ResetStaticDefaultValue()
	{
		ItemTipsComponentUtilTool.TypeDataRelationMap = null;
		ItemTipsComponentUtilTool.TypeUiTypeRelationMap = null;
		ItemTipsComponentUtilTool.TypeItemDataRelationMap = null;
		ItemTipsComponentUtilTool.ItemIdRelationMap = null;
	}

	// Token: 0x06008EB9 RID: 36537 RVA: 0x002AF7E8 File Offset: 0x002AD9E8
	public static EItemTipsType? GetItemItemType(int configId)
	{
		EItemTipsType value;
		if (ItemTipsComponentUtilTool.ItemIdRelationMap.TryGetValue(configId, out value))
		{
			return new EItemTipsType?(value);
		}
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(configId));
		EItemTipsType value2;
		if (!ItemTipsComponentUtilTool.TypeItemDataRelationMap.TryGetValue(itemDataTypeByConfigId, out value2))
		{
			value2 = EItemTipsType.Normal;
		}
		return new EItemTipsType?(value2);
	}

	// Token: 0x06008EBA RID: 36538 RVA: 0x002AF834 File Offset: 0x002ADA34
	public static ItemTipsData GetTipsDataById(int configId, int? incId = null, object extraParam = null)
	{
		EItemTipsType? itemItemType = ItemTipsComponentUtilTool.GetItemItemType(configId);
		if (itemItemType == null)
		{
			return null;
		}
		Type type;
		if (!ItemTipsComponentUtilTool.TypeDataRelationMap.TryGetValue(itemItemType.Value, out type))
		{
			return null;
		}
		ItemTipsParam itemTipsParam = new ItemTipsParam();
		itemTipsParam.ItemId = configId;
		itemTipsParam.ItemUid = ((incId != null) ? incId.Value : 0);
		itemTipsParam.ExtraParam = extraParam;
		return (ItemTipsData)Activator.CreateInstance(type, new object[]
		{
			itemTipsParam
		});
	}

	// Token: 0x06008EBB RID: 36539 RVA: 0x002AF8AC File Offset: 0x002ADAAC
	[NullableContext(1)]
	[return: Nullable(2)]
	public static ItemTipsData GetTipsDataByPram(ItemTipsParam data)
	{
		EItemTipsType? itemItemType = ItemTipsComponentUtilTool.GetItemItemType(data.ItemId);
		if (itemItemType == null)
		{
			return null;
		}
		Type type;
		if (!ItemTipsComponentUtilTool.TypeDataRelationMap.TryGetValue(itemItemType.Value, out type))
		{
			return null;
		}
		return (ItemTipsData)Activator.CreateInstance(type, new object[]
		{
			data
		});
	}

	// Token: 0x06008EBC RID: 36540 RVA: 0x002AF8FC File Offset: 0x002ADAFC
	public static ETipsUiType GetTipsUiType(EItemTipsType tipsType)
	{
		ETipsUiType result;
		if (ItemTipsComponentUtilTool.TypeUiTypeRelationMap.TryGetValue(tipsType, out result))
		{
			return result;
		}
		return ETipsUiType.ItemTipsComponent;
	}

	// Token: 0x0400558E RID: 21902
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<EItemTipsType, Type> TypeDataRelationMap;

	// Token: 0x0400558F RID: 21903
	private static Dictionary<EItemTipsType, ETipsUiType> TypeUiTypeRelationMap;

	// Token: 0x04005590 RID: 21904
	private static Dictionary<InventoryDefine.EItemDataType, EItemTipsType> TypeItemDataRelationMap;

	// Token: 0x04005591 RID: 21905
	private static Dictionary<int, EItemTipsType> ItemIdRelationMap;
}

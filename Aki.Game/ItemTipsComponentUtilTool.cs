using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x020018E8 RID: 6376
[NullableContext(2)]
[Nullable(0)]
public class ItemTipsComponentUtilTool : IStaticVariableResetter
{
	// Token: 0x0600BACD RID: 47821 RVA: 0x002A4E55 File Offset: 0x002A3055
	static ItemTipsComponentUtilTool()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ItemTipsComponentUtilTool.CreateStaticDefaultValue), new Action(ItemTipsComponentUtilTool.ResetStaticDefaultValue));
	}

	// Token: 0x0600BACE RID: 47822 RVA: 0x002A4E74 File Offset: 0x002A3074
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

	// Token: 0x0600BACF RID: 47823 RVA: 0x002A506D File Offset: 0x002A326D
	public static void ResetStaticDefaultValue()
	{
		ItemTipsComponentUtilTool.TypeDataRelationMap = null;
		ItemTipsComponentUtilTool.TypeUiTypeRelationMap = null;
		ItemTipsComponentUtilTool.TypeItemDataRelationMap = null;
		ItemTipsComponentUtilTool.ItemIdRelationMap = null;
	}

	// Token: 0x0600BAD0 RID: 47824 RVA: 0x002A5088 File Offset: 0x002A3288
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

	// Token: 0x0600BAD1 RID: 47825 RVA: 0x002A50D4 File Offset: 0x002A32D4
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

	// Token: 0x0600BAD2 RID: 47826 RVA: 0x002A514C File Offset: 0x002A334C
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

	// Token: 0x0600BAD3 RID: 47827 RVA: 0x002A519C File Offset: 0x002A339C
	public static ETipsUiType GetTipsUiType(EItemTipsType tipsType)
	{
		ETipsUiType result;
		if (ItemTipsComponentUtilTool.TypeUiTypeRelationMap.TryGetValue(tipsType, out result))
		{
			return result;
		}
		return ETipsUiType.ItemTipsComponent;
	}

	// Token: 0x040054E3 RID: 21731
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<EItemTipsType, Type> TypeDataRelationMap;

	// Token: 0x040054E4 RID: 21732
	private static Dictionary<EItemTipsType, ETipsUiType> TypeUiTypeRelationMap;

	// Token: 0x040054E5 RID: 21733
	private static Dictionary<InventoryDefine.EItemDataType, EItemTipsType> TypeItemDataRelationMap;

	// Token: 0x040054E6 RID: 21734
	private static Dictionary<int, EItemTipsType> ItemIdRelationMap;
}

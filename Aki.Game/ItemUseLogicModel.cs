using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x0200148A RID: 5258
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ItemUseLogicModel : ModelBase
{
	// Token: 0x0600D282 RID: 53890 RVA: 0x003E75E8 File Offset: 0x003E57E8
	protected override bool OnInit()
	{
		this.HardCodedIdUseLogicList.Add(new PowerItemUseLogic());
		this.HardCodedIdUseLogicList.Add(new StudentCardItemUseLogic());
		this.HardCodedIdUseLogicList.Add(new BattlePassItemUseLogic());
		this.HardCodedIdUseLogicList.Add(new BrochureItemUseLogic());
		this.UseLogicByItemTypeMap.Add(InventoryDefine.EItemType.Ornament, new OrnamentItemUseLogic());
		this.UseLogicByItemTypeMap.Add(InventoryDefine.EItemType.Gift, new GiftItemUseLogic());
		this.UseLogicByItemTypeMap.Add(InventoryDefine.EItemType.BirthdayItem, new BirthdayItemUseLogic());
		this.UseLogicByItemTypeMap.Add(InventoryDefine.EItemType.PayShopCoupon, new PayShopCouponItemUseLogic());
		this.UseLogicByItemTypeMap.Add(InventoryDefine.EItemType.ShipTowerBuff, new ShipTowerItemUseLogic());
		this.CommonItemUseLogicList.Add(new BuffEquipItemUseLogic());
		this.CommonItemUseLogicList.Add(new MonthCardItemUseLogic());
		this.CommonItemUseLogicList.Add(new VisionRefineItemUseLogic());
		this.CommonItemUseLogicList.Add(new VisionRefineSubItemUseLogic());
		this.CommonItemUseLogicList.Add(new BuffItemUseLogic());
		this.CommonItemUseLogicList.Add(new UiPlayItemUseLogic());
		return true;
	}

	// Token: 0x0600D283 RID: 53891 RVA: 0x003E76F9 File Offset: 0x003E58F9
	protected override bool OnClear()
	{
		this.HardCodedIdUseLogicList.Clear();
		this.UseLogicByItemTypeMap.Clear();
		this.CommonItemUseLogicList.Clear();
		return true;
	}

	// Token: 0x0600D284 RID: 53892 RVA: 0x003E7720 File Offset: 0x003E5920
	[NullableContext(2)]
	public ItemUseLogicBase Resolve(int itemId)
	{
		ItemUseLogicBase itemUseLogicBase = ItemUseLogicModel.ResolveByList(this.HardCodedIdUseLogicList, itemId);
		if (itemUseLogicBase != null)
		{
			return itemUseLogicBase;
		}
		ItemUseLogicBase itemUseLogicBase2 = this.ResolveByItemType(itemId);
		if (itemUseLogicBase2 != null)
		{
			return itemUseLogicBase2;
		}
		return this.ResolveByCommonItemField(itemId);
	}

	// Token: 0x0600D285 RID: 53893 RVA: 0x003E7754 File Offset: 0x003E5954
	[NullableContext(2)]
	private ItemUseLogicBase ResolveByItemType(int itemId)
	{
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
		InventoryDefine.EItemType? eitemType = (itemConfigData != null) ? itemConfigData.ItemType : null;
		if (eitemType == null)
		{
			return null;
		}
		return this.UseLogicByItemTypeMap.GetValueOrDefault(eitemType.Value);
	}

	// Token: 0x0600D286 RID: 53894 RVA: 0x003E779E File Offset: 0x003E599E
	[NullableContext(2)]
	private ItemUseLogicBase ResolveByCommonItemField(int itemId)
	{
		if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemId)) != InventoryDefine.EItemDataType.CommonItem)
		{
			return null;
		}
		return ItemUseLogicModel.ResolveByList(this.CommonItemUseLogicList, itemId);
	}

	// Token: 0x0600D287 RID: 53895 RVA: 0x003E77C0 File Offset: 0x003E59C0
	[return: Nullable(2)]
	private static ItemUseLogicBase ResolveByList(List<ItemUseLogicBase> useLogicList, int itemId)
	{
		foreach (ItemUseLogicBase itemUseLogicBase in useLogicList)
		{
			if (itemUseLogicBase.IsMatch(itemId))
			{
				return itemUseLogicBase;
			}
		}
		return null;
	}

	// Token: 0x1700138B RID: 5003
	// (get) Token: 0x0600D288 RID: 53896 RVA: 0x003E7818 File Offset: 0x003E5A18
	public static ItemUseLogicModel Instance
	{
		get
		{
			return ItemUseLogicModel._Instance;
		}
	}

	// Token: 0x0600D289 RID: 53897 RVA: 0x003E781F File Offset: 0x003E5A1F
	public static ItemUseLogicModel GetOrCreateInstance()
	{
		if (ItemUseLogicModel._Instance == null)
		{
			ItemUseLogicModel.CreateInstance();
		}
		return ItemUseLogicModel._Instance;
	}

	// Token: 0x0600D28A RID: 53898 RVA: 0x003E7833 File Offset: 0x003E5A33
	public static bool CreateInstance()
	{
		if (ItemUseLogicModel._Instance != null)
		{
			return true;
		}
		ItemUseLogicModel._Instance = new ItemUseLogicModel();
		return true;
	}

	// Token: 0x0600D28B RID: 53899 RVA: 0x003E7849 File Offset: 0x003E5A49
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D28C RID: 53900 RVA: 0x003E784B File Offset: 0x003E5A4B
	public static void ResetStaticDefaultValue()
	{
		ItemUseLogicModel._Instance = null;
	}

	// Token: 0x0600D28D RID: 53901 RVA: 0x003E7853 File Offset: 0x003E5A53
	static ItemUseLogicModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ItemUseLogicModel.CreateStaticDefaultValue), new Action(ItemUseLogicModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400768C RID: 30348
	private readonly List<ItemUseLogicBase> HardCodedIdUseLogicList = new List<ItemUseLogicBase>();

	// Token: 0x0400768D RID: 30349
	private readonly Dictionary<InventoryDefine.EItemType, ItemUseLogicBase> UseLogicByItemTypeMap = new Dictionary<InventoryDefine.EItemType, ItemUseLogicBase>();

	// Token: 0x0400768E RID: 30350
	private readonly List<ItemUseLogicBase> CommonItemUseLogicList = new List<ItemUseLogicBase>();

	// Token: 0x0400768F RID: 30351
	[Nullable(2)]
	private static ItemUseLogicModel _Instance;
}

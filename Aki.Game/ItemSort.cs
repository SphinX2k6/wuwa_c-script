using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

// Token: 0x0200188A RID: 6282
[NullableContext(1)]
[Nullable(0)]
public class ItemSort : CommonSort<EItemSortWayType>
{
	// Token: 0x0600B7FE RID: 47102 RVA: 0x0029A780 File Offset: 0x00298980
	private int SortConfigIdAscending(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		global::ItemViewData itemViewData = a as global::ItemViewData;
		global::ItemViewData itemViewData2 = b as global::ItemViewData;
		int configId = itemViewData.GetConfigId();
		int configId2 = itemViewData2.GetConfigId();
		return configId - configId2;
	}

	// Token: 0x0600B7FF RID: 47103 RVA: 0x0029A7A8 File Offset: 0x002989A8
	private int SortConfigId(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		global::ItemViewData itemViewData = a as global::ItemViewData;
		global::ItemViewData itemViewData2 = b as global::ItemViewData;
		int configId = itemViewData.GetConfigId();
		return (itemViewData2.GetConfigId() - configId) * (isAscending ? -1 : 1);
	}

	// Token: 0x0600B800 RID: 47104 RVA: 0x0029A7D8 File Offset: 0x002989D8
	private int SortLevel(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		global::ItemViewData itemViewData = a as global::ItemViewData;
		global::ItemViewData itemViewData2 = b as global::ItemViewData;
		int attributeLevel = itemViewData.GetAttributeLevel();
		return (itemViewData2.GetAttributeLevel() - attributeLevel) * (isAscending ? -1 : 1);
	}

	// Token: 0x0600B801 RID: 47105 RVA: 0x0029A808 File Offset: 0x00298A08
	private int SortQuality(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		global::ItemViewData itemViewData = a as global::ItemViewData;
		global::ItemViewData itemViewData2 = b as global::ItemViewData;
		int quality = itemViewData.GetQuality();
		return (itemViewData2.GetQuality() - quality) * (isAscending ? -1 : 1);
	}

	// Token: 0x0600B802 RID: 47106 RVA: 0x0029A838 File Offset: 0x00298A38
	private int SortCount(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		global::ItemViewData itemViewData = a as global::ItemViewData;
		global::ItemViewData itemViewData2 = b as global::ItemViewData;
		int count = itemViewData.GetCount();
		int count2 = itemViewData2.GetCount();
		return (count - count2) * (isAscending ? -1 : 1);
	}

	// Token: 0x0600B803 RID: 47107 RVA: 0x0029A86C File Offset: 0x00298A6C
	private int SortSortIndex(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		global::ItemViewData itemViewData = a as global::ItemViewData;
		global::ItemViewData itemViewData2 = b as global::ItemViewData;
		int sortIndex = itemViewData.GetSortIndex();
		int sortIndex2 = itemViewData2.GetSortIndex();
		return (sortIndex - sortIndex2) * (isAscending ? -1 : 1);
	}

	// Token: 0x0600B804 RID: 47108 RVA: 0x0029A8A0 File Offset: 0x00298AA0
	private int SortUniqueId(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		global::ItemViewData itemViewData = a as global::ItemViewData;
		global::ItemViewData itemViewData2 = b as global::ItemViewData;
		int uniqueId = itemViewData.GetUniqueId();
		int uniqueId2 = itemViewData2.GetUniqueId();
		return (uniqueId - uniqueId2) * (isAscending ? -1 : 1);
	}

	// Token: 0x0600B805 RID: 47109 RVA: 0x0029A8D4 File Offset: 0x00298AD4
	private int SortTimeLimit(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		global::ItemViewData itemViewData = a as global::ItemViewData;
		global::ItemViewData itemViewData2 = b as global::ItemViewData;
		ItemDataBase itemDataBase = itemViewData.GetItemDataBase();
		ItemDataBase itemDataBase2 = itemViewData2.GetItemDataBase();
		int num = 0;
		int num2 = 0;
		CommonItemData commonItemData = itemDataBase as CommonItemData;
		if (commonItemData != null)
		{
			num = ((commonItemData.IsLimitTimeItem() > false) ? 1 : 0);
		}
		CommonItemData commonItemData2 = itemDataBase2 as CommonItemData;
		if (commonItemData2 != null)
		{
			num2 = ((commonItemData2.IsLimitTimeItem() > false) ? 1 : 0);
		}
		return num2 - num;
	}

	// Token: 0x0600B806 RID: 47110 RVA: 0x0029A930 File Offset: 0x00298B30
	private int GetItemShowTypeSortValue(global::ItemViewData itemData)
	{
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemData.GetConfigId());
		if (((itemConfigData != null) ? itemConfigData.ShowTypes : null) == null || itemConfigData.ShowTypes.Length == 0)
		{
			return 0;
		}
		int showItemType = itemConfigData.ShowTypes[0];
		ItemShowType? itemShowTypeConfig = InventoryConfig.Instance.GetItemShowTypeConfig(showItemType);
		if (itemShowTypeConfig == null)
		{
			return 0;
		}
		return itemShowTypeConfig.Value.ItemSort;
	}

	// Token: 0x0600B807 RID: 47111 RVA: 0x0029A998 File Offset: 0x00298B98
	private int SortItemShowType(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		global::ItemViewData itemData = a as global::ItemViewData;
		global::ItemViewData itemData2 = b as global::ItemViewData;
		int itemShowTypeSortValue = this.GetItemShowTypeSortValue(itemData);
		return this.GetItemShowTypeSortValue(itemData2) - itemShowTypeSortValue;
	}

	// Token: 0x0600B808 RID: 47112 RVA: 0x0029A9C4 File Offset: 0x00298BC4
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EItemSortWayType.ConfigId, new TSortResult(this.SortConfigId));
		this.SortMap.Add(EItemSortWayType.Count, new TSortResult(this.SortCount));
		this.SortMap.Add(EItemSortWayType.Level, new TSortResult(this.SortLevel));
		this.SortMap.Add(EItemSortWayType.Quality, new TSortResult(this.SortQuality));
		this.SortMap.Add(EItemSortWayType.SortIndex, new TSortResult(this.SortSortIndex));
		this.SortMap.Add(EItemSortWayType.UniqueId, new TSortResult(this.SortUniqueId));
		this.SortMap.Add(EItemSortWayType.ConfigIdAscending, new TSortResult(this.SortConfigIdAscending));
		this.SortMap.Add(EItemSortWayType.IsTimeLimit, new TSortResult(this.SortTimeLimit));
		this.SortMap.Add(EItemSortWayType.ItemShowTypeSort, new TSortResult(this.SortItemShowType));
	}
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02000D43 RID: 3395
[NullableContext(1)]
[Nullable(0)]
public class ItemSort : CommonSort<EItemSortWayType>
{
	// Token: 0x06008BE7 RID: 35815 RVA: 0x002A4E98 File Offset: 0x002A3098
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

	// Token: 0x06008BE8 RID: 35816 RVA: 0x002A4EC0 File Offset: 0x002A30C0
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

	// Token: 0x06008BE9 RID: 35817 RVA: 0x002A4EF0 File Offset: 0x002A30F0
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

	// Token: 0x06008BEA RID: 35818 RVA: 0x002A4F20 File Offset: 0x002A3120
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

	// Token: 0x06008BEB RID: 35819 RVA: 0x002A4F50 File Offset: 0x002A3150
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

	// Token: 0x06008BEC RID: 35820 RVA: 0x002A4F84 File Offset: 0x002A3184
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

	// Token: 0x06008BED RID: 35821 RVA: 0x002A4FB8 File Offset: 0x002A31B8
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

	// Token: 0x06008BEE RID: 35822 RVA: 0x002A4FEC File Offset: 0x002A31EC
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

	// Token: 0x06008BEF RID: 35823 RVA: 0x002A5048 File Offset: 0x002A3248
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

	// Token: 0x06008BF0 RID: 35824 RVA: 0x002A50B0 File Offset: 0x002A32B0
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

	// Token: 0x06008BF1 RID: 35825 RVA: 0x002A50DC File Offset: 0x002A32DC
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

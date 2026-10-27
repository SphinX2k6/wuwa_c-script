using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

// Token: 0x02002814 RID: 10260
[NullableContext(1)]
[Nullable(0)]
public class ForecastRoleDevRoleDetailItemData
{
	// Token: 0x06015125 RID: 86309 RVA: 0x00555DFB File Offset: 0x00553FFB
	public void InitByRoleId(int roleId)
	{
		this.DetailItemsInternal.Clear();
		this.AddExpItemDetails(roleId);
		this.AddBreachItemDetails(roleId);
	}

	// Token: 0x06015126 RID: 86310 RVA: 0x00555E18 File Offset: 0x00554018
	private void AddExpItemDetails(int roleId)
	{
		global::IRoleDevDetailItemData roleDevDetailItemData = this.CreateForecastRoleExpItemDetailData(roleId);
		if (roleDevDetailItemData != null)
		{
			this.DetailItemsInternal.Add(roleDevDetailItemData);
		}
	}

	// Token: 0x06015127 RID: 86311 RVA: 0x00555E3C File Offset: 0x0055403C
	private void AddBreachItemDetails(int roleId)
	{
		List<global::IRoleDevDetailItemData> list = this.CreateForecastRoleBreachItemDetailData(roleId);
		if (list != null)
		{
			foreach (global::IRoleDevDetailItemData item in list)
			{
				this.DetailItemsInternal.Add(item);
			}
		}
	}

	// Token: 0x06015128 RID: 86312 RVA: 0x00555E9C File Offset: 0x0055409C
	[NullableContext(2)]
	private global::IRoleDevDetailItemData CreateForecastRoleExpItemDetailData(int roleId)
	{
		IRoleDevProsProjectConfig roleDevProsProjectConfig = this.GetRoleDevProsProjectConfig(roleId);
		if (roleDevProsProjectConfig == null)
		{
			return null;
		}
		int roleExperience = roleDevProsProjectConfig.RoleExperience;
		if (roleExperience <= 0)
		{
			return null;
		}
		List<ValueTuple<int, int>> sortedExpItemList = this.GetSortedExpItemList();
		List<global::IItemMaterial> list = this.CalcRoleExpMaterials(sortedExpItemList, roleExperience);
		if (list.Count == 0)
		{
			return null;
		}
		return this.BuildExpItemDetailData(roleId, list);
	}

	// Token: 0x06015129 RID: 86313 RVA: 0x00555EE8 File Offset: 0x005540E8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::IRoleDevDetailItemData> CreateForecastRoleBreachItemDetailData(int roleId)
	{
		IRoleDevProsProjectConfig roleDevProsProjectConfig = this.GetRoleDevProsProjectConfig(roleId);
		if (roleDevProsProjectConfig == null)
		{
			return null;
		}
		List<RoleDevProsRoleItem> roleItemGroups = this.GetRoleItemGroups(roleDevProsProjectConfig);
		if (roleItemGroups.Count == 0)
		{
			return null;
		}
		return this.BuildBreachDetailItems(roleId, roleItemGroups);
	}

	// Token: 0x0601512A RID: 86314 RVA: 0x00555F1C File Offset: 0x0055411C
	private List<global::IItemMaterial> CalcRoleExpMaterials([TupleElementNames(new string[]
	{
		"ItemId",
		"Count"
	})] [Nullable(new byte[]
	{
		1,
		0
	})] List<ValueTuple<int, int>> expItemList, int totalNeedExp)
	{
		List<global::IItemMaterial> list = new List<global::IItemMaterial>();
		int accumulatedExp = 0;
		accumulatedExp = this.UseExistingItems(expItemList, totalNeedExp, list, accumulatedExp);
		this.AddHighestQualityItemsIfNeeded(expItemList, totalNeedExp, list, accumulatedExp);
		return list;
	}

	// Token: 0x0601512B RID: 86315 RVA: 0x00555F47 File Offset: 0x00554147
	[NullableContext(2)]
	private IRoleDevProsProjectConfig GetRoleDevProsProjectConfig(int roleId)
	{
		return RoleDevConfig.Instance.GetRoleDevProsProjectConfig(roleId);
	}

	// Token: 0x0601512C RID: 86316 RVA: 0x00555F54 File Offset: 0x00554154
	[return: TupleElementNames(new string[]
	{
		"ItemId",
		"Count"
	})]
	[return: Nullable(new byte[]
	{
		1,
		0
	})]
	private List<ValueTuple<int, int>> GetSortedExpItemList()
	{
		List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
		foreach (ItemInfo itemInfo in RoleModel.Instance.GetRoleCostExpList())
		{
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(itemInfo.Id, 0);
			list.Add(new ValueTuple<int, int>(itemInfo.Id, commonItemCount));
		}
		return this.SortExpItemsByQuality(list);
	}

	// Token: 0x0601512D RID: 86317 RVA: 0x00555FB7 File Offset: 0x005541B7
	[return: TupleElementNames(new string[]
	{
		"ItemId",
		"Count"
	})]
	[return: Nullable(new byte[]
	{
		1,
		0
	})]
	private List<ValueTuple<int, int>> SortExpItemsByQuality([TupleElementNames(new string[]
	{
		"ItemId",
		"Count"
	})] [Nullable(new byte[]
	{
		1,
		0
	})] List<ValueTuple<int, int>> expItemList)
	{
		expItemList.Sort(delegate([TupleElementNames(new string[]
		{
			"ItemId",
			"Count"
		})] ValueTuple<int, int> a, [TupleElementNames(new string[]
		{
			"ItemId",
			"Count"
		})] ValueTuple<int, int> b)
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(a.Item1);
			ItemConfig itemConfigData2 = InventoryConfig.Instance.GetItemConfigData(b.Item1);
			int num = (itemConfigData != null) ? itemConfigData.QualityId : 0;
			int num2 = (itemConfigData2 != null) ? itemConfigData2.QualityId : 0;
			return num - num2;
		});
		return expItemList;
	}

	// Token: 0x0601512E RID: 86318 RVA: 0x00555FE0 File Offset: 0x005541E0
	private global::IRoleDevDetailItemData BuildExpItemDetailData(int roleId, List<global::IItemMaterial> totalMaterials)
	{
		List<global::IMaterialGroup> materialGroups = RoleDevUtils.GroupMaterialsByType(totalMaterials);
		return RoleDevUtils.BuildDetailItemData(roleId, materialGroups, ERoleDevMainPage.Role)[0];
	}

	// Token: 0x0601512F RID: 86319 RVA: 0x00556004 File Offset: 0x00554204
	private int UseExistingItems([TupleElementNames(new string[]
	{
		"ItemId",
		"Count"
	})] [Nullable(new byte[]
	{
		1,
		0
	})] List<ValueTuple<int, int>> expItemList, int totalNeedExp, List<global::IItemMaterial> totalMaterials, int accumulatedExp)
	{
		int num = accumulatedExp;
		foreach (ValueTuple<int, int> valueTuple in expItemList)
		{
			if (num >= totalNeedExp)
			{
				break;
			}
			int? roleExpItemExp = RoleModel.Instance.GetRoleExpItemExp(valueTuple.Item1);
			if (roleExpItemExp != null)
			{
				int value = roleExpItemExp.Value;
				int num2 = Math.Min((int)Math.Ceiling((double)(totalNeedExp - num) / (double)value), valueTuple.Item2);
				if (num2 > 0)
				{
					totalMaterials.Add(new global::ItemMaterial
					{
						ItemId = valueTuple.Item1,
						RequiredCount = num2
					});
					num += num2 * value;
				}
			}
		}
		return num;
	}

	// Token: 0x06015130 RID: 86320 RVA: 0x005560C8 File Offset: 0x005542C8
	private void AddHighestQualityItemsIfNeeded([TupleElementNames(new string[]
	{
		"ItemId",
		"Count"
	})] [Nullable(new byte[]
	{
		1,
		0
	})] List<ValueTuple<int, int>> expItemList, int totalNeedExp, List<global::IItemMaterial> totalMaterials, int accumulatedExp)
	{
		if (accumulatedExp >= totalNeedExp)
		{
			return;
		}
		if (expItemList.Count == 0)
		{
			return;
		}
		ValueTuple<int, int> valueTuple = expItemList[expItemList.Count - 1];
		int? roleExpItemExp = RoleModel.Instance.GetRoleExpItemExp(valueTuple.Item1);
		if (roleExpItemExp == null)
		{
			return;
		}
		int value = roleExpItemExp.Value;
		int requiredCount = (int)Math.Ceiling((double)(totalNeedExp - accumulatedExp) / (double)value);
		totalMaterials.Add(new global::ItemMaterial
		{
			ItemId = valueTuple.Item1,
			RequiredCount = requiredCount
		});
	}

	// Token: 0x06015131 RID: 86321 RVA: 0x00556144 File Offset: 0x00554344
	private List<RoleDevProsRoleItem> GetRoleItemGroups(IRoleDevProsProjectConfig roleDevProsListConfig)
	{
		List<RoleDevProsRoleItem> list = new List<RoleDevProsRoleItem>();
		foreach (int itemGroupId in roleDevProsListConfig.RoleItemGroup)
		{
			RoleDevProsRoleItem? roleDevProsRoleItemConfig = RoleDevConfig.Instance.GetRoleDevProsRoleItemConfig(itemGroupId);
			if (roleDevProsRoleItemConfig != null)
			{
				list.Add(roleDevProsRoleItemConfig.Value);
			}
		}
		return list;
	}

	// Token: 0x06015132 RID: 86322 RVA: 0x005561BC File Offset: 0x005543BC
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::IRoleDevDetailItemData> BuildBreachDetailItems(int roleId, List<RoleDevProsRoleItem> roleItemGroups)
	{
		List<global::IRoleDevDetailItemData> list = new List<global::IRoleDevDetailItemData>();
		foreach (RoleDevProsRoleItem group in roleItemGroups)
		{
			List<global::IItemMaterial> list2 = this.ConvertGroupToMaterials(group);
			if (list2.Count > 0)
			{
				foreach (global::IRoleDevDetailItemData item in this.BuildGroupDetailItems(roleId, group, list2))
				{
					list.Add(item);
				}
			}
		}
		if (list.Count <= 0)
		{
			return null;
		}
		return list;
	}

	// Token: 0x06015133 RID: 86323 RVA: 0x00556270 File Offset: 0x00554470
	private List<global::IItemMaterial> ConvertGroupToMaterials(RoleDevProsRoleItem group)
	{
		List<global::IItemMaterial> list = new List<global::IItemMaterial>();
		int itemGroupLength = group.ItemGroupLength;
		for (int i = 0; i < itemGroupLength; i++)
		{
			IntPair? intPair = group.ItemGroup(i);
			if (intPair != null)
			{
				int item = intPair.Value.Item1;
				int item2 = intPair.Value.Item2;
				list.Add(new global::ItemMaterial
				{
					ItemId = item,
					RequiredCount = item2
				});
			}
		}
		return list;
	}

	// Token: 0x06015134 RID: 86324 RVA: 0x005562EC File Offset: 0x005544EC
	private List<global::IRoleDevDetailItemData> BuildGroupDetailItems(int roleId, RoleDevProsRoleItem group, List<global::IItemMaterial> materials)
	{
		return RoleDevUtils.BuildDetailItemData(roleId, new List<global::IMaterialGroup>
		{
			new global::MaterialGroup
			{
				Type = group.ItemTypeId,
				Materials = materials
			}
		}, ERoleDevMainPage.Role);
	}

	// Token: 0x17001BD7 RID: 7127
	// (get) Token: 0x06015135 RID: 86325 RVA: 0x00556326 File Offset: 0x00554526
	public List<global::IRoleDevDetailItemData> DetailItems
	{
		get
		{
			return this.DetailItemsInternal;
		}
	}

	// Token: 0x04009E35 RID: 40501
	private List<global::IRoleDevDetailItemData> DetailItemsInternal = new List<global::IRoleDevDetailItemData>();
}

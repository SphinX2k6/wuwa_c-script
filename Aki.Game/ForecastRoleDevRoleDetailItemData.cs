using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

// Token: 0x02001D8F RID: 7567
[NullableContext(1)]
[Nullable(0)]
public class ForecastRoleDevRoleDetailItemData
{
	// Token: 0x06012B25 RID: 76581 RVA: 0x00580BFB File Offset: 0x0057EDFB
	public void InitByRoleId(int roleId)
	{
		this.DetailItemsInternal.Clear();
		this.AddExpItemDetails(roleId);
		this.AddBreachItemDetails(roleId);
	}

	// Token: 0x06012B26 RID: 76582 RVA: 0x00580C18 File Offset: 0x0057EE18
	private void AddExpItemDetails(int roleId)
	{
		global::IRoleDevDetailItemData roleDevDetailItemData = this.CreateForecastRoleExpItemDetailData(roleId);
		if (roleDevDetailItemData != null)
		{
			this.DetailItemsInternal.Add(roleDevDetailItemData);
		}
	}

	// Token: 0x06012B27 RID: 76583 RVA: 0x00580C3C File Offset: 0x0057EE3C
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

	// Token: 0x06012B28 RID: 76584 RVA: 0x00580C9C File Offset: 0x0057EE9C
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

	// Token: 0x06012B29 RID: 76585 RVA: 0x00580CE8 File Offset: 0x0057EEE8
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

	// Token: 0x06012B2A RID: 76586 RVA: 0x00580D1C File Offset: 0x0057EF1C
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

	// Token: 0x06012B2B RID: 76587 RVA: 0x00580D47 File Offset: 0x0057EF47
	[NullableContext(2)]
	private IRoleDevProsProjectConfig GetRoleDevProsProjectConfig(int roleId)
	{
		return RoleDevConfig.Instance.GetRoleDevProsProjectConfig(roleId);
	}

	// Token: 0x06012B2C RID: 76588 RVA: 0x00580D54 File Offset: 0x0057EF54
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

	// Token: 0x06012B2D RID: 76589 RVA: 0x00580DB7 File Offset: 0x0057EFB7
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

	// Token: 0x06012B2E RID: 76590 RVA: 0x00580DE0 File Offset: 0x0057EFE0
	private global::IRoleDevDetailItemData BuildExpItemDetailData(int roleId, List<global::IItemMaterial> totalMaterials)
	{
		List<global::IMaterialGroup> materialGroups = RoleDevUtils.GroupMaterialsByType(totalMaterials);
		return RoleDevUtils.BuildDetailItemData(roleId, materialGroups, ERoleDevMainPage.Role)[0];
	}

	// Token: 0x06012B2F RID: 76591 RVA: 0x00580E04 File Offset: 0x0057F004
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

	// Token: 0x06012B30 RID: 76592 RVA: 0x00580EC8 File Offset: 0x0057F0C8
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

	// Token: 0x06012B31 RID: 76593 RVA: 0x00580F44 File Offset: 0x0057F144
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

	// Token: 0x06012B32 RID: 76594 RVA: 0x00580FBC File Offset: 0x0057F1BC
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

	// Token: 0x06012B33 RID: 76595 RVA: 0x00581070 File Offset: 0x0057F270
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

	// Token: 0x06012B34 RID: 76596 RVA: 0x005810EC File Offset: 0x0057F2EC
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

	// Token: 0x17001C2F RID: 7215
	// (get) Token: 0x06012B35 RID: 76597 RVA: 0x00581126 File Offset: 0x0057F326
	public List<global::IRoleDevDetailItemData> DetailItems
	{
		get
		{
			return this.DetailItemsInternal;
		}
	}

	// Token: 0x0400A21E RID: 41502
	private List<global::IRoleDevDetailItemData> DetailItemsInternal = new List<global::IRoleDevDetailItemData>();
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02002816 RID: 10262
[NullableContext(1)]
[Nullable(0)]
public class NotObtainedRoleDevRoleDetailItemData
{
	// Token: 0x06015147 RID: 86343 RVA: 0x005564A0 File Offset: 0x005546A0
	public void InitByRoleId(int roleId)
	{
		this.DetailItemsInternal.Clear();
		int currentLevel = 1;
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(roleId);
		if (cultivateProject == null)
		{
			return;
		}
		int roleLevel = cultivateProject.Value.RoleLevel;
		int currentBreachLevel = 0;
		int roleBreachLevel = cultivateProject.Value.RoleBreachLevel;
		this.CollectUpgradeItems(roleId, currentLevel, roleLevel);
		this.CollectBreachItems(roleId, currentBreachLevel, roleBreachLevel);
	}

	// Token: 0x06015148 RID: 86344 RVA: 0x00556504 File Offset: 0x00554704
	private void CollectUpgradeItems(int roleId, int currentLevel, int targetLevel)
	{
		global::IRoleDevDetailItemData roleDevDetailItemData = this.CreateRoleExpItemDetailData(roleId, currentLevel, targetLevel);
		if (roleDevDetailItemData != null)
		{
			this.DetailItemsInternal.Add(roleDevDetailItemData);
		}
	}

	// Token: 0x06015149 RID: 86345 RVA: 0x0055652C File Offset: 0x0055472C
	private void CollectBreachItems(int roleId, int currentBreachLevel, int targetBreachLevel)
	{
		List<global::IRoleDevDetailItemData> list = this.CreateRoleBreachItemDetailData(roleId, currentBreachLevel, targetBreachLevel);
		if (list != null)
		{
			foreach (global::IRoleDevDetailItemData item in list)
			{
				this.DetailItemsInternal.Add(item);
			}
		}
	}

	// Token: 0x0601514A RID: 86346 RVA: 0x0055658C File Offset: 0x0055478C
	[NullableContext(2)]
	private global::IRoleDevDetailItemData CreateRoleExpItemDetailData(int roleId, int currentLevel, int targetLevel)
	{
		if (currentLevel >= targetLevel)
		{
			return null;
		}
		int totalNeedExp = this.CalculateTotalNeedExp(roleId, currentLevel, targetLevel);
		List<ValueTuple<int, int>> sortedExpItemList = this.GetSortedExpItemList();
		List<global::IItemMaterial> totalMaterials = this.CalcRoleExpMaterials(sortedExpItemList, totalNeedExp);
		return this.BuildExpItemDetailData(roleId, totalMaterials);
	}

	// Token: 0x0601514B RID: 86347 RVA: 0x005565C4 File Offset: 0x005547C4
	private int CalculateTotalNeedExp(int roleId, int currentLevel, int targetLevel)
	{
		int num = 0;
		for (int i = currentLevel; i <= targetLevel; i++)
		{
			num += RoleModel.Instance.GetRoleLevelUpExp(roleId, i);
		}
		return num;
	}

	// Token: 0x0601514C RID: 86348 RVA: 0x005565F0 File Offset: 0x005547F0
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

	// Token: 0x0601514D RID: 86349 RVA: 0x00556653 File Offset: 0x00554853
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

	// Token: 0x0601514E RID: 86350 RVA: 0x0055667C File Offset: 0x0055487C
	private global::IRoleDevDetailItemData BuildExpItemDetailData(int roleId, List<global::IItemMaterial> totalMaterials)
	{
		List<global::IMaterialGroup> materialGroups = RoleDevUtils.GroupMaterialsByType(totalMaterials);
		return RoleDevUtils.BuildDetailItemData(roleId, materialGroups, ERoleDevMainPage.Role)[0];
	}

	// Token: 0x0601514F RID: 86351 RVA: 0x005566A0 File Offset: 0x005548A0
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
		accumulatedExp = this.UseExistingExpItems(expItemList, totalNeedExp, list, accumulatedExp);
		this.AddHighestQualityExpItemsIfNeeded(expItemList, totalNeedExp, list, accumulatedExp);
		return list;
	}

	// Token: 0x06015150 RID: 86352 RVA: 0x005566CC File Offset: 0x005548CC
	private int UseExistingExpItems([TupleElementNames(new string[]
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

	// Token: 0x06015151 RID: 86353 RVA: 0x00556790 File Offset: 0x00554990
	private void AddHighestQualityExpItemsIfNeeded([TupleElementNames(new string[]
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

	// Token: 0x06015152 RID: 86354 RVA: 0x0055680C File Offset: 0x00554A0C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::IRoleDevDetailItemData> CreateRoleBreachItemDetailData(int roleId, int currentBreachLevel, int targetBreachLevel)
	{
		if (currentBreachLevel >= targetBreachLevel)
		{
			return null;
		}
		List<global::IItemMaterial> list = this.CalculateBreachMaterials(roleId, currentBreachLevel, targetBreachLevel);
		if (list.Count == 0)
		{
			return null;
		}
		return this.BuildBreachDetailItems(roleId, list);
	}

	// Token: 0x06015153 RID: 86355 RVA: 0x0055683C File Offset: 0x00554A3C
	private List<global::IItemMaterial> CalculateBreachMaterials(int roleId, int currentBreachLevel, int targetBreachLevel)
	{
		List<global::IItemMaterial> list = new List<global::IItemMaterial>();
		for (int i = currentBreachLevel + 1; i <= targetBreachLevel; i++)
		{
			RoleBreach? roleBreachConfig = RoleConfig.Instance.GetRoleBreachConfig(roleId, i);
			if (roleBreachConfig != null)
			{
				this.AddBreachLevelMaterials(roleBreachConfig.Value, list);
			}
		}
		return list;
	}

	// Token: 0x06015154 RID: 86356 RVA: 0x00556884 File Offset: 0x00554A84
	private void AddBreachLevelMaterials(RoleBreach breakConfig, List<global::IItemMaterial> totalMaterials)
	{
		Dictionary<int, int> dictionary = breakConfig.BreachConsume();
		if (dictionary == null)
		{
			return;
		}
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			int key = keyValuePair.Key;
			if (key != 2)
			{
				int value = keyValuePair.Value;
				this.AddOrUpdateMaterial(totalMaterials, key, value);
			}
		}
	}

	// Token: 0x06015155 RID: 86357 RVA: 0x005568F8 File Offset: 0x00554AF8
	private void AddOrUpdateMaterial(List<global::IItemMaterial> totalMaterials, int itemId, int count)
	{
		global::IItemMaterial itemMaterial = totalMaterials.Find((global::IItemMaterial m) => m.ItemId == itemId);
		if (itemMaterial != null)
		{
			itemMaterial.RequiredCount += count;
			return;
		}
		totalMaterials.Add(new global::ItemMaterial
		{
			ItemId = itemId,
			RequiredCount = count
		});
	}

	// Token: 0x06015156 RID: 86358 RVA: 0x00556958 File Offset: 0x00554B58
	private List<global::IRoleDevDetailItemData> BuildBreachDetailItems(int roleId, List<global::IItemMaterial> totalMaterials)
	{
		List<global::IMaterialGroup> materialGroups = RoleDevUtils.GroupMaterialsByType(totalMaterials);
		List<global::IRoleDevDetailItemData> list = RoleDevUtils.BuildDetailItemData(roleId, materialGroups, ERoleDevMainPage.Role);
		if (list.Count <= 0)
		{
			return new List<global::IRoleDevDetailItemData>();
		}
		return list;
	}

	// Token: 0x17001BD9 RID: 7129
	// (get) Token: 0x06015157 RID: 86359 RVA: 0x00556985 File Offset: 0x00554B85
	public List<global::IRoleDevDetailItemData> DetailItems
	{
		get
		{
			return this.DetailItemsInternal;
		}
	}

	// Token: 0x04009E37 RID: 40503
	private List<global::IRoleDevDetailItemData> DetailItemsInternal = new List<global::IRoleDevDetailItemData>();
}

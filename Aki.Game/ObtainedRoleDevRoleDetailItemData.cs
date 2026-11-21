using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001D93 RID: 7571
[NullableContext(1)]
[Nullable(0)]
public class ObtainedRoleDevRoleDetailItemData
{
	// Token: 0x06012B69 RID: 76649 RVA: 0x00581984 File Offset: 0x0057FB84
	public void InitByRoleId(int roleId)
	{
		this.DetailItemsInternal.Clear();
		RoleDataBase roleData = this.GetRoleData(roleId);
		if (roleData == null)
		{
			return;
		}
		RoleLevelData levelData = roleData.GetLevelData();
		int level = levelData.GetLevel();
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(roleId);
		if (cultivateProject == null)
		{
			return;
		}
		int roleLevel = cultivateProject.Value.RoleLevel;
		int breachLevel = levelData.GetBreachLevel();
		int roleBreachLevel = cultivateProject.Value.RoleBreachLevel;
		this.CollectUpgradeItems(roleId, level, roleLevel);
		this.CollectBreachItems(roleId, breachLevel, roleBreachLevel);
	}

	// Token: 0x06012B6A RID: 76650 RVA: 0x00581A08 File Offset: 0x0057FC08
	[NullableContext(2)]
	private RoleDataBase GetRoleData(int roleId)
	{
		return RoleModel.Instance.GetRoleDataById(roleId, true);
	}

	// Token: 0x06012B6B RID: 76651 RVA: 0x00581A18 File Offset: 0x0057FC18
	private void CollectUpgradeItems(int roleId, int currentLevel, int targetLevel)
	{
		global::IRoleDevDetailItemData roleDevDetailItemData = this.CreateRoleExpItemDetailData(roleId, currentLevel, targetLevel);
		if (roleDevDetailItemData != null)
		{
			this.DetailItemsInternal.Add(roleDevDetailItemData);
		}
	}

	// Token: 0x06012B6C RID: 76652 RVA: 0x00581A40 File Offset: 0x0057FC40
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

	// Token: 0x06012B6D RID: 76653 RVA: 0x00581AA0 File Offset: 0x0057FCA0
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

	// Token: 0x06012B6E RID: 76654 RVA: 0x00581AD8 File Offset: 0x0057FCD8
	private int CalculateTotalNeedExp(int roleId, int currentLevel, int targetLevel)
	{
		int num = 0;
		RoleDataBase roleData = this.GetRoleData(roleId);
		if (roleData == null)
		{
			return 0;
		}
		int exp = roleData.GetLevelData().GetExp();
		for (int i = currentLevel + 1; i <= targetLevel; i++)
		{
			num += RoleModel.Instance.GetRoleLevelUpExp(roleId, i);
		}
		int num2 = this.CalculateBreachOverflowExp(roleId);
		num += num2;
		return num - exp;
	}

	// Token: 0x06012B6F RID: 76655 RVA: 0x00581B34 File Offset: 0x0057FD34
	private int CalculateBreachOverflowExp(int roleId)
	{
		RoleDataBase roleData = this.GetRoleData(roleId);
		if (roleData == null)
		{
			return 0;
		}
		int breachLevel = roleData.GetLevelData().GetBreachLevel();
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(roleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		int num = cultivateProject.Value.RoleBreachLevel - breachLevel;
		if (num <= 0)
		{
			return 0;
		}
		RoleDevCulProjectConfig? roleDevCulProjectConfig;
		int num2 = (RoleDevConfig.Instance.GetRoleDevStaticConfig() != null) ? roleDevCulProjectConfig.GetValueOrDefault().OverflowExperience : 1;
		return num * num2;
	}

	// Token: 0x06012B70 RID: 76656 RVA: 0x00581BB4 File Offset: 0x0057FDB4
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

	// Token: 0x06012B71 RID: 76657 RVA: 0x00581C17 File Offset: 0x0057FE17
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

	// Token: 0x06012B72 RID: 76658 RVA: 0x00581C40 File Offset: 0x0057FE40
	private global::IRoleDevDetailItemData BuildExpItemDetailData(int roleId, List<global::IItemMaterial> totalMaterials)
	{
		List<global::IMaterialGroup> materialGroups = RoleDevUtils.GroupMaterialsByType(totalMaterials);
		return RoleDevUtils.BuildDetailItemData(roleId, materialGroups, ERoleDevMainPage.Role)[0];
	}

	// Token: 0x06012B73 RID: 76659 RVA: 0x00581C64 File Offset: 0x0057FE64
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

	// Token: 0x06012B74 RID: 76660 RVA: 0x00581C90 File Offset: 0x0057FE90
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

	// Token: 0x06012B75 RID: 76661 RVA: 0x00581D54 File Offset: 0x0057FF54
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

	// Token: 0x06012B76 RID: 76662 RVA: 0x00581DD0 File Offset: 0x0057FFD0
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

	// Token: 0x06012B77 RID: 76663 RVA: 0x00581E00 File Offset: 0x00580000
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

	// Token: 0x06012B78 RID: 76664 RVA: 0x00581E48 File Offset: 0x00580048
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

	// Token: 0x06012B79 RID: 76665 RVA: 0x00581EBC File Offset: 0x005800BC
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

	// Token: 0x06012B7A RID: 76666 RVA: 0x00581F1C File Offset: 0x0058011C
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

	// Token: 0x17001C33 RID: 7219
	// (get) Token: 0x06012B7B RID: 76667 RVA: 0x00581F49 File Offset: 0x00580149
	public List<global::IRoleDevDetailItemData> DetailItems
	{
		get
		{
			return this.DetailItemsInternal;
		}
	}

	// Token: 0x0400A224 RID: 41508
	private List<global::IRoleDevDetailItemData> DetailItemsInternal = new List<global::IRoleDevDetailItemData>();
}

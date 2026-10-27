using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02002818 RID: 10264
[NullableContext(1)]
[Nullable(0)]
public class ObtainedRoleDevRoleDetailItemData
{
	// Token: 0x06015169 RID: 86377 RVA: 0x00556B84 File Offset: 0x00554D84
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

	// Token: 0x0601516A RID: 86378 RVA: 0x00556C08 File Offset: 0x00554E08
	[NullableContext(2)]
	private RoleDataBase GetRoleData(int roleId)
	{
		return RoleModel.Instance.GetRoleDataById(roleId, true);
	}

	// Token: 0x0601516B RID: 86379 RVA: 0x00556C18 File Offset: 0x00554E18
	private void CollectUpgradeItems(int roleId, int currentLevel, int targetLevel)
	{
		global::IRoleDevDetailItemData roleDevDetailItemData = this.CreateRoleExpItemDetailData(roleId, currentLevel, targetLevel);
		if (roleDevDetailItemData != null)
		{
			this.DetailItemsInternal.Add(roleDevDetailItemData);
		}
	}

	// Token: 0x0601516C RID: 86380 RVA: 0x00556C40 File Offset: 0x00554E40
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

	// Token: 0x0601516D RID: 86381 RVA: 0x00556CA0 File Offset: 0x00554EA0
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

	// Token: 0x0601516E RID: 86382 RVA: 0x00556CD8 File Offset: 0x00554ED8
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

	// Token: 0x0601516F RID: 86383 RVA: 0x00556D34 File Offset: 0x00554F34
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

	// Token: 0x06015170 RID: 86384 RVA: 0x00556DB4 File Offset: 0x00554FB4
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

	// Token: 0x06015171 RID: 86385 RVA: 0x00556E17 File Offset: 0x00555017
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

	// Token: 0x06015172 RID: 86386 RVA: 0x00556E40 File Offset: 0x00555040
	private global::IRoleDevDetailItemData BuildExpItemDetailData(int roleId, List<global::IItemMaterial> totalMaterials)
	{
		List<global::IMaterialGroup> materialGroups = RoleDevUtils.GroupMaterialsByType(totalMaterials);
		return RoleDevUtils.BuildDetailItemData(roleId, materialGroups, ERoleDevMainPage.Role)[0];
	}

	// Token: 0x06015173 RID: 86387 RVA: 0x00556E64 File Offset: 0x00555064
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

	// Token: 0x06015174 RID: 86388 RVA: 0x00556E90 File Offset: 0x00555090
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

	// Token: 0x06015175 RID: 86389 RVA: 0x00556F54 File Offset: 0x00555154
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

	// Token: 0x06015176 RID: 86390 RVA: 0x00556FD0 File Offset: 0x005551D0
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

	// Token: 0x06015177 RID: 86391 RVA: 0x00557000 File Offset: 0x00555200
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

	// Token: 0x06015178 RID: 86392 RVA: 0x00557048 File Offset: 0x00555248
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

	// Token: 0x06015179 RID: 86393 RVA: 0x005570BC File Offset: 0x005552BC
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

	// Token: 0x0601517A RID: 86394 RVA: 0x0055711C File Offset: 0x0055531C
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

	// Token: 0x17001BDB RID: 7131
	// (get) Token: 0x0601517B RID: 86395 RVA: 0x00557149 File Offset: 0x00555349
	public List<global::IRoleDevDetailItemData> DetailItems
	{
		get
		{
			return this.DetailItemsInternal;
		}
	}

	// Token: 0x04009E3B RID: 40507
	private List<global::IRoleDevDetailItemData> DetailItemsInternal = new List<global::IRoleDevDetailItemData>();
}

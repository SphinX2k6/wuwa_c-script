using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02001DA5 RID: 7589
[NullableContext(1)]
[Nullable(0)]
public class NotObtainedRoleDevWeaponDetailItemData
{
	// Token: 0x06012CDA RID: 77018 RVA: 0x005866F8 File Offset: 0x005848F8
	public void InitByWeaponType(int roleId, int weaponType)
	{
		int currentBreachLevel = 0;
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(roleId);
		if (cultivateProject == null)
		{
			return;
		}
		int targetBreachLevel = cultivateProject.Value.WeaponBreachLevel - 1;
		int totalNeedExp = this.GetTotalNeedExp(weaponType);
		this.DetailItemsInternal.Clear();
		RoleDevWeaponItem? weaponItemConfig = this.GetWeaponItemConfig(weaponType);
		if (weaponItemConfig == null)
		{
			return;
		}
		this.CollectForecastUpgradeItemsWithExp(roleId, totalNeedExp);
		this.CollectForecastBreachItems(roleId, weaponItemConfig.Value, currentBreachLevel, targetBreachLevel);
	}

	// Token: 0x06012CDB RID: 77019 RVA: 0x0058676C File Offset: 0x0058496C
	private int GetTotalNeedExp(int weaponType)
	{
		RoleDevWeaponItem? weaponItemConfig = this.GetWeaponItemConfig(weaponType);
		if (weaponItemConfig == null)
		{
			return 0;
		}
		int? num = new int?(RoleDevUtils.GetCurrentProjectNum());
		if (num == null)
		{
			return 0;
		}
		int[] weaponTypeExperienceArray = weaponItemConfig.Value.GetWeaponTypeExperienceArray();
		if (weaponTypeExperienceArray == null || num.Value >= weaponTypeExperienceArray.Length)
		{
			return 0;
		}
		return weaponTypeExperienceArray[num.Value];
	}

	// Token: 0x06012CDC RID: 77020 RVA: 0x005867CD File Offset: 0x005849CD
	private RoleDevWeaponItem? GetWeaponItemConfig(int weaponType)
	{
		return RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(weaponType);
	}

	// Token: 0x06012CDD RID: 77021 RVA: 0x005867DC File Offset: 0x005849DC
	private void CollectForecastUpgradeItemsWithExp(int roleId, int totalNeedExp)
	{
		global::IRoleDevDetailItemData roleDevDetailItemData = this.CreateForecastWeaponExpItemDetailDataWithExp(roleId, totalNeedExp);
		if (roleDevDetailItemData != null)
		{
			this.DetailItemsInternal.Add(roleDevDetailItemData);
		}
	}

	// Token: 0x06012CDE RID: 77022 RVA: 0x00586804 File Offset: 0x00584A04
	[NullableContext(2)]
	private global::IRoleDevDetailItemData CreateForecastWeaponExpItemDetailDataWithExp(int roleId, int totalNeedExp)
	{
		if (totalNeedExp <= 0)
		{
			return null;
		}
		List<ItemDataBase> sortedExpItemList = this.GetSortedExpItemList();
		List<global::IItemMaterial> list = this.CalcRequiredExpMaterials(sortedExpItemList, totalNeedExp);
		if (list.Count == 0)
		{
			return null;
		}
		return this.BuildExpItemDetailData(roleId, list);
	}

	// Token: 0x06012CDF RID: 77023 RVA: 0x0058683C File Offset: 0x00584A3C
	private List<ItemDataBase> GetSortedExpItemList()
	{
		List<ItemInfo> weaponExpItemConfigList = WeaponModel.Instance.GetWeaponExpItemConfigList();
		List<ItemDataBase> list = new List<ItemDataBase>();
		foreach (ItemInfo itemInfo in weaponExpItemConfigList)
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(itemInfo.Id, 0);
			list.Add(new CommonItemData(itemInfo.Id, -1, itemCountByConfigId, InventoryDefine.EItemDataType.CommonItem, null));
		}
		return this.SortExpItemsByQuality(list);
	}

	// Token: 0x06012CE0 RID: 77024 RVA: 0x005868CC File Offset: 0x00584ACC
	private List<ItemDataBase> SortExpItemsByQuality(List<ItemDataBase> expItemList)
	{
		expItemList.Sort(delegate(ItemDataBase a, ItemDataBase b)
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(a.GetConfigId());
			ItemConfig itemConfigData2 = InventoryConfig.Instance.GetItemConfigData(b.GetConfigId());
			return ((itemConfigData != null) ? itemConfigData.QualityId : 0) - ((itemConfigData2 != null) ? itemConfigData2.QualityId : 0);
		});
		return expItemList;
	}

	// Token: 0x06012CE1 RID: 77025 RVA: 0x005868F4 File Offset: 0x00584AF4
	private global::IRoleDevDetailItemData BuildExpItemDetailData(int roleId, List<global::IItemMaterial> totalMaterials)
	{
		List<global::IMaterialGroup> materialGroups = RoleDevUtils.GroupMaterialsByType(totalMaterials);
		return RoleDevUtils.BuildDetailItemData(roleId, materialGroups, ERoleDevMainPage.Weapon)[0];
	}

	// Token: 0x06012CE2 RID: 77026 RVA: 0x00586918 File Offset: 0x00584B18
	private List<global::IItemMaterial> CalcRequiredExpMaterials(List<ItemDataBase> expItemList, int totalNeedExp)
	{
		List<global::IItemMaterial> list = new List<global::IItemMaterial>();
		int accumulatedExp = 0;
		accumulatedExp = this.UseExistingExpItems(expItemList, totalNeedExp, list, accumulatedExp);
		this.AddHighestQualityExpItemsIfNeeded(expItemList, totalNeedExp, list, accumulatedExp);
		return list;
	}

	// Token: 0x06012CE3 RID: 77027 RVA: 0x00586944 File Offset: 0x00584B44
	private int UseExistingExpItems(List<ItemDataBase> expItemList, int totalNeedExp, List<global::IItemMaterial> totalMaterials, int accumulatedExp)
	{
		int num = accumulatedExp;
		foreach (ItemDataBase itemDataBase in expItemList)
		{
			if (num >= totalNeedExp)
			{
				break;
			}
			WeaponExpItem? weaponExpItemConfig = WeaponConfig.Instance.GetWeaponExpItemConfig(itemDataBase.GetConfigId());
			if (weaponExpItemConfig != null)
			{
				int basicExp = weaponExpItemConfig.Value.BasicExp;
				int num2 = Math.Min((int)Math.Ceiling((double)(totalNeedExp - num) / (double)basicExp), itemDataBase.GetCount());
				if (num2 > 0)
				{
					totalMaterials.Add(new global::ItemMaterial
					{
						ItemId = itemDataBase.GetConfigId(),
						RequiredCount = num2
					});
					num += num2 * basicExp;
				}
			}
		}
		return num;
	}

	// Token: 0x06012CE4 RID: 77028 RVA: 0x00586A14 File Offset: 0x00584C14
	private void AddHighestQualityExpItemsIfNeeded(List<ItemDataBase> expItemList, int totalNeedExp, List<global::IItemMaterial> totalMaterials, int accumulatedExp)
	{
		if (accumulatedExp >= totalNeedExp || expItemList.Count == 0)
		{
			return;
		}
		ItemDataBase itemDataBase = expItemList[expItemList.Count - 1];
		WeaponExpItem? weaponExpItemConfig = WeaponConfig.Instance.GetWeaponExpItemConfig(itemDataBase.GetConfigId());
		if (weaponExpItemConfig == null)
		{
			return;
		}
		int basicExp = weaponExpItemConfig.Value.BasicExp;
		int requiredCount = (int)Math.Ceiling((double)(totalNeedExp - accumulatedExp) / (double)basicExp);
		totalMaterials.Add(new global::ItemMaterial
		{
			ItemId = itemDataBase.GetConfigId(),
			RequiredCount = requiredCount
		});
	}

	// Token: 0x06012CE5 RID: 77029 RVA: 0x00586A98 File Offset: 0x00584C98
	private void CollectForecastBreachItems(int roleId, RoleDevWeaponItem weaponItemConfig, int currentBreachLevel, int targetBreachLevel)
	{
		int weaponItemGroup = weaponItemConfig.WeaponItemGroup;
		if (weaponItemGroup == 0)
		{
			return;
		}
		List<global::IRoleDevDetailItemData> list = this.CreateForecastWeaponBreachItemDetailData(roleId, weaponItemGroup, currentBreachLevel, targetBreachLevel);
		if (list != null)
		{
			foreach (global::IRoleDevDetailItemData item in list)
			{
				this.DetailItemsInternal.Add(item);
			}
		}
	}

	// Token: 0x06012CE6 RID: 77030 RVA: 0x00586B08 File Offset: 0x00584D08
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::IRoleDevDetailItemData> CreateForecastWeaponBreachItemDetailData(int roleId, int breakGroupId, int currentBreachLevel, int targetBreachLevel)
	{
		if (currentBreachLevel > targetBreachLevel)
		{
			return null;
		}
		List<global::IItemMaterial> list = this.CalculateBreachMaterials(breakGroupId, currentBreachLevel, targetBreachLevel);
		if (list.Count == 0)
		{
			return null;
		}
		return this.BuildBreachDetailItems(roleId, list);
	}

	// Token: 0x06012CE7 RID: 77031 RVA: 0x00586B3C File Offset: 0x00584D3C
	private List<global::IItemMaterial> CalculateBreachMaterials(int breakGroupId, int currentBreachLevel, int targetBreachLevel)
	{
		List<global::IItemMaterial> list = new List<global::IItemMaterial>();
		for (int i = currentBreachLevel; i <= targetBreachLevel; i++)
		{
			WeaponBreach? weaponBreach = WeaponConfig.Instance.GetWeaponBreach(breakGroupId, i);
			if (weaponBreach != null)
			{
				this.AddBreachLevelMaterials(weaponBreach.Value, list);
			}
		}
		return list;
	}

	// Token: 0x06012CE8 RID: 77032 RVA: 0x00586B80 File Offset: 0x00584D80
	private void AddBreachLevelMaterials(WeaponBreach breachConfig, List<global::IItemMaterial> materials)
	{
		Dictionary<int, int> dictionary = breachConfig.Consume();
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
				this.AddOrUpdateMaterial(materials, key, value);
			}
		}
	}

	// Token: 0x06012CE9 RID: 77033 RVA: 0x00586BF4 File Offset: 0x00584DF4
	private void AddOrUpdateMaterial(List<global::IItemMaterial> materials, int itemId, int count)
	{
		global::IItemMaterial itemMaterial = null;
		foreach (global::IItemMaterial itemMaterial2 in materials)
		{
			if (itemMaterial2.ItemId == itemId)
			{
				itemMaterial = itemMaterial2;
				break;
			}
		}
		if (itemMaterial != null)
		{
			itemMaterial.RequiredCount += count;
			return;
		}
		materials.Add(new global::ItemMaterial
		{
			ItemId = itemId,
			RequiredCount = count
		});
	}

	// Token: 0x06012CEA RID: 77034 RVA: 0x00586C78 File Offset: 0x00584E78
	private List<global::IRoleDevDetailItemData> BuildBreachDetailItems(int roleId, List<global::IItemMaterial> materials)
	{
		List<global::IMaterialGroup> materialGroups = RoleDevUtils.GroupMaterialsByType(materials);
		List<global::IRoleDevDetailItemData> list = RoleDevUtils.BuildDetailItemData(roleId, materialGroups, ERoleDevMainPage.Weapon);
		if (list.Count <= 0)
		{
			return new List<global::IRoleDevDetailItemData>();
		}
		return list;
	}

	// Token: 0x17001C69 RID: 7273
	// (get) Token: 0x06012CEB RID: 77035 RVA: 0x00586CA5 File Offset: 0x00584EA5
	public List<global::IRoleDevDetailItemData> DetailItems
	{
		get
		{
			return this.DetailItemsInternal;
		}
	}

	// Token: 0x0400A279 RID: 41593
	private List<global::IRoleDevDetailItemData> DetailItemsInternal = new List<global::IRoleDevDetailItemData>();
}

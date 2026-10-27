using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x0200282A RID: 10282
[NullableContext(1)]
[Nullable(0)]
public class NotObtainedRoleDevWeaponDetailItemData
{
	// Token: 0x060152DC RID: 86748 RVA: 0x0055B9E4 File Offset: 0x00559BE4
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

	// Token: 0x060152DD RID: 86749 RVA: 0x0055BA58 File Offset: 0x00559C58
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

	// Token: 0x060152DE RID: 86750 RVA: 0x0055BAB9 File Offset: 0x00559CB9
	private RoleDevWeaponItem? GetWeaponItemConfig(int weaponType)
	{
		return RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(weaponType);
	}

	// Token: 0x060152DF RID: 86751 RVA: 0x0055BAC8 File Offset: 0x00559CC8
	private void CollectForecastUpgradeItemsWithExp(int roleId, int totalNeedExp)
	{
		global::IRoleDevDetailItemData roleDevDetailItemData = this.CreateForecastWeaponExpItemDetailDataWithExp(roleId, totalNeedExp);
		if (roleDevDetailItemData != null)
		{
			this.DetailItemsInternal.Add(roleDevDetailItemData);
		}
	}

	// Token: 0x060152E0 RID: 86752 RVA: 0x0055BAF0 File Offset: 0x00559CF0
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

	// Token: 0x060152E1 RID: 86753 RVA: 0x0055BB28 File Offset: 0x00559D28
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

	// Token: 0x060152E2 RID: 86754 RVA: 0x0055BBB8 File Offset: 0x00559DB8
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

	// Token: 0x060152E3 RID: 86755 RVA: 0x0055BBE0 File Offset: 0x00559DE0
	private global::IRoleDevDetailItemData BuildExpItemDetailData(int roleId, List<global::IItemMaterial> totalMaterials)
	{
		List<global::IMaterialGroup> materialGroups = RoleDevUtils.GroupMaterialsByType(totalMaterials);
		return RoleDevUtils.BuildDetailItemData(roleId, materialGroups, ERoleDevMainPage.Weapon)[0];
	}

	// Token: 0x060152E4 RID: 86756 RVA: 0x0055BC04 File Offset: 0x00559E04
	private List<global::IItemMaterial> CalcRequiredExpMaterials(List<ItemDataBase> expItemList, int totalNeedExp)
	{
		List<global::IItemMaterial> list = new List<global::IItemMaterial>();
		int accumulatedExp = 0;
		accumulatedExp = this.UseExistingExpItems(expItemList, totalNeedExp, list, accumulatedExp);
		this.AddHighestQualityExpItemsIfNeeded(expItemList, totalNeedExp, list, accumulatedExp);
		return list;
	}

	// Token: 0x060152E5 RID: 86757 RVA: 0x0055BC30 File Offset: 0x00559E30
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

	// Token: 0x060152E6 RID: 86758 RVA: 0x0055BD00 File Offset: 0x00559F00
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

	// Token: 0x060152E7 RID: 86759 RVA: 0x0055BD84 File Offset: 0x00559F84
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

	// Token: 0x060152E8 RID: 86760 RVA: 0x0055BDF4 File Offset: 0x00559FF4
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

	// Token: 0x060152E9 RID: 86761 RVA: 0x0055BE28 File Offset: 0x0055A028
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

	// Token: 0x060152EA RID: 86762 RVA: 0x0055BE6C File Offset: 0x0055A06C
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

	// Token: 0x060152EB RID: 86763 RVA: 0x0055BEE0 File Offset: 0x0055A0E0
	private void AddOrUpdateMaterial(List<global::IItemMaterial> materials, int itemId, int count)
	{
		global::IItemMaterial itemMaterial = materials.FirstOrDefault((global::IItemMaterial material) => material.ItemId == itemId);
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

	// Token: 0x060152EC RID: 86764 RVA: 0x0055BF40 File Offset: 0x0055A140
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

	// Token: 0x17001C11 RID: 7185
	// (get) Token: 0x060152ED RID: 86765 RVA: 0x0055BF6D File Offset: 0x0055A16D
	public List<global::IRoleDevDetailItemData> DetailItems
	{
		get
		{
			return this.DetailItemsInternal;
		}
	}

	// Token: 0x04009E90 RID: 40592
	private List<global::IRoleDevDetailItemData> DetailItemsInternal = new List<global::IRoleDevDetailItemData>();
}

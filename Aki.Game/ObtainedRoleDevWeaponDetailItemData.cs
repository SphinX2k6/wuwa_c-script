using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x0200282E RID: 10286
[NullableContext(1)]
[Nullable(0)]
public class ObtainedRoleDevWeaponDetailItemData
{
	// Token: 0x06015313 RID: 86803 RVA: 0x0055C234 File Offset: 0x0055A434
	public void InitByWeaponInstance(int roleId, WeaponInstance weaponInstance)
	{
		this.DetailItemsInternal.Clear();
		int level = weaponInstance.GetLevel();
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(roleId);
		if (cultivateProject == null)
		{
			return;
		}
		int weaponLevel = cultivateProject.Value.WeaponLevel;
		int breachLevel = weaponInstance.GetBreachLevel();
		int targetBreachLevel = cultivateProject.Value.WeaponBreachLevel - 1;
		this.CollectUpgradeItems(roleId, weaponInstance, level, weaponLevel);
		this.CollectBreachItems(roleId, weaponInstance, breachLevel, targetBreachLevel);
	}

	// Token: 0x06015314 RID: 86804 RVA: 0x0055C2A8 File Offset: 0x0055A4A8
	private void CollectUpgradeItems(int roleId, WeaponInstance weaponInstance, int currentLevel, int targetLevel)
	{
		global::IRoleDevDetailItemData roleDevDetailItemData = this.CreateWeaponExpItemDetailData(roleId, weaponInstance, currentLevel, targetLevel);
		if (roleDevDetailItemData != null)
		{
			this.DetailItemsInternal.Add(roleDevDetailItemData);
		}
	}

	// Token: 0x06015315 RID: 86805 RVA: 0x0055C2D0 File Offset: 0x0055A4D0
	private void CollectBreachItems(int roleId, WeaponInstance weaponInstance, int currentBreachLevel, int targetBreachLevel)
	{
		List<global::IRoleDevDetailItemData> list = this.CreateWeaponBreachItemDetailData(roleId, weaponInstance, currentBreachLevel, targetBreachLevel);
		if (list != null)
		{
			foreach (global::IRoleDevDetailItemData item in list)
			{
				this.DetailItemsInternal.Add(item);
			}
		}
	}

	// Token: 0x06015316 RID: 86806 RVA: 0x0055C334 File Offset: 0x0055A534
	[return: Nullable(2)]
	private global::IRoleDevDetailItemData CreateWeaponExpItemDetailData(int roleId, WeaponInstance weaponInstance, int currentLevel, int targetLevel)
	{
		if (currentLevel >= targetLevel)
		{
			return null;
		}
		int totalNeedExp = this.CalculateTotalNeedExp(weaponInstance, currentLevel, targetLevel);
		List<ItemInfo> sortedExpItemList = this.GetSortedExpItemList();
		List<global::IItemMaterial> list = this.CalcRequiredExpMaterials(sortedExpItemList, totalNeedExp);
		if (list.Count == 0)
		{
			return null;
		}
		return this.BuildExpItemDetailData(roleId, list);
	}

	// Token: 0x06015317 RID: 86807 RVA: 0x0055C378 File Offset: 0x0055A578
	private int CalculateTotalNeedExp(WeaponInstance weaponInstance, int currentLevel, int targetLevel)
	{
		int num = -weaponInstance.GetExp();
		for (int i = currentLevel; i < targetLevel; i++)
		{
			num += weaponInstance.GetLevelExp(i);
		}
		int num2 = this.CalculateBreachOverflowExp(weaponInstance);
		return num + num2;
	}

	// Token: 0x06015318 RID: 86808 RVA: 0x0055C3B0 File Offset: 0x0055A5B0
	private int CalculateBreachOverflowExp(WeaponInstance weaponInstance)
	{
		int breachLevel = weaponInstance.GetBreachLevel();
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(weaponInstance.GetRoleId());
		if (cultivateProject == null)
		{
			return 0;
		}
		int num = cultivateProject.Value.WeaponBreachLevel - breachLevel;
		if (num <= 0)
		{
			return 0;
		}
		RoleDevCulProjectConfig? roleDevStaticConfig = RoleDevConfig.Instance.GetRoleDevStaticConfig();
		int num2 = (roleDevStaticConfig != null) ? roleDevStaticConfig.GetValueOrDefault().OverflowExperience : 1;
		return num * num2;
	}

	// Token: 0x06015319 RID: 86809 RVA: 0x0055C421 File Offset: 0x0055A621
	private List<ItemInfo> GetSortedExpItemList()
	{
		List<ItemInfo> weaponExpItemConfigList = WeaponModel.Instance.GetWeaponExpItemConfigList();
		weaponExpItemConfigList.Sort((ItemInfo a, ItemInfo b) => a.QualityId - b.QualityId);
		return weaponExpItemConfigList;
	}

	// Token: 0x0601531A RID: 86810 RVA: 0x0055C454 File Offset: 0x0055A654
	private global::IRoleDevDetailItemData BuildExpItemDetailData(int roleId, List<global::IItemMaterial> totalMaterials)
	{
		List<global::IMaterialGroup> materialGroups = RoleDevUtils.GroupMaterialsByType(totalMaterials);
		return RoleDevUtils.BuildDetailItemData(roleId, materialGroups, ERoleDevMainPage.Weapon)[0];
	}

	// Token: 0x0601531B RID: 86811 RVA: 0x0055C478 File Offset: 0x0055A678
	private List<global::IItemMaterial> CalcRequiredExpMaterials(List<ItemInfo> expItemList, int totalNeedExp)
	{
		List<global::IItemMaterial> list = new List<global::IItemMaterial>();
		int accumulatedExp = 0;
		accumulatedExp = this.UseExistingExpItems(expItemList, totalNeedExp, list, accumulatedExp);
		this.AddHighestQualityExpItemsIfNeeded(expItemList, totalNeedExp, list, accumulatedExp);
		return list;
	}

	// Token: 0x0601531C RID: 86812 RVA: 0x0055C4A4 File Offset: 0x0055A6A4
	private int UseExistingExpItems(List<ItemInfo> expItemList, int totalNeedExp, List<global::IItemMaterial> totalMaterials, int accumulatedExp)
	{
		int num = accumulatedExp;
		foreach (ItemInfo itemInfo in expItemList)
		{
			if (num >= totalNeedExp)
			{
				break;
			}
			int id = itemInfo.Id;
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(id, 0);
			WeaponExpItem? weaponExpItemConfig = WeaponConfig.Instance.GetWeaponExpItemConfig(id);
			if (weaponExpItemConfig != null)
			{
				int basicExp = weaponExpItemConfig.Value.BasicExp;
				int num2 = Math.Min((int)Math.Ceiling((double)(totalNeedExp - num) / (double)basicExp), commonItemCount);
				if (num2 > 0)
				{
					totalMaterials.Add(new global::ItemMaterial
					{
						ItemId = id,
						RequiredCount = num2
					});
					num += num2 * basicExp;
				}
			}
		}
		return num;
	}

	// Token: 0x0601531D RID: 86813 RVA: 0x0055C57C File Offset: 0x0055A77C
	private void AddHighestQualityExpItemsIfNeeded(List<ItemInfo> expItemList, int totalNeedExp, List<global::IItemMaterial> totalMaterials, int accumulatedExp)
	{
		if (accumulatedExp >= totalNeedExp || expItemList.Count == 0)
		{
			return;
		}
		ItemInfo itemInfo = expItemList[expItemList.Count - 1];
		WeaponExpItem? weaponExpItemConfig = WeaponConfig.Instance.GetWeaponExpItemConfig(itemInfo.Id);
		if (weaponExpItemConfig == null)
		{
			return;
		}
		int basicExp = weaponExpItemConfig.Value.BasicExp;
		int requiredCount = (int)Math.Ceiling((double)(totalNeedExp - accumulatedExp) / (double)basicExp);
		totalMaterials.Add(new global::ItemMaterial
		{
			ItemId = itemInfo.Id,
			RequiredCount = requiredCount
		});
	}

	// Token: 0x0601531E RID: 86814 RVA: 0x0055C604 File Offset: 0x0055A804
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::IRoleDevDetailItemData> CreateWeaponBreachItemDetailData(int roleId, WeaponInstance weaponInstance, int currentBreachLevel, int targetBreachLevel)
	{
		if (currentBreachLevel > targetBreachLevel)
		{
			return null;
		}
		WeaponConf? weaponConfig = weaponInstance.GetWeaponConfig();
		if (weaponConfig == null)
		{
			return null;
		}
		List<global::IItemMaterial> list = this.CalculateBreachMaterials(weaponConfig.Value, currentBreachLevel, targetBreachLevel);
		if (list.Count == 0)
		{
			return null;
		}
		return this.BuildBreachDetailItems(roleId, list);
	}

	// Token: 0x0601531F RID: 86815 RVA: 0x0055C650 File Offset: 0x0055A850
	private List<global::IItemMaterial> CalculateBreachMaterials(WeaponConf weaponConfig, int currentBreachLevel, int targetBreachLevel)
	{
		List<global::IItemMaterial> list = new List<global::IItemMaterial>();
		int num = Math.Min(WeaponModel.Instance.GetWeaponBreachMaxLevel(weaponConfig.BreachId), targetBreachLevel);
		for (int i = currentBreachLevel; i <= num; i++)
		{
			WeaponBreach? weaponBreach = WeaponConfig.Instance.GetWeaponBreach(weaponConfig.BreachId, i);
			if (weaponBreach != null)
			{
				this.AddBreachLevelMaterials(weaponBreach.Value, list);
			}
		}
		return list;
	}

	// Token: 0x06015320 RID: 86816 RVA: 0x0055C6B4 File Offset: 0x0055A8B4
	private void AddBreachLevelMaterials(WeaponBreach breachConfig, List<global::IItemMaterial> totalMaterials)
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
				this.AddOrUpdateMaterial(totalMaterials, key, value);
			}
		}
	}

	// Token: 0x06015321 RID: 86817 RVA: 0x0055C728 File Offset: 0x0055A928
	private void AddOrUpdateMaterial(List<global::IItemMaterial> totalMaterials, int itemId, int count)
	{
		global::IItemMaterial itemMaterial = totalMaterials.FirstOrDefault((global::IItemMaterial material) => material.ItemId == itemId);
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

	// Token: 0x06015322 RID: 86818 RVA: 0x0055C788 File Offset: 0x0055A988
	private List<global::IRoleDevDetailItemData> BuildBreachDetailItems(int roleId, List<global::IItemMaterial> totalMaterials)
	{
		List<global::IMaterialGroup> materialGroups = RoleDevUtils.GroupMaterialsByType(totalMaterials);
		List<global::IRoleDevDetailItemData> list = RoleDevUtils.BuildDetailItemData(roleId, materialGroups, ERoleDevMainPage.Weapon);
		if (list.Count <= 0)
		{
			return new List<global::IRoleDevDetailItemData>();
		}
		return list;
	}

	// Token: 0x17001C13 RID: 7187
	// (get) Token: 0x06015323 RID: 86819 RVA: 0x0055C7B5 File Offset: 0x0055A9B5
	public List<global::IRoleDevDetailItemData> DetailItems
	{
		get
		{
			return this.DetailItemsInternal;
		}
	}

	// Token: 0x04009E96 RID: 40598
	private List<global::IRoleDevDetailItemData> DetailItemsInternal = new List<global::IRoleDevDetailItemData>();
}

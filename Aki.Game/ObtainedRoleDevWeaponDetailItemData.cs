using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02001DA9 RID: 7593
[NullableContext(1)]
[Nullable(0)]
public class ObtainedRoleDevWeaponDetailItemData
{
	// Token: 0x06012D11 RID: 77073 RVA: 0x00586F6C File Offset: 0x0058516C
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

	// Token: 0x06012D12 RID: 77074 RVA: 0x00586FE0 File Offset: 0x005851E0
	private void CollectUpgradeItems(int roleId, WeaponInstance weaponInstance, int currentLevel, int targetLevel)
	{
		global::IRoleDevDetailItemData roleDevDetailItemData = this.CreateWeaponExpItemDetailData(roleId, weaponInstance, currentLevel, targetLevel);
		if (roleDevDetailItemData != null)
		{
			this.DetailItemsInternal.Add(roleDevDetailItemData);
		}
	}

	// Token: 0x06012D13 RID: 77075 RVA: 0x00587008 File Offset: 0x00585208
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

	// Token: 0x06012D14 RID: 77076 RVA: 0x0058706C File Offset: 0x0058526C
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

	// Token: 0x06012D15 RID: 77077 RVA: 0x005870B0 File Offset: 0x005852B0
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

	// Token: 0x06012D16 RID: 77078 RVA: 0x005870E8 File Offset: 0x005852E8
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

	// Token: 0x06012D17 RID: 77079 RVA: 0x00587159 File Offset: 0x00585359
	private List<ItemInfo> GetSortedExpItemList()
	{
		List<ItemInfo> weaponExpItemConfigList = WeaponModel.Instance.GetWeaponExpItemConfigList();
		weaponExpItemConfigList.Sort((ItemInfo a, ItemInfo b) => a.QualityId - b.QualityId);
		return weaponExpItemConfigList;
	}

	// Token: 0x06012D18 RID: 77080 RVA: 0x0058718C File Offset: 0x0058538C
	private global::IRoleDevDetailItemData BuildExpItemDetailData(int roleId, List<global::IItemMaterial> totalMaterials)
	{
		List<global::IMaterialGroup> materialGroups = RoleDevUtils.GroupMaterialsByType(totalMaterials);
		return RoleDevUtils.BuildDetailItemData(roleId, materialGroups, ERoleDevMainPage.Weapon)[0];
	}

	// Token: 0x06012D19 RID: 77081 RVA: 0x005871B0 File Offset: 0x005853B0
	private List<global::IItemMaterial> CalcRequiredExpMaterials(List<ItemInfo> expItemList, int totalNeedExp)
	{
		List<global::IItemMaterial> list = new List<global::IItemMaterial>();
		int accumulatedExp = 0;
		accumulatedExp = this.UseExistingExpItems(expItemList, totalNeedExp, list, accumulatedExp);
		this.AddHighestQualityExpItemsIfNeeded(expItemList, totalNeedExp, list, accumulatedExp);
		return list;
	}

	// Token: 0x06012D1A RID: 77082 RVA: 0x005871DC File Offset: 0x005853DC
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

	// Token: 0x06012D1B RID: 77083 RVA: 0x005872B4 File Offset: 0x005854B4
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

	// Token: 0x06012D1C RID: 77084 RVA: 0x0058733C File Offset: 0x0058553C
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

	// Token: 0x06012D1D RID: 77085 RVA: 0x00587388 File Offset: 0x00585588
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

	// Token: 0x06012D1E RID: 77086 RVA: 0x005873EC File Offset: 0x005855EC
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

	// Token: 0x06012D1F RID: 77087 RVA: 0x00587460 File Offset: 0x00585660
	private void AddOrUpdateMaterial(List<global::IItemMaterial> totalMaterials, int itemId, int count)
	{
		global::IItemMaterial itemMaterial = null;
		foreach (global::IItemMaterial itemMaterial2 in totalMaterials)
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
		totalMaterials.Add(new global::ItemMaterial
		{
			ItemId = itemId,
			RequiredCount = count
		});
	}

	// Token: 0x06012D20 RID: 77088 RVA: 0x005874E4 File Offset: 0x005856E4
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

	// Token: 0x17001C6B RID: 7275
	// (get) Token: 0x06012D21 RID: 77089 RVA: 0x00587511 File Offset: 0x00585711
	public List<global::IRoleDevDetailItemData> DetailItems
	{
		get
		{
			return this.DetailItemsInternal;
		}
	}

	// Token: 0x0400A27F RID: 41599
	private List<global::IRoleDevDetailItemData> DetailItemsInternal = new List<global::IRoleDevDetailItemData>();
}

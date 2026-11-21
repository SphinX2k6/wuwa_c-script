using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

// Token: 0x02001DA1 RID: 7585
[NullableContext(1)]
[Nullable(0)]
public class ForecastRoleDevWeaponDetailItemData
{
	// Token: 0x06012CA4 RID: 76964 RVA: 0x00586000 File Offset: 0x00584200
	public void InitByWeaponType(int roleId, int weaponType)
	{
		this.DetailItemsInternal.Clear();
		IRoleDevProsProjectConfig roleDevProsProjectConfig = RoleDevConfig.Instance.GetRoleDevProsProjectConfig(roleId);
		if (roleDevProsProjectConfig == null)
		{
			return;
		}
		int weaponExperience = roleDevProsProjectConfig.WeaponExperience;
		if (this.GetWeaponItemConfig(weaponType) == null)
		{
			return;
		}
		this.CollectForecastUpgradeItemsWithExp(roleId, weaponExperience);
		this.CollectForecastBreachItems(roleId);
	}

	// Token: 0x06012CA5 RID: 76965 RVA: 0x00586050 File Offset: 0x00584250
	private RoleDevWeaponItem? GetWeaponItemConfig(int weaponType)
	{
		return RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(weaponType);
	}

	// Token: 0x06012CA6 RID: 76966 RVA: 0x00586060 File Offset: 0x00584260
	private void CollectForecastUpgradeItemsWithExp(int roleId, int totalNeedExp)
	{
		global::IRoleDevDetailItemData roleDevDetailItemData = this.CreateForecastWeaponExpItemDetailDataWithExp(roleId, totalNeedExp);
		if (roleDevDetailItemData != null)
		{
			this.DetailItemsInternal.Add(roleDevDetailItemData);
		}
	}

	// Token: 0x06012CA7 RID: 76967 RVA: 0x00586088 File Offset: 0x00584288
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

	// Token: 0x06012CA8 RID: 76968 RVA: 0x005860C0 File Offset: 0x005842C0
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

	// Token: 0x06012CA9 RID: 76969 RVA: 0x00586150 File Offset: 0x00584350
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

	// Token: 0x06012CAA RID: 76970 RVA: 0x00586178 File Offset: 0x00584378
	private global::IRoleDevDetailItemData BuildExpItemDetailData(int roleId, List<global::IItemMaterial> totalMaterials)
	{
		List<global::IMaterialGroup> materialGroups = RoleDevUtils.GroupMaterialsByType(totalMaterials);
		return RoleDevUtils.BuildDetailItemData(roleId, materialGroups, ERoleDevMainPage.Weapon)[0];
	}

	// Token: 0x06012CAB RID: 76971 RVA: 0x0058619C File Offset: 0x0058439C
	private List<global::IItemMaterial> CalcRequiredExpMaterials(List<ItemDataBase> expItemList, int totalNeedExp)
	{
		List<global::IItemMaterial> list = new List<global::IItemMaterial>();
		int accumulatedExp = 0;
		accumulatedExp = this.UseExistingExpItems(expItemList, totalNeedExp, list, accumulatedExp);
		this.AddHighestQualityExpItemsIfNeeded(expItemList, totalNeedExp, list, accumulatedExp);
		return list;
	}

	// Token: 0x06012CAC RID: 76972 RVA: 0x005861C8 File Offset: 0x005843C8
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

	// Token: 0x06012CAD RID: 76973 RVA: 0x00586298 File Offset: 0x00584498
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

	// Token: 0x06012CAE RID: 76974 RVA: 0x0058631C File Offset: 0x0058451C
	private void CollectForecastBreachItems(int roleId)
	{
		List<global::IRoleDevDetailItemData> list = this.CreateForecastWeaponBreachItemDetailData(roleId);
		if (list != null)
		{
			this.DetailItemsInternal.AddRange(list);
		}
	}

	// Token: 0x06012CAF RID: 76975 RVA: 0x00586340 File Offset: 0x00584540
	[NullableContext(2)]
	private IRoleDevProsProjectConfig GetRoleDevProsProjectConfig(int roleId)
	{
		return RoleDevConfig.Instance.GetRoleDevProsProjectConfig(roleId);
	}

	// Token: 0x06012CB0 RID: 76976 RVA: 0x00586350 File Offset: 0x00584550
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::IRoleDevDetailItemData> CreateForecastWeaponBreachItemDetailData(int roleId)
	{
		IRoleDevProsProjectConfig roleDevProsProjectConfig = this.GetRoleDevProsProjectConfig(roleId);
		if (roleDevProsProjectConfig == null)
		{
			return null;
		}
		List<RoleDevProsRoleItem> weaponItemGroups = this.GetWeaponItemGroups(roleDevProsProjectConfig);
		if (weaponItemGroups.Count == 0)
		{
			return null;
		}
		return this.BuildBreachDetailItems(roleId, weaponItemGroups);
	}

	// Token: 0x06012CB1 RID: 76977 RVA: 0x00586384 File Offset: 0x00584584
	private List<RoleDevProsRoleItem> GetWeaponItemGroups(IRoleDevProsProjectConfig roleDevProsProject)
	{
		List<RoleDevProsRoleItem> list = new List<RoleDevProsRoleItem>();
		foreach (int itemGroupId in roleDevProsProject.WeaponBreachItemGroup)
		{
			RoleDevProsRoleItem? roleDevProsRoleItemConfig = RoleDevConfig.Instance.GetRoleDevProsRoleItemConfig(itemGroupId);
			if (roleDevProsRoleItemConfig != null)
			{
				list.Add(roleDevProsRoleItemConfig.Value);
			}
		}
		return list;
	}

	// Token: 0x06012CB2 RID: 76978 RVA: 0x005863FC File Offset: 0x005845FC
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::IRoleDevDetailItemData> BuildBreachDetailItems(int roleId, List<RoleDevProsRoleItem> weaponItemGroups)
	{
		List<global::IRoleDevDetailItemData> list = new List<global::IRoleDevDetailItemData>();
		foreach (RoleDevProsRoleItem group in weaponItemGroups)
		{
			List<global::IItemMaterial> list2 = this.ConvertGroupToMaterials(group);
			if (list2.Count > 0)
			{
				List<global::IRoleDevDetailItemData> collection = this.BuildGroupDetailItems(roleId, group, list2);
				list.AddRange(collection);
			}
		}
		if (list.Count <= 0)
		{
			return null;
		}
		return list;
	}

	// Token: 0x06012CB3 RID: 76979 RVA: 0x0058647C File Offset: 0x0058467C
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

	// Token: 0x06012CB4 RID: 76980 RVA: 0x005864F8 File Offset: 0x005846F8
	private List<global::IRoleDevDetailItemData> BuildGroupDetailItems(int roleId, RoleDevProsRoleItem group, List<global::IItemMaterial> materials)
	{
		return RoleDevUtils.BuildDetailItemData(roleId, new List<global::IMaterialGroup>
		{
			new global::MaterialGroup
			{
				Type = group.ItemTypeId,
				Materials = materials
			}
		}, ERoleDevMainPage.Weapon);
	}

	// Token: 0x17001C68 RID: 7272
	// (get) Token: 0x06012CB5 RID: 76981 RVA: 0x00586532 File Offset: 0x00584732
	public List<global::IRoleDevDetailItemData> DetailItems
	{
		get
		{
			return this.DetailItemsInternal;
		}
	}

	// Token: 0x0400A273 RID: 41587
	private List<global::IRoleDevDetailItemData> DetailItemsInternal = new List<global::IRoleDevDetailItemData>();
}

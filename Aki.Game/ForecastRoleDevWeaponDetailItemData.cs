using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

// Token: 0x02002826 RID: 10278
[NullableContext(1)]
[Nullable(0)]
public class ForecastRoleDevWeaponDetailItemData
{
	// Token: 0x060152A6 RID: 86694 RVA: 0x0055B2EC File Offset: 0x005594EC
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

	// Token: 0x060152A7 RID: 86695 RVA: 0x0055B33C File Offset: 0x0055953C
	private RoleDevWeaponItem? GetWeaponItemConfig(int weaponType)
	{
		return RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(weaponType);
	}

	// Token: 0x060152A8 RID: 86696 RVA: 0x0055B34C File Offset: 0x0055954C
	private void CollectForecastUpgradeItemsWithExp(int roleId, int totalNeedExp)
	{
		global::IRoleDevDetailItemData roleDevDetailItemData = this.CreateForecastWeaponExpItemDetailDataWithExp(roleId, totalNeedExp);
		if (roleDevDetailItemData != null)
		{
			this.DetailItemsInternal.Add(roleDevDetailItemData);
		}
	}

	// Token: 0x060152A9 RID: 86697 RVA: 0x0055B374 File Offset: 0x00559574
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

	// Token: 0x060152AA RID: 86698 RVA: 0x0055B3AC File Offset: 0x005595AC
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

	// Token: 0x060152AB RID: 86699 RVA: 0x0055B43C File Offset: 0x0055963C
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

	// Token: 0x060152AC RID: 86700 RVA: 0x0055B464 File Offset: 0x00559664
	private global::IRoleDevDetailItemData BuildExpItemDetailData(int roleId, List<global::IItemMaterial> totalMaterials)
	{
		List<global::IMaterialGroup> materialGroups = RoleDevUtils.GroupMaterialsByType(totalMaterials);
		return RoleDevUtils.BuildDetailItemData(roleId, materialGroups, ERoleDevMainPage.Weapon)[0];
	}

	// Token: 0x060152AD RID: 86701 RVA: 0x0055B488 File Offset: 0x00559688
	private List<global::IItemMaterial> CalcRequiredExpMaterials(List<ItemDataBase> expItemList, int totalNeedExp)
	{
		List<global::IItemMaterial> list = new List<global::IItemMaterial>();
		int accumulatedExp = 0;
		accumulatedExp = this.UseExistingExpItems(expItemList, totalNeedExp, list, accumulatedExp);
		this.AddHighestQualityExpItemsIfNeeded(expItemList, totalNeedExp, list, accumulatedExp);
		return list;
	}

	// Token: 0x060152AE RID: 86702 RVA: 0x0055B4B4 File Offset: 0x005596B4
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

	// Token: 0x060152AF RID: 86703 RVA: 0x0055B584 File Offset: 0x00559784
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

	// Token: 0x060152B0 RID: 86704 RVA: 0x0055B608 File Offset: 0x00559808
	private void CollectForecastBreachItems(int roleId)
	{
		List<global::IRoleDevDetailItemData> list = this.CreateForecastWeaponBreachItemDetailData(roleId);
		if (list != null)
		{
			this.DetailItemsInternal.AddRange(list);
		}
	}

	// Token: 0x060152B1 RID: 86705 RVA: 0x0055B62C File Offset: 0x0055982C
	[NullableContext(2)]
	private IRoleDevProsProjectConfig GetRoleDevProsProjectConfig(int roleId)
	{
		return RoleDevConfig.Instance.GetRoleDevProsProjectConfig(roleId);
	}

	// Token: 0x060152B2 RID: 86706 RVA: 0x0055B63C File Offset: 0x0055983C
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

	// Token: 0x060152B3 RID: 86707 RVA: 0x0055B670 File Offset: 0x00559870
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

	// Token: 0x060152B4 RID: 86708 RVA: 0x0055B6E8 File Offset: 0x005598E8
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

	// Token: 0x060152B5 RID: 86709 RVA: 0x0055B768 File Offset: 0x00559968
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

	// Token: 0x060152B6 RID: 86710 RVA: 0x0055B7E4 File Offset: 0x005599E4
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

	// Token: 0x17001C10 RID: 7184
	// (get) Token: 0x060152B7 RID: 86711 RVA: 0x0055B81E File Offset: 0x00559A1E
	public List<global::IRoleDevDetailItemData> DetailItems
	{
		get
		{
			return this.DetailItemsInternal;
		}
	}

	// Token: 0x04009E8A RID: 40586
	private List<global::IRoleDevDetailItemData> DetailItemsInternal = new List<global::IRoleDevDetailItemData>();
}

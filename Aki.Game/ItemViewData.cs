using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using FilterDefine;

// Token: 0x020014CF RID: 5327
[NullableContext(1)]
[Nullable(0)]
public class ItemViewData : IPhantomFilterData
{
	// Token: 0x0600D51B RID: 54555 RVA: 0x003F5B2C File Offset: 0x003F3D2C
	public ItemViewData(InventoryDefine.IItemViewDataInfo itemViewInfo)
	{
		this.ItemViewInfo = itemViewInfo;
	}

	// Token: 0x0600D51C RID: 54556 RVA: 0x003F5B3B File Offset: 0x003F3D3B
	public void SetItemViewInfo(InventoryDefine.IItemViewDataInfo itemViewInfo)
	{
		this.ItemViewInfo = itemViewInfo;
	}

	// Token: 0x0600D51D RID: 54557 RVA: 0x003F5B44 File Offset: 0x003F3D44
	public InventoryDefine.IItemViewDataInfo GetItemViewInfo()
	{
		return this.ItemViewInfo;
	}

	// Token: 0x0600D51E RID: 54558 RVA: 0x003F5B4C File Offset: 0x003F3D4C
	private void SetIsNew(bool isNew)
	{
		this.ItemViewInfo.IsNewItem = isNew;
	}

	// Token: 0x0600D51F RID: 54559 RVA: 0x003F5B5A File Offset: 0x003F3D5A
	public void SetIsLock(bool bIsLock)
	{
		this.ItemViewInfo.IsLock = bIsLock;
	}

	// Token: 0x0600D520 RID: 54560 RVA: 0x003F5B68 File Offset: 0x003F3D68
	public void SetIsDeprecate(bool isDeprecate)
	{
		this.ItemViewInfo.IsDeprecate = isDeprecate;
	}

	// Token: 0x0600D521 RID: 54561 RVA: 0x003F5B76 File Offset: 0x003F3D76
	public void SetHasRedDot(bool hasRedDot)
	{
		this.ItemViewInfo.HasRedDot = hasRedDot;
	}

	// Token: 0x0600D522 RID: 54562 RVA: 0x003F5B84 File Offset: 0x003F3D84
	public InventoryDefine.ERedDotDisableRule GetRedDotDisableRule()
	{
		int configId = this.GetConfigId();
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(configId);
		if (itemConfigData == null)
		{
			return InventoryDefine.ERedDotDisableRule.None;
		}
		return itemConfigData.RedDotDisableRule;
	}

	// Token: 0x0600D523 RID: 54563 RVA: 0x003F5BAF File Offset: 0x003F3DAF
	public int GetConfigId()
	{
		return this.ItemViewInfo.ConfigId;
	}

	// Token: 0x0600D524 RID: 54564 RVA: 0x003F5BBC File Offset: 0x003F3DBC
	public int GetUniqueId()
	{
		ItemDataBase itemDataBase = this.GetItemDataBase();
		if (itemDataBase == null)
		{
			return 0;
		}
		return itemDataBase.GetUniqueId();
	}

	// Token: 0x0600D525 RID: 54565 RVA: 0x003F5BDC File Offset: 0x003F3DDC
	public int GetQuality()
	{
		ItemDataBase itemDataBase = this.GetItemDataBase();
		if (itemDataBase == null)
		{
			return 0;
		}
		return itemDataBase.GetQuality();
	}

	// Token: 0x0600D526 RID: 54566 RVA: 0x003F5BFB File Offset: 0x003F3DFB
	public void SetCount(int count)
	{
		this.ItemViewInfo.Count = count;
	}

	// Token: 0x0600D527 RID: 54567 RVA: 0x003F5C09 File Offset: 0x003F3E09
	public int GetCount()
	{
		return this.ItemViewInfo.Count;
	}

	// Token: 0x0600D528 RID: 54568 RVA: 0x003F5C16 File Offset: 0x003F3E16
	public void SetStackId(int stackId)
	{
		this.ItemViewInfo.StackId = stackId;
	}

	// Token: 0x0600D529 RID: 54569 RVA: 0x003F5C24 File Offset: 0x003F3E24
	public int GetStackId()
	{
		return this.ItemViewInfo.StackId;
	}

	// Token: 0x0600D52A RID: 54570 RVA: 0x003F5C31 File Offset: 0x003F3E31
	public void SetSelectOn(bool isSelectOn)
	{
		this.ItemViewInfo.IsSelectOn = isSelectOn;
	}

	// Token: 0x0600D52B RID: 54571 RVA: 0x003F5C3F File Offset: 0x003F3E3F
	public bool GetSelectOn()
	{
		return this.ItemViewInfo.IsSelectOn;
	}

	// Token: 0x0600D52C RID: 54572 RVA: 0x003F5C4C File Offset: 0x003F3E4C
	public void SetSelectNum(int selectNum)
	{
		this.ItemViewInfo.SelectOnNum = selectNum;
	}

	// Token: 0x0600D52D RID: 54573 RVA: 0x003F5C5A File Offset: 0x003F3E5A
	public int GetSelectNum()
	{
		return this.ItemViewInfo.SelectOnNum;
	}

	// Token: 0x0600D52E RID: 54574 RVA: 0x003F5C67 File Offset: 0x003F3E67
	public ItemDataBase GetItemDataBase()
	{
		return this.ItemViewInfo.ItemDataBase;
	}

	// Token: 0x0600D52F RID: 54575 RVA: 0x003F5C74 File Offset: 0x003F3E74
	public InventoryDefine.EItemDataType GetItemDataType()
	{
		return this.ItemViewInfo.ItemDataType;
	}

	// Token: 0x0600D530 RID: 54576 RVA: 0x003F5C81 File Offset: 0x003F3E81
	public int GetSortIndex()
	{
		return this.GetItemDataBase().GetSortIndex();
	}

	// Token: 0x0600D531 RID: 54577 RVA: 0x003F5C90 File Offset: 0x003F3E90
	public void RemoveNewItem()
	{
		InventoryModel instance = InventoryModel.Instance;
		bool itemDataType = this.GetItemDataType() != InventoryDefine.EItemDataType.CommonItem;
		int configId = this.GetConfigId();
		int uniqueId = this.GetUniqueId();
		if (!itemDataType)
		{
			instance.RemoveNewCommonItem(configId, uniqueId);
		}
		else
		{
			instance.RemoveNewAttributeItem(uniqueId);
		}
		this.SetIsNew(false);
	}

	// Token: 0x0600D532 RID: 54578 RVA: 0x003F5CD4 File Offset: 0x003F3ED4
	public void RemoveRedDotItem()
	{
		InventoryModel instance = InventoryModel.Instance;
		bool itemDataType = this.GetItemDataType() != InventoryDefine.EItemDataType.CommonItem;
		int configId = this.GetConfigId();
		int uniqueId = this.GetUniqueId();
		if (!itemDataType)
		{
			instance.RemoveRedDotCommonItem(configId, uniqueId);
		}
		else
		{
			instance.RemoveRedDotAttributeItem(uniqueId);
		}
		this.SetHasRedDot(false);
	}

	// Token: 0x0600D533 RID: 54579 RVA: 0x003F5D17 File Offset: 0x003F3F17
	public bool IsBuffItem()
	{
		return BuffItemConfig.Instance.IsBuffItem(this.GetConfigId());
	}

	// Token: 0x0600D534 RID: 54580 RVA: 0x003F5D29 File Offset: 0x003F3F29
	public bool IsTeamBuffItem()
	{
		return BuffItemConfig.Instance.IsTeamBuffItem(this.GetConfigId());
	}

	// Token: 0x0600D535 RID: 54581 RVA: 0x003F5D3C File Offset: 0x003F3F3C
	public UiPlayItem GetUiPlayItem()
	{
		return ConfigUiPlayItemById.GetConfig(this.GetConfigId(), true).Value;
	}

	// Token: 0x0600D536 RID: 54582 RVA: 0x003F5D60 File Offset: 0x003F3F60
	public InventoryDefine.EItemType GetItemType()
	{
		return this.GetItemDataBase().GetType().Value;
	}

	// Token: 0x0600D537 RID: 54583 RVA: 0x003F5D80 File Offset: 0x003F3F80
	public int GetAttributeLevel()
	{
		InventoryDefine.EItemDataType itemDataType = this.GetItemDataType();
		int uniqueId = this.GetUniqueId();
		if (itemDataType == InventoryDefine.EItemDataType.PhantomItem)
		{
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
			if (phantomBattleData == null)
			{
				return 0;
			}
			return phantomBattleData.GetPhantomLevel();
		}
		else
		{
			if (itemDataType == InventoryDefine.EItemDataType.WeaponItem)
			{
				return WeaponModel.Instance.GetWeaponLevelById(uniqueId);
			}
			return 0;
		}
	}

	// Token: 0x0600D538 RID: 54584 RVA: 0x003F5DC8 File Offset: 0x003F3FC8
	public ItemViewDefine.EItemOperationMode GetItemOperationType()
	{
		return this.ItemViewInfo.ItemOperationMode;
	}

	// Token: 0x0600D539 RID: 54585 RVA: 0x003F5DD8 File Offset: 0x003F3FD8
	public bool IsItemCanDestroy()
	{
		switch (this.GetItemDataType())
		{
		case InventoryDefine.EItemDataType.CommonItem:
			return (this.GetItemDataBase() as CommonItemData).GetConfig().As<ItemInfo>().Value.Destructible;
		case InventoryDefine.EItemDataType.WeaponItem:
		{
			WeaponItemData weaponItemData = this.GetItemDataBase() as WeaponItemData;
			int uniqueId = weaponItemData.GetUniqueId();
			WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(uniqueId);
			bool isLock = weaponItemData.GetIsLock();
			bool flag = weaponDataByIncId != null && weaponDataByIncId.GetRoleId() != 0;
			bool destructible = weaponItemData.WeaponConfig.Destructible;
			bool flag2 = weaponDataByIncId != null && weaponDataByIncId.HasWeaponCultivated();
			return destructible && !isLock && !flag && !flag2;
		}
		case InventoryDefine.EItemDataType.PhantomItem:
		{
			PhantomItemData phantomItemData = this.GetItemDataBase() as PhantomItemData;
			int uniqueId2 = phantomItemData.GetUniqueId();
			bool isLock2 = phantomItemData.GetIsLock();
			int? equipRole = PhantomBattleController.Instance.GetEquipRole(uniqueId2);
			bool flag3;
			if (equipRole == null)
			{
				flag3 = false;
			}
			else
			{
				int? num = equipRole;
				int num2 = 0;
				flag3 = !(num.GetValueOrDefault() == num2 & num != null);
			}
			bool flag4 = flag3;
			return phantomItemData.GetConfig().As<PhantomItem>().Value.Destructible && !isLock2 && !flag4;
		}
		}
		return false;
	}

	// Token: 0x0600D53A RID: 54586 RVA: 0x003F5F18 File Offset: 0x003F4118
	public bool IsEqual(global::ItemViewData itemViewDataB, bool? needStackEqual = null)
	{
		bool flag = this.GetConfigId() == itemViewDataB.GetConfigId();
		bool flag2 = this.GetUniqueId() == itemViewDataB.GetUniqueId();
		bool flag3 = this.GetStackId() == itemViewDataB.GetStackId();
		if (needStackEqual != null && needStackEqual.Value)
		{
			return flag && flag2 && flag3;
		}
		return flag && flag2;
	}

	// Token: 0x040077A5 RID: 30629
	private InventoryDefine.IItemViewDataInfo ItemViewInfo;
}

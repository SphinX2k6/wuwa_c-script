using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using FilterDefine;

// Token: 0x02001FFC RID: 8188
[NullableContext(1)]
[Nullable(0)]
public class ItemViewData : IPhantomFilterData
{
	// Token: 0x060100B3 RID: 65715 RVA: 0x003E9534 File Offset: 0x003E7734
	public ItemViewData(InventoryDefine.IItemViewDataInfo itemViewInfo)
	{
		this.ItemViewInfo = itemViewInfo;
	}

	// Token: 0x060100B4 RID: 65716 RVA: 0x003E9543 File Offset: 0x003E7743
	public void SetItemViewInfo(InventoryDefine.IItemViewDataInfo itemViewInfo)
	{
		this.ItemViewInfo = itemViewInfo;
	}

	// Token: 0x060100B5 RID: 65717 RVA: 0x003E954C File Offset: 0x003E774C
	public InventoryDefine.IItemViewDataInfo GetItemViewInfo()
	{
		return this.ItemViewInfo;
	}

	// Token: 0x060100B6 RID: 65718 RVA: 0x003E9554 File Offset: 0x003E7754
	private void SetIsNew(bool isNew)
	{
		this.ItemViewInfo.IsNewItem = isNew;
	}

	// Token: 0x060100B7 RID: 65719 RVA: 0x003E9562 File Offset: 0x003E7762
	public void SetIsLock(bool bIsLock)
	{
		this.ItemViewInfo.IsLock = bIsLock;
	}

	// Token: 0x060100B8 RID: 65720 RVA: 0x003E9570 File Offset: 0x003E7770
	public void SetIsDeprecate(bool isDeprecate)
	{
		this.ItemViewInfo.IsDeprecate = isDeprecate;
	}

	// Token: 0x060100B9 RID: 65721 RVA: 0x003E957E File Offset: 0x003E777E
	public void SetHasRedDot(bool hasRedDot)
	{
		this.ItemViewInfo.HasRedDot = hasRedDot;
	}

	// Token: 0x060100BA RID: 65722 RVA: 0x003E958C File Offset: 0x003E778C
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

	// Token: 0x060100BB RID: 65723 RVA: 0x003E95B7 File Offset: 0x003E77B7
	public int GetConfigId()
	{
		return this.ItemViewInfo.ConfigId;
	}

	// Token: 0x060100BC RID: 65724 RVA: 0x003E95C4 File Offset: 0x003E77C4
	public int GetUniqueId()
	{
		ItemDataBase itemDataBase = this.GetItemDataBase();
		if (itemDataBase == null)
		{
			return 0;
		}
		return itemDataBase.GetUniqueId();
	}

	// Token: 0x060100BD RID: 65725 RVA: 0x003E95E4 File Offset: 0x003E77E4
	public int GetQuality()
	{
		ItemDataBase itemDataBase = this.GetItemDataBase();
		if (itemDataBase == null)
		{
			return 0;
		}
		return itemDataBase.GetQuality();
	}

	// Token: 0x060100BE RID: 65726 RVA: 0x003E9603 File Offset: 0x003E7803
	public void SetCount(int count)
	{
		this.ItemViewInfo.Count = count;
	}

	// Token: 0x060100BF RID: 65727 RVA: 0x003E9611 File Offset: 0x003E7811
	public int GetCount()
	{
		return this.ItemViewInfo.Count;
	}

	// Token: 0x060100C0 RID: 65728 RVA: 0x003E961E File Offset: 0x003E781E
	public void SetStackId(int stackId)
	{
		this.ItemViewInfo.StackId = stackId;
	}

	// Token: 0x060100C1 RID: 65729 RVA: 0x003E962C File Offset: 0x003E782C
	public int GetStackId()
	{
		return this.ItemViewInfo.StackId;
	}

	// Token: 0x060100C2 RID: 65730 RVA: 0x003E9639 File Offset: 0x003E7839
	public void SetSelectOn(bool isSelectOn)
	{
		this.ItemViewInfo.IsSelectOn = isSelectOn;
	}

	// Token: 0x060100C3 RID: 65731 RVA: 0x003E9647 File Offset: 0x003E7847
	public bool GetSelectOn()
	{
		return this.ItemViewInfo.IsSelectOn;
	}

	// Token: 0x060100C4 RID: 65732 RVA: 0x003E9654 File Offset: 0x003E7854
	public void SetSelectNum(int selectNum)
	{
		this.ItemViewInfo.SelectOnNum = selectNum;
	}

	// Token: 0x060100C5 RID: 65733 RVA: 0x003E9662 File Offset: 0x003E7862
	public int GetSelectNum()
	{
		return this.ItemViewInfo.SelectOnNum;
	}

	// Token: 0x060100C6 RID: 65734 RVA: 0x003E966F File Offset: 0x003E786F
	public ItemDataBase GetItemDataBase()
	{
		return this.ItemViewInfo.ItemDataBase;
	}

	// Token: 0x060100C7 RID: 65735 RVA: 0x003E967C File Offset: 0x003E787C
	public InventoryDefine.EItemDataType GetItemDataType()
	{
		return this.ItemViewInfo.ItemDataType;
	}

	// Token: 0x060100C8 RID: 65736 RVA: 0x003E9689 File Offset: 0x003E7889
	public int GetSortIndex()
	{
		return this.GetItemDataBase().GetSortIndex();
	}

	// Token: 0x060100C9 RID: 65737 RVA: 0x003E9698 File Offset: 0x003E7898
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

	// Token: 0x060100CA RID: 65738 RVA: 0x003E96DC File Offset: 0x003E78DC
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

	// Token: 0x060100CB RID: 65739 RVA: 0x003E971F File Offset: 0x003E791F
	public bool IsBuffItem()
	{
		return BuffItemConfig.Instance.IsBuffItem(this.GetConfigId());
	}

	// Token: 0x060100CC RID: 65740 RVA: 0x003E9731 File Offset: 0x003E7931
	public bool IsTeamBuffItem()
	{
		return BuffItemConfig.Instance.IsTeamBuffItem(this.GetConfigId());
	}

	// Token: 0x060100CD RID: 65741 RVA: 0x003E9744 File Offset: 0x003E7944
	public UiPlayItem GetUiPlayItem()
	{
		return ConfigUiPlayItemById.GetConfig(this.GetConfigId(), true).Value;
	}

	// Token: 0x060100CE RID: 65742 RVA: 0x003E9768 File Offset: 0x003E7968
	public InventoryDefine.EItemType GetItemType()
	{
		return this.GetItemDataBase().GetType().Value;
	}

	// Token: 0x060100CF RID: 65743 RVA: 0x003E9788 File Offset: 0x003E7988
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

	// Token: 0x060100D0 RID: 65744 RVA: 0x003E97D0 File Offset: 0x003E79D0
	public ItemViewDefine.EItemOperationMode GetItemOperationType()
	{
		return this.ItemViewInfo.ItemOperationMode;
	}

	// Token: 0x060100D1 RID: 65745 RVA: 0x003E97E0 File Offset: 0x003E79E0
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

	// Token: 0x060100D2 RID: 65746 RVA: 0x003E9920 File Offset: 0x003E7B20
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

	// Token: 0x040076BC RID: 30396
	private InventoryDefine.IItemViewDataInfo ItemViewInfo;
}

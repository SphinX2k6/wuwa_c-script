using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Inventory
{
	// Token: 0x0200480C RID: 18444
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemViewData
	{
		// Token: 0x0602E514 RID: 189716 RVA: 0x00CEC970 File Offset: 0x00CEAB70
		public ItemViewData(InventoryDefine.IItemViewDataInfo itemViewInfo)
		{
			this.ItemViewInfo = itemViewInfo;
		}

		// Token: 0x0602E515 RID: 189717 RVA: 0x00CEC97F File Offset: 0x00CEAB7F
		public void SetItemViewInfo(InventoryDefine.IItemViewDataInfo itemViewInfo)
		{
			this.ItemViewInfo = itemViewInfo;
		}

		// Token: 0x0602E516 RID: 189718 RVA: 0x00CEC988 File Offset: 0x00CEAB88
		public InventoryDefine.IItemViewDataInfo GetItemViewInfo()
		{
			return this.ItemViewInfo;
		}

		// Token: 0x0602E517 RID: 189719 RVA: 0x00CEC990 File Offset: 0x00CEAB90
		private void SetIsNew(bool isNew)
		{
			this.ItemViewInfo.IsNewItem = isNew;
		}

		// Token: 0x0602E518 RID: 189720 RVA: 0x00CEC99E File Offset: 0x00CEAB9E
		public void SetIsLock(bool bIsLock)
		{
			this.ItemViewInfo.IsLock = bIsLock;
		}

		// Token: 0x0602E519 RID: 189721 RVA: 0x00CEC9AC File Offset: 0x00CEABAC
		public void SetIsDeprecate(bool isDeprecate)
		{
			this.ItemViewInfo.IsDeprecate = isDeprecate;
		}

		// Token: 0x0602E51A RID: 189722 RVA: 0x00CEC9BA File Offset: 0x00CEABBA
		public void SetHasRedDot(bool hasRedDot)
		{
			this.ItemViewInfo.HasRedDot = hasRedDot;
		}

		// Token: 0x0602E51B RID: 189723 RVA: 0x00CEC9C8 File Offset: 0x00CEABC8
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

		// Token: 0x0602E51C RID: 189724 RVA: 0x00CEC9F3 File Offset: 0x00CEABF3
		public int GetConfigId()
		{
			return this.ItemViewInfo.ConfigId;
		}

		// Token: 0x0602E51D RID: 189725 RVA: 0x00CECA00 File Offset: 0x00CEAC00
		public int? GetUniqueId()
		{
			ItemDataBase itemDataBase = this.GetItemDataBase();
			if (itemDataBase == null)
			{
				return null;
			}
			return new int?(itemDataBase.GetUniqueId());
		}

		// Token: 0x0602E51E RID: 189726 RVA: 0x00CECA2B File Offset: 0x00CEAC2B
		public int GetQuality()
		{
			ItemDataBase itemDataBase = this.GetItemDataBase();
			if (itemDataBase == null)
			{
				return 0;
			}
			return itemDataBase.GetQuality();
		}

		// Token: 0x0602E51F RID: 189727 RVA: 0x00CECA3E File Offset: 0x00CEAC3E
		public void SetCount(int count)
		{
			this.ItemViewInfo.Count = count;
		}

		// Token: 0x0602E520 RID: 189728 RVA: 0x00CECA4C File Offset: 0x00CEAC4C
		public int GetCount()
		{
			return this.ItemViewInfo.Count;
		}

		// Token: 0x0602E521 RID: 189729 RVA: 0x00CECA59 File Offset: 0x00CEAC59
		public void SetStackId(int stackId)
		{
			this.ItemViewInfo.StackId = stackId;
		}

		// Token: 0x0602E522 RID: 189730 RVA: 0x00CECA67 File Offset: 0x00CEAC67
		public int GetStackId()
		{
			return this.ItemViewInfo.StackId;
		}

		// Token: 0x0602E523 RID: 189731 RVA: 0x00CECA74 File Offset: 0x00CEAC74
		public void SetSelectOn(bool isSelectOn)
		{
			this.ItemViewInfo.IsSelectOn = isSelectOn;
		}

		// Token: 0x0602E524 RID: 189732 RVA: 0x00CECA82 File Offset: 0x00CEAC82
		public bool GetSelectOn()
		{
			return this.ItemViewInfo.IsSelectOn;
		}

		// Token: 0x0602E525 RID: 189733 RVA: 0x00CECA8F File Offset: 0x00CEAC8F
		public void SetSelectNum(int selectNum)
		{
			this.ItemViewInfo.SelectOnNum = selectNum;
		}

		// Token: 0x0602E526 RID: 189734 RVA: 0x00CECA9D File Offset: 0x00CEAC9D
		public int GetSelectNum()
		{
			return this.ItemViewInfo.SelectOnNum;
		}

		// Token: 0x0602E527 RID: 189735 RVA: 0x00CECAAA File Offset: 0x00CEACAA
		[NullableContext(2)]
		public ItemDataBase GetItemDataBase()
		{
			return this.ItemViewInfo.ItemDataBase;
		}

		// Token: 0x0602E528 RID: 189736 RVA: 0x00CECAB7 File Offset: 0x00CEACB7
		public InventoryDefine.EItemDataType GetItemDataType()
		{
			return this.ItemViewInfo.ItemDataType;
		}

		// Token: 0x0602E529 RID: 189737 RVA: 0x00CECAC4 File Offset: 0x00CEACC4
		public int GetSortIndex()
		{
			ItemDataBase itemDataBase = this.GetItemDataBase();
			if (itemDataBase == null)
			{
				return 0;
			}
			return itemDataBase.GetSortIndex();
		}

		// Token: 0x0602E52A RID: 189738 RVA: 0x00CECAE4 File Offset: 0x00CEACE4
		public void RemoveNewItem()
		{
			InventoryModel instance = InventoryModel.Instance;
			bool itemDataType = this.GetItemDataType() != InventoryDefine.EItemDataType.CommonItem;
			int configId = this.GetConfigId();
			int? uniqueId = this.GetUniqueId();
			if (!itemDataType)
			{
				instance.RemoveNewCommonItem(configId, uniqueId.Value);
			}
			else
			{
				instance.RemoveNewAttributeItem(uniqueId.Value);
			}
			this.SetIsNew(false);
		}

		// Token: 0x0602E52B RID: 189739 RVA: 0x00CECB34 File Offset: 0x00CEAD34
		public void RemoveRedDotItem()
		{
			InventoryModel instance = InventoryModel.Instance;
			bool itemDataType = this.GetItemDataType() != InventoryDefine.EItemDataType.CommonItem;
			int configId = this.GetConfigId();
			int? uniqueId = this.GetUniqueId();
			if (!itemDataType)
			{
				instance.RemoveRedDotCommonItem(configId, uniqueId.Value);
			}
			else
			{
				instance.RemoveRedDotAttributeItem(uniqueId.Value);
			}
			this.SetHasRedDot(false);
		}

		// Token: 0x0602E52C RID: 189740 RVA: 0x00CECB83 File Offset: 0x00CEAD83
		public bool IsBuffItem()
		{
			return BuffItemConfig.Instance.IsBuffItem(this.GetConfigId());
		}

		// Token: 0x0602E52D RID: 189741 RVA: 0x00CECB95 File Offset: 0x00CEAD95
		public bool IsTeamBuffItem()
		{
			return BuffItemConfig.Instance.IsTeamBuffItem(this.GetConfigId());
		}

		// Token: 0x0602E52E RID: 189742 RVA: 0x00CECBA7 File Offset: 0x00CEADA7
		public UiPlayItem? GetUiPlayItem()
		{
			return ConfigUiPlayItemById.GetConfig(this.GetConfigId(), true);
		}

		// Token: 0x0602E52F RID: 189743 RVA: 0x00CECBB8 File Offset: 0x00CEADB8
		public InventoryDefine.EItemType? GetItemType()
		{
			ItemDataBase itemDataBase = this.GetItemDataBase();
			if (itemDataBase == null)
			{
				return null;
			}
			return itemDataBase.GetType();
		}

		// Token: 0x0602E530 RID: 189744 RVA: 0x00CECBE0 File Offset: 0x00CEADE0
		public int GetAttributeLevel()
		{
			InventoryDefine.EItemDataType itemDataType = this.GetItemDataType();
			int? uniqueId = this.GetUniqueId();
			if (itemDataType == InventoryDefine.EItemDataType.PhantomItem)
			{
				PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId.Value);
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
					return WeaponModel.Instance.GetWeaponLevelById(uniqueId.GetValueOrDefault());
				}
				return 0;
			}
		}

		// Token: 0x0602E531 RID: 189745 RVA: 0x00CECC34 File Offset: 0x00CEAE34
		public ItemViewDefine.EItemOperationMode GetItemOperationType()
		{
			return this.ItemViewInfo.ItemOperationMode;
		}

		// Token: 0x0602E532 RID: 189746 RVA: 0x00CECC44 File Offset: 0x00CEAE44
		public bool IsItemCanDestroy()
		{
			switch (this.GetItemDataType())
			{
			case InventoryDefine.EItemDataType.CommonItem:
			{
				CommonItemData commonItemData = this.GetItemDataBase() as CommonItemData;
				return commonItemData != null && commonItemData.GetConfig().As<ItemInfo>().Value.Destructible;
			}
			case InventoryDefine.EItemDataType.WeaponItem:
			{
				WeaponItemData weaponItemData = this.GetItemDataBase() as WeaponItemData;
				if (weaponItemData == null)
				{
					return false;
				}
				int uniqueId = weaponItemData.GetUniqueId();
				WeaponInstance weaponInstance = (uniqueId > 0) ? WeaponModel.Instance.GetWeaponDataByIncId(uniqueId) : null;
				bool isLock = weaponItemData.GetIsLock();
				bool flag = weaponInstance != null && weaponInstance.GetRoleId() != 0;
				bool destructible = weaponItemData.GetConfig().As<WeaponConf>().Value.Destructible;
				bool flag2 = weaponInstance != null && weaponInstance.HasWeaponCultivated();
				return destructible && !isLock && !flag && !flag2;
			}
			case InventoryDefine.EItemDataType.PhantomItem:
			{
				PhantomItemData phantomItemData = this.GetItemDataBase() as PhantomItemData;
				if (phantomItemData == null)
				{
					return false;
				}
				int uniqueId2 = phantomItemData.GetUniqueId();
				bool isLock2 = phantomItemData.GetIsLock();
				int? equipRole = PhantomBattleController.Instance.GetEquipRole(uniqueId2);
				bool flag3 = equipRole != null && equipRole.Value != 0;
				return phantomItemData.GetConfig().As<PhantomItem>().Value.Destructible && !isLock2 && !flag3;
			}
			}
			return false;
		}

		// Token: 0x0602E533 RID: 189747 RVA: 0x00CECDA8 File Offset: 0x00CEAFA8
		public bool IsEqual(ItemViewData itemViewDataB, bool? needStackEqual = null)
		{
			bool flag = this.GetConfigId() == itemViewDataB.GetConfigId();
			int? uniqueId = this.GetUniqueId();
			int? uniqueId2 = itemViewDataB.GetUniqueId();
			bool flag2 = uniqueId.GetValueOrDefault() == uniqueId2.GetValueOrDefault() & uniqueId != null == (uniqueId2 != null);
			bool flag3 = this.GetStackId() == itemViewDataB.GetStackId();
			if (needStackEqual.GetValueOrDefault())
			{
				return flag && flag2 && flag3;
			}
			return flag && flag2;
		}

		// Token: 0x04018AD7 RID: 101079
		private InventoryDefine.IItemViewDataInfo ItemViewInfo;
	}
}

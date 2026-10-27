using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Inventory
{
	// Token: 0x02005835 RID: 22581
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemViewData
	{
		// Token: 0x06039600 RID: 235008 RVA: 0x00D9DAB0 File Offset: 0x00D9BCB0
		public ItemViewData(InventoryDefine.IItemViewDataInfo itemViewInfo)
		{
			this.ItemViewInfo = itemViewInfo;
		}

		// Token: 0x06039601 RID: 235009 RVA: 0x00D9DABF File Offset: 0x00D9BCBF
		public void SetItemViewInfo(InventoryDefine.IItemViewDataInfo itemViewInfo)
		{
			this.ItemViewInfo = itemViewInfo;
		}

		// Token: 0x06039602 RID: 235010 RVA: 0x00D9DAC8 File Offset: 0x00D9BCC8
		public InventoryDefine.IItemViewDataInfo GetItemViewInfo()
		{
			return this.ItemViewInfo;
		}

		// Token: 0x06039603 RID: 235011 RVA: 0x00D9DAD0 File Offset: 0x00D9BCD0
		private void SetIsNew(bool isNew)
		{
			this.ItemViewInfo.IsNewItem = isNew;
		}

		// Token: 0x06039604 RID: 235012 RVA: 0x00D9DADE File Offset: 0x00D9BCDE
		public void SetIsLock(bool bIsLock)
		{
			this.ItemViewInfo.IsLock = bIsLock;
		}

		// Token: 0x06039605 RID: 235013 RVA: 0x00D9DAEC File Offset: 0x00D9BCEC
		public void SetIsDeprecate(bool isDeprecate)
		{
			this.ItemViewInfo.IsDeprecate = isDeprecate;
		}

		// Token: 0x06039606 RID: 235014 RVA: 0x00D9DAFA File Offset: 0x00D9BCFA
		public void SetHasRedDot(bool hasRedDot)
		{
			this.ItemViewInfo.HasRedDot = hasRedDot;
		}

		// Token: 0x06039607 RID: 235015 RVA: 0x00D9DB08 File Offset: 0x00D9BD08
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

		// Token: 0x06039608 RID: 235016 RVA: 0x00D9DB33 File Offset: 0x00D9BD33
		public int GetConfigId()
		{
			return this.ItemViewInfo.ConfigId;
		}

		// Token: 0x06039609 RID: 235017 RVA: 0x00D9DB40 File Offset: 0x00D9BD40
		public int? GetUniqueId()
		{
			ItemDataBase itemDataBase = this.GetItemDataBase();
			if (itemDataBase == null)
			{
				return null;
			}
			return new int?(itemDataBase.GetUniqueId());
		}

		// Token: 0x0603960A RID: 235018 RVA: 0x00D9DB6B File Offset: 0x00D9BD6B
		public int GetQuality()
		{
			ItemDataBase itemDataBase = this.GetItemDataBase();
			if (itemDataBase == null)
			{
				return 0;
			}
			return itemDataBase.GetQuality();
		}

		// Token: 0x0603960B RID: 235019 RVA: 0x00D9DB7E File Offset: 0x00D9BD7E
		public void SetCount(int count)
		{
			this.ItemViewInfo.Count = count;
		}

		// Token: 0x0603960C RID: 235020 RVA: 0x00D9DB8C File Offset: 0x00D9BD8C
		public int GetCount()
		{
			return this.ItemViewInfo.Count;
		}

		// Token: 0x0603960D RID: 235021 RVA: 0x00D9DB99 File Offset: 0x00D9BD99
		public void SetStackId(int stackId)
		{
			this.ItemViewInfo.StackId = stackId;
		}

		// Token: 0x0603960E RID: 235022 RVA: 0x00D9DBA7 File Offset: 0x00D9BDA7
		public int GetStackId()
		{
			return this.ItemViewInfo.StackId;
		}

		// Token: 0x0603960F RID: 235023 RVA: 0x00D9DBB4 File Offset: 0x00D9BDB4
		public void SetSelectOn(bool isSelectOn)
		{
			this.ItemViewInfo.IsSelectOn = isSelectOn;
		}

		// Token: 0x06039610 RID: 235024 RVA: 0x00D9DBC2 File Offset: 0x00D9BDC2
		public bool GetSelectOn()
		{
			return this.ItemViewInfo.IsSelectOn;
		}

		// Token: 0x06039611 RID: 235025 RVA: 0x00D9DBCF File Offset: 0x00D9BDCF
		public void SetSelectNum(int selectNum)
		{
			this.ItemViewInfo.SelectOnNum = selectNum;
		}

		// Token: 0x06039612 RID: 235026 RVA: 0x00D9DBDD File Offset: 0x00D9BDDD
		public int GetSelectNum()
		{
			return this.ItemViewInfo.SelectOnNum;
		}

		// Token: 0x06039613 RID: 235027 RVA: 0x00D9DBEA File Offset: 0x00D9BDEA
		[NullableContext(2)]
		public ItemDataBase GetItemDataBase()
		{
			return this.ItemViewInfo.ItemDataBase;
		}

		// Token: 0x06039614 RID: 235028 RVA: 0x00D9DBF7 File Offset: 0x00D9BDF7
		public InventoryDefine.EItemDataType GetItemDataType()
		{
			return this.ItemViewInfo.ItemDataType;
		}

		// Token: 0x06039615 RID: 235029 RVA: 0x00D9DC04 File Offset: 0x00D9BE04
		public int GetSortIndex()
		{
			ItemDataBase itemDataBase = this.GetItemDataBase();
			if (itemDataBase == null)
			{
				return 0;
			}
			return itemDataBase.GetSortIndex();
		}

		// Token: 0x06039616 RID: 235030 RVA: 0x00D9DC24 File Offset: 0x00D9BE24
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

		// Token: 0x06039617 RID: 235031 RVA: 0x00D9DC74 File Offset: 0x00D9BE74
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

		// Token: 0x06039618 RID: 235032 RVA: 0x00D9DCC3 File Offset: 0x00D9BEC3
		public bool IsBuffItem()
		{
			return BuffItemConfig.Instance.IsBuffItem(this.GetConfigId());
		}

		// Token: 0x06039619 RID: 235033 RVA: 0x00D9DCD5 File Offset: 0x00D9BED5
		public bool IsTeamBuffItem()
		{
			return BuffItemConfig.Instance.IsTeamBuffItem(this.GetConfigId());
		}

		// Token: 0x0603961A RID: 235034 RVA: 0x00D9DCE7 File Offset: 0x00D9BEE7
		public UiPlayItem? GetUiPlayItem()
		{
			return ConfigUiPlayItemById.GetConfig(this.GetConfigId(), true);
		}

		// Token: 0x0603961B RID: 235035 RVA: 0x00D9DCF8 File Offset: 0x00D9BEF8
		public InventoryDefine.EItemType? GetItemType()
		{
			ItemDataBase itemDataBase = this.GetItemDataBase();
			if (itemDataBase == null)
			{
				return null;
			}
			return itemDataBase.GetType();
		}

		// Token: 0x0603961C RID: 235036 RVA: 0x00D9DD20 File Offset: 0x00D9BF20
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

		// Token: 0x0603961D RID: 235037 RVA: 0x00D9DD74 File Offset: 0x00D9BF74
		public ItemViewDefine.EItemOperationMode GetItemOperationType()
		{
			return this.ItemViewInfo.ItemOperationMode;
		}

		// Token: 0x0603961E RID: 235038 RVA: 0x00D9DD84 File Offset: 0x00D9BF84
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

		// Token: 0x0603961F RID: 235039 RVA: 0x00D9DEE8 File Offset: 0x00D9C0E8
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

		// Token: 0x0401E03E RID: 122942
		private InventoryDefine.IItemViewDataInfo ItemViewInfo;
	}
}

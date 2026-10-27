using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Roverlike;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PermanentRogue;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.PhantomArena;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using FilterDefine;

// Token: 0x02001FB1 RID: 8113
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class InventoryModel : ModelBase
{
	// Token: 0x17001357 RID: 4951
	// (get) Token: 0x0600FCC7 RID: 64711 RVA: 0x003D62E4 File Offset: 0x003D44E4
	private NormalInventoryDataProxy DefaultProxy
	{
		get
		{
			NormalInventoryDataProxy result;
			if ((result = this._DefaultProxy) == null)
			{
				result = (this._DefaultProxy = new NormalInventoryDataProxy(this));
			}
			return result;
		}
	}

	// Token: 0x17001358 RID: 4952
	// (get) Token: 0x0600FCC8 RID: 64712 RVA: 0x003D630A File Offset: 0x003D450A
	// (set) Token: 0x0600FCC9 RID: 64713 RVA: 0x003D631C File Offset: 0x003D451C
	private InventoryDataProxy CurrentProxy
	{
		get
		{
			return this._CurrentProxy ?? this.DefaultProxy;
		}
		set
		{
			this._CurrentProxy = value;
		}
	}

	// Token: 0x0600FCCA RID: 64714 RVA: 0x003D6325 File Offset: 0x003D4525
	public void SetItemNeedCount(int? itemNeedCount)
	{
		this.ItemNeedCount = itemNeedCount;
	}

	// Token: 0x0600FCCB RID: 64715 RVA: 0x003D632E File Offset: 0x003D452E
	public int? GetItemNeedCount()
	{
		return this.ItemNeedCount;
	}

	// Token: 0x0600FCCC RID: 64716 RVA: 0x003D6336 File Offset: 0x003D4536
	protected override bool OnInit()
	{
		if (InventoryConfig.Instance.GetAllMainTypeConfig().Count <= 0)
		{
			return false;
		}
		this.SetSelectedTypeIndex(0);
		return true;
	}

	// Token: 0x0600FCCD RID: 64717 RVA: 0x003D6354 File Offset: 0x003D4554
	protected override bool OnClear()
	{
		this.ClearAllItemData();
		foreach (TimerHandle handle in this.CdTimeStampHandleMap.Values)
		{
			TimerSystem.RealTimeInstance.Remove(handle);
		}
		this.CdTimeStampHandleMap.Clear();
		return true;
	}

	// Token: 0x0600FCCE RID: 64718 RVA: 0x003D63C4 File Offset: 0x003D45C4
	public void RefreshItemRedDotSet()
	{
		NewFlagModel instance = NewFlagModel.Instance;
		HashSet<int> newFlagSet = instance.GetNewFlagSet(ELocalStoragePlayerKey.InventoryCommonItemRedDot);
		if (newFlagSet != null && newFlagSet.Count > 0)
		{
			bool flag = false;
			foreach (int num in newFlagSet)
			{
				bool flag2 = false;
				if (this.GetCommonItemCount(num, 0) <= 0)
				{
					flag2 = true;
				}
				else
				{
					CommonItemData commonItemData = this.GetCommonItemData(num, 0);
					if (commonItemData != null)
					{
						InventoryDefine.ERedDotDisableRule redDotDisableRule = commonItemData.GetRedDotDisableRule();
						if (redDotDisableRule == InventoryDefine.ERedDotDisableRule.ServerFirstSelect || redDotDisableRule == InventoryDefine.ERedDotDisableRule.None)
						{
							flag2 = true;
						}
					}
				}
				if (flag2)
				{
					instance.RemoveNewFlag(ELocalStoragePlayerKey.InventoryCommonItemRedDot, num);
					flag = true;
				}
			}
			if (flag)
			{
				this.SaveRedDotCommonItemConfigIdList();
			}
		}
		ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ItemBackpackFirstCheck) as ServerStorageMap;
		if (serverStorageMap != null)
		{
			foreach (KeyValuePair<int, int> keyValuePair in serverStorageMap.GetContainer())
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				bool flag3 = false;
				CommonItemData commonItemData2 = this.GetCommonItemData(key, 0);
				if (value == 1 && this.GetCommonItemCount(key, 0) <= 0)
				{
					flag3 = true;
				}
				if (commonItemData2 != null && commonItemData2.GetRedDotDisableRule() != InventoryDefine.ERedDotDisableRule.ServerFirstSelect)
				{
					flag3 = true;
				}
				if (flag3)
				{
					serverStorageMap.Delete(key);
				}
			}
		}
		HashSet<int> newFlagSet2 = instance.GetNewFlagSet(ELocalStoragePlayerKey.InventoryAttributeItemRedDot);
		if (newFlagSet2 != null)
		{
			bool flag4 = false;
			foreach (int num2 in newFlagSet2)
			{
				AttributeItemData attributeItemData = this.GetAttributeItemData(num2);
				if (attributeItemData == null)
				{
					instance.RemoveNewFlag(ELocalStoragePlayerKey.InventoryAttributeItemRedDot, num2);
					flag4 = true;
				}
				else if (attributeItemData != null && attributeItemData.GetCount() <= 0)
				{
					instance.RemoveNewFlag(ELocalStoragePlayerKey.InventoryAttributeItemRedDot, num2);
					flag4 = true;
				}
			}
			if (flag4)
			{
				this.SaveRedDotAttributeItemUniqueIdList();
			}
		}
	}

	// Token: 0x0600FCCF RID: 64719 RVA: 0x003D65AC File Offset: 0x003D47AC
	public void SetInventoryTabOpenIdList(List<int> idList)
	{
		this.InventoryTabOpenIdList = idList;
	}

	// Token: 0x0600FCD0 RID: 64720 RVA: 0x003D65B5 File Offset: 0x003D47B5
	public List<ItemMainType> GetOpenIdMainTypeConfig()
	{
		return this.CurrentProxy.GetOpenIdMainTypeConfig();
	}

	// Token: 0x0600FCD1 RID: 64721 RVA: 0x003D65C4 File Offset: 0x003D47C4
	public List<ItemMainType> GetOpenIdMainTypeConfigBase()
	{
		List<ItemMainType> list = new List<ItemMainType>();
		foreach (int itemTypeId in this.InventoryTabOpenIdList)
		{
			ItemMainType? itemMainTypeConfig = InventoryConfig.Instance.GetItemMainTypeConfig(itemTypeId);
			if (itemMainTypeConfig != null && itemMainTypeConfig.Value.BShowInInventoryView)
			{
				list.Add(itemMainTypeConfig.Value);
			}
		}
		list.Sort((ItemMainType a, ItemMainType b) => a.SequenceId - b.SequenceId);
		return list;
	}

	// Token: 0x0600FCD2 RID: 64722 RVA: 0x003D6670 File Offset: 0x003D4870
	public InventoryDefine.EItemMainTypeId? GetCurrentMainTypeId()
	{
		List<ItemMainType> openIdMainTypeConfig = this.GetOpenIdMainTypeConfig();
		if (openIdMainTypeConfig.Count <= 0)
		{
			return null;
		}
		int selectedTypeIndex = this.GetSelectedTypeIndex();
		if (selectedTypeIndex < 0 || selectedTypeIndex >= openIdMainTypeConfig.Count)
		{
			return null;
		}
		return new InventoryDefine.EItemMainTypeId?((InventoryDefine.EItemMainTypeId)openIdMainTypeConfig[selectedTypeIndex].Id);
	}

	// Token: 0x0600FCD3 RID: 64723 RVA: 0x003D66CC File Offset: 0x003D48CC
	public bool IsResourceOrMaterialTab()
	{
		InventoryDefine.EItemMainTypeId? currentMainTypeId = this.GetCurrentMainTypeId();
		return currentMainTypeId.GetValueOrDefault() == InventoryDefine.EItemMainTypeId.Material || currentMainTypeId.GetValueOrDefault() == InventoryDefine.EItemMainTypeId.Collection;
	}

	// Token: 0x0600FCD4 RID: 64724 RVA: 0x003D66F8 File Offset: 0x003D48F8
	private void AddToItemTypeMap(ItemDataBase itemDataBase)
	{
		InventoryDefine.EItemType? type = itemDataBase.GetType();
		HashSet<ItemDataBase> hashSet;
		if (!this.ItemTypeMap.TryGetValue(type.Value, out hashSet))
		{
			hashSet = new HashSet<ItemDataBase>();
			this.ItemTypeMap.Add(type.Value, hashSet);
		}
		hashSet.Add(itemDataBase);
	}

	// Token: 0x0600FCD5 RID: 64725 RVA: 0x003D6744 File Offset: 0x003D4944
	private void RemoveFromItemTypeMap(ItemDataBase itemDataBase)
	{
		InventoryDefine.EItemType? type = itemDataBase.GetType();
		HashSet<ItemDataBase> hashSet;
		if (this.ItemTypeMap.TryGetValue(type.Value, out hashSet))
		{
			hashSet.Remove(itemDataBase);
		}
	}

	// Token: 0x0600FCD6 RID: 64726 RVA: 0x003D6776 File Offset: 0x003D4976
	private void ClearFromItemTypeMap(InventoryDefine.EItemType itemType)
	{
		this.ItemTypeMap.Remove(itemType);
	}

	// Token: 0x0600FCD7 RID: 64727 RVA: 0x003D6788 File Offset: 0x003D4988
	private void AddToItemMainTypeMap(ItemDataBase itemDataBase)
	{
		InventoryDefine.EItemMainTypeId? mainType = itemDataBase.GetMainType();
		global::ItemMainTypeMapping itemMainTypeMapping;
		if (!this.ItemMainTypeMap.TryGetValue(mainType.Value, out itemMainTypeMapping))
		{
			itemMainTypeMapping = new global::ItemMainTypeMapping(mainType.Value);
			this.ItemMainTypeMap.Add(mainType.Value, itemMainTypeMapping);
		}
		itemMainTypeMapping.Add(itemDataBase);
	}

	// Token: 0x0600FCD8 RID: 64728 RVA: 0x003D67DC File Offset: 0x003D49DC
	private void RemoveFromItemMainTypeMap(ItemDataBase itemDataBase)
	{
		InventoryDefine.EItemMainTypeId? mainType = itemDataBase.GetMainType();
		global::ItemMainTypeMapping itemMainTypeMapping;
		if (this.ItemMainTypeMap.TryGetValue(mainType.Value, out itemMainTypeMapping))
		{
			itemMainTypeMapping.Remove(itemDataBase);
		}
	}

	// Token: 0x0600FCD9 RID: 64729 RVA: 0x003D680D File Offset: 0x003D4A0D
	private void ClearFromItemMainTypeMap(InventoryDefine.EItemMainTypeId itemMainType)
	{
		this.ItemMainTypeMap.Remove(itemMainType);
	}

	// Token: 0x0600FCDA RID: 64730 RVA: 0x003D681C File Offset: 0x003D4A1C
	private void AddToCommonItemByItemTypeMap(CommonItemData commonItemData)
	{
		InventoryDefine.EItemType? type = commonItemData.GetType();
		HashSet<CommonItemData> hashSet;
		if (!this.CommonItemByItemTypeMap.TryGetValue(type.Value, out hashSet))
		{
			hashSet = new HashSet<CommonItemData>();
			this.CommonItemByItemTypeMap[type.Value] = hashSet;
		}
		hashSet.Add(commonItemData);
	}

	// Token: 0x0600FCDB RID: 64731 RVA: 0x003D6868 File Offset: 0x003D4A68
	private void RemoveFromCommonItemByItemTypeMap(CommonItemData commonItemData)
	{
		InventoryDefine.EItemType? type = commonItemData.GetType();
		HashSet<CommonItemData> hashSet;
		if (!this.CommonItemByItemTypeMap.TryGetValue(type.Value, out hashSet))
		{
			return;
		}
		hashSet.Remove(commonItemData);
	}

	// Token: 0x0600FCDC RID: 64732 RVA: 0x003D689B File Offset: 0x003D4A9B
	private void ClearFromCommonItemByItemTypeMap(InventoryDefine.EItemType itemType)
	{
		this.CommonItemByItemTypeMap.Remove(itemType);
	}

	// Token: 0x0600FCDD RID: 64733 RVA: 0x003D68AC File Offset: 0x003D4AAC
	public void NewCommonItemData(int configId, int count, int uniqueId = 0, long? endTime = null)
	{
		CommonItemData commonItemData = new CommonItemData(configId, uniqueId, count, InventoryDefine.EItemDataType.CommonItem, endTime);
		Dictionary<int, CommonItemData> dictionary;
		if (!this.CommonItemMap.TryGetValue(configId, out dictionary))
		{
			dictionary = new Dictionary<int, CommonItemData>();
		}
		CommonItemData commonItemData2;
		if (dictionary.TryGetValue(uniqueId, out commonItemData2))
		{
			return;
		}
		dictionary.TryAdd(uniqueId, commonItemData);
		this.CommonItemMap.TryAdd(configId, dictionary);
		this.AddToCommonItemByItemTypeMap(commonItemData);
		this.AddToItemTypeMap(commonItemData);
		this.AddToItemMainTypeMap(commonItemData);
		this.TryAddItemCoolDownTimer(commonItemData);
	}

	// Token: 0x0600FCDE RID: 64734 RVA: 0x003D691C File Offset: 0x003D4B1C
	public void RemoveCommonItemData(int configId, int uniqueId = 0)
	{
		Dictionary<int, CommonItemData> dictionary;
		if (!this.CommonItemMap.TryGetValue(configId, out dictionary))
		{
			return;
		}
		CommonItemData commonItemData;
		if (!dictionary.TryGetValue(uniqueId, out commonItemData))
		{
			return;
		}
		dictionary.Remove(uniqueId);
		if (dictionary.Count == 0)
		{
			this.CommonItemMap.Remove(configId);
		}
		this.RemoveFromItemTypeMap(commonItemData);
		this.RemoveFromItemMainTypeMap(commonItemData);
		this.RemoveFromCommonItemByItemTypeMap(commonItemData);
	}

	// Token: 0x0600FCDF RID: 64735 RVA: 0x003D6978 File Offset: 0x003D4B78
	public void RemoveCommonItemDataAndSaveNewList(List<InventoryDefine.IGetItemData> commonItemList)
	{
		foreach (InventoryDefine.IGetItemData getItemData in commonItemList)
		{
			this.RemoveCommonItemData(getItemData.ItemId, getItemData.IncId);
			this.RemoveNewCommonItem(getItemData.ItemId, getItemData.IncId);
			this.RemoveRedDotCommonItem(getItemData.ItemId, getItemData.IncId);
		}
		this.SaveNewCommonItemConfigIdList();
		this.SaveNewAttributeItemUniqueIdList();
		this.SaveRedDotCommonItemConfigIdList();
		this.SaveRedDotAttributeItemUniqueIdList();
	}

	// Token: 0x0600FCE0 RID: 64736 RVA: 0x003D6A14 File Offset: 0x003D4C14
	private void TryAddItemCoolDownTimer(CommonItemData itemData)
	{
		if (itemData.GetEndTime() > 0L)
		{
			if (itemData.IsOverTime())
			{
				InventoryController.Instance.InvalidItemRemoveRequest();
				return;
			}
			long endTime = itemData.GetEndTime() + 20L;
			if (this.CdTimeStampSet.Contains(endTime))
			{
				return;
			}
			string reason = StringUtils.Format(this.CD_TIME_REASON, new string[]
			{
				itemData.GetConfigId().ToString(),
				itemData.GetUniqueId().ToString()
			});
			TimerHandle timerHandle = TimerSystem.RealTimeInstance.EmitOnTime(delegate(float time)
			{
				this.CdTimeStampCheck(endTime);
			}, (double)endTime, null, reason, true, 1f);
			if (timerHandle == null)
			{
				return;
			}
			this.CdTimeStampSet.Add(endTime);
			this.CdTimeStampHandleMap[endTime] = timerHandle;
		}
	}

	// Token: 0x0600FCE1 RID: 64737 RVA: 0x003D6AF4 File Offset: 0x003D4CF4
	private void CdTimeStampCheck(long endTime)
	{
		InventoryController.Instance.InvalidItemRemoveRequest();
		TimerHandle handle;
		if (this.CdTimeStampHandleMap.TryGetValue(endTime, out handle))
		{
			TimerSystem.RealTimeInstance.Remove(handle);
			this.CdTimeStampHandleMap.Remove(endTime);
		}
		this.CdTimeStampSet.Remove(endTime);
	}

	// Token: 0x0600FCE2 RID: 64738 RVA: 0x003D6B44 File Offset: 0x003D4D44
	[NullableContext(2)]
	public CommonItemData GetCommonItemData(int configId, int uniqueId = 0)
	{
		Dictionary<int, CommonItemData> dictionary;
		if (!this.CommonItemMap.TryGetValue(configId, out dictionary))
		{
			return null;
		}
		CommonItemData commonItemData;
		if (!dictionary.TryGetValue(uniqueId, out commonItemData))
		{
			return null;
		}
		if (!commonItemData.IsValid())
		{
			return null;
		}
		return commonItemData;
	}

	// Token: 0x0600FCE3 RID: 64739 RVA: 0x003D6B7C File Offset: 0x003D4D7C
	public List<CommonItemData> GetAllCommonItemDataByConfigId(int configId)
	{
		List<CommonItemData> list = new List<CommonItemData>();
		Dictionary<int, CommonItemData> dictionary;
		if (!this.CommonItemMap.TryGetValue(configId, out dictionary))
		{
			return list;
		}
		foreach (CommonItemData commonItemData in new List<CommonItemData>(dictionary.Values))
		{
			if (commonItemData.IsValid())
			{
				list.Add(commonItemData);
			}
		}
		return list;
	}

	// Token: 0x0600FCE4 RID: 64740 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	public List<ItemDataBase> GetItemDataBaseByConfigId(int configId)
	{
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(configId));
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.WeaponItem)
		{
			return this.GetAllWeaponItemDataByConfigId(configId).Cast<ItemDataBase>().ToList<ItemDataBase>();
		}
		if (itemDataTypeByConfigId != InventoryDefine.EItemDataType.PhantomItem)
		{
			return this.GetAllCommonItemDataByConfigId(configId).Cast<ItemDataBase>().ToList<ItemDataBase>();
		}
		return this.GetAllPhantomItemDataByConfigId(configId).Cast<ItemDataBase>().ToList<ItemDataBase>();
	}

	// Token: 0x0600FCE5 RID: 64741 RVA: 0x003D6C58 File Offset: 0x003D4E58
	public List<PhantomItemData> GetAllPhantomItemDataByConfigId(int configId)
	{
		List<PhantomItemData> list = new List<PhantomItemData>();
		foreach (PhantomItemData phantomItemData in this.GetAllPhantomItemDataIterator())
		{
			if (phantomItemData.GetConfigId() == configId)
			{
				list.Add(phantomItemData);
			}
		}
		return list;
	}

	// Token: 0x0600FCE6 RID: 64742 RVA: 0x003D6CBC File Offset: 0x003D4EBC
	public List<WeaponItemData> GetAllWeaponItemDataByConfigId(int configId)
	{
		List<WeaponItemData> list = new List<WeaponItemData>();
		foreach (WeaponItemData weaponItemData in this.GetWeaponItemDataList())
		{
			if (weaponItemData.GetConfigId() == configId)
			{
				list.Add(weaponItemData);
			}
		}
		return list;
	}

	// Token: 0x0600FCE7 RID: 64743 RVA: 0x003D6D20 File Offset: 0x003D4F20
	public List<WeaponItemData> GetAllWeaponItemDataByQualityAndType(int quality, int weaponType)
	{
		List<WeaponItemData> list = new List<WeaponItemData>();
		foreach (WeaponItemData weaponItemData in this.GetWeaponItemDataList())
		{
			if ((quality == 0 || weaponItemData.GetQuality() == quality) && (weaponType == 0 || weaponItemData.WeaponConfig.WeaponType == weaponType))
			{
				list.Add(weaponItemData);
			}
		}
		return list;
	}

	// Token: 0x0600FCE8 RID: 64744 RVA: 0x003D6D9C File Offset: 0x003D4F9C
	public int GetCommonItemCount(int configId, int uniqueId = 0)
	{
		return this.CurrentProxy.GetCommonItemCount(configId, uniqueId);
	}

	// Token: 0x0600FCE9 RID: 64745 RVA: 0x003D6DAC File Offset: 0x003D4FAC
	public int GetCommonItemCountBase(int configId, int uniqueId = 0)
	{
		CommonItemData commonItemData = this.GetCommonItemData(configId, uniqueId);
		if (commonItemData == null)
		{
			return 0;
		}
		return commonItemData.GetCount();
	}

	// Token: 0x0600FCEA RID: 64746 RVA: 0x003D6DD0 File Offset: 0x003D4FD0
	public void NewWeaponItemData(int configId, int uniqueId, int functionValue)
	{
		if (this.WeaponItemMap.ContainsKey(uniqueId))
		{
			return;
		}
		WeaponItemData weaponItemData = new WeaponItemData(configId, uniqueId, functionValue, InventoryDefine.EItemDataType.WeaponItem);
		this.WeaponItemMap.TryAdd(uniqueId, weaponItemData);
		this.AddToItemTypeMap(weaponItemData);
		this.AddToItemMainTypeMap(weaponItemData);
	}

	// Token: 0x0600FCEB RID: 64747 RVA: 0x003D6E14 File Offset: 0x003D5014
	public void RemoveWeaponItemData(int uniqueId)
	{
		WeaponItemData itemDataBase;
		if (!this.WeaponItemMap.TryGetValue(uniqueId, out itemDataBase))
		{
			return;
		}
		this.WeaponItemMap.Remove(uniqueId);
		this.RemoveFromItemTypeMap(itemDataBase);
		this.RemoveFromItemMainTypeMap(itemDataBase);
	}

	// Token: 0x0600FCEC RID: 64748 RVA: 0x003D6E50 File Offset: 0x003D5050
	public void RemoveWeaponItemDataAndSaveNewList(IReadOnlyList<int> weaponUniqueIdList)
	{
		foreach (int uniqueId in weaponUniqueIdList)
		{
			this.RemoveWeaponItemData(uniqueId);
			this.RemoveNewAttributeItem(uniqueId);
			this.RemoveRedDotAttributeItem(uniqueId);
		}
		this.SaveNewAttributeItemUniqueIdList();
		this.SaveRedDotAttributeItemUniqueIdList();
	}

	// Token: 0x0600FCED RID: 64749 RVA: 0x003D6EB8 File Offset: 0x003D50B8
	[NullableContext(2)]
	public WeaponItemData GetWeaponItemData(int uniqueId)
	{
		WeaponItemData result;
		this.WeaponItemMap.TryGetValue(uniqueId, out result);
		return result;
	}

	// Token: 0x0600FCEE RID: 64750 RVA: 0x003D6ED8 File Offset: 0x003D50D8
	public void NewPhantomItemData(int configId, int uniqueId, int functionValue, int stackCount = 0, long addTime = 0L)
	{
		if (this.PhantomItemMap.ContainsKey(uniqueId))
		{
			return;
		}
		PhantomItemData phantomItemData = new PhantomItemData(configId, uniqueId, functionValue, InventoryDefine.EItemDataType.PhantomItem);
		if (stackCount > 0)
		{
			phantomItemData.SetStackCount(stackCount);
		}
		if (addTime > 0L)
		{
			phantomItemData.SetAddTime(addTime);
		}
		this.PhantomItemMap[uniqueId] = phantomItemData;
		this.AddToItemTypeMap(phantomItemData);
		this.AddToItemMainTypeMap(phantomItemData);
	}

	// Token: 0x0600FCEF RID: 64751 RVA: 0x003D6F34 File Offset: 0x003D5134
	public void UpdatePhantomItemData(Aki.Protocol.PhantomItem phantomItemInfo, string reason = "")
	{
		int id = phantomItemInfo.Id;
		int incrId = phantomItemInfo.IncrId;
		int funcValue = phantomItemInfo.FuncValue;
		int stackCount = phantomItemInfo.StackCount;
		long addTime = phantomItemInfo.AddTime;
		if (PhantomStackUtil.IsUpdateInfoRemoved(phantomItemInfo))
		{
			string reason2 = string.IsNullOrEmpty(reason) ? "UpdateWithZeroStackCount" : ("UpdateWithZeroStackCount:" + reason);
			this.RemovePhantomItemDataAndNotify(new int[]
			{
				incrId
			}, reason2);
			return;
		}
		PhantomItemData phantomItemData;
		if (this.PhantomItemMap.TryGetValue(incrId, out phantomItemData) && phantomItemData.GetConfigId() == id)
		{
			phantomItemData.GetStackCount();
			phantomItemData.SetFunctionValue(funcValue);
			phantomItemData.SetStackCount(stackCount);
			if (addTime > 0L)
			{
				phantomItemData.SetAddTime(addTime);
			}
			return;
		}
		this.RemovePhantomItemData(incrId);
		this.NewPhantomItemData(id, incrId, funcValue, stackCount, addTime);
	}

	// Token: 0x0600FCF0 RID: 64752 RVA: 0x003D6FF4 File Offset: 0x003D51F4
	public void RemovePhantomItemData(int uniqueId)
	{
		PhantomItemData itemDataBase;
		if (!this.PhantomItemMap.TryGetValue(uniqueId, out itemDataBase))
		{
			return;
		}
		this.PhantomItemMap.Remove(uniqueId);
		this.RemoveFromItemTypeMap(itemDataBase);
		this.RemoveFromItemMainTypeMap(itemDataBase);
	}

	// Token: 0x0600FCF1 RID: 64753 RVA: 0x003D7030 File Offset: 0x003D5230
	public void RemovePhantomItemDataAndSaveNewList(IReadOnlyList<int> phantomUniqueIdList)
	{
		foreach (int uniqueId in phantomUniqueIdList)
		{
			this.RemovePhantomItemData(uniqueId);
			this.RemoveNewAttributeItem(uniqueId);
			this.RemoveRedDotAttributeItem(uniqueId);
		}
		this.SaveNewAttributeItemUniqueIdList();
		this.SaveRedDotAttributeItemUniqueIdList();
	}

	// Token: 0x0600FCF2 RID: 64754 RVA: 0x003D7098 File Offset: 0x003D5298
	public void RemovePhantomItemDataAndNotify(IReadOnlyList<int> phantomUniqueIdList, string reason = "")
	{
		this.RemovePhantomItemDataAndSaveNewList(phantomUniqueIdList);
		EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.OnRemovePhantomItem, phantomUniqueIdList);
	}

	// Token: 0x0600FCF3 RID: 64755 RVA: 0x003D70B4 File Offset: 0x003D52B4
	[NullableContext(2)]
	public PhantomItemData GetPhantomItemData(int uniqueId)
	{
		PhantomItemData result;
		this.PhantomItemMap.TryGetValue(uniqueId, out result);
		return result;
	}

	// Token: 0x0600FCF4 RID: 64756 RVA: 0x003D70D4 File Offset: 0x003D52D4
	public void NewCalabashSkinItemData(int configId)
	{
		if (this.CalabashSkinItemMap.ContainsKey(configId))
		{
			return;
		}
		CalabashSkinItemData calabashSkinItemData = new CalabashSkinItemData(configId, 1, InventoryDefine.EItemDataType.CalabashSkinItem);
		this.CalabashSkinItemMap[configId] = calabashSkinItemData;
		this.AddToItemTypeMap(calabashSkinItemData);
		this.AddToItemMainTypeMap(calabashSkinItemData);
	}

	// Token: 0x0600FCF5 RID: 64757 RVA: 0x003D7118 File Offset: 0x003D5318
	public void NewOrnamentItemData(int configId)
	{
		if (this.OrnamentItemMap.ContainsKey(configId))
		{
			return;
		}
		OrnamentItemData ornamentItemData = new OrnamentItemData(configId, 1, InventoryDefine.EItemDataType.OrnamentItem);
		this.OrnamentItemMap[configId] = ornamentItemData;
		this.AddToItemTypeMap(ornamentItemData);
		this.AddToItemMainTypeMap(ornamentItemData);
	}

	// Token: 0x0600FCF6 RID: 64758 RVA: 0x003D715C File Offset: 0x003D535C
	public void ClearCommonItemData()
	{
		foreach (Dictionary<int, CommonItemData> dictionary in this.CommonItemMap.Values)
		{
			foreach (CommonItemData commonItemData in dictionary.Values)
			{
				InventoryDefine.EItemMainTypeId? mainType = commonItemData.GetMainType();
				InventoryDefine.EItemType? type = commonItemData.GetType();
				this.ClearFromItemMainTypeMap(mainType.Value);
				this.ClearFromItemTypeMap(type.Value);
				this.ClearFromCommonItemByItemTypeMap(type.Value);
			}
		}
		this.CommonItemMap.Clear();
	}

	// Token: 0x0600FCF7 RID: 64759 RVA: 0x003D7224 File Offset: 0x003D5424
	public void ClearWeaponItemData()
	{
		foreach (WeaponItemData weaponItemData in this.WeaponItemMap.Values)
		{
			InventoryDefine.EItemMainTypeId? mainType = weaponItemData.GetMainType();
			InventoryDefine.EItemType? type = weaponItemData.GetType();
			this.ClearFromItemMainTypeMap(mainType.Value);
			this.ClearFromItemTypeMap(type.Value);
		}
		this.WeaponItemMap.Clear();
	}

	// Token: 0x0600FCF8 RID: 64760 RVA: 0x003D72A8 File Offset: 0x003D54A8
	public void ClearPhantomItemData()
	{
		foreach (PhantomItemData phantomItemData in this.PhantomItemMap.Values)
		{
			InventoryDefine.EItemMainTypeId? mainType = phantomItemData.GetMainType();
			InventoryDefine.EItemType? type = phantomItemData.GetType();
			this.ClearFromItemMainTypeMap(mainType.Value);
			this.ClearFromItemTypeMap(type.Value);
		}
		this.PhantomItemMap.Clear();
	}

	// Token: 0x0600FCF9 RID: 64761 RVA: 0x003D732C File Offset: 0x003D552C
	public void ClearCalabashSkinItemData()
	{
		foreach (CalabashSkinItemData calabashSkinItemData in this.CalabashSkinItemMap.Values)
		{
			InventoryDefine.EItemMainTypeId? mainType = calabashSkinItemData.GetMainType();
			InventoryDefine.EItemType? type = calabashSkinItemData.GetType();
			this.ClearFromItemMainTypeMap(mainType.Value);
			this.ClearFromItemTypeMap(type.Value);
		}
		this.CalabashSkinItemMap.Clear();
	}

	// Token: 0x0600FCFA RID: 64762 RVA: 0x003D73B0 File Offset: 0x003D55B0
	public void ClearOrnamentItemData()
	{
		foreach (OrnamentItemData ornamentItemData in this.OrnamentItemMap.Values)
		{
			InventoryDefine.EItemMainTypeId? mainType = ornamentItemData.GetMainType();
			InventoryDefine.EItemType? type = ornamentItemData.GetType();
			this.ClearFromItemMainTypeMap(mainType.Value);
			this.ClearFromItemTypeMap(type.Value);
		}
		this.OrnamentItemMap.Clear();
	}

	// Token: 0x0600FCFB RID: 64763 RVA: 0x003D7434 File Offset: 0x003D5634
	public void ClearAllItemData()
	{
		this.ClearCommonItemData();
		this.ClearWeaponItemData();
		this.ClearPhantomItemData();
		this.ClearCalabashSkinItemData();
		this.ClearOrnamentItemData();
		this.ItemTypeMap.Clear();
		this.ItemMainTypeMap.Clear();
		this.CommonItemByItemTypeMap.Clear();
	}

	// Token: 0x0600FCFC RID: 64764 RVA: 0x003D7480 File Offset: 0x003D5680
	[NullableContext(2)]
	public AttributeItemData GetAttributeItemData(int uniqueId)
	{
		AttributeItemData attributeItemData = this.GetWeaponItemData(uniqueId);
		if (attributeItemData == null)
		{
			attributeItemData = this.GetPhantomItemData(uniqueId);
		}
		if (attributeItemData == null)
		{
			attributeItemData = DangoAbyssModel.Instance.GetPluginItemInfoById(uniqueId);
		}
		return attributeItemData;
	}

	// Token: 0x0600FCFD RID: 64765 RVA: 0x003D74B0 File Offset: 0x003D56B0
	public List<WeaponItemData> GetWeaponItemDataList()
	{
		List<WeaponItemData> list = new List<WeaponItemData>();
		foreach (WeaponItemData weaponItemData in this.GetAllWeaponItemDataIterator())
		{
			if (!WeaponModel.Instance.IsWeaponUsedByUncommonRole(weaponItemData.GetUniqueId()))
			{
				list.Add(weaponItemData);
			}
		}
		return list;
	}

	// Token: 0x0600FCFE RID: 64766 RVA: 0x003D751C File Offset: 0x003D571C
	public List<PhantomItemData> GetPhantomItemDataList()
	{
		List<PhantomItemData> list = new List<PhantomItemData>();
		foreach (PhantomItemData item in this.PhantomItemMap.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0600FCFF RID: 64767 RVA: 0x003D757C File Offset: 0x003D577C
	public List<PhantomItemData> GetUnEquipPhantomItemDataList()
	{
		List<PhantomItemData> phantomItemDataList = this.GetPhantomItemDataList();
		List<PhantomItemData> list = new List<PhantomItemData>();
		foreach (PhantomItemData phantomItemData in phantomItemDataList)
		{
			if (!PhantomBattleController.Instance.CheckIsEquip(phantomItemData.GetUniqueId()))
			{
				list.Add(phantomItemData);
			}
		}
		return list;
	}

	// Token: 0x0600FD00 RID: 64768 RVA: 0x003D75E8 File Offset: 0x003D57E8
	public List<PhantomItemData> GetPhantomItemDataListByPhantomItemId(int itemId)
	{
		List<PhantomItemData> list = new List<PhantomItemData>();
		foreach (PhantomItemData phantomItemData in this.PhantomItemMap.Values)
		{
			if (phantomItemData.GetConfigId() == itemId)
			{
				list.Add(phantomItemData);
			}
		}
		return list;
	}

	// Token: 0x0600FD01 RID: 64769 RVA: 0x003D7650 File Offset: 0x003D5850
	public List<PhantomItemData> GetPhantomItemDataListByPhantomItem(List<Aki.Protocol.PhantomItem> phantomItemList)
	{
		List<PhantomItemData> list = new List<PhantomItemData>();
		foreach (Aki.Protocol.PhantomItem data in phantomItemList)
		{
			PhantomItemData phantomItemDataByPhantomItem = this.GetPhantomItemDataByPhantomItem(data);
			list.Add(phantomItemDataByPhantomItem);
		}
		return list;
	}

	// Token: 0x0600FD02 RID: 64770 RVA: 0x003D76B0 File Offset: 0x003D58B0
	public PhantomItemData GetPhantomItemDataByPhantomItem(Aki.Protocol.PhantomItem data)
	{
		PhantomItemData phantomItemData = new PhantomItemData(data.Id, data.IncrId, data.FuncValue, InventoryDefine.EItemDataType.PhantomItem);
		phantomItemData.SetFetterGroupId(data.FetterGroupId);
		return phantomItemData;
	}

	// Token: 0x0600FD03 RID: 64771 RVA: 0x003D76D8 File Offset: 0x003D58D8
	public List<PhantomItemData> GetPhantomItemDataListByAddCountItemInfo(List<AddCountItemInfo> items)
	{
		List<PhantomItemData> list = new List<PhantomItemData>();
		foreach (AddCountItemInfo addCountItemInfo in items)
		{
			PhantomItemData item = new PhantomItemData(addCountItemInfo.Id, addCountItemInfo.IncrId, 0, InventoryDefine.EItemDataType.PhantomItem);
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0600FD04 RID: 64772 RVA: 0x003D7744 File Offset: 0x003D5944
	public List<CommonItemData> GetCommonItemDataList()
	{
		List<CommonItemData> list = new List<CommonItemData>();
		foreach (Dictionary<int, CommonItemData> dictionary in this.CommonItemMap.Values)
		{
			foreach (CommonItemData commonItemData in dictionary.Values)
			{
				if (commonItemData.IsValid())
				{
					list.Add(commonItemData);
				}
			}
		}
		return list;
	}

	// Token: 0x0600FD05 RID: 64773 RVA: 0x003D77E4 File Offset: 0x003D59E4
	public List<CommonItemData> GetCommonItemByItemType(InventoryDefine.EItemType itemType)
	{
		HashSet<CommonItemData> source;
		if (!this.CommonItemByItemTypeMap.TryGetValue(itemType, out source))
		{
			return new List<CommonItemData>();
		}
		return (from commonItemData in source
		where commonItemData.IsValid()
		select commonItemData).ToList<CommonItemData>();
	}

	// Token: 0x0600FD06 RID: 64774 RVA: 0x003D7834 File Offset: 0x003D5A34
	public List<CommonItemData> GetCommonItemByShowType(InventoryDefine.EShowType showType)
	{
		List<CommonItemData> list = new List<CommonItemData>();
		foreach (Dictionary<int, CommonItemData> dictionary in this.CommonItemMap.Values)
		{
			foreach (CommonItemData commonItemData in dictionary.Values)
			{
				if (commonItemData.GetShowTypeList().Contains((int)showType) && commonItemData.IsValid())
				{
					list.Add(commonItemData);
				}
			}
		}
		return list;
	}

	// Token: 0x0600FD07 RID: 64775 RVA: 0x003D78E4 File Offset: 0x003D5AE4
	public List<WeaponItemData> GetWeaponItemByItemType(InventoryDefine.EItemType itemType)
	{
		List<WeaponItemData> list = new List<WeaponItemData>();
		foreach (WeaponItemData weaponItemData in this.GetWeaponItemDataList())
		{
			InventoryDefine.EItemType? type = weaponItemData.GetType();
			if (type.GetValueOrDefault() == itemType & type != null)
			{
				list.Add(weaponItemData);
			}
		}
		return list;
	}

	// Token: 0x0600FD08 RID: 64776 RVA: 0x003D7960 File Offset: 0x003D5B60
	public List<PhantomItemData> GetPhantomItemByItemType(InventoryDefine.EItemType itemType)
	{
		List<PhantomItemData> list = new List<PhantomItemData>();
		foreach (PhantomItemData phantomItemData in this.PhantomItemMap.Values)
		{
			InventoryDefine.EItemType? type = phantomItemData.GetType();
			if (type.GetValueOrDefault() == itemType & type != null)
			{
				list.Add(phantomItemData);
			}
		}
		return list;
	}

	// Token: 0x0600FD09 RID: 64777 RVA: 0x003D79E0 File Offset: 0x003D5BE0
	public List<ItemDataBase> GetItemDataBase(InventoryDefine.IGetItemData getItemData)
	{
		int incId = getItemData.IncId;
		if (incId > 0)
		{
			return new List<ItemDataBase>
			{
				this.GetAttributeItemData(incId)
			};
		}
		return this.GetItemDataBaseByConfigId(getItemData.ItemId);
	}

	// Token: 0x0600FD0A RID: 64778 RVA: 0x003D7A18 File Offset: 0x003D5C18
	[NullableContext(2)]
	public global::ItemMainTypeMapping GetItemMainTypeMapping(InventoryDefine.EItemMainTypeId mainType)
	{
		global::ItemMainTypeMapping result;
		this.ItemMainTypeMap.TryGetValue(mainType, out result);
		return result;
	}

	// Token: 0x0600FD0B RID: 64779 RVA: 0x003D7A35 File Offset: 0x003D5C35
	public HashSet<ItemDataBase> GetItemDataBaseByMainType(InventoryDefine.EItemMainTypeId mainType)
	{
		return this.CurrentProxy.GetItemDataBaseByMainType(mainType);
	}

	// Token: 0x0600FD0C RID: 64780 RVA: 0x003D7A44 File Offset: 0x003D5C44
	public HashSet<ItemDataBase> GetItemDataBaseByMainTypeBase(InventoryDefine.EItemMainTypeId mainType)
	{
		HashSet<ItemDataBase> hashSet = new HashSet<ItemDataBase>();
		global::ItemMainTypeMapping itemMainTypeMapping;
		if (!this.ItemMainTypeMap.TryGetValue(mainType, out itemMainTypeMapping))
		{
			return hashSet;
		}
		foreach (ItemDataBase itemDataBase in itemMainTypeMapping.GetSet())
		{
			if (itemDataBase.IsValid())
			{
				hashSet.Add(itemDataBase);
			}
		}
		return hashSet;
	}

	// Token: 0x0600FD0D RID: 64781 RVA: 0x003D7ABC File Offset: 0x003D5CBC
	public int GetInventoryItemGridCountByMainType(InventoryDefine.EItemMainTypeId mainType)
	{
		return this.CurrentProxy.GetInventoryItemGridCountByMainType(mainType);
	}

	// Token: 0x0600FD0E RID: 64782 RVA: 0x003D7ACC File Offset: 0x003D5CCC
	public int GetInventoryItemGridCountByMainTypeBase(InventoryDefine.EItemMainTypeId mainType)
	{
		HashSet<ItemDataBase> itemDataBaseByMainTypeBase = this.GetItemDataBaseByMainTypeBase(mainType);
		int num = 0;
		foreach (ItemDataBase itemDataBase in itemDataBaseByMainTypeBase)
		{
			InventoryDefine.EItemType? type = itemDataBase.GetType();
			InventoryDefine.EItemType eitemType = InventoryDefine.EItemType.Virtual;
			if (!(type.GetValueOrDefault() == eitemType & type != null))
			{
				if (itemDataBase is CommonItemData)
				{
					int maxStackCount = itemDataBase.GetMaxStackCount();
					if (maxStackCount > 0)
					{
						num += (int)Math.Ceiling((double)((float)itemDataBase.GetCount() / (float)maxStackCount));
					}
				}
				else
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x0600FD0F RID: 64783 RVA: 0x003D7B6C File Offset: 0x003D5D6C
	public HashSet<ItemDataBase> GetItemDataBaseByItemType(InventoryDefine.EItemType itemType)
	{
		HashSet<ItemDataBase> hashSet = new HashSet<ItemDataBase>();
		HashSet<ItemDataBase> hashSet2;
		if (!this.ItemTypeMap.TryGetValue(itemType, out hashSet2))
		{
			return hashSet;
		}
		foreach (ItemDataBase itemDataBase in hashSet2)
		{
			if (itemDataBase.IsValid())
			{
				hashSet.Add(itemDataBase);
			}
		}
		return hashSet;
	}

	// Token: 0x0600FD10 RID: 64784 RVA: 0x003D7BDC File Offset: 0x003D5DDC
	private Dictionary<int, WeaponItemData>.ValueCollection GetAllWeaponItemDataIterator()
	{
		return this.WeaponItemMap.Values;
	}

	// Token: 0x0600FD11 RID: 64785 RVA: 0x003D7BE9 File Offset: 0x003D5DE9
	public Dictionary<int, PhantomItemData>.ValueCollection GetAllPhantomItemDataIterator()
	{
		return this.PhantomItemMap.Values;
	}

	// Token: 0x0600FD12 RID: 64786 RVA: 0x003D7BF6 File Offset: 0x003D5DF6
	[NullableContext(2)]
	public void SetSelectedItemViewData(global::ItemViewData itemViewData)
	{
		this.SelectedItemViewData = itemViewData;
	}

	// Token: 0x0600FD13 RID: 64787 RVA: 0x003D7BFF File Offset: 0x003D5DFF
	public void SetCurrentLockItemUniqueId(int uniqueId)
	{
		this.CurrentLockItemUniqueId = uniqueId;
	}

	// Token: 0x0600FD14 RID: 64788 RVA: 0x003D7C08 File Offset: 0x003D5E08
	[NullableContext(2)]
	public global::ItemViewData GetSelectedItemData()
	{
		return this.SelectedItemViewData;
	}

	// Token: 0x17001359 RID: 4953
	// (get) Token: 0x0600FD15 RID: 64789 RVA: 0x003D7C10 File Offset: 0x003D5E10
	public int GetCurrentLockItemUniqueId
	{
		get
		{
			return this.CurrentLockItemUniqueId;
		}
	}

	// Token: 0x0600FD16 RID: 64790 RVA: 0x003D7C18 File Offset: 0x003D5E18
	public void SetSelectedTypeIndex(int index)
	{
		this.CurrentProxy.SetSelectedTypeIndex(index);
	}

	// Token: 0x0600FD17 RID: 64791 RVA: 0x003D7C26 File Offset: 0x003D5E26
	public int GetSelectedTypeIndex()
	{
		return this.CurrentProxy.GetSelectedTypeIndex();
	}

	// Token: 0x0600FD18 RID: 64792 RVA: 0x003D7C33 File Offset: 0x003D5E33
	public void SetOutsideUniqueId(int uniqueId)
	{
		this.OutsideUniqueId = new int?(uniqueId);
	}

	// Token: 0x0600FD19 RID: 64793 RVA: 0x003D7C41 File Offset: 0x003D5E41
	public int? GetOutsideUniqueId()
	{
		return this.OutsideUniqueId;
	}

	// Token: 0x0600FD1A RID: 64794 RVA: 0x003D7C49 File Offset: 0x003D5E49
	public void ClearOutsideUniqueId()
	{
		this.OutsideUniqueId = null;
	}

	// Token: 0x0600FD1B RID: 64795 RVA: 0x003D7C57 File Offset: 0x003D5E57
	public int GetItemCountByConfigId(int itemConfigId, int uniqueId = 0)
	{
		return this.CurrentProxy.GetItemCountByConfigId(itemConfigId, uniqueId);
	}

	// Token: 0x0600FD1C RID: 64796 RVA: 0x003D7C68 File Offset: 0x003D5E68
	public int GetItemCountByConfigIdBase(int itemConfigId, int uniqueId = 0)
	{
		if (Enum.IsDefined(typeof(EItemId), itemConfigId))
		{
			return PlayerInfoModel.Instance.GetPlayerMoney(itemConfigId);
		}
		switch (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemConfigId)))
		{
		case InventoryDefine.EItemDataType.WeaponItem:
			return this.GetWeaponItemCount(itemConfigId);
		case InventoryDefine.EItemDataType.PhantomItem:
			return this.GetPhantomItemCount(itemConfigId);
		case InventoryDefine.EItemDataType.CardItem:
			return this.GetCardItemCount(itemConfigId);
		case InventoryDefine.EItemDataType.RogueCurrency:
			return this.GetRogueCurrencyItemCount(itemConfigId);
		case InventoryDefine.EItemDataType.RogueResCurrency:
			return this.GetRogueResCurrencyItemCount(itemConfigId);
		case InventoryDefine.EItemDataType.WeaponSkinItem:
			return this.GetWeaponSkinCount(itemConfigId);
		case InventoryDefine.EItemDataType.RoleSkinItem:
			return this.GetRoleSkinCount(itemConfigId);
		case InventoryDefine.EItemDataType.PlayerHeadItem:
			return this.GetPlayerHeadItemCount(itemConfigId);
		case InventoryDefine.EItemDataType.FlySkinItem:
			return this.GetFlySkinCount(itemConfigId);
		case InventoryDefine.EItemDataType.PhantomArenaCard:
			return this.GetPhantomArenaCardCount(itemConfigId);
		case InventoryDefine.EItemDataType.CalabashSkinItem:
			return this.GetCalabashSkinCount(itemConfigId);
		case InventoryDefine.EItemDataType.MotorStickerItem:
			return this.GetMotorSkinCount(itemConfigId);
		case InventoryDefine.EItemDataType.FurnitureItem:
			return this.GetFurnitureItemCount(itemConfigId);
		case InventoryDefine.EItemDataType.MotorSkinItem:
			return this.GetOwnedMotorSkinCount(itemConfigId);
		case InventoryDefine.EItemDataType.OrnamentItem:
			return this.GetOrnamentItemCount(itemConfigId);
		case InventoryDefine.EItemDataType.PinballRoleItem:
			return this.GetPinballRoleItemCount(itemConfigId);
		case InventoryDefine.EItemDataType.PinballWeaponItem:
			return this.GetPinballWeaponItemCount(itemConfigId);
		case InventoryDefine.EItemDataType.RoverRogueCurrency:
			return this.GetRoverRogueCurrencyItemCount(itemConfigId);
		}
		return this.GetCommonItemCount(itemConfigId, uniqueId);
	}

	// Token: 0x0600FD1D RID: 64797 RVA: 0x003D7DD0 File Offset: 0x003D5FD0
	public List<IGetWayItemData> GetGetWayDataList(int itemId)
	{
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
		if (itemConfigData.ItemAccess == null || itemConfigData.ItemAccess.Length == 0)
		{
			return new List<IGetWayItemData>();
		}
		List<IGetWayItemData> list = new List<IGetWayItemData>();
		int[] itemAccess = itemConfigData.ItemAccess;
		for (int i = 0; i < itemAccess.Length; i++)
		{
			int getWayId = itemAccess[i];
			AccessPath? configById = GetWayConfig.Instance.GetConfigById(getWayId);
			if (configById != null)
			{
				GetWayItemData item = new GetWayItemData(getWayId, (EGetWayItemType)configById.Value.Type, configById.Value.Description, configById.Value.SortIndex, delegate()
				{
					SkipTaskManager.RunByConfigId(getWayId, itemId);
				});
				list.Add(item);
			}
		}
		list.Sort(delegate(IGetWayItemData aGetWayData, IGetWayItemData bGetWayData)
		{
			int sortIndex = aGetWayData.SortIndex;
			int sortIndex2 = bGetWayData.SortIndex;
			if (sortIndex == sortIndex2)
			{
				return bGetWayData.Id - aGetWayData.Id;
			}
			return sortIndex2 - sortIndex;
		});
		return list;
	}

	// Token: 0x0600FD1E RID: 64798 RVA: 0x003D7EE8 File Offset: 0x003D60E8
	private int GetWeaponItemCount(int configId)
	{
		int num = 0;
		using (List<WeaponItemData>.Enumerator enumerator = this.GetWeaponItemDataList().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetConfigId() == configId)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x0600FD1F RID: 64799 RVA: 0x003D7F44 File Offset: 0x003D6144
	private int GetRogueCurrencyItemCount(int configId)
	{
		return RoguelikeModel.Instance.GetRoguelikeInventoryCurrency(configId);
	}

	// Token: 0x0600FD20 RID: 64800 RVA: 0x003D7F51 File Offset: 0x003D6151
	private int GetRogueResCurrencyItemCount(int configId)
	{
		return ActivityPermanentRogueModel.Instance.GetCurrency(configId);
	}

	// Token: 0x0600FD21 RID: 64801 RVA: 0x003D7F5E File Offset: 0x003D615E
	private int GetRoverRogueCurrencyItemCount(int configId)
	{
		return RoverlikeModel.Instance.GetCurrency(configId);
	}

	// Token: 0x0600FD22 RID: 64802 RVA: 0x003D7F6B File Offset: 0x003D616B
	private int GetWeaponSkinCount(int configId)
	{
		return WeaponSkinModel.Instance.GetSkinCountById(configId);
	}

	// Token: 0x0600FD23 RID: 64803 RVA: 0x003D7F78 File Offset: 0x003D6178
	private int GetRoleSkinCount(int configId)
	{
		return RoleSkinModel.Instance.GetSkinCountById(configId);
	}

	// Token: 0x0600FD24 RID: 64804 RVA: 0x003D7F85 File Offset: 0x003D6185
	private int GetFlySkinCount(int configId)
	{
		return FlySkinModel.Instance.GetFlySkinItemCount(configId);
	}

	// Token: 0x0600FD25 RID: 64805 RVA: 0x003D7F94 File Offset: 0x003D6194
	private int GetMotorSkinCount(int configId)
	{
		EOutLookState stickerState = MotorcycleDiyModel.Instance.GetStickerState(configId);
		if (stickerState == EOutLookState.IsEquipped || stickerState == EOutLookState.CanEquipped)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x0600FD26 RID: 64806 RVA: 0x003D7FB8 File Offset: 0x003D61B8
	private int GetOwnedMotorSkinCount(int configId)
	{
		return (MotorcycleDiyModel.Instance.HasSkin(configId) > false) ? 1 : 0;
	}

	// Token: 0x0600FD27 RID: 64807 RVA: 0x003D7FC8 File Offset: 0x003D61C8
	private int GetPhantomArenaCardCount(int configId)
	{
		if (!PhantomArenaModel.Instance.IsCardUnlock(configId))
		{
			return 0;
		}
		return PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(configId).CardGroupNum;
	}

	// Token: 0x0600FD28 RID: 64808 RVA: 0x003D7FF7 File Offset: 0x003D61F7
	private int GetCalabashSkinCount(int configId)
	{
		return CalabashSkinModel.Instance.GetSkinCountById(configId);
	}

	// Token: 0x0600FD29 RID: 64809 RVA: 0x003D8004 File Offset: 0x003D6204
	private int GetFurnitureItemCount(int configId)
	{
		return (FurnitureModel.Instance.GetIsFurnitureUnlockById(configId) > false) ? 1 : 0;
	}

	// Token: 0x0600FD2A RID: 64810 RVA: 0x003D8014 File Offset: 0x003D6214
	private int GetOrnamentItemCount(int configId)
	{
		return RoleOrnamentModel.Instance.GetOrnamentCountById(configId);
	}

	// Token: 0x0600FD2B RID: 64811 RVA: 0x003D8021 File Offset: 0x003D6221
	private int GetPinballRoleItemCount(int configId)
	{
		return 0;
	}

	// Token: 0x0600FD2C RID: 64812 RVA: 0x003D8024 File Offset: 0x003D6224
	private int GetPinballWeaponItemCount(int configId)
	{
		return 0;
	}

	// Token: 0x0600FD2D RID: 64813 RVA: 0x003D8028 File Offset: 0x003D6228
	private int GetPhantomItemCount(int configId)
	{
		int num = 0;
		using (Dictionary<int, PhantomItemData>.ValueCollection.Enumerator enumerator = this.GetAllPhantomItemDataIterator().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetConfigId() == configId)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x0600FD2E RID: 64814 RVA: 0x003D8084 File Offset: 0x003D6284
	private int GetPlayerHeadItemCount(int configId)
	{
		PlayerHeadData playerHeadData = PersonalModel.Instance.GetPlayerHeadData(configId, true);
		if (playerHeadData != null && !playerHeadData.Lock)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x0600FD2F RID: 64815 RVA: 0x003D80AC File Offset: 0x003D62AC
	private int GetCardItemCount(int configId)
	{
		List<PersonalCardData> cardDataList = PersonalModel.Instance.GetCardDataList();
		int count = cardDataList.Count;
		for (int i = 0; i < count; i++)
		{
			PersonalCardData personalCardData = cardDataList[i];
			if (personalCardData.CardId == configId && personalCardData.IsUnLock)
			{
				return 1;
			}
		}
		return 0;
	}

	// Token: 0x0600FD30 RID: 64816 RVA: 0x003D80F3 File Offset: 0x003D62F3
	public bool TryAddNewCommonItem(int configId, int uniqueId = 0)
	{
		if (uniqueId != 0)
		{
			return this.TryAddNewAttributeItem(uniqueId);
		}
		if (NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.InventoryCommonItem, configId))
		{
			return false;
		}
		NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.InventoryCommonItem, configId);
		EventSystem.Instance.Emit<int>(EEventName.OnGetNewItem, configId);
		return true;
	}

	// Token: 0x0600FD31 RID: 64817 RVA: 0x003D812F File Offset: 0x003D632F
	public bool TryAddNewAttributeItem(int uniqueId)
	{
		if (NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.InventoryAttributeItem, uniqueId))
		{
			return false;
		}
		NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.InventoryAttributeItem, uniqueId);
		EventSystem.Instance.Emit<int>(EEventName.OnGetNewItem, uniqueId);
		return true;
	}

	// Token: 0x0600FD32 RID: 64818 RVA: 0x003D8160 File Offset: 0x003D6360
	public bool RemoveNewCommonItem(int configId, int uniqueId = 0)
	{
		if (uniqueId != 0)
		{
			return this.RemoveNewAttributeItem(uniqueId);
		}
		return NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.InventoryCommonItem, configId);
	}

	// Token: 0x0600FD33 RID: 64819 RVA: 0x003D8179 File Offset: 0x003D6379
	public bool RemoveNewAttributeItem(int uniqueId)
	{
		return NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.InventoryAttributeItem, uniqueId);
	}

	// Token: 0x0600FD34 RID: 64820 RVA: 0x003D8187 File Offset: 0x003D6387
	public bool SaveNewCommonItemConfigIdList()
	{
		return NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.InventoryCommonItem);
	}

	// Token: 0x0600FD35 RID: 64821 RVA: 0x003D8194 File Offset: 0x003D6394
	public bool SaveNewAttributeItemUniqueIdList()
	{
		return NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.InventoryAttributeItem);
	}

	// Token: 0x0600FD36 RID: 64822 RVA: 0x003D81A1 File Offset: 0x003D63A1
	public bool IsNewCommonItem(int configId, int uniqueId = 0)
	{
		if (uniqueId != 0)
		{
			return this.IsNewAttributeItem(uniqueId);
		}
		return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.InventoryCommonItem, configId);
	}

	// Token: 0x0600FD37 RID: 64823 RVA: 0x003D81BA File Offset: 0x003D63BA
	public bool IsNewAttributeItem(int uniqueId)
	{
		return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.InventoryAttributeItem, uniqueId);
	}

	// Token: 0x0600FD38 RID: 64824 RVA: 0x003D81C8 File Offset: 0x003D63C8
	[NullableContext(2)]
	public HashSet<int> GetNewAttributeItemUniqueIdList()
	{
		return NewFlagModel.Instance.GetNewFlagSet(ELocalStoragePlayerKey.InventoryAttributeItem);
	}

	// Token: 0x0600FD39 RID: 64825 RVA: 0x003D81D8 File Offset: 0x003D63D8
	public bool TryAddRedDotCommonItem(int configId, int uniqueId = 0)
	{
		CommonItemData commonItemData = this.GetCommonItemData(configId, uniqueId);
		if (commonItemData == null)
		{
			return false;
		}
		InventoryDefine.ERedDotDisableRule redDotDisableRule = commonItemData.GetRedDotDisableRule();
		if (redDotDisableRule == InventoryDefine.ERedDotDisableRule.None)
		{
			return false;
		}
		if (uniqueId != 0)
		{
			NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.InventoryAttributeItemRedDot, uniqueId);
			return true;
		}
		if (redDotDisableRule == InventoryDefine.ERedDotDisableRule.ServerFirstSelect)
		{
			this.TryAddCommonItemServerFirstSelectRedDot(configId);
		}
		else
		{
			NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.InventoryCommonItemRedDot, configId);
		}
		return true;
	}

	// Token: 0x0600FD3A RID: 64826 RVA: 0x003D822C File Offset: 0x003D642C
	private void TryAddCommonItemServerFirstSelectRedDot(int itemId)
	{
		ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ItemBackpackFirstCheck) as ServerStorageMap;
		if (serverStorageMap.Has(itemId))
		{
			return;
		}
		serverStorageMap.Set(itemId, 1);
	}

	// Token: 0x0600FD3B RID: 64827 RVA: 0x003D8260 File Offset: 0x003D6460
	private bool TryClearCommonItemServerFirstSelectRedDot(int itemId)
	{
		ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ItemBackpackFirstCheck) as ServerStorageMap;
		if (serverStorageMap.Get(itemId).GetValueOrDefault() == 1)
		{
			serverStorageMap.Set(itemId, 0);
			return true;
		}
		return false;
	}

	// Token: 0x0600FD3C RID: 64828 RVA: 0x003D829C File Offset: 0x003D649C
	public bool HasCommonItemServerFirstSelectRedDot(int itemId)
	{
		ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ItemBackpackFirstCheck) as ServerStorageMap;
		return serverStorageMap != null && serverStorageMap.Get(itemId).GetValueOrDefault() == 1;
	}

	// Token: 0x0600FD3D RID: 64829 RVA: 0x003D82D4 File Offset: 0x003D64D4
	public bool HasAnyCommonItemServerFirstSelectRedDot()
	{
		ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ItemBackpackFirstCheck) as ServerStorageMap;
		if (serverStorageMap == null)
		{
			return false;
		}
		return serverStorageMap.GetContainer().Values.Any((int value) => value == 1);
	}

	// Token: 0x0600FD3E RID: 64830 RVA: 0x003D8328 File Offset: 0x003D6528
	public bool TryAddRedDotAttributeItem(int uniqueId)
	{
		if (NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.InventoryAttributeItemRedDot, uniqueId))
		{
			return false;
		}
		AttributeItemData attributeItemData = this.GetAttributeItemData(uniqueId);
		if (attributeItemData == null)
		{
			return false;
		}
		if (attributeItemData.GetRedDotDisableRule() == InventoryDefine.ERedDotDisableRule.None)
		{
			return false;
		}
		NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.InventoryAttributeItemRedDot, uniqueId);
		return true;
	}

	// Token: 0x0600FD3F RID: 64831 RVA: 0x003D836C File Offset: 0x003D656C
	public bool HasRedDot()
	{
		NewFlagModel instance = NewFlagModel.Instance;
		HashSet<int> newFlagSet = instance.GetNewFlagSet(ELocalStoragePlayerKey.InventoryCommonItemRedDot);
		int num = 0;
		if (newFlagSet != null)
		{
			num = newFlagSet.Count;
		}
		int num2 = 0;
		HashSet<int> newFlagSet2 = instance.GetNewFlagSet(ELocalStoragePlayerKey.InventoryAttributeItemRedDot);
		if (newFlagSet2 != null)
		{
			num2 = newFlagSet2.Count;
		}
		return num > 0 || num2 > 0 || this.HasAnyCommonItemServerFirstSelectRedDot();
	}

	// Token: 0x0600FD40 RID: 64832 RVA: 0x003D83B5 File Offset: 0x003D65B5
	public bool IsMainTypeHasRedDot(InventoryDefine.EItemMainTypeId itemMainType)
	{
		global::ItemMainTypeMapping itemMainTypeMapping = this.GetItemMainTypeMapping(itemMainType);
		return itemMainTypeMapping != null && itemMainTypeMapping.HasRedDot();
	}

	// Token: 0x0600FD41 RID: 64833 RVA: 0x003D83C9 File Offset: 0x003D65C9
	public bool IsCommonItemHasRedDot(int configId, int uniqueId = 0)
	{
		if (uniqueId != 0)
		{
			return this.IsAttributeItemHasRedDot(uniqueId);
		}
		return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.InventoryCommonItemRedDot, configId) || this.HasCommonItemServerFirstSelectRedDot(configId);
	}

	// Token: 0x0600FD42 RID: 64834 RVA: 0x003D83ED File Offset: 0x003D65ED
	public bool IsAttributeItemHasRedDot(int uniqueId)
	{
		return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.InventoryAttributeItemRedDot, uniqueId);
	}

	// Token: 0x0600FD43 RID: 64835 RVA: 0x003D83FC File Offset: 0x003D65FC
	public bool RemoveRedDotCommonItem(int configId, int uniqueId = 0)
	{
		if (uniqueId != 0)
		{
			return this.RemoveRedDotAttributeItem(uniqueId);
		}
		bool flag = NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.InventoryCommonItemRedDot, configId);
		bool flag2 = this.TryClearCommonItemServerFirstSelectRedDot(configId);
		if (flag || flag2)
		{
			EventSystem.Instance.Emit(EEventName.OnRemoveItemRedDot);
			return true;
		}
		return false;
	}

	// Token: 0x0600FD44 RID: 64836 RVA: 0x003D843F File Offset: 0x003D663F
	public bool RemoveRedDotAttributeItem(int uniqueId)
	{
		if (!NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.InventoryAttributeItemRedDot, uniqueId))
		{
			return false;
		}
		EventSystem.Instance.Emit(EEventName.OnRemoveItemRedDot);
		return true;
	}

	// Token: 0x0600FD45 RID: 64837 RVA: 0x003D8462 File Offset: 0x003D6662
	public bool SaveRedDotCommonItemConfigIdList()
	{
		return NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.InventoryCommonItemRedDot);
	}

	// Token: 0x0600FD46 RID: 64838 RVA: 0x003D846F File Offset: 0x003D666F
	public bool SaveRedDotAttributeItemUniqueIdList()
	{
		return NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.InventoryAttributeItemRedDot);
	}

	// Token: 0x0600FD47 RID: 64839 RVA: 0x003D847C File Offset: 0x003D667C
	[NullableContext(2)]
	public void SetAcquireData(AcquireData acquireData)
	{
		this.CurrentAcquireData = acquireData;
	}

	// Token: 0x0600FD48 RID: 64840 RVA: 0x003D8485 File Offset: 0x003D6685
	[NullableContext(2)]
	public AcquireData GetAcquireData()
	{
		return this.CurrentAcquireData;
	}

	// Token: 0x0600FD49 RID: 64841 RVA: 0x003D8490 File Offset: 0x003D6690
	public bool CheckIsCoinEnough(int coinItemId, IList<OneItemConfig> matList)
	{
		foreach (OneItemConfig oneItemConfig in matList)
		{
			if (oneItemConfig.ItemId == coinItemId)
			{
				return this.GetItemCountByConfigId(coinItemId, 0) >= oneItemConfig.Count;
			}
		}
		return true;
	}

	// Token: 0x0600FD4A RID: 64842 RVA: 0x003D84F8 File Offset: 0x003D66F8
	public bool GetPhantomManageConfigClear()
	{
		return this.PhantomManageConfig.Count == 0;
	}

	// Token: 0x0600FD4B RID: 64843 RVA: 0x003D8508 File Offset: 0x003D6708
	public List<PhantomManageConfigData> GetPhantomManageConfigByType(PhantomSettingType type)
	{
		if (this.PhantomManageConfig.Count == 0 || !this.PhantomManageConfig.ContainsKey(type))
		{
			Log.Instance.Error(ELogModule.Inventory, ELogAuthor.WDX, "批量管理方案未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<PhantomManageConfigData>();
		}
		return this.PhantomManageConfig[type];
	}

	// Token: 0x0600FD4C RID: 64844 RVA: 0x003D8560 File Offset: 0x003D6760
	[NullableContext(2)]
	public PhantomManageConfigData GetPhantomManageConfigByTypeAndIndex(PhantomSettingType type, int index)
	{
		foreach (PhantomManageConfigData phantomManageConfigData in this.GetPhantomManageConfigByType(type))
		{
			if (phantomManageConfigData.GetIndex() == index)
			{
				return phantomManageConfigData;
			}
		}
		Log.Instance.Error(ELogModule.Inventory, ELogAuthor.WDX, "批量管理方案未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
		return null;
	}

	// Token: 0x0600FD4D RID: 64845 RVA: 0x003D85DC File Offset: 0x003D67DC
	public void UpdatePhantomManageConfig(PhantomSettingType type, PhantomSettingUpdateResponse response)
	{
		OnePhantomSetting setting = response.Setting;
		List<PhantomManageConfigData> list;
		if (!this.PhantomManageConfig.TryGetValue(type, out list))
		{
			Log.Instance.Error(ELogModule.Inventory, ELogAuthor.WDX, "批量管理方案更新失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int index = setting.Index;
		foreach (PhantomManageConfigData phantomManageConfigData in list)
		{
			int index2 = phantomManageConfigData.GetIndex();
			if (index == index2)
			{
				phantomManageConfigData.Parse(setting);
				break;
			}
		}
	}

	// Token: 0x0600FD4E RID: 64846 RVA: 0x003D8678 File Offset: 0x003D6878
	public void CoverAllPhantomManageConfig(List<PhantomSettingInfo> settingInfoList)
	{
		this.PhantomManageConfig.Clear();
		foreach (PhantomSettingInfo phantomSettingInfo in settingInfoList)
		{
			PhantomSettingType settingType = phantomSettingInfo.SettingType;
			List<PhantomManageConfigData> list;
			if (!this.PhantomManageConfig.TryGetValue(settingType, out list))
			{
				list = new List<PhantomManageConfigData>();
				this.PhantomManageConfig[settingType] = list;
			}
			OnePhantomSetting setting = phantomSettingInfo.Setting;
			if (setting == null)
			{
				Log.Instance.Error(ELogModule.Inventory, ELogAuthor.LZK, "批量管理方案设置数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				PhantomManageConfigData phantomManageConfigData = new PhantomManageConfigData(setting.Index);
				phantomManageConfigData.SetType(settingType);
				phantomManageConfigData.Parse(setting);
				list.Add(phantomManageConfigData);
				this.PhantomManageConfig[settingType] = list;
			}
		}
		foreach (KeyValuePair<PhantomSettingType, List<PhantomManageConfigData>> keyValuePair in this.PhantomManageConfig)
		{
			PhantomSettingType key = keyValuePair.Key;
			List<PhantomManageConfigData> value = keyValuePair.Value;
			while (value.Count < this.GetConfigMaxCountConst())
			{
				PhantomManageConfigData phantomManageConfigData2 = new PhantomManageConfigData(value.Count);
				phantomManageConfigData2.SetType(key);
				value.Add(phantomManageConfigData2);
			}
		}
	}

	// Token: 0x0600FD4F RID: 64847 RVA: 0x003D87D4 File Offset: 0x003D69D4
	public void InitPhantomManageConfig(PhantomSettingResponse response)
	{
		this.PhantomManageConfig.Clear();
		this.InitSettingsByType(PhantomSettingType.AutoLock, response.AutoLockSettings.ToList<OnePhantomSetting>());
		this.InitSettingsByType(PhantomSettingType.AutoDisuse, response.AutoDisuseSettings.ToList<OnePhantomSetting>());
	}

	// Token: 0x0600FD50 RID: 64848 RVA: 0x003D8808 File Offset: 0x003D6A08
	[return: Nullable(2)]
	private OnePhantomSetting GetSettingByIndex(int index, List<OnePhantomSetting> settingList)
	{
		foreach (OnePhantomSetting onePhantomSetting in settingList)
		{
			if (onePhantomSetting.Index == index)
			{
				return onePhantomSetting;
			}
		}
		return null;
	}

	// Token: 0x0600FD51 RID: 64849 RVA: 0x003D8860 File Offset: 0x003D6A60
	private void InitSettingsByType(PhantomSettingType type, List<OnePhantomSetting> settings)
	{
		List<PhantomManageConfigData> list = new List<PhantomManageConfigData>();
		int configMaxCountConst = this.GetConfigMaxCountConst();
		for (int i = 0; i < configMaxCountConst; i++)
		{
			PhantomManageConfigData phantomManageConfigData = new PhantomManageConfigData(i);
			phantomManageConfigData.SetType(type);
			OnePhantomSetting settingByIndex = this.GetSettingByIndex(i, settings);
			if (settingByIndex != null)
			{
				phantomManageConfigData.Parse(settingByIndex);
			}
			list.Add(phantomManageConfigData);
		}
		this.PhantomManageConfig[type] = list;
	}

	// Token: 0x0600FD52 RID: 64850 RVA: 0x003D88C0 File Offset: 0x003D6AC0
	public unsafe List<InventoryDefine.IManageConfigTitleItemData> GetSettingTitleItemDataList()
	{
		int filterIdConst = this.GetFilterIdConst();
		Span<int> ruleListBytes = FilterConfig.Instance.GetFilterConfig(filterIdConst).Value.GetRuleListBytes();
		List<InventoryDefine.IManageConfigTitleItemData> list = new List<InventoryDefine.IManageConfigTitleItemData>();
		Span<int> span = ruleListBytes;
		for (int i = 0; i < span.Length; i++)
		{
			int filterRuleId = *span[i];
			list.Add(new InventoryDefine.ManageConfigTitleItemData
			{
				FilterId = filterIdConst,
				FilterRuleId = filterRuleId
			});
		}
		return list;
	}

	// Token: 0x0600FD53 RID: 64851 RVA: 0x003D893C File Offset: 0x003D6B3C
	public int GetFilterIdConst()
	{
		return ConfigCommonParamById.GetIntConfig("PhantomAutoLockFilterId").GetValueOrDefault();
	}

	// Token: 0x0600FD54 RID: 64852 RVA: 0x003D895C File Offset: 0x003D6B5C
	public int GetConfigMaxCountConst()
	{
		return ConfigCommonParamById.GetIntConfig("PhantomSettingFilterMaxCount").GetValueOrDefault(10);
	}

	// Token: 0x0600FD55 RID: 64853 RVA: 0x003D8980 File Offset: 0x003D6B80
	public InventoryDefine.ESettingGridType GetGridTypeByFilterRuleId(int filterRuleId)
	{
		InventoryDefine.ESettingGridType result = InventoryDefine.ESettingGridType.Small;
		InventoryDefine.recFilterRuleToGirdType.TryGetValue((FilterDefine.EFilterType)filterRuleId, out result);
		return result;
	}

	// Token: 0x0600FD56 RID: 64854 RVA: 0x003D89A0 File Offset: 0x003D6BA0
	[NullableContext(2)]
	public void SetPhantomManageSelectSet(HashSet<int> selectSet)
	{
		this.PhantomManageSelectSet = selectSet;
	}

	// Token: 0x0600FD57 RID: 64855 RVA: 0x003D89A9 File Offset: 0x003D6BA9
	[NullableContext(2)]
	public HashSet<int> GetPhantomManageSelectSet()
	{
		return this.PhantomManageSelectSet;
	}

	// Token: 0x0600FD58 RID: 64856 RVA: 0x003D89B1 File Offset: 0x003D6BB1
	public void SetInventoryDataProxy(InventoryDataProxy proxy)
	{
		this.CurrentProxy = proxy;
	}

	// Token: 0x0600FD59 RID: 64857 RVA: 0x003D89BA File Offset: 0x003D6BBA
	public void ResetInventoryDataProxy()
	{
		this._CurrentProxy = null;
	}

	// Token: 0x0600FD5A RID: 64858 RVA: 0x003D89C3 File Offset: 0x003D6BC3
	public bool SupportInventoryViewShowCurrency()
	{
		return this.CurrentProxy.SupportShowCurrency();
	}

	// Token: 0x0600FD5B RID: 64859 RVA: 0x003D89D0 File Offset: 0x003D6BD0
	public bool GetInteractiveItemsFunctionEnable()
	{
		return this.InteractiveItemsFunctionEnable;
	}

	// Token: 0x0600FD5C RID: 64860 RVA: 0x003D89D8 File Offset: 0x003D6BD8
	public void SetInteractiveItemsFunctionEnable(bool enable)
	{
		bool flag = this.InteractiveItemsFunctionEnable != enable;
		this.InteractiveItemsFunctionEnable = enable;
		if (flag)
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnInteractiveItemsFunctionEnableChanged, enable);
		}
	}

	// Token: 0x1700135A RID: 4954
	// (get) Token: 0x0600FD5D RID: 64861 RVA: 0x003D8A00 File Offset: 0x003D6C00
	public static InventoryModel Instance
	{
		get
		{
			return InventoryModel._Instance;
		}
	}

	// Token: 0x0600FD5E RID: 64862 RVA: 0x003D8A07 File Offset: 0x003D6C07
	public static InventoryModel GetOrCreateInstance()
	{
		if (InventoryModel._Instance == null)
		{
			InventoryModel.CreateInstance();
		}
		return InventoryModel._Instance;
	}

	// Token: 0x0600FD5F RID: 64863 RVA: 0x003D8A1B File Offset: 0x003D6C1B
	public static bool CreateInstance()
	{
		if (InventoryModel._Instance != null)
		{
			return true;
		}
		InventoryModel._Instance = new InventoryModel();
		return true;
	}

	// Token: 0x0600FD60 RID: 64864 RVA: 0x003D8A31 File Offset: 0x003D6C31
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FD61 RID: 64865 RVA: 0x003D8A33 File Offset: 0x003D6C33
	public static void ResetStaticDefaultValue()
	{
		InventoryModel._Instance = null;
	}

	// Token: 0x0600FD62 RID: 64866 RVA: 0x003D8A3B File Offset: 0x003D6C3B
	static InventoryModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InventoryModel.CreateStaticDefaultValue), new Action(InventoryModel.ResetStaticDefaultValue));
	}

	// Token: 0x04007573 RID: 30067
	private string CD_TIME_REASON = "限时物品主动添加倒计时 [ConfigId:{0}, UniqueId:{1}]";

	// Token: 0x04007574 RID: 30068
	private int? OutsideUniqueId;

	// Token: 0x04007575 RID: 30069
	private int CurrentLockItemUniqueId;

	// Token: 0x04007576 RID: 30070
	[Nullable(2)]
	private global::ItemViewData SelectedItemViewData;

	// Token: 0x04007577 RID: 30071
	[Nullable(2)]
	private List<int> InventoryTabOpenIdList;

	// Token: 0x04007578 RID: 30072
	[Nullable(2)]
	private NormalInventoryDataProxy _DefaultProxy;

	// Token: 0x04007579 RID: 30073
	[Nullable(2)]
	private InventoryDataProxy _CurrentProxy;

	// Token: 0x0400757A RID: 30074
	private readonly Dictionary<int, Dictionary<int, CommonItemData>> CommonItemMap = new Dictionary<int, Dictionary<int, CommonItemData>>();

	// Token: 0x0400757B RID: 30075
	private readonly Dictionary<int, WeaponItemData> WeaponItemMap = new Dictionary<int, WeaponItemData>();

	// Token: 0x0400757C RID: 30076
	private readonly Dictionary<int, PhantomItemData> PhantomItemMap = new Dictionary<int, PhantomItemData>();

	// Token: 0x0400757D RID: 30077
	private readonly Dictionary<int, CalabashSkinItemData> CalabashSkinItemMap = new Dictionary<int, CalabashSkinItemData>();

	// Token: 0x0400757E RID: 30078
	private readonly Dictionary<int, OrnamentItemData> OrnamentItemMap = new Dictionary<int, OrnamentItemData>();

	// Token: 0x0400757F RID: 30079
	private readonly Dictionary<InventoryDefine.EItemType, HashSet<CommonItemData>> CommonItemByItemTypeMap = new Dictionary<InventoryDefine.EItemType, HashSet<CommonItemData>>();

	// Token: 0x04007580 RID: 30080
	private readonly Dictionary<InventoryDefine.EItemType, HashSet<ItemDataBase>> ItemTypeMap = new Dictionary<InventoryDefine.EItemType, HashSet<ItemDataBase>>();

	// Token: 0x04007581 RID: 30081
	private readonly Dictionary<InventoryDefine.EItemMainTypeId, global::ItemMainTypeMapping> ItemMainTypeMap = new Dictionary<InventoryDefine.EItemMainTypeId, global::ItemMainTypeMapping>();

	// Token: 0x04007582 RID: 30082
	[Nullable(2)]
	private AcquireData CurrentAcquireData;

	// Token: 0x04007583 RID: 30083
	private readonly HashSet<long> CdTimeStampSet = new HashSet<long>();

	// Token: 0x04007584 RID: 30084
	private readonly Dictionary<long, TimerHandle> CdTimeStampHandleMap = new Dictionary<long, TimerHandle>();

	// Token: 0x04007585 RID: 30085
	public bool IsConfirmDestruction;

	// Token: 0x04007586 RID: 30086
	private int? ItemNeedCount;

	// Token: 0x04007587 RID: 30087
	private readonly Dictionary<PhantomSettingType, List<PhantomManageConfigData>> PhantomManageConfig = new Dictionary<PhantomSettingType, List<PhantomManageConfigData>>();

	// Token: 0x04007588 RID: 30088
	[Nullable(2)]
	private HashSet<int> PhantomManageSelectSet;

	// Token: 0x04007589 RID: 30089
	private bool InteractiveItemsFunctionEnable = true;

	// Token: 0x0400758A RID: 30090
	[Nullable(2)]
	private static InventoryModel _Instance;
}

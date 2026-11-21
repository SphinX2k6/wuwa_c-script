using System;
using System.Collections.Generic;
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

// Token: 0x02001473 RID: 5235
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class InventoryModel : ModelBase
{
	// Token: 0x17001383 RID: 4995
	// (get) Token: 0x0600D0ED RID: 53485 RVA: 0x003E1C98 File Offset: 0x003DFE98
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

	// Token: 0x17001384 RID: 4996
	// (get) Token: 0x0600D0EE RID: 53486 RVA: 0x003E1CBE File Offset: 0x003DFEBE
	// (set) Token: 0x0600D0EF RID: 53487 RVA: 0x003E1CD0 File Offset: 0x003DFED0
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

	// Token: 0x0600D0F0 RID: 53488 RVA: 0x003E1CD9 File Offset: 0x003DFED9
	public void SetItemNeedCount(int? itemNeedCount)
	{
		this.ItemNeedCount = itemNeedCount;
	}

	// Token: 0x0600D0F1 RID: 53489 RVA: 0x003E1CE2 File Offset: 0x003DFEE2
	public int? GetItemNeedCount()
	{
		return this.ItemNeedCount;
	}

	// Token: 0x0600D0F2 RID: 53490 RVA: 0x003E1CEA File Offset: 0x003DFEEA
	protected override bool OnInit()
	{
		if (InventoryConfig.Instance.GetAllMainTypeConfig().Count <= 0)
		{
			return false;
		}
		this.SetSelectedTypeIndex(0);
		return true;
	}

	// Token: 0x0600D0F3 RID: 53491 RVA: 0x003E1D08 File Offset: 0x003DFF08
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

	// Token: 0x0600D0F4 RID: 53492 RVA: 0x003E1D78 File Offset: 0x003DFF78
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

	// Token: 0x0600D0F5 RID: 53493 RVA: 0x003E1F60 File Offset: 0x003E0160
	public void SetInventoryTabOpenIdList(List<int> idList)
	{
		this.InventoryTabOpenIdList = idList;
	}

	// Token: 0x0600D0F6 RID: 53494 RVA: 0x003E1F69 File Offset: 0x003E0169
	public List<ItemMainType> GetOpenIdMainTypeConfig()
	{
		return this.CurrentProxy.GetOpenIdMainTypeConfig();
	}

	// Token: 0x0600D0F7 RID: 53495 RVA: 0x003E1F78 File Offset: 0x003E0178
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

	// Token: 0x0600D0F8 RID: 53496 RVA: 0x003E2024 File Offset: 0x003E0224
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

	// Token: 0x0600D0F9 RID: 53497 RVA: 0x003E2080 File Offset: 0x003E0280
	public bool IsResourceOrMaterialTab()
	{
		InventoryDefine.EItemMainTypeId? currentMainTypeId = this.GetCurrentMainTypeId();
		return currentMainTypeId.GetValueOrDefault() == InventoryDefine.EItemMainTypeId.Material || currentMainTypeId.GetValueOrDefault() == InventoryDefine.EItemMainTypeId.Collection;
	}

	// Token: 0x0600D0FA RID: 53498 RVA: 0x003E20AC File Offset: 0x003E02AC
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

	// Token: 0x0600D0FB RID: 53499 RVA: 0x003E20F8 File Offset: 0x003E02F8
	private void RemoveFromItemTypeMap(ItemDataBase itemDataBase)
	{
		InventoryDefine.EItemType? type = itemDataBase.GetType();
		HashSet<ItemDataBase> hashSet;
		if (this.ItemTypeMap.TryGetValue(type.Value, out hashSet))
		{
			hashSet.Remove(itemDataBase);
		}
	}

	// Token: 0x0600D0FC RID: 53500 RVA: 0x003E212A File Offset: 0x003E032A
	private void ClearFromItemTypeMap(InventoryDefine.EItemType itemType)
	{
		this.ItemTypeMap.Remove(itemType);
	}

	// Token: 0x0600D0FD RID: 53501 RVA: 0x003E213C File Offset: 0x003E033C
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

	// Token: 0x0600D0FE RID: 53502 RVA: 0x003E2190 File Offset: 0x003E0390
	private void RemoveFromItemMainTypeMap(ItemDataBase itemDataBase)
	{
		InventoryDefine.EItemMainTypeId? mainType = itemDataBase.GetMainType();
		global::ItemMainTypeMapping itemMainTypeMapping;
		if (this.ItemMainTypeMap.TryGetValue(mainType.Value, out itemMainTypeMapping))
		{
			itemMainTypeMapping.Remove(itemDataBase);
		}
	}

	// Token: 0x0600D0FF RID: 53503 RVA: 0x003E21C1 File Offset: 0x003E03C1
	private void ClearFromItemMainTypeMap(InventoryDefine.EItemMainTypeId itemMainType)
	{
		this.ItemMainTypeMap.Remove(itemMainType);
	}

	// Token: 0x0600D100 RID: 53504 RVA: 0x003E21D0 File Offset: 0x003E03D0
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

	// Token: 0x0600D101 RID: 53505 RVA: 0x003E221C File Offset: 0x003E041C
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

	// Token: 0x0600D102 RID: 53506 RVA: 0x003E224F File Offset: 0x003E044F
	private void ClearFromCommonItemByItemTypeMap(InventoryDefine.EItemType itemType)
	{
		this.CommonItemByItemTypeMap.Remove(itemType);
	}

	// Token: 0x0600D103 RID: 53507 RVA: 0x003E2260 File Offset: 0x003E0460
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

	// Token: 0x0600D104 RID: 53508 RVA: 0x003E22D0 File Offset: 0x003E04D0
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

	// Token: 0x0600D105 RID: 53509 RVA: 0x003E232C File Offset: 0x003E052C
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

	// Token: 0x0600D106 RID: 53510 RVA: 0x003E23C8 File Offset: 0x003E05C8
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

	// Token: 0x0600D107 RID: 53511 RVA: 0x003E24A8 File Offset: 0x003E06A8
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

	// Token: 0x0600D108 RID: 53512 RVA: 0x003E24F8 File Offset: 0x003E06F8
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

	// Token: 0x0600D109 RID: 53513 RVA: 0x003E2530 File Offset: 0x003E0730
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

	// Token: 0x0600D10A RID: 53514 RVA: 0x003E25AC File Offset: 0x003E07AC
	public List<ItemDataBase> GetItemDataBaseByConfigId(int configId)
	{
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(configId));
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.WeaponItem)
		{
			return new List<ItemDataBase>(this.GetAllWeaponItemDataByConfigId(configId));
		}
		if (itemDataTypeByConfigId != InventoryDefine.EItemDataType.PhantomItem)
		{
			return new List<ItemDataBase>(this.GetAllCommonItemDataByConfigId(configId));
		}
		return new List<ItemDataBase>(this.GetAllPhantomItemDataByConfigId(configId));
	}

	// Token: 0x0600D10B RID: 53515 RVA: 0x003E25FC File Offset: 0x003E07FC
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

	// Token: 0x0600D10C RID: 53516 RVA: 0x003E2660 File Offset: 0x003E0860
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

	// Token: 0x0600D10D RID: 53517 RVA: 0x003E26C4 File Offset: 0x003E08C4
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

	// Token: 0x0600D10E RID: 53518 RVA: 0x003E2740 File Offset: 0x003E0940
	public int GetCommonItemCount(int configId, int uniqueId = 0)
	{
		return this.CurrentProxy.GetCommonItemCount(configId, uniqueId);
	}

	// Token: 0x0600D10F RID: 53519 RVA: 0x003E2750 File Offset: 0x003E0950
	public int GetCommonItemCountBase(int configId, int uniqueId = 0)
	{
		CommonItemData commonItemData = this.GetCommonItemData(configId, uniqueId);
		if (commonItemData == null)
		{
			return 0;
		}
		return commonItemData.GetCount();
	}

	// Token: 0x0600D110 RID: 53520 RVA: 0x003E2774 File Offset: 0x003E0974
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

	// Token: 0x0600D111 RID: 53521 RVA: 0x003E27B8 File Offset: 0x003E09B8
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

	// Token: 0x0600D112 RID: 53522 RVA: 0x003E27F4 File Offset: 0x003E09F4
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

	// Token: 0x0600D113 RID: 53523 RVA: 0x003E285C File Offset: 0x003E0A5C
	[NullableContext(2)]
	public WeaponItemData GetWeaponItemData(int uniqueId)
	{
		WeaponItemData result;
		this.WeaponItemMap.TryGetValue(uniqueId, out result);
		return result;
	}

	// Token: 0x0600D114 RID: 53524 RVA: 0x003E287C File Offset: 0x003E0A7C
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

	// Token: 0x0600D115 RID: 53525 RVA: 0x003E28D8 File Offset: 0x003E0AD8
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

	// Token: 0x0600D116 RID: 53526 RVA: 0x003E2998 File Offset: 0x003E0B98
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

	// Token: 0x0600D117 RID: 53527 RVA: 0x003E29D4 File Offset: 0x003E0BD4
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

	// Token: 0x0600D118 RID: 53528 RVA: 0x003E2A3C File Offset: 0x003E0C3C
	public void RemovePhantomItemDataAndNotify(IReadOnlyList<int> phantomUniqueIdList, string reason = "")
	{
		this.RemovePhantomItemDataAndSaveNewList(phantomUniqueIdList);
		EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.OnRemovePhantomItem, phantomUniqueIdList);
	}

	// Token: 0x0600D119 RID: 53529 RVA: 0x003E2A58 File Offset: 0x003E0C58
	[NullableContext(2)]
	public PhantomItemData GetPhantomItemData(int uniqueId)
	{
		PhantomItemData result;
		this.PhantomItemMap.TryGetValue(uniqueId, out result);
		return result;
	}

	// Token: 0x0600D11A RID: 53530 RVA: 0x003E2A78 File Offset: 0x003E0C78
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

	// Token: 0x0600D11B RID: 53531 RVA: 0x003E2ABC File Offset: 0x003E0CBC
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

	// Token: 0x0600D11C RID: 53532 RVA: 0x003E2B00 File Offset: 0x003E0D00
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

	// Token: 0x0600D11D RID: 53533 RVA: 0x003E2BC8 File Offset: 0x003E0DC8
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

	// Token: 0x0600D11E RID: 53534 RVA: 0x003E2C4C File Offset: 0x003E0E4C
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

	// Token: 0x0600D11F RID: 53535 RVA: 0x003E2CD0 File Offset: 0x003E0ED0
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

	// Token: 0x0600D120 RID: 53536 RVA: 0x003E2D54 File Offset: 0x003E0F54
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

	// Token: 0x0600D121 RID: 53537 RVA: 0x003E2DD8 File Offset: 0x003E0FD8
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

	// Token: 0x0600D122 RID: 53538 RVA: 0x003E2E24 File Offset: 0x003E1024
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

	// Token: 0x0600D123 RID: 53539 RVA: 0x003E2E54 File Offset: 0x003E1054
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

	// Token: 0x0600D124 RID: 53540 RVA: 0x003E2EC0 File Offset: 0x003E10C0
	public List<PhantomItemData> GetPhantomItemDataList()
	{
		List<PhantomItemData> list = new List<PhantomItemData>();
		foreach (PhantomItemData item in this.PhantomItemMap.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0600D125 RID: 53541 RVA: 0x003E2F20 File Offset: 0x003E1120
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

	// Token: 0x0600D126 RID: 53542 RVA: 0x003E2F8C File Offset: 0x003E118C
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

	// Token: 0x0600D127 RID: 53543 RVA: 0x003E2FF4 File Offset: 0x003E11F4
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

	// Token: 0x0600D128 RID: 53544 RVA: 0x003E3054 File Offset: 0x003E1254
	public PhantomItemData GetPhantomItemDataByPhantomItem(Aki.Protocol.PhantomItem data)
	{
		PhantomItemData phantomItemData = new PhantomItemData(data.Id, data.IncrId, data.FuncValue, InventoryDefine.EItemDataType.PhantomItem);
		phantomItemData.SetFetterGroupId(data.FetterGroupId);
		return phantomItemData;
	}

	// Token: 0x0600D129 RID: 53545 RVA: 0x003E307C File Offset: 0x003E127C
	public List<PhantomItemData> GetPhantomItemDataListByAddCountItemInfo(IEnumerable<AddCountItemInfo> items)
	{
		List<PhantomItemData> list = new List<PhantomItemData>();
		foreach (AddCountItemInfo addCountItemInfo in items)
		{
			PhantomItemData item = new PhantomItemData(addCountItemInfo.Id, addCountItemInfo.IncrId, 0, InventoryDefine.EItemDataType.PhantomItem);
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0600D12A RID: 53546 RVA: 0x003E30E0 File Offset: 0x003E12E0
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

	// Token: 0x0600D12B RID: 53547 RVA: 0x003E3180 File Offset: 0x003E1380
	public List<CommonItemData> GetCommonItemByItemType(InventoryDefine.EItemType itemType)
	{
		HashSet<CommonItemData> hashSet;
		if (!this.CommonItemByItemTypeMap.TryGetValue(itemType, out hashSet))
		{
			return new List<CommonItemData>();
		}
		List<CommonItemData> list = new List<CommonItemData>();
		foreach (CommonItemData commonItemData in hashSet)
		{
			if (commonItemData.IsValid())
			{
				list.Add(commonItemData);
			}
		}
		return list;
	}

	// Token: 0x0600D12C RID: 53548 RVA: 0x003E31F4 File Offset: 0x003E13F4
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

	// Token: 0x0600D12D RID: 53549 RVA: 0x003E32A4 File Offset: 0x003E14A4
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

	// Token: 0x0600D12E RID: 53550 RVA: 0x003E3320 File Offset: 0x003E1520
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

	// Token: 0x0600D12F RID: 53551 RVA: 0x003E33A0 File Offset: 0x003E15A0
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

	// Token: 0x0600D130 RID: 53552 RVA: 0x003E33D8 File Offset: 0x003E15D8
	[NullableContext(2)]
	public global::ItemMainTypeMapping GetItemMainTypeMapping(InventoryDefine.EItemMainTypeId mainType)
	{
		global::ItemMainTypeMapping result;
		this.ItemMainTypeMap.TryGetValue(mainType, out result);
		return result;
	}

	// Token: 0x0600D131 RID: 53553 RVA: 0x003E33F5 File Offset: 0x003E15F5
	public HashSet<ItemDataBase> GetItemDataBaseByMainType(InventoryDefine.EItemMainTypeId mainType)
	{
		return this.CurrentProxy.GetItemDataBaseByMainType(mainType);
	}

	// Token: 0x0600D132 RID: 53554 RVA: 0x003E3404 File Offset: 0x003E1604
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

	// Token: 0x0600D133 RID: 53555 RVA: 0x003E347C File Offset: 0x003E167C
	public int GetInventoryItemGridCountByMainType(InventoryDefine.EItemMainTypeId mainType)
	{
		return this.CurrentProxy.GetInventoryItemGridCountByMainType(mainType);
	}

	// Token: 0x0600D134 RID: 53556 RVA: 0x003E348C File Offset: 0x003E168C
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

	// Token: 0x0600D135 RID: 53557 RVA: 0x003E352C File Offset: 0x003E172C
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

	// Token: 0x0600D136 RID: 53558 RVA: 0x003E359C File Offset: 0x003E179C
	private Dictionary<int, WeaponItemData>.ValueCollection GetAllWeaponItemDataIterator()
	{
		return this.WeaponItemMap.Values;
	}

	// Token: 0x0600D137 RID: 53559 RVA: 0x003E35A9 File Offset: 0x003E17A9
	public Dictionary<int, PhantomItemData>.ValueCollection GetAllPhantomItemDataIterator()
	{
		return this.PhantomItemMap.Values;
	}

	// Token: 0x0600D138 RID: 53560 RVA: 0x003E35B6 File Offset: 0x003E17B6
	[NullableContext(2)]
	public void SetSelectedItemViewData(global::ItemViewData itemViewData)
	{
		this.SelectedItemViewData = itemViewData;
	}

	// Token: 0x0600D139 RID: 53561 RVA: 0x003E35BF File Offset: 0x003E17BF
	public void SetCurrentLockItemUniqueId(int uniqueId)
	{
		this.CurrentLockItemUniqueId = uniqueId;
	}

	// Token: 0x0600D13A RID: 53562 RVA: 0x003E35C8 File Offset: 0x003E17C8
	[NullableContext(2)]
	public global::ItemViewData GetSelectedItemData()
	{
		return this.SelectedItemViewData;
	}

	// Token: 0x17001385 RID: 4997
	// (get) Token: 0x0600D13B RID: 53563 RVA: 0x003E35D0 File Offset: 0x003E17D0
	public int GetCurrentLockItemUniqueId
	{
		get
		{
			return this.CurrentLockItemUniqueId;
		}
	}

	// Token: 0x0600D13C RID: 53564 RVA: 0x003E35D8 File Offset: 0x003E17D8
	public void SetSelectedTypeIndex(int index)
	{
		this.CurrentProxy.SetSelectedTypeIndex(index);
	}

	// Token: 0x0600D13D RID: 53565 RVA: 0x003E35E6 File Offset: 0x003E17E6
	public int GetSelectedTypeIndex()
	{
		return this.CurrentProxy.GetSelectedTypeIndex();
	}

	// Token: 0x0600D13E RID: 53566 RVA: 0x003E35F3 File Offset: 0x003E17F3
	public void SetOutsideUniqueId(int uniqueId)
	{
		this.OutsideUniqueId = new int?(uniqueId);
	}

	// Token: 0x0600D13F RID: 53567 RVA: 0x003E3601 File Offset: 0x003E1801
	public int? GetOutsideUniqueId()
	{
		return this.OutsideUniqueId;
	}

	// Token: 0x0600D140 RID: 53568 RVA: 0x003E3609 File Offset: 0x003E1809
	public void ClearOutsideUniqueId()
	{
		this.OutsideUniqueId = null;
	}

	// Token: 0x0600D141 RID: 53569 RVA: 0x003E3617 File Offset: 0x003E1817
	public int GetItemCountByConfigId(int itemConfigId, int uniqueId = 0)
	{
		return this.CurrentProxy.GetItemCountByConfigId(itemConfigId, uniqueId);
	}

	// Token: 0x0600D142 RID: 53570 RVA: 0x003E3628 File Offset: 0x003E1828
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

	// Token: 0x0600D143 RID: 53571 RVA: 0x003E3790 File Offset: 0x003E1990
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

	// Token: 0x0600D144 RID: 53572 RVA: 0x003E38A8 File Offset: 0x003E1AA8
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

	// Token: 0x0600D145 RID: 53573 RVA: 0x003E3904 File Offset: 0x003E1B04
	private int GetRogueCurrencyItemCount(int configId)
	{
		return RoguelikeModel.Instance.GetRoguelikeInventoryCurrency(configId);
	}

	// Token: 0x0600D146 RID: 53574 RVA: 0x003E3911 File Offset: 0x003E1B11
	private int GetRogueResCurrencyItemCount(int configId)
	{
		return ActivityPermanentRogueModel.Instance.GetCurrency(configId);
	}

	// Token: 0x0600D147 RID: 53575 RVA: 0x003E391E File Offset: 0x003E1B1E
	private int GetRoverRogueCurrencyItemCount(int configId)
	{
		return RoverlikeModel.Instance.GetCurrency(configId);
	}

	// Token: 0x0600D148 RID: 53576 RVA: 0x003E392B File Offset: 0x003E1B2B
	private int GetWeaponSkinCount(int configId)
	{
		return WeaponSkinModel.Instance.GetSkinCountById(configId);
	}

	// Token: 0x0600D149 RID: 53577 RVA: 0x003E3938 File Offset: 0x003E1B38
	private int GetRoleSkinCount(int configId)
	{
		return RoleSkinModel.Instance.GetSkinCountById(configId);
	}

	// Token: 0x0600D14A RID: 53578 RVA: 0x003E3945 File Offset: 0x003E1B45
	private int GetFlySkinCount(int configId)
	{
		return FlySkinModel.Instance.GetFlySkinItemCount(configId);
	}

	// Token: 0x0600D14B RID: 53579 RVA: 0x003E3954 File Offset: 0x003E1B54
	private int GetMotorSkinCount(int configId)
	{
		EOutLookState stickerState = MotorcycleDiyModel.Instance.GetStickerState(configId);
		if (stickerState == EOutLookState.IsEquipped || stickerState == EOutLookState.CanEquipped)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x0600D14C RID: 53580 RVA: 0x003E3978 File Offset: 0x003E1B78
	private int GetOwnedMotorSkinCount(int configId)
	{
		return (MotorcycleDiyModel.Instance.HasSkin(configId) > false) ? 1 : 0;
	}

	// Token: 0x0600D14D RID: 53581 RVA: 0x003E3988 File Offset: 0x003E1B88
	private int GetPhantomArenaCardCount(int configId)
	{
		if (!PhantomArenaModel.Instance.IsCardUnlock(configId))
		{
			return 0;
		}
		return PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(configId).CardGroupNum;
	}

	// Token: 0x0600D14E RID: 53582 RVA: 0x003E39B7 File Offset: 0x003E1BB7
	private int GetCalabashSkinCount(int configId)
	{
		return CalabashSkinModel.Instance.GetSkinCountById(configId);
	}

	// Token: 0x0600D14F RID: 53583 RVA: 0x003E39C4 File Offset: 0x003E1BC4
	private int GetFurnitureItemCount(int configId)
	{
		return (FurnitureModel.Instance.GetIsFurnitureUnlockById(configId) > false) ? 1 : 0;
	}

	// Token: 0x0600D150 RID: 53584 RVA: 0x003E39D4 File Offset: 0x003E1BD4
	private int GetOrnamentItemCount(int configId)
	{
		return RoleOrnamentModel.Instance.GetOrnamentCountById(configId);
	}

	// Token: 0x0600D151 RID: 53585 RVA: 0x003E39E1 File Offset: 0x003E1BE1
	private int GetPinballRoleItemCount(int configId)
	{
		return 0;
	}

	// Token: 0x0600D152 RID: 53586 RVA: 0x003E39E4 File Offset: 0x003E1BE4
	private int GetPinballWeaponItemCount(int configId)
	{
		return 0;
	}

	// Token: 0x0600D153 RID: 53587 RVA: 0x003E39E8 File Offset: 0x003E1BE8
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

	// Token: 0x0600D154 RID: 53588 RVA: 0x003E3A44 File Offset: 0x003E1C44
	private int GetPlayerHeadItemCount(int configId)
	{
		PlayerHeadData playerHeadData = PersonalModel.Instance.GetPlayerHeadData(configId, true);
		if (playerHeadData != null && !playerHeadData.Lock)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x0600D155 RID: 53589 RVA: 0x003E3A6C File Offset: 0x003E1C6C
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

	// Token: 0x0600D156 RID: 53590 RVA: 0x003E3AB3 File Offset: 0x003E1CB3
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

	// Token: 0x0600D157 RID: 53591 RVA: 0x003E3AEF File Offset: 0x003E1CEF
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

	// Token: 0x0600D158 RID: 53592 RVA: 0x003E3B20 File Offset: 0x003E1D20
	public bool RemoveNewCommonItem(int configId, int uniqueId = 0)
	{
		if (uniqueId != 0)
		{
			return this.RemoveNewAttributeItem(uniqueId);
		}
		return NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.InventoryCommonItem, configId);
	}

	// Token: 0x0600D159 RID: 53593 RVA: 0x003E3B39 File Offset: 0x003E1D39
	public bool RemoveNewAttributeItem(int uniqueId)
	{
		return NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.InventoryAttributeItem, uniqueId);
	}

	// Token: 0x0600D15A RID: 53594 RVA: 0x003E3B47 File Offset: 0x003E1D47
	public bool SaveNewCommonItemConfigIdList()
	{
		return NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.InventoryCommonItem);
	}

	// Token: 0x0600D15B RID: 53595 RVA: 0x003E3B54 File Offset: 0x003E1D54
	public bool SaveNewAttributeItemUniqueIdList()
	{
		return NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.InventoryAttributeItem);
	}

	// Token: 0x0600D15C RID: 53596 RVA: 0x003E3B61 File Offset: 0x003E1D61
	public bool IsNewCommonItem(int configId, int uniqueId = 0)
	{
		if (uniqueId != 0)
		{
			return this.IsNewAttributeItem(uniqueId);
		}
		return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.InventoryCommonItem, configId);
	}

	// Token: 0x0600D15D RID: 53597 RVA: 0x003E3B7A File Offset: 0x003E1D7A
	public bool IsNewAttributeItem(int uniqueId)
	{
		return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.InventoryAttributeItem, uniqueId);
	}

	// Token: 0x0600D15E RID: 53598 RVA: 0x003E3B88 File Offset: 0x003E1D88
	[NullableContext(2)]
	public HashSet<int> GetNewAttributeItemUniqueIdList()
	{
		return NewFlagModel.Instance.GetNewFlagSet(ELocalStoragePlayerKey.InventoryAttributeItem);
	}

	// Token: 0x0600D15F RID: 53599 RVA: 0x003E3B98 File Offset: 0x003E1D98
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

	// Token: 0x0600D160 RID: 53600 RVA: 0x003E3BEC File Offset: 0x003E1DEC
	private void TryAddCommonItemServerFirstSelectRedDot(int itemId)
	{
		ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ItemBackpackFirstCheck) as ServerStorageMap;
		if (serverStorageMap.Has(itemId))
		{
			return;
		}
		serverStorageMap.Set(itemId, 1);
	}

	// Token: 0x0600D161 RID: 53601 RVA: 0x003E3C20 File Offset: 0x003E1E20
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

	// Token: 0x0600D162 RID: 53602 RVA: 0x003E3C5C File Offset: 0x003E1E5C
	public bool HasCommonItemServerFirstSelectRedDot(int itemId)
	{
		ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ItemBackpackFirstCheck) as ServerStorageMap;
		return serverStorageMap != null && serverStorageMap.Get(itemId).GetValueOrDefault() == 1;
	}

	// Token: 0x0600D163 RID: 53603 RVA: 0x003E3C94 File Offset: 0x003E1E94
	public bool HasAnyCommonItemServerFirstSelectRedDot()
	{
		ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.ItemBackpackFirstCheck) as ServerStorageMap;
		if (serverStorageMap == null)
		{
			return false;
		}
		using (Dictionary<int, int>.ValueCollection.Enumerator enumerator = serverStorageMap.GetContainer().Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == 1)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600D164 RID: 53604 RVA: 0x003E3D08 File Offset: 0x003E1F08
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

	// Token: 0x0600D165 RID: 53605 RVA: 0x003E3D4C File Offset: 0x003E1F4C
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

	// Token: 0x0600D166 RID: 53606 RVA: 0x003E3D95 File Offset: 0x003E1F95
	public bool IsMainTypeHasRedDot(InventoryDefine.EItemMainTypeId itemMainType)
	{
		global::ItemMainTypeMapping itemMainTypeMapping = this.GetItemMainTypeMapping(itemMainType);
		return itemMainTypeMapping != null && itemMainTypeMapping.HasRedDot();
	}

	// Token: 0x0600D167 RID: 53607 RVA: 0x003E3DA9 File Offset: 0x003E1FA9
	public bool IsCommonItemHasRedDot(int configId, int uniqueId = 0)
	{
		if (uniqueId != 0)
		{
			return this.IsAttributeItemHasRedDot(uniqueId);
		}
		return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.InventoryCommonItemRedDot, configId) || this.HasCommonItemServerFirstSelectRedDot(configId);
	}

	// Token: 0x0600D168 RID: 53608 RVA: 0x003E3DCD File Offset: 0x003E1FCD
	public bool IsAttributeItemHasRedDot(int uniqueId)
	{
		return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.InventoryAttributeItemRedDot, uniqueId);
	}

	// Token: 0x0600D169 RID: 53609 RVA: 0x003E3DDC File Offset: 0x003E1FDC
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

	// Token: 0x0600D16A RID: 53610 RVA: 0x003E3E1F File Offset: 0x003E201F
	public bool RemoveRedDotAttributeItem(int uniqueId)
	{
		if (!NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.InventoryAttributeItemRedDot, uniqueId))
		{
			return false;
		}
		EventSystem.Instance.Emit(EEventName.OnRemoveItemRedDot);
		return true;
	}

	// Token: 0x0600D16B RID: 53611 RVA: 0x003E3E42 File Offset: 0x003E2042
	public bool SaveRedDotCommonItemConfigIdList()
	{
		return NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.InventoryCommonItemRedDot);
	}

	// Token: 0x0600D16C RID: 53612 RVA: 0x003E3E4F File Offset: 0x003E204F
	public bool SaveRedDotAttributeItemUniqueIdList()
	{
		return NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.InventoryAttributeItemRedDot);
	}

	// Token: 0x0600D16D RID: 53613 RVA: 0x003E3E5C File Offset: 0x003E205C
	[NullableContext(2)]
	public void SetAcquireData(AcquireData acquireData)
	{
		this.CurrentAcquireData = acquireData;
	}

	// Token: 0x0600D16E RID: 53614 RVA: 0x003E3E65 File Offset: 0x003E2065
	[NullableContext(2)]
	public AcquireData GetAcquireData()
	{
		return this.CurrentAcquireData;
	}

	// Token: 0x0600D16F RID: 53615 RVA: 0x003E3E70 File Offset: 0x003E2070
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

	// Token: 0x0600D170 RID: 53616 RVA: 0x003E3ED8 File Offset: 0x003E20D8
	public bool GetPhantomManageConfigClear()
	{
		return this.PhantomManageConfig.Count == 0;
	}

	// Token: 0x0600D171 RID: 53617 RVA: 0x003E3EE8 File Offset: 0x003E20E8
	public List<PhantomManageConfigData> GetPhantomManageConfigByType(PhantomSettingType type)
	{
		if (this.PhantomManageConfig.Count == 0 || !this.PhantomManageConfig.ContainsKey(type))
		{
			Log.Instance.Error(ELogModule.Inventory, ELogAuthor.WDX, "批量管理方案未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<PhantomManageConfigData>();
		}
		return this.PhantomManageConfig[type];
	}

	// Token: 0x0600D172 RID: 53618 RVA: 0x003E3F40 File Offset: 0x003E2140
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

	// Token: 0x0600D173 RID: 53619 RVA: 0x003E3FBC File Offset: 0x003E21BC
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

	// Token: 0x0600D174 RID: 53620 RVA: 0x003E4058 File Offset: 0x003E2258
	public void CoverAllPhantomManageConfig(IEnumerable<PhantomSettingInfo> settingInfoList)
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

	// Token: 0x0600D175 RID: 53621 RVA: 0x003E41B0 File Offset: 0x003E23B0
	public void InitPhantomManageConfig(PhantomSettingResponse response)
	{
		this.PhantomManageConfig.Clear();
		this.InitSettingsByType(PhantomSettingType.AutoLock, new List<OnePhantomSetting>(response.AutoLockSettings));
		this.InitSettingsByType(PhantomSettingType.AutoDisuse, new List<OnePhantomSetting>(response.AutoDisuseSettings));
	}

	// Token: 0x0600D176 RID: 53622 RVA: 0x003E41E4 File Offset: 0x003E23E4
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

	// Token: 0x0600D177 RID: 53623 RVA: 0x003E423C File Offset: 0x003E243C
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

	// Token: 0x0600D178 RID: 53624 RVA: 0x003E429C File Offset: 0x003E249C
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

	// Token: 0x0600D179 RID: 53625 RVA: 0x003E4318 File Offset: 0x003E2518
	public int GetFilterIdConst()
	{
		return ConfigCommonParamById.GetIntConfig("PhantomAutoLockFilterId").GetValueOrDefault();
	}

	// Token: 0x0600D17A RID: 53626 RVA: 0x003E4338 File Offset: 0x003E2538
	public int GetConfigMaxCountConst()
	{
		return ConfigCommonParamById.GetIntConfig("PhantomSettingFilterMaxCount").GetValueOrDefault(10);
	}

	// Token: 0x0600D17B RID: 53627 RVA: 0x003E435C File Offset: 0x003E255C
	public InventoryDefine.ESettingGridType GetGridTypeByFilterRuleId(int filterRuleId)
	{
		InventoryDefine.ESettingGridType result = InventoryDefine.ESettingGridType.Small;
		InventoryDefine.recFilterRuleToGirdType.TryGetValue((FilterDefine.EFilterType)filterRuleId, out result);
		return result;
	}

	// Token: 0x0600D17C RID: 53628 RVA: 0x003E437C File Offset: 0x003E257C
	[NullableContext(2)]
	public void SetPhantomManageSelectSet(HashSet<int> selectSet)
	{
		this.PhantomManageSelectSet = selectSet;
	}

	// Token: 0x0600D17D RID: 53629 RVA: 0x003E4385 File Offset: 0x003E2585
	[NullableContext(2)]
	public HashSet<int> GetPhantomManageSelectSet()
	{
		return this.PhantomManageSelectSet;
	}

	// Token: 0x0600D17E RID: 53630 RVA: 0x003E438D File Offset: 0x003E258D
	public void SetInventoryDataProxy(InventoryDataProxy proxy)
	{
		this.CurrentProxy = proxy;
	}

	// Token: 0x0600D17F RID: 53631 RVA: 0x003E4396 File Offset: 0x003E2596
	public void ResetInventoryDataProxy()
	{
		this._CurrentProxy = null;
	}

	// Token: 0x0600D180 RID: 53632 RVA: 0x003E439F File Offset: 0x003E259F
	public bool SupportInventoryViewShowCurrency()
	{
		return this.CurrentProxy.SupportShowCurrency();
	}

	// Token: 0x0600D181 RID: 53633 RVA: 0x003E43AC File Offset: 0x003E25AC
	public bool GetInteractiveItemsFunctionEnable()
	{
		return this.InteractiveItemsFunctionEnable;
	}

	// Token: 0x0600D182 RID: 53634 RVA: 0x003E43B4 File Offset: 0x003E25B4
	public void SetInteractiveItemsFunctionEnable(bool enable)
	{
		bool flag = this.InteractiveItemsFunctionEnable != enable;
		this.InteractiveItemsFunctionEnable = enable;
		if (flag)
		{
			EventSystem.Instance.Emit<bool>(EEventName.OnInteractiveItemsFunctionEnableChanged, enable);
		}
	}

	// Token: 0x17001386 RID: 4998
	// (get) Token: 0x0600D183 RID: 53635 RVA: 0x003E43DC File Offset: 0x003E25DC
	public static InventoryModel Instance
	{
		get
		{
			return InventoryModel._Instance;
		}
	}

	// Token: 0x0600D184 RID: 53636 RVA: 0x003E43E3 File Offset: 0x003E25E3
	public static InventoryModel GetOrCreateInstance()
	{
		if (InventoryModel._Instance == null)
		{
			InventoryModel.CreateInstance();
		}
		return InventoryModel._Instance;
	}

	// Token: 0x0600D185 RID: 53637 RVA: 0x003E43F7 File Offset: 0x003E25F7
	public static bool CreateInstance()
	{
		if (InventoryModel._Instance != null)
		{
			return true;
		}
		InventoryModel._Instance = new InventoryModel();
		return true;
	}

	// Token: 0x0600D186 RID: 53638 RVA: 0x003E440D File Offset: 0x003E260D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D187 RID: 53639 RVA: 0x003E440F File Offset: 0x003E260F
	public static void ResetStaticDefaultValue()
	{
		InventoryModel._Instance = null;
	}

	// Token: 0x0600D188 RID: 53640 RVA: 0x003E4417 File Offset: 0x003E2617
	static InventoryModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InventoryModel.CreateStaticDefaultValue), new Action(InventoryModel.ResetStaticDefaultValue));
	}

	// Token: 0x04007655 RID: 30293
	private string CD_TIME_REASON = "限时物品主动添加倒计时 [ConfigId:{0}, UniqueId:{1}]";

	// Token: 0x04007656 RID: 30294
	private int? OutsideUniqueId;

	// Token: 0x04007657 RID: 30295
	private int CurrentLockItemUniqueId;

	// Token: 0x04007658 RID: 30296
	[Nullable(2)]
	private global::ItemViewData SelectedItemViewData;

	// Token: 0x04007659 RID: 30297
	[Nullable(2)]
	private List<int> InventoryTabOpenIdList;

	// Token: 0x0400765A RID: 30298
	[Nullable(2)]
	private NormalInventoryDataProxy _DefaultProxy;

	// Token: 0x0400765B RID: 30299
	[Nullable(2)]
	private InventoryDataProxy _CurrentProxy;

	// Token: 0x0400765C RID: 30300
	private readonly Dictionary<int, Dictionary<int, CommonItemData>> CommonItemMap = new Dictionary<int, Dictionary<int, CommonItemData>>();

	// Token: 0x0400765D RID: 30301
	private readonly Dictionary<int, WeaponItemData> WeaponItemMap = new Dictionary<int, WeaponItemData>();

	// Token: 0x0400765E RID: 30302
	private readonly Dictionary<int, PhantomItemData> PhantomItemMap = new Dictionary<int, PhantomItemData>();

	// Token: 0x0400765F RID: 30303
	private readonly Dictionary<int, CalabashSkinItemData> CalabashSkinItemMap = new Dictionary<int, CalabashSkinItemData>();

	// Token: 0x04007660 RID: 30304
	private readonly Dictionary<int, OrnamentItemData> OrnamentItemMap = new Dictionary<int, OrnamentItemData>();

	// Token: 0x04007661 RID: 30305
	private readonly Dictionary<InventoryDefine.EItemType, HashSet<CommonItemData>> CommonItemByItemTypeMap = new Dictionary<InventoryDefine.EItemType, HashSet<CommonItemData>>();

	// Token: 0x04007662 RID: 30306
	private readonly Dictionary<InventoryDefine.EItemType, HashSet<ItemDataBase>> ItemTypeMap = new Dictionary<InventoryDefine.EItemType, HashSet<ItemDataBase>>();

	// Token: 0x04007663 RID: 30307
	private readonly Dictionary<InventoryDefine.EItemMainTypeId, global::ItemMainTypeMapping> ItemMainTypeMap = new Dictionary<InventoryDefine.EItemMainTypeId, global::ItemMainTypeMapping>();

	// Token: 0x04007664 RID: 30308
	[Nullable(2)]
	private AcquireData CurrentAcquireData;

	// Token: 0x04007665 RID: 30309
	private readonly HashSet<long> CdTimeStampSet = new HashSet<long>();

	// Token: 0x04007666 RID: 30310
	private readonly Dictionary<long, TimerHandle> CdTimeStampHandleMap = new Dictionary<long, TimerHandle>();

	// Token: 0x04007667 RID: 30311
	public bool IsConfirmDestruction;

	// Token: 0x04007668 RID: 30312
	private int? ItemNeedCount;

	// Token: 0x04007669 RID: 30313
	private readonly Dictionary<PhantomSettingType, List<PhantomManageConfigData>> PhantomManageConfig = new Dictionary<PhantomSettingType, List<PhantomManageConfigData>>();

	// Token: 0x0400766A RID: 30314
	[Nullable(2)]
	private HashSet<int> PhantomManageSelectSet;

	// Token: 0x0400766B RID: 30315
	private bool InteractiveItemsFunctionEnable = true;

	// Token: 0x0400766C RID: 30316
	[Nullable(2)]
	private static InventoryModel _Instance;
}

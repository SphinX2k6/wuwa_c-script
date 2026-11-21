using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.LinkedItem;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.PhantomBattle;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001907 RID: 6407
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PhantomBattleModel : ModelBase
{
	// Token: 0x0600FCEC RID: 64748 RVA: 0x0049CD64 File Offset: 0x0049AF64
	public PhantomBattleModel()
	{
		this.RobotDataMap = new Dictionary<int, PhantomBattleData>();
		this.BattleDataMap = new Dictionary<int, PhantomRoleEquipmentData>();
		this.PhantomEquipmentRoleMap = new Dictionary<int, int>();
		this.PhantomInstanceMap = new Dictionary<int, PhantomBattleInstance>();
		this.PhantomBattleDataMap = new Dictionary<int, PhantomBattleData>();
		this.UnEquipVisionArray = new List<PhantomBattleData>();
		this.PhantomMeshZoom = new FVector();
		this.PhantomMeshLocation = new FVector();
		this.PhantomMeshRotator = new FRotator();
		this.LevelUpItemData = new Dictionary<int, int>();
		this.TempSaveItemList = new TItem[0];
		this.CurrentDraggingIndex = 999;
		this.MonsterSkinMap = new Dictionary<int, int[]>();
		this.MonsterSkinMonsterIdMap = new Dictionary<int, int>();
		this.VisionLevelUpMaterialPutInMode = EVisionLevelUpMaterialPutInMode.AllIn;
		this.VisionLevelUpMaterialUseType = EVisionLevelUpMaterialUseType.OnlyLevelUpMaterial;
		this.VisionLevelUpIdentify = EVisionLevelUpIdentify.DisableIdentify;
		this.QualityUnlockTips = new List<VisionUnlockQualityData>();
	}

	// Token: 0x0600FCED RID: 64749 RVA: 0x0049CE3D File Offset: 0x0049B03D
	public void SetCurrentDragIndex(int index)
	{
		this.CurrentDraggingIndex = index;
	}

	// Token: 0x0600FCEE RID: 64750 RVA: 0x0049CE46 File Offset: 0x0049B046
	public void ClearCurrentDragIndex()
	{
		this.CurrentDraggingIndex = 999;
	}

	// Token: 0x0600FCEF RID: 64751 RVA: 0x0049CE53 File Offset: 0x0049B053
	public bool CheckIfCurrentDragIndex(int index)
	{
		return this.CurrentDraggingIndex == index;
	}

	// Token: 0x0600FCF0 RID: 64752 RVA: 0x0049CE5E File Offset: 0x0049B05E
	public bool CheckIfCanDrag()
	{
		return this.CurrentDraggingIndex == 999;
	}

	// Token: 0x0600FCF1 RID: 64753 RVA: 0x0049CE70 File Offset: 0x0049B070
	protected override bool OnInit()
	{
		foreach (Aki.Config.PhantomItem phantomItem in PhantomBattleConfig.Instance.GetPhantomItemList())
		{
			int key = (phantomItem.ParentMonsterId != 0) ? phantomItem.ParentMonsterId : phantomItem.MonsterId;
			int[] collection;
			if (!this.MonsterSkinMap.TryGetValue(key, out collection))
			{
				collection = new int[0];
			}
			if (phantomItem.ParentMonsterId != 0)
			{
				List<int> list = new List<int>(collection);
				list.Add(phantomItem.ItemId);
				this.MonsterSkinMap[key] = list.ToArray();
			}
			else if (phantomItem.PhantomType == 1 && phantomItem.QualityId == 2)
			{
				List<int> list2 = new List<int>();
				list2.Add(phantomItem.ItemId);
				list2.AddRange(collection);
				this.MonsterSkinMap[key] = list2.ToArray();
			}
			if (phantomItem.ParentMonsterId != 0)
			{
				this.MonsterSkinMonsterIdMap[phantomItem.MonsterId] = phantomItem.ParentMonsterId;
			}
		}
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		return true;
	}

	// Token: 0x0600FCF2 RID: 64754 RVA: 0x0049CFA8 File Offset: 0x0049B1A8
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		return true;
	}

	// Token: 0x0600FCF3 RID: 64755 RVA: 0x0049CFC8 File Offset: 0x0049B1C8
	private void OnWorldDone()
	{
		this.VisionLevelUpMaterialPutInMode = LocalStorage.GetPlayer<EVisionLevelUpMaterialPutInMode?>(ELocalStoragePlayerKey.VisionLevelUpMaterialPutInMode, null).GetValueOrDefault();
		this.VisionLevelUpMaterialUseType = LocalStorage.GetPlayer<EVisionLevelUpMaterialUseType?>(ELocalStoragePlayerKey.VisionLevelUpMaterialUseType, null).GetValueOrDefault();
		this.VisionLevelUpIdentify = LocalStorage.GetPlayer<EVisionLevelUpIdentify?>(ELocalStoragePlayerKey.VisionLevelUpIdentify, null).GetValueOrDefault();
	}

	// Token: 0x0600FCF4 RID: 64756 RVA: 0x0049D034 File Offset: 0x0049B234
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<UCurveFloat> GetDragCurve()
	{
		PhantomBattleModel.<GetDragCurve>d__43 <GetDragCurve>d__;
		<GetDragCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder<UCurveFloat>.Create();
		<GetDragCurve>d__.<>4__this = this;
		<GetDragCurve>d__.<>1__state = -1;
		<GetDragCurve>d__.<>t__builder.Start<PhantomBattleModel.<GetDragCurve>d__43>(ref <GetDragCurve>d__);
		return <GetDragCurve>d__.<>t__builder.Task;
	}

	// Token: 0x0600FCF5 RID: 64757 RVA: 0x0049D078 File Offset: 0x0049B278
	public void SetDefaultSkin(int monsterId, int skinId)
	{
		foreach (KeyValuePair<int, PhantomBattleData> keyValuePair in this.PhantomBattleDataMap)
		{
			PhantomBattleData value = keyValuePair.Value;
			if (monsterId == value.GetConfig().MonsterId)
			{
				value.SetSkinId(skinId);
			}
		}
	}

	// Token: 0x0600FCF6 RID: 64758 RVA: 0x0049D0E4 File Offset: 0x0049B2E4
	public void SetUnlockSkinList(int[] skins)
	{
		this.UnlockSkin = skins;
	}

	// Token: 0x0600FCF7 RID: 64759 RVA: 0x0049D0F0 File Offset: 0x0049B2F0
	public void ConcatUnlockSkinList(IEnumerable<int> skins)
	{
		List<int> list = new List<int>(this.UnlockSkin);
		list.AddRange(skins);
		this.UnlockSkin = list.ToArray();
	}

	// Token: 0x0600FCF8 RID: 64760 RVA: 0x0049D11C File Offset: 0x0049B31C
	public bool GetSkinIsUnlock(int skinId)
	{
		return this.UnlockSkin != null && Array.IndexOf<int>(this.UnlockSkin, skinId) >= 0;
	}

	// Token: 0x0600FCF9 RID: 64761 RVA: 0x0049D13C File Offset: 0x0049B33C
	[NullableContext(2)]
	public int[] GetMonsterSkinListByMonsterId(int monsterId)
	{
		int[] array;
		if (this.MonsterSkinMap.TryGetValue(monsterId, out array))
		{
			return Array.FindAll<int>(array, (int skinId) => !LinkedItemConfig.Instance.ShouldHide(skinId, this.GetSkinIsUnlock(skinId)));
		}
		return null;
	}

	// Token: 0x0600FCFA RID: 64762 RVA: 0x0049D170 File Offset: 0x0049B370
	public bool GetMonsterSkinListHasNew(int itemId)
	{
		Aki.Config.PhantomItem? phantomItemById = PhantomBattleConfig.Instance.GetPhantomItemById(itemId);
		if (phantomItemById == null)
		{
			return false;
		}
		int key = (phantomItemById.Value.ParentMonsterId != 0) ? phantomItemById.Value.ParentMonsterId : phantomItemById.Value.MonsterId;
		int[] array;
		if (!this.MonsterSkinMap.TryGetValue(key, out array))
		{
			return false;
		}
		foreach (int value in array)
		{
			if (NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.VisionSkin, value))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600FCFB RID: 64763 RVA: 0x0049D208 File Offset: 0x0049B408
	public int? GetMonsterSkinMonsterIdMapByMonsterId(int monsterId)
	{
		int value;
		if (this.MonsterSkinMonsterIdMap.TryGetValue(monsterId, out value))
		{
			return new int?(value);
		}
		return null;
	}

	// Token: 0x0600FCFC RID: 64764 RVA: 0x0049D235 File Offset: 0x0049B435
	public void SetMaxCost(int cost)
	{
		this.CurrentMaxCost = cost;
	}

	// Token: 0x0600FCFD RID: 64765 RVA: 0x0049D23E File Offset: 0x0049B43E
	public int GetMaxCost()
	{
		return this.CurrentMaxCost;
	}

	// Token: 0x0600FCFE RID: 64766 RVA: 0x0049D246 File Offset: 0x0049B446
	public void SetRobotPhantomData(int incrId, PhantomTrialBattleData data)
	{
		this.RobotDataMap[incrId] = data;
	}

	// Token: 0x0600FCFF RID: 64767 RVA: 0x0049D258 File Offset: 0x0049B458
	public PhantomBattleData NewPhantomBattleData(Aki.Protocol.PhantomItem phantomItemInfo)
	{
		PhantomBattleData phantomBattleData = new PhantomBattleData();
		phantomBattleData.SetData(phantomItemInfo);
		this.PhantomBattleDataMap[phantomItemInfo.IncrId] = phantomBattleData;
		this.UnEquipVisionArrayRefreshTag = true;
		return phantomBattleData;
	}

	// Token: 0x0600FD00 RID: 64768 RVA: 0x0049D28C File Offset: 0x0049B48C
	[return: Nullable(2)]
	public PhantomBattleData UpdatePhantomBattleData(Aki.Protocol.PhantomItem phantomItemInfo)
	{
		this.RemovePhantomBattleData(phantomItemInfo.IncrId);
		if (PhantomStackUtil.IsUpdateInfoRemoved(phantomItemInfo))
		{
			return null;
		}
		PhantomBattleData phantomBattleData = new PhantomBattleData();
		phantomBattleData.SetData(phantomItemInfo);
		this.PhantomBattleDataMap[phantomItemInfo.IncrId] = phantomBattleData;
		this.UnEquipVisionArrayRefreshTag = true;
		return phantomBattleData;
	}

	// Token: 0x0600FD01 RID: 64769 RVA: 0x0049D2D6 File Offset: 0x0049B4D6
	public void RemovePhantomBattleData(int uniqueId)
	{
		this.PhantomBattleDataMap.Remove(uniqueId);
		this.UnEquipVisionArrayRefreshTag = true;
	}

	// Token: 0x0600FD02 RID: 64770 RVA: 0x0049D2EC File Offset: 0x0049B4EC
	[NullableContext(2)]
	public PhantomDataBase GetPhantomDataBase(int uniqueId)
	{
		return this.GetPhantomBattleData(uniqueId);
	}

	// Token: 0x0600FD03 RID: 64771 RVA: 0x0049D2F8 File Offset: 0x0049B4F8
	[NullableContext(2)]
	public PhantomBattleData GetPhantomBattleData(int uniqueId)
	{
		if (uniqueId < 0)
		{
			PhantomBattleData result;
			if (this.RobotDataMap.TryGetValue(uniqueId, out result))
			{
				return result;
			}
			return null;
		}
		else
		{
			PhantomBattleData result2;
			if (this.PhantomBattleDataMap.TryGetValue(uniqueId, out result2))
			{
				return result2;
			}
			return null;
		}
	}

	// Token: 0x0600FD04 RID: 64772 RVA: 0x0049D330 File Offset: 0x0049B530
	public PhantomBattleInstance GetPhantomInstanceByItemId(int itemId)
	{
		PhantomBattleInstance phantomBattleInstance;
		if (!this.PhantomInstanceMap.TryGetValue(itemId, out phantomBattleInstance))
		{
			phantomBattleInstance = new PhantomBattleInstance(PhantomBattleConfig.Instance.GetPhantomItemById(itemId).Value);
			this.PhantomInstanceMap[itemId] = phantomBattleInstance;
		}
		return phantomBattleInstance;
	}

	// Token: 0x0600FD05 RID: 64773 RVA: 0x0049D374 File Offset: 0x0049B574
	public LevelUpPastVisionData CreatePhantomLevelCacheData(int incId)
	{
		return new LevelUpPastVisionData
		{
			Level = this.GetPhantomBattleData(incId).GetPhantomLevel(),
			AttrListScrollData = this.GetPhantomBattleData(incId).GetMainPropShowAttributeList(CommonComponentDefine.EAttributeType.PhantomType, false),
			SlotData = this.GetPhantomBattleData(incId).GetCurrentSlotData(),
			UniqueId = incId,
			SubProp = this.GetPhantomBattleData(incId).GetPhantomSubProp()
		};
	}

	// Token: 0x0600FD06 RID: 64774 RVA: 0x0049D3D7 File Offset: 0x0049B5D7
	public void CachePhantomLevelUpData(LevelUpPastVisionData data)
	{
		this.PastVisionLevelUpData = data;
	}

	// Token: 0x0600FD07 RID: 64775 RVA: 0x0049D3E0 File Offset: 0x0049B5E0
	[NullableContext(2)]
	public LevelUpPastVisionData GetCachePhantomLevelUpData()
	{
		return this.PastVisionLevelUpData;
	}

	// Token: 0x0600FD08 RID: 64776 RVA: 0x0049D3E8 File Offset: 0x0049B5E8
	public ILevelUpSuccessAttributeData GetLevelUpSuccessData(int uniqueId)
	{
		ILevelInfo levelInfo = null;
		LevelUpPastVisionData cachePhantomLevelUpData = PhantomBattleModel.Instance.GetCachePhantomLevelUpData();
		List<IAttributeInfo> list = new List<IAttributeInfo>();
		bool value = PhantomBattleModel.Instance.CheckPhantomIfLevelMax(uniqueId);
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(uniqueId);
		if (cachePhantomLevelUpData.Level != phantomItemDataByUniqueId.GetPhantomLevel())
		{
			foreach (AttrListScrollData attrData in this.GetLevelUpSuccessAttributeData(cachePhantomLevelUpData, phantomItemDataByUniqueId))
			{
				list.Add(RoleLevelUpSuccessController.ConvertsAttrListScrollDataToAttributeInfo(attrData));
			}
			levelInfo = new LevelInfo
			{
				PreUpgradeLv = cachePhantomLevelUpData.Level,
				UpgradeLv = phantomItemDataByUniqueId.GetPhantomLevel(),
				FormatStringId = "VisionLevel",
				IsMaxLevel = new bool?(value)
			};
		}
		string title = null;
		int count = cachePhantomLevelUpData.SubProp.Count;
		int count2 = phantomItemDataByUniqueId.GetPhantomSubProp().Count;
		List<AttrListScrollData> subPropShowAttributeList = phantomItemDataByUniqueId.GetSubPropShowAttributeList(CommonComponentDefine.EAttributeType.PhantomType);
		List<AttrListScrollData> list2 = new List<AttrListScrollData>();
		for (int j = count; j < count2; j++)
		{
			subPropShowAttributeList[j].AddValue = subPropShowAttributeList[j].BaseValue;
			subPropShowAttributeList[j].BaseValue = 0.0;
			list2.Add(subPropShowAttributeList[j]);
		}
		int levelUnlockSubPropSlotCount = phantomItemDataByUniqueId.GetLevelUnlockSubPropSlotCount(cachePhantomLevelUpData.Level);
		int num = phantomItemDataByUniqueId.GetLevelUnlockSubPropSlotCount(phantomItemDataByUniqueId.GetPhantomLevel()) - levelUnlockSubPropSlotCount - list2.Count;
		if (list2.Count > 0 || num > 0)
		{
			list.Add(new AttributeInfo
			{
				IsLine = new bool?(true)
			});
		}
		foreach (AttrListScrollData attrData2 in list2)
		{
			IAttributeInfo attributeInfo = RoleLevelUpSuccessController.ConvertsAttrListScrollDataToAttributeInfo(attrData2);
			attributeInfo.ShowArrow = new bool?(false);
			attributeInfo.PreText = null;
			list.Add(attributeInfo);
		}
		if (list2.Count > 0)
		{
			title = "IdentifySuccess";
		}
		if (num > 0)
		{
			for (int k = 0; k < num; k++)
			{
				list.Add(new AttributeInfo
				{
					Name = "UnlockSlot",
					ShowArrow = new bool?(false),
					PreText = "",
					CurText = ConfigMultiTextLang.GetLocalTextNew("Text_PhantomUnlock_Text", null),
					IconPath = PhantomBattleConfig.Instance.GetVisionLevelUpTexture()
				});
			}
		}
		return new LevelUpSuccessAttributeData
		{
			Title = title,
			LevelInfo = levelInfo,
			WiderScrollView = new bool?(false),
			AttributeInfo = list
		};
	}

	// Token: 0x0600FD09 RID: 64777 RVA: 0x0049D66C File Offset: 0x0049B86C
	private AttrListScrollData[] GetLevelUpSuccessAttributeData(LevelUpPastVisionData data, PhantomBattleData visionData)
	{
		List<AttrListScrollData> attrListScrollData = data.AttrListScrollData;
		List<AttrListScrollData> mainPropShowAttributeList = visionData.GetMainPropShowAttributeList(CommonComponentDefine.EAttributeType.PhantomType, false);
		int count = mainPropShowAttributeList.Count;
		int count2 = attrListScrollData.Count;
		List<AttrListScrollData> list = new List<AttrListScrollData>();
		for (int i = 0; i < count; i++)
		{
			AttrListScrollData attrListScrollData2 = mainPropShowAttributeList[i];
			AttrListScrollData attrListScrollData3 = null;
			for (int j = 0; j < count2; j++)
			{
				if (attrListScrollData[j].Id == attrListScrollData2.Id && i == j)
				{
					attrListScrollData3 = attrListScrollData[j];
					break;
				}
			}
			PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(attrListScrollData2.Id);
			list.Add(new AttrListScrollData(attrListScrollData2.Id, attrListScrollData3.BaseValue, attrListScrollData2.BaseValue, propertyIndexInfo.Value.Priority, attrListScrollData3.IsRatio, CommonComponentDefine.EAttributeType.VisionLevelUp));
		}
		return list.ToArray();
	}

	// Token: 0x0600FD0A RID: 64778 RVA: 0x0049D74C File Offset: 0x0049B94C
	public void PhantomLevelUpReceiveItem(Dictionary<int, int> itemMap)
	{
		List<TItem> list = new List<TItem>();
		foreach (KeyValuePair<int, int> keyValuePair in itemMap)
		{
			int key = keyValuePair.Key;
			TItem item = new TItem(new InventoryDefine.GetItemData(key, 0), keyValuePair.Value);
			list.Add(item);
		}
		this.TempSaveItemList = list.ToArray();
		Array.Sort<TItem>(this.TempSaveItemList, delegate(TItem a, TItem b)
		{
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(a.ItemData.ItemId);
			return InventoryConfig.Instance.GetItemConfigData(b.ItemData.ItemId).QualityId - itemConfigData.QualityId;
		});
		this.VisionLevelUpTag = true;
		EventSystem.Instance.Emit<IReadOnlyList<TItem>>(EEventName.PhantomLevelUpReceiveItem, list);
	}

	// Token: 0x0600FD0B RID: 64779 RVA: 0x0049D80C File Offset: 0x0049BA0C
	public bool GetVisionLevelUpTag()
	{
		return this.VisionLevelUpTag;
	}

	// Token: 0x0600FD0C RID: 64780 RVA: 0x0049D814 File Offset: 0x0049BA14
	public void ClearVisionLevelUp()
	{
		this.VisionLevelUpTag = false;
	}

	// Token: 0x0600FD0D RID: 64781 RVA: 0x0049D81D File Offset: 0x0049BA1D
	public TItem[] GetTempSaveItemList()
	{
		return this.TempSaveItemList;
	}

	// Token: 0x0600FD0E RID: 64782 RVA: 0x0049D828 File Offset: 0x0049BA28
	public TItem? ShiftTempSaveItemList()
	{
		if (this.TempSaveItemList.Length == 0)
		{
			return null;
		}
		TItem value = this.TempSaveItemList[0];
		List<TItem> list = new List<TItem>(this.TempSaveItemList);
		list.RemoveAt(0);
		this.TempSaveItemList = list.ToArray();
		return new TItem?(value);
	}

	// Token: 0x0600FD0F RID: 64783 RVA: 0x0049D878 File Offset: 0x0049BA78
	public void ClearTempSaveItemList()
	{
		this.TempSaveItemList = new TItem[0];
	}

	// Token: 0x0600FD10 RID: 64784 RVA: 0x0049D888 File Offset: 0x0049BA88
	public IPhantomItemData[] GetVisionSortUseDataList(int filterFetterGroupId = 0, int cost = 0)
	{
		List<IPhantomItemData> list = new List<IPhantomItemData>();
		InventoryModel instance = InventoryModel.Instance;
		foreach (PhantomBattleData phantomBattleData in PhantomBattleModel.Instance.GetPhantomBattleDataMap().Values)
		{
			int uniqueId = phantomBattleData.GetUniqueId();
			if ((filterFetterGroupId <= 0 || phantomBattleData.GetFetterGroupId() == filterFetterGroupId) && (cost <= 0 || phantomBattleData.GetCost() == cost) && phantomBattleData.CheckIfHaveSelectRecommendSubAttr() && phantomBattleData.CheckIfHaveSelectRecommendMainAttr() && phantomBattleData.CheckIfHaveSelectMainPhantomType())
			{
				global::PhantomItemData phantomItemData = instance.GetPhantomItemData(uniqueId);
				Aki.Config.PhantomItem config = phantomBattleData.GetConfig();
				CSharpScript.Game.PhantomBattle.PhantomItemData item = new CSharpScript.Game.PhantomBattle.PhantomItemData
				{
					IsPhantomData = true,
					Id = phantomBattleData.GetUniqueId(),
					Quality = config.QualityId,
					IsEquip = PhantomBattleController.Instance.CheckIsEquip(uniqueId),
					Role = PhantomBattleController.Instance.GetEquipRole(uniqueId).GetValueOrDefault(),
					Level = phantomBattleData.GetPhantomLevel(),
					IsBreach = phantomBattleData.IsBreach(),
					MonsterId = config.MonsterId,
					MainPropMap = phantomBattleData.GetMainPropArray(),
					SubPropMap = phantomBattleData.GetSubPropArray(),
					IsLock = phantomItemData.GetIsLock(),
					IsDeprecate = phantomItemData.GetIsDeprecated(),
					ConfigId = phantomItemData.GetConfigId(),
					Rarity = config.Rarity
				};
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600FD11 RID: 64785 RVA: 0x0049DA2C File Offset: 0x0049BC2C
	public IPhantomItemData[] GetVisionSortUseDataListByMultiGroup(IReadOnlySet<int> filterFetterGroupIds, int cost = 0)
	{
		List<IPhantomItemData> list = new List<IPhantomItemData>();
		InventoryModel instance = InventoryModel.Instance;
		foreach (PhantomBattleData phantomBattleData in PhantomBattleModel.Instance.GetPhantomBattleDataMap().Values)
		{
			int uniqueId = phantomBattleData.GetUniqueId();
			if ((filterFetterGroupIds.Count <= 0 || filterFetterGroupIds.Contains(phantomBattleData.GetFetterGroupId())) && (cost <= 0 || phantomBattleData.GetCost() == cost) && phantomBattleData.CheckIfHaveSelectRecommendSubAttr() && phantomBattleData.CheckIfHaveSelectRecommendMainAttr() && phantomBattleData.CheckIfHaveSelectMainPhantomType())
			{
				global::PhantomItemData phantomItemData = instance.GetPhantomItemData(uniqueId);
				Aki.Config.PhantomItem config = phantomBattleData.GetConfig();
				CSharpScript.Game.PhantomBattle.PhantomItemData item = new CSharpScript.Game.PhantomBattle.PhantomItemData
				{
					IsPhantomData = true,
					Id = phantomBattleData.GetUniqueId(),
					Quality = config.QualityId,
					IsEquip = PhantomBattleController.Instance.CheckIsEquip(uniqueId),
					Role = PhantomBattleController.Instance.GetEquipRole(uniqueId).GetValueOrDefault(),
					Level = phantomBattleData.GetPhantomLevel(),
					IsBreach = phantomBattleData.IsBreach(),
					MonsterId = config.MonsterId,
					MainPropMap = phantomBattleData.GetMainPropArray(),
					SubPropMap = phantomBattleData.GetSubPropArray(),
					IsLock = phantomItemData.GetIsLock(),
					IsDeprecate = phantomItemData.GetIsDeprecated(),
					ConfigId = phantomItemData.GetConfigId(),
					Rarity = config.Rarity
				};
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600FD12 RID: 64786 RVA: 0x0049DBD8 File Offset: 0x0049BDD8
	public Dictionary<int, PhantomBattleData> GetPhantomBattleDataMap()
	{
		return this.PhantomBattleDataMap;
	}

	// Token: 0x0600FD13 RID: 64787 RVA: 0x0049DBE0 File Offset: 0x0049BDE0
	public PhantomBattleData[] GetUnEquipVisionArray()
	{
		if (this.UnEquipVisionArrayRefreshTag)
		{
			this.UnEquipVisionArray = new List<PhantomBattleData>();
			this.UnEquipVisionArrayRefreshTag = false;
			foreach (KeyValuePair<int, PhantomBattleData> keyValuePair in this.GetPhantomBattleDataMap())
			{
				if (!this.CheckPhantomIsEquip(keyValuePair.Key))
				{
					this.UnEquipVisionArray.Add(keyValuePair.Value);
				}
			}
		}
		return this.UnEquipVisionArray.ToArray();
	}

	// Token: 0x0600FD14 RID: 64788 RVA: 0x0049DC74 File Offset: 0x0049BE74
	public void UpdateRoleEquipmentData(RolePhantomEquipInfo data)
	{
		PhantomRoleEquipmentData battleDataById = this.GetBattleDataById(data.RoleId);
		foreach (int key in battleDataById.GetIncrIdList())
		{
			this.PhantomEquipmentRoleMap.Remove(key);
		}
		foreach (int num in data.PhantomItemIncrId)
		{
			int? phantomEquipOnRoleId = this.GetPhantomEquipOnRoleId(num);
			int? num2 = phantomEquipOnRoleId;
			int num3 = 0;
			if (num2.GetValueOrDefault() > num3 & num2 != null)
			{
				this.GetBattleDataById(phantomEquipOnRoleId.Value).RemoveIncrIdLocal(num);
			}
			this.PhantomEquipmentRoleMap[num] = data.RoleId;
		}
		this.UnEquipVisionArrayRefreshTag = true;
		battleDataById.Phrase(data);
	}

	// Token: 0x0600FD15 RID: 64789 RVA: 0x0049DD6C File Offset: 0x0049BF6C
	public void UpdateRoleEquipmentPropData(RolePhantomPropInfo data)
	{
		this.GetBattleDataById(data.RoleId).Phrase(data);
	}

	// Token: 0x0600FD16 RID: 64790 RVA: 0x0049DD80 File Offset: 0x0049BF80
	public PhantomRoleEquipmentData GetBattleDataById(int roleId)
	{
		PhantomRoleEquipmentData phantomRoleEquipmentData;
		if (!this.BattleDataMap.TryGetValue(roleId, out phantomRoleEquipmentData))
		{
			phantomRoleEquipmentData = new PhantomRoleEquipmentData();
		}
		this.BattleDataMap[roleId] = phantomRoleEquipmentData;
		return phantomRoleEquipmentData;
	}

	// Token: 0x0600FD17 RID: 64791 RVA: 0x0049DDB1 File Offset: 0x0049BFB1
	public bool CheckPhantomIsEquip(int uniqueId)
	{
		return uniqueId < 0 || (uniqueId != 0 && this.PhantomEquipmentRoleMap.ContainsKey(uniqueId));
	}

	// Token: 0x0600FD18 RID: 64792 RVA: 0x0049DDCC File Offset: 0x0049BFCC
	public bool CheckPhantomIsMain(int uniqueId)
	{
		if (uniqueId < 0)
		{
			return (this.GetPhantomDataBase(uniqueId) as PhantomTrialBattleData).GetIfMain();
		}
		if (!this.CheckPhantomIsEquip(uniqueId))
		{
			return false;
		}
		int roleId = this.PhantomEquipmentRoleMap[uniqueId];
		return this.GetBattleDataById(roleId).CheckPhantomIsMain(uniqueId);
	}

	// Token: 0x0600FD19 RID: 64793 RVA: 0x0049DE14 File Offset: 0x0049C014
	public bool CheckPhantomIsSub(int uniqueId)
	{
		if (!this.CheckPhantomIsEquip(uniqueId))
		{
			return false;
		}
		int roleId = this.PhantomEquipmentRoleMap[uniqueId];
		return this.GetBattleDataById(roleId).CheckPhantomIsSub(uniqueId);
	}

	// Token: 0x0600FD1A RID: 64794 RVA: 0x0049DE48 File Offset: 0x0049C048
	public int? GetPhantomEquipOnRoleId(int uniqueId)
	{
		if (!this.CheckPhantomIsEquip(uniqueId))
		{
			return null;
		}
		return new int?(this.PhantomEquipmentRoleMap[uniqueId]);
	}

	// Token: 0x0600FD1B RID: 64795 RVA: 0x0049DE79 File Offset: 0x0049C079
	public bool CheckPhantomIndexIsEquipOnRole(int roleId, int index)
	{
		return this.GetBattleDataById(roleId).GetIndexPhantomId(index) != -1;
	}

	// Token: 0x0600FD1C RID: 64796 RVA: 0x0049DE8E File Offset: 0x0049C08E
	public int GetPhantomSumLevelByRoleId(int roleId)
	{
		return this.GetBattleDataById(roleId).GetSumEquipLevel();
	}

	// Token: 0x0600FD1D RID: 64797 RVA: 0x0049DE9C File Offset: 0x0049C09C
	public bool GetPhantomIsUnlock(int monsterId)
	{
		foreach (KeyValuePair<int, List<ICalabashDevelopConditionState>> keyValuePair in CalabashModel.Instance.GetUnlockCalabashDevelopRewards())
		{
			if (monsterId == keyValuePair.Key)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600FD1E RID: 64798 RVA: 0x0049DF00 File Offset: 0x0049C100
	public bool CheckPhantomIfLevelMax(int uniqueId)
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(uniqueId);
		return phantomItemDataByUniqueId.GetPhantomLevel() == PhantomBattleConfig.Instance.GetPhantomQualityByItemQuality(phantomItemDataByUniqueId.GetQuality()).Value.LevelLimit;
	}

	// Token: 0x0600FD1F RID: 64799 RVA: 0x0049DF41 File Offset: 0x0049C141
	public bool CheckMonsterIsEquipOnRole(int roleId, int monsterId)
	{
		return this.GetBattleDataById(roleId).CheckMonsterIsEquip(monsterId);
	}

	// Token: 0x0600FD20 RID: 64800 RVA: 0x0049DF50 File Offset: 0x0049C150
	public int GetVisionIndexOnRole(int uniqueId, int roleId)
	{
		return this.GetBattleDataById(roleId).GetIndexPhantomId(uniqueId);
	}

	// Token: 0x0600FD21 RID: 64801 RVA: 0x0049DF60 File Offset: 0x0049C160
	public bool GetRoleIfEquipVision(int roleId)
	{
		List<int> incrIdList = PhantomBattleModel.Instance.GetBattleDataById(roleId).GetIncrIdList();
		int count = incrIdList.Count;
		for (int i = 0; i < count; i++)
		{
			if (incrIdList[i] != 0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600FD22 RID: 64802 RVA: 0x0049DF9D File Offset: 0x0049C19D
	public int GetRoleIndexPhantomId(int roleId, int index)
	{
		return this.GetBattleDataById(roleId).GetIndexPhantomId(index);
	}

	// Token: 0x0600FD23 RID: 64803 RVA: 0x0049DFAC File Offset: 0x0049C1AC
	public int GetPhantomIndexOfRole(int roleId, int phantomId)
	{
		List<int> incrIdList = PhantomBattleModel.Instance.GetBattleDataById(roleId).GetIncrIdList();
		int count = incrIdList.Count;
		for (int i = 0; i < count; i++)
		{
			if (incrIdList[i] == phantomId)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x0600FD24 RID: 64804 RVA: 0x0049DFEA File Offset: 0x0049C1EA
	public EEquipType GetRolePhantomEquipState(int roleId, int index, int uniqueId)
	{
		if (!this.CheckPhantomIsEquip(uniqueId))
		{
			return EEquipType.Equip;
		}
		return this.GetBattleDataById(roleId).GetPhantomOperationState(index, uniqueId);
	}

	// Token: 0x0600FD25 RID: 64805 RVA: 0x0049E008 File Offset: 0x0049C208
	public int GetPhantomMaxLevel(int uniqueId)
	{
		PhantomBattleData phantomBattleData = this.GetPhantomBattleData(uniqueId);
		return PhantomBattleConfig.Instance.GetPhantomQualityByItemQuality(phantomBattleData.GetQuality()).Value.LevelLimit;
	}

	// Token: 0x0600FD26 RID: 64806 RVA: 0x0049E040 File Offset: 0x0049C240
	public FTransform GetMeshTransform(int itemId)
	{
		FRotator meshRotator = this.GetMeshRotator(itemId);
		FVector meshLocation = this.GetMeshLocation(itemId);
		FVector meshZoom = this.GetMeshZoom(itemId);
		return new FTransform(ref meshRotator, ref meshLocation, ref meshZoom);
	}

	// Token: 0x0600FD27 RID: 64807 RVA: 0x0049E070 File Offset: 0x0049C270
	private FVector GetMeshZoom(int itemId)
	{
		float[] modelZoom = this.GetPhantomInstanceByItemId(itemId).GetModelZoom();
		if (modelZoom.Length != 0)
		{
			this.PhantomMeshZoom.Set(modelZoom[0], modelZoom[1], modelZoom[2]);
			return this.PhantomMeshZoom;
		}
		return new FVector();
	}

	// Token: 0x0600FD28 RID: 64808 RVA: 0x0049E0B0 File Offset: 0x0049C2B0
	private FVector GetMeshLocation(int itemId)
	{
		float[] modelLocation = this.GetPhantomInstanceByItemId(itemId).GetModelLocation();
		if (modelLocation.Length != 0)
		{
			this.PhantomMeshLocation.Set(modelLocation[0], modelLocation[1], modelLocation[2]);
			return this.PhantomMeshLocation;
		}
		return new FVector();
	}

	// Token: 0x0600FD29 RID: 64809 RVA: 0x0049E0F0 File Offset: 0x0049C2F0
	private FRotator GetMeshRotator(int itemId)
	{
		float[] modelRotator = this.GetPhantomInstanceByItemId(itemId).GetModelRotator();
		if (modelRotator.Length != 0)
		{
			this.PhantomMeshRotator.Roll = modelRotator[0];
			this.PhantomMeshRotator.Pitch = modelRotator[1];
			this.PhantomMeshRotator.Yaw = modelRotator[2];
			return this.PhantomMeshRotator;
		}
		return new FRotator();
	}

	// Token: 0x0600FD2A RID: 64810 RVA: 0x0049E144 File Offset: 0x0049C344
	public string GetStandAnim(int itemId)
	{
		return this.GetPhantomInstanceByItemId(itemId).GetStandAnim();
	}

	// Token: 0x0600FD2B RID: 64811 RVA: 0x0049E152 File Offset: 0x0049C352
	public EVisionLevelUpMaterialPutInMode GetVisionLevelUpMaterialPutInMode()
	{
		return this.VisionLevelUpMaterialPutInMode;
	}

	// Token: 0x0600FD2C RID: 64812 RVA: 0x0049E15A File Offset: 0x0049C35A
	public void SetVisionLevelUpMaterialPutInMode(EVisionLevelUpMaterialPutInMode mode)
	{
		if (this.VisionLevelUpMaterialPutInMode == mode)
		{
			return;
		}
		this.VisionLevelUpMaterialPutInMode = mode;
		LocalStorage.SetPlayer<EVisionLevelUpMaterialPutInMode>(ELocalStoragePlayerKey.VisionLevelUpMaterialPutInMode, mode);
		EventSystem.Instance.Emit(EEventName.OnVisionLevelUpMaterialPutInModeChange);
	}

	// Token: 0x0600FD2D RID: 64813 RVA: 0x0049E186 File Offset: 0x0049C386
	public EVisionLevelUpMaterialUseType GetVisionLevelUpMaterialUseType()
	{
		return this.VisionLevelUpMaterialUseType;
	}

	// Token: 0x0600FD2E RID: 64814 RVA: 0x0049E18E File Offset: 0x0049C38E
	public void SetVisionLevelUpMaterialUseType(EVisionLevelUpMaterialUseType type)
	{
		if (this.VisionLevelUpMaterialUseType == type)
		{
			return;
		}
		this.VisionLevelUpMaterialUseType = type;
		LocalStorage.SetPlayer<EVisionLevelUpMaterialUseType>(ELocalStoragePlayerKey.VisionLevelUpMaterialUseType, type);
	}

	// Token: 0x0600FD2F RID: 64815 RVA: 0x0049E1AA File Offset: 0x0049C3AA
	public EVisionLevelUpIdentify GetVisionLevelUpIdentify()
	{
		return this.VisionLevelUpIdentify;
	}

	// Token: 0x0600FD30 RID: 64816 RVA: 0x0049E1B2 File Offset: 0x0049C3B2
	public void SetVisionLevelUpIdentify(EVisionLevelUpIdentify type)
	{
		if (this.VisionLevelUpIdentify == type)
		{
			return;
		}
		this.VisionLevelUpIdentify = type;
		LocalStorage.SetPlayer<EVisionLevelUpIdentify>(ELocalStoragePlayerKey.VisionLevelUpIdentify, type);
		EventSystem.Instance.Emit(EEventName.OnVisionLevelUpIdentifyChange);
	}

	// Token: 0x0600FD31 RID: 64817 RVA: 0x0049E1E1 File Offset: 0x0049C3E1
	public PhantomBattleData GetPhantomBattleDataByPhantomItem(Aki.Protocol.PhantomItem data)
	{
		PhantomBattleData phantomBattleData = new PhantomBattleData();
		phantomBattleData.SetData(data);
		return phantomBattleData;
	}

	// Token: 0x0600FD32 RID: 64818 RVA: 0x0049E1EF File Offset: 0x0049C3EF
	public void AddNeedCameraFocusMethodDisableViewCount()
	{
		this.NeedCameraFocusMethodDisableViewCount++;
		this.UpdateCameraFocusMethod();
	}

	// Token: 0x0600FD33 RID: 64819 RVA: 0x0049E205 File Offset: 0x0049C405
	public void ReduceNeedCameraFocusMethodDisableViewCount()
	{
		this.NeedCameraFocusMethodDisableViewCount--;
		this.UpdateCameraFocusMethod();
	}

	// Token: 0x0600FD34 RID: 64820 RVA: 0x0049E21C File Offset: 0x0049C41C
	public void UpdateCameraFocusMethod()
	{
		ECameraFocusMethod cameraFocusMethod = (this.NeedCameraFocusMethodDisableViewCount > 0) ? ECameraFocusMethod.Disable : ECameraFocusMethod.Manual;
		UiCameraModel.Instance.GetOrCreateCamera().GetUiCameraComponent<UiCameraDisplayComponent>().SetCameraFocusMethod(cameraFocusMethod);
	}

	// Token: 0x0600FD35 RID: 64821 RVA: 0x0049E24C File Offset: 0x0049C44C
	public PhantomFetter[] GetFetterListByRoleId(int roleId)
	{
		List<int> targetRoleFetterList = this.GetTargetRoleFetterList(roleId);
		if (targetRoleFetterList.Count == 0)
		{
			return new PhantomFetter[0];
		}
		List<PhantomFetter> list = new List<PhantomFetter>();
		foreach (int id in targetRoleFetterList)
		{
			list.Add(PhantomBattleConfig.Instance.GetPhantomFetterById(id));
		}
		return list.ToArray();
	}

	// Token: 0x0600FD36 RID: 64822 RVA: 0x0049E2C8 File Offset: 0x0049C4C8
	public void UpdateFetterList(int roleId)
	{
		RolePhantomData phantomData = RoleModel.Instance.GetRoleDataById(roleId, true).GetPhantomData();
		Dictionary<int, PhantomDataBase> dataMap = phantomData.GetDataMap();
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, PhantomDataBase> keyValuePair in dataMap)
		{
			PhantomDataBase value = keyValuePair.Value;
			if (value != null)
			{
				list.Add(value.GetIncrId());
			}
		}
		phantomData.ClearPhantomFettersList();
		this.DoFettersList(list.ToArray(), phantomData.GetPhantomFettersList());
	}

	// Token: 0x0600FD37 RID: 64823 RVA: 0x0049E360 File Offset: 0x0049C560
	private void DoFettersList(int[] incIdArray, List<int> outList)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (int uniqueId in incIdArray)
		{
			PhantomDataBase phantomDataBase = this.GetPhantomDataBase(uniqueId);
			if (phantomDataBase != null)
			{
				int num;
				if (!dictionary.TryGetValue(phantomDataBase.GetFetterGroupId(), out num))
				{
					num = 0;
				}
				int value = num + 1;
				dictionary[phantomDataBase.GetFetterGroupId()] = value;
			}
		}
		foreach (int item in PhantomBattleConfig.Instance.GetFetterResultBySuitMap(dictionary))
		{
			outList.Add(item);
		}
	}

	// Token: 0x0600FD38 RID: 64824 RVA: 0x0049E40C File Offset: 0x0049C60C
	public int[] GetPreviewFetterAdd(PhantomDataBase phantomData, int index, int roleId)
	{
		List<int> incrIdList = this.GetBattleDataById(roleId).GetIncrIdList();
		List<int> list = new List<int>();
		int count = incrIdList.Count;
		for (int i = 0; i < count; i++)
		{
			if (this.GetPhantomBattleData(incrIdList[i]) != null && i != index)
			{
				list.Add(incrIdList[i]);
			}
		}
		List<int> list2 = new List<int>();
		List<int> targetRoleFetterList = this.GetTargetRoleFetterList(roleId);
		List<int> list3 = new List<int>();
		list.Add(phantomData.GetIncrId());
		this.DoFettersList(list.ToArray(), list2);
		foreach (int item in list2)
		{
			if (targetRoleFetterList.IndexOf(item) < 0)
			{
				list3.Add(item);
			}
		}
		return list3.ToArray();
	}

	// Token: 0x0600FD39 RID: 64825 RVA: 0x0049E4F0 File Offset: 0x0049C6F0
	public int[] GetPreviewFettersDel(PhantomDataBase phantomData, int index, int roleId)
	{
		List<int> incrIdList = this.GetBattleDataById(roleId).GetIncrIdList();
		List<int> list = new List<int>();
		int count = incrIdList.Count;
		for (int i = 0; i < count; i++)
		{
			if (this.GetPhantomBattleData(incrIdList[i]) != null && i != index)
			{
				list.Add(incrIdList[i]);
			}
		}
		List<int> list2 = new List<int>();
		List<int> targetRoleFetterList = this.GetTargetRoleFetterList(roleId);
		List<int> list3 = new List<int>();
		list.Add(phantomData.GetIncrId());
		this.DoFettersList(list.ToArray(), list2);
		foreach (int num in targetRoleFetterList)
		{
			bool flag = false;
			using (List<int>.Enumerator enumerator2 = list2.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current == num)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				list3.Add(num);
			}
		}
		return list3.ToArray();
	}

	// Token: 0x0600FD3A RID: 64826 RVA: 0x0049E608 File Offset: 0x0049C808
	public bool CheckFetterActiveState(int roleId, int fetterId)
	{
		PhantomFetter[] fetterListByRoleId = this.GetFetterListByRoleId(roleId);
		if (fetterListByRoleId == null || fetterListByRoleId.Length == 0)
		{
			return false;
		}
		foreach (PhantomFetter phantomFetter in fetterListByRoleId)
		{
			if (phantomFetter.Id == fetterId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600FD3B RID: 64827 RVA: 0x0049E64C File Offset: 0x0049C84C
	public int[] GetTargetCanActiveFettersList(int incId)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		PhantomDataBase phantomDataBase = this.GetPhantomDataBase(incId);
		List<int> list = new List<int>();
		if (phantomDataBase != null)
		{
			dictionary[phantomDataBase.GetFetterGroupId()] = 999;
		}
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			foreach (KeyValuePair<int, int> keyValuePair2 in ConfigPhantomFetterGroupById.GetConfig(keyValuePair.Key, true).Value.FetterMap())
			{
				int key = keyValuePair2.Key;
				int value = keyValuePair2.Value;
				if (keyValuePair.Value >= key)
				{
					int item = value;
					list.Add(item);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600FD3C RID: 64828 RVA: 0x0049E748 File Offset: 0x0049C948
	public VisionFetterData[] GetRoleFetterData(int roleId)
	{
		List<VisionFetterData> list = new List<VisionFetterData>();
		List<int> incrIdList = PhantomBattleModel.Instance.GetBattleDataById(roleId).GetIncrIdList();
		int count = incrIdList.Count;
		List<PhantomDataBase> list2 = new List<PhantomDataBase>();
		for (int i = 0; i < count; i++)
		{
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(incrIdList[i]);
			if (phantomBattleData != null)
			{
				list2.Add(phantomBattleData);
			}
		}
		Dictionary<int, int> dictionary = PhantomDataBase.CalculateFetterByPhantomBattleData(list2);
		for (int j = 0; j < count; j++)
		{
			PhantomBattleData phantomBattleData2 = PhantomBattleModel.Instance.GetPhantomBattleData(incrIdList[j]);
			if (phantomBattleData2 != null)
			{
				PhantomFetterGroup? config = ConfigPhantomFetterGroupById.GetConfig(phantomBattleData2.GetFetterGroupId(), true);
				int fetterMapLength = config.Value.FetterMapLength;
				for (int k = 0; k < fetterMapLength; k++)
				{
					DicIntInt? dicIntInt = config.Value.FetterMap(k);
					int num;
					int num2;
					list.Add(new VisionFetterData
					{
						FetterId = dicIntInt.Value.Value,
						FetterGroupId = phantomBattleData2.GetFetterGroupId(),
						ActiveFetterGroupNum = (dictionary.TryGetValue(phantomBattleData2.GetFetterGroupId(), out num) ? num : 0),
						ActiveState = (dictionary.TryGetValue(phantomBattleData2.GetFetterGroupId(), out num2) && num2 >= dicIntInt.Value.Key)
					});
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600FD3D RID: 64829 RVA: 0x0049E8B9 File Offset: 0x0049CAB9
	public List<int> GetTargetRoleFetterList(int roleId)
	{
		return RoleModel.Instance.GetRoleDataById(roleId, true).GetPhantomData().GetPhantomFettersList();
	}

	// Token: 0x0600FD3E RID: 64830 RVA: 0x0049E8D4 File Offset: 0x0049CAD4
	public ItemInfo[] GetPhantomLevelUpItemSortList(int uniqueId)
	{
		List<ItemInfo> list = new List<ItemInfo>();
		IReadOnlyList<PhantomExpItem> phantomExpItemList = PhantomBattleConfig.Instance.GetPhantomExpItemList();
		if (phantomExpItemList != null)
		{
			foreach (PhantomExpItem phantomExpItem in phantomExpItemList)
			{
				ItemInfo? config = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfig(phantomExpItem.ItemId);
				if (config != null)
				{
					list.Add(config.Value);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600FD3F RID: 64831 RVA: 0x0049E958 File Offset: 0x0049CB58
	public bool GetIfHasMonsterInInventory(int monsterId)
	{
		int[] phantomItemIdArrayByMonsterId = this.GetPhantomItemIdArrayByMonsterId(monsterId);
		if (phantomItemIdArrayByMonsterId == null || phantomItemIdArrayByMonsterId.Length == 0)
		{
			return false;
		}
		bool result = false;
		foreach (int itemConfigId in phantomItemIdArrayByMonsterId)
		{
			if (InventoryModel.Instance.GetItemCountByConfigId(itemConfigId, 0) > 0)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	// Token: 0x0600FD40 RID: 64832 RVA: 0x0049E9A4 File Offset: 0x0049CBA4
	public bool CheckPhantomIfNewQuality(int uniqueId)
	{
		PhantomDataBase phantomDataBase = this.GetPhantomDataBase(uniqueId);
		bool flag = false;
		foreach (KeyValuePair<int, PhantomBattleData> keyValuePair in this.PhantomBattleDataMap)
		{
			int monsterId = keyValuePair.Value.GetMonsterId(false);
			int? num = (phantomDataBase != null) ? new int?(phantomDataBase.GetMonsterId(false)) : null;
			if ((monsterId == num.GetValueOrDefault() & num != null) && keyValuePair.Key != uniqueId && keyValuePair.Value.GetQuality() == phantomDataBase.GetQuality())
			{
				flag = true;
				break;
			}
		}
		return !flag;
	}

	// Token: 0x0600FD41 RID: 64833 RVA: 0x0049EA60 File Offset: 0x0049CC60
	public string GetEquipRoleName(int uniqueId)
	{
		int? phantomEquipOnRoleId = PhantomBattleModel.Instance.GetPhantomEquipOnRoleId(uniqueId);
		int? num = phantomEquipOnRoleId;
		int num2 = 0;
		if (num.GetValueOrDefault() > num2 & num != null)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(phantomEquipOnRoleId.Value);
			return RoleConfig.Instance.GetRoleName(roleConfig.Value.Name);
		}
		return "";
	}

	// Token: 0x0600FD42 RID: 64834 RVA: 0x0049EAC4 File Offset: 0x0049CCC4
	public int GetRoleCurrentPhantomCost(int roleId)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		int num = 0;
		if (roleDataById != null && roleDataById.IsTrialRole())
		{
			Dictionary<int, PhantomDataBase> dataMap = roleDataById.GetPhantomData().GetDataMap();
			for (int i = 0; i < 5; i++)
			{
				PhantomDataBase phantomDataBase;
				if (dataMap.TryGetValue(i, out phantomDataBase) && phantomDataBase != null)
				{
					num += phantomDataBase.GetCost();
				}
			}
		}
		else
		{
			foreach (int uniqueId in this.GetBattleDataById(roleId).GetIncrIdList())
			{
				PhantomBattleData phantomBattleData = this.GetPhantomBattleData(uniqueId);
				if (phantomBattleData != null)
				{
					num += phantomBattleData.GetCost();
				}
			}
		}
		return num;
	}

	// Token: 0x0600FD43 RID: 64835 RVA: 0x0049EB80 File Offset: 0x0049CD80
	public int GetLevelUpNeedCost(int exp)
	{
		return (int)Math.Floor((double)((float)exp * PhantomBattleConfig.Instance.GetPhantomLevelUpCostRatio()));
	}

	// Token: 0x0600FD44 RID: 64836 RVA: 0x0049EB96 File Offset: 0x0049CD96
	public void ResetLevelUpItemData()
	{
		this.LevelUpItemData.Clear();
	}

	// Token: 0x0600FD45 RID: 64837 RVA: 0x0049EBA4 File Offset: 0x0049CDA4
	public int[] GetPhantomItemIdArrayByMonsterId(int monsterId)
	{
		IEnumerable<Aki.Config.PhantomItem> phantomItemByMonsterId = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(monsterId);
		List<int> list = new List<int>();
		foreach (Aki.Config.PhantomItem phantomItem in phantomItemByMonsterId)
		{
			list.Add(phantomItem.ItemId);
		}
		return list.ToArray();
	}

	// Token: 0x0600FD46 RID: 64838 RVA: 0x0049EC08 File Offset: 0x0049CE08
	public int GetMonsterRarity(int monsterId)
	{
		return PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(monsterId)[0].Rarity;
	}

	// Token: 0x0600FD47 RID: 64839 RVA: 0x0049EC2E File Offset: 0x0049CE2E
	public AttrListScrollData[] GetShowAttrList(int roleId)
	{
		List<AttrListScrollData> propShowAttributeList = this.GetBattleDataById(roleId).GetPropShowAttributeList();
		propShowAttributeList.Sort(new Comparison<AttrListScrollData>(this.SortAttrList));
		return propShowAttributeList.ToArray();
	}

	// Token: 0x0600FD48 RID: 64840 RVA: 0x0049EC53 File Offset: 0x0049CE53
	public List<AttrListScrollData> GetExtraAttrList(int roleId)
	{
		List<AttrListScrollData> propDetailAttributeList = this.GetBattleDataById(roleId).GetPropDetailAttributeList();
		propDetailAttributeList.Sort(new Comparison<AttrListScrollData>(this.SortAttrList));
		return propDetailAttributeList;
	}

	// Token: 0x0600FD49 RID: 64841 RVA: 0x0049EC74 File Offset: 0x0049CE74
	public int[] GetFetterGroupMonsterIdArray(int fetterGroupId)
	{
		int[] result;
		if (this.GetFetterGroupMonsterMap().TryGetValue(fetterGroupId, out result))
		{
			return result;
		}
		return new int[0];
	}

	// Token: 0x0600FD4A RID: 64842 RVA: 0x0049EC9C File Offset: 0x0049CE9C
	public int GetMonsterFindCountByMonsterIdArray(int[] monsterIdList)
	{
		int num = 0;
		foreach (int id in monsterIdList)
		{
			if (HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Phantom, id) != null)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x0600FD4B RID: 64843 RVA: 0x0049ECD4 File Offset: 0x0049CED4
	public int GetMonsterFindCountByMonsterIdArrayWithoutCost4(int[] monsterIdList)
	{
		int num = 0;
		foreach (int num2 in monsterIdList)
		{
			if (HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Phantom, num2) != null)
			{
				IReadOnlyList<Aki.Config.PhantomItem> phantomItemByMonsterId = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(num2);
				if (phantomItemByMonsterId != null && phantomItemByMonsterId.Count != 0)
				{
					int rarity = phantomItemByMonsterId[0].Rarity;
					if (PhantomBattleConfig.Instance.GetPhantomRareConfig(rarity).Value.Cost != 4)
					{
						num++;
					}
				}
			}
		}
		return num;
	}

	// Token: 0x0600FD4C RID: 64844 RVA: 0x0049ED58 File Offset: 0x0049CF58
	public Dictionary<int, int[]> GetFetterGroupMonsterMap()
	{
		if (this.FetterGroupMonsterMap != null)
		{
			return this.FetterGroupMonsterMap;
		}
		this.FetterGroupMonsterMap = new Dictionary<int, int[]>();
		foreach (PhantomFetterGroup phantomFetterGroup in PhantomBattleConfig.Instance.GetFetterGroupArray())
		{
			int[] fetterGroupSourceMonster = PhantomBattleConfig.Instance.GetFetterGroupSourceMonster(phantomFetterGroup.Id);
			List<int> list = new List<int>();
			foreach (int item in fetterGroupSourceMonster)
			{
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
			this.FetterGroupMonsterMap[phantomFetterGroup.Id] = list.ToArray();
		}
		return this.FetterGroupMonsterMap;
	}

	// Token: 0x0600FD4D RID: 64845 RVA: 0x0049EE1C File Offset: 0x0049D01C
	public AttrListScrollData[] GetTrialRoleDetailAttrList(int roleDataId)
	{
		IEnumerable<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("VisionMainViewExtraAttribute");
		AttrListScrollData[] trialRoleAttrList = this.GetTrialRoleAttrList(roleDataId);
		int num = trialRoleAttrList.Length;
		List<AttrListScrollData> list = new List<AttrListScrollData>();
		foreach (int num2 in intArrayConfig)
		{
			PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(num2);
			bool flag = false;
			for (int i = 0; i < num; i++)
			{
				if (trialRoleAttrList[i].Id == num2)
				{
					list.Add(trialRoleAttrList[i]);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				list.Add(new AttrListScrollData(num2, 0.0, 0.0, propertyIndexInfo.Value.Priority, false, CommonComponentDefine.EAttributeType.PhantomType));
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600FD4E RID: 64846 RVA: 0x0049EEF8 File Offset: 0x0049D0F8
	public AttrListScrollData[] GetTrialRoleAttrList(int roleDataId)
	{
		List<AttrListScrollData> list = new List<AttrListScrollData>();
		RoleDataBase roleRobotData = RoleModel.Instance.GetRoleRobotData(roleDataId);
		IReadOnlyList<PropertyIndex> propertyIndexList = PropertyIndexConfig.Instance.GetPropertyIndexList();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		List<AttributeValueData> list2 = new List<AttributeValueData>();
		foreach (KeyValuePair<int, PhantomDataBase> keyValuePair in roleRobotData.GetPhantomData().GetDataMap())
		{
			PhantomTrialBattleData phantomTrialBattleData = keyValuePair.Value as PhantomTrialBattleData;
			foreach (AttributeValueData item in phantomTrialBattleData.GetMainTrailProp().Values)
			{
				list2.Add(item);
			}
			foreach (AttributeValueData item2 in phantomTrialBattleData.GetSubTrailPropMap().Values)
			{
				list2.Add(item2);
			}
		}
		this.CalculateAttribute(list2.ToArray(), dictionary, roleDataId);
		foreach (PropertyIndex propertyIndex in propertyIndexList)
		{
			if (propertyIndex.IsShow)
			{
				PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(propertyIndex.Id);
				int num;
				if (!dictionary.TryGetValue(propertyIndex.Id, out num))
				{
					num = 0;
				}
				int num2 = num;
				list.Add(new AttrListScrollData(propertyIndex.Id, 0.0, (double)num2, propertyIndexInfo.Value.Priority, false, CommonComponentDefine.EAttributeType.PhantomType));
			}
		}
		list.Sort(new Comparison<AttrListScrollData>(this.SortAttrList));
		return list.ToArray();
	}

	// Token: 0x0600FD4F RID: 64847 RVA: 0x0049F0DC File Offset: 0x0049D2DC
	private void CalculateAttribute(AttributeValueData[] attributeDataList, Dictionary<int, int> outMap, int roleId)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		foreach (AttributeValueData attributeValueData in attributeDataList)
		{
			int num = attributeValueData.AttributeId;
			if (attributeValueData.AttributeId > 10000)
			{
				num -= 10000;
			}
			int num2;
			if (attributeValueData.IsRatio)
			{
				num2 = (int)((double)roleDataById.GetBaseAttributeValueById(num) * (attributeValueData.AttributeValue / 10000.0));
			}
			else
			{
				num2 = (int)attributeValueData.AttributeValue;
			}
			if (!outMap.ContainsKey(num))
			{
				outMap[num] = num2;
			}
			else
			{
				int num3 = outMap[num];
				outMap[num] = num3 + num2;
			}
		}
	}

	// Token: 0x0600FD50 RID: 64848 RVA: 0x0049F190 File Offset: 0x0049D390
	protected int SortAttrList(AttrListScrollData dataA, AttrListScrollData dataB)
	{
		bool flag = dataA.Priority != 0;
		bool flag2 = dataB.Priority != 0;
		if (flag && flag2)
		{
			return dataA.Priority - dataB.Priority;
		}
		if (flag)
		{
			return -1;
		}
		if (flag2)
		{
			return 1;
		}
		return dataA.Id - dataB.Id;
	}

	// Token: 0x17001843 RID: 6211
	// (get) Token: 0x0600FD51 RID: 64849 RVA: 0x0049F1DB File Offset: 0x0049D3DB
	// (set) Token: 0x0600FD52 RID: 64850 RVA: 0x0049F1E3 File Offset: 0x0049D3E3
	public PhantomFetter? CurrentSelectedFetter
	{
		get
		{
			return this.Fetter;
		}
		set
		{
			this.Fetter = value;
		}
	}

	// Token: 0x0600FD53 RID: 64851 RVA: 0x0049F1EC File Offset: 0x0049D3EC
	public IFettersObtainData[] GetFettersObtainDataList(int[] fetterId)
	{
		List<IFettersObtainData> list = new List<IFettersObtainData>();
		foreach (int num in fetterId)
		{
			int[] phantomItemIdArrayByMonsterId = this.GetPhantomItemIdArrayByMonsterId(num);
			if (phantomItemIdArrayByMonsterId == null || phantomItemIdArrayByMonsterId.Length == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Phantom;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "该怪物没有对应道具，请检查幻象道具表是否正确";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("monsterId", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				int num2 = 0;
				foreach (int itemConfigId in phantomItemIdArrayByMonsterId)
				{
					num2 = InventoryModel.Instance.GetItemCountByConfigId(itemConfigId, 0);
					if (num2 > 0)
					{
						break;
					}
				}
				PhantomBattleInstance phantomInstanceByItemId = this.GetPhantomInstanceByItemId(phantomItemIdArrayByMonsterId[0]);
				CalabashDevelopReward? calabashDevelopRewardByMonsterId = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(num);
				string monsterIcon = MonsterInfoConfig.Instance.GetMonsterIcon(calabashDevelopRewardByMonsterId.Value.MonsterInfoId);
				FettersObtainData item = new FettersObtainData
				{
					Id = num,
					Name = phantomInstanceByItemId.PhantomItem.Value.MonsterName,
					Icon = monsterIcon,
					IsGet = (num2 != 0)
				};
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600FD54 RID: 64852 RVA: 0x0049F31C File Offset: 0x0049D51C
	[NullableContext(2)]
	public void SetPhantomRecommendData(PhantomRecommendResponse data)
	{
		this.RecommendData = new RecommendData();
		this.RecommendData.RoleId = data.RoleId;
		this.RecommendData.MonsterIdList = new List<int>(data.MonsterIdList);
		this.RecommendData.MainPropId = data.MainPropId;
		this.RecommendData.FetterGroupId = data.FetterGroupId;
	}

	// Token: 0x17001844 RID: 6212
	// (get) Token: 0x0600FD55 RID: 64853 RVA: 0x0049F37D File Offset: 0x0049D57D
	[Nullable(2)]
	public RecommendData PhantomRecommendData
	{
		[NullableContext(2)]
		get
		{
			return this.RecommendData;
		}
	}

	// Token: 0x0600FD56 RID: 64854 RVA: 0x0049F388 File Offset: 0x0049D588
	public bool CheckIfHasPhantomSatisfiedLevelCondition(int itemId, int level)
	{
		List<global::PhantomItemData> list;
		if (itemId != 0)
		{
			list = InventoryModel.Instance.GetPhantomItemDataListByPhantomItemId(itemId);
		}
		else
		{
			list = InventoryModel.Instance.GetPhantomItemDataList();
		}
		if (list.Count == 0)
		{
			return false;
		}
		foreach (global::PhantomItemData phantomItemData in list)
		{
			PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(phantomItemData.GetUniqueId());
			if (phantomItemDataByUniqueId != null && phantomItemDataByUniqueId.GetPhantomLevel() >= level)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600FD57 RID: 64855 RVA: 0x0049F41C File Offset: 0x0049D61C
	public bool CheckIfHasPhantomLevelMax()
	{
		foreach (PhantomBattleData phantomBattleData in this.GetPhantomBattleDataMap().Values)
		{
			if (this.GetPhantomMaxLevel(phantomBattleData.GetUniqueId()) == phantomBattleData.GetPhantomLevel())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600FD58 RID: 64856 RVA: 0x0049F488 File Offset: 0x0049D688
	public bool CheckIfExistPhantomCanEquipInItemList(int[] itemIdList)
	{
		foreach (int itemId in itemIdList)
		{
			List<global::PhantomItemData> phantomItemDataListByPhantomItemId = InventoryModel.Instance.GetPhantomItemDataListByPhantomItemId(itemId);
			if (phantomItemDataListByPhantomItemId.Count == 0)
			{
				return false;
			}
			foreach (global::PhantomItemData phantomItemData in phantomItemDataListByPhantomItemId)
			{
				if (!this.CheckPhantomIsEquip(phantomItemData.GetUniqueId()))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600FD59 RID: 64857 RVA: 0x0049F514 File Offset: 0x0049D714
	public int GetPhantomItemNumByItemId(int itemId)
	{
		List<global::PhantomItemData> phantomItemDataList = InventoryModel.Instance.GetPhantomItemDataList();
		if (phantomItemDataList.Count == 0)
		{
			return 0;
		}
		int num = 0;
		using (List<global::PhantomItemData>.Enumerator enumerator = phantomItemDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetConfigId() == itemId)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x0600FD5A RID: 64858 RVA: 0x0049F580 File Offset: 0x0049D780
	public static AttrListScrollData[] FilterShowAttribute(AttrListScrollData[] input)
	{
		List<AttrListScrollData> list = new List<AttrListScrollData>();
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("VisionMainViewShowAttribute");
		foreach (AttrListScrollData attrListScrollData in input)
		{
			if (intArrayConfig.IndexOf(attrListScrollData.Id) >= 0)
			{
				list.Add(attrListScrollData);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600FD5B RID: 64859 RVA: 0x0049F5D4 File Offset: 0x0049D7D4
	public List<PhantomDataBase> GetCurrentViewShowPhantomList(RoleDataBase roleData)
	{
		bool flag = roleData.IsTrialRole();
		List<PhantomDataBase> list = new List<PhantomDataBase>();
		if (flag)
		{
			Dictionary<int, PhantomDataBase> dataMap = roleData.GetPhantomData().GetDataMap();
			for (int i = 0; i < 5; i++)
			{
				PhantomDataBase item;
				if (dataMap.TryGetValue(i, out item))
				{
					list.Add(item);
				}
			}
			return list;
		}
		List<int> incrIdList = PhantomBattleModel.Instance.GetBattleDataById(roleData.GetRoleId()).GetIncrIdList();
		int count = incrIdList.Count;
		for (int j = 0; j < count; j++)
		{
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(incrIdList[j]);
			list.Add(phantomBattleData);
		}
		return list;
	}

	// Token: 0x0600FD5C RID: 64860 RVA: 0x0049F66B File Offset: 0x0049D86B
	public ItemDataBase[] GetSortedExpMaterialList(int uniqueId, int qualityId, bool withoutPhantom)
	{
		List<ItemDataBase> list = new List<ItemDataBase>(this.GetExpMaterialList(uniqueId, qualityId, true, withoutPhantom));
		list.Sort(new Comparison<ItemDataBase>(this.MaterialSort));
		return list.ToArray();
	}

	// Token: 0x0600FD5D RID: 64861 RVA: 0x0049F694 File Offset: 0x0049D894
	private int MaterialSort(ItemDataBase a, ItemDataBase b)
	{
		InventoryDefine.EItemType? type = a.GetType();
		InventoryDefine.EItemType? type2 = b.GetType();
		if (!(type.GetValueOrDefault() == type2.GetValueOrDefault() & type != null == (type2 != null)))
		{
			return a.GetType().Value - b.GetType().Value;
		}
		if (a.GetQuality() != b.GetQuality())
		{
			return a.GetQuality() - b.GetQuality();
		}
		PhantomBattleData phantomBattleData = this.GetPhantomBattleData(a.GetUniqueId());
		PhantomBattleData phantomBattleData2 = this.GetPhantomBattleData(a.GetUniqueId());
		if (phantomBattleData != null && phantomBattleData2 != null && phantomBattleData.GetPhantomLevel() != phantomBattleData2.GetPhantomLevel())
		{
			return phantomBattleData.GetPhantomLevel() - phantomBattleData2.GetPhantomLevel();
		}
		return b.GetUniqueId() - a.GetUniqueId();
	}

	// Token: 0x0600FD5E RID: 64862 RVA: 0x0049F758 File Offset: 0x0049D958
	public ItemDataBase[] GetExpMaterialList(int uniqueId, int quality = 0, bool checkLock = false, bool withoutPhantom = false)
	{
		List<ItemInfo> levelUpItemList = PhantomBattleController.Instance.GetLevelUpItemList(uniqueId);
		List<ItemDataBase> list = new List<ItemDataBase>();
		foreach (ItemInfo itemInfo in levelUpItemList)
		{
			List<ItemDataBase> itemDataBaseByConfigId = InventoryModel.Instance.GetItemDataBaseByConfigId(itemInfo.Id);
			int count = itemDataBaseByConfigId.Count;
			for (int i = 0; i < count; i++)
			{
				ItemDataBase itemDataBase = itemDataBaseByConfigId[i];
				if (quality <= 0 || itemDataBase.GetQuality() <= quality)
				{
					list.Add(itemDataBase);
				}
			}
		}
		if (withoutPhantom)
		{
			return list.ToArray();
		}
		foreach (ItemDataBase itemDataBase2 in InventoryModel.Instance.GetItemDataBaseByMainType(InventoryDefine.EItemMainTypeId.Phantom))
		{
			if (itemDataBase2.GetType().GetValueOrDefault() == InventoryDefine.EItemType.Phantom)
			{
				if (itemDataBase2.GetUniqueId() == uniqueId || (checkLock && itemDataBase2.GetIsLock()) || (quality > 0 && itemDataBase2.GetQuality() > quality))
				{
					continue;
				}
				PhantomBattleData phantomBattleData = this.GetPhantomBattleData(itemDataBase2.GetUniqueId());
				int num;
				if ((phantomBattleData.GetPhantomLevel() == 0 && phantomBattleData.GetExp() == 0) || (this.PhantomEquipmentRoleMap.ContainsKey(itemDataBase2.GetUniqueId()) && this.PhantomEquipmentRoleMap.TryGetValue(itemDataBase2.GetUniqueId(), out num) && num != 0))
				{
					continue;
				}
			}
			list.Add(itemDataBase2);
		}
		return list.ToArray();
	}

	// Token: 0x0600FD5F RID: 64863 RVA: 0x0049F8E4 File Offset: 0x0049DAE4
	public bool GetIfSimpleState(int key)
	{
		Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.IsSimpleDetail, null);
		bool flag;
		return player != null && player.TryGetValue(key, out flag) && flag;
	}

	// Token: 0x0600FD60 RID: 64864 RVA: 0x0049F910 File Offset: 0x0049DB10
	public void SaveIfSimpleState(int key, bool state)
	{
		Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.IsSimpleDetail, null);
		if (dictionary == null)
		{
			dictionary = new Dictionary<int, bool>();
		}
		dictionary[key] = state;
		LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.IsSimpleDetail, dictionary);
		EventSystem.Instance.Emit(EEventName.ChangeVisionSimplyState);
	}

	// Token: 0x0600FD61 RID: 64865 RVA: 0x0049F950 File Offset: 0x0049DB50
	public void SaveVisionSkillState(int key, bool state)
	{
		Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.VisionSpecialSkillShowMap, null);
		if (dictionary == null)
		{
			dictionary = new Dictionary<int, bool>();
		}
		dictionary[key] = state;
		LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.VisionSpecialSkillShowMap, dictionary);
	}

	// Token: 0x0600FD62 RID: 64866 RVA: 0x0049F980 File Offset: 0x0049DB80
	public bool GetIfVisionSkillState(int key)
	{
		Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.VisionSpecialSkillShowMap, null);
		bool flag;
		return player != null && player.TryGetValue(key, out flag) && flag;
	}

	// Token: 0x0600FD63 RID: 64867 RVA: 0x0049F9AC File Offset: 0x0049DBAC
	public Dictionary<int, int> CalculateExpBackItem(int exp)
	{
		IReadOnlyList<PhantomExpItem> phantomExpItemList = PhantomBattleConfig.Instance.GetPhantomExpItemList();
		int count = phantomExpItemList.Count;
		int num = exp;
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = count - 1; i >= 0; i--)
		{
			int num2 = (int)Math.Floor((double)((float)num / (float)phantomExpItemList[i].Exp));
			num %= phantomExpItemList[i].Exp;
			if (num2 > 0)
			{
				dictionary[phantomExpItemList[i].ItemId] = num2;
			}
		}
		return dictionary;
	}

	// Token: 0x0600FD64 RID: 64868 RVA: 0x0049FA30 File Offset: 0x0049DC30
	public bool CheckVisionIdentifyRedDot(int uniqueId)
	{
		PhantomDataBase phantomDataBase = this.GetPhantomDataBase(uniqueId);
		if (phantomDataBase != null)
		{
			bool ifHaveUnIdentifySubProp = phantomDataBase.GetIfHaveUnIdentifySubProp();
			bool ifHaveEnoughIdentifyConsumeItem = phantomDataBase.GetIfHaveEnoughIdentifyConsumeItem(1);
			return ifHaveUnIdentifySubProp && ifHaveEnoughIdentifyConsumeItem;
		}
		return false;
	}

	// Token: 0x0600FD65 RID: 64869 RVA: 0x0049FA5C File Offset: 0x0049DC5C
	public bool CheckVisionLevelUpSettingRedDot()
	{
		return !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.VisionLevelUpSettingRedDot, false) || !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.VisionLevelUpIdentifyRedDot, false);
	}

	// Token: 0x0600FD66 RID: 64870 RVA: 0x0049FA78 File Offset: 0x0049DC78
	public bool IsVisionHighQuality(PhantomBattleData data)
	{
		int visionLevelUpQualityLimit = PhantomBattleConfig.Instance.GetVisionLevelUpQualityLimit();
		return data.GetConfig().QualityId > visionLevelUpQualityLimit;
	}

	// Token: 0x0600FD67 RID: 64871 RVA: 0x0049FAA4 File Offset: 0x0049DCA4
	public bool IsVisionHighLevel(PhantomBattleData data)
	{
		int visionLevelUpLevelLimit = PhantomBattleConfig.Instance.GetVisionLevelUpLevelLimit();
		return data.GetPhantomLevel() > visionLevelUpLevelLimit;
	}

	// Token: 0x0600FD68 RID: 64872 RVA: 0x0049FAC8 File Offset: 0x0049DCC8
	public bool IsVisionHighRare(PhantomBattleData data)
	{
		int visionLevelUpRareLimit = PhantomBattleConfig.Instance.GetVisionLevelUpRareLimit();
		return data.GetRareConfig().Value.Rare > visionLevelUpRareLimit;
	}

	// Token: 0x17001845 RID: 6213
	// (get) Token: 0x0600FD69 RID: 64873 RVA: 0x0049FAF9 File Offset: 0x0049DCF9
	public List<VisionUnlockQualityData> QualityUnlockTipsList
	{
		get
		{
			return this.QualityUnlockTips;
		}
	}

	// Token: 0x0600FD6A RID: 64874 RVA: 0x0049FB04 File Offset: 0x0049DD04
	public void CacheNewSkinData(int skinId)
	{
		VisionUnlockQualityData visionUnlockQualityData = new VisionUnlockQualityData();
		visionUnlockQualityData.SkinId = skinId;
		visionUnlockQualityData.MonsterItemId = skinId;
		visionUnlockQualityData.IsUnlockMonster = false;
		int qualityId = PhantomBattleConfig.Instance.GetPhantomItemById(skinId).Value.QualityId;
		visionUnlockQualityData.UnlockQuality = qualityId;
		PhantomBattleModel.Instance.QualityUnlockTipsList.Add(visionUnlockQualityData);
	}

	// Token: 0x0600FD6B RID: 64875 RVA: 0x0049FB60 File Offset: 0x0049DD60
	public void CacheNewQualityData(PhantomUnlockNotify notify)
	{
		foreach (int num in notify.UnlockQualityItemList)
		{
			VisionUnlockQualityData visionUnlockQualityData = new VisionUnlockQualityData();
			int qualityId = PhantomBattleConfig.Instance.GetPhantomItemById(num).Value.QualityId;
			visionUnlockQualityData.MonsterItemId = num;
			visionUnlockQualityData.UnlockQuality = qualityId;
			visionUnlockQualityData.IsUnlockMonster = false;
			PhantomBattleModel.Instance.QualityUnlockTipsList.Add(visionUnlockQualityData);
		}
	}

	// Token: 0x0600FD6C RID: 64876 RVA: 0x0049FBF0 File Offset: 0x0049DDF0
	public int GetMainAttributeKey(int key)
	{
		int result;
		if (this.GetSortMainAttributeMap().TryGetValue(key, out result))
		{
			return result;
		}
		int result2;
		if (this.GetSortMainPercentageAttributeMap().TryGetValue(key, out result2))
		{
			return result2;
		}
		return 0;
	}

	// Token: 0x0600FD6D RID: 64877 RVA: 0x0049FC24 File Offset: 0x0049DE24
	public int GetMainAttributeCost(int key)
	{
		int result;
		if (!this.GetSortMainAttributeCostMap().TryGetValue(key, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x0600FD6E RID: 64878 RVA: 0x0049FC44 File Offset: 0x0049DE44
	public Dictionary<int, int> GetSortMainAttributeCostMap()
	{
		if (this.MainAttributeCostMap == null)
		{
			this.MainAttributeCostMap = new Dictionary<int, int>();
			this.MainAttributeCostMap[1001] = 4;
			this.MainAttributeCostMap[1002] = 3;
			this.MainAttributeCostMap[1003] = 1;
			this.MainAttributeCostMap[1004] = 4;
			this.MainAttributeCostMap[1005] = 3;
			this.MainAttributeCostMap[1006] = 1;
			this.MainAttributeCostMap[1007] = 4;
			this.MainAttributeCostMap[1008] = 3;
			this.MainAttributeCostMap[1009] = 1;
		}
		return this.MainAttributeCostMap;
	}

	// Token: 0x0600FD6F RID: 64879 RVA: 0x0049FD08 File Offset: 0x0049DF08
	public int GetSortRuleIdByPropIndex(int propIndex, int addType)
	{
		foreach (KeyValuePair<int, int> keyValuePair in ((addType == 2) ? this.GetSortMainPercentageAttributeMap() : this.GetSortMainAttributeMap()))
		{
			if (propIndex == keyValuePair.Value)
			{
				return keyValuePair.Key;
			}
		}
		return 0;
	}

	// Token: 0x0600FD70 RID: 64880 RVA: 0x0049FD78 File Offset: 0x0049DF78
	public Dictionary<int, int> GetSortMainAttributeMap()
	{
		if (this.MainAttributeMap == null)
		{
			this.MainAttributeMap = new Dictionary<int, int>();
			this.MainAttributeMap[8] = 10007;
			this.MainAttributeMap[6] = 10002;
			this.MainAttributeMap[10] = 10010;
			this.MainAttributeMap[12] = 8;
			this.MainAttributeMap[13] = 9;
			this.MainAttributeMap[14] = 35;
			this.MainAttributeMap[15] = 21;
			this.MainAttributeMap[16] = 22;
			this.MainAttributeMap[17] = 23;
			this.MainAttributeMap[18] = 24;
			this.MainAttributeMap[19] = 25;
			this.MainAttributeMap[20] = 26;
			this.MainAttributeMap[21] = 27;
			this.MainAttributeMap[22] = 11;
		}
		return this.MainAttributeMap;
	}

	// Token: 0x0600FD71 RID: 64881 RVA: 0x0049FE7C File Offset: 0x0049E07C
	public Dictionary<int, int> GetSortMainPercentageAttributeMap()
	{
		if (this.MainPercentageAttributeMap == null)
		{
			this.MainPercentageAttributeMap = new Dictionary<int, int>();
			this.MainPercentageAttributeMap[9] = 10007;
			this.MainPercentageAttributeMap[7] = 10002;
			this.MainPercentageAttributeMap[11] = 10010;
			this.MainPercentageAttributeMap[1001] = 10002;
			this.MainPercentageAttributeMap[1002] = 10002;
			this.MainPercentageAttributeMap[1003] = 10002;
			this.MainPercentageAttributeMap[1004] = 10007;
			this.MainPercentageAttributeMap[1005] = 10007;
			this.MainPercentageAttributeMap[1006] = 10007;
			this.MainPercentageAttributeMap[1007] = 10010;
			this.MainPercentageAttributeMap[1008] = 10010;
			this.MainPercentageAttributeMap[1009] = 10010;
		}
		return this.MainPercentageAttributeMap;
	}

	// Token: 0x0600FD72 RID: 64882 RVA: 0x0049FF98 File Offset: 0x0049E198
	public int GetSubAttributeKey(int key)
	{
		int result;
		if (this.GetSortSubAttributeMap().TryGetValue(key, out result))
		{
			return result;
		}
		int result2;
		if (this.GetSortSubPercentageAttributeMap().TryGetValue(key, out result2))
		{
			return result2;
		}
		return 0;
	}

	// Token: 0x0600FD73 RID: 64883 RVA: 0x0049FFCC File Offset: 0x0049E1CC
	public Dictionary<int, int> GetSortSubAttributeMap()
	{
		if (this.SubAttributeMap == null)
		{
			this.SubAttributeMap = new Dictionary<int, int>();
			this.SubAttributeMap[25] = 2;
			this.SubAttributeMap[23] = 1;
			this.SubAttributeMap[27] = 3;
			this.SubAttributeMap[29] = 11;
			this.SubAttributeMap[30] = 12;
			this.SubAttributeMap[36] = 11;
			this.SubAttributeMap[37] = 12;
			this.SubAttributeMap[38] = 13;
			this.SubAttributeMap[39] = 13;
			this.SubAttributeMap[47] = 7;
			this.SubAttributeMap[48] = 8;
			this.SubAttributeMap[49] = 9;
			this.SubAttributeMap[50] = 10;
		}
		return this.SubAttributeMap;
	}

	// Token: 0x0600FD74 RID: 64884 RVA: 0x004A00B4 File Offset: 0x0049E2B4
	public Dictionary<int, int> GetSortSubPercentageAttributeMap()
	{
		if (this.SubPercentageAttributeMap == null)
		{
			this.SubPercentageAttributeMap = new Dictionary<int, int>();
			this.SubPercentageAttributeMap[26] = 5;
			this.SubPercentageAttributeMap[24] = 4;
			this.SubPercentageAttributeMap[28] = 6;
		}
		return this.SubPercentageAttributeMap;
	}

	// Token: 0x0600FD75 RID: 64885 RVA: 0x004A0104 File Offset: 0x0049E304
	public void GmClearData()
	{
		this.QualityUnlockTips.Clear();
	}

	// Token: 0x0600FD76 RID: 64886 RVA: 0x004A0111 File Offset: 0x0049E311
	public void RecordVisionRecoveryRedDot(bool value)
	{
		ServerStorageBoolean serverStorageBoolean = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.VisionRecoveryBatchTip) as ServerStorageBoolean;
		if (serverStorageBoolean != null)
		{
			serverStorageBoolean.Set(new bool?(value));
		}
		EventSystem.Instance.Emit(EEventName.OnVisionRecoveryStorage);
	}

	// Token: 0x0600FD77 RID: 64887 RVA: 0x004A0148 File Offset: 0x0049E348
	public bool GetVisionRecoveryBatchRedDot()
	{
		ServerStorageBoolean serverStorageBoolean = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.VisionRecoveryBatchTip) as ServerStorageBoolean;
		bool valueOrDefault = ((serverStorageBoolean != null) ? serverStorageBoolean.Get() : null).GetValueOrDefault(true);
		return FunctionModel.Instance.IsOpen(10024001) && valueOrDefault;
	}

	// Token: 0x0600FD78 RID: 64888 RVA: 0x004A0195 File Offset: 0x0049E395
	public void RecordVisionRecoveryAimRedDot(bool value)
	{
		if (!FunctionModel.Instance.IsOpen(EFunctionType.VisionAim))
		{
			return;
		}
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.VisionRecoveryBatchAimTip) as ServerStorageBoolean).Set(new bool?(value));
		EventSystem.Instance.Emit(EEventName.OnVisionRecoveryStorage);
	}

	// Token: 0x0600FD79 RID: 64889 RVA: 0x004A01D8 File Offset: 0x0049E3D8
	public bool GetVisionRecoveryBatchAimRedDot()
	{
		bool valueOrDefault = (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.VisionRecoveryBatchAimTip) as ServerStorageBoolean).Get().GetValueOrDefault(true);
		return FunctionModel.Instance.IsOpen(EFunctionType.VisionAim) && valueOrDefault;
	}

	// Token: 0x0600FD7A RID: 64890 RVA: 0x004A0218 File Offset: 0x0049E418
	public List<global::PhantomItemData> GetVisionRecoverySortPhantomItemList(List<AddCountItemInfo> itemInfos)
	{
		List<global::PhantomItemData> phantomItemDataListByAddCountItemInfo = InventoryModel.Instance.GetPhantomItemDataListByAddCountItemInfo(itemInfos);
		HashSet<int> hashSet = new HashSet<int>();
		hashSet.Add(3);
		hashSet.Add(4);
		SortModel.Instance.SortDataByData<global::PhantomItemData>(phantomItemDataListByAddCountItemInfo, ESortDataType.Phantom, hashSet, false);
		return phantomItemDataListByAddCountItemInfo;
	}

	// Token: 0x0600FD7B RID: 64891 RVA: 0x004A0256 File Offset: 0x0049E456
	public void RecordVisionRefineRedDot(bool value)
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.VisionRefineTip) as ServerStorageBoolean).Set(new bool?(value));
		EventSystem.Instance.Emit(EEventName.OnVisionRefineStorage);
	}

	// Token: 0x0600FD7C RID: 64892 RVA: 0x004A0284 File Offset: 0x0049E484
	public bool GetVisionRefineRedDot()
	{
		bool valueOrDefault = (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.VisionRefineTip) as ServerStorageBoolean).Get().GetValueOrDefault(true);
		return FunctionModel.Instance.IsOpen(10083) && valueOrDefault;
	}

	// Token: 0x0600FD7D RID: 64893 RVA: 0x004A02C4 File Offset: 0x0049E4C4
	[NullableContext(2)]
	public Dictionary<int, int> GetVisionRefineMaterialCost(int uniqueId)
	{
		PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(uniqueId);
		if (phantomDataBase != null)
		{
			return phantomDataBase.GetRareConfig().Value.PolishCost();
		}
		return null;
	}

	// Token: 0x0600FD7E RID: 64894 RVA: 0x004A02F8 File Offset: 0x0049E4F8
	[return: Nullable(2)]
	public Dictionary<int, int> GetVisionListRefineMainMaterialCost(List<int> uniqueIdList)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (int uniqueId in uniqueIdList)
		{
			Dictionary<int, int> visionRefineMaterialCost = this.GetVisionRefineMaterialCost(uniqueId);
			if (visionRefineMaterialCost != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair in visionRefineMaterialCost)
				{
					int num;
					if (dictionary.TryGetValue(keyValuePair.Key, out num))
					{
						dictionary[keyValuePair.Key] = num + keyValuePair.Value;
					}
					else
					{
						dictionary[keyValuePair.Key] = keyValuePair.Value;
					}
				}
			}
		}
		if (dictionary.Count == 0)
		{
			return null;
		}
		return dictionary;
	}

	// Token: 0x0600FD7F RID: 64895 RVA: 0x004A03D4 File Offset: 0x0049E5D4
	[NullableContext(2)]
	public Dictionary<int, int> GetVisionRefineSubMaterialCost(int lockCount)
	{
		PhantomVicePolishConfig? phantomVicePolishCostByLockCount = PhantomBattleConfig.Instance.GetPhantomVicePolishCostByLockCount(lockCount);
		if (phantomVicePolishCostByLockCount == null)
		{
			return null;
		}
		return phantomVicePolishCostByLockCount.Value.Cost();
	}

	// Token: 0x0600FD80 RID: 64896 RVA: 0x004A0408 File Offset: 0x0049E608
	[NullableContext(2)]
	public Dictionary<int, int> GetVisionRefineMaterialDefaultCost()
	{
		IReadOnlyList<PhantomRarity> phantomRareConfigAll = PhantomBattleConfig.Instance.GetPhantomRareConfigAll();
		if (phantomRareConfigAll.Count > 0)
		{
			return phantomRareConfigAll[0].PolishCost();
		}
		return null;
	}

	// Token: 0x0600FD81 RID: 64897 RVA: 0x004A043C File Offset: 0x0049E63C
	[NullableContext(2)]
	public Dictionary<int, int> GetVisionRefineSubMaterialDefaultCost()
	{
		IReadOnlyList<PhantomVicePolishConfig> phantomVicePolishConfigAll = PhantomBattleConfig.Instance.GetPhantomVicePolishConfigAll();
		if (phantomVicePolishConfigAll != null && phantomVicePolishConfigAll.Count > 0)
		{
			Dictionary<int, int> dictionary = phantomVicePolishConfigAll[0].Cost();
			if (dictionary.Count > 0)
			{
				int key = 0;
				using (Dictionary<int, int>.Enumerator enumerator = dictionary.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						KeyValuePair<int, int> keyValuePair = enumerator.Current;
						key = keyValuePair.Key;
					}
				}
				return new Dictionary<int, int>
				{
					{
						key,
						0
					}
				};
			}
		}
		return null;
	}

	// Token: 0x0600FD82 RID: 64898 RVA: 0x004A04D0 File Offset: 0x0049E6D0
	public bool IsVisionRefineMaterialEnough(int uniqueId)
	{
		Dictionary<int, int> visionRefineMaterialCost = this.GetVisionRefineMaterialCost(uniqueId);
		if (visionRefineMaterialCost == null)
		{
			return false;
		}
		foreach (KeyValuePair<int, int> keyValuePair in visionRefineMaterialCost)
		{
			int value = keyValuePair.Value;
			if (InventoryModel.Instance.GetItemCountByConfigId(keyValuePair.Key, 0) < value)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600FD83 RID: 64899 RVA: 0x004A054C File Offset: 0x0049E74C
	public bool IsVisionListRefineMainMaterialEnough(List<int> uniqueIdList)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (int uniqueId in uniqueIdList)
		{
			Dictionary<int, int> visionRefineMaterialCost = this.GetVisionRefineMaterialCost(uniqueId);
			if (visionRefineMaterialCost != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair in visionRefineMaterialCost)
				{
					int num;
					if (dictionary.TryGetValue(keyValuePair.Key, out num))
					{
						dictionary[keyValuePair.Key] = num + keyValuePair.Value;
					}
					else
					{
						dictionary[keyValuePair.Key] = keyValuePair.Value;
					}
				}
			}
		}
		foreach (KeyValuePair<int, int> keyValuePair2 in dictionary)
		{
			int value = keyValuePair2.Value;
			if (InventoryModel.Instance.GetItemCountByConfigId(keyValuePair2.Key, 0) < value)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600FD84 RID: 64900 RVA: 0x004A0680 File Offset: 0x0049E880
	public bool IsVisionRefineSubMaterialEnough(int count)
	{
		Dictionary<int, int> visionRefineSubMaterialCost = this.GetVisionRefineSubMaterialCost(count);
		if (visionRefineSubMaterialCost == null)
		{
			return false;
		}
		using (Dictionary<int, int>.Enumerator enumerator = visionRefineSubMaterialCost.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				KeyValuePair<int, int> keyValuePair = enumerator.Current;
				return InventoryModel.Instance.GetItemCountByConfigId(keyValuePair.Key, 0) >= keyValuePair.Value;
			}
		}
		return false;
	}

	// Token: 0x0600FD85 RID: 64901 RVA: 0x004A06F8 File Offset: 0x0049E8F8
	public int GetPhantomMainRandGroupId(int itemId)
	{
		int randGroupId = PhantomBattleConfig.Instance.GetPhantomItemById(itemId).Value.MainProp.Value.RandGroupId;
		if (randGroupId == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.WDX;
			string message = "获取幻象主属性组配置失败, 请检查配置表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", itemId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return -1;
		}
		return randGroupId;
	}

	// Token: 0x0600FD86 RID: 64902 RVA: 0x004A0768 File Offset: 0x0049E968
	public int[] GetPhantomMainPropItemRefineAvailableIdList(int itemId)
	{
		int phantomMainRandGroupId = this.GetPhantomMainRandGroupId(itemId);
		IReadOnlyList<PhantomMainProperty> phantomMainPropertyByRandGroupId = PhantomBattleConfig.Instance.GetPhantomMainPropertyByRandGroupId(phantomMainRandGroupId);
		if (phantomMainPropertyByRandGroupId == null || phantomMainPropertyByRandGroupId.Count == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.WDX;
			string message = "获取幻象主属性池失败, 请检查配置表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", itemId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new int[0];
		}
		List<int> list = new List<int>();
		foreach (PhantomMainProperty phantomMainProperty in phantomMainPropertyByRandGroupId)
		{
			int[] array = phantomMainProperty.PropGroup();
			list.Add(array[0]);
		}
		return list.ToArray();
	}

	// Token: 0x0600FD87 RID: 64903 RVA: 0x004A0820 File Offset: 0x0049EA20
	public void SetSelfPhantomConfigCode(string value)
	{
		this.PhantomConfigData.SelfPhantomConfigCode = value;
	}

	// Token: 0x0600FD88 RID: 64904 RVA: 0x004A082E File Offset: 0x0049EA2E
	public PhantomManagerConfigData GetPhantomConfigData()
	{
		return this.PhantomConfigData;
	}

	// Token: 0x0600FD89 RID: 64905 RVA: 0x004A0836 File Offset: 0x0049EA36
	public string GetSelfPhantomConfigCode()
	{
		return this.PhantomConfigData.SelfPhantomConfigCode;
	}

	// Token: 0x0600FD8A RID: 64906 RVA: 0x004A0843 File Offset: 0x0049EA43
	public void UpdatePhantomConfigData(PhBaOneAllSuitPlan allPlan)
	{
		this.PhantomConfigData.UpdateFetterMap(allPlan.SuitPlanList);
	}

	// Token: 0x0600FD8B RID: 64907 RVA: 0x004A0856 File Offset: 0x0049EA56
	public void CacheShareConfigData(PhBaOneAllSuitPlan allPlan)
	{
		this.PhantomConfigData.CacheShareFetterMap(allPlan.SuitPlanList);
	}

	// Token: 0x17001846 RID: 6214
	// (get) Token: 0x0600FD8C RID: 64908 RVA: 0x004A0869 File Offset: 0x0049EA69
	public static PhantomBattleModel Instance
	{
		get
		{
			return PhantomBattleModel._Instance;
		}
	}

	// Token: 0x0600FD8D RID: 64909 RVA: 0x004A0870 File Offset: 0x0049EA70
	public static PhantomBattleModel GetOrCreateInstance()
	{
		if (PhantomBattleModel._Instance == null)
		{
			PhantomBattleModel.CreateInstance();
		}
		return PhantomBattleModel._Instance;
	}

	// Token: 0x0600FD8E RID: 64910 RVA: 0x004A0884 File Offset: 0x0049EA84
	public static bool CreateInstance()
	{
		if (PhantomBattleModel._Instance != null)
		{
			return true;
		}
		PhantomBattleModel._Instance = new PhantomBattleModel();
		return true;
	}

	// Token: 0x0600FD8F RID: 64911 RVA: 0x004A089A File Offset: 0x0049EA9A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FD90 RID: 64912 RVA: 0x004A089C File Offset: 0x0049EA9C
	public static void ResetStaticDefaultValue()
	{
		PhantomBattleModel._Instance = null;
	}

	// Token: 0x0600FD91 RID: 64913 RVA: 0x004A08A4 File Offset: 0x0049EAA4
	static PhantomBattleModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomBattleModel.CreateStaticDefaultValue), new Action(PhantomBattleModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008CFC RID: 36092
	private readonly Dictionary<int, PhantomBattleData> RobotDataMap;

	// Token: 0x04008CFD RID: 36093
	private readonly Dictionary<int, PhantomRoleEquipmentData> BattleDataMap;

	// Token: 0x04008CFE RID: 36094
	private readonly Dictionary<int, int> PhantomEquipmentRoleMap;

	// Token: 0x04008CFF RID: 36095
	private readonly Dictionary<int, PhantomBattleInstance> PhantomInstanceMap;

	// Token: 0x04008D00 RID: 36096
	private readonly Dictionary<int, PhantomBattleData> PhantomBattleDataMap;

	// Token: 0x04008D01 RID: 36097
	private List<PhantomBattleData> UnEquipVisionArray;

	// Token: 0x04008D02 RID: 36098
	private bool UnEquipVisionArrayRefreshTag;

	// Token: 0x04008D03 RID: 36099
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, int[]> FetterGroupMonsterMap;

	// Token: 0x04008D04 RID: 36100
	[Nullable(2)]
	public PhantomBattleData CurrentSelectData;

	// Token: 0x04008D05 RID: 36101
	public int CurrentEquipmentSelectIndex;

	// Token: 0x04008D06 RID: 36102
	public int CurrentSelectUniqueId;

	// Token: 0x04008D07 RID: 36103
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CustomPromise<UCurveFloat> LoadingCurvePromise;

	// Token: 0x04008D08 RID: 36104
	public bool LevelUpConfirmTipsNotShow;

	// Token: 0x04008D09 RID: 36105
	private FVector PhantomMeshZoom;

	// Token: 0x04008D0A RID: 36106
	private FVector PhantomMeshLocation;

	// Token: 0x04008D0B RID: 36107
	private FRotator PhantomMeshRotator;

	// Token: 0x04008D0C RID: 36108
	private readonly Dictionary<int, int> LevelUpItemData;

	// Token: 0x04008D0D RID: 36109
	private TItem[] TempSaveItemList;

	// Token: 0x04008D0E RID: 36110
	[Nullable(2)]
	private LevelUpPastVisionData PastVisionLevelUpData;

	// Token: 0x04008D0F RID: 36111
	private bool VisionLevelUpTag;

	// Token: 0x04008D10 RID: 36112
	private int CurrentDraggingIndex;

	// Token: 0x04008D11 RID: 36113
	private int CurrentMaxCost;

	// Token: 0x04008D12 RID: 36114
	[Nullable(2)]
	private int[] UnlockSkin;

	// Token: 0x04008D13 RID: 36115
	private readonly Dictionary<int, int[]> MonsterSkinMap;

	// Token: 0x04008D14 RID: 36116
	private readonly Dictionary<int, int> MonsterSkinMonsterIdMap;

	// Token: 0x04008D15 RID: 36117
	[Nullable(2)]
	private Dictionary<int, int> MainAttributeMap;

	// Token: 0x04008D16 RID: 36118
	[Nullable(2)]
	private Dictionary<int, int> MainPercentageAttributeMap;

	// Token: 0x04008D17 RID: 36119
	[Nullable(2)]
	private Dictionary<int, int> SubAttributeMap;

	// Token: 0x04008D18 RID: 36120
	[Nullable(2)]
	private Dictionary<int, int> SubPercentageAttributeMap;

	// Token: 0x04008D19 RID: 36121
	[Nullable(2)]
	private Dictionary<int, int> MainAttributeCostMap;

	// Token: 0x04008D1A RID: 36122
	private EVisionLevelUpMaterialPutInMode VisionLevelUpMaterialPutInMode;

	// Token: 0x04008D1B RID: 36123
	private EVisionLevelUpMaterialUseType VisionLevelUpMaterialUseType;

	// Token: 0x04008D1C RID: 36124
	private EVisionLevelUpIdentify VisionLevelUpIdentify;

	// Token: 0x04008D1D RID: 36125
	public bool PhantomRefineAcceptIgnore;

	// Token: 0x04008D1E RID: 36126
	public bool PhantomRefineRejectIgnore;

	// Token: 0x04008D1F RID: 36127
	private int NeedCameraFocusMethodDisableViewCount;

	// Token: 0x04008D20 RID: 36128
	private PhantomFetter? Fetter;

	// Token: 0x04008D21 RID: 36129
	public int CurrentSelectFetterGroupId;

	// Token: 0x04008D22 RID: 36130
	[Nullable(2)]
	private RecommendData RecommendData;

	// Token: 0x04008D23 RID: 36131
	private readonly List<VisionUnlockQualityData> QualityUnlockTips;

	// Token: 0x04008D24 RID: 36132
	protected PhantomManagerConfigData PhantomConfigData = new PhantomManagerConfigData();

	// Token: 0x04008D25 RID: 36133
	[Nullable(2)]
	private static PhantomBattleModel _Instance;
}

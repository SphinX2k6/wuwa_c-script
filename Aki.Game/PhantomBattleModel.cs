using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.PhantomBattle;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002422 RID: 9250
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PhantomBattleModel : ModelBase
{
	// Token: 0x06012836 RID: 75830 RVA: 0x0048F748 File Offset: 0x0048D948
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

	// Token: 0x06012837 RID: 75831 RVA: 0x0048F821 File Offset: 0x0048DA21
	public void SetCurrentDragIndex(int index)
	{
		this.CurrentDraggingIndex = index;
	}

	// Token: 0x06012838 RID: 75832 RVA: 0x0048F82A File Offset: 0x0048DA2A
	public void ClearCurrentDragIndex()
	{
		this.CurrentDraggingIndex = 999;
	}

	// Token: 0x06012839 RID: 75833 RVA: 0x0048F837 File Offset: 0x0048DA37
	public bool CheckIfCurrentDragIndex(int index)
	{
		return this.CurrentDraggingIndex == index;
	}

	// Token: 0x0601283A RID: 75834 RVA: 0x0048F842 File Offset: 0x0048DA42
	public bool CheckIfCanDrag()
	{
		return this.CurrentDraggingIndex == 999;
	}

	// Token: 0x0601283B RID: 75835 RVA: 0x0048F854 File Offset: 0x0048DA54
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

	// Token: 0x0601283C RID: 75836 RVA: 0x0048F98C File Offset: 0x0048DB8C
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		return true;
	}

	// Token: 0x0601283D RID: 75837 RVA: 0x0048F9AC File Offset: 0x0048DBAC
	private void OnWorldDone()
	{
		this.VisionLevelUpMaterialPutInMode = LocalStorage.GetPlayer<EVisionLevelUpMaterialPutInMode?>(ELocalStoragePlayerKey.VisionLevelUpMaterialPutInMode, null).GetValueOrDefault();
		this.VisionLevelUpMaterialUseType = LocalStorage.GetPlayer<EVisionLevelUpMaterialUseType?>(ELocalStoragePlayerKey.VisionLevelUpMaterialUseType, null).GetValueOrDefault();
		this.VisionLevelUpIdentify = LocalStorage.GetPlayer<EVisionLevelUpIdentify?>(ELocalStoragePlayerKey.VisionLevelUpIdentify, null).GetValueOrDefault();
	}

	// Token: 0x0601283E RID: 75838 RVA: 0x0048FA18 File Offset: 0x0048DC18
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

	// Token: 0x0601283F RID: 75839 RVA: 0x0048FA5C File Offset: 0x0048DC5C
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

	// Token: 0x06012840 RID: 75840 RVA: 0x0048FAC8 File Offset: 0x0048DCC8
	public void SetUnlockSkinList(int[] skins)
	{
		this.UnlockSkin = skins;
	}

	// Token: 0x06012841 RID: 75841 RVA: 0x0048FAD4 File Offset: 0x0048DCD4
	public void ConcatUnlockSkinList(List<int> skins)
	{
		List<int> list = new List<int>(this.UnlockSkin);
		list.AddRange(skins);
		this.UnlockSkin = list.ToArray();
	}

	// Token: 0x06012842 RID: 75842 RVA: 0x0048FB00 File Offset: 0x0048DD00
	public bool GetSkinIsUnlock(int skinId)
	{
		return Array.IndexOf<int>(this.UnlockSkin, skinId) >= 0;
	}

	// Token: 0x06012843 RID: 75843 RVA: 0x0048FB14 File Offset: 0x0048DD14
	[NullableContext(2)]
	public int[] GetMonsterSkinListByMonsterId(int monsterId)
	{
		int[] result;
		if (this.MonsterSkinMap.TryGetValue(monsterId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06012844 RID: 75844 RVA: 0x0048FB34 File Offset: 0x0048DD34
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

	// Token: 0x06012845 RID: 75845 RVA: 0x0048FBCC File Offset: 0x0048DDCC
	public int? GetMonsterSkinMonsterIdMapByMonsterId(int monsterId)
	{
		int value;
		if (this.MonsterSkinMonsterIdMap.TryGetValue(monsterId, out value))
		{
			return new int?(value);
		}
		return null;
	}

	// Token: 0x06012846 RID: 75846 RVA: 0x0048FBF9 File Offset: 0x0048DDF9
	public void SetMaxCost(int cost)
	{
		this.CurrentMaxCost = cost;
	}

	// Token: 0x06012847 RID: 75847 RVA: 0x0048FC02 File Offset: 0x0048DE02
	public int GetMaxCost()
	{
		return this.CurrentMaxCost;
	}

	// Token: 0x06012848 RID: 75848 RVA: 0x0048FC0A File Offset: 0x0048DE0A
	public void SetRobotPhantomData(int incrId, PhantomTrialBattleData data)
	{
		this.RobotDataMap[incrId] = data;
	}

	// Token: 0x06012849 RID: 75849 RVA: 0x0048FC1C File Offset: 0x0048DE1C
	public PhantomBattleData NewPhantomBattleData(Aki.Protocol.PhantomItem phantomItemInfo)
	{
		PhantomBattleData phantomBattleData = new PhantomBattleData();
		phantomBattleData.SetData(phantomItemInfo);
		this.PhantomBattleDataMap[phantomItemInfo.IncrId] = phantomBattleData;
		this.UnEquipVisionArrayRefreshTag = true;
		return phantomBattleData;
	}

	// Token: 0x0601284A RID: 75850 RVA: 0x0048FC50 File Offset: 0x0048DE50
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

	// Token: 0x0601284B RID: 75851 RVA: 0x0048FC9A File Offset: 0x0048DE9A
	public void RemovePhantomBattleData(int uniqueId)
	{
		this.PhantomBattleDataMap.Remove(uniqueId);
		this.UnEquipVisionArrayRefreshTag = true;
	}

	// Token: 0x0601284C RID: 75852 RVA: 0x0048FCB0 File Offset: 0x0048DEB0
	[NullableContext(2)]
	public PhantomDataBase GetPhantomDataBase(int uniqueId)
	{
		return this.GetPhantomBattleData(uniqueId);
	}

	// Token: 0x0601284D RID: 75853 RVA: 0x0048FCBC File Offset: 0x0048DEBC
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

	// Token: 0x0601284E RID: 75854 RVA: 0x0048FCF4 File Offset: 0x0048DEF4
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

	// Token: 0x0601284F RID: 75855 RVA: 0x0048FD38 File Offset: 0x0048DF38
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

	// Token: 0x06012850 RID: 75856 RVA: 0x0048FD9B File Offset: 0x0048DF9B
	public void CachePhantomLevelUpData(LevelUpPastVisionData data)
	{
		this.PastVisionLevelUpData = data;
	}

	// Token: 0x06012851 RID: 75857 RVA: 0x0048FDA4 File Offset: 0x0048DFA4
	[NullableContext(2)]
	public LevelUpPastVisionData GetCachePhantomLevelUpData()
	{
		return this.PastVisionLevelUpData;
	}

	// Token: 0x06012852 RID: 75858 RVA: 0x0048FDAC File Offset: 0x0048DFAC
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

	// Token: 0x06012853 RID: 75859 RVA: 0x00490030 File Offset: 0x0048E230
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

	// Token: 0x06012854 RID: 75860 RVA: 0x00490110 File Offset: 0x0048E310
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

	// Token: 0x06012855 RID: 75861 RVA: 0x004901D0 File Offset: 0x0048E3D0
	public bool GetVisionLevelUpTag()
	{
		return this.VisionLevelUpTag;
	}

	// Token: 0x06012856 RID: 75862 RVA: 0x004901D8 File Offset: 0x0048E3D8
	public void ClearVisionLevelUp()
	{
		this.VisionLevelUpTag = false;
	}

	// Token: 0x06012857 RID: 75863 RVA: 0x004901E1 File Offset: 0x0048E3E1
	public TItem[] GetTempSaveItemList()
	{
		return this.TempSaveItemList;
	}

	// Token: 0x06012858 RID: 75864 RVA: 0x004901EC File Offset: 0x0048E3EC
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

	// Token: 0x06012859 RID: 75865 RVA: 0x0049023C File Offset: 0x0048E43C
	public void ClearTempSaveItemList()
	{
		this.TempSaveItemList = new TItem[0];
	}

	// Token: 0x0601285A RID: 75866 RVA: 0x0049024C File Offset: 0x0048E44C
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

	// Token: 0x0601285B RID: 75867 RVA: 0x004903F0 File Offset: 0x0048E5F0
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

	// Token: 0x0601285C RID: 75868 RVA: 0x0049059C File Offset: 0x0048E79C
	public Dictionary<int, PhantomBattleData> GetPhantomBattleDataMap()
	{
		return this.PhantomBattleDataMap;
	}

	// Token: 0x0601285D RID: 75869 RVA: 0x004905A4 File Offset: 0x0048E7A4
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

	// Token: 0x0601285E RID: 75870 RVA: 0x00490638 File Offset: 0x0048E838
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

	// Token: 0x0601285F RID: 75871 RVA: 0x00490730 File Offset: 0x0048E930
	public void UpdateRoleEquipmentPropData(RolePhantomPropInfo data)
	{
		this.GetBattleDataById(data.RoleId).Phrase(data);
	}

	// Token: 0x06012860 RID: 75872 RVA: 0x00490744 File Offset: 0x0048E944
	public void DeleteBattleData(int roleId)
	{
		PhantomRoleEquipmentData phantomRoleEquipmentData;
		if (!this.BattleDataMap.TryGetValue(roleId, out phantomRoleEquipmentData))
		{
			return;
		}
		foreach (int key in phantomRoleEquipmentData.GetIncrIdList())
		{
			this.PhantomEquipmentRoleMap.Remove(key);
		}
		this.UnEquipVisionArrayRefreshTag = true;
		this.BattleDataMap.Remove(roleId);
	}

	// Token: 0x06012861 RID: 75873 RVA: 0x004907C4 File Offset: 0x0048E9C4
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

	// Token: 0x06012862 RID: 75874 RVA: 0x004907F5 File Offset: 0x0048E9F5
	public bool CheckPhantomIsEquip(int uniqueId)
	{
		return uniqueId < 0 || (uniqueId != 0 && this.PhantomEquipmentRoleMap.ContainsKey(uniqueId));
	}

	// Token: 0x06012863 RID: 75875 RVA: 0x00490810 File Offset: 0x0048EA10
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

	// Token: 0x06012864 RID: 75876 RVA: 0x00490858 File Offset: 0x0048EA58
	public bool CheckPhantomIsSub(int uniqueId)
	{
		if (!this.CheckPhantomIsEquip(uniqueId))
		{
			return false;
		}
		int roleId = this.PhantomEquipmentRoleMap[uniqueId];
		return this.GetBattleDataById(roleId).CheckPhantomIsSub(uniqueId);
	}

	// Token: 0x06012865 RID: 75877 RVA: 0x0049088C File Offset: 0x0048EA8C
	public int? GetPhantomEquipOnRoleId(int uniqueId)
	{
		if (!this.CheckPhantomIsEquip(uniqueId))
		{
			return null;
		}
		return new int?(this.PhantomEquipmentRoleMap[uniqueId]);
	}

	// Token: 0x06012866 RID: 75878 RVA: 0x004908BD File Offset: 0x0048EABD
	public bool CheckPhantomIndexIsEquipOnRole(int roleId, int index)
	{
		return this.GetBattleDataById(roleId).GetIndexPhantomId(index) != -1;
	}

	// Token: 0x06012867 RID: 75879 RVA: 0x004908D2 File Offset: 0x0048EAD2
	public int GetPhantomSumLevelByRoleId(int roleId)
	{
		return this.GetBattleDataById(roleId).GetSumEquipLevel();
	}

	// Token: 0x06012868 RID: 75880 RVA: 0x004908E0 File Offset: 0x0048EAE0
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

	// Token: 0x06012869 RID: 75881 RVA: 0x00490944 File Offset: 0x0048EB44
	public bool CheckPhantomIfLevelMax(int uniqueId)
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(uniqueId);
		return phantomItemDataByUniqueId.GetPhantomLevel() == PhantomBattleConfig.Instance.GetPhantomQualityByItemQuality(phantomItemDataByUniqueId.GetQuality()).Value.LevelLimit;
	}

	// Token: 0x0601286A RID: 75882 RVA: 0x00490985 File Offset: 0x0048EB85
	public bool CheckMonsterIsEquipOnRole(int roleId, int monsterId)
	{
		return this.GetBattleDataById(roleId).CheckMonsterIsEquip(monsterId);
	}

	// Token: 0x0601286B RID: 75883 RVA: 0x00490994 File Offset: 0x0048EB94
	public int GetVisionIndexOnRole(int uniqueId, int roleId)
	{
		return this.GetBattleDataById(roleId).GetIndexPhantomId(uniqueId);
	}

	// Token: 0x0601286C RID: 75884 RVA: 0x004909A4 File Offset: 0x0048EBA4
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

	// Token: 0x0601286D RID: 75885 RVA: 0x004909E1 File Offset: 0x0048EBE1
	public int GetRoleIndexPhantomId(int roleId, int index)
	{
		return this.GetBattleDataById(roleId).GetIndexPhantomId(index);
	}

	// Token: 0x0601286E RID: 75886 RVA: 0x004909F0 File Offset: 0x0048EBF0
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

	// Token: 0x0601286F RID: 75887 RVA: 0x00490A2E File Offset: 0x0048EC2E
	public EEquipType GetRolePhantomEquipState(int roleId, int index, int uniqueId)
	{
		if (!this.CheckPhantomIsEquip(uniqueId))
		{
			return EEquipType.Equip;
		}
		return this.GetBattleDataById(roleId).GetPhantomOperationState(index, uniqueId);
	}

	// Token: 0x06012870 RID: 75888 RVA: 0x00490A4C File Offset: 0x0048EC4C
	public int GetPhantomMaxLevel(int uniqueId)
	{
		PhantomBattleData phantomBattleData = this.GetPhantomBattleData(uniqueId);
		return PhantomBattleConfig.Instance.GetPhantomQualityByItemQuality(phantomBattleData.GetQuality()).Value.LevelLimit;
	}

	// Token: 0x06012871 RID: 75889 RVA: 0x00490A84 File Offset: 0x0048EC84
	public FTransform GetMeshTransform(int itemId)
	{
		FRotator meshRotator = this.GetMeshRotator(itemId);
		FVector meshLocation = this.GetMeshLocation(itemId);
		FVector meshZoom = this.GetMeshZoom(itemId);
		return new FTransform(ref meshRotator, ref meshLocation, ref meshZoom);
	}

	// Token: 0x06012872 RID: 75890 RVA: 0x00490AB4 File Offset: 0x0048ECB4
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

	// Token: 0x06012873 RID: 75891 RVA: 0x00490AF4 File Offset: 0x0048ECF4
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

	// Token: 0x06012874 RID: 75892 RVA: 0x00490B34 File Offset: 0x0048ED34
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

	// Token: 0x06012875 RID: 75893 RVA: 0x00490B88 File Offset: 0x0048ED88
	public string GetStandAnim(int itemId)
	{
		return this.GetPhantomInstanceByItemId(itemId).GetStandAnim();
	}

	// Token: 0x06012876 RID: 75894 RVA: 0x00490B96 File Offset: 0x0048ED96
	public EVisionLevelUpMaterialPutInMode GetVisionLevelUpMaterialPutInMode()
	{
		return this.VisionLevelUpMaterialPutInMode;
	}

	// Token: 0x06012877 RID: 75895 RVA: 0x00490B9E File Offset: 0x0048ED9E
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

	// Token: 0x06012878 RID: 75896 RVA: 0x00490BCA File Offset: 0x0048EDCA
	public EVisionLevelUpMaterialUseType GetVisionLevelUpMaterialUseType()
	{
		return this.VisionLevelUpMaterialUseType;
	}

	// Token: 0x06012879 RID: 75897 RVA: 0x00490BD2 File Offset: 0x0048EDD2
	public void SetVisionLevelUpMaterialUseType(EVisionLevelUpMaterialUseType type)
	{
		if (this.VisionLevelUpMaterialUseType == type)
		{
			return;
		}
		this.VisionLevelUpMaterialUseType = type;
		LocalStorage.SetPlayer<EVisionLevelUpMaterialUseType>(ELocalStoragePlayerKey.VisionLevelUpMaterialUseType, type);
	}

	// Token: 0x0601287A RID: 75898 RVA: 0x00490BEE File Offset: 0x0048EDEE
	public EVisionLevelUpIdentify GetVisionLevelUpIdentify()
	{
		return this.VisionLevelUpIdentify;
	}

	// Token: 0x0601287B RID: 75899 RVA: 0x00490BF6 File Offset: 0x0048EDF6
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

	// Token: 0x0601287C RID: 75900 RVA: 0x00490C25 File Offset: 0x0048EE25
	public PhantomBattleData GetPhantomBattleDataByPhantomItem(Aki.Protocol.PhantomItem data)
	{
		PhantomBattleData phantomBattleData = new PhantomBattleData();
		phantomBattleData.SetData(data);
		return phantomBattleData;
	}

	// Token: 0x0601287D RID: 75901 RVA: 0x00490C33 File Offset: 0x0048EE33
	public void AddNeedCameraFocusMethodDisableViewCount()
	{
		this.NeedCameraFocusMethodDisableViewCount++;
		this.UpdateCameraFocusMethod();
	}

	// Token: 0x0601287E RID: 75902 RVA: 0x00490C49 File Offset: 0x0048EE49
	public void ReduceNeedCameraFocusMethodDisableViewCount()
	{
		this.NeedCameraFocusMethodDisableViewCount--;
		this.UpdateCameraFocusMethod();
	}

	// Token: 0x0601287F RID: 75903 RVA: 0x00490C60 File Offset: 0x0048EE60
	public void UpdateCameraFocusMethod()
	{
		ECameraFocusMethod cameraFocusMethod = (this.NeedCameraFocusMethodDisableViewCount > 0) ? ECameraFocusMethod.Disable : ECameraFocusMethod.Manual;
		UiCameraManager.Get().GetUiCameraComponent<UiCameraPostEffectComponent>().SetCameraFocusMethod(cameraFocusMethod);
	}

	// Token: 0x06012880 RID: 75904 RVA: 0x00490C8C File Offset: 0x0048EE8C
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

	// Token: 0x06012881 RID: 75905 RVA: 0x00490D08 File Offset: 0x0048EF08
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

	// Token: 0x06012882 RID: 75906 RVA: 0x00490DA0 File Offset: 0x0048EFA0
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

	// Token: 0x06012883 RID: 75907 RVA: 0x00490E4C File Offset: 0x0048F04C
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

	// Token: 0x06012884 RID: 75908 RVA: 0x00490F30 File Offset: 0x0048F130
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

	// Token: 0x06012885 RID: 75909 RVA: 0x00491048 File Offset: 0x0048F248
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

	// Token: 0x06012886 RID: 75910 RVA: 0x0049108C File Offset: 0x0048F28C
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

	// Token: 0x06012887 RID: 75911 RVA: 0x00491188 File Offset: 0x0048F388
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

	// Token: 0x06012888 RID: 75912 RVA: 0x004912F9 File Offset: 0x0048F4F9
	public List<int> GetTargetRoleFetterList(int roleId)
	{
		return RoleModel.Instance.GetRoleDataById(roleId, true).GetPhantomData().GetPhantomFettersList();
	}

	// Token: 0x06012889 RID: 75913 RVA: 0x00491314 File Offset: 0x0048F514
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

	// Token: 0x0601288A RID: 75914 RVA: 0x00491398 File Offset: 0x0048F598
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

	// Token: 0x0601288B RID: 75915 RVA: 0x004913E4 File Offset: 0x0048F5E4
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

	// Token: 0x0601288C RID: 75916 RVA: 0x004914A0 File Offset: 0x0048F6A0
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

	// Token: 0x0601288D RID: 75917 RVA: 0x00491504 File Offset: 0x0048F704
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

	// Token: 0x0601288E RID: 75918 RVA: 0x004915C0 File Offset: 0x0048F7C0
	public int GetLevelUpNeedCost(int exp)
	{
		return (int)Math.Floor((double)((float)exp * PhantomBattleConfig.Instance.GetPhantomLevelUpCostRatio()));
	}

	// Token: 0x0601288F RID: 75919 RVA: 0x004915D6 File Offset: 0x0048F7D6
	public void ResetLevelUpItemData()
	{
		this.LevelUpItemData.Clear();
	}

	// Token: 0x06012890 RID: 75920 RVA: 0x004915E4 File Offset: 0x0048F7E4
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

	// Token: 0x06012891 RID: 75921 RVA: 0x00491648 File Offset: 0x0048F848
	public int GetMonsterRarity(int monsterId)
	{
		return PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(monsterId)[0].Rarity;
	}

	// Token: 0x06012892 RID: 75922 RVA: 0x0049166E File Offset: 0x0048F86E
	public AttrListScrollData[] GetShowAttrList(int roleId)
	{
		List<AttrListScrollData> propShowAttributeList = this.GetBattleDataById(roleId).GetPropShowAttributeList();
		propShowAttributeList.Sort(new Comparison<AttrListScrollData>(this.SortAttrList));
		return propShowAttributeList.ToArray();
	}

	// Token: 0x06012893 RID: 75923 RVA: 0x00491693 File Offset: 0x0048F893
	public List<AttrListScrollData> GetExtraAttrList(int roleId)
	{
		List<AttrListScrollData> propDetailAttributeList = this.GetBattleDataById(roleId).GetPropDetailAttributeList();
		propDetailAttributeList.Sort(new Comparison<AttrListScrollData>(this.SortAttrList));
		return propDetailAttributeList;
	}

	// Token: 0x06012894 RID: 75924 RVA: 0x004916B4 File Offset: 0x0048F8B4
	public int[] GetFetterGroupMonsterIdArray(int fetterGroupId)
	{
		int[] result;
		if (this.GetFetterGroupMonsterMap().TryGetValue(fetterGroupId, out result))
		{
			return result;
		}
		return new int[0];
	}

	// Token: 0x06012895 RID: 75925 RVA: 0x004916DC File Offset: 0x0048F8DC
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

	// Token: 0x06012896 RID: 75926 RVA: 0x00491714 File Offset: 0x0048F914
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

	// Token: 0x06012897 RID: 75927 RVA: 0x00491798 File Offset: 0x0048F998
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

	// Token: 0x06012898 RID: 75928 RVA: 0x0049185C File Offset: 0x0048FA5C
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

	// Token: 0x06012899 RID: 75929 RVA: 0x00491938 File Offset: 0x0048FB38
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

	// Token: 0x0601289A RID: 75930 RVA: 0x00491B1C File Offset: 0x0048FD1C
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

	// Token: 0x0601289B RID: 75931 RVA: 0x00491BD0 File Offset: 0x0048FDD0
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

	// Token: 0x17001809 RID: 6153
	// (get) Token: 0x0601289C RID: 75932 RVA: 0x00491C1B File Offset: 0x0048FE1B
	// (set) Token: 0x0601289D RID: 75933 RVA: 0x00491C23 File Offset: 0x0048FE23
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

	// Token: 0x0601289E RID: 75934 RVA: 0x00491C2C File Offset: 0x0048FE2C
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

	// Token: 0x0601289F RID: 75935 RVA: 0x00491D5C File Offset: 0x0048FF5C
	[NullableContext(2)]
	public void SetPhantomRecommendData(PhantomRecommendResponse data)
	{
		this.RecommendData = new RecommendData();
		this.RecommendData.RoleId = data.RoleId;
		this.RecommendData.MonsterIdList = data.MonsterIdList.ToList<int>();
		this.RecommendData.MainPropId = data.MainPropId;
		this.RecommendData.FetterGroupId = data.FetterGroupId;
	}

	// Token: 0x1700180A RID: 6154
	// (get) Token: 0x060128A0 RID: 75936 RVA: 0x00491DBD File Offset: 0x0048FFBD
	[Nullable(2)]
	public RecommendData PhantomRecommendData
	{
		[NullableContext(2)]
		get
		{
			return this.RecommendData;
		}
	}

	// Token: 0x060128A1 RID: 75937 RVA: 0x00491DC8 File Offset: 0x0048FFC8
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

	// Token: 0x060128A2 RID: 75938 RVA: 0x00491E5C File Offset: 0x0049005C
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

	// Token: 0x060128A3 RID: 75939 RVA: 0x00491EC8 File Offset: 0x004900C8
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

	// Token: 0x060128A4 RID: 75940 RVA: 0x00491F54 File Offset: 0x00490154
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

	// Token: 0x060128A5 RID: 75941 RVA: 0x00491FC0 File Offset: 0x004901C0
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

	// Token: 0x060128A6 RID: 75942 RVA: 0x00492014 File Offset: 0x00490214
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

	// Token: 0x060128A7 RID: 75943 RVA: 0x004920AB File Offset: 0x004902AB
	public ItemDataBase[] GetSortedExpMaterialList(int uniqueId, int qualityId, bool withoutPhantom)
	{
		List<ItemDataBase> list = new List<ItemDataBase>(this.GetExpMaterialList(uniqueId, qualityId, true, withoutPhantom));
		list.Sort(new Comparison<ItemDataBase>(this.MaterialSort));
		return list.ToArray();
	}

	// Token: 0x060128A8 RID: 75944 RVA: 0x004920D4 File Offset: 0x004902D4
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

	// Token: 0x060128A9 RID: 75945 RVA: 0x00492198 File Offset: 0x00490398
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

	// Token: 0x060128AA RID: 75946 RVA: 0x00492324 File Offset: 0x00490524
	public bool GetIfSimpleState(int key)
	{
		Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.IsSimpleDetail, null);
		bool flag;
		return player != null && player.TryGetValue(key, out flag) && flag;
	}

	// Token: 0x060128AB RID: 75947 RVA: 0x00492350 File Offset: 0x00490550
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

	// Token: 0x060128AC RID: 75948 RVA: 0x00492390 File Offset: 0x00490590
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

	// Token: 0x060128AD RID: 75949 RVA: 0x004923C0 File Offset: 0x004905C0
	public bool GetIfVisionSkillState(int key)
	{
		Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.VisionSpecialSkillShowMap, null);
		bool flag;
		return player != null && player.TryGetValue(key, out flag) && flag;
	}

	// Token: 0x060128AE RID: 75950 RVA: 0x004923EC File Offset: 0x004905EC
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

	// Token: 0x060128AF RID: 75951 RVA: 0x00492470 File Offset: 0x00490670
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

	// Token: 0x060128B0 RID: 75952 RVA: 0x0049249C File Offset: 0x0049069C
	public bool CheckVisionLevelUpSettingRedDot()
	{
		return !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.VisionLevelUpSettingRedDot, false) || !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.VisionLevelUpIdentifyRedDot, false);
	}

	// Token: 0x060128B1 RID: 75953 RVA: 0x004924B8 File Offset: 0x004906B8
	public bool IsVisionHighQuality(PhantomBattleData data)
	{
		int visionLevelUpQualityLimit = PhantomBattleConfig.Instance.GetVisionLevelUpQualityLimit();
		return data.GetConfig().QualityId > visionLevelUpQualityLimit;
	}

	// Token: 0x060128B2 RID: 75954 RVA: 0x004924E4 File Offset: 0x004906E4
	public bool IsVisionHighLevel(PhantomBattleData data)
	{
		int visionLevelUpLevelLimit = PhantomBattleConfig.Instance.GetVisionLevelUpLevelLimit();
		return data.GetPhantomLevel() > visionLevelUpLevelLimit;
	}

	// Token: 0x060128B3 RID: 75955 RVA: 0x00492508 File Offset: 0x00490708
	public bool IsVisionHighRare(PhantomBattleData data)
	{
		int visionLevelUpRareLimit = PhantomBattleConfig.Instance.GetVisionLevelUpRareLimit();
		return data.GetRareConfig().Value.Rare > visionLevelUpRareLimit;
	}

	// Token: 0x1700180B RID: 6155
	// (get) Token: 0x060128B4 RID: 75956 RVA: 0x00492539 File Offset: 0x00490739
	public List<VisionUnlockQualityData> QualityUnlockTipsList
	{
		get
		{
			return this.QualityUnlockTips;
		}
	}

	// Token: 0x060128B5 RID: 75957 RVA: 0x00492544 File Offset: 0x00490744
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

	// Token: 0x060128B6 RID: 75958 RVA: 0x004925A0 File Offset: 0x004907A0
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

	// Token: 0x060128B7 RID: 75959 RVA: 0x00492630 File Offset: 0x00490830
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

	// Token: 0x060128B8 RID: 75960 RVA: 0x00492664 File Offset: 0x00490864
	public int GetMainAttributeCost(int key)
	{
		int result;
		if (!this.GetSortMainAttributeCostMap().TryGetValue(key, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x060128B9 RID: 75961 RVA: 0x00492684 File Offset: 0x00490884
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

	// Token: 0x060128BA RID: 75962 RVA: 0x00492748 File Offset: 0x00490948
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

	// Token: 0x060128BB RID: 75963 RVA: 0x004927B8 File Offset: 0x004909B8
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

	// Token: 0x060128BC RID: 75964 RVA: 0x004928BC File Offset: 0x00490ABC
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

	// Token: 0x060128BD RID: 75965 RVA: 0x004929D8 File Offset: 0x00490BD8
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

	// Token: 0x060128BE RID: 75966 RVA: 0x00492A0C File Offset: 0x00490C0C
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

	// Token: 0x060128BF RID: 75967 RVA: 0x00492AF4 File Offset: 0x00490CF4
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

	// Token: 0x060128C0 RID: 75968 RVA: 0x00492B44 File Offset: 0x00490D44
	public void GmClearData()
	{
		this.QualityUnlockTips.Clear();
	}

	// Token: 0x060128C1 RID: 75969 RVA: 0x00492B51 File Offset: 0x00490D51
	public void RecordVisionRecoveryRedDot(bool value)
	{
		ServerStorageBoolean serverStorageBoolean = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.VisionRecoveryBatchTip) as ServerStorageBoolean;
		if (serverStorageBoolean != null)
		{
			serverStorageBoolean.Set(new bool?(value));
		}
		EventSystem.Instance.Emit(EEventName.OnVisionRecoveryStorage);
	}

	// Token: 0x060128C2 RID: 75970 RVA: 0x00492B88 File Offset: 0x00490D88
	public bool GetVisionRecoveryBatchRedDot()
	{
		ServerStorageBoolean serverStorageBoolean = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.VisionRecoveryBatchTip) as ServerStorageBoolean;
		bool valueOrDefault = ((serverStorageBoolean != null) ? serverStorageBoolean.Get() : null).GetValueOrDefault(true);
		return FunctionModel.Instance.IsOpen(10024001) && valueOrDefault;
	}

	// Token: 0x060128C3 RID: 75971 RVA: 0x00492BD5 File Offset: 0x00490DD5
	public void RecordVisionRecoveryAimRedDot(bool value)
	{
		if (!FunctionModel.Instance.IsOpen(EFunctionType.VisionAim))
		{
			return;
		}
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.VisionRecoveryBatchAimTip) as ServerStorageBoolean).Set(new bool?(value));
		EventSystem.Instance.Emit(EEventName.OnVisionRecoveryStorage);
	}

	// Token: 0x060128C4 RID: 75972 RVA: 0x00492C18 File Offset: 0x00490E18
	public bool GetVisionRecoveryBatchAimRedDot()
	{
		bool valueOrDefault = (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.VisionRecoveryBatchAimTip) as ServerStorageBoolean).Get().GetValueOrDefault(true);
		return FunctionModel.Instance.IsOpen(EFunctionType.VisionAim) && valueOrDefault;
	}

	// Token: 0x060128C5 RID: 75973 RVA: 0x00492C58 File Offset: 0x00490E58
	public List<global::PhantomItemData> GetVisionRecoverySortPhantomItemList(List<AddCountItemInfo> itemInfos)
	{
		List<global::PhantomItemData> phantomItemDataListByAddCountItemInfo = InventoryModel.Instance.GetPhantomItemDataListByAddCountItemInfo(itemInfos);
		HashSet<int> hashSet = new HashSet<int>();
		hashSet.Add(3);
		hashSet.Add(4);
		SortModel.Instance.SortDataByData<global::PhantomItemData>(phantomItemDataListByAddCountItemInfo, ESortDataType.Phantom, hashSet, false);
		return phantomItemDataListByAddCountItemInfo;
	}

	// Token: 0x060128C6 RID: 75974 RVA: 0x00492C96 File Offset: 0x00490E96
	public void RecordVisionRefineRedDot(bool value)
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.VisionRefineTip) as ServerStorageBoolean).Set(new bool?(value));
		EventSystem.Instance.Emit(EEventName.OnVisionRefineStorage);
	}

	// Token: 0x060128C7 RID: 75975 RVA: 0x00492CC4 File Offset: 0x00490EC4
	public bool GetVisionRefineRedDot()
	{
		bool valueOrDefault = (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.VisionRefineTip) as ServerStorageBoolean).Get().GetValueOrDefault(true);
		return FunctionModel.Instance.IsOpen(10083) && valueOrDefault;
	}

	// Token: 0x060128C8 RID: 75976 RVA: 0x00492D04 File Offset: 0x00490F04
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

	// Token: 0x060128C9 RID: 75977 RVA: 0x00492D38 File Offset: 0x00490F38
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

	// Token: 0x060128CA RID: 75978 RVA: 0x00492E14 File Offset: 0x00491014
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

	// Token: 0x060128CB RID: 75979 RVA: 0x00492E48 File Offset: 0x00491048
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

	// Token: 0x060128CC RID: 75980 RVA: 0x00492E7C File Offset: 0x0049107C
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

	// Token: 0x060128CD RID: 75981 RVA: 0x00492F10 File Offset: 0x00491110
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

	// Token: 0x060128CE RID: 75982 RVA: 0x00492F8C File Offset: 0x0049118C
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

	// Token: 0x060128CF RID: 75983 RVA: 0x004930C0 File Offset: 0x004912C0
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

	// Token: 0x060128D0 RID: 75984 RVA: 0x00493138 File Offset: 0x00491338
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

	// Token: 0x060128D1 RID: 75985 RVA: 0x004931A8 File Offset: 0x004913A8
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

	// Token: 0x060128D2 RID: 75986 RVA: 0x00493260 File Offset: 0x00491460
	public void SetSelfPhantomConfigCode(string value)
	{
		this.PhantomConfigData.SelfPhantomConfigCode = value;
	}

	// Token: 0x060128D3 RID: 75987 RVA: 0x0049326E File Offset: 0x0049146E
	public PhantomManagerConfigData GetPhantomConfigData()
	{
		return this.PhantomConfigData;
	}

	// Token: 0x060128D4 RID: 75988 RVA: 0x00493276 File Offset: 0x00491476
	public string GetSelfPhantomConfigCode()
	{
		return this.PhantomConfigData.SelfPhantomConfigCode;
	}

	// Token: 0x060128D5 RID: 75989 RVA: 0x00493283 File Offset: 0x00491483
	public void UpdatePhantomConfigData(PhBaOneAllSuitPlan allPlan)
	{
		this.PhantomConfigData.UpdateFetterMap(allPlan.SuitPlanList.ToList<PhBaOneSuitPlan>());
	}

	// Token: 0x060128D6 RID: 75990 RVA: 0x0049329B File Offset: 0x0049149B
	public void CacheShareConfigData(PhBaOneAllSuitPlan allPlan)
	{
		this.PhantomConfigData.CacheShareFetterMap(allPlan.SuitPlanList.ToList<PhBaOneSuitPlan>());
	}

	// Token: 0x1700180C RID: 6156
	// (get) Token: 0x060128D7 RID: 75991 RVA: 0x004932B3 File Offset: 0x004914B3
	public static PhantomBattleModel Instance
	{
		get
		{
			return PhantomBattleModel._Instance;
		}
	}

	// Token: 0x060128D8 RID: 75992 RVA: 0x004932BA File Offset: 0x004914BA
	public static PhantomBattleModel GetOrCreateInstance()
	{
		if (PhantomBattleModel._Instance == null)
		{
			PhantomBattleModel.CreateInstance();
		}
		return PhantomBattleModel._Instance;
	}

	// Token: 0x060128D9 RID: 75993 RVA: 0x004932CE File Offset: 0x004914CE
	public static bool CreateInstance()
	{
		if (PhantomBattleModel._Instance != null)
		{
			return true;
		}
		PhantomBattleModel._Instance = new PhantomBattleModel();
		return true;
	}

	// Token: 0x060128DA RID: 75994 RVA: 0x004932E4 File Offset: 0x004914E4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060128DB RID: 75995 RVA: 0x004932E6 File Offset: 0x004914E6
	public static void ResetStaticDefaultValue()
	{
		PhantomBattleModel._Instance = null;
	}

	// Token: 0x060128DC RID: 75996 RVA: 0x004932EE File Offset: 0x004914EE
	static PhantomBattleModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomBattleModel.CreateStaticDefaultValue), new Action(PhantomBattleModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008BB5 RID: 35765
	private readonly Dictionary<int, PhantomBattleData> RobotDataMap;

	// Token: 0x04008BB6 RID: 35766
	private readonly Dictionary<int, PhantomRoleEquipmentData> BattleDataMap;

	// Token: 0x04008BB7 RID: 35767
	private readonly Dictionary<int, int> PhantomEquipmentRoleMap;

	// Token: 0x04008BB8 RID: 35768
	private readonly Dictionary<int, PhantomBattleInstance> PhantomInstanceMap;

	// Token: 0x04008BB9 RID: 35769
	private readonly Dictionary<int, PhantomBattleData> PhantomBattleDataMap;

	// Token: 0x04008BBA RID: 35770
	private List<PhantomBattleData> UnEquipVisionArray;

	// Token: 0x04008BBB RID: 35771
	private bool UnEquipVisionArrayRefreshTag;

	// Token: 0x04008BBC RID: 35772
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, int[]> FetterGroupMonsterMap;

	// Token: 0x04008BBD RID: 35773
	[Nullable(2)]
	public PhantomBattleData CurrentSelectData;

	// Token: 0x04008BBE RID: 35774
	public int CurrentEquipmentSelectIndex;

	// Token: 0x04008BBF RID: 35775
	public int CurrentSelectUniqueId;

	// Token: 0x04008BC0 RID: 35776
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CustomPromise<UCurveFloat> LoadingCurvePromise;

	// Token: 0x04008BC1 RID: 35777
	public bool LevelUpConfirmTipsNotShow;

	// Token: 0x04008BC2 RID: 35778
	private FVector PhantomMeshZoom;

	// Token: 0x04008BC3 RID: 35779
	private FVector PhantomMeshLocation;

	// Token: 0x04008BC4 RID: 35780
	private FRotator PhantomMeshRotator;

	// Token: 0x04008BC5 RID: 35781
	private readonly Dictionary<int, int> LevelUpItemData;

	// Token: 0x04008BC6 RID: 35782
	private TItem[] TempSaveItemList;

	// Token: 0x04008BC7 RID: 35783
	[Nullable(2)]
	private LevelUpPastVisionData PastVisionLevelUpData;

	// Token: 0x04008BC8 RID: 35784
	private bool VisionLevelUpTag;

	// Token: 0x04008BC9 RID: 35785
	private int CurrentDraggingIndex;

	// Token: 0x04008BCA RID: 35786
	private int CurrentMaxCost;

	// Token: 0x04008BCB RID: 35787
	[Nullable(2)]
	private int[] UnlockSkin;

	// Token: 0x04008BCC RID: 35788
	private readonly Dictionary<int, int[]> MonsterSkinMap;

	// Token: 0x04008BCD RID: 35789
	private readonly Dictionary<int, int> MonsterSkinMonsterIdMap;

	// Token: 0x04008BCE RID: 35790
	[Nullable(2)]
	private Dictionary<int, int> MainAttributeMap;

	// Token: 0x04008BCF RID: 35791
	[Nullable(2)]
	private Dictionary<int, int> MainPercentageAttributeMap;

	// Token: 0x04008BD0 RID: 35792
	[Nullable(2)]
	private Dictionary<int, int> SubAttributeMap;

	// Token: 0x04008BD1 RID: 35793
	[Nullable(2)]
	private Dictionary<int, int> SubPercentageAttributeMap;

	// Token: 0x04008BD2 RID: 35794
	[Nullable(2)]
	private Dictionary<int, int> MainAttributeCostMap;

	// Token: 0x04008BD3 RID: 35795
	private EVisionLevelUpMaterialPutInMode VisionLevelUpMaterialPutInMode;

	// Token: 0x04008BD4 RID: 35796
	private EVisionLevelUpMaterialUseType VisionLevelUpMaterialUseType;

	// Token: 0x04008BD5 RID: 35797
	private EVisionLevelUpIdentify VisionLevelUpIdentify;

	// Token: 0x04008BD6 RID: 35798
	public bool PhantomRefineAcceptIgnore;

	// Token: 0x04008BD7 RID: 35799
	public bool PhantomRefineRejectIgnore;

	// Token: 0x04008BD8 RID: 35800
	private int NeedCameraFocusMethodDisableViewCount;

	// Token: 0x04008BD9 RID: 35801
	private PhantomFetter? Fetter;

	// Token: 0x04008BDA RID: 35802
	public int CurrentSelectFetterGroupId;

	// Token: 0x04008BDB RID: 35803
	[Nullable(2)]
	private RecommendData RecommendData;

	// Token: 0x04008BDC RID: 35804
	private readonly List<VisionUnlockQualityData> QualityUnlockTips;

	// Token: 0x04008BDD RID: 35805
	protected PhantomManagerConfigData PhantomConfigData = new PhantomManagerConfigData();

	// Token: 0x04008BDE RID: 35806
	[Nullable(2)]
	private static PhantomBattleModel _Instance;
}

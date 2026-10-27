using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.TowerDefence;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02002BBF RID: 11199
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class TowerDefenseController : ActivityControllerBase
{
	// Token: 0x0601736D RID: 95085 RVA: 0x005E2DD6 File Offset: 0x005E0FD6
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return TowerDefenseModel.Instance.GetOrCreateParsedTowerDefenseMsg();
	}

	// Token: 0x0601736E RID: 95086 RVA: 0x005E2DE2 File Offset: 0x005E0FE2
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new TowerDefenseSubView();
	}

	// Token: 0x0601736F RID: 95087 RVA: 0x005E2DE9 File Offset: 0x005E0FE9
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_LordGymMainA";
	}

	// Token: 0x06017370 RID: 95088 RVA: 0x005E2DF0 File Offset: 0x005E0FF0
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return UiManager.Instance.IsViewOpen(EUiViewName.TowerDefenseLevelView);
	}

	// Token: 0x06017371 RID: 95089 RVA: 0x005E2E04 File Offset: 0x005E1004
	protected override void OnOpenView(ActivityBaseData data)
	{
		if (!data.GetPreGuideQuestFinishState())
		{
			int unFinishPreGuideQuestId = data.GetUnFinishPreGuideQuestId();
			UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
			return;
		}
		TowerDefenseConfig? towerDefenseConfigByActivityId = InstanceDungeonConfig.Instance.GetTowerDefenseConfigByActivityId(data.Id);
		if (towerDefenseConfigByActivityId.Value.EntranceId != 0)
		{
			InstanceDungeonEntranceController.Instance.EnterEntrance(towerDefenseConfigByActivityId.Value.EntranceId, 0, null);
			return;
		}
		WorldMapViewOpenParams data2 = new WorldMapViewOpenParams
		{
			MarkId = new int?(TowerDefenseController.Instance.GetMarkIdByActivityId(data.Id)),
			MarkType = EMarkType.None,
			OpenFogId = new int?(0)
		};
		WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data2, null);
	}

	// Token: 0x06017372 RID: 95090 RVA: 0x005E2EB8 File Offset: 0x005E10B8
	[NullableContext(0)]
	protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
	{
		TowerDefenseController.<OnOpenSubView>d__5 <OnOpenSubView>d__;
		<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OnOpenSubView>d__.viewName = viewName;
		<OnOpenSubView>d__.<>1__state = -1;
		<OnOpenSubView>d__.<>t__builder.Start<TowerDefenseController.<OnOpenSubView>d__5>(ref <OnOpenSubView>d__);
		return <OnOpenSubView>d__.<>t__builder.Task;
	}

	// Token: 0x06017373 RID: 95091 RVA: 0x005E2EFC File Offset: 0x005E10FC
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshBattleRoleSlot, new Action<ERefreshRoleSlotReason>(this.HandleOnRefreshEditBattleRoleSlotData));
		EventSystem.Instance.Add(EEventName.TowerDefenseBeforeConfirmQuickRoleSelect, new Action(this.HandleBeforeConfirmQuickRoleSelect));
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.HandleOnChangeRole));
		EventSystem.Instance.Add(EEventName.EnterInstanceDungeon, new Action(this.HandleEnterInstanceDungeon));
		EventSystem.Instance.Add(EEventName.LeaveInstanceDungeon, new Action(this.HandleLeaveInstanceDungeon));
		EventSystem.Instance.Add(EEventName.LeaveInstanceExternalConfirm, new Action(this.HandleLeaveInstanceExternalConfirm));
		EventSystem.Instance.Add<int, int>(EEventName.BattleScoreChanged, new Action<int, int>(this.HandleBattleScoreChanged));
		EventSystem.Instance.Add(EEventName.OnBeforeDestroyInstanceDungeonEntranceView, new Action(this.HandleOnBeforeDestroyInstanceDungeonEntranceView));
		EventSystem.Instance.Add(EEventName.TowerDefenseSelfPhantomConfirm, new Action<int>(this.HandleTowerDefenseSelfPhantomConfirm));
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.HandleWorldDoneAndCloseLoading));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.HandleCloseView));
		EventSystem.Instance.Add(EEventName.OnSelectInstanceIdChallenge, new Action<int>(this.OnSelectInstanceIdChallenge));
	}

	// Token: 0x06017374 RID: 95092 RVA: 0x005E3058 File Offset: 0x005E1258
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshBattleRoleSlot, new Action<ERefreshRoleSlotReason>(this.HandleOnRefreshEditBattleRoleSlotData));
		EventSystem.Instance.Remove(EEventName.TowerDefenseBeforeConfirmQuickRoleSelect, new Action(this.HandleBeforeConfirmQuickRoleSelect));
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.HandleOnChangeRole));
		EventSystem.Instance.Remove(EEventName.EnterInstanceDungeon, new Action(this.HandleEnterInstanceDungeon));
		EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeon, new Action(this.HandleLeaveInstanceDungeon));
		EventSystem.Instance.Remove(EEventName.LeaveInstanceExternalConfirm, new Action(this.HandleLeaveInstanceExternalConfirm));
		EventSystem.Instance.Remove(EEventName.BattleScoreChanged, new Action<int, int>(this.HandleBattleScoreChanged));
		EventSystem.Instance.Remove(EEventName.OnBeforeDestroyInstanceDungeonEntranceView, new Action(this.HandleOnBeforeDestroyInstanceDungeonEntranceView));
		EventSystem.Instance.Remove(EEventName.TowerDefenseSelfPhantomConfirm, new Action<int>(this.HandleTowerDefenseSelfPhantomConfirm));
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.HandleWorldDoneAndCloseLoading));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.HandleCloseView));
		EventSystem.Instance.Remove(EEventName.OnSelectInstanceIdChallenge, new Action<int>(this.OnSelectInstanceIdChallenge));
	}

	// Token: 0x06017375 RID: 95093 RVA: 0x005E31B4 File Offset: 0x005E13B4
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.TowerDefenceInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnActivityInfoUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.TowerDefenceInstanceInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnInstanceInfoUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.TowerDefencePhantomInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhantomInfoUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.TowerDefenceEndNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTowerDefenseBattleEndNotify));
		Net.Instance.Register(ENotifyMessageId.TowerDefenceEnterInstNotify, new Action<IMessage, Net.CallbackStatus>(this.OnEnterInstNotify));
		Net.Instance.Register(ENotifyMessageId.TowerDefenceRoleReviveNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleReviveNotify));
		Net.Instance.Register(ENotifyMessageId.TowerDefencePlayerReviveNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPlayerReviveNotify));
	}

	// Token: 0x06017376 RID: 95094 RVA: 0x005E3288 File Offset: 0x005E1488
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.TowerDefenceInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TowerDefenceInstanceInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TowerDefencePhantomInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TowerDefenceEndNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TowerDefenceEnterInstNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TowerDefenceRoleReviveNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TowerDefencePlayerReviveNotify);
	}

	// Token: 0x06017377 RID: 95095 RVA: 0x005E3305 File Offset: 0x005E1505
	public override bool GetActivityLevelUnlockState(int levelId)
	{
		return this.CheckIsInstanceUnlock(levelId);
	}

	// Token: 0x06017378 RID: 95096 RVA: 0x005E330E File Offset: 0x005E150E
	public TowerDefencePhantomIconItem BuildPhantomIconItem()
	{
		return new TowerDefencePhantomIconItem();
	}

	// Token: 0x06017379 RID: 95097 RVA: 0x005E3315 File Offset: 0x005E1515
	public TowerDefensePhantomSkillItem BuildPhantomSkillItem()
	{
		return new TowerDefensePhantomSkillItem();
	}

	// Token: 0x0601737A RID: 95098 RVA: 0x005E331C File Offset: 0x005E151C
	public TowerDefenseInBattleInfoItem BuildPhantomSkillInBattleItem()
	{
		return new TowerDefenseInBattleInfoItem();
	}

	// Token: 0x0601737B RID: 95099 RVA: 0x005E3324 File Offset: 0x005E1524
	public List<PhantomSmallItemGrid> BuildPhantomIconScrollData()
	{
		List<PhantomSmallItemGrid> list = new List<PhantomSmallItemGrid>();
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		List<ITowerDefensePhantomConfig> sortedPhantomConfigCache = instance.SortedPhantomConfigCache;
		InstanceDungeonEntranceModel instance2 = InstanceDungeonEntranceModel.Instance;
		Dictionary<long, EMultiPlayerSlot> dictionary = null;
		if (this.CheckIsInMatch())
		{
			dictionary = new Dictionary<long, EMultiPlayerSlot>();
			foreach (PrewarFormationData prewarFormationData in InstanceDungeonModel.Instance.GetPrewarFormationDataList())
			{
				dictionary[(long)prewarFormationData.GetPlayerId()] = (EMultiPlayerSlot)prewarFormationData.GetOnlineNumber();
			}
		}
		foreach (ITowerDefensePhantomConfig towerDefensePhantomConfig in sortedPhantomConfigCache)
		{
			if (instance.CheckPhantomAvailableInActivityByActivityId(towerDefensePhantomConfig.ActivityId))
			{
				Aki.Config.PhantomItem? config = ConfigPhantomItemByItemId.GetConfig(towerDefensePhantomConfig.PhantomItemId, true);
				int num = this.CheckIsInMatch() ? instance2.GetMatchingId() : instance2.SelectInstanceId;
				TowerDefenceInstance? config2 = ConfigTowerDefenceInstanceByInstanceId.GetConfig(num, true);
				if (config2 == null)
				{
					Log instance3 = Log.Instance;
					ELogModule module = ELogModule.Activity;
					ELogAuthor author = ELogAuthor.WZ;
					string message = "副本ID配置错误，无法在塔防副本配置中找到，请检查联机塔防表和副本表";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("选中的副本ID", num);
					instance3.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				bool flag = config2 == null || !config2.Value.OptionalBuff().Contains(towerDefensePhantomConfig.Id);
				TowerDefensePhantomIconItemData towerDefensePhantomIconItemData = new TowerDefensePhantomIconItemData();
				towerDefensePhantomIconItemData.ConfigId = towerDefensePhantomConfig.Id;
				UiResourceConfig instance4 = UiResourceConfig.Instance;
				towerDefensePhantomIconItemData.HexColorPath = (((instance4 != null) ? instance4.GetResourcePath(towerDefensePhantomConfig.MarkResourceId) : null) ?? "");
				towerDefensePhantomIconItemData.IsLocked = flag;
				towerDefensePhantomIconItemData.IsChosen = false;
				towerDefensePhantomIconItemData.IsOccupied = instance.CheckPhantomIsOccupied(towerDefensePhantomConfig.Id);
				TowerDefensePhantomIconItemData data = towerDefensePhantomIconItemData;
				SmallItemMultiPlayer multiPlayer = null;
				if (dictionary != null)
				{
					Dictionary<EMultiPlayerSlot, bool> dictionary2 = new Dictionary<EMultiPlayerSlot, bool>();
					foreach (ITowerDefensePhantomDataOwner towerDefensePhantomDataOwner in instance.PhantomOwnerDataList)
					{
						EMultiPlayerSlot key;
						if (towerDefensePhantomDataOwner.PhantomId != 0 && towerDefensePhantomDataOwner.PhantomId == towerDefensePhantomConfig.Id && dictionary.TryGetValue(towerDefensePhantomDataOwner.PlayerId, out key))
						{
							bool flag2;
							dictionary2[key] = (towerDefensePhantomDataOwner.IsSelf || (dictionary2.TryGetValue(key, out flag2) && flag2));
						}
					}
					if (dictionary2.Count > 0)
					{
						List<SmallItemMultiPlayerSlot> list2 = new List<SmallItemMultiPlayerSlot>();
						foreach (KeyValuePair<EMultiPlayerSlot, bool> keyValuePair in dictionary2)
						{
							list2.Add(new SmallItemMultiPlayerSlot
							{
								Seat = keyValuePair.Key,
								IsSelf = keyValuePair.Value
							});
						}
						list2.Sort((SmallItemMultiPlayerSlot a, SmallItemMultiPlayerSlot b) => a.Seat - b.Seat);
						multiPlayer = new SmallItemMultiPlayer
						{
							Players = list2
						};
					}
				}
				PhantomSmallItemGrid item = new PhantomSmallItemGrid
				{
					Data = data,
					PhantomId = new int?(towerDefensePhantomConfig.PhantomItemId),
					QualityId = new int?(config.Value.QualityId),
					IsLockVisibleBlack = new bool?(flag || !instance.IsPhantomViewOpened),
					MultiPlayer = multiPlayer
				};
				list.Add(item);
			}
		}
		list.Sort(new Comparison<PhantomSmallItemGrid>(this.PhantomIconSorter));
		return list;
	}

	// Token: 0x0601737C RID: 95100 RVA: 0x005E36E8 File Offset: 0x005E18E8
	public void MarkPhantomIconScrollDataChosen(List<PhantomSmallItemGrid> data, bool isFirstTime, int roleCfgId)
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		int value = PlayerInfoModel.Instance.GetId().Value;
		ITowerDefensePhantomDataOwner ownerData = instance.GetOwnerData(value, roleCfgId);
		if (isFirstTime)
		{
			if (ownerData == null || ownerData.PhantomId == 0)
			{
				using (List<PhantomSmallItemGrid>.Enumerator enumerator = data.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						PhantomSmallItemGrid phantomSmallItemGrid = enumerator.Current;
						ITowerDefensePhantomIconItemData towerDefensePhantomIconItemData = phantomSmallItemGrid.Data as ITowerDefensePhantomIconItemData;
						if (!towerDefensePhantomIconItemData.IsOccupied && !towerDefensePhantomIconItemData.IsLocked)
						{
							instance.CurrentSelfPhantomIdInUiTemp = towerDefensePhantomIconItemData.ConfigId;
							break;
						}
					}
					goto IL_93;
				}
			}
			instance.CurrentSelfPhantomIdInUiTemp = ownerData.PhantomId;
		}
		IL_93:
		foreach (PhantomSmallItemGrid phantomSmallItemGrid2 in data)
		{
			ITowerDefensePhantomIconItemData towerDefensePhantomIconItemData2 = phantomSmallItemGrid2.Data as ITowerDefensePhantomIconItemData;
			towerDefensePhantomIconItemData2.IsChosen = (instance.CurrentSelfPhantomIdInUiTemp == towerDefensePhantomIconItemData2.ConfigId);
		}
	}

	// Token: 0x0601737D RID: 95101 RVA: 0x005E37F0 File Offset: 0x005E19F0
	public bool CheckSelfPhantomCancelAble(int roleCfgId)
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		int value = PlayerInfoModel.Instance.GetId().Value;
		ITowerDefensePhantomDataOwner ownerData = instance.GetOwnerData(value, roleCfgId);
		return ownerData != null && ownerData.PhantomId != 0 && instance.CurrentSelfPhantomIdInUiTemp == ownerData.PhantomId;
	}

	// Token: 0x0601737E RID: 95102 RVA: 0x005E383C File Offset: 0x005E1A3C
	public List<ITowerDefensePhantomSkillItemData> BuildPhantomSkillLayoutData()
	{
		List<ITowerDefensePhantomSkillItemData> list = new List<ITowerDefensePhantomSkillItemData>();
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		ITowerDefensePhantomConfig towerDefensePhantomConfig = instance.PhantomConfigCache[instance.CurrentSelfPhantomIdInUiTemp];
		for (int i = 0; i < towerDefensePhantomConfig.SkillDataList.Count; i++)
		{
			ITowerDefensePhantomConfigSkillData towerDefensePhantomConfigSkillData = towerDefensePhantomConfig.SkillDataList[i];
			list.Add(new TowerDefensePhantomSkillItemData
			{
				SkillTextId = towerDefensePhantomConfigSkillData.Name,
				DescriptionTextId = towerDefensePhantomConfigSkillData.Description,
				DescriptionArgs = PhantomBattleConfig.Instance.GetPhantomSkillDescExByPhantomSkillIdAndQuality(towerDefensePhantomConfigSkillData.PhantomSkill, 5).ToList<string>(),
				Level = (i + 1).ToString()
			});
		}
		return list;
	}

	// Token: 0x0601737F RID: 95103 RVA: 0x005E38E0 File Offset: 0x005E1AE0
	public ITowerDefensePhantomOtherData BuildPhantomOtherData()
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		InstanceDungeonEntranceModel instance2 = InstanceDungeonEntranceModel.Instance;
		ITowerDefensePhantomConfig towerDefensePhantomConfig = instance.PhantomConfigCache[instance.CurrentSelfPhantomIdInUiTemp];
		if (towerDefensePhantomConfig == null)
		{
			return null;
		}
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceByInstanceId.GetConfig(this.CheckIsInMatch() ? instance2.GetMatchingId() : instance2.SelectInstanceId, true);
		return new TowerDefensePhantomOtherData
		{
			NameTextId = towerDefensePhantomConfig.PhantomNameTextId,
			TypeIconPath = towerDefensePhantomConfig.TypeIconPath,
			TypeTextId = towerDefensePhantomConfig.PhantomTypeTextId,
			IsLocked = (config == null || !config.Value.OptionalBuff().Contains(instance.CurrentSelfPhantomIdInUiTemp))
		};
	}

	// Token: 0x06017380 RID: 95104 RVA: 0x005E3988 File Offset: 0x005E1B88
	public PhantomSmallItemGrid BuildPhantomIconInBattleData()
	{
		TowerDefencePhantom? config = ConfigTowerDefencePhantomById.GetConfig(TowerDefenseModel.Instance.GetCurrentPhantomIdInBattle(), true);
		int? num = (config != null) ? new int?(config.GetValueOrDefault().PhantomItemId) : null;
		return new PhantomSmallItemGrid
		{
			Data = num,
			PhantomId = num
		};
	}

	// Token: 0x06017381 RID: 95105 RVA: 0x005E39E8 File Offset: 0x005E1BE8
	public List<ITowerDefensePhantomSkillItemInBattleData> BuildPhantomSkillInBattleLayoutData()
	{
		List<ITowerDefensePhantomSkillItemInBattleData> list = new List<ITowerDefensePhantomSkillItemInBattleData>();
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		List<ITowerDefensePhantomConfigSkillData> currentPhantomSkillCfgListInBattle = instance.GetCurrentPhantomSkillCfgListInBattle();
		int currentPhantomLevelInBattle = instance.GetCurrentPhantomLevelInBattle();
		int num = currentPhantomLevelInBattle - 1;
		bool flag = this.CheckInBossRushInstance();
		bool flag2 = currentPhantomLevelInBattle >= currentPhantomSkillCfgListInBattle.Count;
		for (int i = 0; i < currentPhantomSkillCfgListInBattle.Count; i++)
		{
			if ((flag && !flag2) || i == num)
			{
				ITowerDefensePhantomConfigSkillData towerDefensePhantomConfigSkillData = currentPhantomSkillCfgListInBattle[i];
				list.Add(new TowerDefensePhantomSkillItemInBattleData
				{
					Skill = towerDefensePhantomConfigSkillData.Name,
					Description = towerDefensePhantomConfigSkillData.Description,
					DescriptionArgs = PhantomBattleConfig.Instance.GetPhantomSkillDescExByPhantomSkillIdAndQuality(towerDefensePhantomConfigSkillData.PhantomSkill, 5).ToList<string>(),
					IsUnlock = (currentPhantomLevelInBattle > i),
					IsCurrent = (i == num)
				});
			}
		}
		return list;
	}

	// Token: 0x06017382 RID: 95106 RVA: 0x005E3AB4 File Offset: 0x005E1CB4
	public int GetCurrentPhantomItemIdInBattle()
	{
		TowerDefencePhantom? config = ConfigTowerDefencePhantomById.GetConfig(TowerDefenseModel.Instance.GetCurrentPhantomIdInBattle(), true);
		if (config == null)
		{
			return 0;
		}
		return config.GetValueOrDefault().PhantomItemId;
	}

	// Token: 0x06017383 RID: 95107 RVA: 0x005E3AEC File Offset: 0x005E1CEC
	public string GetCurrentPhantomQualitySpritePathInBattle()
	{
		Aki.Config.PhantomItem? config = ConfigPhantomItemByItemId.GetConfig(this.GetCurrentPhantomItemIdInBattle(), true);
		InventoryDefine.EQuality key = (InventoryDefine.EQuality)((config != null) ? config.GetValueOrDefault().QualityId : 0);
		string resourceId;
		if (!TowerDefenceDefine.inBattleQualitySpriteKey.TryGetValue(key, out resourceId))
		{
			return "";
		}
		UiResourceConfig instance = UiResourceConfig.Instance;
		return ((instance != null) ? instance.GetResourcePath(resourceId) : null) ?? "";
	}

	// Token: 0x06017384 RID: 95108 RVA: 0x005E3B54 File Offset: 0x005E1D54
	[NullableContext(2)]
	public string GetNextLevelUnlockDescriptionInBattle()
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		List<ITowerDefensePhantomConfigSkillData> currentPhantomSkillCfgListInBattle = instance.GetCurrentPhantomSkillCfgListInBattle();
		int currentPhantomLevelInBattle = instance.GetCurrentPhantomLevelInBattle();
		if (currentPhantomLevelInBattle < 0 || currentPhantomLevelInBattle >= currentPhantomSkillCfgListInBattle.Count)
		{
			return null;
		}
		return currentPhantomSkillCfgListInBattle[currentPhantomLevelInBattle].UnlockDescription;
	}

	// Token: 0x06017385 RID: 95109 RVA: 0x005E3B8E File Offset: 0x005E1D8E
	public string BuildCurrentPhantomNameTextIdInBattle()
	{
		return TowerDefenseModel.Instance.GetCurrentPhantomNameTextId();
	}

	// Token: 0x06017386 RID: 95110 RVA: 0x005E3B9A File Offset: 0x005E1D9A
	public IActivityRewardViewData BuildPreviewRewardData()
	{
		return TowerDefenseModel.Instance.GetPreviewRewardData();
	}

	// Token: 0x06017387 RID: 95111 RVA: 0x005E3BA8 File Offset: 0x005E1DA8
	public List<TItem> BuildPhantomForInstanceDungeonEntranceData(int instanceId)
	{
		List<TItem> list = new List<TItem>();
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceByInstanceId.GetConfig(instanceId, true);
		if (config == null)
		{
			return list;
		}
		int[] array = config.Value.OptionalBuff();
		for (int i = 0; i < array.Length; i++)
		{
			TowerDefencePhantom? config2 = ConfigTowerDefencePhantomById.GetConfig(array[i], true);
			if (config2 != null)
			{
				InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(config2.Value.PhantomItemId, 0);
				list.Add(new TItem(itemData, 0));
			}
		}
		return list;
	}

	// Token: 0x06017388 RID: 95112 RVA: 0x005E3C28 File Offset: 0x005E1E28
	public TowerDefenseRecommendLevel BuildRecommendLevelForInstanceDungeonEntranceData(int instanceId)
	{
		InstanceDungeon? instanceDungeon;
		return new TowerDefenseRecommendLevel
		{
			TextId = "RecommendLevel",
			Level = ((ConfigInstanceDungeonById.GetConfig(instanceId, true) != null) ? instanceDungeon.GetValueOrDefault().RecommendLevel().GetValueOrDefault(1, 0) : 0)
		};
	}

	// Token: 0x06017389 RID: 95113 RVA: 0x005E3C78 File Offset: 0x005E1E78
	public string BuildTotalScoreContent()
	{
		int totalScore = TowerDefenseModel.Instance.PhantomMessageCache.TotalScore;
		return totalScore.ToString();
	}

	// Token: 0x0601738A RID: 95114 RVA: 0x005E3C9C File Offset: 0x005E1E9C
	public ITowerDefenseTipsContentInBattle BuildPhantomTipsInBattleData()
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		List<ITowerDefensePhantomConfigSkillData> currentPhantomSkillCfgListInBattle = instance.GetCurrentPhantomSkillCfgListInBattle();
		int currentPhantomLevelInBattle = instance.GetCurrentPhantomLevelInBattle();
		ITowerDefensePhantomConfigSkillData towerDefensePhantomConfigSkillData = currentPhantomSkillCfgListInBattle[currentPhantomLevelInBattle - 1];
		return new TowerDefenseTipsContentInBattle
		{
			TitleTextId = towerDefensePhantomConfigSkillData.Name,
			PhantomTextId = towerDefensePhantomConfigSkillData.Name,
			Level = currentPhantomLevelInBattle,
			DescTextId = towerDefensePhantomConfigSkillData.Description,
			DescArgs = instance.GetCurrentPhantomSkillDescriptionArgsInBattle()
		};
	}

	// Token: 0x0601738B RID: 95115 RVA: 0x005E3D04 File Offset: 0x005E1F04
	public string BuildTeamPhantomIconData(int playerId, int roleCfgId)
	{
		ITowerDefensePhantomDataOwner ownerData = TowerDefenseModel.Instance.GetOwnerData(playerId, roleCfgId);
		if (ownerData == null)
		{
			return null;
		}
		int phantomId = ownerData.PhantomId;
		if (phantomId <= 0)
		{
			return null;
		}
		TowerDefencePhantom? config = ConfigTowerDefencePhantomById.GetConfig(phantomId, true);
		if (config == null)
		{
			return null;
		}
		Aki.Config.PhantomItem? config2 = ConfigPhantomItemByItemId.GetConfig(config.Value.PhantomItemId, true);
		if (config2 == null)
		{
			return null;
		}
		return config2.GetValueOrDefault().IconMiddle;
	}

	// Token: 0x0601738C RID: 95116 RVA: 0x005E3D78 File Offset: 0x005E1F78
	private unsafe List<IRewardExploreConfirmButton> BuildRewardButtonList(int recordScore)
	{
		RewardExploreConfirmButtonData item = new RewardExploreConfirmButtonData
		{
			ButtonTextId = "Text_ButtonTextExit_Text",
			DescriptionTextId = null,
			IsTimeDownCloseView = false,
			IsClickedCloseView = false,
			OnClickedCallback = new Action<int>(this.RewardViewLeftClickCallback)
		};
		RewardExploreConfirmButtonData rewardExploreConfirmButtonData = new RewardExploreConfirmButtonData();
		rewardExploreConfirmButtonData.ButtonTextId = "TowerDefence_Restart";
		rewardExploreConfirmButtonData.DescriptionTextId = "TowerDefence_GPint";
		int num = 1;
		List<object> list = new List<object>(num);
		CollectionsMarshal.SetCount<object>(list, num);
		Span<object> span = CollectionsMarshal.AsSpan<object>(list);
		int index = 0;
		*span[index] = recordScore;
		rewardExploreConfirmButtonData.DescriptionArgs = list;
		rewardExploreConfirmButtonData.IsTimeDownCloseView = false;
		rewardExploreConfirmButtonData.IsClickedCloseView = false;
		rewardExploreConfirmButtonData.OnClickedCallback = new Action<int>(this.RewardViewRightClickCallback);
		RewardExploreConfirmButtonData item2 = rewardExploreConfirmButtonData;
		return new List<IRewardExploreConfirmButton>
		{
			item,
			item2
		};
	}

	// Token: 0x0601738D RID: 95117 RVA: 0x005E3E3C File Offset: 0x005E203C
	public List<int> BuildPhantomIdListByOwnRoleCfgIdList(List<int> roleCfgIdList)
	{
		List<int> list = new List<int>();
		if (this.CheckInUiFlow())
		{
			TowerDefenseModel instance = TowerDefenseModel.Instance;
			int value = PlayerInfoModel.Instance.GetId().Value;
			foreach (int roleCfgId in roleCfgIdList)
			{
				ITowerDefensePhantomDataOwner ownerData = instance.GetOwnerData(value, roleCfgId);
				int item = 0;
				if (ownerData != null)
				{
					item = ownerData.PhantomId;
				}
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x0601738E RID: 95118 RVA: 0x005E3ED0 File Offset: 0x005E20D0
	[NullableContext(2)]
	public unsafe string BuildInstanceCountDownTextParam(int instanceId)
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceByInstanceId.GetConfig(instanceId, true);
		if (config == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.TowerDefense;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "副本ID与塔防副本表不对应";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("InstanceId", instanceId);
			instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage;
		instance.PhantomMessageCache.StageMapCache.TryGetValue(config.Value.Id, out towerDefenseParsedStageMessage);
		if (towerDefenseParsedStageMessage == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module2 = ELogModule.TowerDefense;
			ELogAuthor author2 = ELogAuthor.WZ;
			string message2 = "指定塔防副本协议数据不存在";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("InstanceId", instanceId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TowerDefenseInstanceId", config.Value.Id);
			instance3.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		double num = (double)towerDefenseParsedStageMessage.UnlockTime * TimeUtil.Instance.Millisecond - TimeUtil.Instance.GetServerTime();
		if (num <= 0.0)
		{
			return "";
		}
		double num2 = Math.Max(num, TimeUtil.Instance.Minute);
		CommonDefine.ETimeType value = CommonDefine.ETimeType.Minute;
		CommonDefine.ETimeType value2 = CommonDefine.ETimeType.Minute;
		if (num2 > 86400.0)
		{
			value = CommonDefine.ETimeType.Day;
			value2 = CommonDefine.ETimeType.Day;
		}
		else if (num > 3600.0)
		{
			value = CommonDefine.ETimeType.Hour;
			value2 = CommonDefine.ETimeType.Hour;
		}
		return TimeUtil.Instance.GetCountDownDataFormat2(num2, new CommonDefine.ETimeType?(value), new CommonDefine.ETimeType?(value2)).CountDownText ?? "";
	}

	// Token: 0x0601738F RID: 95119 RVA: 0x005E4054 File Offset: 0x005E2254
	public string BuildInstanceCountDownText(int instanceId)
	{
		string text = this.BuildInstanceCountDownTextParam(instanceId);
		if (text == null)
		{
			return null;
		}
		return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("ActivityMowing_UnlockCondition", null), new string[]
		{
			text
		});
	}

	// Token: 0x06017390 RID: 95120 RVA: 0x005E4088 File Offset: 0x005E2288
	private int PhantomIconSorter(PhantomSmallItemGrid a, PhantomSmallItemGrid b)
	{
		ITowerDefensePhantomIconItemData towerDefensePhantomIconItemData = a.Data as ITowerDefensePhantomIconItemData;
		ITowerDefensePhantomIconItemData towerDefensePhantomIconItemData2 = b.Data as ITowerDefensePhantomIconItemData;
		if (towerDefensePhantomIconItemData.IsLocked == towerDefensePhantomIconItemData2.IsLocked)
		{
			return towerDefensePhantomIconItemData.ConfigId - towerDefensePhantomIconItemData2.ConfigId;
		}
		if (!towerDefensePhantomIconItemData.IsLocked)
		{
			return -1;
		}
		return 1;
	}

	// Token: 0x06017391 RID: 95121 RVA: 0x005E40D4 File Offset: 0x005E22D4
	public double GetTotalScoreProgress()
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		int maxScoreRewardThreshold = instance.GetMaxScoreRewardThreshold();
		if (maxScoreRewardThreshold <= 0)
		{
			return 0.0;
		}
		double val = (double)instance.PhantomMessageCache.TotalScore / (double)maxScoreRewardThreshold;
		return Math.Min(1.0, Math.Max(0.0, val));
	}

	// Token: 0x06017392 RID: 95122 RVA: 0x005E412C File Offset: 0x005E232C
	private void SyncMatchingPhantomId()
	{
		if (!this.CheckInUiFlow() || !this.CheckIsInMatch())
		{
			return;
		}
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		MatchTeamInfo matchTeamInfo = InstanceDungeonModel.Instance.GetMatchTeamInfo();
		if (matchTeamInfo != null)
		{
			int num = 0;
			foreach (MatchPlayerInfo matchPlayerInfo in matchTeamInfo.PlayerInfos)
			{
				int playerId = matchPlayerInfo.PlayerId;
				foreach (MatchRoleInfo matchRoleInfo in matchPlayerInfo.RoleInfo)
				{
					int roleId = matchRoleInfo.RoleId;
					int towerDefencePhantomId = matchRoleInfo.TowerDefencePhantomId;
					bool flag = this.CheckIsSelf(playerId);
					ITowerDefensePhantomDataOwner towerDefensePhantomDataOwner = instance.PhantomOwnerDataList[num++];
					towerDefensePhantomDataOwner.PlayerId = (long)playerId;
					towerDefensePhantomDataOwner.IsSelf = flag;
					towerDefensePhantomDataOwner.RoleCfgId = roleId;
					towerDefensePhantomDataOwner.RoleSkinId = matchRoleInfo.RoleSkinId;
					towerDefensePhantomDataOwner.PhantomId = towerDefencePhantomId;
					if (flag)
					{
						instance.RoleCfgId2PhantomIdMapCache[roleId] = towerDefencePhantomId;
					}
				}
			}
			for (int i = num; i < 3; i++)
			{
				instance.ResetPhantomOwnerDataByIndex(i);
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.TowerDefense;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "同步匹配数据时，队伍不足3人，所以将不足的数据重置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("第几个角色是空缺", i);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
	}

	// Token: 0x06017393 RID: 95123 RVA: 0x005E429C File Offset: 0x005E249C
	private void SyncEditBattleTeamModelToOwnerData()
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		BattleTeamModel instance2 = BattleTeamModel.Instance;
		int i = 0;
		while (i < 3)
		{
			BattleRoleSlotData slot = instance2.GetSlot(i + 1);
			if (slot == null)
			{
				goto IL_8F;
			}
			BattleRoleData roleData = slot.RoleData;
			ITowerDefensePhantomDataOwner towerDefensePhantomDataOwner = instance.PhantomOwnerDataList[i];
			if (roleData == null)
			{
				goto IL_8F;
			}
			towerDefensePhantomDataOwner.PlayerId = (long)roleData.PlayerId;
			towerDefensePhantomDataOwner.IsSelf = roleData.IsSelf;
			towerDefensePhantomDataOwner.RoleCfgId = roleData.ConfigId;
			towerDefensePhantomDataOwner.RoleSkinId = roleData.SkinId;
			towerDefensePhantomDataOwner.PhantomId = instance.RoleCfgId2PhantomIdMapCache.GetValueOrDefault(roleData.ConfigId, 0);
			IL_96:
			i++;
			continue;
			IL_8F:
			instance.ResetPhantomOwnerDataByIndex(i);
			goto IL_96;
		}
	}

	// Token: 0x06017394 RID: 95124 RVA: 0x005E434C File Offset: 0x005E254C
	private void OpenInBattleTipImplement()
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		int currentPhantomIdInBattle = instance.GetCurrentPhantomIdInBattle();
		bool valueOrDefault = instance.PhantomMessageCache.OwnPhantomInBattleNewLevelUpFlagCache.GetValueOrDefault(currentPhantomIdInBattle, false);
		if (!UiManager.Instance.IsViewOpen(EUiViewName.TowerDefenseInBattleTips) && valueOrDefault)
		{
			UiManager.Instance.OpenView(EUiViewName.TowerDefenseInBattleTips, null, null);
		}
	}

	// Token: 0x06017395 RID: 95125 RVA: 0x005E43A0 File Offset: 0x005E25A0
	[NullableContext(0)]
	public UniTask<bool> EnterTowerDefense()
	{
		TowerDefenseController.<EnterTowerDefense>d__40 <EnterTowerDefense>d__;
		<EnterTowerDefense>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<EnterTowerDefense>d__.<>1__state = -1;
		<EnterTowerDefense>d__.<>t__builder.Start<TowerDefenseController.<EnterTowerDefense>d__40>(ref <EnterTowerDefense>d__);
		return <EnterTowerDefense>d__.<>t__builder.Task;
	}

	// Token: 0x06017396 RID: 95126 RVA: 0x005E43DC File Offset: 0x005E25DC
	public void RequestScoreReward(IReadOnlyList<int> rewardIds)
	{
		if (rewardIds.Count == 0)
		{
			return;
		}
		TowerDefenceScoreRewardRequest towerDefenceScoreRewardRequest = TowerDefenceScoreRewardRequest.Create();
		TowerDefenseModel model = TowerDefenseModel.Instance;
		foreach (int item in rewardIds)
		{
			towerDefenceScoreRewardRequest.Ids.Add(item);
		}
		Net.Instance.CallAsync(ERequestMessageId.TowerDefenceScoreRewardRequest, towerDefenceScoreRewardRequest, 0).ContinueWith(delegate(IMessage msg)
		{
			TowerDefenceScoreRewardResponse towerDefenceScoreRewardResponse = (TowerDefenceScoreRewardResponse)msg;
			if (towerDefenceScoreRewardResponse == null)
			{
				return;
			}
			if (towerDefenceScoreRewardResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				foreach (int rewardId in rewardIds)
				{
					model.PhantomMessageCache.UpdateByScoreRewardRequest(rewardId);
				}
				EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, model.GetPreviewRewardData());
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, model.PhantomMessageCache.Id);
			}
		});
	}

	// Token: 0x06017397 RID: 95127 RVA: 0x005E4480 File Offset: 0x005E2680
	public void RequestInstanceReward(IReadOnlyList<int> instanceIds)
	{
		if (instanceIds.Count == 0)
		{
			return;
		}
		TowerDefenceInstanceRewardRequest towerDefenceInstanceRewardRequest = TowerDefenceInstanceRewardRequest.Create();
		TowerDefenseModel model = TowerDefenseModel.Instance;
		foreach (int item in instanceIds)
		{
			towerDefenceInstanceRewardRequest.Ids.Add(item);
		}
		Net.Instance.CallAsync(ERequestMessageId.TowerDefenceInstanceRewardRequest, towerDefenceInstanceRewardRequest, 0).ContinueWith(delegate(IMessage msg)
		{
			TowerDefenceInstanceRewardResponse towerDefenceInstanceRewardResponse = (TowerDefenceInstanceRewardResponse)msg;
			if (towerDefenceInstanceRewardResponse == null)
			{
				return;
			}
			if (towerDefenceInstanceRewardResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				foreach (int instanceId in instanceIds)
				{
					model.PhantomMessageCache.UpdateByInstanceRewardRequest(instanceId);
				}
				EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, model.GetPreviewRewardData());
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, model.PhantomMessageCache.Id);
			}
		});
	}

	// Token: 0x06017398 RID: 95128 RVA: 0x005E4524 File Offset: 0x005E2724
	public UniTask RequestSelfRankData(int activityId)
	{
		TowerDefenseController.<RequestSelfRankData>d__43 <RequestSelfRankData>d__;
		<RequestSelfRankData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestSelfRankData>d__.activityId = activityId;
		<RequestSelfRankData>d__.<>1__state = -1;
		<RequestSelfRankData>d__.<>t__builder.Start<TowerDefenseController.<RequestSelfRankData>d__43>(ref <RequestSelfRankData>d__);
		return <RequestSelfRankData>d__.<>t__builder.Task;
	}

	// Token: 0x06017399 RID: 95129 RVA: 0x005E4568 File Offset: 0x005E2768
	public UniTask RequestRankList(int levelId)
	{
		TowerDefenseController.<RequestRankList>d__44 <RequestRankList>d__;
		<RequestRankList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRankList>d__.levelId = levelId;
		<RequestRankList>d__.<>1__state = -1;
		<RequestRankList>d__.<>t__builder.Start<TowerDefenseController.<RequestRankList>d__44>(ref <RequestRankList>d__);
		return <RequestRankList>d__.<>t__builder.Task;
	}

	// Token: 0x0601739A RID: 95130 RVA: 0x005E45AC File Offset: 0x005E27AC
	public void RequestRankShowName(bool isShowName, Action callback = null)
	{
		TowerDefenceRankShowNameRequest towerDefenceRankShowNameRequest = TowerDefenceRankShowNameRequest.Create();
		towerDefenceRankShowNameRequest.ShowName = isShowName;
		Net.Instance.Call(ERequestMessageId.TowerDefenceRankShowNameRequest, towerDefenceRankShowNameRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TowerDefenceRankShowNameResponse towerDefenceRankShowNameResponse = (TowerDefenceRankShowNameResponse)msg;
			if (towerDefenceRankShowNameResponse == null)
			{
				return;
			}
			if (towerDefenceRankShowNameResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(towerDefenceRankShowNameResponse.ErrorCode, 17275, null, true, true);
				return;
			}
			Action callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2();
		}, 0);
	}

	// Token: 0x0601739B RID: 95131 RVA: 0x005E45F0 File Offset: 0x005E27F0
	[NullableContext(2)]
	private void OnActivityInfoUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		TowerDefenceInfoUpdateNotify towerDefenceInfoUpdateNotify = (TowerDefenceInfoUpdateNotify)msg;
		if (towerDefenceInfoUpdateNotify.ActivityInfo == null)
		{
			return;
		}
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		instance.PhantomMessageCache.ParseTowerDefenseActivityData(towerDefenceInfoUpdateNotify.ActivityInfo);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, instance.PhantomMessageCache.Id);
		EventSystem.Instance.Emit(EEventName.TowerDefenseOnActivityInfoUpdateNotify);
	}

	// Token: 0x0601739C RID: 95132 RVA: 0x005E4650 File Offset: 0x005E2850
	[NullableContext(2)]
	private void OnInstanceInfoUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		TowerDefenceInstanceInfoUpdateNotify towerDefenceInstanceInfoUpdateNotify = (TowerDefenceInstanceInfoUpdateNotify)msg;
		TowerDefenseModel.Instance.PhantomMessageCache.ParseTowerDefenseInstanceDataList(towerDefenceInstanceInfoUpdateNotify.InstanceInfos.ToList<TowerDefenceInstanceInfo>(), false);
		EventSystem.Instance.Emit(EEventName.TowerDefenseOnInstanceInfoUpdateNotify);
	}

	// Token: 0x0601739D RID: 95133 RVA: 0x005E4690 File Offset: 0x005E2890
	[NullableContext(2)]
	private void OnPhantomInfoUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		TowerDefencePhantomInfoUpdateNotify towerDefencePhantomInfoUpdateNotify = (TowerDefencePhantomInfoUpdateNotify)msg;
		TowerDefenseModel.Instance.PhantomMessageCache.ParseTowerDefenseOwnPhantomDataList(towerDefencePhantomInfoUpdateNotify.Phantoms.ToList<TowerDefencePhantomInfo>());
		EventSystem.Instance.Emit(EEventName.TowerDefenseOnPhantomInfoUpdateNotify);
		this.OpenInBattleTipImplement();
	}

	// Token: 0x0601739E RID: 95134 RVA: 0x005E46D4 File Offset: 0x005E28D4
	[NullableContext(2)]
	private void OnTowerDefenseBattleEndNotify(IMessage msg, Net.CallbackStatus _)
	{
		TowerDefenceEndNotify towerDefenceEndNotify = (TowerDefenceEndNotify)msg;
		if (GameModeModel.Instance.WorldDoneAndLoadingClosed)
		{
			this.HandleEndNotifyImplement(towerDefenceEndNotify);
			return;
		}
		TowerDefenseModel.Instance.DelayedEndNotify = towerDefenceEndNotify;
	}

	// Token: 0x0601739F RID: 95135 RVA: 0x005E4708 File Offset: 0x005E2908
	[NullableContext(2)]
	private void OnEnterInstNotify(IMessage msg, Net.CallbackStatus _)
	{
		TowerDefenceEnterInstNotify towerDefenceEnterInstNotify = (TowerDefenceEnterInstNotify)msg;
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		instance.ResetPhantomOwnerDataList();
		for (int i = 0; i < towerDefenceEnterInstNotify.RoleList.Count; i++)
		{
			TowerDefenceRoleInfo towerDefenceRoleInfo = towerDefenceEnterInstNotify.RoleList[i];
			ITowerDefensePhantomDataOwner towerDefensePhantomDataOwner = instance.PhantomOwnerDataList[i];
			TowerDefencePhantomInfo phantom = towerDefenceRoleInfo.Phantom;
			int id = phantom.Id;
			towerDefensePhantomDataOwner.RoleCfgId = towerDefenceRoleInfo.RoleId;
			towerDefensePhantomDataOwner.PhantomId = id;
			instance.PhantomMessageCache.OwnPhantomInBattleDataCache[id] = phantom;
		}
		BattleUiModel.Instance.RegisterTopPanelHook(new TowerDefenseTopHudHook());
	}

	// Token: 0x060173A0 RID: 95136 RVA: 0x005E47A0 File Offset: 0x005E29A0
	[NullableContext(2)]
	private void OnRoleReviveNotify(IMessage msg, Net.CallbackStatus _)
	{
		TowerDefenceRoleReviveNotify notify = (TowerDefenceRoleReviveNotify)msg;
		long targetTime = notify.ReviveTime;
		double serverStopTimeStamp = TimeUtil.Instance.GetServerStopTimeStamp();
		double total = TimeUtil.Instance.SetTimeSecond((double)targetTime - serverStopTimeStamp);
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(total + 0.5);
		if (!string.IsNullOrEmpty(remainTimeDataFormat.CountDownText))
		{
			if (this.CheckIsSelf(notify.PlayerId))
			{
				GenericPromptController.Instance.ShowPromptByCode("TowerDefenceRoleDie", new object[]
				{
					remainTimeDataFormat.CountDownText
				});
			}
			else
			{
				GenericPromptController.Instance.ShowPromptByCode("TowerDefencePlayerDie", new object[]
				{
					remainTimeDataFormat.CountDownText
				});
			}
		}
		TowerDefenseModel model = TowerDefenseModel.Instance;
		TimerHandle handle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			double serverStopTimeStamp2 = TimeUtil.Instance.GetServerStopTimeStamp();
			if (serverStopTimeStamp2 >= (double)targetTime)
			{
				EventSystem.Instance.Emit<int, int, float?, float?>(EEventName.OnRefreshFormationCooldownExternalInBattleView, notify.PlayerId, notify.RoleId, null, null);
				model.TryRemoveTimerInBattle(notify.PlayerId, new int?(notify.RoleId));
				return;
			}
			EventSystem.Instance.Emit<int, int, float?, float?>(EEventName.OnRefreshFormationCooldownExternalInBattleView, notify.PlayerId, notify.RoleId, new float?((float)TimeUtil.Instance.SetTimeSecond((double)targetTime - serverStopTimeStamp2)), new float?((float)total));
		}, 100f, 1f, null, null, true);
		model.TryAddTimerInBattle(handle, notify.PlayerId, notify.RoleId);
	}

	// Token: 0x060173A1 RID: 95137 RVA: 0x005E48C0 File Offset: 0x005E2AC0
	[NullableContext(2)]
	private void OnPlayerReviveNotify(IMessage msg, Net.CallbackStatus _)
	{
		TowerDefencePlayerReviveNotify notify = (TowerDefencePlayerReviveNotify)msg;
		long targetTime = MathUtils.Instance.LongToNumber(notify.ReviveTime);
		double serverStopTimeStamp = TimeUtil.Instance.GetServerStopTimeStamp();
		double total = TimeUtil.Instance.SetTimeSecond((double)targetTime - serverStopTimeStamp);
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(0.5 + TimeUtil.Instance.SetTimeSecond((double)targetTime - serverStopTimeStamp));
		if (this.CheckIsSelf(notify.PlayerId))
		{
			TowerDefenseModel.Instance.SelfReviveTargetTimestampForUi = new long?(MathUtils.Instance.LongToNumber(notify.ReviveTime));
		}
		else if (!string.IsNullOrEmpty(remainTimeDataFormat.CountDownText))
		{
			OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(notify.PlayerId);
			int num = (currentTeamListById != null) ? currentTeamListById.PlayerNumber : 0;
			GenericPromptController.Instance.ShowPromptByCode("TowerDefencePlayerRoleDie", new object[]
			{
				num,
				remainTimeDataFormat.CountDownText
			});
		}
		TowerDefenseModel model = TowerDefenseModel.Instance;
		model.TryRemoveTimerInBattle(notify.PlayerId, null);
		BattleUiFormationPanelData formationPanelData = BattleUiModel.Instance.FormationPanelData;
		Dictionary<int, FormationItemData> dictionary = (formationPanelData != null) ? formationPanelData.PositionItemMap : null;
		if (dictionary != null)
		{
			using (Dictionary<int, FormationItemData>.ValueCollection.Enumerator enumerator = dictionary.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					FormationItemData itemData = enumerator.Current;
					if (itemData.PlayerId == notify.PlayerId)
					{
						TimerHandle handle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
						{
							double serverStopTimeStamp2 = TimeUtil.Instance.GetServerStopTimeStamp();
							if (serverStopTimeStamp2 >= (double)targetTime)
							{
								EventSystem.Instance.Emit<int, int, float?, float?>(EEventName.OnRefreshFormationCooldownExternalInBattleView, notify.PlayerId, 0, null, null);
								model.TryRemoveTimerInBattle(notify.PlayerId, new int?(itemData.RoleId));
								return;
							}
							EventSystem.Instance.Emit<int, int, float?, float?>(EEventName.OnRefreshFormationCooldownExternalInBattleView, notify.PlayerId, 0, new float?((float)TimeUtil.Instance.SetTimeSecond((double)targetTime - serverStopTimeStamp2)), new float?((float)total));
						}, 100f, 1f, null, null, true);
						model.TryAddTimerInBattle(handle, notify.PlayerId, itemData.RoleId);
					}
				}
			}
		}
	}

	// Token: 0x060173A2 RID: 95138 RVA: 0x005E4AF0 File Offset: 0x005E2CF0
	public void HandleOnClickReward()
	{
		UiManager.Instance.OpenView(EUiViewName.TowerDefenseRewardView, TowerDefenseModel.Instance.GetPreviewRewardData(), delegate(bool success, int viewId)
		{
			EUiViewName viewName = UiManager.Instance.IsViewOpen(EUiViewName.TowerDefenseLevelView) ? EUiViewName.TowerDefenseLevelView : EUiViewName.CommonActivityView;
			if (UiManager.Instance.IsViewOpen(viewName))
			{
				UiViewBase viewByName = UiManager.Instance.GetViewByName(viewName);
				if (viewByName == null)
				{
					return;
				}
				viewByName.AddChildViewById(viewId);
			}
		});
	}

	// Token: 0x060173A3 RID: 95139 RVA: 0x005E4B2A File Offset: 0x005E2D2A
	private void HandleBeforeConfirmQuickRoleSelect()
	{
		if (!this.CheckInUiFlow())
		{
			return;
		}
		this.SyncEditBattleTeamModelToOwnerData();
		EventSystem.Instance.Emit(EEventName.TowerDefensePhantomChanged);
	}

	// Token: 0x060173A4 RID: 95140 RVA: 0x005E4B4B File Offset: 0x005E2D4B
	private void HandleOnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
	}

	// Token: 0x060173A5 RID: 95141 RVA: 0x005E4B4D File Offset: 0x005E2D4D
	private void HandleEnterInstanceDungeon()
	{
		if (this.CheckInInstanceDungeon())
		{
			EventSystem.Instance.Emit<bool>(EEventName.TowerDefenseShowInBattleView, true);
		}
	}

	// Token: 0x060173A6 RID: 95142 RVA: 0x005E4B68 File Offset: 0x005E2D68
	private void HandleLeaveInstanceDungeon()
	{
		TowerDefenseModel.Instance.ResetTimerCacheInBattle();
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.BattleView);
		if (viewByName != null)
		{
			(viewByName as BattleView).ResetFormationCooldownExternal();
		}
		EventSystem.Instance.Emit<bool>(EEventName.TowerDefenseShowInBattleView, false);
	}

	// Token: 0x060173A7 RID: 95143 RVA: 0x005E4BAE File Offset: 0x005E2DAE
	private void HandleLeaveInstanceExternalConfirm()
	{
		if (!this.CheckInInstanceDungeon())
		{
			return;
		}
		InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().ContinueWith(delegate(bool task)
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.ExploreRewardView))
			{
				UiManager.Instance.CloseView(EUiViewName.ExploreRewardView, null);
			}
			TowerDefenseModel instance = TowerDefenseModel.Instance;
			instance.IsNeedShowMainView = true;
			instance.ResetAllCache();
		});
	}

	// Token: 0x060173A8 RID: 95144 RVA: 0x005E4BE8 File Offset: 0x005E2DE8
	private void RewardViewLeftClickCallback(int buttonIndex)
	{
		this.RequestChallengeQuit();
	}

	// Token: 0x060173A9 RID: 95145 RVA: 0x005E4BF0 File Offset: 0x005E2DF0
	private void RewardViewRightClickCallback(int buttonIndex)
	{
		this.HandleSettleViewRestart(buttonIndex);
	}

	// Token: 0x060173AA RID: 95146 RVA: 0x005E4BFC File Offset: 0x005E2DFC
	public void HandleSettleViewExit()
	{
		TowerDefenseModel.Instance.IsNeedShowMainView = true;
		InstanceDungeonModel.Instance.LastEnterRoleList = null;
		if (UiManager.Instance.IsViewShow(EUiViewName.ExploreRewardView))
		{
			UiManager.Instance.CloseView(EUiViewName.ExploreRewardView, null);
		}
		if (UiManager.Instance.IsViewShow(EUiViewName.TowerDefenseSettleView))
		{
			UiManager.Instance.CloseView(EUiViewName.TowerDefenseSettleView, null);
		}
		TowerDefenseModel.Instance.ResetAllCache();
	}

	// Token: 0x060173AB RID: 95147 RVA: 0x005E4C6C File Offset: 0x005E2E6C
	public void RequestChallengeQuit()
	{
		TowerDefenceChallengeQuitRequest message = TowerDefenceChallengeQuitRequest.Create();
		Net.Instance.CallAsync(ERequestMessageId.TowerDefenceChallengeQuitRequest, message, 0).ContinueWith(delegate(IMessage msg)
		{
			TowerDefenceChallengeQuitResponse towerDefenceChallengeQuitResponse = (TowerDefenceChallengeQuitResponse)msg;
			if (towerDefenceChallengeQuitResponse == null)
			{
				return;
			}
			if (towerDefenceChallengeQuitResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(towerDefenceChallengeQuitResponse.ErrorCode, 29413, null, true, true);
				return;
			}
			this.HandleSettleViewExit();
		});
	}

	// Token: 0x060173AC RID: 95148 RVA: 0x005E4CA4 File Offset: 0x005E2EA4
	public void HandleSettleViewRestart(int buttonIndex = 0)
	{
		if (TowerDefenseModel.Instance.GetOrCreateParsedTowerDefenseMsg().CheckIfClose())
		{
			GenericPromptController.Instance.ShowPromptByCode("TowerDefenceActivityEnd", Array.Empty<object>());
			return;
		}
		if (GameModeModel.Instance.IsMulti)
		{
			InstanceDungeonEntranceController.Instance.SettleViewButtonSuccessOnMultiCallBack(buttonIndex);
			return;
		}
		InstanceDungeonEntranceController.Instance.RestartInstanceDungeon().ContinueWith(delegate(bool task)
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.ExploreRewardView))
			{
				UiManager.Instance.CloseView(EUiViewName.ExploreRewardView, null);
			}
		});
	}

	// Token: 0x060173AD RID: 95149 RVA: 0x005E4D1E File Offset: 0x005E2F1E
	private void HandleBattleScoreChanged(int scoreId, int scoreValue)
	{
		this.CheckInInstanceDungeon();
	}

	// Token: 0x060173AE RID: 95150 RVA: 0x005E4D27 File Offset: 0x005E2F27
	private void HandleOnBeforeDestroyInstanceDungeonEntranceView()
	{
		this.CheckInUiFlow();
		this.SetIsUiFlowOpen(false);
	}

	// Token: 0x060173AF RID: 95151 RVA: 0x005E4D38 File Offset: 0x005E2F38
	private void HandleOnRefreshEditBattleRoleSlotData(ERefreshRoleSlotReason reason)
	{
		if (!this.CheckInUiFlow())
		{
			return;
		}
		if (this.CheckIsInMatch())
		{
			this.SyncMatchingPhantomId();
		}
		else
		{
			if (reason == ERefreshRoleSlotReason.ChangeTeamOffline)
			{
				TowerDefenseModel.Instance.RoleCfgId2PhantomIdMapCache.Clear();
			}
			this.SyncEditBattleTeamModelToOwnerData();
		}
		EventSystem.Instance.Emit(EEventName.TowerDefensePhantomChanged);
	}

	// Token: 0x060173B0 RID: 95152 RVA: 0x005E4D87 File Offset: 0x005E2F87
	private void HandleTowerDefenseSelfPhantomConfirm(int roleCfgId)
	{
		this.SyncSelfTowerDefensePhantomId(roleCfgId);
		this.ResetCurrentTowerDefensePhantomIdInUiTemp();
	}

	// Token: 0x060173B1 RID: 95153 RVA: 0x005E4D98 File Offset: 0x005E2F98
	private void HandleWorldDoneAndCloseLoading()
	{
		this.TryReopenLevelViewOnWorldReturn();
		if (!this.CheckInInstanceDungeon())
		{
			return;
		}
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		if (instance.DelayedEndNotify != null)
		{
			this.HandleEndNotifyImplement(instance.DelayedEndNotify);
			instance.DelayedEndNotify = null;
		}
	}

	// Token: 0x060173B2 RID: 95154 RVA: 0x005E4DD8 File Offset: 0x005E2FD8
	private void TryReopenLevelViewOnWorldReturn()
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		if (!instance.IsNeedShowMainView)
		{
			return;
		}
		instance.IsNeedShowMainView = false;
		if (instance.GetOrCreateParsedTowerDefenseMsg().CheckIfClose())
		{
			return;
		}
		SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.None, ESplashScreenType.Other, delegate()
		{
			InstanceDungeonEntranceController.Instance.EnterEntrance(InstanceDungeonEntranceModel.Instance.EntranceId, 0, null);
		});
		SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, false);
	}

	// Token: 0x060173B3 RID: 95155 RVA: 0x005E4E3C File Offset: 0x005E303C
	private void HandleCloseView(EUiViewName viewName, int ViewId)
	{
		if (this.CheckInUiFlow() && viewName == EUiViewName.BattleTeam2DView)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.TowerDefensePhantomView))
			{
				UiManager.Instance.CloseView(EUiViewName.TowerDefensePhantomView, null);
			}
			TowerDefenseModel.Instance.RoleCfgId2PhantomIdMapCache.Clear();
			if (!this.CheckActivityUnlockByMulti())
			{
				this.SetIsUiFlowOpen(false);
			}
		}
	}

	// Token: 0x060173B4 RID: 95156 RVA: 0x005E4E9D File Offset: 0x005E309D
	private void OnSelectInstanceIdChallenge(int instanceId)
	{
		TowerDefenseModel.Instance.SetLevelHasClickByInstanceId(instanceId);
	}

	// Token: 0x060173B5 RID: 95157 RVA: 0x005E4EAA File Offset: 0x005E30AA
	public void SetCurrentTowerDefensePhantomIdInUiTemp(int id)
	{
		TowerDefenseModel.Instance.CurrentSelfPhantomIdInUiTemp = id;
	}

	// Token: 0x060173B6 RID: 95158 RVA: 0x005E4EB7 File Offset: 0x005E30B7
	public void ResetCurrentTowerDefensePhantomIdInUiTemp()
	{
		TowerDefenseModel.Instance.ResetCurrentPhantomIdInUiTempToFirstAvailable();
	}

	// Token: 0x060173B7 RID: 95159 RVA: 0x005E4EC3 File Offset: 0x005E30C3
	public void ToggleInBattleView()
	{
		EventSystem.Instance.Emit(EEventName.BattleUiToggleTowerDefenseInfoView);
	}

	// Token: 0x060173B8 RID: 95160 RVA: 0x005E4ED8 File Offset: 0x005E30D8
	public void ResetCurrentPhantomLevelUpFlag(int level)
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		int currentPhantomIdInBattle = instance.GetCurrentPhantomIdInBattle();
		int currentPhantomLevelInBattle = instance.GetCurrentPhantomLevelInBattle();
		instance.PhantomMessageCache.OwnPhantomInBattleNewLevelUpFlagCache[currentPhantomIdInBattle] = (currentPhantomLevelInBattle > level);
	}

	// Token: 0x060173B9 RID: 95161 RVA: 0x005E4F0C File Offset: 0x005E310C
	public void TryReopenInBattleTip()
	{
		this.OpenInBattleTipImplement();
	}

	// Token: 0x060173BA RID: 95162 RVA: 0x005E4F14 File Offset: 0x005E3114
	public void TryOpenPhantomViewByPlayerIdAndRoleId(int playerId, int roleId)
	{
		if (this.CheckIsSelf(playerId))
		{
			if (InstanceDungeonModel.Instance.GetPrewarPlayerReadyState(playerId))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("TowerDefence_PhantasmTips", Array.Empty<object>());
				return;
			}
			TowerDefensePhantomViewArgs param = new TowerDefensePhantomViewArgs
			{
				RoleCfgId = roleId
			};
			UiManager.Instance.OpenView(EUiViewName.TowerDefensePhantomView, param, null);
		}
	}

	// Token: 0x060173BB RID: 95163 RVA: 0x005E4F6C File Offset: 0x005E316C
	public void SyncSelfTowerDefensePhantomId(int roleCfgId)
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		int value = PlayerInfoModel.Instance.GetId().Value;
		ITowerDefensePhantomDataOwner ownerData = instance.GetOwnerData(value, roleCfgId);
		if (ownerData == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.TowerDefense;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "自己选择声骸后，找不到自己的OwnerData，声骸ID不进行同步";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleCfgId", roleCfgId);
			instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		ownerData.PhantomId = instance.CurrentSelfPhantomIdInUiTemp;
		instance.RoleCfgId2PhantomIdMapCache[roleCfgId] = instance.CurrentSelfPhantomIdInUiTemp;
		if (this.CheckIsInMatch())
		{
			BattleTeamModel instance3 = BattleTeamModel.Instance;
			InstanceDungeonEntranceController.Instance.MatchChangeRoleRequest(instance3.OwnRoleConfigIdList.Item1).ContinueWith(delegate(bool bSuccess)
			{
				if (bSuccess)
				{
					EventSystem.Instance.Emit(EEventName.TowerDefensePhantomChanged);
				}
			});
			return;
		}
		EventSystem.Instance.Emit(EEventName.TowerDefensePhantomChanged);
	}

	// Token: 0x060173BC RID: 95164 RVA: 0x005E5048 File Offset: 0x005E3248
	private void HandleEndNotifyImplement(TowerDefenceEndNotify notify)
	{
		if (!GameModeController.Instance.IsInInstance())
		{
			return;
		}
		if (notify.Success && GameModeModel.Instance.IsMulti)
		{
			this.OpenTowerDefenseSuccessSettleView(notify);
		}
		else
		{
			this.OpenTowerDefenseSettleView(notify);
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.TowerDefenseInBattleTips))
		{
			UiManager.Instance.CloseView(EUiViewName.TowerDefenseInBattleTips, null);
		}
		EventSystem.Instance.Emit(EEventName.TowerDefenseOnTowerDefenseBattleEndNotify);
	}

	// Token: 0x060173BD RID: 95165 RVA: 0x005E50B8 File Offset: 0x005E32B8
	public unsafe void OpenTowerDefenseResultView(TowerDefenceEndNotify notify)
	{
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceById.GetConfig(notify.InstId, true);
		if (config == null)
		{
			return;
		}
		bool isDifficult = config.Value.IsDifficult;
		string titleTextId = string.Empty;
		string record = string.Empty;
		int? recordRollingTo = null;
		List<IRewardExploreConfirmButton> list = this.BuildRewardButtonList(notify.MaxScore);
		if (isDifficult)
		{
			if (notify.Success)
			{
				titleTextId = "TowerDefenceWinTime";
				record = TimeUtil.Instance.GetTimeString((double)notify.PassTime);
			}
			else
			{
				titleTextId = "TowerDefencelose";
				record = string.Empty;
			}
			list[1].DescriptionTextId = "TowerDefenceBestTime";
			IRewardExploreConfirmButton rewardExploreConfirmButton = list[1];
			int num = 1;
			List<object> list2 = new List<object>(num);
			CollectionsMarshal.SetCount<object>(list2, num);
			Span<object> span = CollectionsMarshal.AsSpan<object>(list2);
			int index = 0;
			*span[index] = TimeUtil.Instance.GetTimeString((double)notify.MinPassTime);
			rewardExploreConfirmButton.DescriptionArgs = list2;
		}
		else if (notify.Success)
		{
			titleTextId = "MowingCurrentPoint";
			record = string.Empty;
			recordRollingTo = new int?(notify.Score);
		}
		else
		{
			titleTextId = "TowerDefencelose";
			record = string.Empty;
		}
		ExploreRewardViewData data = new ExploreRewardViewData
		{
			ConfigId = (notify.Success ? 3018 : 3017),
			IsSuccess = notify.Success,
			ExploreRecordInfo = new RewardExploreRecordData
			{
				TitleTextId = titleTextId,
				Record = record,
				RecordRollingTo = recordRollingTo,
				IsNewRecord = (isDifficult ? (notify.PassTime != 0 && notify.MinPassTime >= notify.PassTime) : (notify.Score >= notify.MaxScore && notify.Score != 0))
			},
			ButtonInfoList = list
		};
		ItemRewardController.Instance.OpenExploreRewardViewNew(data);
	}

	// Token: 0x060173BE RID: 95166 RVA: 0x005E526F File Offset: 0x005E346F
	public void OpenTowerDefenseSettleView(TowerDefenceEndNotify notify)
	{
		UiManager.Instance.OpenView(EUiViewName.TowerDefenseSettleView, notify, null);
	}

	// Token: 0x060173BF RID: 95167 RVA: 0x005E5284 File Offset: 0x005E3484
	private void OpenTowerDefenseSuccessSettleView(TowerDefenceEndNotify notify)
	{
		List<ISolarSpeedRolePanelData> list = new List<ISolarSpeedRolePanelData>();
		List<int> list2 = new List<int>();
		foreach (TowerDefenceRoleScoreInfo towerDefenceRoleScoreInfo in notify.BattleInfo)
		{
			int playerId = towerDefenceRoleScoreInfo.PlayerId;
			int num = list2.IndexOf(playerId);
			int index;
			if (num != -1)
			{
				index = num;
			}
			else
			{
				index = list2.Count;
				list2.Add(playerId);
			}
			OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(playerId);
			bool flag = currentTeamListById != null && currentTeamListById.IsSelf;
			List<ITowerDefenseRoleDescData> list3 = new List<ITowerDefenseRoleDescData>();
			foreach (TowerDefenceBattleScoreInfo towerDefenceBattleScoreInfo in towerDefenceRoleScoreInfo.ScoreList)
			{
				TowerDefenseRoleDescData item = new TowerDefenseRoleDescData
				{
					Title = towerDefenceBattleScoreInfo.Id,
					Count = towerDefenceBattleScoreInfo.Score
				};
				list3.Add(item);
			}
			TowerDefenseRolePanelData item2 = new TowerDefenseRolePanelData
			{
				Rank = 0,
				PlayerId = playerId,
				IsAddButtonAvailable = (!flag && !FriendModel.Instance.IsMyFriend(playerId)),
				IsSelf = flag,
				BgPath = SolarSpeedDefine.rankBgPathMap[0],
				MedalColorHex = SolarSpeedDefine.medalColorHex[0],
				FxColorHex = SolarSpeedDefine.fxColorHex[0],
				PlayerIndexIconPath = (flag ? SolarSpeedDefine.playerIndexSelfIconMap[index] : SolarSpeedDefine.playerIndexIconMap[index]),
				NameText = (((currentTeamListById != null) ? currentTeamListById.PlayerName : null) ?? string.Empty),
				IconData = new SolarSpeedRoleIconPanelData
				{
					IconPath = ((currentTeamListById == null) ? string.Empty : PersonalModel.Instance.GetPlayerHeadData(currentTeamListById.HeadId, false).GetRoleHeadIconCircle())
				},
				BestTitle = towerDefenceRoleScoreInfo.Title,
				DescDataList = list3
			};
			list.Add(item2);
		}
		SolarSpeedResultViewData solarSpeedResultViewData = new SolarSpeedResultViewData();
		solarSpeedResultViewData.TitleId = "TowerDefenceSettlement01";
		solarSpeedResultViewData.RoleDataList = list;
		solarSpeedResultViewData.PanelType = (() => new TowerDefenseRolePanel());
		solarSpeedResultViewData.ConfirmClick = delegate()
		{
			this.OpenTowerDefenseSettleView(notify);
		};
		SolarSpeedResultViewData param = solarSpeedResultViewData;
		UiManager.Instance.OpenView(EUiViewName.SolarSpeedResultView, param, null);
	}

	// Token: 0x060173C0 RID: 95168 RVA: 0x005E552C File Offset: 0x005E372C
	public int GetLevelInBattle()
	{
		return TowerDefenseModel.Instance.GetCurrentPhantomLevelInBattle();
	}

	// Token: 0x060173C1 RID: 95169 RVA: 0x005E5538 File Offset: 0x005E3738
	public string GetLevelContentInBattle()
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		if (instance.CheckCurrentActivityShowDifferent())
		{
			return ConfigMultiTextLang.GetLocalTextNew("TowerDefencewenhao", null) ?? string.Empty;
		}
		return instance.GetCurrentPhantomLevelInBattle().ToString();
	}

	// Token: 0x060173C2 RID: 95170 RVA: 0x005E5578 File Offset: 0x005E3778
	[NullableContext(2)]
	public ITowerDefensePhantomExp GetExpDataInBattle()
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		if (instance.CheckCurrentActivityShowDifferent())
		{
			return null;
		}
		return instance.GetCurrentPhantomExpPairInBattle();
	}

	// Token: 0x060173C3 RID: 95171 RVA: 0x005E559C File Offset: 0x005E379C
	public float GetProgressInBattle()
	{
		ITowerDefensePhantomExp currentPhantomExpPairInBattle = TowerDefenseModel.Instance.GetCurrentPhantomExpPairInBattle();
		if (currentPhantomExpPairInBattle.Exp == 0.0)
		{
			return 0f;
		}
		if (currentPhantomExpPairInBattle.Threshold == 0.0)
		{
			return 1f;
		}
		return (float)(currentPhantomExpPairInBattle.Exp / currentPhantomExpPairInBattle.Threshold);
	}

	// Token: 0x060173C4 RID: 95172 RVA: 0x005E55F0 File Offset: 0x005E37F0
	public bool GetIsFirstOpen()
	{
		return TowerDefenseModel.Instance.GetOrCreateParsedTowerDefenseMsg().GetIfFirstOpen();
	}

	// Token: 0x060173C5 RID: 95173 RVA: 0x005E5601 File Offset: 0x005E3801
	public string GetActivitySubViewTitle()
	{
		return TowerDefenseModel.Instance.GetOrCreateParsedTowerDefenseMsg().GetTitle();
	}

	// Token: 0x060173C6 RID: 95174 RVA: 0x005E5612 File Offset: 0x005E3812
	public Activity GetActivityCfg()
	{
		return TowerDefenseModel.Instance.GetOrCreateParsedTowerDefenseMsg().LocalConfig.Value;
	}

	// Token: 0x060173C7 RID: 95175 RVA: 0x005E5628 File Offset: 0x005E3828
	public List<TItem> GetActivityPreviewReward()
	{
		return TowerDefenseModel.Instance.GetOrCreateParsedTowerDefenseMsg().GetPreviewReward(null);
	}

	// Token: 0x060173C8 RID: 95176 RVA: 0x005E5650 File Offset: 0x005E3850
	public EUiViewName? TryGetReviveViewName()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.ExploreRewardView))
		{
			return null;
		}
		return new EUiViewName?(EUiViewName.TowerDefenceReviveView);
	}

	// Token: 0x060173C9 RID: 95177 RVA: 0x005E5682 File Offset: 0x005E3882
	public SceneTeamItem GetCurrentSceneTeamItem()
	{
		return SceneTeamModel.Instance.GetCurrentTeamItem;
	}

	// Token: 0x060173CA RID: 95178 RVA: 0x005E568E File Offset: 0x005E388E
	public List<SceneTeamItem> GetAllOwnSceneTeamItems()
	{
		return SceneTeamModel.Instance.GetTeamItems(true);
	}

	// Token: 0x060173CB RID: 95179 RVA: 0x005E569B File Offset: 0x005E389B
	public int GetSuitableStageId()
	{
		return TowerDefenseModel.Instance.PhantomMessageCache.GetSuitableStageId();
	}

	// Token: 0x060173CC RID: 95180 RVA: 0x005E56AC File Offset: 0x005E38AC
	public bool CheckStageUnlockById(int id)
	{
		TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(id);
		if (towerDefenseConfigById == null)
		{
			return false;
		}
		if (towerDefenseConfigById.Value.BossRush)
		{
			return this.CheckAllPrerequisiteStagesPassed();
		}
		if (!this.IsStageTimeReachedById(id))
		{
			return false;
		}
		if (towerDefenseConfigById.Value.Difficulty == 1)
		{
			return true;
		}
		int sameGroupNormalStageId = this.GetSameGroupNormalStageId(towerDefenseConfigById.Value.GroupId);
		return sameGroupNormalStageId <= 0 || this.CheckStagePassedById(sameGroupNormalStageId);
	}

	// Token: 0x060173CD RID: 95181 RVA: 0x005E572A File Offset: 0x005E392A
	public bool IsStageTimeReachedById(int id)
	{
		return TowerDefenseModel.Instance.PhantomMessageCache.IsStageUnlockedByTowerDefenseInstanceId(id);
	}

	// Token: 0x060173CE RID: 95182 RVA: 0x005E573C File Offset: 0x005E393C
	public bool CheckStageSelectableById(int id)
	{
		TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(id);
		if (towerDefenseConfigById == null)
		{
			return false;
		}
		if (towerDefenseConfigById.Value.BossRush)
		{
			return this.CheckStageUnlockById(id);
		}
		int sameGroupNormalStageId = this.GetSameGroupNormalStageId(towerDefenseConfigById.Value.GroupId);
		if (sameGroupNormalStageId <= 0)
		{
			return this.IsStageTimeReachedById(id);
		}
		return this.IsStageTimeReachedById(sameGroupNormalStageId);
	}

	// Token: 0x060173CF RID: 95183 RVA: 0x005E57A4 File Offset: 0x005E39A4
	public int GetSameGroupNormalStageId(int groupId)
	{
		List<ITowerDefenseParsedStageMessage> stageListCache = TowerDefenseModel.Instance.PhantomMessageCache.StageListCache;
		if (stageListCache == null)
		{
			return 0;
		}
		foreach (ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage in stageListCache)
		{
			TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(towerDefenseParsedStageMessage.Id);
			if (towerDefenseConfigById != null && !towerDefenseConfigById.Value.BossRush && towerDefenseConfigById.Value.GroupId == groupId && towerDefenseConfigById.Value.Difficulty == 1)
			{
				return towerDefenseParsedStageMessage.Id;
			}
		}
		return 0;
	}

	// Token: 0x060173D0 RID: 95184 RVA: 0x005E5860 File Offset: 0x005E3A60
	public bool CheckAllPrerequisiteStagesPassed()
	{
		List<ITowerDefenseParsedStageMessage> stageListCache = TowerDefenseModel.Instance.PhantomMessageCache.StageListCache;
		if (stageListCache == null)
		{
			return false;
		}
		foreach (ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage in stageListCache)
		{
			TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(towerDefenseParsedStageMessage.Id);
			if (towerDefenseConfigById != null && !towerDefenseConfigById.Value.BossRush && towerDefenseConfigById.Value.Difficulty == 1 && !this.CheckStagePassedById(towerDefenseParsedStageMessage.Id))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060173D1 RID: 95185 RVA: 0x005E5914 File Offset: 0x005E3B14
	public int GetSameGroupHardStageId(int groupId)
	{
		List<ITowerDefenseParsedStageMessage> stageListCache = TowerDefenseModel.Instance.PhantomMessageCache.StageListCache;
		if (stageListCache == null)
		{
			return 0;
		}
		foreach (ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage in stageListCache)
		{
			TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(towerDefenseParsedStageMessage.Id);
			if (towerDefenseConfigById != null && !towerDefenseConfigById.Value.BossRush && towerDefenseConfigById.Value.GroupId == groupId && towerDefenseConfigById.Value.Difficulty != 1)
			{
				return towerDefenseParsedStageMessage.Id;
			}
		}
		return 0;
	}

	// Token: 0x060173D2 RID: 95186 RVA: 0x005E59D0 File Offset: 0x005E3BD0
	public int GetLatestUnlockedGroupId()
	{
		List<ITowerDefenseParsedStageMessage> stageListCache = TowerDefenseModel.Instance.PhantomMessageCache.StageListCache;
		if (stageListCache == null)
		{
			return 0;
		}
		int result = 0;
		foreach (ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage in stageListCache)
		{
			TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(towerDefenseParsedStageMessage.Id);
			if (towerDefenseConfigById != null && !towerDefenseConfigById.Value.BossRush && towerDefenseConfigById.Value.Difficulty == 1 && this.IsStageTimeReachedById(towerDefenseParsedStageMessage.Id))
			{
				result = towerDefenseConfigById.Value.GroupId;
			}
		}
		return result;
	}

	// Token: 0x060173D3 RID: 95187 RVA: 0x005E5A90 File Offset: 0x005E3C90
	public int GetLastBossRushStageId()
	{
		List<ITowerDefenseParsedStageMessage> stageListCache = TowerDefenseModel.Instance.PhantomMessageCache.StageListCache;
		if (stageListCache == null)
		{
			return 0;
		}
		int result = 0;
		foreach (ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage in stageListCache)
		{
			TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(towerDefenseParsedStageMessage.Id);
			if (towerDefenseConfigById != null && towerDefenseConfigById.Value.BossRush)
			{
				result = towerDefenseParsedStageMessage.Id;
			}
		}
		return result;
	}

	// Token: 0x060173D4 RID: 95188 RVA: 0x005E5B24 File Offset: 0x005E3D24
	public int GetDefaultSelectStageId()
	{
		List<ITowerDefenseParsedStageMessage> stageListCache = TowerDefenseModel.Instance.PhantomMessageCache.StageListCache;
		if (stageListCache == null)
		{
			return 0;
		}
		foreach (ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage in stageListCache)
		{
			TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(towerDefenseParsedStageMessage.Id);
			if (towerDefenseConfigById != null && !towerDefenseConfigById.Value.BossRush && this.CheckStageUnlockById(towerDefenseParsedStageMessage.Id) && !this.CheckStagePassedById(towerDefenseParsedStageMessage.Id))
			{
				return towerDefenseParsedStageMessage.Id;
			}
		}
		int lastBossRushStageId = this.GetLastBossRushStageId();
		if (lastBossRushStageId > 0 && this.CheckStageUnlockById(lastBossRushStageId))
		{
			return lastBossRushStageId;
		}
		int latestUnlockedGroupId = this.GetLatestUnlockedGroupId();
		if (latestUnlockedGroupId <= 0)
		{
			return 0;
		}
		int sameGroupHardStageId = this.GetSameGroupHardStageId(latestUnlockedGroupId);
		if (sameGroupHardStageId <= 0)
		{
			return this.GetSameGroupNormalStageId(latestUnlockedGroupId);
		}
		return sameGroupHardStageId;
	}

	// Token: 0x060173D5 RID: 95189 RVA: 0x005E5C14 File Offset: 0x005E3E14
	[NullableContext(2)]
	public ITowerDefenseLockedHint BuildStageLockedHintById(int id)
	{
		TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(id);
		if (towerDefenseConfigById == null)
		{
			return null;
		}
		if (towerDefenseConfigById.Value.BossRush)
		{
			return new TowerDefenseLockedHint
			{
				TextId = "TowerDefence_Lcok_TipsText"
			};
		}
		if (this.IsStageTimeReachedById(id))
		{
			return new TowerDefenseLockedHint
			{
				TextId = "OnlineGymnasium_LevelRst"
			};
		}
		string text = this.BuildInstanceCountDownTextParam(towerDefenseConfigById.Value.InstanceId);
		if (!string.IsNullOrEmpty(text))
		{
			return new TowerDefenseLockedHint
			{
				TextId = "ActivityMowing_UnlockCondition",
				Args = new string[]
				{
					text
				}
			};
		}
		return null;
	}

	// Token: 0x060173D6 RID: 95190 RVA: 0x005E5CB8 File Offset: 0x005E3EB8
	public bool CheckStagePassedById(int id)
	{
		ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage;
		return TowerDefenseModel.Instance.PhantomMessageCache.StageMapCache.TryGetValue(id, out towerDefenseParsedStageMessage) && towerDefenseParsedStageMessage.Passed;
	}

	// Token: 0x060173D7 RID: 95191 RVA: 0x005E5CE8 File Offset: 0x005E3EE8
	public int GetRecordByStageId(int id)
	{
		ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage;
		if (!TowerDefenseModel.Instance.PhantomMessageCache.StageMapCache.TryGetValue(id, out towerDefenseParsedStageMessage))
		{
			return 0;
		}
		return towerDefenseParsedStageMessage.Record;
	}

	// Token: 0x060173D8 RID: 95192 RVA: 0x005E5D18 File Offset: 0x005E3F18
	public int GetRecordByInstanceId(int instanceId)
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceByInstanceId.GetConfig(instanceId, true);
		if (config == null)
		{
			return 0;
		}
		ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage;
		if (instance.PhantomMessageCache.StageMapCache.TryGetValue(config.Value.Id, out towerDefenseParsedStageMessage))
		{
			return towerDefenseParsedStageMessage.Record;
		}
		return 0;
	}

	// Token: 0x060173D9 RID: 95193 RVA: 0x005E5D6C File Offset: 0x005E3F6C
	public string GetPassTimeContentByInstanceId(int instanceId)
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceByInstanceId.GetConfig(instanceId, true);
		double second = 0.0;
		ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage;
		if (config != null && instance.PhantomMessageCache.StageMapCache.TryGetValue(config.Value.Id, out towerDefenseParsedStageMessage))
		{
			second = (towerDefenseParsedStageMessage.Passed ? towerDefenseParsedStageMessage.PassTime : 0.0);
		}
		return TimeUtil.Instance.GetTimeString(second);
	}

	// Token: 0x060173DA RID: 95194 RVA: 0x005E5DE4 File Offset: 0x005E3FE4
	public int GetTotalScoreLimitByInstanceId(int instanceId)
	{
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceByInstanceId.GetConfig(instanceId, true);
		if (config == null)
		{
			return 0;
		}
		return config.Value.UnlockScoreLimit;
	}

	// Token: 0x060173DB RID: 95195 RVA: 0x005E5E14 File Offset: 0x005E4014
	public int GetCurrentScoreLimit()
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		int num = 0;
		foreach (int num2 in instance.PhantomMessageCache.StageMapCache.Keys)
		{
			TowerDefenceInstance? config = ConfigTowerDefenceInstanceById.GetConfig(num2, true);
			if (config != null && instance.PhantomMessageCache.IsStageUnlockedByTowerDefenseInstanceId(num2))
			{
				num = ((config.Value.UnlockScoreLimit > num) ? config.Value.UnlockScoreLimit : num);
			}
		}
		return num;
	}

	// Token: 0x060173DC RID: 95196 RVA: 0x005E5EBC File Offset: 0x005E40BC
	public int GetMarkIdByActivityId(int activityId)
	{
		TowerDefenceMapMark? config = ConfigTowerDefenceMapMarkByActivityId.GetConfig(activityId, true);
		if (config == null)
		{
			return 0;
		}
		return config.Value.MarkId;
	}

	// Token: 0x060173DD RID: 95197 RVA: 0x005E5EEB File Offset: 0x005E40EB
	public int GetSuitableInstanceId()
	{
		return TowerDefenseModel.Instance.PhantomMessageCache.GetSuitableInstanceId();
	}

	// Token: 0x060173DE RID: 95198 RVA: 0x005E5EFC File Offset: 0x005E40FC
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] GetPhantomSkillDescriptionArgsByPhantomId(int id)
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		if (!instance.CheckCurrentActivityShowDifferent())
		{
			return null;
		}
		int skillId = ConfigPhantomItemByItemId.GetConfig(instance.PhantomConfigCache[id].PhantomItemId, true).Value.SkillId;
		return PhantomBattleConfig.Instance.GetPhantomSkillDescExByPhantomSkillIdAndQuality(skillId, 5);
	}

	// Token: 0x060173DF RID: 95199 RVA: 0x005E5F4D File Offset: 0x005E414D
	public bool CheckActivityUnlockByCondition()
	{
		return TowerDefenseModel.Instance.GetOrCreateParsedTowerDefenseMsg().IsUnLock();
	}

	// Token: 0x060173E0 RID: 95200 RVA: 0x005E5F60 File Offset: 0x005E4160
	public bool CheckInInstanceDungeon()
	{
		if (GameModeController.Instance.IsInInstance())
		{
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.GetValueOrDefault().InstSubType == 21;
		}
		return false;
	}

	// Token: 0x060173E1 RID: 95201 RVA: 0x005E5FB0 File Offset: 0x005E41B0
	public bool CheckInBossRushInstance()
	{
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceByInstanceId.GetConfig(CreatureModel.Instance.GetInstanceId(), true);
		return config != null && config.GetValueOrDefault().BossRush;
	}

	// Token: 0x060173E2 RID: 95202 RVA: 0x005E5FE8 File Offset: 0x005E41E8
	public bool CheckIsInstanceUnlock(int instanceId)
	{
		return TowerDefenseModel.Instance.PhantomMessageCache.IsStageUnLocked(instanceId);
	}

	// Token: 0x060173E3 RID: 95203 RVA: 0x005E5FFC File Offset: 0x005E41FC
	public bool CheckIsInstanceSingle()
	{
		if (GameModeController.Instance.IsInInstance())
		{
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.GetValueOrDefault().OnlineType == InstOnlineType.Single;
		}
		return false;
	}

	// Token: 0x060173E4 RID: 95204 RVA: 0x005E604B File Offset: 0x005E424B
	public bool CheckHasReward()
	{
		return TowerDefenseModel.Instance.CheckHasReward();
	}

	// Token: 0x060173E5 RID: 95205 RVA: 0x005E6057 File Offset: 0x005E4257
	public bool CheckHasNewStage()
	{
		return TowerDefenseModel.Instance.HasNotClickNewLevel();
	}

	// Token: 0x060173E6 RID: 95206 RVA: 0x005E6064 File Offset: 0x005E4264
	public bool CheckIsSelf(int playerId)
	{
		int? id = PlayerInfoModel.Instance.GetId();
		return id.GetValueOrDefault() == playerId & id != null;
	}

	// Token: 0x060173E7 RID: 95207 RVA: 0x005E6090 File Offset: 0x005E4290
	public bool CheckActivityUnlockByMulti()
	{
		if (GameModeModel.Instance.IsMulti)
		{
			int? id = PlayerInfoModel.Instance.GetId();
			int ownerId = OnlineModel.Instance.OwnerId;
			return id.GetValueOrDefault() == ownerId & id != null;
		}
		return true;
	}

	// Token: 0x060173E8 RID: 95208 RVA: 0x005E60D9 File Offset: 0x005E42D9
	public bool CheckInUiFlow()
	{
		return TowerDefenseModel.Instance.IsUiFlowOpen;
	}

	// Token: 0x060173E9 RID: 95209 RVA: 0x005E60E5 File Offset: 0x005E42E5
	public bool CheckIsSelfEntrance(int entranceId)
	{
		return TowerDefenceDefine.entranceSet.Contains(entranceId);
	}

	// Token: 0x060173EA RID: 95210 RVA: 0x005E60F2 File Offset: 0x005E42F2
	public bool CheckIsPhantomViewOpened()
	{
		return TowerDefenseModel.Instance.IsPhantomViewOpened;
	}

	// Token: 0x060173EB RID: 95211 RVA: 0x005E6100 File Offset: 0x005E4300
	public bool CheckAllPhantomsReady()
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		int? id = PlayerInfoModel.Instance.GetId();
		foreach (ITowerDefensePhantomDataOwner towerDefensePhantomDataOwner in instance.PhantomOwnerDataList)
		{
			int? num = id;
			long? num2 = (num != null) ? new long?((long)num.GetValueOrDefault()) : null;
			long playerId = towerDefensePhantomDataOwner.PlayerId;
			if ((num2.GetValueOrDefault() == playerId & num2 != null) && towerDefensePhantomDataOwner.RoleCfgId > 0 && towerDefensePhantomDataOwner.PhantomId <= 0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060173EC RID: 95212 RVA: 0x005E61BC File Offset: 0x005E43BC
	public bool CheckHasSurvivalPhantom()
	{
		return TowerDefenseModel.Instance.CheckHasSurvivalPhantom();
	}

	// Token: 0x060173ED RID: 95213 RVA: 0x005E61C8 File Offset: 0x005E43C8
	public bool CheckSelectStageIsBossRush()
	{
		InstanceDungeonEntranceModel instance = InstanceDungeonEntranceModel.Instance;
		TowerDefenceInstance? towerDefenceInstance;
		return ConfigTowerDefenceInstanceByInstanceId.GetConfig(this.CheckIsInMatch() ? instance.GetMatchingId() : instance.SelectInstanceId, true) != null && towerDefenceInstance.GetValueOrDefault().BossRush;
	}

	// Token: 0x060173EE RID: 95214 RVA: 0x005E6212 File Offset: 0x005E4412
	public bool CheckNeedSurvivalWarning()
	{
		return this.CheckSelectStageIsBossRush() && !this.CheckHasSurvivalPhantom();
	}

	// Token: 0x060173EF RID: 95215 RVA: 0x005E6228 File Offset: 0x005E4428
	public bool CheckIsTowerEntity(ITrackData trackData)
	{
		if (!this.CheckInInstanceDungeon())
		{
			return false;
		}
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceByInstanceId.GetConfig(CreatureModel.Instance.GetInstanceId(), true);
		if (config != null)
		{
			TTrackTarget_Int ttrackTarget_Int = trackData.TrackTarget as TTrackTarget_Int;
			return ttrackTarget_Int != null && config.Value.BaseEntityId == ttrackTarget_Int.Value;
		}
		return false;
	}

	// Token: 0x060173F0 RID: 95216 RVA: 0x005E6283 File Offset: 0x005E4483
	private bool CheckIsInMatch()
	{
		return InstanceDungeonEntranceModel.Instance.GetMatchingState() > EInstanceMatchState.Default;
	}

	// Token: 0x060173F1 RID: 95217 RVA: 0x005E6294 File Offset: 0x005E4494
	public bool CheckIsChallengeInstanceByInstanceId(int id)
	{
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceByInstanceId.GetConfig(id, true);
		return config != null && config.Value.IsDifficult;
	}

	// Token: 0x060173F2 RID: 95218 RVA: 0x005E62C4 File Offset: 0x005E44C4
	public bool CheckInstancePassedByInstanceId(int id)
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceByInstanceId.GetConfig(id, true);
		ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage;
		return config != null && instance.PhantomMessageCache.StageMapCache.TryGetValue(config.Value.Id, out towerDefenseParsedStageMessage) && towerDefenseParsedStageMessage.Passed;
	}

	// Token: 0x060173F3 RID: 95219 RVA: 0x005E6315 File Offset: 0x005E4515
	public bool CheckCurrentPhantomIsOccupiedInUi()
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		return instance.CheckPhantomIsOccupied(instance.CurrentSelfPhantomIdInUiTemp);
	}

	// Token: 0x060173F4 RID: 95220 RVA: 0x005E6327 File Offset: 0x005E4527
	public void SetIsUiFlowOpen(bool value)
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		instance.IsUiFlowOpen = value;
		instance.IsPhantomViewOpened = false;
	}

	// Token: 0x060173F5 RID: 95221 RVA: 0x005E633B File Offset: 0x005E453B
	public void SetPhantomViewOpened(bool value)
	{
		TowerDefenseModel.Instance.IsPhantomViewOpened = value;
	}

	// Token: 0x17001F5E RID: 8030
	// (get) Token: 0x060173F6 RID: 95222 RVA: 0x005E6348 File Offset: 0x005E4548
	public static TowerDefenseController Instance
	{
		get
		{
			return TowerDefenseController._Instance;
		}
	}

	// Token: 0x060173F7 RID: 95223 RVA: 0x005E634F File Offset: 0x005E454F
	public static TowerDefenseController GetOrCreateInstance()
	{
		if (TowerDefenseController._Instance == null)
		{
			TowerDefenseController.CreateInstance();
		}
		return TowerDefenseController._Instance;
	}

	// Token: 0x060173F8 RID: 95224 RVA: 0x005E6363 File Offset: 0x005E4563
	public static bool CreateInstance()
	{
		if (TowerDefenseController._Instance != null)
		{
			return true;
		}
		TowerDefenseController._Instance = new TowerDefenseController();
		return true;
	}

	// Token: 0x060173F9 RID: 95225 RVA: 0x005E6379 File Offset: 0x005E4579
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060173FA RID: 95226 RVA: 0x005E637B File Offset: 0x005E457B
	public static void ResetStaticDefaultValue()
	{
		TowerDefenseController._Instance = null;
	}

	// Token: 0x060173FB RID: 95227 RVA: 0x005E6383 File Offset: 0x005E4583
	static TowerDefenseController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TowerDefenseController.CreateStaticDefaultValue), new Action(TowerDefenseController.ResetStaticDefaultValue));
	}

	// Token: 0x0400ADE2 RID: 44514
	[Nullable(2)]
	private static TowerDefenseController _Instance;
}

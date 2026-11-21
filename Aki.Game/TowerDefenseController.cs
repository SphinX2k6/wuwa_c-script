using System;
using System.Collections.Generic;
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

// Token: 0x0200213A RID: 8506
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class TowerDefenseController : ActivityControllerBase
{
	// Token: 0x06014D9E RID: 85406 RVA: 0x0060F9AA File Offset: 0x0060DBAA
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return TowerDefenseModel.Instance.GetOrCreateParsedTowerDefenseMsg();
	}

	// Token: 0x06014D9F RID: 85407 RVA: 0x0060F9B6 File Offset: 0x0060DBB6
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new TowerDefenseSubView();
	}

	// Token: 0x06014DA0 RID: 85408 RVA: 0x0060F9BD File Offset: 0x0060DBBD
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_LordGymMainA";
	}

	// Token: 0x06014DA1 RID: 85409 RVA: 0x0060F9C4 File Offset: 0x0060DBC4
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return UiManager.Instance.IsViewOpen(EUiViewName.TowerDefenseLevelView);
	}

	// Token: 0x06014DA2 RID: 85410 RVA: 0x0060F9D8 File Offset: 0x0060DBD8
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

	// Token: 0x06014DA3 RID: 85411 RVA: 0x0060FA8C File Offset: 0x0060DC8C
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

	// Token: 0x06014DA4 RID: 85412 RVA: 0x0060FAD0 File Offset: 0x0060DCD0
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

	// Token: 0x06014DA5 RID: 85413 RVA: 0x0060FC2C File Offset: 0x0060DE2C
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

	// Token: 0x06014DA6 RID: 85414 RVA: 0x0060FD88 File Offset: 0x0060DF88
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

	// Token: 0x06014DA7 RID: 85415 RVA: 0x0060FE5C File Offset: 0x0060E05C
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

	// Token: 0x06014DA8 RID: 85416 RVA: 0x0060FED9 File Offset: 0x0060E0D9
	public override bool GetActivityLevelUnlockState(int levelId)
	{
		return this.CheckIsInstanceUnlock(levelId);
	}

	// Token: 0x06014DA9 RID: 85417 RVA: 0x0060FEE2 File Offset: 0x0060E0E2
	public TowerDefencePhantomIconItem BuildPhantomIconItem()
	{
		return new TowerDefencePhantomIconItem();
	}

	// Token: 0x06014DAA RID: 85418 RVA: 0x0060FEE9 File Offset: 0x0060E0E9
	public TowerDefensePhantomSkillItem BuildPhantomSkillItem()
	{
		return new TowerDefensePhantomSkillItem();
	}

	// Token: 0x06014DAB RID: 85419 RVA: 0x0060FEF0 File Offset: 0x0060E0F0
	public TowerDefenseInBattleInfoItem BuildPhantomSkillInBattleItem()
	{
		return new TowerDefenseInBattleInfoItem();
	}

	// Token: 0x06014DAC RID: 85420 RVA: 0x0060FEF8 File Offset: 0x0060E0F8
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
				bool flag = config2 == null || Array.IndexOf<int>(config2.Value.OptionalBuff(), towerDefensePhantomConfig.Id) < 0;
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

	// Token: 0x06014DAD RID: 85421 RVA: 0x006102BC File Offset: 0x0060E4BC
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

	// Token: 0x06014DAE RID: 85422 RVA: 0x006103C4 File Offset: 0x0060E5C4
	public bool CheckSelfPhantomCancelAble(int roleCfgId)
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		int value = PlayerInfoModel.Instance.GetId().Value;
		ITowerDefensePhantomDataOwner ownerData = instance.GetOwnerData(value, roleCfgId);
		return ownerData != null && ownerData.PhantomId != 0 && instance.CurrentSelfPhantomIdInUiTemp == ownerData.PhantomId;
	}

	// Token: 0x06014DAF RID: 85423 RVA: 0x00610410 File Offset: 0x0060E610
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
				DescriptionArgs = new List<string>(PhantomBattleConfig.Instance.GetPhantomSkillDescExByPhantomSkillIdAndQuality(towerDefensePhantomConfigSkillData.PhantomSkill, 5)),
				Level = (i + 1).ToString()
			});
		}
		return list;
	}

	// Token: 0x06014DB0 RID: 85424 RVA: 0x006104B4 File Offset: 0x0060E6B4
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
			IsLocked = (config == null || Array.IndexOf<int>(config.Value.OptionalBuff(), instance.CurrentSelfPhantomIdInUiTemp) < 0)
		};
	}

	// Token: 0x06014DB1 RID: 85425 RVA: 0x0061055C File Offset: 0x0060E75C
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

	// Token: 0x06014DB2 RID: 85426 RVA: 0x006105BC File Offset: 0x0060E7BC
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
					DescriptionArgs = new List<string>(PhantomBattleConfig.Instance.GetPhantomSkillDescExByPhantomSkillIdAndQuality(towerDefensePhantomConfigSkillData.PhantomSkill, 5)),
					IsUnlock = (currentPhantomLevelInBattle > i),
					IsCurrent = (i == num)
				});
			}
		}
		return list;
	}

	// Token: 0x06014DB3 RID: 85427 RVA: 0x00610688 File Offset: 0x0060E888
	public int GetCurrentPhantomItemIdInBattle()
	{
		TowerDefencePhantom? config = ConfigTowerDefencePhantomById.GetConfig(TowerDefenseModel.Instance.GetCurrentPhantomIdInBattle(), true);
		if (config == null)
		{
			return 0;
		}
		return config.GetValueOrDefault().PhantomItemId;
	}

	// Token: 0x06014DB4 RID: 85428 RVA: 0x006106C0 File Offset: 0x0060E8C0
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

	// Token: 0x06014DB5 RID: 85429 RVA: 0x00610728 File Offset: 0x0060E928
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

	// Token: 0x06014DB6 RID: 85430 RVA: 0x00610762 File Offset: 0x0060E962
	public string BuildCurrentPhantomNameTextIdInBattle()
	{
		return TowerDefenseModel.Instance.GetCurrentPhantomNameTextId();
	}

	// Token: 0x06014DB7 RID: 85431 RVA: 0x0061076E File Offset: 0x0060E96E
	public IActivityRewardViewData BuildPreviewRewardData()
	{
		return TowerDefenseModel.Instance.GetPreviewRewardData();
	}

	// Token: 0x06014DB8 RID: 85432 RVA: 0x0061077C File Offset: 0x0060E97C
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

	// Token: 0x06014DB9 RID: 85433 RVA: 0x006107FC File Offset: 0x0060E9FC
	public TowerDefenseRecommendLevel BuildRecommendLevelForInstanceDungeonEntranceData(int instanceId)
	{
		InstanceDungeon? instanceDungeon;
		return new TowerDefenseRecommendLevel
		{
			TextId = "RecommendLevel",
			Level = ((ConfigInstanceDungeonById.GetConfig(instanceId, true) != null) ? instanceDungeon.GetValueOrDefault().RecommendLevel().GetValueOrDefault(1, 0) : 0)
		};
	}

	// Token: 0x06014DBA RID: 85434 RVA: 0x0061084C File Offset: 0x0060EA4C
	public string BuildTotalScoreContent()
	{
		int totalScore = TowerDefenseModel.Instance.PhantomMessageCache.TotalScore;
		return totalScore.ToString();
	}

	// Token: 0x06014DBB RID: 85435 RVA: 0x00610870 File Offset: 0x0060EA70
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

	// Token: 0x06014DBC RID: 85436 RVA: 0x006108D8 File Offset: 0x0060EAD8
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

	// Token: 0x06014DBD RID: 85437 RVA: 0x0061094C File Offset: 0x0060EB4C
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

	// Token: 0x06014DBE RID: 85438 RVA: 0x00610A10 File Offset: 0x0060EC10
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

	// Token: 0x06014DBF RID: 85439 RVA: 0x00610AA4 File Offset: 0x0060ECA4
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

	// Token: 0x06014DC0 RID: 85440 RVA: 0x00610C28 File Offset: 0x0060EE28
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

	// Token: 0x06014DC1 RID: 85441 RVA: 0x00610C5C File Offset: 0x0060EE5C
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

	// Token: 0x06014DC2 RID: 85442 RVA: 0x00610CA8 File Offset: 0x0060EEA8
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

	// Token: 0x06014DC3 RID: 85443 RVA: 0x00610D00 File Offset: 0x0060EF00
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

	// Token: 0x06014DC4 RID: 85444 RVA: 0x00610E70 File Offset: 0x0060F070
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

	// Token: 0x06014DC5 RID: 85445 RVA: 0x00610F20 File Offset: 0x0060F120
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

	// Token: 0x06014DC6 RID: 85446 RVA: 0x00610F74 File Offset: 0x0060F174
	[NullableContext(0)]
	public UniTask<bool> EnterTowerDefense()
	{
		TowerDefenseController.<EnterTowerDefense>d__40 <EnterTowerDefense>d__;
		<EnterTowerDefense>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<EnterTowerDefense>d__.<>1__state = -1;
		<EnterTowerDefense>d__.<>t__builder.Start<TowerDefenseController.<EnterTowerDefense>d__40>(ref <EnterTowerDefense>d__);
		return <EnterTowerDefense>d__.<>t__builder.Task;
	}

	// Token: 0x06014DC7 RID: 85447 RVA: 0x00610FB0 File Offset: 0x0060F1B0
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

	// Token: 0x06014DC8 RID: 85448 RVA: 0x00611054 File Offset: 0x0060F254
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

	// Token: 0x06014DC9 RID: 85449 RVA: 0x006110F8 File Offset: 0x0060F2F8
	public UniTask RequestSelfRankData(int activityId)
	{
		TowerDefenseController.<RequestSelfRankData>d__43 <RequestSelfRankData>d__;
		<RequestSelfRankData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestSelfRankData>d__.activityId = activityId;
		<RequestSelfRankData>d__.<>1__state = -1;
		<RequestSelfRankData>d__.<>t__builder.Start<TowerDefenseController.<RequestSelfRankData>d__43>(ref <RequestSelfRankData>d__);
		return <RequestSelfRankData>d__.<>t__builder.Task;
	}

	// Token: 0x06014DCA RID: 85450 RVA: 0x0061113C File Offset: 0x0060F33C
	public UniTask RequestRankList(int levelId)
	{
		TowerDefenseController.<RequestRankList>d__44 <RequestRankList>d__;
		<RequestRankList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRankList>d__.levelId = levelId;
		<RequestRankList>d__.<>1__state = -1;
		<RequestRankList>d__.<>t__builder.Start<TowerDefenseController.<RequestRankList>d__44>(ref <RequestRankList>d__);
		return <RequestRankList>d__.<>t__builder.Task;
	}

	// Token: 0x06014DCB RID: 85451 RVA: 0x00611180 File Offset: 0x0060F380
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(towerDefenceRankShowNameResponse.ErrorCode, 29510, null, true, true);
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

	// Token: 0x06014DCC RID: 85452 RVA: 0x006111C4 File Offset: 0x0060F3C4
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

	// Token: 0x06014DCD RID: 85453 RVA: 0x00611224 File Offset: 0x0060F424
	[NullableContext(2)]
	private void OnInstanceInfoUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		TowerDefenceInstanceInfoUpdateNotify towerDefenceInstanceInfoUpdateNotify = (TowerDefenceInstanceInfoUpdateNotify)msg;
		TowerDefenseModel.Instance.PhantomMessageCache.ParseTowerDefenseInstanceDataList(towerDefenceInstanceInfoUpdateNotify.InstanceInfos, false);
		EventSystem.Instance.Emit(EEventName.TowerDefenseOnInstanceInfoUpdateNotify);
	}

	// Token: 0x06014DCE RID: 85454 RVA: 0x00611260 File Offset: 0x0060F460
	[NullableContext(2)]
	private void OnPhantomInfoUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		TowerDefencePhantomInfoUpdateNotify towerDefencePhantomInfoUpdateNotify = (TowerDefencePhantomInfoUpdateNotify)msg;
		TowerDefenseModel.Instance.PhantomMessageCache.ParseTowerDefenseOwnPhantomDataList(towerDefencePhantomInfoUpdateNotify.Phantoms);
		EventSystem.Instance.Emit(EEventName.TowerDefenseOnPhantomInfoUpdateNotify);
		this.OpenInBattleTipImplement();
	}

	// Token: 0x06014DCF RID: 85455 RVA: 0x006112A0 File Offset: 0x0060F4A0
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

	// Token: 0x06014DD0 RID: 85456 RVA: 0x006112D4 File Offset: 0x0060F4D4
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

	// Token: 0x06014DD1 RID: 85457 RVA: 0x0061136C File Offset: 0x0060F56C
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

	// Token: 0x06014DD2 RID: 85458 RVA: 0x0061148C File Offset: 0x0060F68C
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

	// Token: 0x06014DD3 RID: 85459 RVA: 0x006116BC File Offset: 0x0060F8BC
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

	// Token: 0x06014DD4 RID: 85460 RVA: 0x006116F6 File Offset: 0x0060F8F6
	private void HandleBeforeConfirmQuickRoleSelect()
	{
		if (!this.CheckInUiFlow())
		{
			return;
		}
		this.SyncEditBattleTeamModelToOwnerData();
		EventSystem.Instance.Emit(EEventName.TowerDefensePhantomChanged);
	}

	// Token: 0x06014DD5 RID: 85461 RVA: 0x00611717 File Offset: 0x0060F917
	private void HandleOnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
	}

	// Token: 0x06014DD6 RID: 85462 RVA: 0x00611719 File Offset: 0x0060F919
	private void HandleEnterInstanceDungeon()
	{
		if (this.CheckInInstanceDungeon())
		{
			EventSystem.Instance.Emit<bool>(EEventName.TowerDefenseShowInBattleView, true);
		}
	}

	// Token: 0x06014DD7 RID: 85463 RVA: 0x00611734 File Offset: 0x0060F934
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

	// Token: 0x06014DD8 RID: 85464 RVA: 0x0061177A File Offset: 0x0060F97A
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

	// Token: 0x06014DD9 RID: 85465 RVA: 0x006117B4 File Offset: 0x0060F9B4
	private void RewardViewLeftClickCallback(int buttonIndex)
	{
		this.RequestChallengeQuit();
	}

	// Token: 0x06014DDA RID: 85466 RVA: 0x006117BC File Offset: 0x0060F9BC
	private void RewardViewRightClickCallback(int buttonIndex)
	{
		this.HandleSettleViewRestart(buttonIndex);
	}

	// Token: 0x06014DDB RID: 85467 RVA: 0x006117C8 File Offset: 0x0060F9C8
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

	// Token: 0x06014DDC RID: 85468 RVA: 0x00611838 File Offset: 0x0060FA38
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(towerDefenceChallengeQuitResponse.ErrorCode, 16362, null, true, true);
				return;
			}
			this.HandleSettleViewExit();
		});
	}

	// Token: 0x06014DDD RID: 85469 RVA: 0x00611870 File Offset: 0x0060FA70
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
		InstanceDungeonEntranceController.Instance.RestartInstanceDungeon(false).ContinueWith(delegate(bool task)
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.ExploreRewardView))
			{
				UiManager.Instance.CloseView(EUiViewName.ExploreRewardView, null);
			}
		});
	}

	// Token: 0x06014DDE RID: 85470 RVA: 0x006118EB File Offset: 0x0060FAEB
	private void HandleBattleScoreChanged(int scoreId, int scoreValue)
	{
		this.CheckInInstanceDungeon();
	}

	// Token: 0x06014DDF RID: 85471 RVA: 0x006118F4 File Offset: 0x0060FAF4
	private void HandleOnBeforeDestroyInstanceDungeonEntranceView()
	{
		this.CheckInUiFlow();
		this.SetIsUiFlowOpen(false);
	}

	// Token: 0x06014DE0 RID: 85472 RVA: 0x00611904 File Offset: 0x0060FB04
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

	// Token: 0x06014DE1 RID: 85473 RVA: 0x00611953 File Offset: 0x0060FB53
	private void HandleTowerDefenseSelfPhantomConfirm(int roleCfgId)
	{
		this.SyncSelfTowerDefensePhantomId(roleCfgId);
		this.ResetCurrentTowerDefensePhantomIdInUiTemp();
	}

	// Token: 0x06014DE2 RID: 85474 RVA: 0x00611964 File Offset: 0x0060FB64
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

	// Token: 0x06014DE3 RID: 85475 RVA: 0x006119A4 File Offset: 0x0060FBA4
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

	// Token: 0x06014DE4 RID: 85476 RVA: 0x00611A08 File Offset: 0x0060FC08
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

	// Token: 0x06014DE5 RID: 85477 RVA: 0x00611A69 File Offset: 0x0060FC69
	private void OnSelectInstanceIdChallenge(int instanceId)
	{
		TowerDefenseModel.Instance.SetLevelHasClickByInstanceId(instanceId);
	}

	// Token: 0x06014DE6 RID: 85478 RVA: 0x00611A76 File Offset: 0x0060FC76
	public void SetCurrentTowerDefensePhantomIdInUiTemp(int id)
	{
		TowerDefenseModel.Instance.CurrentSelfPhantomIdInUiTemp = id;
	}

	// Token: 0x06014DE7 RID: 85479 RVA: 0x00611A83 File Offset: 0x0060FC83
	public void ResetCurrentTowerDefensePhantomIdInUiTemp()
	{
		TowerDefenseModel.Instance.ResetCurrentPhantomIdInUiTempToFirstAvailable();
	}

	// Token: 0x06014DE8 RID: 85480 RVA: 0x00611A8F File Offset: 0x0060FC8F
	public void ToggleInBattleView()
	{
		EventSystem.Instance.Emit(EEventName.BattleUiToggleTowerDefenseInfoView);
	}

	// Token: 0x06014DE9 RID: 85481 RVA: 0x00611AA4 File Offset: 0x0060FCA4
	public void ResetCurrentPhantomLevelUpFlag(int level)
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		int currentPhantomIdInBattle = instance.GetCurrentPhantomIdInBattle();
		int currentPhantomLevelInBattle = instance.GetCurrentPhantomLevelInBattle();
		instance.PhantomMessageCache.OwnPhantomInBattleNewLevelUpFlagCache[currentPhantomIdInBattle] = (currentPhantomLevelInBattle > level);
	}

	// Token: 0x06014DEA RID: 85482 RVA: 0x00611AD8 File Offset: 0x0060FCD8
	public void TryReopenInBattleTip()
	{
		this.OpenInBattleTipImplement();
	}

	// Token: 0x06014DEB RID: 85483 RVA: 0x00611AE0 File Offset: 0x0060FCE0
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

	// Token: 0x06014DEC RID: 85484 RVA: 0x00611B38 File Offset: 0x0060FD38
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

	// Token: 0x06014DED RID: 85485 RVA: 0x00611C14 File Offset: 0x0060FE14
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

	// Token: 0x06014DEE RID: 85486 RVA: 0x00611C84 File Offset: 0x0060FE84
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

	// Token: 0x06014DEF RID: 85487 RVA: 0x00611E3B File Offset: 0x0061003B
	public void OpenTowerDefenseSettleView(TowerDefenceEndNotify notify)
	{
		UiManager.Instance.OpenView(EUiViewName.TowerDefenseSettleView, notify, null);
	}

	// Token: 0x06014DF0 RID: 85488 RVA: 0x00611E50 File Offset: 0x00610050
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

	// Token: 0x06014DF1 RID: 85489 RVA: 0x006120F8 File Offset: 0x006102F8
	public int GetLevelInBattle()
	{
		return TowerDefenseModel.Instance.GetCurrentPhantomLevelInBattle();
	}

	// Token: 0x06014DF2 RID: 85490 RVA: 0x00612104 File Offset: 0x00610304
	public string GetLevelContentInBattle()
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		if (instance.CheckCurrentActivityShowDifferent())
		{
			return ConfigMultiTextLang.GetLocalTextNew("TowerDefencewenhao", null) ?? string.Empty;
		}
		return instance.GetCurrentPhantomLevelInBattle().ToString();
	}

	// Token: 0x06014DF3 RID: 85491 RVA: 0x00612144 File Offset: 0x00610344
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

	// Token: 0x06014DF4 RID: 85492 RVA: 0x00612168 File Offset: 0x00610368
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

	// Token: 0x06014DF5 RID: 85493 RVA: 0x006121BC File Offset: 0x006103BC
	public bool GetIsFirstOpen()
	{
		return TowerDefenseModel.Instance.GetOrCreateParsedTowerDefenseMsg().GetIfFirstOpen();
	}

	// Token: 0x06014DF6 RID: 85494 RVA: 0x006121CD File Offset: 0x006103CD
	public string GetActivitySubViewTitle()
	{
		return TowerDefenseModel.Instance.GetOrCreateParsedTowerDefenseMsg().GetTitle();
	}

	// Token: 0x06014DF7 RID: 85495 RVA: 0x006121DE File Offset: 0x006103DE
	public Activity GetActivityCfg()
	{
		return TowerDefenseModel.Instance.GetOrCreateParsedTowerDefenseMsg().LocalConfig.Value;
	}

	// Token: 0x06014DF8 RID: 85496 RVA: 0x006121F4 File Offset: 0x006103F4
	public List<TItem> GetActivityPreviewReward()
	{
		return TowerDefenseModel.Instance.GetOrCreateParsedTowerDefenseMsg().GetPreviewReward(null);
	}

	// Token: 0x06014DF9 RID: 85497 RVA: 0x0061221C File Offset: 0x0061041C
	public EUiViewName? TryGetReviveViewName()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.ExploreRewardView))
		{
			return null;
		}
		return new EUiViewName?(EUiViewName.TowerDefenceReviveView);
	}

	// Token: 0x06014DFA RID: 85498 RVA: 0x0061224E File Offset: 0x0061044E
	public SceneTeamItem GetCurrentSceneTeamItem()
	{
		return SceneTeamModel.Instance.GetCurrentTeamItem;
	}

	// Token: 0x06014DFB RID: 85499 RVA: 0x0061225A File Offset: 0x0061045A
	public List<SceneTeamItem> GetAllOwnSceneTeamItems()
	{
		return SceneTeamModel.Instance.GetTeamItems(true);
	}

	// Token: 0x06014DFC RID: 85500 RVA: 0x00612267 File Offset: 0x00610467
	public int GetSuitableStageId()
	{
		return TowerDefenseModel.Instance.PhantomMessageCache.GetSuitableStageId();
	}

	// Token: 0x06014DFD RID: 85501 RVA: 0x00612278 File Offset: 0x00610478
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

	// Token: 0x06014DFE RID: 85502 RVA: 0x006122F6 File Offset: 0x006104F6
	public bool IsStageTimeReachedById(int id)
	{
		return TowerDefenseModel.Instance.PhantomMessageCache.IsStageUnlockedByTowerDefenseInstanceId(id);
	}

	// Token: 0x06014DFF RID: 85503 RVA: 0x00612308 File Offset: 0x00610508
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

	// Token: 0x06014E00 RID: 85504 RVA: 0x00612370 File Offset: 0x00610570
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

	// Token: 0x06014E01 RID: 85505 RVA: 0x0061242C File Offset: 0x0061062C
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

	// Token: 0x06014E02 RID: 85506 RVA: 0x006124E0 File Offset: 0x006106E0
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

	// Token: 0x06014E03 RID: 85507 RVA: 0x0061259C File Offset: 0x0061079C
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

	// Token: 0x06014E04 RID: 85508 RVA: 0x0061265C File Offset: 0x0061085C
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

	// Token: 0x06014E05 RID: 85509 RVA: 0x006126F0 File Offset: 0x006108F0
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

	// Token: 0x06014E06 RID: 85510 RVA: 0x006127E0 File Offset: 0x006109E0
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

	// Token: 0x06014E07 RID: 85511 RVA: 0x00612884 File Offset: 0x00610A84
	public bool CheckStagePassedById(int id)
	{
		ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage;
		return TowerDefenseModel.Instance.PhantomMessageCache.StageMapCache.TryGetValue(id, out towerDefenseParsedStageMessage) && towerDefenseParsedStageMessage.Passed;
	}

	// Token: 0x06014E08 RID: 85512 RVA: 0x006128B4 File Offset: 0x00610AB4
	public int GetRecordByStageId(int id)
	{
		ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage;
		if (!TowerDefenseModel.Instance.PhantomMessageCache.StageMapCache.TryGetValue(id, out towerDefenseParsedStageMessage))
		{
			return 0;
		}
		return towerDefenseParsedStageMessage.Record;
	}

	// Token: 0x06014E09 RID: 85513 RVA: 0x006128E4 File Offset: 0x00610AE4
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

	// Token: 0x06014E0A RID: 85514 RVA: 0x00612938 File Offset: 0x00610B38
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

	// Token: 0x06014E0B RID: 85515 RVA: 0x006129B0 File Offset: 0x00610BB0
	public int GetTotalScoreLimitByInstanceId(int instanceId)
	{
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceByInstanceId.GetConfig(instanceId, true);
		if (config == null)
		{
			return 0;
		}
		return config.Value.UnlockScoreLimit;
	}

	// Token: 0x06014E0C RID: 85516 RVA: 0x006129E0 File Offset: 0x00610BE0
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

	// Token: 0x06014E0D RID: 85517 RVA: 0x00612A88 File Offset: 0x00610C88
	public int GetMarkIdByActivityId(int activityId)
	{
		TowerDefenceMapMark? config = ConfigTowerDefenceMapMarkByActivityId.GetConfig(activityId, true);
		if (config == null)
		{
			return 0;
		}
		return config.Value.MarkId;
	}

	// Token: 0x06014E0E RID: 85518 RVA: 0x00612AB7 File Offset: 0x00610CB7
	public int GetSuitableInstanceId()
	{
		return TowerDefenseModel.Instance.PhantomMessageCache.GetSuitableInstanceId();
	}

	// Token: 0x06014E0F RID: 85519 RVA: 0x00612AC8 File Offset: 0x00610CC8
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

	// Token: 0x06014E10 RID: 85520 RVA: 0x00612B19 File Offset: 0x00610D19
	public bool CheckActivityUnlockByCondition()
	{
		return TowerDefenseModel.Instance.GetOrCreateParsedTowerDefenseMsg().IsUnLock();
	}

	// Token: 0x06014E11 RID: 85521 RVA: 0x00612B2C File Offset: 0x00610D2C
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

	// Token: 0x06014E12 RID: 85522 RVA: 0x00612B7C File Offset: 0x00610D7C
	public bool CheckInBossRushInstance()
	{
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceByInstanceId.GetConfig(CreatureModel.Instance.GetInstanceId(), true);
		return config != null && config.GetValueOrDefault().BossRush;
	}

	// Token: 0x06014E13 RID: 85523 RVA: 0x00612BB4 File Offset: 0x00610DB4
	public bool CheckIsInstanceUnlock(int instanceId)
	{
		return TowerDefenseModel.Instance.PhantomMessageCache.IsStageUnLocked(instanceId);
	}

	// Token: 0x06014E14 RID: 85524 RVA: 0x00612BC8 File Offset: 0x00610DC8
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

	// Token: 0x06014E15 RID: 85525 RVA: 0x00612C17 File Offset: 0x00610E17
	public bool CheckHasReward()
	{
		return TowerDefenseModel.Instance.CheckHasReward();
	}

	// Token: 0x06014E16 RID: 85526 RVA: 0x00612C23 File Offset: 0x00610E23
	public bool CheckHasNewStage()
	{
		return TowerDefenseModel.Instance.HasNotClickNewLevel();
	}

	// Token: 0x06014E17 RID: 85527 RVA: 0x00612C30 File Offset: 0x00610E30
	public bool CheckIsSelf(int playerId)
	{
		int? id = PlayerInfoModel.Instance.GetId();
		return id.GetValueOrDefault() == playerId & id != null;
	}

	// Token: 0x06014E18 RID: 85528 RVA: 0x00612C5C File Offset: 0x00610E5C
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

	// Token: 0x06014E19 RID: 85529 RVA: 0x00612CA5 File Offset: 0x00610EA5
	public bool CheckInUiFlow()
	{
		return TowerDefenseModel.Instance.IsUiFlowOpen;
	}

	// Token: 0x06014E1A RID: 85530 RVA: 0x00612CB1 File Offset: 0x00610EB1
	public bool CheckIsSelfEntrance(int entranceId)
	{
		return TowerDefenceDefine.entranceSet.Contains(entranceId);
	}

	// Token: 0x06014E1B RID: 85531 RVA: 0x00612CBE File Offset: 0x00610EBE
	public bool CheckIsPhantomViewOpened()
	{
		return TowerDefenseModel.Instance.IsPhantomViewOpened;
	}

	// Token: 0x06014E1C RID: 85532 RVA: 0x00612CCC File Offset: 0x00610ECC
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

	// Token: 0x06014E1D RID: 85533 RVA: 0x00612D88 File Offset: 0x00610F88
	public bool CheckHasSurvivalPhantom()
	{
		return TowerDefenseModel.Instance.CheckHasSurvivalPhantom();
	}

	// Token: 0x06014E1E RID: 85534 RVA: 0x00612D94 File Offset: 0x00610F94
	public bool CheckSelectStageIsBossRush()
	{
		InstanceDungeonEntranceModel instance = InstanceDungeonEntranceModel.Instance;
		TowerDefenceInstance? towerDefenceInstance;
		return ConfigTowerDefenceInstanceByInstanceId.GetConfig(this.CheckIsInMatch() ? instance.GetMatchingId() : instance.SelectInstanceId, true) != null && towerDefenceInstance.GetValueOrDefault().BossRush;
	}

	// Token: 0x06014E1F RID: 85535 RVA: 0x00612DDE File Offset: 0x00610FDE
	public bool CheckNeedSurvivalWarning()
	{
		return this.CheckSelectStageIsBossRush() && !this.CheckHasSurvivalPhantom();
	}

	// Token: 0x06014E20 RID: 85536 RVA: 0x00612DF4 File Offset: 0x00610FF4
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

	// Token: 0x06014E21 RID: 85537 RVA: 0x00612E4F File Offset: 0x0061104F
	private bool CheckIsInMatch()
	{
		return InstanceDungeonEntranceModel.Instance.GetMatchingState() > EInstanceMatchState.Default;
	}

	// Token: 0x06014E22 RID: 85538 RVA: 0x00612E60 File Offset: 0x00611060
	public bool CheckIsChallengeInstanceByInstanceId(int id)
	{
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceByInstanceId.GetConfig(id, true);
		return config != null && config.Value.IsDifficult;
	}

	// Token: 0x06014E23 RID: 85539 RVA: 0x00612E90 File Offset: 0x00611090
	public bool CheckInstancePassedByInstanceId(int id)
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		TowerDefenceInstance? config = ConfigTowerDefenceInstanceByInstanceId.GetConfig(id, true);
		ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage;
		return config != null && instance.PhantomMessageCache.StageMapCache.TryGetValue(config.Value.Id, out towerDefenseParsedStageMessage) && towerDefenseParsedStageMessage.Passed;
	}

	// Token: 0x06014E24 RID: 85540 RVA: 0x00612EE1 File Offset: 0x006110E1
	public bool CheckCurrentPhantomIsOccupiedInUi()
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		return instance.CheckPhantomIsOccupied(instance.CurrentSelfPhantomIdInUiTemp);
	}

	// Token: 0x06014E25 RID: 85541 RVA: 0x00612EF3 File Offset: 0x006110F3
	public void SetIsUiFlowOpen(bool value)
	{
		TowerDefenseModel instance = TowerDefenseModel.Instance;
		instance.IsUiFlowOpen = value;
		instance.IsPhantomViewOpened = false;
	}

	// Token: 0x06014E26 RID: 85542 RVA: 0x00612F07 File Offset: 0x00611107
	public void SetPhantomViewOpened(bool value)
	{
		TowerDefenseModel.Instance.IsPhantomViewOpened = value;
	}

	// Token: 0x17001FB6 RID: 8118
	// (get) Token: 0x06014E27 RID: 85543 RVA: 0x00612F14 File Offset: 0x00611114
	public static TowerDefenseController Instance
	{
		get
		{
			return TowerDefenseController._Instance;
		}
	}

	// Token: 0x06014E28 RID: 85544 RVA: 0x00612F1B File Offset: 0x0061111B
	public static TowerDefenseController GetOrCreateInstance()
	{
		if (TowerDefenseController._Instance == null)
		{
			TowerDefenseController.CreateInstance();
		}
		return TowerDefenseController._Instance;
	}

	// Token: 0x06014E29 RID: 85545 RVA: 0x00612F2F File Offset: 0x0061112F
	public static bool CreateInstance()
	{
		if (TowerDefenseController._Instance != null)
		{
			return true;
		}
		TowerDefenseController._Instance = new TowerDefenseController();
		return true;
	}

	// Token: 0x06014E2A RID: 85546 RVA: 0x00612F45 File Offset: 0x00611145
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014E2B RID: 85547 RVA: 0x00612F47 File Offset: 0x00611147
	public static void ResetStaticDefaultValue()
	{
		TowerDefenseController._Instance = null;
	}

	// Token: 0x06014E2C RID: 85548 RVA: 0x00612F4F File Offset: 0x0061114F
	static TowerDefenseController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TowerDefenseController.CreateStaticDefaultValue), new Action(TowerDefenseController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B1E7 RID: 45543
	[Nullable(2)]
	private static TowerDefenseController _Instance;
}

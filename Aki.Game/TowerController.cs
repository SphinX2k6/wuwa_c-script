using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.TrainingDegree;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x0200214B RID: 8523
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class TowerController : ControllerBase
{
	// Token: 0x06014EDE RID: 85726 RVA: 0x00618695 File Offset: 0x00616895
	protected override bool OnInit()
	{
		this.OnAddEvents();
		this.OnRegisterNetEvent();
		return true;
	}

	// Token: 0x06014EDF RID: 85727 RVA: 0x006186A4 File Offset: 0x006168A4
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		this.OnUnRegisterNetEvent();
		return true;
	}

	// Token: 0x06014EE0 RID: 85728 RVA: 0x006186B3 File Offset: 0x006168B3
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDone));
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
	}

	// Token: 0x06014EE1 RID: 85729 RVA: 0x006186ED File Offset: 0x006168ED
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDone));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
	}

	// Token: 0x06014EE2 RID: 85730 RVA: 0x00618728 File Offset: 0x00616928
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.TowerInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.TowerInfoUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.TowerDifficultyUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.TowerDifficultyUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.TowerFloorUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.TowerFloorUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.TowerEndNotify, new Action<IMessage, Net.CallbackStatus>(this.TowerEndNotify));
	}

	// Token: 0x06014EE3 RID: 85731 RVA: 0x006187A8 File Offset: 0x006169A8
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.TowerInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TowerDifficultyUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TowerFloorUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TowerEndNotify);
	}

	// Token: 0x06014EE4 RID: 85732 RVA: 0x006187F5 File Offset: 0x006169F5
	private void OnFunctionOpenUpdate(EFunctionType functionType, bool isOpen)
	{
		if (functionType != EFunctionType.NewTower)
		{
			return;
		}
		if (!isOpen)
		{
			return;
		}
		this.TowerRequest();
	}

	// Token: 0x06014EE5 RID: 85733 RVA: 0x0061880C File Offset: 0x00616A0C
	private void WorldDone()
	{
		TowerModel.Instance.IsWaitTowerStart = false;
		TowerModel.Instance.IsWaitTowerSettlement = false;
		this.TowerRequest();
		if (TowerModel.Instance.NeedOpenConfirmView)
		{
			TowerConfig? towerInfo = TowerClimbConfig.Instance.GetTowerInfo(TowerModel.Instance.NeedOpenConfirmViewTowerId);
			UiManager.Instance.OpenView(EUiViewName.TowerFloorView, towerInfo.Value.AreaNum, null);
		}
	}

	// Token: 0x06014EE6 RID: 85734 RVA: 0x0061887C File Offset: 0x00616A7C
	[NullableContext(0)]
	public UniTask<bool> RefreshTower(int timeoutMs = 0)
	{
		TowerController.<RefreshTower>d__10 <RefreshTower>d__;
		<RefreshTower>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RefreshTower>d__.timeoutMs = timeoutMs;
		<RefreshTower>d__.<>1__state = -1;
		<RefreshTower>d__.<>t__builder.Start<TowerController.<RefreshTower>d__10>(ref <RefreshTower>d__);
		return <RefreshTower>d__.<>t__builder.Task;
	}

	// Token: 0x06014EE7 RID: 85735 RVA: 0x006188C0 File Offset: 0x00616AC0
	[NullableContext(1)]
	public UniTask TowerStartRequest(int towerConfigId, List<int> formation, bool checkCost = true)
	{
		TowerController.<TowerStartRequest>d__11 <TowerStartRequest>d__;
		<TowerStartRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TowerStartRequest>d__.towerConfigId = towerConfigId;
		<TowerStartRequest>d__.formation = formation;
		<TowerStartRequest>d__.checkCost = checkCost;
		<TowerStartRequest>d__.<>1__state = -1;
		<TowerStartRequest>d__.<>t__builder.Start<TowerController.<TowerStartRequest>d__11>(ref <TowerStartRequest>d__);
		return <TowerStartRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06014EE8 RID: 85736 RVA: 0x00618914 File Offset: 0x00616B14
	public void TowerResetRequest(int towerConfigId)
	{
		TowerResetRequest towerResetRequest = Aki.Protocol.TowerResetRequest.Create();
		towerResetRequest.TowerConfigId = towerConfigId;
		Net.Instance.Call(ERequestMessageId.TowerResetRequest, towerResetRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TowerResetResponse towerResetResponse = (TowerResetResponse)msg;
			if (towerResetResponse != null && towerResetResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				EventSystem.Instance.Emit(EEventName.OnTowerRefresh);
				ScrollingTipsController.Instance.ShowTipsById("ResetConfirm", Array.Empty<object>());
				return;
			}
			if (towerResetResponse != null && towerResetResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrTowerSeasonUpdate)
			{
				TowerController.Instance.OpenSeasonUpdateConfirm();
				return;
			}
			if (towerResetResponse != null)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(towerResetResponse.ErrorCode, 26793, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06014EE9 RID: 85737 RVA: 0x00618960 File Offset: 0x00616B60
	[NullableContext(1)]
	public void TowerRewardRequest(int difficulty, int rewardIndex, List<int> rewardIndexList)
	{
		TowerRewardRequest towerRewardRequest = Aki.Protocol.TowerRewardRequest.Create();
		towerRewardRequest.Difficulty = difficulty;
		towerRewardRequest.RewardIndex = rewardIndex;
		towerRewardRequest.RewardIndexList.AddRange(rewardIndexList);
		Net.Instance.Call(ERequestMessageId.TowerRewardRequest, towerRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TowerRewardResponse towerRewardResponse = (TowerRewardResponse)msg;
			if (towerRewardResponse != null && towerRewardResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				EventSystem.Instance.Emit(EEventName.OnTowerRewardReceived);
				EventSystem.Instance.Emit(EEventName.RedDotTowerReward);
				EventSystem.Instance.Emit<int>(EEventName.RedDotTowerRewardByDifficulties, difficulty);
				EventSystem.Instance.Emit<int>(EEventName.RedDotTowerRewardByDifficulties, 5);
				return;
			}
			if (towerRewardResponse != null && towerRewardResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrTowerSeasonUpdate)
			{
				TowerController.Instance.OpenSeasonUpdateConfirm();
				return;
			}
			if (towerRewardResponse != null)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(towerRewardResponse.ErrorCode, 16113, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06014EEA RID: 85738 RVA: 0x006189BC File Offset: 0x00616BBC
	public UniTask TowerFormationRecommendRequest(int towerConfigId)
	{
		TowerController.<TowerFormationRecommendRequest>d__14 <TowerFormationRecommendRequest>d__;
		<TowerFormationRecommendRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TowerFormationRecommendRequest>d__.towerConfigId = towerConfigId;
		<TowerFormationRecommendRequest>d__.<>1__state = -1;
		<TowerFormationRecommendRequest>d__.<>t__builder.Start<TowerController.<TowerFormationRecommendRequest>d__14>(ref <TowerFormationRecommendRequest>d__);
		return <TowerFormationRecommendRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06014EEB RID: 85739 RVA: 0x00618A00 File Offset: 0x00616C00
	public void TowerApplyFloorDataRequest(bool apply)
	{
		TowerApplyFloorDataRequest towerApplyFloorDataRequest = Aki.Protocol.TowerApplyFloorDataRequest.Create();
		towerApplyFloorDataRequest.Apply = apply;
		Net.Instance.Call(ERequestMessageId.TowerApplyFloorDataRequest, towerApplyFloorDataRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TowerApplyFloorDataResponse towerApplyFloorDataResponse = (TowerApplyFloorDataResponse)msg;
			if (towerApplyFloorDataResponse != null && towerApplyFloorDataResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				EventSystem.Instance.Emit(EEventName.OnTowerRefresh);
				return;
			}
			if (towerApplyFloorDataResponse != null && towerApplyFloorDataResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrTowerSeasonUpdate)
			{
				TowerController.Instance.OpenSeasonUpdateConfirm();
				return;
			}
			if (towerApplyFloorDataResponse != null)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(towerApplyFloorDataResponse.ErrorCode, 18513, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06014EEC RID: 85740 RVA: 0x00618A4C File Offset: 0x00616C4C
	private void TowerInfoUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		TowerInfoUpdateNotify towerInfoUpdateNotify = (TowerInfoUpdateNotify)msg;
		if (towerInfoUpdateNotify.TowerInfo != null)
		{
			TowerModel.Instance.RefreshTowerInfo(towerInfoUpdateNotify.TowerInfo);
		}
	}

	// Token: 0x06014EED RID: 85741 RVA: 0x00618A78 File Offset: 0x00616C78
	private void TowerFloorUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		TowerFloorUpdateNotify towerFloorUpdateNotify = (TowerFloorUpdateNotify)msg;
		TowerModel.Instance.RefreshTowerInfoByFloor(towerFloorUpdateNotify.TowerFloors);
	}

	// Token: 0x06014EEE RID: 85742 RVA: 0x00618A9C File Offset: 0x00616C9C
	private void TowerDifficultyUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		TowerDifficultyUpdateNotify towerDifficultyUpdateNotify = (TowerDifficultyUpdateNotify)msg;
		TowerModel.Instance.RefreshTowerInfoByDifficulty(towerDifficultyUpdateNotify.TowerDifficulties);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, 100300002);
	}

	// Token: 0x06014EEF RID: 85743 RVA: 0x00618AD8 File Offset: 0x00616CD8
	private void TowerEndNotify(IMessage msg, Net.CallbackStatus _)
	{
		TowerEndNotify towerEndNotify = (TowerEndNotify)msg;
		if (towerEndNotify.NeedUpdateSeason && !TowerModel.Instance.GetIsInOnceTower())
		{
			TowerController.Instance.OpenSeasonUpdateConfirm();
			return;
		}
		if (TowerModel.Instance.IsWaitTowerStart)
		{
			return;
		}
		TowerModel.Instance.IsWaitTowerSettlement = true;
		ConfirmBoxController.Instance.CloseConfirmBoxView();
		if (towerEndNotify.Success)
		{
			TowerFloorPb currentFloorData = towerEndNotify.CurrentFloorData;
			if (currentFloorData != null)
			{
				TowerModel.Instance.CurrentNotConfirmedFloor = new TowerFloorInfo(currentFloorData.TowerConfigId, currentFloorData.Star, new List<TowerRolePb>(currentFloorData.Formation), new List<int>(currentFloorData.StarIndex), currentFloorData.IsQuickPass);
			}
		}
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("TowerGuide");
		TowerController.Instance.ClearAllHatredInTower();
		TowerController.Instance.OpenTowerSettlementView(towerEndNotify.Success);
	}

	// Token: 0x06014EF0 RID: 85744 RVA: 0x00618BA0 File Offset: 0x00616DA0
	private void TowerRequest()
	{
		TowerRequest message = Aki.Protocol.TowerRequest.Create();
		Net.Instance.Call(ERequestMessageId.TowerRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TowerResponse towerResponse = (TowerResponse)msg;
			if (towerResponse != null && towerResponse.TowerInfo != null)
			{
				TowerModel.Instance.RefreshTowerInfo(towerResponse.TowerInfo);
				WorldMapModel.Instance.UpdateActivityListItemData(true);
			}
		}, 0);
	}

	// Token: 0x06014EF1 RID: 85745 RVA: 0x00618BE4 File Offset: 0x00616DE4
	public unsafe void OpenTowerSettlementView(bool isSuccess)
	{
		TowerController.<>c__DisplayClass21_0 CS$<>8__locals1 = new TowerController.<>c__DisplayClass21_0();
		CS$<>8__locals1.isSuccess = isSuccess;
		CS$<>8__locals1.towerManager = TowerModel.Instance;
		int currentTowerId = CS$<>8__locals1.towerManager.CurrentTowerId;
		bool haveChallengeFloorAndFormation = CS$<>8__locals1.towerManager.GetHaveChallengeFloorAndFormation(currentTowerId);
		CS$<>8__locals1.buttonList = new List<IRewardExploreConfirmButton>();
		CS$<>8__locals1.nextTowerFloor = TowerClimbConfig.Instance.GetNextFloorInArea(currentTowerId);
		List<IRewardExploreConfirmButton> buttonList = CS$<>8__locals1.buttonList;
		RewardExploreConfirmButtonData rewardExploreConfirmButtonData = new RewardExploreConfirmButtonData();
		rewardExploreConfirmButtonData.ButtonTextId = "Text_BackToTower_Text";
		rewardExploreConfirmButtonData.DescriptionTextId = null;
		rewardExploreConfirmButtonData.IsTimeDownCloseView = false;
		rewardExploreConfirmButtonData.IsClickedCloseView = true;
		rewardExploreConfirmButtonData.OnClickedCallback = delegate(int _)
		{
			TowerController.Instance.BackToTowerView(null);
		};
		buttonList.Add(rewardExploreConfirmButtonData);
		CS$<>8__locals1.toggle = null;
		if (CS$<>8__locals1.isSuccess && haveChallengeFloorAndFormation)
		{
			CS$<>8__locals1.buttonList.RemoveAt(CS$<>8__locals1.buttonList.Count - 1);
			CS$<>8__locals1.buttonList.Add(new RewardExploreConfirmButtonData
			{
				ButtonTextId = "Text_ButtonTextConfirmResult_Text",
				DescriptionTextId = null,
				IsTimeDownCloseView = false,
				IsClickedCloseView = true,
				OnClickedCallback = delegate(int _)
				{
					TowerController.Instance.ConfirmResult(false, CS$<>8__locals1.isSuccess);
				}
			});
		}
		else if (CS$<>8__locals1.isSuccess && CS$<>8__locals1.nextTowerFloor != 0 && !haveChallengeFloorAndFormation)
		{
			TowerConfig? towerInfo = TowerClimbConfig.Instance.GetTowerInfo(CS$<>8__locals1.nextTowerFloor);
			string towerAreaName = TowerClimbConfig.Instance.GetTowerAreaName(CS$<>8__locals1.nextTowerFloor);
			if (towerInfo != null && towerAreaName != null)
			{
				List<IRewardExploreConfirmButton> buttonList2 = CS$<>8__locals1.buttonList;
				RewardExploreConfirmButtonData rewardExploreConfirmButtonData2 = new RewardExploreConfirmButtonData();
				rewardExploreConfirmButtonData2.ButtonTextId = "Text_ButtonTextContinue_Text";
				rewardExploreConfirmButtonData2.DescriptionTextId = "Text_ButtonTextGoOnTower_Text";
				int num = 2;
				List<object> list = new List<object>(num);
				CollectionsMarshal.SetCount<object>(list, num);
				Span<object> span = CollectionsMarshal.AsSpan<object>(list);
				int i = 0;
				*span[i] = towerAreaName;
				i++;
				*span[i] = towerInfo.Value.Floor;
				rewardExploreConfirmButtonData2.DescriptionArgs = list;
				rewardExploreConfirmButtonData2.IsTimeDownCloseView = false;
				rewardExploreConfirmButtonData2.IsClickedCloseView = true;
				rewardExploreConfirmButtonData2.OnClickedCallback = delegate(int _)
				{
					TowerController.Instance.OpenTowerFormation(new int?(CS$<>8__locals1.nextTowerFloor));
				};
				buttonList2.Add(rewardExploreConfirmButtonData2);
			}
		}
		else if (!CS$<>8__locals1.isSuccess || CS$<>8__locals1.nextTowerFloor == 0)
		{
			CS$<>8__locals1.towerManager.NeedChangeFormation = false;
			List<IRewardExploreConfirmButton> buttonList3 = CS$<>8__locals1.buttonList;
			RewardExploreConfirmButtonData rewardExploreConfirmButtonData3 = new RewardExploreConfirmButtonData();
			rewardExploreConfirmButtonData3.ButtonTextId = "Text_ButtonTextChallengeOneMore_Text";
			rewardExploreConfirmButtonData3.DescriptionTextId = null;
			rewardExploreConfirmButtonData3.IsTimeDownCloseView = false;
			rewardExploreConfirmButtonData3.IsClickedCloseView = true;
			rewardExploreConfirmButtonData3.OnClickedCallback = delegate(int _)
			{
				if (TowerModel.Instance.NeedChangeFormation)
				{
					TowerController.Instance.OpenTowerFormation(null);
					return;
				}
				TowerController.Instance.ReChallengeTower();
			};
			buttonList3.Add(rewardExploreConfirmButtonData3);
			CS$<>8__locals1.toggle = new RewardExploreToggleData
			{
				DescriptionTextId = "Text_ChangeFormation_Text",
				OnToggleClick = delegate(EToggleState state)
				{
					CS$<>8__locals1.towerManager.NeedChangeFormation = (state == EToggleState.ETT_Checked);
				}
			};
		}
		if (CS$<>8__locals1.isSuccess)
		{
			List<IRewardExploreTargetReached> targetReached = new List<IRewardExploreTargetReached>();
			IReadOnlyList<int> floorTarget = TowerClimbConfig.Instance.GetFloorTarget(currentTowerId);
			if (floorTarget != null && TowerModel.Instance.CurrentNotConfirmedFloor != null)
			{
				List<int> starIndex = TowerModel.Instance.CurrentNotConfirmedFloor.StarIndex;
				for (int j = 0; j < 3; j++)
				{
					if (j < floorTarget.Count)
					{
						TowerTarget? targetConfig = TowerClimbConfig.Instance.GetTargetConfig(floorTarget[j]);
						if (targetConfig != null)
						{
							List<string> list2 = new List<string>();
							if (targetConfig.Value.Params() != null)
							{
								foreach (int num2 in targetConfig.Value.Params())
								{
									list2.Add(num2.ToString());
								}
							}
							bool isReached = starIndex.Contains(j);
							RewardExploreTargetReachedData item = new RewardExploreTargetReachedData
							{
								Target = list2,
								DescriptionTextId = targetConfig.Value.DesText,
								IsReached = isReached
							};
							targetReached.Add(item);
						}
					}
				}
			}
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				ItemRewardController.Instance.OpenExploreRewardView(3008, CS$<>8__locals1.isSuccess, null, null, null, CS$<>8__locals1.buttonList, targetReached, CS$<>8__locals1.toggle, null, null, null, null, null, null, null, null, null);
			}, (float)TowerModel.Instance.TowerSettlementDelayTime, null, null, true, 1f);
			return;
		}
		List<IRewardExploreBar> barList = new List<IRewardExploreBar>();
		IReadOnlyList<TrainingData> trainingDataList = TrainingDegreeModel.Instance.GetTrainingDataList();
		if (trainingDataList == null)
		{
			return;
		}
		foreach (TrainingData trainingData in trainingDataList)
		{
			RewardExploreBar item2 = new RewardExploreBar
			{
				TrainingData = trainingData
			};
			barList.Add(item2);
		}
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			ItemRewardController.Instance.OpenExploreRewardView(3009, CS$<>8__locals1.isSuccess, null, null, barList, CS$<>8__locals1.buttonList, null, CS$<>8__locals1.toggle, null, null, null, null, null, null, null, null, null);
		}, (float)TowerModel.Instance.TowerSettlementDelayTime, null, null, true, 1f);
	}

	// Token: 0x06014EF2 RID: 85746 RVA: 0x006190A4 File Offset: 0x006172A4
	private void CloseTowerView()
	{
		UiManager.Instance.ResetToBattleView(delegate(bool _)
		{
			if (TowerModel.Instance.CheckInTower())
			{
				TowerController.Instance.LeaveTower().Forget();
			}
		});
	}

	// Token: 0x06014EF3 RID: 85747 RVA: 0x006190D0 File Offset: 0x006172D0
	public UniTask LeaveTower()
	{
		TowerController.<LeaveTower>d__23 <LeaveTower>d__;
		<LeaveTower>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LeaveTower>d__.<>1__state = -1;
		<LeaveTower>d__.<>t__builder.Start<TowerController.<LeaveTower>d__23>(ref <LeaveTower>d__);
		return <LeaveTower>d__.<>t__builder.Task;
	}

	// Token: 0x06014EF4 RID: 85748 RVA: 0x0061910C File Offset: 0x0061730C
	private void OpenTowerFormation(int? nextFloor = null)
	{
		TowerModel.Instance.OpenTowerFormationView(nextFloor ?? TowerModel.Instance.CurrentTowerId);
	}

	// Token: 0x06014EF5 RID: 85749 RVA: 0x00619141 File Offset: 0x00617341
	public void ReChallengeTower()
	{
		TowerModel.Instance.IsWaitTowerStart = true;
		TowerController.Instance.TowerStartRequest(TowerModel.Instance.CurrentTowerId, TowerModel.Instance.CurrentTowerFormation, false);
	}

	// Token: 0x06014EF6 RID: 85750 RVA: 0x00619170 File Offset: 0x00617370
	private void ConfirmResult(bool isFormLeave, bool isSuccess)
	{
		if (isSuccess)
		{
			TowerModel.Instance.SaveNeedOpenConfirmView();
		}
		if (isFormLeave)
		{
			return;
		}
		TowerConfig? towerInfo = TowerClimbConfig.Instance.GetTowerInfo(TowerModel.Instance.NeedOpenConfirmViewTowerId);
		if (towerInfo != null)
		{
			UiManager.Instance.OpenView(EUiViewName.TowerFloorView, towerInfo.Value.AreaNum, null);
		}
	}

	// Token: 0x06014EF7 RID: 85751 RVA: 0x006191D0 File Offset: 0x006173D0
	public void BackToTowerView(Action callBack = null)
	{
		TowerController.Instance.OpenTowerView(true).ContinueWith(delegate(bool _)
		{
			Action callBack2 = callBack;
			if (callBack2 == null)
			{
				return;
			}
			callBack2();
		});
	}

	// Token: 0x06014EF8 RID: 85752 RVA: 0x00619208 File Offset: 0x00617408
	[NullableContext(0)]
	public UniTask<bool> OpenTowerView(bool openCurrentFloor = false)
	{
		TowerController.<OpenTowerView>d__28 <OpenTowerView>d__;
		<OpenTowerView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenTowerView>d__.openCurrentFloor = openCurrentFloor;
		<OpenTowerView>d__.<>1__state = -1;
		<OpenTowerView>d__.<>t__builder.Start<TowerController.<OpenTowerView>d__28>(ref <OpenTowerView>d__);
		return <OpenTowerView>d__.<>t__builder.Task;
	}

	// Token: 0x06014EF9 RID: 85753 RVA: 0x0061924C File Offset: 0x0061744C
	[NullableContext(0)]
	private UniTask<bool> OpenTowerViewInternal(bool openCurrentFloor = false)
	{
		TowerController.<OpenTowerViewInternal>d__29 <OpenTowerViewInternal>d__;
		<OpenTowerViewInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenTowerViewInternal>d__.openCurrentFloor = openCurrentFloor;
		<OpenTowerViewInternal>d__.<>1__state = -1;
		<OpenTowerViewInternal>d__.<>t__builder.Start<TowerController.<OpenTowerViewInternal>d__29>(ref <OpenTowerViewInternal>d__);
		return <OpenTowerViewInternal>d__.<>t__builder.Task;
	}

	// Token: 0x06014EFA RID: 85754 RVA: 0x00619290 File Offset: 0x00617490
	public void OpenSeasonUpdateConfirm()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CycleTowerSeasonRefresh);
		Action value = delegate()
		{
			TowerController.Instance.CloseTowerView();
		};
		confirmBoxDataNew.FunctionMap.Add(1, value);
		confirmBoxDataNew.FunctionMap.Add(2, value);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06014EFB RID: 85755 RVA: 0x006192EB File Offset: 0x006174EB
	public void OpenTowerGuide()
	{
		UiManager.Instance.OpenView(EUiViewName.TowerGuideView, null, null);
	}

	// Token: 0x06014EFC RID: 85756 RVA: 0x00619300 File Offset: 0x00617500
	public void ClearAllHatredInTower()
	{
		foreach (int id in FormationDataModel.Instance.PlayerAggroSet)
		{
			Entity entity = EntitySystem.Instance.Get(id);
			if (entity != null)
			{
				CharacterAiComponent component = entity.GetComponent<CharacterAiComponent>();
				if (component != null)
				{
					AiController aiController = component.AiController;
					if (aiController != null)
					{
						AiHateList aiHateList = aiController.AiHateList;
						if (aiHateList != null)
						{
							aiHateList.ClearHatred(0);
						}
					}
				}
			}
		}
	}

	// Token: 0x17001FBD RID: 8125
	// (get) Token: 0x06014EFD RID: 85757 RVA: 0x00619388 File Offset: 0x00617588
	[Nullable(1)]
	public static TowerController Instance
	{
		[NullableContext(1)]
		get
		{
			return TowerController._Instance;
		}
	}

	// Token: 0x06014EFE RID: 85758 RVA: 0x0061938F File Offset: 0x0061758F
	[NullableContext(1)]
	public static TowerController GetOrCreateInstance()
	{
		if (TowerController._Instance == null)
		{
			TowerController.CreateInstance();
		}
		return TowerController._Instance;
	}

	// Token: 0x06014EFF RID: 85759 RVA: 0x006193A3 File Offset: 0x006175A3
	public static bool CreateInstance()
	{
		if (TowerController._Instance != null)
		{
			return true;
		}
		TowerController._Instance = new TowerController();
		return true;
	}

	// Token: 0x06014F00 RID: 85760 RVA: 0x006193B9 File Offset: 0x006175B9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014F01 RID: 85761 RVA: 0x006193BB File Offset: 0x006175BB
	public static void ResetStaticDefaultValue()
	{
		TowerController._Instance = null;
	}

	// Token: 0x06014F02 RID: 85762 RVA: 0x006193C3 File Offset: 0x006175C3
	static TowerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TowerController.CreateStaticDefaultValue), new Action(TowerController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B24F RID: 45647
	private const int TOWER_SUCCESS_NO_REWARD = 3008;

	// Token: 0x0400B250 RID: 45648
	private const int TOWER_FAIL = 3009;

	// Token: 0x0400B251 RID: 45649
	private static TowerController _Instance;
}

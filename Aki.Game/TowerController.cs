using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02002BD0 RID: 11216
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class TowerController : ControllerBase
{
	// Token: 0x060174AD RID: 95405 RVA: 0x005EBAFD File Offset: 0x005E9CFD
	protected override bool OnInit()
	{
		this.OnAddEvents();
		this.OnRegisterNetEvent();
		return true;
	}

	// Token: 0x060174AE RID: 95406 RVA: 0x005EBB0C File Offset: 0x005E9D0C
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		this.OnUnRegisterNetEvent();
		return true;
	}

	// Token: 0x060174AF RID: 95407 RVA: 0x005EBB1B File Offset: 0x005E9D1B
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDone));
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
	}

	// Token: 0x060174B0 RID: 95408 RVA: 0x005EBB55 File Offset: 0x005E9D55
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDone));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
	}

	// Token: 0x060174B1 RID: 95409 RVA: 0x005EBB90 File Offset: 0x005E9D90
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.TowerInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.TowerInfoUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.TowerDifficultyUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.TowerDifficultyUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.TowerFloorUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.TowerFloorUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.TowerEndNotify, new Action<IMessage, Net.CallbackStatus>(this.TowerEndNotify));
	}

	// Token: 0x060174B2 RID: 95410 RVA: 0x005EBC10 File Offset: 0x005E9E10
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.TowerInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TowerDifficultyUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TowerFloorUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TowerEndNotify);
	}

	// Token: 0x060174B3 RID: 95411 RVA: 0x005EBC5D File Offset: 0x005E9E5D
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

	// Token: 0x060174B4 RID: 95412 RVA: 0x005EBC74 File Offset: 0x005E9E74
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
		if (TowerModel.Instance.CheckInTower())
		{
			UiTimeDilation.Instance.AddWaitSetTimeDilationTag("TowerGuide");
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				TowerController.Instance.OpenTowerGuide();
				EventSystem.Instance.Emit(EEventName.OnShowTowerGuideButton);
			}, (float)TowerModel.Instance.TowerGuideDelayTime, null, null, true, 1f);
		}
	}

	// Token: 0x060174B5 RID: 95413 RVA: 0x005EBD3C File Offset: 0x005E9F3C
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

	// Token: 0x060174B6 RID: 95414 RVA: 0x005EBD80 File Offset: 0x005E9F80
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

	// Token: 0x060174B7 RID: 95415 RVA: 0x005EBDD4 File Offset: 0x005E9FD4
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(towerResetResponse.ErrorCode, 22328, null, true, true);
			}
		}, 0);
	}

	// Token: 0x060174B8 RID: 95416 RVA: 0x005EBE20 File Offset: 0x005EA020
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(towerRewardResponse.ErrorCode, 20230, null, true, true);
			}
		}, 0);
	}

	// Token: 0x060174B9 RID: 95417 RVA: 0x005EBE7C File Offset: 0x005EA07C
	public UniTask TowerFormationRecommendRequest(int towerConfigId)
	{
		TowerController.<TowerFormationRecommendRequest>d__14 <TowerFormationRecommendRequest>d__;
		<TowerFormationRecommendRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TowerFormationRecommendRequest>d__.towerConfigId = towerConfigId;
		<TowerFormationRecommendRequest>d__.<>1__state = -1;
		<TowerFormationRecommendRequest>d__.<>t__builder.Start<TowerController.<TowerFormationRecommendRequest>d__14>(ref <TowerFormationRecommendRequest>d__);
		return <TowerFormationRecommendRequest>d__.<>t__builder.Task;
	}

	// Token: 0x060174BA RID: 95418 RVA: 0x005EBEC0 File Offset: 0x005EA0C0
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(towerApplyFloorDataResponse.ErrorCode, 29629, null, true, true);
			}
		}, 0);
	}

	// Token: 0x060174BB RID: 95419 RVA: 0x005EBF0C File Offset: 0x005EA10C
	private void TowerInfoUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		TowerInfoUpdateNotify towerInfoUpdateNotify = (TowerInfoUpdateNotify)msg;
		if (towerInfoUpdateNotify.TowerInfo != null)
		{
			TowerModel.Instance.RefreshTowerInfo(towerInfoUpdateNotify.TowerInfo);
		}
	}

	// Token: 0x060174BC RID: 95420 RVA: 0x005EBF38 File Offset: 0x005EA138
	private void TowerFloorUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		TowerFloorUpdateNotify towerFloorUpdateNotify = (TowerFloorUpdateNotify)msg;
		TowerModel.Instance.RefreshTowerInfoByFloor(towerFloorUpdateNotify.TowerFloors);
	}

	// Token: 0x060174BD RID: 95421 RVA: 0x005EBF5C File Offset: 0x005EA15C
	private void TowerDifficultyUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		TowerDifficultyUpdateNotify towerDifficultyUpdateNotify = (TowerDifficultyUpdateNotify)msg;
		TowerModel.Instance.RefreshTowerInfoByDifficulty(towerDifficultyUpdateNotify.TowerDifficulties);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, 100300002);
	}

	// Token: 0x060174BE RID: 95422 RVA: 0x005EBF98 File Offset: 0x005EA198
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
				TowerModel.Instance.CurrentNotConfirmedFloor = new TowerFloorInfo(currentFloorData.TowerConfigId, currentFloorData.Star, currentFloorData.Formation.ToList<TowerRolePb>(), currentFloorData.StarIndex.ToList<int>(), currentFloorData.IsQuickPass);
			}
		}
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("TowerGuide");
		TowerController.Instance.ClearAllHatredInTower();
		TowerController.Instance.OpenTowerSettlementView(towerEndNotify.Success);
	}

	// Token: 0x060174BF RID: 95423 RVA: 0x005EC060 File Offset: 0x005EA260
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

	// Token: 0x060174C0 RID: 95424 RVA: 0x005EC0A4 File Offset: 0x005EA2A4
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
								Target = list2.ToList<string>(),
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

	// Token: 0x060174C1 RID: 95425 RVA: 0x005EC568 File Offset: 0x005EA768
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

	// Token: 0x060174C2 RID: 95426 RVA: 0x005EC594 File Offset: 0x005EA794
	public UniTask LeaveTower()
	{
		TowerController.<LeaveTower>d__23 <LeaveTower>d__;
		<LeaveTower>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LeaveTower>d__.<>1__state = -1;
		<LeaveTower>d__.<>t__builder.Start<TowerController.<LeaveTower>d__23>(ref <LeaveTower>d__);
		return <LeaveTower>d__.<>t__builder.Task;
	}

	// Token: 0x060174C3 RID: 95427 RVA: 0x005EC5D0 File Offset: 0x005EA7D0
	private void OpenTowerFormation(int? nextFloor = null)
	{
		TowerModel.Instance.OpenTowerFormationView(nextFloor ?? TowerModel.Instance.CurrentTowerId);
	}

	// Token: 0x060174C4 RID: 95428 RVA: 0x005EC605 File Offset: 0x005EA805
	public void ReChallengeTower()
	{
		TowerModel.Instance.IsWaitTowerStart = true;
		TowerController.Instance.TowerStartRequest(TowerModel.Instance.CurrentTowerId, TowerModel.Instance.CurrentTowerFormation, false);
	}

	// Token: 0x060174C5 RID: 95429 RVA: 0x005EC634 File Offset: 0x005EA834
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

	// Token: 0x060174C6 RID: 95430 RVA: 0x005EC694 File Offset: 0x005EA894
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

	// Token: 0x060174C7 RID: 95431 RVA: 0x005EC6CC File Offset: 0x005EA8CC
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

	// Token: 0x060174C8 RID: 95432 RVA: 0x005EC710 File Offset: 0x005EA910
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

	// Token: 0x060174C9 RID: 95433 RVA: 0x005EC754 File Offset: 0x005EA954
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

	// Token: 0x060174CA RID: 95434 RVA: 0x005EC7AF File Offset: 0x005EA9AF
	public void OpenTowerGuide()
	{
		UiManager.Instance.OpenView(EUiViewName.TowerGuideView, null, null);
	}

	// Token: 0x060174CB RID: 95435 RVA: 0x005EC7C4 File Offset: 0x005EA9C4
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

	// Token: 0x17001F65 RID: 8037
	// (get) Token: 0x060174CC RID: 95436 RVA: 0x005EC84C File Offset: 0x005EAA4C
	[Nullable(1)]
	public static TowerController Instance
	{
		[NullableContext(1)]
		get
		{
			return TowerController._Instance;
		}
	}

	// Token: 0x060174CD RID: 95437 RVA: 0x005EC853 File Offset: 0x005EAA53
	[NullableContext(1)]
	public static TowerController GetOrCreateInstance()
	{
		if (TowerController._Instance == null)
		{
			TowerController.CreateInstance();
		}
		return TowerController._Instance;
	}

	// Token: 0x060174CE RID: 95438 RVA: 0x005EC867 File Offset: 0x005EAA67
	public static bool CreateInstance()
	{
		if (TowerController._Instance != null)
		{
			return true;
		}
		TowerController._Instance = new TowerController();
		return true;
	}

	// Token: 0x060174CF RID: 95439 RVA: 0x005EC87D File Offset: 0x005EAA7D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060174D0 RID: 95440 RVA: 0x005EC87F File Offset: 0x005EAA7F
	public static void ResetStaticDefaultValue()
	{
		TowerController._Instance = null;
	}

	// Token: 0x060174D1 RID: 95441 RVA: 0x005EC887 File Offset: 0x005EAA87
	static TowerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TowerController.CreateStaticDefaultValue), new Action(TowerController.ResetStaticDefaultValue));
	}

	// Token: 0x0400AE4A RID: 44618
	private const int TOWER_SUCCESS_NO_REWARD = 3008;

	// Token: 0x0400AE4B RID: 44619
	private const int TOWER_FAIL = 3009;

	// Token: 0x0400AE4C RID: 44620
	private static TowerController _Instance;
}

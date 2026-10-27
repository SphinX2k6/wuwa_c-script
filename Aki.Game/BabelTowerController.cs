using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.TrainingDegree;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x02001121 RID: 4385
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class BabelTowerController : ActivityControllerBase
{
	// Token: 0x060072D0 RID: 29392 RVA: 0x00178CDC File Offset: 0x00176EDC
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060072D1 RID: 29393 RVA: 0x00178CDE File Offset: 0x00176EDE
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityBabel";
	}

	// Token: 0x060072D2 RID: 29394 RVA: 0x00178CE5 File Offset: 0x00176EE5
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new BabelTowerSubView();
	}

	// Token: 0x060072D3 RID: 29395 RVA: 0x00178CEC File Offset: 0x00176EEC
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new BabelTowerData();
	}

	// Token: 0x060072D4 RID: 29396 RVA: 0x00178CFF File Offset: 0x00176EFF
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x060072D5 RID: 29397 RVA: 0x00178D04 File Offset: 0x00176F04
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.BabelActivityLevelInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.BabelActivityLevelInfoNotify));
		Net.Instance.Register(ENotifyMessageId.BabelActivityDeTermInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.BabelActivityDeTermInfoNotify));
		Net.Instance.Register(ENotifyMessageId.BabelActivityBuffInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.BabelActivityBuffInfoNotify));
		Net.Instance.Register(ENotifyMessageId.BabelActivityTaskInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.BabelActivityTaskInfoNotify));
		Net.Instance.Register(ENotifyMessageId.BabelActivityDailyTaskInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.BabelActivityDailyTaskInfoNotify));
		Net.Instance.Register(ENotifyMessageId.BabelActivitySettleInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.BabelActivitySettleInfoNotify));
		Net.Instance.Register(ENotifyMessageId.BabelActivityInstInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.BabelActivityInstInfoNotify));
		Net.Instance.Register(ENotifyMessageId.BabelActivityItemNumUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.BabelActivityItemNumUpdateNotify));
	}

	// Token: 0x060072D6 RID: 29398 RVA: 0x00178DF4 File Offset: 0x00176FF4
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.BabelActivityLevelInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BabelActivityDeTermInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BabelActivityBuffInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BabelActivityTaskInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BabelActivityDailyTaskInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BabelActivitySettleInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BabelActivityInstInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BabelActivityItemNumUpdateNotify);
	}

	// Token: 0x060072D7 RID: 29399 RVA: 0x00178E81 File Offset: 0x00177081
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
	}

	// Token: 0x060072D8 RID: 29400 RVA: 0x00178E9F File Offset: 0x0017709F
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
	}

	// Token: 0x060072D9 RID: 29401 RVA: 0x00178EBD File Offset: 0x001770BD
	private void OnRoleChangeEnd()
	{
		if (this.ActivityId <= 0)
		{
			return;
		}
		BabelTowerData babelTowerData = this.GetBabelTowerData();
		if (babelTowerData == null)
		{
			return;
		}
		babelTowerData.UpdateAllLevelRoleIds();
	}

	// Token: 0x060072DA RID: 29402 RVA: 0x00178EDC File Offset: 0x001770DC
	[NullableContext(2)]
	private void BabelActivityLevelInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		BabelActivityLevelInfoNotify babelActivityLevelInfoNotify = (BabelActivityLevelInfoNotify)msg;
		this.GetBabelTowerData().UpdateLevelInfosAndNotify(babelActivityLevelInfoNotify.BabelActivityLevelInfos);
		EventSystem.Instance.Emit(EEventName.BabelTowerRefreshLevelInfo);
	}

	// Token: 0x060072DB RID: 29403 RVA: 0x00178F14 File Offset: 0x00177114
	[NullableContext(2)]
	private void BabelActivityDeTermInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		BabelActivityDeTermInfoNotify babelActivityDeTermInfoNotify = (BabelActivityDeTermInfoNotify)msg;
		BabelTowerData babelTowerData = this.GetBabelTowerData();
		foreach (BabelActivityDeTermInfo babelActivityDeTermInfo in babelActivityDeTermInfoNotify.BabelActivityDeTermInfos)
		{
			babelTowerData.DeTermUnlock[babelActivityDeTermInfo.DeTermId] = babelActivityDeTermInfo.DifficultUnlock;
		}
	}

	// Token: 0x060072DC RID: 29404 RVA: 0x00178F80 File Offset: 0x00177180
	[NullableContext(2)]
	private void BabelActivityBuffInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		BabelActivityBuffInfoNotify babelActivityBuffInfoNotify = (BabelActivityBuffInfoNotify)msg;
		BabelTowerData babelTowerData = this.GetBabelTowerData();
		foreach (BabelActivityBuffInfo babelActivityBuffInfo in babelActivityBuffInfoNotify.BabelActivityBuffInfos)
		{
			babelTowerData.BuffUnlock[babelActivityBuffInfo.BabelBuffId] = babelActivityBuffInfo.DifficultUnlock;
		}
	}

	// Token: 0x060072DD RID: 29405 RVA: 0x00178FEC File Offset: 0x001771EC
	[NullableContext(2)]
	private void BabelActivityTaskInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		BabelActivityTaskInfoNotify babelActivityTaskInfoNotify = (BabelActivityTaskInfoNotify)msg;
		BabelTowerData babelTowerData = this.GetBabelTowerData();
		foreach (ActivityTask activityTask in babelActivityTaskInfoNotify.ActivityTasks)
		{
			babelTowerData.NormalQuest[activityTask.Id] = activityTask;
		}
		EventSystem.Instance.Emit(EEventName.BabelTowerRefreshQuestState);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, babelTowerData.Id);
	}

	// Token: 0x060072DE RID: 29406 RVA: 0x00179078 File Offset: 0x00177278
	[NullableContext(2)]
	private void BabelActivityDailyTaskInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		BabelActivityDailyTaskInfoNotify babelActivityDailyTaskInfoNotify = (BabelActivityDailyTaskInfoNotify)msg;
		BabelTowerData babelTowerData = this.GetBabelTowerData();
		foreach (ActivityTask activityTask in babelActivityDailyTaskInfoNotify.ActivityTasks)
		{
			babelTowerData.DailyQuest[activityTask.Id] = activityTask;
		}
		EventSystem.Instance.Emit(EEventName.BabelTowerRefreshQuestState);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, babelTowerData.Id);
	}

	// Token: 0x060072DF RID: 29407 RVA: 0x00179104 File Offset: 0x00177304
	[NullableContext(2)]
	private void BabelActivitySettleInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		BabelTowerController.<>c__DisplayClass16_0 CS$<>8__locals1 = new BabelTowerController.<>c__DisplayClass16_0();
		CS$<>8__locals1.<>4__this = this;
		BabelActivitySettleInfoNotify babelActivitySettleInfoNotify = (BabelActivitySettleInfoNotify)msg;
		CS$<>8__locals1.instData = BabelTowerModel.Instance.CurrentChallengeInstData;
		if (CS$<>8__locals1.instData == null)
		{
			return;
		}
		CS$<>8__locals1.levelId = CS$<>8__locals1.instData.LevelId;
		int curStarNum = CS$<>8__locals1.instData.CurStarNum;
		CS$<>8__locals1.levelConfig = ConfigBabelTowerLevelById.GetConfig(CS$<>8__locals1.levelId, true).Value;
		CS$<>8__locals1.instId = CS$<>8__locals1.levelConfig.InstId;
		int passStar = CS$<>8__locals1.levelConfig.PassStar;
		bool flag = curStarNum >= passStar;
		bool isPass = babelActivitySettleInfoNotify.IsPass;
		CS$<>8__locals1.isDifficult = CS$<>8__locals1.levelConfig.IsDifficult;
		if (isPass && flag)
		{
			this.UpdateLocalLevelDataOnPass(CS$<>8__locals1.levelId, CS$<>8__locals1.isDifficult, curStarNum, babelActivitySettleInfoNotify);
		}
		if (isPass & CS$<>8__locals1.isDifficult)
		{
			this.HandleHardLevelPassSettle(CS$<>8__locals1.levelId, curStarNum, passStar, CS$<>8__locals1.instId, CS$<>8__locals1.instData, babelActivitySettleInfoNotify).Forget();
			return;
		}
		int configId = isPass ? 3025 : 3026;
		IExploreRewardViewData exploreRewardViewData;
		if (isPass)
		{
			string textKey = flag ? "Text_BabelResultOverStarNum_Text" : "Text_BabelResultUnderStarNum_Text";
			string tipTextId = flag ? "Text_BabelResultOverStarTip_Text1" : "Text_BabelResultUnderStarTip_Text";
			BabelTowerSuccessData babelTowerSuccessData = new BabelTowerSuccessData
			{
				NewBabelBuffIds = new List<int>(babelActivitySettleInfoNotify.NewBabelBuffIds),
				NewBabelDeTermIds = new List<int>(babelActivitySettleInfoNotify.NewBabelDeTermId),
				StarTextParam = new TableTextArgNew(textKey, new <>z__ReadOnlyArray<object>(new object[]
				{
					curStarNum,
					passStar
				})),
				TipTextId = tipTextId
			};
			exploreRewardViewData = new ExploreRewardViewData
			{
				ConfigId = configId,
				IsSuccess = true,
				BabelTowerSuccessData = babelTowerSuccessData
			};
		}
		else
		{
			List<IRewardExploreBar> list = new List<IRewardExploreBar>();
			IReadOnlyList<TrainingData> trainingDataList = TrainingDegreeModel.Instance.GetTrainingDataList();
			if (trainingDataList != null)
			{
				foreach (TrainingData trainingData in trainingDataList)
				{
					list.Add(new RewardExploreBar
					{
						TrainingData = trainingData
					});
				}
			}
			exploreRewardViewData = new ExploreRewardViewData
			{
				ConfigId = configId,
				IsSuccess = false,
				ExploreBarDataList = list
			};
		}
		List<IRewardExploreConfirmButton> list2 = new List<IRewardExploreConfirmButton>();
		RewardExploreConfirmButtonData item = new RewardExploreConfirmButtonData
		{
			ButtonTextId = "Text_ButtonTextExit_Text",
			DescriptionTextId = null,
			IsTimeDownCloseView = false,
			IsClickedCloseView = false,
			OnClickedCallback = new Action<int>(CS$<>8__locals1.<BabelActivitySettleInfoNotify>g__ExitCallBack|0)
		};
		list2.Add(item);
		if (!babelActivitySettleInfoNotify.IsPass || !flag)
		{
			RewardExploreConfirmButtonData item2 = new RewardExploreConfirmButtonData
			{
				ButtonTextId = "Text_ChallengeAgain_Text",
				DescriptionTextId = null,
				IsTimeDownCloseView = false,
				IsClickedCloseView = false,
				OnClickedCallback = delegate(int _)
				{
					EToggleState? bottomToggleState = (UiManager.Instance.GetViewByName(EUiViewName.ExploreRewardView) as ExploreRewardView).GetBottomToggleState();
					if (bottomToggleState != null)
					{
						EToggleState? etoggleState = bottomToggleState;
						EToggleState etoggleState2 = EToggleState.ETT_Checked;
						if (etoggleState.GetValueOrDefault() == etoggleState2 & etoggleState != null)
						{
							int num = 0;
							List<int> deTermIdList = CS$<>8__locals1.instData.DeTermIdList;
							if (deTermIdList != null)
							{
								foreach (int id in deTermIdList)
								{
									num += BabelTowerConfig.Instance.GetBabelTowerDeTerm(id).Star;
								}
							}
							BabelTowerLevelInfo babelTowerLevelInfo = new BabelTowerLevelInfo();
							babelTowerLevelInfo.BabelTowerLevelId = CS$<>8__locals1.levelId;
							babelTowerLevelInfo.InstanceId = CS$<>8__locals1.instId;
							babelTowerLevelInfo.RoleList = CS$<>8__locals1.<>4__this.GetTeamRoleConfigIdListWithFill();
							List<int> buffList;
							if ((buffList = CS$<>8__locals1.instData.BuffSelection) == null)
							{
								List<int> list3 = new List<int>();
								list3.Add(-1);
								buffList = list3;
								list3.Add(-1);
							}
							babelTowerLevelInfo.BuffList = buffList;
							babelTowerLevelInfo.BuffCount = CS$<>8__locals1.levelConfig.OptionalBabelBuffNum;
							babelTowerLevelInfo.StarNumber = num;
							BabelTowerLevelInfo param = babelTowerLevelInfo;
							UiManager.Instance.OpenView(EUiViewName.BabelTowerHardLevelInfoViewNew, param, null);
							return;
						}
					}
					CS$<>8__locals1.<>4__this.ReChallengeBabelTower();
				}
			};
			list2.Add(item2);
			RewardExploreToggleData stateToggle = new RewardExploreToggleData
			{
				DescriptionTextId = "Text_ChangeFormation_Text"
			};
			((ExploreRewardViewData)exploreRewardViewData).StateToggle = stateToggle;
		}
		((ExploreRewardViewData)exploreRewardViewData).ButtonInfoList = list2;
		ItemRewardController.Instance.OpenExploreRewardViewNew(exploreRewardViewData);
	}

	// Token: 0x060072E0 RID: 29408 RVA: 0x0017941C File Offset: 0x0017761C
	[NullableContext(2)]
	private void BabelActivityInstInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		BabelActivityInstInfoNotify notify = (BabelActivityInstInfoNotify)msg;
		BabelTowerModel.Instance.UpdateCurrentChallengeInstDataByNotify(notify);
	}

	// Token: 0x060072E1 RID: 29409 RVA: 0x0017943C File Offset: 0x0017763C
	[NullableContext(2)]
	private void BabelActivityItemNumUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		BabelActivityItemNumUpdateNotify babelActivityItemNumUpdateNotify = (BabelActivityItemNumUpdateNotify)msg;
		this.GetBabelTowerData().CurrentItemCount = babelActivityItemNumUpdateNotify.ActivityItemNum;
	}

	// Token: 0x060072E2 RID: 29410 RVA: 0x00179464 File Offset: 0x00177664
	[NullableContext(0)]
	public UniTask<bool> SelectBabelActivityDeTermRequest(int levelId, [Nullable(1)] List<int> deTermList)
	{
		BabelTowerController.<SelectBabelActivityDeTermRequest>d__19 <SelectBabelActivityDeTermRequest>d__;
		<SelectBabelActivityDeTermRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SelectBabelActivityDeTermRequest>d__.levelId = levelId;
		<SelectBabelActivityDeTermRequest>d__.deTermList = deTermList;
		<SelectBabelActivityDeTermRequest>d__.<>1__state = -1;
		<SelectBabelActivityDeTermRequest>d__.<>t__builder.Start<BabelTowerController.<SelectBabelActivityDeTermRequest>d__19>(ref <SelectBabelActivityDeTermRequest>d__);
		return <SelectBabelActivityDeTermRequest>d__.<>t__builder.Task;
	}

	// Token: 0x060072E3 RID: 29411 RVA: 0x001794B0 File Offset: 0x001776B0
	public UniTask SubmitDeTermSelectionAndJump(int levelId, List<int> deTermList, int currentStar, bool jumpToPreBattle = true, int quickId = -1)
	{
		BabelTowerController.<SubmitDeTermSelectionAndJump>d__20 <SubmitDeTermSelectionAndJump>d__;
		<SubmitDeTermSelectionAndJump>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SubmitDeTermSelectionAndJump>d__.<>4__this = this;
		<SubmitDeTermSelectionAndJump>d__.levelId = levelId;
		<SubmitDeTermSelectionAndJump>d__.deTermList = deTermList;
		<SubmitDeTermSelectionAndJump>d__.currentStar = currentStar;
		<SubmitDeTermSelectionAndJump>d__.jumpToPreBattle = jumpToPreBattle;
		<SubmitDeTermSelectionAndJump>d__.<>1__state = -1;
		<SubmitDeTermSelectionAndJump>d__.<>t__builder.Start<BabelTowerController.<SubmitDeTermSelectionAndJump>d__20>(ref <SubmitDeTermSelectionAndJump>d__);
		return <SubmitDeTermSelectionAndJump>d__.<>t__builder.Task;
	}

	// Token: 0x060072E4 RID: 29412 RVA: 0x00179514 File Offset: 0x00177714
	public void OpenPreBattleView(int levelId, int currentStar)
	{
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(levelId);
		BabelTowerData babelTowerData = this.GetBabelTowerData();
		BabelActivityLevelInfo babelActivityLevelInfo = null;
		if (babelTowerLevelConfig.IsDifficult)
		{
			babelTowerData.HardLevelDataMap.TryGetValue(levelId, out babelActivityLevelInfo);
		}
		else
		{
			babelTowerData.NormalLevelDataMap.TryGetValue(levelId, out babelActivityLevelInfo);
		}
		List<int> list = new List<int>();
		int? num;
		if (babelActivityLevelInfo == null)
		{
			num = null;
		}
		else
		{
			RepeatedField<int> maxPassRoleSelection = babelActivityLevelInfo.MaxPassRoleSelection;
			num = ((maxPassRoleSelection != null) ? new int?(maxPassRoleSelection.Count) : null);
		}
		int? num2 = num;
		RepeatedField<int> repeatedField = (num2.GetValueOrDefault() > 0) ? babelActivityLevelInfo.MaxPassRoleSelection : ((babelActivityLevelInfo != null) ? babelActivityLevelInfo.RoleSelection : null);
		if (repeatedField != null)
		{
			foreach (int num3 in repeatedField)
			{
				if (num3 > 0)
				{
					list.Add(num3);
				}
			}
		}
		this.RemoveOutdatedMainRoleTrialIds(list);
		BabelTowerLevelInfo babelTowerLevelInfo = new BabelTowerLevelInfo();
		babelTowerLevelInfo.BabelTowerLevelId = levelId;
		babelTowerLevelInfo.InstanceId = babelTowerLevelConfig.InstId;
		babelTowerLevelInfo.RoleList = list;
		List<int> buffList;
		if (((babelActivityLevelInfo != null) ? babelActivityLevelInfo.MaxPassBuffSelection : null) == null)
		{
			List<int> list2 = new List<int>();
			list2.Add(-1);
			buffList = list2;
			list2.Add(-1);
		}
		else
		{
			buffList = new List<int>(babelActivityLevelInfo.MaxPassBuffSelection);
		}
		babelTowerLevelInfo.BuffList = buffList;
		babelTowerLevelInfo.BuffCount = babelTowerLevelConfig.OptionalBabelBuffNum;
		babelTowerLevelInfo.StarNumber = currentStar;
		BabelTowerLevelInfo param = babelTowerLevelInfo;
		UiManager.Instance.OpenView(EUiViewName.BabelTowerHardLevelInfoViewNew, param, null);
	}

	// Token: 0x060072E5 RID: 29413 RVA: 0x00179688 File Offset: 0x00177888
	public void RemoveOutdatedMainRoleTrialIds(List<int> roleList)
	{
		if (roleList == null || roleList.Count == 0)
		{
			return;
		}
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		RoleModel instance = RoleModel.Instance;
		for (int i = 0; i < roleList.Count; i++)
		{
			int num = roleList[i];
			if (num > 0)
			{
				if (num < 100000)
				{
					RoleDataBase roleDataById = instance.GetRoleDataById(num, true);
					int num2 = (roleDataById != null) ? roleDataById.GetRoleId() : 0;
					if (instance.IsMainRole(num2) && instance.GetRoleInstanceById(num2) == null)
					{
						roleList[i] = 0;
					}
				}
				else
				{
					TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(num);
					if (trialRoleConfig != null)
					{
						RoleDataBase roleDataById2 = instance.GetRoleDataById(num, true);
						int roleId = (roleDataById2 != null) ? roleDataById2.GetRoleId() : 0;
						if (instance.IsMainRole(roleId) && trialRoleConfig.Value.Gender != (int)playerGender)
						{
							roleList[i] = 0;
						}
					}
				}
			}
		}
	}

	// Token: 0x060072E6 RID: 29414 RVA: 0x00179768 File Offset: 0x00177968
	public void BabelTowerTaskRewardRequest(int taskId)
	{
		BabelTowerTaskRewardRequest babelTowerTaskRewardRequest = Aki.Protocol.BabelTowerTaskRewardRequest.Create();
		babelTowerTaskRewardRequest.TaskId = taskId;
		Net.Instance.Call(ERequestMessageId.BabelTowerTaskRewardRequest, babelTowerTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BabelTowerTaskRewardResponse babelTowerTaskRewardResponse = (BabelTowerTaskRewardResponse)msg;
			if (babelTowerTaskRewardResponse == null)
			{
				return;
			}
			if (babelTowerTaskRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(babelTowerTaskRewardResponse.ErrorCode, 21846, null, true, true);
				return;
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
		}, 0);
	}

	// Token: 0x060072E7 RID: 29415 RVA: 0x001797A0 File Offset: 0x001779A0
	public void BabelTowerMultiTaskRewardRequest(List<int> taskIds)
	{
		if (taskIds.Count == 0)
		{
			return;
		}
		BabelTowerTaskRewardRequest babelTowerTaskRewardRequest = Aki.Protocol.BabelTowerTaskRewardRequest.Create();
		babelTowerTaskRewardRequest.TaskIds.Add(taskIds);
		babelTowerTaskRewardRequest.ActivityId = this.ActivityId;
		Net.Instance.Call(ERequestMessageId.BabelTowerTaskRewardRequest, babelTowerTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BabelTowerTaskRewardResponse babelTowerTaskRewardResponse = (BabelTowerTaskRewardResponse)msg;
			if (babelTowerTaskRewardResponse == null)
			{
				return;
			}
			if (babelTowerTaskRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(babelTowerTaskRewardResponse.ErrorCode, 21846, null, true, true);
				return;
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
		}, 0);
	}

	// Token: 0x060072E8 RID: 29416 RVA: 0x001797F4 File Offset: 0x001779F4
	public void BabelTowerDailyTaskRewardRequest(int taskId)
	{
		BabelTowerDailyTaskRewardRequest babelTowerDailyTaskRewardRequest = Aki.Protocol.BabelTowerDailyTaskRewardRequest.Create();
		babelTowerDailyTaskRewardRequest.TaskId = taskId;
		Net.Instance.Call(ERequestMessageId.BabelTowerDailyTaskRewardRequest, babelTowerDailyTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BabelTowerDailyTaskRewardResponse babelTowerDailyTaskRewardResponse = (BabelTowerDailyTaskRewardResponse)msg;
			if (babelTowerDailyTaskRewardResponse == null)
			{
				return;
			}
			if (babelTowerDailyTaskRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(babelTowerDailyTaskRewardResponse.ErrorCode, 20492, null, true, true);
				return;
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
		}, 0);
	}

	// Token: 0x060072E9 RID: 29417 RVA: 0x0017982C File Offset: 0x00177A2C
	public void ResetBabelTowerLevelRequest(int levelId)
	{
		ResetBabelTowerLevelRequest resetBabelTowerLevelRequest = Aki.Protocol.ResetBabelTowerLevelRequest.Create();
		resetBabelTowerLevelRequest.BabelTowerLevelId = levelId;
		Net.Instance.Call(ERequestMessageId.ResetBabelTowerLevelRequest, resetBabelTowerLevelRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ResetBabelTowerLevelResponse resetBabelTowerLevelResponse = (ResetBabelTowerLevelResponse)msg;
			if (resetBabelTowerLevelResponse == null)
			{
				return;
			}
			if (resetBabelTowerLevelResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(resetBabelTowerLevelResponse.ErrorCode, 22385, null, true, true);
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("BabelTowerResetLevelTips", Array.Empty<object>());
			this.GetBabelTowerData().ClearMyRankData();
		}, 0);
	}

	// Token: 0x060072EA RID: 29418 RVA: 0x00179864 File Offset: 0x00177A64
	public void BabelTowerSettlementRequest()
	{
		BabelTowerSettlementRequest message = Aki.Protocol.BabelTowerSettlementRequest.Create();
		Net.Instance.Call(ERequestMessageId.BabelTowerSettlementRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BabelTowerSettlementResponse babelTowerSettlementResponse = (BabelTowerSettlementResponse)msg;
			if (babelTowerSettlementResponse == null)
			{
				return;
			}
			if (babelTowerSettlementResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(babelTowerSettlementResponse.ErrorCode, 24625, null, true, true);
			}
		}, 0);
	}

	// Token: 0x060072EB RID: 29419 RVA: 0x001798A8 File Offset: 0x00177AA8
	public void ReChallengeBabelTower()
	{
		BabelTowerInstanceData currentChallengeInstData = BabelTowerModel.Instance.CurrentChallengeInstData;
		int levelId = currentChallengeInstData.LevelId;
		int instId = ConfigBabelTowerLevelById.GetConfig(levelId, true).Value.InstId;
		List<int> teamRoleConfigIdListWithFill = this.GetTeamRoleConfigIdListWithFill();
		this.BabelTowerStartRequest(instId, teamRoleConfigIdListWithFill, levelId, currentChallengeInstData.BuffSelection ?? new List<int>(), this.BuildSkillBranchListFromRoleList(teamRoleConfigIdListWithFill));
	}

	// Token: 0x060072EC RID: 29420 RVA: 0x0017990C File Offset: 0x00177B0C
	public List<int> GetTeamRoleConfigIdListWithFill()
	{
		List<int> list = new List<int>(SceneTeamModel.Instance.GetTeamRoleConfigIdList(false, false));
		for (int i = list.Count; i < 3; i++)
		{
			list.Add(0);
		}
		return list;
	}

	// Token: 0x060072ED RID: 29421 RVA: 0x00179944 File Offset: 0x00177B44
	public List<int> BuildSkillBranchListFromRoleList(List<int> roleList)
	{
		RoleModel roleModel = RoleModel.Instance;
		return roleList.Select(delegate(int roleConfigId)
		{
			if (roleConfigId <= 0)
			{
				return 0;
			}
			return roleModel.GetRoleSkillBranchIdInGamePlay(roleConfigId, ESkillBranchCacheType.BabelTower);
		}).ToList<int>();
	}

	// Token: 0x060072EE RID: 29422 RVA: 0x0017997C File Offset: 0x00177B7C
	public void BabelTowerStartRequest(int instanceId, List<int> roleList, int levelId, List<int> buffList, List<int> skillBranchList)
	{
		BabelTowerData babelTowerData = this.GetBabelTowerData();
		this.RequestRankDataList(babelTowerData, true).Forget();
		BabelTowerCtx babelTowerCtx = new BabelTowerCtx();
		babelTowerCtx.LevelsId = levelId;
		babelTowerCtx.SelectBuff.Add(buffList);
		babelTowerCtx.SkillBranchId.Add(skillBranchList);
		InstanceDungeonModel.Instance.InstanceEnterContentText.BabelTowerCtx = babelTowerCtx;
		int valueOrDefault = PlayerInfoModel.Instance.GetId().GetValueOrDefault();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(valueOrDefault);
		defaultInterpolatedStringHandler.AppendLiteral("_");
		defaultInterpolatedStringHandler.AppendFormatted<long>((long)Time.Instance.ServerTimeStamp);
		string traceId = defaultInterpolatedStringHandler.ToStringAndClear();
		BabelTowerModel.Instance.SetTraceId(traceId);
		InstanceDungeonController.Instance.PrewarTeamFightRequest(instanceId, roleList, 0, 0, null, null).ContinueWith(delegate(bool success)
		{
			if (success)
			{
				BabelTowerModel.Instance.CurrentSelectLevel = 0;
				BabelTowerController <>4__this = this;
				BabelTowerInstanceData currentChallengeInstData = BabelTowerModel.Instance.CurrentChallengeInstData;
				<>4__this.ReportBabelTowerEnterSelection(((currentChallengeInstData != null) ? currentChallengeInstData.TraceId : null) ?? "", levelId, buffList);
			}
			return UniTask.CompletedTask;
		}).Forget();
	}

	// Token: 0x060072EF RID: 29423 RVA: 0x00179A77 File Offset: 0x00177C77
	public BabelTowerData GetBabelTowerData()
	{
		return (BabelTowerData)ActivityModel.Instance.GetActivityById(this.ActivityId);
	}

	// Token: 0x060072F0 RID: 29424 RVA: 0x00179A90 File Offset: 0x00177C90
	public void OnClickInstanceDungeonExitButton()
	{
		int playerId = CreatureModel.Instance.GetPlayerId();
		if (SceneTeamModel.Instance.GetCurrentGroupLivingState(playerId) == ETeamLivingState.Dead)
		{
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BabelTowerInstanceDungeonLeave);
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		confirmBoxDataNew.FunctionMap[1] = new Action(BabelTowerController.<OnClickInstanceDungeonExitButton>g__LeaveCallBack|33_0);
		confirmBoxDataNew.FunctionMap[2] = new Action(this.<OnClickInstanceDungeonExitButton>g__ReChallengeCallBack|33_1);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060072F1 RID: 29425 RVA: 0x00179B08 File Offset: 0x00177D08
	public void SaveNewLevelData(int levelId)
	{
		Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.BabelTowerNewLevel, null) ?? new Dictionary<int, bool>();
		dictionary[levelId] = true;
		LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.BabelTowerNewLevel, dictionary);
	}

	// Token: 0x060072F2 RID: 29426 RVA: 0x00179B38 File Offset: 0x00177D38
	public void SaveNewLevelClickData(int levelId, EBabelTowerDifficulty difficulty)
	{
		Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.BabelTowerNewLevelHasClick, null) ?? new Dictionary<int, bool>();
		dictionary[levelId] = true;
		LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.BabelTowerNewLevelHasClick, dictionary);
		EventSystem.Instance.Emit<int>(EEventName.BabelTowerLevelClick, levelId);
		EventSystem.Instance.Emit<int>(EEventName.BabelTowerDifficultyLevelClick, (int)difficulty);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
	}

	// Token: 0x060072F3 RID: 29427 RVA: 0x00179BA0 File Offset: 0x00177DA0
	private void UpdateLocalLevelDataOnPass(int levelId, bool isDifficult, int curStarNum, BabelActivitySettleInfoNotify response)
	{
		BabelTowerData babelTowerData = this.GetBabelTowerData();
		BabelActivityLevelInfo babelActivityLevelInfo;
		if (!(isDifficult ? babelTowerData.HardLevelDataMap : babelTowerData.NormalLevelDataMap).TryGetValue(levelId, out babelActivityLevelInfo))
		{
			return;
		}
		int passStar = babelActivityLevelInfo.PassStar;
		int maxPassUseTime = babelActivityLevelInfo.MaxPassUseTime;
		int useTime = response.UseTime;
		babelActivityLevelInfo.IsFinished = true;
		bool flag = curStarNum > passStar;
		bool flag2 = curStarNum == passStar;
		bool flag3 = maxPassUseTime == 0 || (flag2 && useTime > 0 && useTime < maxPassUseTime);
		bool flag4 = flag || flag3;
		if (flag)
		{
			babelActivityLevelInfo.PassStar = curStarNum;
		}
		if (flag3)
		{
			babelActivityLevelInfo.MaxPassUseTime = useTime;
		}
		if (flag4)
		{
			List<int> teamRoleConfigIdList = SceneTeamModel.Instance.GetTeamRoleConfigIdList(false, false);
			if (teamRoleConfigIdList != null && teamRoleConfigIdList.Count > 0)
			{
				babelActivityLevelInfo.MaxPassRoleSelection.Clear();
				babelActivityLevelInfo.MaxPassRoleSelection.Add(teamRoleConfigIdList);
			}
			RepeatedField<int> newBabelBuffIds = response.NewBabelBuffIds;
			if (newBabelBuffIds.Count > 0)
			{
				babelActivityLevelInfo.MaxPassBuffSelection.Clear();
				babelActivityLevelInfo.MaxPassBuffSelection.Add(newBabelBuffIds);
			}
		}
	}

	// Token: 0x060072F4 RID: 29428 RVA: 0x00179C90 File Offset: 0x00177E90
	private UniTask HandleHardLevelPassSettle(int levelId, int curStarNum, int targetStarNum, int instId, BabelTowerInstanceData instData, BabelActivitySettleInfoNotify response)
	{
		BabelTowerController.<HandleHardLevelPassSettle>d__37 <HandleHardLevelPassSettle>d__;
		<HandleHardLevelPassSettle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HandleHardLevelPassSettle>d__.<>4__this = this;
		<HandleHardLevelPassSettle>d__.levelId = levelId;
		<HandleHardLevelPassSettle>d__.curStarNum = curStarNum;
		<HandleHardLevelPassSettle>d__.targetStarNum = targetStarNum;
		<HandleHardLevelPassSettle>d__.instId = instId;
		<HandleHardLevelPassSettle>d__.instData = instData;
		<HandleHardLevelPassSettle>d__.response = response;
		<HandleHardLevelPassSettle>d__.<>1__state = -1;
		<HandleHardLevelPassSettle>d__.<>t__builder.Start<BabelTowerController.<HandleHardLevelPassSettle>d__37>(ref <HandleHardLevelPassSettle>d__);
		return <HandleHardLevelPassSettle>d__.<>t__builder.Task;
	}

	// Token: 0x060072F5 RID: 29429 RVA: 0x00179D08 File Offset: 0x00177F08
	public UniTask RequestRankDataList(BabelTowerData data, bool cacheMyRank = false)
	{
		BabelTowerController.<RequestRankDataList>d__38 <RequestRankDataList>d__;
		<RequestRankDataList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRankDataList>d__.data = data;
		<RequestRankDataList>d__.cacheMyRank = cacheMyRank;
		<RequestRankDataList>d__.<>1__state = -1;
		<RequestRankDataList>d__.<>t__builder.Start<BabelTowerController.<RequestRankDataList>d__38>(ref <RequestRankDataList>d__);
		return <RequestRankDataList>d__.<>t__builder.Task;
	}

	// Token: 0x060072F6 RID: 29430 RVA: 0x00179D54 File Offset: 0x00177F54
	public bool ConvertProtoToRankData(PublicBabelTowerInfo protoData, BabelTowerRankItemData rankItemData, int levelId)
	{
		RepeatedField<PublicBabelTowerChallengeInfo> challengeInfo = protoData.ChallengeInfo;
		if (challengeInfo.Count == 0)
		{
			return false;
		}
		bool flag = levelId == -1;
		List<PublicBabelTowerChallengeInfo> list = flag ? challengeInfo.ToList<PublicBabelTowerChallengeInfo>() : (from c in challengeInfo
		where c.ChallengeId == levelId && c.UseTime > 0
		select c).ToList<PublicBabelTowerChallengeInfo>();
		if (list.Count == 0)
		{
			return false;
		}
		int num = 0;
		int num2 = 0;
		List<int> list2 = new List<int>();
		List<int> list3 = new List<int>();
		foreach (PublicBabelTowerChallengeInfo publicBabelTowerChallengeInfo in list)
		{
			num += publicBabelTowerChallengeInfo.Star;
			num2 += publicBabelTowerChallengeInfo.UseTime;
			foreach (BabelPassRoleInfo babelPassRoleInfo in publicBabelTowerChallengeInfo.BabelPassRoleInfos)
			{
				list2.Add(babelPassRoleInfo.RoleId);
				list3.Add(babelPassRoleInfo.RoleLevel);
			}
		}
		if (num2 <= 0)
		{
			return false;
		}
		rankItemData.Name = protoData.Name;
		rankItemData.ShowName = protoData.ShowName;
		rankItemData.HeadId = protoData.HeadId;
		rankItemData.TowerLevel = list[0].ChallengeId;
		rankItemData.PassStar = num;
		rankItemData.PassTime = num2;
		rankItemData.RoleIdList = list2;
		rankItemData.RoleLevelList = list3;
		rankItemData.HasData = true;
		rankItemData.TitleId = protoData.TitleId;
		rankItemData.TitleStarLevel = protoData.TitleExtraParam;
		rankItemData.PlayerId = protoData.PlayerId;
		rankItemData.ShowRoleList = !flag;
		return true;
	}

	// Token: 0x060072F7 RID: 29431 RVA: 0x00179F0C File Offset: 0x0017810C
	public UniTask SetShowNameRequestAsync(int activityId, bool showName)
	{
		BabelTowerController.<SetShowNameRequestAsync>d__40 <SetShowNameRequestAsync>d__;
		<SetShowNameRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetShowNameRequestAsync>d__.<>4__this = this;
		<SetShowNameRequestAsync>d__.activityId = activityId;
		<SetShowNameRequestAsync>d__.showName = showName;
		<SetShowNameRequestAsync>d__.<>1__state = -1;
		<SetShowNameRequestAsync>d__.<>t__builder.Start<BabelTowerController.<SetShowNameRequestAsync>d__40>(ref <SetShowNameRequestAsync>d__);
		return <SetShowNameRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060072F8 RID: 29432 RVA: 0x00179F60 File Offset: 0x00178160
	private void ReportBabelTowerRankChange(int levelId, int currentStar, int targetStar, int dungeonId, string traceId, int oldLevelRank, int newLevelRank, int oldTotalRank, int newTotalRank)
	{
		PublicBabelTowerInfo rawSelfData = this.GetBabelTowerData().GetRawSelfData();
		int i_best_star = currentStar;
		if (((rawSelfData != null) ? rawSelfData.ChallengeInfo : null) != null)
		{
			PublicBabelTowerChallengeInfo publicBabelTowerChallengeInfo = rawSelfData.ChallengeInfo.FirstOrDefault((PublicBabelTowerChallengeInfo c) => c.ChallengeId == levelId);
			if (publicBabelTowerChallengeInfo != null)
			{
				i_best_star = publicBabelTowerChallengeInfo.Star;
			}
		}
		BabelTowerRankChangeEvent babelTowerRankChangeEvent = new BabelTowerRankChangeEvent();
		babelTowerRankChangeEvent.i_best_star = i_best_star;
		babelTowerRankChangeEvent.i_current_star = currentStar;
		babelTowerRankChangeEvent.i_target_star = targetStar;
		babelTowerRankChangeEvent.i_dungeon_id = dungeonId;
		babelTowerRankChangeEvent.s_trace_id = traceId;
		babelTowerRankChangeEvent.s_battle_id = traceId;
		babelTowerRankChangeEvent.i_old_exp = oldLevelRank;
		babelTowerRankChangeEvent.i_new_exp = newLevelRank;
		babelTowerRankChangeEvent.i_old_level = oldTotalRank;
		babelTowerRankChangeEvent.i_new_level = newTotalRank;
		LogReportController.Instance.LogReport(babelTowerRankChangeEvent);
	}

	// Token: 0x060072F9 RID: 29433 RVA: 0x0017A01C File Offset: 0x0017821C
	private static bool IsSameDeTermSet(List<int> a, int[] b)
	{
		if (a == null || b == null)
		{
			return false;
		}
		if (a.Count != b.Length)
		{
			return false;
		}
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (int key in a)
		{
			int num;
			if (dictionary.TryGetValue(key, out num))
			{
				dictionary[key] = num + 1;
			}
			else
			{
				dictionary[key] = 1;
			}
		}
		foreach (int key2 in b)
		{
			int num2;
			if (!dictionary.TryGetValue(key2, out num2) || num2 <= 0)
			{
				return false;
			}
			dictionary[key2] = num2 - 1;
		}
		return true;
	}

	// Token: 0x060072FA RID: 29434 RVA: 0x0017A0DC File Offset: 0x001782DC
	private void ReportBabelTowerEnterSelection(string traceId, int levelId, List<int> buffList)
	{
		BabelTowerEnterSelectionLogEvent babelTowerEnterSelectionLogEvent = new BabelTowerEnterSelectionLogEvent();
		List<int> list = (from buffId in buffList
		where buffId > 0
		select buffId).ToList<int>();
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(levelId);
		int[] recommendBuffs = babelTowerLevelConfig.GetRecommendBuffArray() ?? Array.Empty<int>();
		bool s_buff_selection = list.Count > 0 && list.All((int buffId) => recommendBuffs.Contains(buffId));
		babelTowerEnterSelectionLogEvent.s_buff_selection = s_buff_selection;
		babelTowerEnterSelectionLogEvent.o_buff_selection = (from buffId in list
		select new BuffSelectionData
		{
			i_buff_id = buffId
		}).ToList<BuffSelectionData>();
		List<int> allActiveDeTermList = BabelTowerModel.Instance.GetAllActiveDeTermList();
		HashSet<int> hashSet = new HashSet<int>();
		foreach (KeyValuePair<int, IBabelTowerSelectInfo> keyValuePair in BabelTowerModel.Instance.DeTermSelectInfo)
		{
			int key = keyValuePair.Key;
			IBabelTowerSelectInfo value = keyValuePair.Value;
			if (key != 0 && (value.State == EBabelTowerDeTermState.Select || value.State == EBabelTowerDeTermState.StaticSelect))
			{
				hashSet.Add(key);
			}
		}
		babelTowerEnterSelectionLogEvent.o_debuff_selection = (from deTermId in hashSet
		select new DeBuffSelectionData
		{
			i_debuff_id = deTermId
		}).ToList<DeBuffSelectionData>();
		int currentQuickIndex = BabelTowerModel.Instance.CurrentQuickIndex;
		string s_debuff_selection = "非预设";
		if (currentQuickIndex >= 0)
		{
			IReadOnlyList<BabelTowerQuick> babelTowerQuickByInstId = BabelTowerConfig.Instance.GetBabelTowerQuickByInstId(babelTowerLevelConfig.InstId);
			if (babelTowerQuickByInstId != null && currentQuickIndex < babelTowerQuickByInstId.Count)
			{
				BabelTowerQuick babelTowerQuick = babelTowerQuickByInstId[currentQuickIndex];
				if (BabelTowerController.IsSameDeTermSet(allActiveDeTermList, babelTowerQuick.GetBuffGroupArray()))
				{
					s_debuff_selection = babelTowerQuick.DifficultyTextKey;
				}
			}
		}
		babelTowerEnterSelectionLogEvent.s_debuff_selection = s_debuff_selection;
		babelTowerEnterSelectionLogEvent.s_trace_id = traceId;
		babelTowerEnterSelectionLogEvent.s_battle_id = traceId;
		LogReportController.Instance.LogReport(babelTowerEnterSelectionLogEvent);
	}

	// Token: 0x170009B2 RID: 2482
	// (get) Token: 0x060072FB RID: 29435 RVA: 0x0017A2D8 File Offset: 0x001784D8
	public static BabelTowerController Instance
	{
		get
		{
			return BabelTowerController._Instance;
		}
	}

	// Token: 0x060072FC RID: 29436 RVA: 0x0017A2DF File Offset: 0x001784DF
	public static BabelTowerController GetOrCreateInstance()
	{
		if (BabelTowerController._Instance == null)
		{
			BabelTowerController.CreateInstance();
		}
		return BabelTowerController._Instance;
	}

	// Token: 0x060072FD RID: 29437 RVA: 0x0017A2F3 File Offset: 0x001784F3
	public static bool CreateInstance()
	{
		if (BabelTowerController._Instance != null)
		{
			return true;
		}
		BabelTowerController._Instance = new BabelTowerController();
		return true;
	}

	// Token: 0x060072FE RID: 29438 RVA: 0x0017A309 File Offset: 0x00178509
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060072FF RID: 29439 RVA: 0x0017A30B File Offset: 0x0017850B
	public static void ResetStaticDefaultValue()
	{
		BabelTowerController._Instance = null;
	}

	// Token: 0x06007300 RID: 29440 RVA: 0x0017A313 File Offset: 0x00178513
	static BabelTowerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BabelTowerController.CreateStaticDefaultValue), new Action(BabelTowerController.ResetStaticDefaultValue));
	}

	// Token: 0x06007306 RID: 29446 RVA: 0x0017A484 File Offset: 0x00178684
	[CompilerGenerated]
	internal static void <OnClickInstanceDungeonExitButton>g__LeaveCallBack|33_0()
	{
		BabelTowerMainViewData param = new BabelTowerMainViewData
		{
			IfLeaveInstanceDungeonWhenClose = true
		};
		UiManager.Instance.OpenView(EUiViewName.BabelTowerMainView, param, null);
	}

	// Token: 0x06007307 RID: 29447 RVA: 0x0017A4AF File Offset: 0x001786AF
	[CompilerGenerated]
	private void <OnClickInstanceDungeonExitButton>g__ReChallengeCallBack|33_1()
	{
		this.ReChallengeBabelTower();
	}

	// Token: 0x04003518 RID: 13592
	public int ActivityId;

	// Token: 0x04003519 RID: 13593
	[Nullable(2)]
	private static BabelTowerController _Instance;
}

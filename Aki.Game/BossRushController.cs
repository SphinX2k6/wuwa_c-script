using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.BossRush;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x020011B7 RID: 4535
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class BossRushController : ActivityControllerBase
{
	// Token: 0x06007861 RID: 30817 RVA: 0x001939CB File Offset: 0x00191BCB
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06007862 RID: 30818 RVA: 0x001939CD File Offset: 0x00191BCD
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityBossrush";
	}

	// Token: 0x06007863 RID: 30819 RVA: 0x001939D4 File Offset: 0x00191BD4
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new BossRushSubView();
	}

	// Token: 0x06007864 RID: 30820 RVA: 0x001939DB File Offset: 0x00191BDB
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new BossRushData();
	}

	// Token: 0x06007865 RID: 30821 RVA: 0x001939E2 File Offset: 0x00191BE2
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06007866 RID: 30822 RVA: 0x001939E8 File Offset: 0x00191BE8
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.BossRushResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnChallengeEndNotify));
		Net.Instance.Register(ENotifyMessageId.BossRushLevelInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBossRushLevelInfoNotify));
		Net.Instance.Register(ENotifyMessageId.BossRushFailResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBossRushFailNotify));
		Net.Instance.Register(ENotifyMessageId.BossRushTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBossRushTaskUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.BossRushSelectBuffNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBossRushSelectBuffNotify));
	}

	// Token: 0x06007867 RID: 30823 RVA: 0x00193A84 File Offset: 0x00191C84
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.BossRushResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BossRushLevelInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BossRushFailResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BossRushTaskUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BossRushSelectBuffNotify);
	}

	// Token: 0x06007868 RID: 30824 RVA: 0x00193AE1 File Offset: 0x00191CE1
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.LeaveInstanceDungeonConfirm, new Action(this.OnLeaveInstanceDungeonConfirm));
		EventSystem.Instance.Add<Aki.Protocol.ErrorCode>(EEventName.EnterInstanceDungeonFail, new Action<Aki.Protocol.ErrorCode>(this.EnterInstanceDungeonFail));
	}

	// Token: 0x06007869 RID: 30825 RVA: 0x00193B1B File Offset: 0x00191D1B
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeonConfirm, new Action(this.OnLeaveInstanceDungeonConfirm));
		EventSystem.Instance.Remove(EEventName.EnterInstanceDungeonFail, new Action<Aki.Protocol.ErrorCode>(this.EnterInstanceDungeonFail));
	}

	// Token: 0x0600786A RID: 30826 RVA: 0x00193B58 File Offset: 0x00191D58
	private void OnLeaveInstanceDungeonConfirm()
	{
		int instanceId = CreatureModel.Instance.GetInstanceId();
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		if (config != null && config.Value.InstSubType == 20)
		{
			BossRushController.Instance.RequestSettlement();
		}
	}

	// Token: 0x0600786B RID: 30827 RVA: 0x00193BA2 File Offset: 0x00191DA2
	private void EnterInstanceDungeonFail(Aki.Protocol.ErrorCode errorCode)
	{
		if (errorCode == Aki.Protocol.ErrorCode.BossRushActivityBuffSelectionEmpty)
		{
			EventSystem.Instance.Emit<int>(EEventName.BossRushBuffTabChange, 0);
		}
		if (errorCode == Aki.Protocol.ErrorCode.BossRushBuffCountLimit)
		{
			EventSystem.Instance.Emit<int>(EEventName.BossRushBuffTabChange, 1);
		}
	}

	// Token: 0x0600786C RID: 30828 RVA: 0x00193BD8 File Offset: 0x00191DD8
	private void CheckIfNewBossRushOpen()
	{
		foreach (int id in BossRushModel.Instance.CurrentOpenBossRushActivityIds)
		{
			BossRushData bossRushData = ActivityModel.Instance.GetActivityById(id) as BossRushData;
			if (bossRushData != null)
			{
				bossRushData.CheckIfNewBossRushOpen();
			}
		}
	}

	// Token: 0x0600786D RID: 30829 RVA: 0x00193C44 File Offset: 0x00191E44
	[NullableContext(2)]
	private void OnBossRushLevelInfoNotify(IMessage msg, Net.CallbackStatus _)
	{
		BossRushLevelInfoNotify bossRushLevelInfoNotify = (BossRushLevelInfoNotify)msg;
		BossRushData bossRushData = ActivityModel.Instance.GetActivityById(bossRushLevelInfoNotify.ActivityId) as BossRushData;
		if (bossRushData == null)
		{
			return;
		}
		bossRushData.PhraseLevelInfo(bossRushLevelInfoNotify.UnlockedBuffIndices.ToArray<int>(), bossRushLevelInfoNotify.BossRushLevelInfo.ToArray<BossRushLevelData>());
		bossRushData.PhraseRewardInfo(bossRushLevelInfoNotify.BossRushScoreScoreRewardInfo.ToArray<BossRushScoreRewardData>());
		bossRushData.CheckIfNewBossRushOpen();
		EventSystem.Instance.Emit(EEventName.BossRushDataUpdate);
		if (UiManager.Instance.IsViewOpen(EUiViewName.ActivityRewardPopUpView))
		{
			EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, bossRushData.GetRewardViewData());
		}
		EventSystem.Instance.Emit<int>(EEventName.BossRefreshBossRushRewardRedDot, bossRushLevelInfoNotify.ActivityId);
	}

	// Token: 0x0600786E RID: 30830 RVA: 0x00193CF4 File Offset: 0x00191EF4
	[NullableContext(2)]
	private void OnBossRushSelectBuffNotify(IMessage msg, Net.CallbackStatus _)
	{
		BossRushSelectBuffNotify bossRushSelectBuffNotify = (BossRushSelectBuffNotify)msg;
		BossRushData bossRushData = ActivityModel.Instance.GetActivityById(bossRushSelectBuffNotify.ActivityId) as BossRushData;
		if (bossRushData == null)
		{
			return;
		}
		bossRushData.SetInsSelectedBuffIdMap(bossRushSelectBuffNotify.InstId, bossRushSelectBuffNotify.SelectBuffIndices.ToArray<int>());
	}

	// Token: 0x0600786F RID: 30831 RVA: 0x00193D3C File Offset: 0x00191F3C
	public int GetBossRushSelectedBuffId(int instanceId)
	{
		foreach (ActivityBaseData activityBaseData in ActivityModel.Instance.GetAllActivityMap().Values)
		{
			BossRushData bossRushData = activityBaseData as BossRushData;
			if (bossRushData != null && bossRushData.GetBossRushLevelDetailInfoById(instanceId) != null)
			{
				int[] insSelectedBuffId = bossRushData.GetInsSelectedBuffId(instanceId);
				if (insSelectedBuffId.Length != 0)
				{
					return insSelectedBuffId[0];
				}
			}
		}
		return 0;
	}

	// Token: 0x06007870 RID: 30832 RVA: 0x00193DB8 File Offset: 0x00191FB8
	[NullableContext(2)]
	private void OnBossRushTaskUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		BossRushTaskUpdateNotify bossRushTaskUpdateNotify = (BossRushTaskUpdateNotify)msg;
		List<int> list = new List<int>();
		foreach (ActivityTask activityTask in bossRushTaskUpdateNotify.ActivityTasks)
		{
			int activityId = BossRushConfig.Instance.GetBossRushTaskConfig(activityTask.Id).ActivityId;
			BossRushData bossRushData = ActivityModel.Instance.GetActivityById(activityId) as BossRushData;
			if (bossRushData != null)
			{
				bossRushData.RefreshSingleTaskData(activityTask);
				if (!list.Contains(activityId))
				{
					list.Add(activityId);
				}
			}
		}
		EventSystem.Instance.Emit(EEventName.BossRushTaskStateChanged);
		EventSystem.Instance.Emit(EEventName.BossRefreshBossRushReward);
		foreach (int p in list)
		{
			EventSystem.Instance.Emit<int>(EEventName.BossRefreshBossRushRewardRedDot, p);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, p);
		}
	}

	// Token: 0x06007871 RID: 30833 RVA: 0x00193ED0 File Offset: 0x001920D0
	[NullableContext(2)]
	private void OnBossRushFailNotify(IMessage msg, Net.CallbackStatus _2)
	{
		List<IRewardExploreConfirmButton> list = new List<IRewardExploreConfirmButton>();
		Action<int> onClickedCallback = delegate(int _)
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
		};
		list.Add(new RewardExploreConfirmButtonData
		{
			ButtonTextId = "BossRushFailLeave",
			DescriptionTextId = null,
			IsTimeDownCloseView = false,
			IsClickedCloseView = true,
			OnClickedCallback = onClickedCallback
		});
		ItemRewardModel.Instance.ClearCurrentRewardData();
		RewardData<IExploreRewardInfo> rewardData = ItemRewardModel.Instance.RefreshExploreRewardDataFromConfig(3015, false, null, null, null, list, null, null, null, null, null, null, null, null, null, null);
		ItemRewardController.Instance.Open<IExploreRewardInfo>(rewardData, null);
	}

	// Token: 0x06007872 RID: 30834 RVA: 0x00193F7C File Offset: 0x0019217C
	[NullableContext(2)]
	private unsafe void OnChallengeEndNotify(IMessage msg, Net.CallbackStatus _)
	{
		BossRushResultNotify bossRushResultNotify = (BossRushResultNotify)msg;
		this.CheckIfNewBossRushOpen();
		bool flag = true;
		RewardData<IExploreRewardInfo> rewardData = this.CreateExploreData(flag ? 3016 : 3015, flag, null, bossRushResultNotify);
		ReachTargetData reachTargetData = new ReachTargetData();
		List<IRewardExploreTargetReached> list = new List<IRewardExploreTargetReached>();
		RewardExploreTargetReachedData rewardExploreTargetReachedData = new RewardExploreTargetReachedData();
		int num = 1;
		List<string> list2 = new List<string>(num);
		CollectionsMarshal.SetCount<string>(list2, num);
		Span<string> span = CollectionsMarshal.AsSpan<string>(list2);
		int num2 = 0;
		*span[num2] = bossRushResultNotify.KilMonsterScore.ToString();
		rewardExploreTargetReachedData.Target = list2;
		rewardExploreTargetReachedData.DescriptionTextId = "BossRushMonsterScoreTips";
		rewardExploreTargetReachedData.IsReached = false;
		RewardExploreTargetReachedData item = rewardExploreTargetReachedData;
		list.Add(item);
		RewardExploreTargetReachedData rewardExploreTargetReachedData2 = new RewardExploreTargetReachedData();
		num2 = 1;
		List<string> list3 = new List<string>(num2);
		CollectionsMarshal.SetCount<string>(list3, num2);
		span = CollectionsMarshal.AsSpan<string>(list3);
		num = 0;
		*span[num] = bossRushResultNotify.TimerScore.ToString();
		rewardExploreTargetReachedData2.Target = list3;
		rewardExploreTargetReachedData2.DescriptionTextId = "BossRushTimeScoreTips";
		rewardExploreTargetReachedData2.IsReached = false;
		RewardExploreTargetReachedData item2 = rewardExploreTargetReachedData2;
		list.Add(item2);
		RewardExploreTargetReachedData rewardExploreTargetReachedData3 = new RewardExploreTargetReachedData();
		num = 1;
		List<string> list4 = new List<string>(num);
		CollectionsMarshal.SetCount<string>(list4, num);
		span = CollectionsMarshal.AsSpan<string>(list4);
		num2 = 0;
		*span[num2] = bossRushResultNotify.TechnicalScore.ToString();
		rewardExploreTargetReachedData3.Target = list4;
		rewardExploreTargetReachedData3.DescriptionTextId = "BossRushTechScoreTips";
		rewardExploreTargetReachedData3.IsReached = false;
		RewardExploreTargetReachedData item3 = rewardExploreTargetReachedData3;
		list.Add(item3);
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Text_Second_Text", null);
		RewardExploreTargetReachedData rewardExploreTargetReachedData4 = new RewardExploreTargetReachedData();
		num2 = 1;
		List<string> list5 = new List<string>(num2);
		CollectionsMarshal.SetCount<string>(list5, num2);
		span = CollectionsMarshal.AsSpan<string>(list5);
		num = 0;
		*span[num] = bossRushResultNotify.LeftTime.ToString() + localTextNew;
		rewardExploreTargetReachedData4.Target = list5;
		rewardExploreTargetReachedData4.DescriptionTextId = "BossRushLeftTimeTips";
		rewardExploreTargetReachedData4.IsReached = false;
		RewardExploreTargetReachedData item4 = rewardExploreTargetReachedData4;
		list.Add(item4);
		reachTargetData.TargetReached = list;
		int num3 = bossRushResultNotify.KilMonsterScore + bossRushResultNotify.TimerScore + bossRushResultNotify.TechnicalScore;
		bool ifNewRecord = num3 > bossRushResultNotify.HighScore;
		reachTargetData.IfNewRecord = ifNewRecord;
		reachTargetData.FullScore = num3;
		rewardData.SetScoreReached(reachTargetData);
		ItemRewardController.Instance.Open<IExploreRewardInfo>(rewardData, null);
		TowerController.Instance.ClearAllHatredInTower();
	}

	// Token: 0x06007873 RID: 30835 RVA: 0x001941A4 File Offset: 0x001923A4
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private unsafe RewardData<IExploreRewardInfo> CreateExploreData(int configId, bool isSuccess, [Nullable(2)] Action onCloseCallback, BossRushResultNotify notify)
	{
		List<IRewardExploreConfirmButton> list = new List<IRewardExploreConfirmButton>();
		List<IRewardExploreConfirmButton> list2 = list;
		RewardExploreConfirmButtonData rewardExploreConfirmButtonData = new RewardExploreConfirmButtonData();
		rewardExploreConfirmButtonData.ButtonTextId = "Text_ButtonTextConfirmResult_Text";
		rewardExploreConfirmButtonData.DescriptionTextId = null;
		rewardExploreConfirmButtonData.IsTimeDownCloseView = true;
		rewardExploreConfirmButtonData.IsClickedCloseView = false;
		rewardExploreConfirmButtonData.OnClickedCallback = delegate(int _)
		{
			BossRushController.Instance.OpenDefaultBossRushView();
		};
		list2.Add(rewardExploreConfirmButtonData);
		bool flag = notify.HighScore > 0;
		List<IRewardExploreConfirmButton> list3 = list;
		RewardExploreConfirmButtonData rewardExploreConfirmButtonData2 = new RewardExploreConfirmButtonData();
		rewardExploreConfirmButtonData2.ButtonTextId = "Text_ButtonTextChallengeOneMore_Text";
		rewardExploreConfirmButtonData2.DescriptionTextId = (flag ? "BossRushCurrentHighScore" : null);
		int num = 1;
		List<object> list4 = new List<object>(num);
		CollectionsMarshal.SetCount<object>(list4, num);
		Span<object> span = CollectionsMarshal.AsSpan<object>(list4);
		int index = 0;
		*span[index] = notify.HighScore;
		rewardExploreConfirmButtonData2.DescriptionArgs = list4;
		rewardExploreConfirmButtonData2.IsTimeDownCloseView = false;
		rewardExploreConfirmButtonData2.IsClickedCloseView = false;
		rewardExploreConfirmButtonData2.OnClickedCallback = delegate(int _)
		{
			BossRushData bossRushData = ActivityModel.Instance.GetActivityById(notify.ActivityId) as BossRushData;
			if (bossRushData == null)
			{
				return;
			}
			BossRushLevelDetailInfo bossRushLevelDetailInfoById = bossRushData.GetBossRushLevelDetailInfoById(notify.InstId);
			if (bossRushLevelDetailInfoById == null)
			{
				return;
			}
			BossRushController.Instance.RequestStartBossRushByTeamData(bossRushLevelDetailInfoById.ConvertToTeamInfo());
		};
		list3.Add(rewardExploreConfirmButtonData2);
		ItemRewardModel.Instance.ClearCurrentRewardData();
		return ItemRewardModel.Instance.RefreshExploreRewardDataFromConfig(configId, isSuccess, null, null, null, list, null, null, onCloseCallback, null, null, null, null, null, null, null);
	}

	// Token: 0x06007874 RID: 30836 RVA: 0x001942DC File Offset: 0x001924DC
	public void RequestStartBossRushByTeamData(BossRushTeamInfo data)
	{
		List<BuffSelection> list = new List<BuffSelection>();
		foreach (BossRushBuffInfo bossRushBuffInfo in data.GetPrepareSelectBuff())
		{
			BuffSelection buffSelection = BuffSelection.Create();
			buffSelection.BuffId = bossRushBuffInfo.BuffId;
			buffSelection.Slot = bossRushBuffInfo.Slot;
			buffSelection.BuffSelectionStatus = bossRushBuffInfo.State;
			list.Add(buffSelection);
		}
		List<int> list2 = new List<int>();
		foreach (BossRushBuffInfo bossRushBuffInfo2 in data.GetPrepareSelectScoreBuff())
		{
			if (bossRushBuffInfo2.BuffId > 0)
			{
				list2.Add(bossRushBuffInfo2.BuffId);
			}
		}
		List<int> list3 = new List<int>();
		foreach (int item in data.GetCurrentTeamMembers())
		{
			list3.Add(item);
		}
		int activityId = data.ActivityId;
		BossRushController.Instance.RequestStartBossRush(activityId, data.GetCurrentSelectLevel().GetInstanceDungeonId(), list.ToArray(), list2.ToArray(), list3.ToArray());
	}

	// Token: 0x06007875 RID: 30837 RVA: 0x00194424 File Offset: 0x00192624
	public void RequestBossRushTaskReward(int activityId)
	{
		BossRushBatchClaimRewardRequest bossRushBatchClaimRewardRequest = BossRushBatchClaimRewardRequest.Create();
		bossRushBatchClaimRewardRequest.ActivityId = activityId;
		BossRushData bossRushData = ActivityModel.Instance.GetActivityById(activityId) as BossRushData;
		if (bossRushData == null)
		{
			return;
		}
		bossRushBatchClaimRewardRequest.TaskRewardIds.AddRange(bossRushData.GetFinishAndUnclaimedTaskList());
		Net.Instance.Call(ERequestMessageId.BossRushBatchClaimRewardRequest, bossRushBatchClaimRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BossRushBatchClaimRewardResponse bossRushBatchClaimRewardResponse = (BossRushBatchClaimRewardResponse)msg;
			if (bossRushBatchClaimRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(bossRushBatchClaimRewardResponse.ErrorCode, 23711, null, true, true);
			}
			EventSystem.Instance.Emit<int>(EEventName.BossRefreshBossRushRewardRedDot, activityId);
			EventSystem.Instance.Emit(EEventName.BossRefreshBossRushReward);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}, 0);
	}

	// Token: 0x06007876 RID: 30838 RVA: 0x00194498 File Offset: 0x00192698
	public void RequestStartBossRush(int id, int instanceDungeonId, BuffSelection[] buff, int[] scoreBuff, int[] role)
	{
		if (this.LastRequestBossRushTime != 0f && Time.Instance.Now - (double)this.LastRequestBossRushTime <= 1000.0)
		{
			return;
		}
		this.LastRequestBossRushTime = (float)Time.Instance.Now;
		List<BuffSelection> list = new List<BuffSelection>();
		List<BossRushBuffInfo> currentSelectBuff = BossRushModel.Instance.GetBossRushTeamInfoByActivityId(id).GetCurrentSelectBuff();
		foreach (BuffSelection buffSelection in buff)
		{
			if (buffSelection.BuffSelectionStatus != BossRushBuffSelectionStatus.BuffEmpty)
			{
				list.Add(buffSelection);
			}
			else
			{
				BuffSelection buffSelection2 = BuffSelection.Create();
				buffSelection2.BuffId = buffSelection.BuffId;
				buffSelection2.Slot = buffSelection.Slot;
				buffSelection2.BuffSelectionStatus = ((buffSelection.BuffId == 0) ? BossRushBuffSelectionStatus.BuffEmpty : BossRushBuffSelectionStatus.BuffSelected);
				list.Add(buffSelection2);
			}
		}
		foreach (BossRushBuffInfo bossRushBuffInfo in currentSelectBuff)
		{
			if (bossRushBuffInfo.State == BossRushBuffSelectionStatus.BuffInactive)
			{
				BuffSelection buffSelection3 = BuffSelection.Create();
				buffSelection3.BuffId = bossRushBuffInfo.BuffId;
				buffSelection3.Slot = bossRushBuffInfo.Slot;
				buffSelection3.BuffSelectionStatus = BossRushBuffSelectionStatus.BuffInactive;
				list.Add(buffSelection3);
			}
		}
		BossRushActivity? bossRushByActivityIdAndInstanceId = BossRushConfig.Instance.GetBossRushByActivityIdAndInstanceId(id, instanceDungeonId);
		BossRushCtx bossRushCtx = BossRushCtx.Create();
		bossRushCtx.ActivityId = id;
		bossRushCtx.Id = ((bossRushByActivityIdAndInstanceId != null) ? bossRushByActivityIdAndInstanceId.GetValueOrDefault().Id : 0);
		bossRushCtx.BuffSelections.AddRange(list);
		bossRushCtx.ScoreBuff.AddRange(scoreBuff);
		InstanceDungeonModel.Instance.InstanceEnterContentText.BossRushCtx = bossRushCtx;
		InstanceDungeonController.Instance.PrewarTeamFightRequest(instanceDungeonId, role.ToList<int>(), 0, 0, null, null);
	}

	// Token: 0x06007877 RID: 30839 RVA: 0x0019465C File Offset: 0x0019285C
	public void RequestSettlement()
	{
		BossRushSettlementRequest message = BossRushSettlementRequest.Create();
		Net.Instance.Call(ERequestMessageId.BossRushSettlementRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BossRushSettlementResponse bossRushSettlementResponse = (BossRushSettlementResponse)msg;
			if (bossRushSettlementResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(bossRushSettlementResponse.ErrorCode, 15915, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06007878 RID: 30840 RVA: 0x001946A0 File Offset: 0x001928A0
	public void RequestGetBossRushReward(int activityId, int rewardId, BossRushRewardType type)
	{
		BossRushClaimRewardRequest bossRushClaimRewardRequest = BossRushClaimRewardRequest.Create();
		bossRushClaimRewardRequest.ActivityId = activityId;
		bossRushClaimRewardRequest.RewardId = rewardId;
		bossRushClaimRewardRequest.RewardType = type;
		Net.Instance.Call(ERequestMessageId.BossRushClaimRewardRequest, bossRushClaimRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BossRushClaimRewardResponse bossRushClaimRewardResponse = (BossRushClaimRewardResponse)msg;
			if (bossRushClaimRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(bossRushClaimRewardResponse.ErrorCode, 20167, null, true, true);
			}
			EventSystem.Instance.Emit<int>(EEventName.BossRefreshBossRushRewardRedDot, activityId);
			EventSystem.Instance.Emit(EEventName.BossRefreshBossRushReward);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}, 0);
	}

	// Token: 0x06007879 RID: 30841 RVA: 0x001946F8 File Offset: 0x001928F8
	public void RequestGetBossRushLevelReward(int activityId, int configId, int levelId, int index)
	{
		BossRushLevelScoreRewardRequest bossRushLevelScoreRewardRequest = BossRushLevelScoreRewardRequest.Create();
		bossRushLevelScoreRewardRequest.BossRushActivityId = configId;
		bossRushLevelScoreRewardRequest.Index = index;
		Net.Instance.Call(ERequestMessageId.BossRushLevelScoreRewardRequest, bossRushLevelScoreRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BossRushLevelScoreRewardResponse bossRushLevelScoreRewardResponse = (BossRushLevelScoreRewardResponse)msg;
			if (bossRushLevelScoreRewardResponse.Error != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(bossRushLevelScoreRewardResponse.Error, 20167, null, true, true);
			}
			BossRushData bossRushData = ActivityModel.Instance.GetActivityById(activityId) as BossRushData;
			if (bossRushData == null)
			{
				return;
			}
			bossRushData.SetRewardStateClaimed(levelId, index);
			EventSystem.Instance.Emit<int>(EEventName.BossRefreshBossRushRewardRedDot, activityId);
			EventSystem.Instance.Emit(EEventName.BossRefreshBossRushReward);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}, 0);
	}

	// Token: 0x0600787A RID: 30842 RVA: 0x00194758 File Offset: 0x00192958
	[NullableContext(0)]
	public UniTask<bool> OpenDefaultBossRushView()
	{
		BossRushController.<OpenDefaultBossRushView>d__27 <OpenDefaultBossRushView>d__;
		<OpenDefaultBossRushView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenDefaultBossRushView>d__.<>1__state = -1;
		<OpenDefaultBossRushView>d__.<>t__builder.Start<BossRushController.<OpenDefaultBossRushView>d__27>(ref <OpenDefaultBossRushView>d__);
		return <OpenDefaultBossRushView>d__.<>t__builder.Task;
	}

	// Token: 0x0600787B RID: 30843 RVA: 0x00194794 File Offset: 0x00192994
	[NullableContext(0)]
	public UniTask<bool> OpenBossRushView(int activityId)
	{
		BossRushController.<OpenBossRushView>d__28 <OpenBossRushView>d__;
		<OpenBossRushView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenBossRushView>d__.activityId = activityId;
		<OpenBossRushView>d__.<>1__state = -1;
		<OpenBossRushView>d__.<>t__builder.Start<BossRushController.<OpenBossRushView>d__28>(ref <OpenBossRushView>d__);
		return <OpenBossRushView>d__.<>t__builder.Task;
	}

	// Token: 0x0600787C RID: 30844 RVA: 0x001947D8 File Offset: 0x001929D8
	[NullableContext(0)]
	public UniTask<bool> RefreshBossRushBuffInGame()
	{
		BossRushController.<RefreshBossRushBuffInGame>d__29 <RefreshBossRushBuffInGame>d__;
		<RefreshBossRushBuffInGame>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RefreshBossRushBuffInGame>d__.<>1__state = -1;
		<RefreshBossRushBuffInGame>d__.<>t__builder.Start<BossRushController.<RefreshBossRushBuffInGame>d__29>(ref <RefreshBossRushBuffInGame>d__);
		return <RefreshBossRushBuffInGame>d__.<>t__builder.Task;
	}

	// Token: 0x0600787D RID: 30845 RVA: 0x00194814 File Offset: 0x00192A14
	[NullableContext(0)]
	public UniTask<bool> RequestBossRushChooseBuffInGame(int index)
	{
		BossRushController.<RequestBossRushChooseBuffInGame>d__30 <RequestBossRushChooseBuffInGame>d__;
		<RequestBossRushChooseBuffInGame>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestBossRushChooseBuffInGame>d__.index = index;
		<RequestBossRushChooseBuffInGame>d__.<>1__state = -1;
		<RequestBossRushChooseBuffInGame>d__.<>t__builder.Start<BossRushController.<RequestBossRushChooseBuffInGame>d__30>(ref <RequestBossRushChooseBuffInGame>d__);
		return <RequestBossRushChooseBuffInGame>d__.<>t__builder.Task;
	}

	// Token: 0x17000A4C RID: 2636
	// (get) Token: 0x0600787E RID: 30846 RVA: 0x00194857 File Offset: 0x00192A57
	public static BossRushController Instance
	{
		get
		{
			return BossRushController._Instance;
		}
	}

	// Token: 0x0600787F RID: 30847 RVA: 0x0019485E File Offset: 0x00192A5E
	public static BossRushController GetOrCreateInstance()
	{
		if (BossRushController._Instance == null)
		{
			BossRushController.CreateInstance();
		}
		return BossRushController._Instance;
	}

	// Token: 0x06007880 RID: 30848 RVA: 0x00194872 File Offset: 0x00192A72
	public static bool CreateInstance()
	{
		if (BossRushController._Instance != null)
		{
			return true;
		}
		BossRushController._Instance = new BossRushController();
		return true;
	}

	// Token: 0x06007881 RID: 30849 RVA: 0x00194888 File Offset: 0x00192A88
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007882 RID: 30850 RVA: 0x0019488A File Offset: 0x00192A8A
	public static void ResetStaticDefaultValue()
	{
		BossRushController._Instance = null;
	}

	// Token: 0x06007883 RID: 30851 RVA: 0x00194892 File Offset: 0x00192A92
	static BossRushController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BossRushController.CreateStaticDefaultValue), new Action(BossRushController.ResetStaticDefaultValue));
	}

	// Token: 0x04003763 RID: 14179
	private const int SENDCD = 1000;

	// Token: 0x04003764 RID: 14180
	private float LastRequestBossRushTime;

	// Token: 0x04003765 RID: 14181
	[Nullable(2)]
	private static BossRushController _Instance;
}

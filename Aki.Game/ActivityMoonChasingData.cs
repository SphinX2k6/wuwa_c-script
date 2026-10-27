using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;

// Token: 0x020012E8 RID: 4840
[NullableContext(1)]
[Nullable(0)]
public class ActivityMoonChasingData : ActivityBaseData
{
	// Token: 0x060085A8 RID: 34216 RVA: 0x001C7628 File Offset: 0x001C5828
	protected override void PhraseEx(ActivityData data)
	{
		this.LimitTimeRewardOn = false;
		this.PermanentTargetOn = false;
		this.ActivityFlowState = EMoonChasingActivityFlow.Activity;
		TrackMoonActivity? activityMoonChasingConfig = ActivityMoonChasingConfig.Instance.GetActivityMoonChasingConfig(base.Id);
		if (activityMoonChasingConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[ActivityMoonChasing] 活动配置不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", base.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		TrackMoonActivity value = activityMoonChasingConfig.Value;
		this.LimitTimeRewardOn = value.ActivityReward;
		this.PermanentTargetOn = value.PermanentTarget;
		this.ActivityFlowState = ((value.ActivityButtonType == 0) ? EMoonChasingActivityFlow.Activity : EMoonChasingActivityFlow.Close);
		this.LimitTimeRewardState.Clear();
		Aki.Protocol.ActivityTaskData trackMoonActivityTaskData = data.TrackMoonActivityTaskData;
		if (trackMoonActivityTaskData == null)
		{
			return;
		}
		foreach (ActivityTask activityTask in trackMoonActivityTaskData.ActivityTasks)
		{
			this.LimitTimeRewardState[activityTask.Id] = TaskStateResolver.TaskState[activityTask.Status];
		}
		if (!this.LimitTimeRewardOn)
		{
			return;
		}
		this.RefreshRewardPopView();
	}

	// Token: 0x060085A9 RID: 34217 RVA: 0x001C7758 File Offset: 0x001C5958
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x060085AA RID: 34218 RVA: 0x001C775B File Offset: 0x001C595B
	public override bool GetExDataRedPointShowState()
	{
		if (this.ActivityFlowState == EMoonChasingActivityFlow.Close)
		{
			return this.IsHasMoonChasingRedDot();
		}
		return this.IsHasLimitTimeReward() || this.IsHasPermanentReward() || this.IsHasHandbookReward() || this.IsHasMoonChasingRedDot();
	}

	// Token: 0x060085AB RID: 34219 RVA: 0x001C7790 File Offset: 0x001C5990
	public bool IsPreStageQuestFinished()
	{
		TrackMoonActivity? activityMoonChasingConfig = ActivityMoonChasingConfig.Instance.GetActivityMoonChasingConfig(base.Id);
		if (activityMoonChasingConfig == null)
		{
			return true;
		}
		int stageQuestId = activityMoonChasingConfig.Value.StageQuestId;
		return stageQuestId == 0 || QuestNewModel.Instance.CheckQuestFinished(stageQuestId);
	}

	// Token: 0x060085AC RID: 34220 RVA: 0x001C77DC File Offset: 0x001C59DC
	public int? GetPreStageQuestId()
	{
		global::Quest firstShowQuestByType = QuestNewModel.Instance.GetFirstShowQuestByType(1);
		if (firstShowQuestByType != null)
		{
			return new int?(firstShowQuestByType.Id);
		}
		return null;
	}

	// Token: 0x060085AD RID: 34221 RVA: 0x001C7810 File Offset: 0x001C5A10
	[NullableContext(2)]
	public unsafe IActivityRewardViewData GetAllRewardData()
	{
		List<IActivityRewardData> list = new List<IActivityRewardData>();
		foreach (KeyValuePair<int, EActivityTaskState> keyValuePair in this.LimitTimeRewardState)
		{
			IActivityRewardData rewardStateInfo = this.GetRewardStateInfo(keyValuePair.Key, keyValuePair.Value);
			if (rewardStateInfo != null)
			{
				list.Add(rewardStateInfo);
			}
		}
		if (list.Count == 0)
		{
			return null;
		}
		list.Sort(new Comparison<IActivityRewardData>(this.SortReward));
		ActivityRewardDataPage activityRewardDataPage = new ActivityRewardDataPage
		{
			DataList = list
		};
		ActivityRewardViewData activityRewardViewData = new ActivityRewardViewData();
		int num = 1;
		List<IActivityRewardDataPage> list2 = new List<IActivityRewardDataPage>(num);
		CollectionsMarshal.SetCount<IActivityRewardDataPage>(list2, num);
		Span<IActivityRewardDataPage> span = CollectionsMarshal.AsSpan<IActivityRewardDataPage>(list2);
		int index = 0;
		*span[index] = activityRewardDataPage;
		activityRewardViewData.DataPageList = list2;
		activityRewardViewData.Source = EActivityRewardSource.MoonChasing;
		return activityRewardViewData;
	}

	// Token: 0x060085AE RID: 34222 RVA: 0x001C78EC File Offset: 0x001C5AEC
	[NullableContext(2)]
	private IActivityRewardData GetRewardStateInfo(int id, EActivityTaskState state)
	{
		TrackMoonActivityReward? activityMoonChasingRewardConfigById = ActivityMoonChasingConfig.Instance.GetActivityMoonChasingRewardConfigById(id);
		if (activityMoonChasingRewardConfigById == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[ActivityMoonChasing] 活动限时奖励配置无配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RewardId", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		TrackMoonActivityReward rewardInfoVal = activityMoonChasingRewardConfigById.Value;
		EActivityRewardState rewardState = EActivityRewardState.Disabled;
		string text = "";
		Action clickFunction = null;
		bool value = false;
		bool value2 = false;
		switch (state)
		{
		case EActivityTaskState.FinishedAndUnclaimed:
			rewardState = EActivityRewardState.Enable;
			text = "Moonfiesta_AwardGet";
			value = true;
			clickFunction = delegate()
			{
				ActivityMoonChasingController.Instance.TrackMoonActivityTargetRewardRequest(this.Id, rewardInfoVal.Id);
			};
			break;
		case EActivityTaskState.Active:
			if (rewardInfoVal.TargetFunc != 0)
			{
				int targetFunc = rewardInfoVal.TargetFunc;
				clickFunction = delegate()
				{
					SkipTaskManager.RunByConfigId(targetFunc, null);
				};
				rewardState = EActivityRewardState.Enable;
				text = "Moonfiesta_Skip";
				value2 = true;
			}
			else
			{
				rewardState = EActivityRewardState.Disabled;
				text = "Moonfiesta_Underway";
			}
			break;
		case EActivityTaskState.FinishedAndClaimed:
			rewardState = EActivityRewardState.Claimed;
			break;
		}
		if (!StringUtils.IsEmpty(text))
		{
			text = ConfigMultiTextLang.GetLocalTextNew(text, null);
		}
		return new ActivityRewardData
		{
			Id = new int?(rewardInfoVal.Id),
			NameText = ConfigMultiTextLang.GetLocalTextNew(rewardInfoVal.TargetName, null),
			RewardList = base.GetPreviewReward(new int?(rewardInfoVal.TargetReward)).ToArray(),
			RewardState = rewardState,
			RewardButtonText = text,
			RewardButtonRedDot = new bool?(value),
			ClickFunction = clickFunction,
			ClickFunctionAndCloseSelf = new bool?(value2)
		};
	}

	// Token: 0x060085AF RID: 34223 RVA: 0x001C7A78 File Offset: 0x001C5C78
	private int SortReward(IActivityRewardData a, IActivityRewardData b)
	{
		EActivityTaskState eactivityTaskState = this.LimitTimeRewardState[a.Id.Value];
		EActivityTaskState eactivityTaskState2 = this.LimitTimeRewardState[b.Id.Value];
		if (eactivityTaskState == eactivityTaskState2)
		{
			return a.Id.Value - b.Id.Value;
		}
		return eactivityTaskState - eactivityTaskState2;
	}

	// Token: 0x060085B0 RID: 34224 RVA: 0x001C7ADE File Offset: 0x001C5CDE
	public void SetRewardState(int id, EActivityTaskState state)
	{
		if (!this.LimitTimeRewardState.ContainsKey(id))
		{
			return;
		}
		this.LimitTimeRewardState[id] = state;
		this.RefreshRewardPopView();
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x060085B1 RID: 34225 RVA: 0x001C7B18 File Offset: 0x001C5D18
	public bool IsHasLimitTimeReward()
	{
		if (!this.LimitTimeRewardOn)
		{
			return false;
		}
		using (Dictionary<int, EActivityTaskState>.ValueCollection.Enumerator enumerator = this.LimitTimeRewardState.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == EActivityTaskState.FinishedAndUnclaimed)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060085B2 RID: 34226 RVA: 0x001C7B7C File Offset: 0x001C5D7C
	private void RefreshRewardPopView()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.ActivityRewardPopUpView))
		{
			IActivityRewardViewData allRewardData = this.GetAllRewardData();
			if (allRewardData != null)
			{
				EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, allRewardData);
			}
		}
	}

	// Token: 0x060085B3 RID: 34227 RVA: 0x001C7BB5 File Offset: 0x001C5DB5
	private bool IsHasPermanentReward()
	{
		return base.IsUnLock() && base.GetPreGuideQuestFinishState() && (MoonChasingRewardModel.Instance.GetAllTaskDataRedDotState(true) || MoonChasingRewardModel.Instance.GetShopRedDotState());
	}

	// Token: 0x060085B4 RID: 34228 RVA: 0x001C7BE2 File Offset: 0x001C5DE2
	private bool IsHasHandbookReward()
	{
		return MoonChasingModel.Instance.HasHandbookRewardRedDot();
	}

	// Token: 0x060085B5 RID: 34229 RVA: 0x001C7BF0 File Offset: 0x001C5DF0
	public bool IsHasMoonChasingRedDot()
	{
		if (!base.IsUnLock() || !base.GetPreGuideQuestFinishState())
		{
			return false;
		}
		if (this.ActivityFlowState == EMoonChasingActivityFlow.Close)
		{
			return MoonChasingModel.Instance.CheckMemoryRedDotState();
		}
		if (MoonChasingBuildingModel.Instance.CheckAllBuildingRedDotState())
		{
			return true;
		}
		MoonChasingModel instance = MoonChasingModel.Instance;
		return instance != null && instance.CheckQuestRedDotState();
	}

	// Token: 0x04003BF7 RID: 15351
	public bool LimitTimeRewardOn;

	// Token: 0x04003BF8 RID: 15352
	private readonly Dictionary<int, EActivityTaskState> LimitTimeRewardState = new Dictionary<int, EActivityTaskState>();

	// Token: 0x04003BF9 RID: 15353
	public bool PermanentTargetOn;

	// Token: 0x04003BFA RID: 15354
	public EMoonChasingActivityFlow ActivityFlowState;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;

// Token: 0x0200079C RID: 1948
[NullableContext(1)]
[Nullable(0)]
public class ActivityMoonChasingData : ActivityBaseData
{
	// Token: 0x06005943 RID: 22851 RVA: 0x001D0494 File Offset: 0x001CE694
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

	// Token: 0x06005944 RID: 22852 RVA: 0x001D05C4 File Offset: 0x001CE7C4
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x06005945 RID: 22853 RVA: 0x001D05C7 File Offset: 0x001CE7C7
	public override bool GetExDataRedPointShowState()
	{
		if (this.ActivityFlowState == EMoonChasingActivityFlow.Close)
		{
			return this.IsHasMoonChasingRedDot();
		}
		return this.IsHasLimitTimeReward() || this.IsHasPermanentReward() || this.IsHasHandbookReward() || this.IsHasMoonChasingRedDot();
	}

	// Token: 0x06005946 RID: 22854 RVA: 0x001D05FC File Offset: 0x001CE7FC
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

	// Token: 0x06005947 RID: 22855 RVA: 0x001D0648 File Offset: 0x001CE848
	public int? GetPreStageQuestId()
	{
		global::Quest firstShowQuestByType = QuestNewModel.Instance.GetFirstShowQuestByType(1);
		if (firstShowQuestByType != null)
		{
			return new int?(firstShowQuestByType.Id);
		}
		return null;
	}

	// Token: 0x06005948 RID: 22856 RVA: 0x001D067C File Offset: 0x001CE87C
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

	// Token: 0x06005949 RID: 22857 RVA: 0x001D0758 File Offset: 0x001CE958
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

	// Token: 0x0600594A RID: 22858 RVA: 0x001D08E4 File Offset: 0x001CEAE4
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

	// Token: 0x0600594B RID: 22859 RVA: 0x001D094A File Offset: 0x001CEB4A
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

	// Token: 0x0600594C RID: 22860 RVA: 0x001D0984 File Offset: 0x001CEB84
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

	// Token: 0x0600594D RID: 22861 RVA: 0x001D09E8 File Offset: 0x001CEBE8
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

	// Token: 0x0600594E RID: 22862 RVA: 0x001D0A21 File Offset: 0x001CEC21
	private bool IsHasPermanentReward()
	{
		return base.IsUnLock() && base.GetPreGuideQuestFinishState() && (MoonChasingRewardModel.Instance.GetAllTaskDataRedDotState(true) || MoonChasingRewardModel.Instance.GetShopRedDotState());
	}

	// Token: 0x0600594F RID: 22863 RVA: 0x001D0A4E File Offset: 0x001CEC4E
	private bool IsHasHandbookReward()
	{
		return MoonChasingModel.Instance.HasHandbookRewardRedDot();
	}

	// Token: 0x06005950 RID: 22864 RVA: 0x001D0A5C File Offset: 0x001CEC5C
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

	// Token: 0x04003C8F RID: 15503
	public bool LimitTimeRewardOn;

	// Token: 0x04003C90 RID: 15504
	private readonly Dictionary<int, EActivityTaskState> LimitTimeRewardState = new Dictionary<int, EActivityTaskState>();

	// Token: 0x04003C91 RID: 15505
	public bool PermanentTargetOn;

	// Token: 0x04003C92 RID: 15506
	public EMoonChasingActivityFlow ActivityFlowState;
}

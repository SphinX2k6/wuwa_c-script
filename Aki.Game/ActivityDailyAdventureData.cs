using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x0200120C RID: 4620
[NullableContext(1)]
[Nullable(0)]
public class ActivityDailyAdventureData : ActivityBaseData
{
	// Token: 0x06007BBF RID: 31679 RVA: 0x001A18B4 File Offset: 0x0019FAB4
	public void SetProgressPoint(int pt)
	{
		this.ProgressPoint = pt;
		foreach (DailyAdventureRewardData dailyAdventureRewardData in this.PointRewardMap.Values)
		{
			dailyAdventureRewardData.RefreshState(dailyAdventureRewardData.RewardState == ERewardState.FinishedAndClaimed, new int?(this.ProgressPoint));
		}
	}

	// Token: 0x06007BC0 RID: 31680 RVA: 0x001A1924 File Offset: 0x0019FB24
	protected unsafe override void PhraseEx(ActivityData data)
	{
		DailyAdventureActivity? activityDailyAdventureConfig = ActivityDailyAdventureConfig.Instance.GetActivityDailyAdventureConfig(base.Id);
		if (activityDailyAdventureConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[日常探险活动] 活动数据未找到";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId", base.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.CreatePointRewardMap(activityDailyAdventureConfig.Value.GetRewardListArray().ToList<int>());
		DailyAdventureActivityData dailyAdventureActivityData = data.DailyAdventureActivityData;
		if (dailyAdventureActivityData == null)
		{
			return;
		}
		this.ProgressPoint = InventoryModel.Instance.GetItemCountByConfigId(13, 0);
		this.TaskInfoMap.Clear();
		foreach (DailyAdventureActivityTask dailyAdventureActivityTask in dailyAdventureActivityData.DailyAdventureActivityTasks)
		{
			DailyAdventureTaskData dailyAdventureTaskData = new DailyAdventureTaskData();
			dailyAdventureTaskData.TaskId = dailyAdventureActivityTask.Id;
			dailyAdventureTaskData.CurrentProgress = dailyAdventureActivityTask.Current;
			dailyAdventureTaskData.TargetProgress = dailyAdventureActivityTask.Target;
			dailyAdventureTaskData.TaskState = ActivityDailyAdventureDefine.RewardStateResolver[dailyAdventureActivityTask.Status];
			this.TaskInfoMap[dailyAdventureActivityTask.Id] = dailyAdventureTaskData;
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Activity;
			ELogAuthor author2 = ELogAuthor.YYZ;
			string message2 = "[日常探险活动] 任务信息打印";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TaskId", dailyAdventureActivityTask.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("State", dailyAdventureTaskData.TaskState);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		foreach (DailyAdventureRewardData dailyAdventureRewardData in this.PointRewardMap.Values)
		{
			bool hasTaken = dailyAdventureActivityData.PtRewardTaken.Contains(dailyAdventureRewardData.RewardId);
			dailyAdventureRewardData.RefreshState(hasTaken, new int?(this.ProgressPoint));
		}
	}

	// Token: 0x06007BC1 RID: 31681 RVA: 0x001A1B3C File Offset: 0x0019FD3C
	private void CreatePointRewardMap(List<int> rewardIdList)
	{
		this.PointRewardMap.Clear();
		foreach (int num in rewardIdList)
		{
			DailyAdventurePoint? dailyAdventurePointConfig = ActivityDailyAdventureConfig.Instance.GetDailyAdventurePointConfig(num);
			if (dailyAdventurePointConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[日常探险活动] 积分奖励数据不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			DailyAdventureRewardData dailyAdventureRewardData = new DailyAdventureRewardData();
			dailyAdventureRewardData.RewardId = num;
			dailyAdventureRewardData.Point = dailyAdventurePointConfig.Value.NeedPt;
			this.PointRewardMap[num] = dailyAdventureRewardData;
		}
	}

	// Token: 0x06007BC2 RID: 31682 RVA: 0x001A1C08 File Offset: 0x0019FE08
	public List<DailyAdventureRewardData> GetAllPointReward()
	{
		return (from a in this.PointRewardMap.Values.ToList<DailyAdventureRewardData>()
		orderby a.RewardId
		select a).ToList<DailyAdventureRewardData>();
	}

	// Token: 0x06007BC3 RID: 31683 RVA: 0x001A1C44 File Offset: 0x0019FE44
	public List<DailyAdventureTaskData> GetAllTaskInfo()
	{
		return (from a in this.TaskInfoMap.Values.ToList<DailyAdventureTaskData>()
		orderby a.TaskState, a.TaskId
		select a).ToList<DailyAdventureTaskData>();
	}

	// Token: 0x06007BC4 RID: 31684 RVA: 0x001A1CB0 File Offset: 0x0019FEB0
	public void SetPointReward(int id, bool hasTaken)
	{
		DailyAdventureRewardData dailyAdventureRewardData;
		if (this.PointRewardMap.TryGetValue(id, out dailyAdventureRewardData))
		{
			dailyAdventureRewardData.RefreshState(hasTaken, new int?(this.ProgressPoint));
		}
	}

	// Token: 0x06007BC5 RID: 31685 RVA: 0x001A1CE0 File Offset: 0x0019FEE0
	public void SetTaskInfo(int id, ERewardState? state = null, int? currentProgress = null)
	{
		DailyAdventureTaskData dailyAdventureTaskData;
		if (this.TaskInfoMap.TryGetValue(id, out dailyAdventureTaskData))
		{
			if (state != null)
			{
				dailyAdventureTaskData.TaskState = state.Value;
			}
			if (currentProgress != null)
			{
				dailyAdventureTaskData.CurrentProgress = currentProgress.Value;
			}
		}
	}

	// Token: 0x06007BC6 RID: 31686 RVA: 0x001A1D2C File Offset: 0x0019FF2C
	public int GetDefaultMapMarkId()
	{
		DailyAdventureActivity? activityDailyAdventureConfig = ActivityDailyAdventureConfig.Instance.GetActivityDailyAdventureConfig(base.Id);
		if (activityDailyAdventureConfig == null)
		{
			return 0;
		}
		return activityDailyAdventureConfig.Value.AreaDefaultMarkId;
	}

	// Token: 0x06007BC7 RID: 31687 RVA: 0x001A1D64 File Offset: 0x0019FF64
	public override bool GetExDataRedPointShowState()
	{
		return !this.IsAllPointRewardFinished() && (this.IsTaskHasReward() || this.IsPointHasReward() || this.IsDailyTips());
	}

	// Token: 0x06007BC8 RID: 31688 RVA: 0x001A1D88 File Offset: 0x0019FF88
	protected override bool GetExDataFinishShowState()
	{
		return this.IsAllPointRewardFinished();
	}

	// Token: 0x06007BC9 RID: 31689 RVA: 0x001A1D90 File Offset: 0x0019FF90
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x06007BCA RID: 31690 RVA: 0x001A1D94 File Offset: 0x0019FF94
	public bool IsTaskHasReward()
	{
		using (Dictionary<int, DailyAdventureTaskData>.ValueCollection.Enumerator enumerator = this.TaskInfoMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.TaskState == ERewardState.FinishedAndUnClaimed)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06007BCB RID: 31691 RVA: 0x001A1DF4 File Offset: 0x0019FFF4
	public bool IsPointHasReward()
	{
		using (Dictionary<int, DailyAdventureRewardData>.ValueCollection.Enumerator enumerator = this.PointRewardMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.RewardState == ERewardState.FinishedAndUnClaimed)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06007BCC RID: 31692 RVA: 0x001A1E54 File Offset: 0x001A0054
	public bool IsDailyTips()
	{
		int num = (int)TimeUtil.Instance.GetCurrentCrossDayStamp();
		int activityCacheData = ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, 0, 0);
		return num != activityCacheData;
	}

	// Token: 0x06007BCD RID: 31693 RVA: 0x001A1E88 File Offset: 0x001A0088
	public void ReadDailyTips()
	{
		double currentCrossDayStamp = TimeUtil.Instance.GetCurrentCrossDayStamp();
		ActivityModel.Instance.SaveActivityData(base.Id, 1, 0, 0, (int)currentCrossDayStamp);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06007BCE RID: 31694 RVA: 0x001A1ECC File Offset: 0x001A00CC
	private bool IsAllPointRewardFinished()
	{
		using (Dictionary<int, DailyAdventureRewardData>.ValueCollection.Enumerator enumerator = this.PointRewardMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.RewardState != ERewardState.FinishedAndClaimed)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x040038A8 RID: 14504
	private const int DAILY_TIME_FLAG = 1;

	// Token: 0x040038A9 RID: 14505
	public int ProgressPoint;

	// Token: 0x040038AA RID: 14506
	private readonly Dictionary<int, DailyAdventureRewardData> PointRewardMap = new Dictionary<int, DailyAdventureRewardData>();

	// Token: 0x040038AB RID: 14507
	private readonly Dictionary<int, DailyAdventureTaskData> TaskInfoMap = new Dictionary<int, DailyAdventureTaskData>();
}

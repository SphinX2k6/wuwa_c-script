using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020006C0 RID: 1728
[NullableContext(1)]
[Nullable(0)]
public class ActivityDailyAdventureData : ActivityBaseData
{
	// Token: 0x06004F55 RID: 20309 RVA: 0x001AA56C File Offset: 0x001A876C
	public void SetProgressPoint(int pt)
	{
		this.ProgressPoint = pt;
		foreach (DailyAdventureRewardData dailyAdventureRewardData in this.PointRewardMap.Values)
		{
			dailyAdventureRewardData.RefreshState(dailyAdventureRewardData.RewardState == ERewardState.FinishedAndClaimed, new int?(this.ProgressPoint));
		}
	}

	// Token: 0x06004F56 RID: 20310 RVA: 0x001AA5DC File Offset: 0x001A87DC
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
		this.CreatePointRewardMap(activityDailyAdventureConfig.Value.GetRewardListArray());
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

	// Token: 0x06004F57 RID: 20311 RVA: 0x001AA7F0 File Offset: 0x001A89F0
	private void CreatePointRewardMap(IEnumerable<int> rewardIdList)
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

	// Token: 0x06004F58 RID: 20312 RVA: 0x001AA8B8 File Offset: 0x001A8AB8
	public List<DailyAdventureRewardData> GetAllPointReward()
	{
		List<DailyAdventureRewardData> list = new List<DailyAdventureRewardData>(this.PointRewardMap.Values);
		list.Sort((DailyAdventureRewardData a, DailyAdventureRewardData b) => a.RewardId.CompareTo(b.RewardId));
		return list;
	}

	// Token: 0x06004F59 RID: 20313 RVA: 0x001AA8EF File Offset: 0x001A8AEF
	public List<DailyAdventureTaskData> GetAllTaskInfo()
	{
		List<DailyAdventureTaskData> list = new List<DailyAdventureTaskData>(this.TaskInfoMap.Values);
		list.Sort(delegate(DailyAdventureTaskData a, DailyAdventureTaskData b)
		{
			int num = a.TaskState.CompareTo(b.TaskState);
			if (num == 0)
			{
				return a.TaskId.CompareTo(b.TaskId);
			}
			return num;
		});
		return list;
	}

	// Token: 0x06004F5A RID: 20314 RVA: 0x001AA928 File Offset: 0x001A8B28
	public void SetPointReward(int id, bool hasTaken)
	{
		DailyAdventureRewardData dailyAdventureRewardData;
		if (this.PointRewardMap.TryGetValue(id, out dailyAdventureRewardData))
		{
			dailyAdventureRewardData.RefreshState(hasTaken, new int?(this.ProgressPoint));
		}
	}

	// Token: 0x06004F5B RID: 20315 RVA: 0x001AA958 File Offset: 0x001A8B58
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

	// Token: 0x06004F5C RID: 20316 RVA: 0x001AA9A4 File Offset: 0x001A8BA4
	public int GetDefaultMapMarkId()
	{
		DailyAdventureActivity? activityDailyAdventureConfig = ActivityDailyAdventureConfig.Instance.GetActivityDailyAdventureConfig(base.Id);
		if (activityDailyAdventureConfig == null)
		{
			return 0;
		}
		return activityDailyAdventureConfig.Value.AreaDefaultMarkId;
	}

	// Token: 0x06004F5D RID: 20317 RVA: 0x001AA9DC File Offset: 0x001A8BDC
	public override bool GetExDataRedPointShowState()
	{
		return !this.IsAllPointRewardFinished() && (this.IsTaskHasReward() || this.IsPointHasReward() || this.IsDailyTips());
	}

	// Token: 0x06004F5E RID: 20318 RVA: 0x001AAA00 File Offset: 0x001A8C00
	protected override bool GetExDataFinishShowState()
	{
		return this.IsAllPointRewardFinished();
	}

	// Token: 0x06004F5F RID: 20319 RVA: 0x001AAA08 File Offset: 0x001A8C08
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x06004F60 RID: 20320 RVA: 0x001AAA0C File Offset: 0x001A8C0C
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

	// Token: 0x06004F61 RID: 20321 RVA: 0x001AAA6C File Offset: 0x001A8C6C
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

	// Token: 0x06004F62 RID: 20322 RVA: 0x001AAACC File Offset: 0x001A8CCC
	public bool IsDailyTips()
	{
		int num = (int)TimeUtil.Instance.GetCurrentCrossDayStamp();
		int activityCacheData = ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, 0, 0);
		return num != activityCacheData;
	}

	// Token: 0x06004F63 RID: 20323 RVA: 0x001AAB00 File Offset: 0x001A8D00
	public void ReadDailyTips()
	{
		double currentCrossDayStamp = TimeUtil.Instance.GetCurrentCrossDayStamp();
		ActivityModel.Instance.SaveActivityData(base.Id, 1, 0, 0, (int)currentCrossDayStamp);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06004F64 RID: 20324 RVA: 0x001AAB44 File Offset: 0x001A8D44
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

	// Token: 0x04003941 RID: 14657
	private const int DAILY_TIME_FLAG = 1;

	// Token: 0x04003942 RID: 14658
	public int ProgressPoint;

	// Token: 0x04003943 RID: 14659
	private readonly Dictionary<int, DailyAdventureRewardData> PointRewardMap = new Dictionary<int, DailyAdventureRewardData>();

	// Token: 0x04003944 RID: 14660
	private readonly Dictionary<int, DailyAdventureTaskData> TaskInfoMap = new Dictionary<int, DailyAdventureTaskData>();
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.LongShan;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.SkipInterface;
using Google.Protobuf.Collections;

// Token: 0x02000754 RID: 1876
[NullableContext(1)]
[Nullable(0)]
public class ActivityLongShanData : ActivityBaseData
{
	// Token: 0x06005649 RID: 22089 RVA: 0x001C4B6A File Offset: 0x001C2D6A
	protected override void OnInit(ActivityData data)
	{
		this.InitScoreReward();
	}

	// Token: 0x0600564A RID: 22090 RVA: 0x001C4B74 File Offset: 0x001C2D74
	protected unsafe override void PhraseEx(ActivityData data)
	{
		Dictionary<int, CSharpScript.Game.Module.Activity.ActivityContent.LongShan.LongShanStageInfo> stages = this.Stages;
		if (stages != null)
		{
			stages.Clear();
		}
		this.Stages = (this.Stages ?? new Dictionary<int, CSharpScript.Game.Module.Activity.ActivityContent.LongShan.LongShanStageInfo>());
		this.StageIds = Array.Empty<int>();
		IReadOnlyList<LongShanStage> configList = ConfigLongShanStageAll.GetConfigList(base.Id, true);
		if (configList != null)
		{
			List<int> list = new List<int>();
			foreach (LongShanStage longShanStage in configList)
			{
				list.Add(longShanStage.Id);
				Aki.Protocol.LongShanStageInfo longShanStageInfo = null;
				LongShanActivity longShanActivityData = data.LongShanActivityData;
				if (((longShanActivityData != null) ? longShanActivityData.Stages : null) != null)
				{
					foreach (Aki.Protocol.LongShanStageInfo longShanStageInfo2 in data.LongShanActivityData.Stages)
					{
						if (longShanStageInfo2.Id == longShanStage.Id)
						{
							longShanStageInfo = longShanStageInfo2;
							break;
						}
					}
				}
				if (longShanStageInfo != null)
				{
					CSharpScript.Game.Module.Activity.ActivityContent.LongShan.LongShanStageInfo value = new CSharpScript.Game.Module.Activity.ActivityContent.LongShan.LongShanStageInfo(longShanStageInfo);
					this.Stages[longShanStage.Id] = value;
				}
			}
			this.StageIds = list.ToArray();
		}
		LongShanActivity longShanActivityData2 = data.LongShanActivityData;
		RepeatedField<int> repeatedField = (longShanActivityData2 != null) ? longShanActivityData2.ScoreRewardedIds : null;
		if (repeatedField == null)
		{
			return;
		}
		foreach (int num in repeatedField)
		{
			LongShanScoreRewardData scoreRewardDataById = this.GetScoreRewardDataById(num);
			if (scoreRewardDataById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "[LongShanActivity] 奖励Id不存在";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActivityId", base.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RewardId", num);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			else
			{
				scoreRewardDataById.Achieved = true;
			}
		}
	}

	// Token: 0x0600564B RID: 22091 RVA: 0x001C4D84 File Offset: 0x001C2F84
	public void InitScoreReward()
	{
		this.ScoreRewards.Clear();
		this.ScoreRewardIds = Array.Empty<int>();
		IEnumerable<LongShanScoreReward> enumerable = ConfigLongShanScoreRewardByActivityId.GetConfigList(base.Id, true) ?? Array.Empty<LongShanScoreReward>();
		List<int> list = new List<int>();
		foreach (LongShanScoreReward longShanScoreReward in enumerable)
		{
			list.Add(longShanScoreReward.Id);
			LongShanScoreRewardData longShanScoreRewardData = new LongShanScoreRewardData();
			longShanScoreRewardData.Id = longShanScoreReward.Id;
			longShanScoreRewardData.Goal = longShanScoreReward.Score;
			longShanScoreRewardData.DropId = longShanScoreReward.DropId;
			longShanScoreRewardData.GetCurrentScore = new Func<int>(this.GetScoreItemCount);
			this.ScoreItemId = longShanScoreReward.ItemId;
			this.ScoreItemTotal = Math.Max(this.ScoreItemTotal, longShanScoreRewardData.Goal);
			this.ScoreRewards[longShanScoreReward.Id] = longShanScoreRewardData;
		}
		this.ScoreRewardIds = list.ToArray();
	}

	// Token: 0x0600564C RID: 22092 RVA: 0x001C4E8C File Offset: 0x001C308C
	public void UpdateStage(IReadOnlyList<Aki.Protocol.LongShanStageInfo> stageInfos)
	{
		foreach (Aki.Protocol.LongShanStageInfo longShanStageInfo in stageInfos)
		{
			CSharpScript.Game.Module.Activity.ActivityContent.LongShan.LongShanStageInfo longShanStageInfo2;
			if (this.Stages.TryGetValue(longShanStageInfo.Id, out longShanStageInfo2) && longShanStageInfo2 != null)
			{
				CSharpScript.Game.Module.Activity.ActivityContent.LongShan.LongShanStageInfo longShanStageInfo3 = new CSharpScript.Game.Module.Activity.ActivityContent.LongShan.LongShanStageInfo(longShanStageInfo);
				this.Stages[longShanStageInfo.Id] = longShanStageInfo3;
				this.OnStageInfoChange(longShanStageInfo2, longShanStageInfo3);
			}
		}
		EventSystem.Instance.Emit(EEventName.LongShanUpdate);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x0600564D RID: 22093 RVA: 0x001C4F2C File Offset: 0x001C312C
	public void OnStageInfoChange(CSharpScript.Game.Module.Activity.ActivityContent.LongShan.LongShanStageInfo oldStage, CSharpScript.Game.Module.Activity.ActivityContent.LongShan.LongShanStageInfo newStage)
	{
		foreach (KeyValuePair<int, LongShanTaskInfo> keyValuePair in oldStage.TaskInfoMap)
		{
			int key = keyValuePair.Key;
			LongShanTaskInfo value = keyValuePair.Value;
			LongShanTaskInfo newTask;
			if (newStage.TaskInfoMap.TryGetValue(key, out newTask))
			{
				this.OnStageTaskInfoChange(key, value, newTask);
			}
		}
	}

	// Token: 0x0600564E RID: 22094 RVA: 0x001C4FA4 File Offset: 0x001C31A4
	public void OnStageTaskInfoChange(int taskId, LongShanTaskInfo oldTask, LongShanTaskInfo newTask)
	{
		if (!oldTask.IsFinished && newTask.IsFinished)
		{
			int jumpId = ConfigLongShanTaskById.GetConfig(taskId, true).Value.JumpId;
			if (jumpId > 0)
			{
				AccessPath? accessPathConfig = SkipInterfaceConfig.Instance.GetAccessPathConfig(jumpId);
				if (accessPathConfig != null && accessPathConfig.Value.SkipName == 8)
				{
					int value = int.Parse(accessPathConfig.Value.Val1);
					MapModel.Instance.RemoveMapMarksByConfigId(new EMarkType?(EMarkType.Entity), new int?(value));
				}
			}
		}
	}

	// Token: 0x0600564F RID: 22095 RVA: 0x001C5034 File Offset: 0x001C3234
	public void UpdateScoreRewardStatus(IReadOnlyList<int> ids)
	{
		foreach (int id in ids)
		{
			LongShanScoreRewardData scoreRewardDataById = this.GetScoreRewardDataById(id);
			if (scoreRewardDataById != null)
			{
				scoreRewardDataById.Achieved = true;
			}
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06005650 RID: 22096 RVA: 0x001C50A0 File Offset: 0x001C32A0
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x06005651 RID: 22097 RVA: 0x001C50A4 File Offset: 0x001C32A4
	[NullableContext(2)]
	public Aki.Protocol.LongShanStageInfo GetStageInfoById(int id)
	{
		CSharpScript.Game.Module.Activity.ActivityContent.LongShan.LongShanStageInfo longShanStageInfo;
		if (this.Stages == null || !this.Stages.TryGetValue(id, out longShanStageInfo))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "龙山活动阶段数据为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("stageId", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		if (longShanStageInfo.ProtoStageInfo == null)
		{
			return null;
		}
		if (!longShanStageInfo.ProtoStageInfo.Unlock)
		{
			return null;
		}
		return longShanStageInfo.ProtoStageInfo;
	}

	// Token: 0x06005652 RID: 22098 RVA: 0x001C511C File Offset: 0x001C331C
	public Aki.Protocol.LongShanStageInfo GetStageInfoByIdIncludeLock(int id)
	{
		CSharpScript.Game.Module.Activity.ActivityContent.LongShan.LongShanStageInfo longShanStageInfo;
		if (this.Stages != null && this.Stages.TryGetValue(id, out longShanStageInfo) && longShanStageInfo != null && longShanStageInfo.ProtoStageInfo != null)
		{
			return longShanStageInfo.ProtoStageInfo;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Activity;
		ELogAuthor author = ELogAuthor.CXJ;
		string message = "龙山活动阶段数据为空";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("stageId", id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x06005653 RID: 22099 RVA: 0x001C5184 File Offset: 0x001C3384
	public List<int> GetFinishedAndUnclaimedTasksByStageId(int stageId)
	{
		Aki.Protocol.LongShanStageInfo stageInfoById = this.GetStageInfoById(stageId);
		if (stageInfoById == null)
		{
			return new List<int>();
		}
		List<int> list = new List<int>();
		foreach (LongShanTaskInfo longShanTaskInfo in stageInfoById.Tasks)
		{
			if (longShanTaskInfo.IsFinished && !longShanTaskInfo.IsTaken)
			{
				list.Add(longShanTaskInfo.Id);
			}
		}
		return list;
	}

	// Token: 0x06005654 RID: 22100 RVA: 0x001C5200 File Offset: 0x001C3400
	public int TaskSort(LongShanTaskInfo a, LongShanTaskInfo b)
	{
		if (a.IsTaken != b.IsTaken)
		{
			if (!a.IsTaken)
			{
				return -1;
			}
			return 1;
		}
		else if (a.IsFinished != b.IsFinished)
		{
			if (!a.IsFinished)
			{
				return 1;
			}
			return -1;
		}
		else
		{
			int sortId = ConfigLongShanTaskById.GetConfig(a.Id, true).Value.SortId;
			int sortId2 = ConfigLongShanTaskById.GetConfig(b.Id, true).Value.SortId;
			if (sortId != sortId2)
			{
				return sortId - sortId2;
			}
			return a.Id - b.Id;
		}
	}

	// Token: 0x06005655 RID: 22101 RVA: 0x001C5290 File Offset: 0x001C3490
	public int GetProgress(int id)
	{
		Aki.Protocol.LongShanStageInfo stageInfoById = this.GetStageInfoById(id);
		if (stageInfoById == null)
		{
			return 0;
		}
		int num = 0;
		if (stageInfoById.Tasks != null)
		{
			using (IEnumerator<LongShanTaskInfo> enumerator = stageInfoById.Tasks.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsTaken)
					{
						num++;
					}
				}
			}
		}
		return (int)Math.Ceiling((double)((float)num * 1f / (float)stageInfoById.Tasks.Count * 100f));
	}

	// Token: 0x06005656 RID: 22102 RVA: 0x001C531C File Offset: 0x001C351C
	public bool IsStageUnlock(int stageId)
	{
		bool flag = this.IsStageReachOpenTime(stageId);
		Aki.Protocol.LongShanStageInfo stageInfoByIdIncludeLock = this.GetStageInfoByIdIncludeLock(stageId);
		return stageInfoByIdIncludeLock != null && stageInfoByIdIncludeLock.Unlock && flag;
	}

	// Token: 0x06005657 RID: 22103 RVA: 0x001C5348 File Offset: 0x001C3548
	public bool IsStageReachOpenTime(int stageId)
	{
		Aki.Protocol.LongShanStageInfo stageInfoByIdIncludeLock = this.GetStageInfoByIdIncludeLock(stageId);
		if (stageInfoByIdIncludeLock == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "龙山活动阶段数据为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("stageId", stageId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		long beginOpenTime = stageInfoByIdIncludeLock.BeginOpenTime;
		return beginOpenTime == 0L || (double)beginOpenTime < serverTimeStamp;
	}

	// Token: 0x06005658 RID: 22104 RVA: 0x001C53B0 File Offset: 0x001C35B0
	public float GetScoreRewardRelativeProgress(int scoreRewardId)
	{
		List<LongShanScoreRewardData> allScoreRewardData = this.GetAllScoreRewardData();
		int num = allScoreRewardData.FindIndex((LongShanScoreRewardData data) => data.Id == scoreRewardId);
		int goal = allScoreRewardData[num].Goal;
		int num2 = num - 1;
		int num3 = 0;
		if (num2 >= 0)
		{
			num3 = allScoreRewardData[num2].Goal;
		}
		return (float)(this.GetScoreItemCount() - num3) / (float)(goal - num3);
	}

	// Token: 0x06005659 RID: 22105 RVA: 0x001C5420 File Offset: 0x001C3620
	public bool CheckStageRed(int id)
	{
		Aki.Protocol.LongShanStageInfo stageInfoById = this.GetStageInfoById(id);
		if (stageInfoById == null)
		{
			return false;
		}
		if (ActivityModel.Instance.GetActivityCacheData(base.Id, 0, id, 0, 0) == 0)
		{
			return true;
		}
		if (stageInfoById.Tasks != null)
		{
			foreach (LongShanTaskInfo longShanTaskInfo in stageInfoById.Tasks)
			{
				if (longShanTaskInfo.IsFinished && !longShanTaskInfo.IsTaken)
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x0600565A RID: 22106 RVA: 0x001C54AC File Offset: 0x001C36AC
	public void SaveNewStageFlag(int stageId)
	{
		ActivityModel.Instance.SaveActivityData(base.Id, stageId, 0, 0, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x0600565B RID: 22107 RVA: 0x001C54D8 File Offset: 0x001C36D8
	public bool CheckAnyStageRed()
	{
		if (this.StageIds != null)
		{
			foreach (int id in this.StageIds)
			{
				if (this.CheckStageRed(id))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600565C RID: 22108 RVA: 0x001C5512 File Offset: 0x001C3712
	public bool CheckScoreRewardRedDot()
	{
		return NoLinq.Any<LongShanScoreRewardData>(this.ScoreRewards.Values, (LongShanScoreRewardData data) => data.GetState() == EActivityTaskState.FinishedAndUnclaimed);
	}

	// Token: 0x0600565D RID: 22109 RVA: 0x001C5543 File Offset: 0x001C3743
	public override bool GetExDataRedPointShowState()
	{
		return this.CheckAnyStageRed() || this.CheckScoreRewardRedDot();
	}

	// Token: 0x0600565E RID: 22110 RVA: 0x001C5558 File Offset: 0x001C3758
	protected override bool GetExDataFinishShowState()
	{
		if (!NoLinq.All<LongShanScoreRewardData>(this.ScoreRewards.Values, (LongShanScoreRewardData data) => data.GetState() == EActivityTaskState.FinishedAndClaimed))
		{
			return false;
		}
		if (this.StageIds != null)
		{
			foreach (int id in this.StageIds)
			{
				if (this.GetProgress(id) != 100)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600565F RID: 22111 RVA: 0x001C55C7 File Offset: 0x001C37C7
	public List<LongShanScoreRewardData> GetAllScoreRewardData()
	{
		return NoLinq.SortToList<LongShanScoreRewardData>(this.ScoreRewards.Values, (LongShanScoreRewardData left, LongShanScoreRewardData right) => left.Goal.CompareTo(right.Goal));
	}

	// Token: 0x06005660 RID: 22112 RVA: 0x001C55F8 File Offset: 0x001C37F8
	public LongShanScoreRewardData GetScoreRewardDataById(int id)
	{
		LongShanScoreRewardData result;
		this.ScoreRewards.TryGetValue(id, out result);
		return result;
	}

	// Token: 0x06005661 RID: 22113 RVA: 0x001C5615 File Offset: 0x001C3815
	public int GetScoreItemCount()
	{
		return InventoryModel.Instance.GetItemCountByConfigId(this.ScoreItemId, 0);
	}

	// Token: 0x06005662 RID: 22114 RVA: 0x001C5628 File Offset: 0x001C3828
	public int[] GetAllAvailableScoreRewardIds()
	{
		List<int> list = new List<int>();
		foreach (LongShanScoreRewardData longShanScoreRewardData in this.GetAllScoreRewardData())
		{
			if (longShanScoreRewardData.GetState() == EActivityTaskState.FinishedAndUnclaimed)
			{
				list.Add(longShanScoreRewardData.Id);
			}
		}
		return list.ToArray();
	}

	// Token: 0x04003B88 RID: 15240
	private const int TASK_FINISH_PERCENT = 100;

	// Token: 0x04003B89 RID: 15241
	[Nullable(2)]
	public int[] StageIds;

	// Token: 0x04003B8A RID: 15242
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, CSharpScript.Game.Module.Activity.ActivityContent.LongShan.LongShanStageInfo> Stages;

	// Token: 0x04003B8B RID: 15243
	public int[] ScoreRewardIds = Array.Empty<int>();

	// Token: 0x04003B8C RID: 15244
	private readonly Dictionary<int, LongShanScoreRewardData> ScoreRewards = new Dictionary<int, LongShanScoreRewardData>();

	// Token: 0x04003B8D RID: 15245
	public int ScoreItemId;

	// Token: 0x04003B8E RID: 15246
	public int ScoreItemTotal;
}

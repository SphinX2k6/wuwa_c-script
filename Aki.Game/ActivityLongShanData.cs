using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.LongShan;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.SkipInterface;
using Google.Protobuf.Collections;

// Token: 0x020012A0 RID: 4768
[NullableContext(1)]
[Nullable(0)]
public class ActivityLongShanData : ActivityBaseData
{
	// Token: 0x060082B2 RID: 33458 RVA: 0x001BBE3A File Offset: 0x001BA03A
	protected override void OnInit(ActivityData data)
	{
		this.InitScoreReward();
	}

	// Token: 0x060082B3 RID: 33459 RVA: 0x001BBE44 File Offset: 0x001BA044
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
			using (IEnumerator<LongShanStage> enumerator = configList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					LongShanStage config = enumerator.Current;
					list.Add(config.Id);
					LongShanActivity longShanActivityData = data.LongShanActivityData;
					Aki.Protocol.LongShanStageInfo longShanStageInfo;
					if (longShanActivityData == null)
					{
						longShanStageInfo = null;
					}
					else
					{
						RepeatedField<Aki.Protocol.LongShanStageInfo> stages2 = longShanActivityData.Stages;
						longShanStageInfo = ((stages2 != null) ? stages2.FirstOrDefault((Aki.Protocol.LongShanStageInfo x) => x.Id == config.Id) : null);
					}
					Aki.Protocol.LongShanStageInfo longShanStageInfo2 = longShanStageInfo;
					if (longShanStageInfo2 != null)
					{
						CSharpScript.Game.Module.Activity.ActivityContent.LongShan.LongShanStageInfo value = new CSharpScript.Game.Module.Activity.ActivityContent.LongShan.LongShanStageInfo(longShanStageInfo2);
						this.Stages[config.Id] = value;
					}
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

	// Token: 0x060082B4 RID: 33460 RVA: 0x001BC028 File Offset: 0x001BA228
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

	// Token: 0x060082B5 RID: 33461 RVA: 0x001BC130 File Offset: 0x001BA330
	public void UpdateStage(Aki.Protocol.LongShanStageInfo[] stageInfos)
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

	// Token: 0x060082B6 RID: 33462 RVA: 0x001BC1B4 File Offset: 0x001BA3B4
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

	// Token: 0x060082B7 RID: 33463 RVA: 0x001BC22C File Offset: 0x001BA42C
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

	// Token: 0x060082B8 RID: 33464 RVA: 0x001BC2BC File Offset: 0x001BA4BC
	public void UpdateScoreRewardStatus(int[] ids)
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

	// Token: 0x060082B9 RID: 33465 RVA: 0x001BC305 File Offset: 0x001BA505
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x060082BA RID: 33466 RVA: 0x001BC308 File Offset: 0x001BA508
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

	// Token: 0x060082BB RID: 33467 RVA: 0x001BC380 File Offset: 0x001BA580
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

	// Token: 0x060082BC RID: 33468 RVA: 0x001BC3E8 File Offset: 0x001BA5E8
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

	// Token: 0x060082BD RID: 33469 RVA: 0x001BC464 File Offset: 0x001BA664
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

	// Token: 0x060082BE RID: 33470 RVA: 0x001BC4F4 File Offset: 0x001BA6F4
	public int GetProgress(int id)
	{
		Aki.Protocol.LongShanStageInfo stageInfoById = this.GetStageInfoById(id);
		if (stageInfoById == null)
		{
			return 0;
		}
		RepeatedField<LongShanTaskInfo> tasks = stageInfoById.Tasks;
		float num;
		if (tasks == null)
		{
			num = (float)0;
		}
		else
		{
			num = (float)tasks.Count((LongShanTaskInfo x) => x.IsTaken);
		}
		return (int)Math.Ceiling((double)(num * 1f / (float)stageInfoById.Tasks.Count * 100f));
	}

	// Token: 0x060082BF RID: 33471 RVA: 0x001BC560 File Offset: 0x001BA760
	public bool IsStageUnlock(int stageId)
	{
		bool flag = this.IsStageReachOpenTime(stageId);
		Aki.Protocol.LongShanStageInfo stageInfoByIdIncludeLock = this.GetStageInfoByIdIncludeLock(stageId);
		return stageInfoByIdIncludeLock != null && stageInfoByIdIncludeLock.Unlock && flag;
	}

	// Token: 0x060082C0 RID: 33472 RVA: 0x001BC58C File Offset: 0x001BA78C
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

	// Token: 0x060082C1 RID: 33473 RVA: 0x001BC5F4 File Offset: 0x001BA7F4
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

	// Token: 0x060082C2 RID: 33474 RVA: 0x001BC664 File Offset: 0x001BA864
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
			return stageInfoById.Tasks.Any((LongShanTaskInfo x) => x.IsFinished && !x.IsTaken);
		}
		return false;
	}

	// Token: 0x060082C3 RID: 33475 RVA: 0x001BC6CA File Offset: 0x001BA8CA
	public void SaveNewStageFlag(int stageId)
	{
		ActivityModel.Instance.SaveActivityData(base.Id, stageId, 0, 0, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x060082C4 RID: 33476 RVA: 0x001BC6F8 File Offset: 0x001BA8F8
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

	// Token: 0x060082C5 RID: 33477 RVA: 0x001BC734 File Offset: 0x001BA934
	public bool CheckScoreRewardRedDot()
	{
		using (List<LongShanScoreRewardData>.Enumerator enumerator = this.GetAllScoreRewardData().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetState() == EActivityTaskState.FinishedAndUnclaimed)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060082C6 RID: 33478 RVA: 0x001BC790 File Offset: 0x001BA990
	public override bool GetExDataRedPointShowState()
	{
		return this.CheckAnyStageRed() || this.CheckScoreRewardRedDot();
	}

	// Token: 0x060082C7 RID: 33479 RVA: 0x001BC7A4 File Offset: 0x001BA9A4
	protected override bool GetExDataFinishShowState()
	{
		using (List<LongShanScoreRewardData>.Enumerator enumerator = this.GetAllScoreRewardData().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetState() != EActivityTaskState.FinishedAndClaimed)
				{
					return false;
				}
			}
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

	// Token: 0x060082C8 RID: 33480 RVA: 0x001BC830 File Offset: 0x001BAA30
	public List<LongShanScoreRewardData> GetAllScoreRewardData()
	{
		return (from a in this.ScoreRewards.Values
		orderby a.Goal
		select a).ToList<LongShanScoreRewardData>();
	}

	// Token: 0x060082C9 RID: 33481 RVA: 0x001BC868 File Offset: 0x001BAA68
	public LongShanScoreRewardData GetScoreRewardDataById(int id)
	{
		LongShanScoreRewardData result;
		this.ScoreRewards.TryGetValue(id, out result);
		return result;
	}

	// Token: 0x060082CA RID: 33482 RVA: 0x001BC885 File Offset: 0x001BAA85
	public int GetScoreItemCount()
	{
		return InventoryModel.Instance.GetItemCountByConfigId(this.ScoreItemId, 0);
	}

	// Token: 0x060082CB RID: 33483 RVA: 0x001BC898 File Offset: 0x001BAA98
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

	// Token: 0x04003AF0 RID: 15088
	private const int TASK_FINISH_PERCENT = 100;

	// Token: 0x04003AF1 RID: 15089
	[Nullable(2)]
	public int[] StageIds;

	// Token: 0x04003AF2 RID: 15090
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, CSharpScript.Game.Module.Activity.ActivityContent.LongShan.LongShanStageInfo> Stages;

	// Token: 0x04003AF3 RID: 15091
	public int[] ScoreRewardIds = Array.Empty<int>();

	// Token: 0x04003AF4 RID: 15092
	private readonly Dictionary<int, LongShanScoreRewardData> ScoreRewards = new Dictionary<int, LongShanScoreRewardData>();

	// Token: 0x04003AF5 RID: 15093
	public int ScoreItemId;

	// Token: 0x04003AF6 RID: 15094
	public int ScoreItemTotal;
}

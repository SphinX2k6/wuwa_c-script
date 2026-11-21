using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02000F95 RID: 3989
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class FeedbackRewardModel : ModelBase
{
	// Token: 0x06009FE4 RID: 40932 RVA: 0x002F3508 File Offset: 0x002F1708
	protected override bool OnInit()
	{
		foreach (GivebackScoreReward givebackScoreReward in (FeedbackRewardConfig.Instance.GetGivebackScoreRewardAll() ?? new List<GivebackScoreReward>()))
		{
			this.FeedbackRewardStateMap.Add(givebackScoreReward.Id, EFeedbackRewardState.UnFinish);
		}
		foreach (GivebackTask givebackTask in (FeedbackRewardConfig.Instance.GetGivebackTaskAll() ?? new List<GivebackTask>()))
		{
			this.FeedbackTaskMap.Add(givebackTask.TaskId, 0);
		}
		this.MaxShowScore = ConfigCommonParamById.GetIntConfig("FeedbackRewardMaxScore").GetValueOrDefault();
		return true;
	}

	// Token: 0x06009FE5 RID: 40933 RVA: 0x002F35E0 File Offset: 0x002F17E0
	public List<int> GetAllRewardList()
	{
		return new List<int>(this.FeedbackRewardStateMap.Keys);
	}

	// Token: 0x06009FE6 RID: 40934 RVA: 0x002F35F4 File Offset: 0x002F17F4
	public EFeedbackRewardState GetFeedbackRewardState(int id)
	{
		EFeedbackRewardState result;
		if (this.FeedbackRewardStateMap.TryGetValue(id, out result))
		{
			return result;
		}
		return EFeedbackRewardState.UnFinish;
	}

	// Token: 0x06009FE7 RID: 40935 RVA: 0x002F3614 File Offset: 0x002F1814
	public int GetFeedbackTaskCurrentPoint(int id)
	{
		int result;
		if (this.FeedbackTaskMap.TryGetValue(id, out result))
		{
			return result;
		}
		return 0;
	}

	// Token: 0x06009FE8 RID: 40936 RVA: 0x002F3634 File Offset: 0x002F1834
	public List<int> GetFeedbackTaskList()
	{
		return new List<int>(this.FeedbackTaskMap.Keys);
	}

	// Token: 0x06009FE9 RID: 40937 RVA: 0x002F3648 File Offset: 0x002F1848
	public List<int> GetFeedbackRewardCanClaim()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, EFeedbackRewardState> keyValuePair in this.FeedbackRewardStateMap)
		{
			if (keyValuePair.Value == EFeedbackRewardState.Finish)
			{
				list.Add(keyValuePair.Key);
			}
		}
		return list;
	}

	// Token: 0x06009FEA RID: 40938 RVA: 0x002F36B4 File Offset: 0x002F18B4
	public void RefreshFeedBackRewardMapState(int[] haveGetRewardIds)
	{
		foreach (KeyValuePair<int, EFeedbackRewardState> keyValuePair in this.FeedbackRewardStateMap)
		{
			int key = keyValuePair.Key;
			if (new List<int>(haveGetRewardIds).Contains(key))
			{
				this.FeedbackRewardStateMap[key] = EFeedbackRewardState.Claimed;
			}
			else if (FeedbackRewardConfig.Instance.GetGivebackScoreRewardById(key).Value.Target <= this.CurrentPointCount)
			{
				this.FeedbackRewardStateMap[key] = EFeedbackRewardState.Finish;
			}
		}
	}

	// Token: 0x06009FEB RID: 40939 RVA: 0x002F3758 File Offset: 0x002F1958
	public void RefreshFeedBackTask(IReadOnlyList<GivebackTaskPb> tasks)
	{
		foreach (GivebackTaskPb givebackTaskPb in tasks)
		{
			if (this.FeedbackTaskMap.ContainsKey(givebackTaskPb.Id))
			{
				this.FeedbackTaskMap[givebackTaskPb.Id] = givebackTaskPb.Score;
			}
			else
			{
				this.FeedbackTaskMap.Add(givebackTaskPb.Id, givebackTaskPb.Score);
			}
		}
	}

	// Token: 0x06009FEC RID: 40940 RVA: 0x002F37DC File Offset: 0x002F19DC
	public List<int> GetCanFinishRewardId()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, EFeedbackRewardState> keyValuePair in this.FeedbackRewardStateMap)
		{
			if (keyValuePair.Value == EFeedbackRewardState.Finish)
			{
				list.Add(keyValuePair.Key);
			}
		}
		return list;
	}

	// Token: 0x06009FED RID: 40941 RVA: 0x002F3848 File Offset: 0x002F1A48
	public bool CheckRedDot()
	{
		foreach (KeyValuePair<int, EFeedbackRewardState> keyValuePair in this.FeedbackRewardStateMap)
		{
			if (keyValuePair.Value == EFeedbackRewardState.Finish)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06009FEE RID: 40942 RVA: 0x002F38A8 File Offset: 0x002F1AA8
	public int GetMaxFinishRewardId()
	{
		int num = 0;
		foreach (KeyValuePair<int, EFeedbackRewardState> keyValuePair in this.FeedbackRewardStateMap)
		{
			if (keyValuePair.Value == EFeedbackRewardState.Finish && num < keyValuePair.Key)
			{
				num = keyValuePair.Key;
			}
		}
		return num;
	}

	// Token: 0x06009FEF RID: 40943 RVA: 0x002F3914 File Offset: 0x002F1B14
	public List<int> GetCanClaimRewardIds()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, EFeedbackRewardState> keyValuePair in this.FeedbackRewardStateMap)
		{
			if (keyValuePair.Value == EFeedbackRewardState.Finish)
			{
				list.Add(keyValuePair.Key);
			}
		}
		return list;
	}

	// Token: 0x170010FA RID: 4346
	// (get) Token: 0x06009FF0 RID: 40944 RVA: 0x002F3980 File Offset: 0x002F1B80
	public static FeedbackRewardModel Instance
	{
		get
		{
			return FeedbackRewardModel._Instance;
		}
	}

	// Token: 0x06009FF1 RID: 40945 RVA: 0x002F3987 File Offset: 0x002F1B87
	public static FeedbackRewardModel GetOrCreateInstance()
	{
		if (FeedbackRewardModel._Instance == null)
		{
			FeedbackRewardModel.CreateInstance();
		}
		return FeedbackRewardModel._Instance;
	}

	// Token: 0x06009FF2 RID: 40946 RVA: 0x002F399B File Offset: 0x002F1B9B
	public static bool CreateInstance()
	{
		if (FeedbackRewardModel._Instance != null)
		{
			return true;
		}
		FeedbackRewardModel._Instance = new FeedbackRewardModel();
		return true;
	}

	// Token: 0x06009FF3 RID: 40947 RVA: 0x002F39B1 File Offset: 0x002F1BB1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009FF4 RID: 40948 RVA: 0x002F39B3 File Offset: 0x002F1BB3
	public static void ResetStaticDefaultValue()
	{
		FeedbackRewardModel._Instance = null;
	}

	// Token: 0x06009FF5 RID: 40949 RVA: 0x002F39BB File Offset: 0x002F1BBB
	static FeedbackRewardModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FeedbackRewardModel.CreateStaticDefaultValue), new Action(FeedbackRewardModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005E88 RID: 24200
	private readonly Dictionary<int, EFeedbackRewardState> FeedbackRewardStateMap = new Dictionary<int, EFeedbackRewardState>();

	// Token: 0x04005E89 RID: 24201
	private readonly Dictionary<int, int> FeedbackTaskMap = new Dictionary<int, int>();

	// Token: 0x04005E8A RID: 24202
	public int MaxShowScore;

	// Token: 0x04005E8B RID: 24203
	public int CurrentPointCount;

	// Token: 0x04005E8C RID: 24204
	public int CurrentLoginDayCount;

	// Token: 0x04005E8D RID: 24205
	[Nullable(2)]
	private static FeedbackRewardModel _Instance;
}

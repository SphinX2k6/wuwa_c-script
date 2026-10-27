using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02001AD6 RID: 6870
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class FeedbackRewardModel : ModelBase
{
	// Token: 0x0600CBD3 RID: 52179 RVA: 0x002E8394 File Offset: 0x002E6594
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

	// Token: 0x0600CBD4 RID: 52180 RVA: 0x002E846C File Offset: 0x002E666C
	public List<int> GetAllRewardList()
	{
		return new List<int>(this.FeedbackRewardStateMap.Keys);
	}

	// Token: 0x0600CBD5 RID: 52181 RVA: 0x002E8480 File Offset: 0x002E6680
	public EFeedbackRewardState GetFeedbackRewardState(int id)
	{
		EFeedbackRewardState result;
		if (this.FeedbackRewardStateMap.TryGetValue(id, out result))
		{
			return result;
		}
		return EFeedbackRewardState.UnFinish;
	}

	// Token: 0x0600CBD6 RID: 52182 RVA: 0x002E84A0 File Offset: 0x002E66A0
	public int GetFeedbackTaskCurrentPoint(int id)
	{
		int result;
		if (this.FeedbackTaskMap.TryGetValue(id, out result))
		{
			return result;
		}
		return 0;
	}

	// Token: 0x0600CBD7 RID: 52183 RVA: 0x002E84C0 File Offset: 0x002E66C0
	public List<int> GetFeedbackTaskList()
	{
		return new List<int>(this.FeedbackTaskMap.Keys);
	}

	// Token: 0x0600CBD8 RID: 52184 RVA: 0x002E84D4 File Offset: 0x002E66D4
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

	// Token: 0x0600CBD9 RID: 52185 RVA: 0x002E8540 File Offset: 0x002E6740
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

	// Token: 0x0600CBDA RID: 52186 RVA: 0x002E85E4 File Offset: 0x002E67E4
	public void RefreshFeedBackTask(GivebackTaskPb[] tasks)
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

	// Token: 0x0600CBDB RID: 52187 RVA: 0x002E8648 File Offset: 0x002E6848
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

	// Token: 0x0600CBDC RID: 52188 RVA: 0x002E86B4 File Offset: 0x002E68B4
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

	// Token: 0x0600CBDD RID: 52189 RVA: 0x002E8714 File Offset: 0x002E6914
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

	// Token: 0x0600CBDE RID: 52190 RVA: 0x002E8780 File Offset: 0x002E6980
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

	// Token: 0x170010D5 RID: 4309
	// (get) Token: 0x0600CBDF RID: 52191 RVA: 0x002E87EC File Offset: 0x002E69EC
	public static FeedbackRewardModel Instance
	{
		get
		{
			return FeedbackRewardModel._Instance;
		}
	}

	// Token: 0x0600CBE0 RID: 52192 RVA: 0x002E87F3 File Offset: 0x002E69F3
	public static FeedbackRewardModel GetOrCreateInstance()
	{
		if (FeedbackRewardModel._Instance == null)
		{
			FeedbackRewardModel.CreateInstance();
		}
		return FeedbackRewardModel._Instance;
	}

	// Token: 0x0600CBE1 RID: 52193 RVA: 0x002E8807 File Offset: 0x002E6A07
	public static bool CreateInstance()
	{
		if (FeedbackRewardModel._Instance != null)
		{
			return true;
		}
		FeedbackRewardModel._Instance = new FeedbackRewardModel();
		return true;
	}

	// Token: 0x0600CBE2 RID: 52194 RVA: 0x002E881D File Offset: 0x002E6A1D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CBE3 RID: 52195 RVA: 0x002E881F File Offset: 0x002E6A1F
	public static void ResetStaticDefaultValue()
	{
		FeedbackRewardModel._Instance = null;
	}

	// Token: 0x0600CBE4 RID: 52196 RVA: 0x002E8827 File Offset: 0x002E6A27
	static FeedbackRewardModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FeedbackRewardModel.CreateStaticDefaultValue), new Action(FeedbackRewardModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005DB9 RID: 23993
	private readonly Dictionary<int, EFeedbackRewardState> FeedbackRewardStateMap = new Dictionary<int, EFeedbackRewardState>();

	// Token: 0x04005DBA RID: 23994
	private readonly Dictionary<int, int> FeedbackTaskMap = new Dictionary<int, int>();

	// Token: 0x04005DBB RID: 23995
	public int MaxShowScore;

	// Token: 0x04005DBC RID: 23996
	public int CurrentPointCount;

	// Token: 0x04005DBD RID: 23997
	public int CurrentLoginDayCount;

	// Token: 0x04005DBE RID: 23998
	[Nullable(2)]
	private static FeedbackRewardModel _Instance;
}

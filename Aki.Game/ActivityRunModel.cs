using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02000991 RID: 2449
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ActivityRunModel : ModelBase
{
	// Token: 0x06006BB6 RID: 27574 RVA: 0x00216D34 File Offset: 0x00214F34
	public void OnReceiveMessageData(ParkourChallengeResponse data)
	{
		if (data.Challenges != null)
		{
			foreach (ParkourChallenge parkourChallenge in data.Challenges)
			{
				this.GetActivityRunData(parkourChallenge.ChallengeId).Phrase(parkourChallenge);
			}
		}
		if (data.OpenIds != null)
		{
			foreach (int id in data.OpenIds)
			{
				this.GetActivityRunData(id).SetIsOpen(true);
			}
		}
	}

	// Token: 0x06006BB7 RID: 27575 RVA: 0x00216DE0 File Offset: 0x00214FE0
	public void OnReceiveChallengeOpenNotify(ParkourChallengeOpenNotify message)
	{
		ActivityRunData activityRunData = this.GetActivityRunData(message.ChallengeId);
		activityRunData.SetIsOpen(message.IsOpen);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityRunData.GetActivityId());
	}

	// Token: 0x06006BB8 RID: 27576 RVA: 0x00216E1C File Offset: 0x0021501C
	public void OnGetChallengeReward(int challengeId, int scoreIndex)
	{
		ActivityRunData activityRunData = this.GetActivityRunData(challengeId);
		activityRunData.OnGetScoreReward(scoreIndex);
		int scoreIndexScore = activityRunData.GetScoreIndexScore(scoreIndex);
		EventSystem.Instance.Emit<int>(EEventName.OnGetRunActivityReward, scoreIndexScore);
	}

	// Token: 0x06006BB9 RID: 27577 RVA: 0x00216E50 File Offset: 0x00215050
	public int[] GetOpenChallengeIds()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, ActivityRunData> keyValuePair in this.ActivityMap)
		{
			if (keyValuePair.Value.GetIsShow())
			{
				list.Add(keyValuePair.Key);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06006BBA RID: 27578 RVA: 0x00216EC4 File Offset: 0x002150C4
	public int[] GetChallengeIds()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, ActivityRunData> keyValuePair in this.ActivityMap)
		{
			list.Add(keyValuePair.Key);
		}
		return list.ToArray();
	}

	// Token: 0x06006BBB RID: 27579 RVA: 0x00216F2C File Offset: 0x0021512C
	public ActivityRunData GetActivityRunData(int id)
	{
		ActivityRunData result;
		if (this.ActivityMap.TryGetValue(id, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06006BBC RID: 27580 RVA: 0x00216F4C File Offset: 0x0021514C
	public ActivityRunData CreateActivityRunData(int activityId, int id)
	{
		ActivityRunData activityRunData;
		if (!this.ActivityMap.TryGetValue(id, out activityRunData))
		{
			activityRunData = new ActivityRunData(activityId);
			this.ActivityMap[id] = activityRunData;
		}
		return activityRunData;
	}

	// Token: 0x06006BBD RID: 27581 RVA: 0x00216F80 File Offset: 0x00215180
	public int GetDefaultOpenUiChallengeIndex(ActivityBaseData baseData)
	{
		ActivityRun activityRun = baseData as ActivityRun;
		if (activityRun == null)
		{
			return 0;
		}
		List<ActivityRunData> challengeDataArray = activityRun.GetChallengeDataArray();
		if (activityRun.IfAllFinish())
		{
			this.StartViewSelectIndex = challengeDataArray.Count - 1;
			return challengeDataArray.Count - 1;
		}
		return activityRun.GetActivityContentIndex();
	}

	// Token: 0x06006BBE RID: 27582 RVA: 0x00216FC5 File Offset: 0x002151C5
	public void SetStartViewSelectIndex(int index)
	{
		this.StartViewSelectIndex = index;
	}

	// Token: 0x06006BBF RID: 27583 RVA: 0x00216FCE File Offset: 0x002151CE
	public int GetStartViewSelectIndex()
	{
		return this.StartViewSelectIndex;
	}

	// Token: 0x06006BC0 RID: 27584 RVA: 0x00216FD8 File Offset: 0x002151D8
	public ActivityRunData GetChallengeDataByMarkId(int markId)
	{
		int[] challengeIds = this.GetChallengeIds();
		int num = challengeIds.Length;
		if (num == 0)
		{
			return null;
		}
		int num2 = -1;
		for (int i = 0; i < num; i++)
		{
			ActivityRunData activityRunData = this.GetActivityRunData(challengeIds[i]);
			if (activityRunData != null && activityRunData.GetMarkId() == (long)markId)
			{
				num2 = i;
			}
		}
		if (num2 == -1)
		{
			num2 = 0;
		}
		return this.GetActivityRunData(challengeIds[num2]);
	}

	// Token: 0x17000D3C RID: 3388
	// (get) Token: 0x06006BC1 RID: 27585 RVA: 0x0021702F File Offset: 0x0021522F
	public static ActivityRunModel Instance
	{
		get
		{
			return ActivityRunModel._Instance;
		}
	}

	// Token: 0x06006BC2 RID: 27586 RVA: 0x00217036 File Offset: 0x00215236
	public static ActivityRunModel GetOrCreateInstance()
	{
		if (ActivityRunModel._Instance == null)
		{
			ActivityRunModel.CreateInstance();
		}
		return ActivityRunModel._Instance;
	}

	// Token: 0x06006BC3 RID: 27587 RVA: 0x0021704A File Offset: 0x0021524A
	public static bool CreateInstance()
	{
		if (ActivityRunModel._Instance != null)
		{
			return true;
		}
		ActivityRunModel._Instance = new ActivityRunModel();
		return true;
	}

	// Token: 0x06006BC4 RID: 27588 RVA: 0x00217060 File Offset: 0x00215260
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006BC5 RID: 27589 RVA: 0x00217062 File Offset: 0x00215262
	public static void ResetStaticDefaultValue()
	{
		ActivityRunModel._Instance = null;
	}

	// Token: 0x06006BC6 RID: 27590 RVA: 0x0021706A File Offset: 0x0021526A
	static ActivityRunModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRunModel.CreateStaticDefaultValue), new Action(ActivityRunModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004375 RID: 17269
	public int CurrentSelectChallengeId;

	// Token: 0x04004376 RID: 17270
	private int StartViewSelectIndex;

	// Token: 0x04004377 RID: 17271
	private readonly Dictionary<int, ActivityRunData> ActivityMap = new Dictionary<int, ActivityRunData>();

	// Token: 0x04004378 RID: 17272
	[Nullable(2)]
	private static ActivityRunModel _Instance;
}

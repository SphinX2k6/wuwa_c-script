using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020014D9 RID: 5337
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ActivityRunModel : ModelBase
{
	// Token: 0x060097DC RID: 38876 RVA: 0x0020CFF4 File Offset: 0x0020B1F4
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

	// Token: 0x060097DD RID: 38877 RVA: 0x0020D0A0 File Offset: 0x0020B2A0
	public void OnReceiveChallengeOpenNotify(ParkourChallengeOpenNotify message)
	{
		ActivityRunData activityRunData = this.GetActivityRunData(message.ChallengeId);
		activityRunData.SetIsOpen(message.IsOpen);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityRunData.GetActivityId());
	}

	// Token: 0x060097DE RID: 38878 RVA: 0x0020D0DC File Offset: 0x0020B2DC
	public void OnGetChallengeReward(int challengeId, int scoreIndex)
	{
		ActivityRunData activityRunData = this.GetActivityRunData(challengeId);
		activityRunData.OnGetScoreReward(scoreIndex);
		int scoreIndexScore = activityRunData.GetScoreIndexScore(scoreIndex);
		EventSystem.Instance.Emit<int>(EEventName.OnGetRunActivityReward, scoreIndexScore);
	}

	// Token: 0x060097DF RID: 38879 RVA: 0x0020D110 File Offset: 0x0020B310
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

	// Token: 0x060097E0 RID: 38880 RVA: 0x0020D184 File Offset: 0x0020B384
	public int[] GetChallengeIds()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, ActivityRunData> keyValuePair in this.ActivityMap)
		{
			list.Add(keyValuePair.Key);
		}
		return list.ToArray();
	}

	// Token: 0x060097E1 RID: 38881 RVA: 0x0020D1EC File Offset: 0x0020B3EC
	public ActivityRunData GetActivityRunData(int id)
	{
		ActivityRunData result;
		if (this.ActivityMap.TryGetValue(id, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060097E2 RID: 38882 RVA: 0x0020D20C File Offset: 0x0020B40C
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

	// Token: 0x060097E3 RID: 38883 RVA: 0x0020D240 File Offset: 0x0020B440
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

	// Token: 0x060097E4 RID: 38884 RVA: 0x0020D285 File Offset: 0x0020B485
	public void SetStartViewSelectIndex(int index)
	{
		this.StartViewSelectIndex = index;
	}

	// Token: 0x060097E5 RID: 38885 RVA: 0x0020D28E File Offset: 0x0020B48E
	public int GetStartViewSelectIndex()
	{
		return this.StartViewSelectIndex;
	}

	// Token: 0x060097E6 RID: 38886 RVA: 0x0020D298 File Offset: 0x0020B498
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

	// Token: 0x17000D1B RID: 3355
	// (get) Token: 0x060097E7 RID: 38887 RVA: 0x0020D2EF File Offset: 0x0020B4EF
	public static ActivityRunModel Instance
	{
		get
		{
			return ActivityRunModel._Instance;
		}
	}

	// Token: 0x060097E8 RID: 38888 RVA: 0x0020D2F6 File Offset: 0x0020B4F6
	public static ActivityRunModel GetOrCreateInstance()
	{
		if (ActivityRunModel._Instance == null)
		{
			ActivityRunModel.CreateInstance();
		}
		return ActivityRunModel._Instance;
	}

	// Token: 0x060097E9 RID: 38889 RVA: 0x0020D30A File Offset: 0x0020B50A
	public static bool CreateInstance()
	{
		if (ActivityRunModel._Instance != null)
		{
			return true;
		}
		ActivityRunModel._Instance = new ActivityRunModel();
		return true;
	}

	// Token: 0x060097EA RID: 38890 RVA: 0x0020D320 File Offset: 0x0020B520
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060097EB RID: 38891 RVA: 0x0020D322 File Offset: 0x0020B522
	public static void ResetStaticDefaultValue()
	{
		ActivityRunModel._Instance = null;
	}

	// Token: 0x060097EC RID: 38892 RVA: 0x0020D32A File Offset: 0x0020B52A
	static ActivityRunModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRunModel.CreateStaticDefaultValue), new Action(ActivityRunModel.ResetStaticDefaultValue));
	}

	// Token: 0x040042D0 RID: 17104
	public int CurrentSelectChallengeId;

	// Token: 0x040042D1 RID: 17105
	private int StartViewSelectIndex;

	// Token: 0x040042D2 RID: 17106
	private readonly Dictionary<int, ActivityRunData> ActivityMap = new Dictionary<int, ActivityRunData>();

	// Token: 0x040042D3 RID: 17107
	[Nullable(2)]
	private static ActivityRunModel _Instance;
}

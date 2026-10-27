using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.FunPlay;

// Token: 0x02001287 RID: 4743
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ActivityFunPlayModel : ModelBase
{
	// Token: 0x06008192 RID: 33170 RVA: 0x001B809C File Offset: 0x001B629C
	public void CreateChallengeData(FunPlayChallengeInfo[] data, int activityId)
	{
		if (data == null)
		{
			return;
		}
		for (int i = 0; i < data.Length; i++)
		{
			FunPlayChallengeInfo funPlayChallengeInfo = data[i];
			ActivityFunPlayChallengeData activityFunPlayChallengeData = this.GetChallengeData(funPlayChallengeInfo.ChallengeId);
			if (activityFunPlayChallengeData != null)
			{
				activityFunPlayChallengeData.Phrase(funPlayChallengeInfo);
			}
			else
			{
				activityFunPlayChallengeData = new ActivityFunPlayChallengeData(activityId);
				activityFunPlayChallengeData.Phrase(funPlayChallengeInfo);
				activityFunPlayChallengeData.SetIndex(i);
				this.AllChallengeDataMap.Add(funPlayChallengeInfo.ChallengeId, activityFunPlayChallengeData);
				this.AllChallengeDataList.Add(activityFunPlayChallengeData);
			}
		}
	}

	// Token: 0x06008193 RID: 33171 RVA: 0x001B810C File Offset: 0x001B630C
	[return: Nullable(2)]
	public ActivityFunPlayChallengeData UpdateChallengeData(FunPlayChallengeInfo data)
	{
		if (data == null)
		{
			return null;
		}
		ActivityFunPlayChallengeData challengeData = this.GetChallengeData(data.ChallengeId);
		if (challengeData == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ActivityFunPlay;
			ELogAuthor author = ELogAuthor.CB;
			string message = "服务器下发的更新关卡信息的id不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ChallengeId", data.ChallengeId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		challengeData.Phrase(data);
		return challengeData;
	}

	// Token: 0x06008194 RID: 33172 RVA: 0x001B816C File Offset: 0x001B636C
	private List<ActivityFunPlayChallengeData> SortChallenges()
	{
		List<ActivityFunPlayChallengeData> list = new List<ActivityFunPlayChallengeData>(this.AllChallengeDataList);
		list.Sort(delegate(ActivityFunPlayChallengeData a, ActivityFunPlayChallengeData b)
		{
			bool flag = a.CheckRewardStatus(FunPlayChallengeRewardStatus.FunPlayCanReward);
			bool flag2 = b.CheckRewardStatus(FunPlayChallengeRewardStatus.FunPlayCanReward);
			if (flag != flag2)
			{
				if (!flag)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				if (flag && flag2)
				{
					int index = a.Index;
					return b.Index - index;
				}
				bool flag3 = a.CheckRewardStatus(FunPlayChallengeRewardStatus.FunPlayRewarded);
				bool flag4 = b.CheckRewardStatus(FunPlayChallengeRewardStatus.FunPlayRewarded);
				if (flag3 != flag4)
				{
					if (!flag3)
					{
						return -1;
					}
					return 1;
				}
				else
				{
					bool isUnlock = a.GetIsUnlock();
					bool isUnlock2 = b.GetIsUnlock();
					if (isUnlock == isUnlock2)
					{
						int challengeId = a.GetChallengeId();
						int challengeId2 = b.GetChallengeId();
						return challengeId.CompareTo(challengeId2);
					}
					if (!isUnlock)
					{
						return 1;
					}
					return -1;
				}
			}
		});
		return list;
	}

	// Token: 0x06008195 RID: 33173 RVA: 0x001B819E File Offset: 0x001B639E
	public List<ActivityFunPlayChallengeData> GetAllChallengeData()
	{
		return this.AllChallengeDataList;
	}

	// Token: 0x06008196 RID: 33174 RVA: 0x001B81A8 File Offset: 0x001B63A8
	[NullableContext(2)]
	public ActivityFunPlayChallengeData GetChallengeData(int challengeId)
	{
		ActivityFunPlayChallengeData result;
		this.AllChallengeDataMap.TryGetValue(challengeId, out result);
		return result;
	}

	// Token: 0x06008197 RID: 33175 RVA: 0x001B81C5 File Offset: 0x001B63C5
	public void SetCurrentChallengeData(int challengeId)
	{
		this.CurrentChallengeData = this.GetChallengeData(challengeId);
	}

	// Token: 0x06008198 RID: 33176 RVA: 0x001B81D4 File Offset: 0x001B63D4
	[NullableContext(2)]
	public ActivityFunPlayChallengeData GetCurrentChallengeData()
	{
		return this.CurrentChallengeData;
	}

	// Token: 0x06008199 RID: 33177 RVA: 0x001B81DC File Offset: 0x001B63DC
	public int GetDefaultSelectIndex()
	{
		List<ActivityFunPlayChallengeData> list = this.SortChallenges();
		if (list.Count > 0)
		{
			return list[0].Index;
		}
		return 0;
	}

	// Token: 0x0600819A RID: 33178 RVA: 0x001B8208 File Offset: 0x001B6408
	public bool GetHasInternalRedDot()
	{
		using (Dictionary<int, ActivityFunPlayChallengeData>.ValueCollection.Enumerator enumerator = this.AllChallengeDataMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetRedPoint())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600819B RID: 33179 RVA: 0x001B8268 File Offset: 0x001B6468
	public bool IsAllRewardClaimed()
	{
		if (this.AllChallengeDataList.Count == 0)
		{
			return false;
		}
		using (List<ActivityFunPlayChallengeData>.Enumerator enumerator = this.AllChallengeDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.CheckRewardStatus(FunPlayChallengeRewardStatus.FunPlayRewarded))
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600819C RID: 33180 RVA: 0x001B82D4 File Offset: 0x001B64D4
	protected override bool OnClear()
	{
		this.AllChallengeDataMap.Clear();
		this.AllChallengeDataList.Clear();
		return true;
	}

	// Token: 0x17000B1A RID: 2842
	// (get) Token: 0x0600819D RID: 33181 RVA: 0x001B82ED File Offset: 0x001B64ED
	public static ActivityFunPlayModel Instance
	{
		get
		{
			return ActivityFunPlayModel._Instance;
		}
	}

	// Token: 0x0600819E RID: 33182 RVA: 0x001B82F4 File Offset: 0x001B64F4
	public static ActivityFunPlayModel GetOrCreateInstance()
	{
		if (ActivityFunPlayModel._Instance == null)
		{
			ActivityFunPlayModel.CreateInstance();
		}
		return ActivityFunPlayModel._Instance;
	}

	// Token: 0x0600819F RID: 33183 RVA: 0x001B8308 File Offset: 0x001B6508
	public static bool CreateInstance()
	{
		if (ActivityFunPlayModel._Instance != null)
		{
			return true;
		}
		ActivityFunPlayModel._Instance = new ActivityFunPlayModel();
		return true;
	}

	// Token: 0x060081A0 RID: 33184 RVA: 0x001B831E File Offset: 0x001B651E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060081A1 RID: 33185 RVA: 0x001B8320 File Offset: 0x001B6520
	public static void ResetStaticDefaultValue()
	{
		ActivityFunPlayModel._Instance = null;
	}

	// Token: 0x060081A2 RID: 33186 RVA: 0x001B8328 File Offset: 0x001B6528
	static ActivityFunPlayModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityFunPlayModel.CreateStaticDefaultValue), new Action(ActivityFunPlayModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003AB3 RID: 15027
	[Nullable(2)]
	private ActivityFunPlayChallengeData CurrentChallengeData;

	// Token: 0x04003AB4 RID: 15028
	private readonly Dictionary<int, ActivityFunPlayChallengeData> AllChallengeDataMap = new Dictionary<int, ActivityFunPlayChallengeData>();

	// Token: 0x04003AB5 RID: 15029
	private readonly List<ActivityFunPlayChallengeData> AllChallengeDataList = new List<ActivityFunPlayChallengeData>();

	// Token: 0x04003AB6 RID: 15030
	[Nullable(2)]
	private static ActivityFunPlayModel _Instance;
}

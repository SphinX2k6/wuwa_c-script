using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.FunPlay;

// Token: 0x0200073B RID: 1851
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ActivityFunPlayModel : ModelBase
{
	// Token: 0x06005529 RID: 21801 RVA: 0x001C0D6C File Offset: 0x001BEF6C
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

	// Token: 0x0600552A RID: 21802 RVA: 0x001C0DDC File Offset: 0x001BEFDC
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

	// Token: 0x0600552B RID: 21803 RVA: 0x001C0E3C File Offset: 0x001BF03C
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

	// Token: 0x0600552C RID: 21804 RVA: 0x001C0E6E File Offset: 0x001BF06E
	public List<ActivityFunPlayChallengeData> GetAllChallengeData()
	{
		return this.AllChallengeDataList;
	}

	// Token: 0x0600552D RID: 21805 RVA: 0x001C0E78 File Offset: 0x001BF078
	[NullableContext(2)]
	public ActivityFunPlayChallengeData GetChallengeData(int challengeId)
	{
		ActivityFunPlayChallengeData result;
		this.AllChallengeDataMap.TryGetValue(challengeId, out result);
		return result;
	}

	// Token: 0x0600552E RID: 21806 RVA: 0x001C0E95 File Offset: 0x001BF095
	public void SetCurrentChallengeData(int challengeId)
	{
		this.CurrentChallengeData = this.GetChallengeData(challengeId);
	}

	// Token: 0x0600552F RID: 21807 RVA: 0x001C0EA4 File Offset: 0x001BF0A4
	[NullableContext(2)]
	public ActivityFunPlayChallengeData GetCurrentChallengeData()
	{
		return this.CurrentChallengeData;
	}

	// Token: 0x06005530 RID: 21808 RVA: 0x001C0EAC File Offset: 0x001BF0AC
	public int GetDefaultSelectIndex()
	{
		List<ActivityFunPlayChallengeData> list = this.SortChallenges();
		if (list.Count > 0)
		{
			return list[0].Index;
		}
		return 0;
	}

	// Token: 0x06005531 RID: 21809 RVA: 0x001C0ED8 File Offset: 0x001BF0D8
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

	// Token: 0x06005532 RID: 21810 RVA: 0x001C0F38 File Offset: 0x001BF138
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

	// Token: 0x06005533 RID: 21811 RVA: 0x001C0FA4 File Offset: 0x001BF1A4
	protected override bool OnClear()
	{
		this.AllChallengeDataMap.Clear();
		this.AllChallengeDataList.Clear();
		return true;
	}

	// Token: 0x17000B3A RID: 2874
	// (get) Token: 0x06005534 RID: 21812 RVA: 0x001C0FBD File Offset: 0x001BF1BD
	public static ActivityFunPlayModel Instance
	{
		get
		{
			return ActivityFunPlayModel._Instance;
		}
	}

	// Token: 0x06005535 RID: 21813 RVA: 0x001C0FC4 File Offset: 0x001BF1C4
	public static ActivityFunPlayModel GetOrCreateInstance()
	{
		if (ActivityFunPlayModel._Instance == null)
		{
			ActivityFunPlayModel.CreateInstance();
		}
		return ActivityFunPlayModel._Instance;
	}

	// Token: 0x06005536 RID: 21814 RVA: 0x001C0FD8 File Offset: 0x001BF1D8
	public static bool CreateInstance()
	{
		if (ActivityFunPlayModel._Instance != null)
		{
			return true;
		}
		ActivityFunPlayModel._Instance = new ActivityFunPlayModel();
		return true;
	}

	// Token: 0x06005537 RID: 21815 RVA: 0x001C0FEE File Offset: 0x001BF1EE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005538 RID: 21816 RVA: 0x001C0FF0 File Offset: 0x001BF1F0
	public static void ResetStaticDefaultValue()
	{
		ActivityFunPlayModel._Instance = null;
	}

	// Token: 0x06005539 RID: 21817 RVA: 0x001C0FF8 File Offset: 0x001BF1F8
	static ActivityFunPlayModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityFunPlayModel.CreateStaticDefaultValue), new Action(ActivityFunPlayModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003B4B RID: 15179
	[Nullable(2)]
	private ActivityFunPlayChallengeData CurrentChallengeData;

	// Token: 0x04003B4C RID: 15180
	private readonly Dictionary<int, ActivityFunPlayChallengeData> AllChallengeDataMap = new Dictionary<int, ActivityFunPlayChallengeData>();

	// Token: 0x04003B4D RID: 15181
	private readonly List<ActivityFunPlayChallengeData> AllChallengeDataList = new List<ActivityFunPlayChallengeData>();

	// Token: 0x04003B4E RID: 15182
	[Nullable(2)]
	private static ActivityFunPlayModel _Instance;
}

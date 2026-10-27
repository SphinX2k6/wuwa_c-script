using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020014D4 RID: 5332
[NullableContext(1)]
[Nullable(0)]
public class ActivityRun : ActivityBaseData
{
	// Token: 0x06009796 RID: 38806 RVA: 0x0020BFEC File Offset: 0x0020A1EC
	protected override void PhraseEx(ActivityData data)
	{
		this.CurrentChallenges = new List<ActivityRunData>();
		ParkourActivity parkourActivity = data.ParkourActivity;
		if (((parkourActivity != null) ? parkourActivity.Challenges : null) != null)
		{
			foreach (ParkourActivityChallenge parkourActivityChallenge in data.ParkourActivity.Challenges)
			{
				ActivityRunData activityRunData = ActivityRunModel.Instance.CreateActivityRunData(data.Id, parkourActivityChallenge.ChallengeId);
				activityRunData.Phrase(parkourActivityChallenge);
				this.CurrentChallenges.Add(activityRunData);
				this.ChallengeActivityMap[(long)parkourActivityChallenge.ChallengeId] = (long)data.Id;
			}
		}
	}

	// Token: 0x06009797 RID: 38807 RVA: 0x0020C09C File Offset: 0x0020A29C
	public long GetChallengeActivityId(long challengeId)
	{
		long result;
		if (this.ChallengeActivityMap.TryGetValue(challengeId, out result))
		{
			return result;
		}
		return 0L;
	}

	// Token: 0x06009798 RID: 38808 RVA: 0x0020C0BD File Offset: 0x0020A2BD
	public List<ActivityRunData> GetChallengeDataArray()
	{
		return this.CurrentChallenges;
	}

	// Token: 0x06009799 RID: 38809 RVA: 0x0020C0C5 File Offset: 0x0020A2C5
	public void SetActivityContentIndex(int index)
	{
		ActivityModel.Instance.SaveActivityData(base.Id, -256, base.Id, 0, index);
	}

	// Token: 0x0600979A RID: 38810 RVA: 0x0020C0E4 File Offset: 0x0020A2E4
	public int GetActivityContentIndex()
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, -256, base.Id, 0);
	}

	// Token: 0x0600979B RID: 38811 RVA: 0x0020C104 File Offset: 0x0020A304
	public override bool GetExDataRedPointShowState()
	{
		int count = this.CurrentChallenges.Count;
		for (int i = 0; i < count; i++)
		{
			if (this.CurrentChallenges[i].GetRedPoint())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600979C RID: 38812 RVA: 0x0020C13F File Offset: 0x0020A33F
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x0600979D RID: 38813 RVA: 0x0020C144 File Offset: 0x0020A344
	public bool IfAllFinish()
	{
		int count = this.CurrentChallenges.Count;
		for (int i = 0; i < count; i++)
		{
			if (!this.CurrentChallenges[i].GetIfRewardAllFinished())
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x040042B4 RID: 17076
	private const int ACTIVITYSELECTCACHEKEY = -256;

	// Token: 0x040042B5 RID: 17077
	private readonly Dictionary<long, long> ChallengeActivityMap = new Dictionary<long, long>();

	// Token: 0x040042B6 RID: 17078
	private List<ActivityRunData> CurrentChallenges = new List<ActivityRunData>();
}

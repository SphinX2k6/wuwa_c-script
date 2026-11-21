using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200098C RID: 2444
[NullableContext(1)]
[Nullable(0)]
public class ActivityRun : ActivityBaseData
{
	// Token: 0x06006B70 RID: 27504 RVA: 0x00215D2C File Offset: 0x00213F2C
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

	// Token: 0x06006B71 RID: 27505 RVA: 0x00215DDC File Offset: 0x00213FDC
	public long GetChallengeActivityId(long challengeId)
	{
		long result;
		if (this.ChallengeActivityMap.TryGetValue(challengeId, out result))
		{
			return result;
		}
		return 0L;
	}

	// Token: 0x06006B72 RID: 27506 RVA: 0x00215DFD File Offset: 0x00213FFD
	public List<ActivityRunData> GetChallengeDataArray()
	{
		return this.CurrentChallenges;
	}

	// Token: 0x06006B73 RID: 27507 RVA: 0x00215E05 File Offset: 0x00214005
	public void SetActivityContentIndex(int index)
	{
		ActivityModel.Instance.SaveActivityData(base.Id, -256, base.Id, 0, index);
	}

	// Token: 0x06006B74 RID: 27508 RVA: 0x00215E24 File Offset: 0x00214024
	public int GetActivityContentIndex()
	{
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, -256, base.Id, 0);
	}

	// Token: 0x06006B75 RID: 27509 RVA: 0x00215E44 File Offset: 0x00214044
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

	// Token: 0x06006B76 RID: 27510 RVA: 0x00215E7F File Offset: 0x0021407F
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x06006B77 RID: 27511 RVA: 0x00215E84 File Offset: 0x00214084
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

	// Token: 0x04004359 RID: 17241
	private const int ACTIVITYSELECTCACHEKEY = -256;

	// Token: 0x0400435A RID: 17242
	private readonly Dictionary<long, long> ChallengeActivityMap = new Dictionary<long, long>();

	// Token: 0x0400435B RID: 17243
	private List<ActivityRunData> CurrentChallenges = new List<ActivityRunData>();
}

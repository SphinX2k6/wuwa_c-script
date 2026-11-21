using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02000747 RID: 1863
[NullableContext(1)]
[Nullable(0)]
public class LifePointDrawActivityData : ActivityBaseData
{
	// Token: 0x060055A6 RID: 21926 RVA: 0x001C206C File Offset: 0x001C026C
	protected override void PhraseEx(ActivityData data)
	{
		LifePointChallengeActivityData lifePointChallenge = data.LifePointChallenge;
		if (lifePointChallenge != null)
		{
			foreach (LifePointChallengeData lifePointChallengeData in lifePointChallenge.Challenges)
			{
				LifePointChallengeDataInstance challengeData = this.GetChallengeData(lifePointChallengeData.ChallengeId);
				if (challengeData != null)
				{
					challengeData.Phrase(lifePointChallengeData);
				}
				else
				{
					LifePointChallengeDataInstance lifePointChallengeDataInstance = new LifePointChallengeDataInstance();
					lifePointChallengeDataInstance.Phrase(lifePointChallengeData);
					this.ChallengeMap[lifePointChallengeDataInstance.GetId()] = lifePointChallengeDataInstance;
				}
			}
			for (int i = 0; i < LifePointDrawConfig.Instance.GetLifePointEntranceById(base.Id).Value.GroupListLength; i++)
			{
				int p = LifePointDrawConfig.Instance.GetLifePointEntranceById(base.Id).Value.GroupList(i);
				EventSystem.Instance.Emit<int>(EEventName.RefreshLifePointDrawGroupRedDot, p);
			}
		}
	}

	// Token: 0x060055A7 RID: 21927 RVA: 0x001C2164 File Offset: 0x001C0364
	public LifePointChallengeDataInstance GetChallengeData(int id)
	{
		LifePointChallengeDataInstance result;
		this.ChallengeMap.TryGetValue(id, out result);
		return result;
	}

	// Token: 0x060055A8 RID: 21928 RVA: 0x001C2184 File Offset: 0x001C0384
	public void OnLifePointChallengeDataUpdate(LifePointChallengeData data)
	{
		LifePointChallengeDataInstance challengeData = this.GetChallengeData(data.ChallengeId);
		if (challengeData != null)
		{
			challengeData.Phrase(data);
			return;
		}
		LifePointChallengeDataInstance lifePointChallengeDataInstance = new LifePointChallengeDataInstance();
		lifePointChallengeDataInstance.Phrase(data);
		this.ChallengeMap[lifePointChallengeDataInstance.GetId()] = lifePointChallengeDataInstance;
	}

	// Token: 0x060055A9 RID: 21929 RVA: 0x001C21C8 File Offset: 0x001C03C8
	public int GetChallengeNumber()
	{
		return this.ChallengeMap.Count;
	}

	// Token: 0x060055AA RID: 21930 RVA: 0x001C21D8 File Offset: 0x001C03D8
	public int GetFinishChallengeNumber()
	{
		int num = 0;
		using (Dictionary<int, LifePointChallengeDataInstance>.ValueCollection.Enumerator enumerator = this.ChallengeMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetHasGetReward())
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x060055AB RID: 21931 RVA: 0x001C2238 File Offset: 0x001C0438
	public int GetGroupChallengeNumber(int groupId)
	{
		int num = 0;
		for (int i = 0; i < LifePointDrawConfig.Instance.GetLifePointGroupByGroupId(groupId).Value.ChallengeListLength; i++)
		{
			int id = LifePointDrawConfig.Instance.GetLifePointGroupByGroupId(groupId).Value.ChallengeList(i);
			if (this.GetChallengeData(id) != null)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x060055AC RID: 21932 RVA: 0x001C229C File Offset: 0x001C049C
	public long GetGroupUnlockTime(int groupId)
	{
		long num = 0L;
		for (int i = 0; i < LifePointDrawConfig.Instance.GetLifePointGroupByGroupId(groupId).Value.ChallengeListLength; i++)
		{
			int id = LifePointDrawConfig.Instance.GetLifePointGroupByGroupId(groupId).Value.ChallengeList(i);
			LifePointChallengeDataInstance challengeData = this.GetChallengeData(id);
			if (challengeData != null && challengeData.GetOpenTime() > num)
			{
				num = challengeData.GetOpenTime();
			}
		}
		return num;
	}

	// Token: 0x060055AD RID: 21933 RVA: 0x001C2310 File Offset: 0x001C0510
	public bool GetGroupIfOverUnlockTime(int groupId)
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		long groupUnlockTime = this.GetGroupUnlockTime(groupId);
		return serverTime >= (double)groupUnlockTime;
	}

	// Token: 0x060055AE RID: 21934 RVA: 0x001C2338 File Offset: 0x001C0538
	public bool GetGroupHasGetReward(int groupId)
	{
		for (int i = 0; i < LifePointDrawConfig.Instance.GetLifePointGroupByGroupId(groupId).Value.ChallengeListLength; i++)
		{
			int id = LifePointDrawConfig.Instance.GetLifePointGroupByGroupId(groupId).Value.ChallengeList(i);
			LifePointChallengeDataInstance challengeData = this.GetChallengeData(id);
			if (challengeData != null && !challengeData.GetHasGetReward())
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060055AF RID: 21935 RVA: 0x001C23A0 File Offset: 0x001C05A0
	public int GetGroupRewardProgress(int groupId)
	{
		int num = 0;
		for (int i = 0; i < LifePointDrawConfig.Instance.GetLifePointGroupByGroupId(groupId).Value.ChallengeListLength; i++)
		{
			int id = LifePointDrawConfig.Instance.GetLifePointGroupByGroupId(groupId).Value.ChallengeList(i);
			LifePointChallengeDataInstance challengeData = this.GetChallengeData(id);
			if (challengeData != null && challengeData.GetHasGetReward())
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x060055B0 RID: 21936 RVA: 0x001C2410 File Offset: 0x001C0610
	public bool GetChallengeIfGetReward(int challengeId)
	{
		LifePointChallengeDataInstance challengeData = this.GetChallengeData(challengeId);
		return challengeData != null && challengeData.GetHasGetReward();
	}

	// Token: 0x060055B1 RID: 21937 RVA: 0x001C2430 File Offset: 0x001C0630
	public bool GetChallengeRequireFinishState(int challengeId)
	{
		LifePointChallengeDataInstance challengeData = this.GetChallengeData(challengeId);
		return challengeData != null && challengeData.GetPreChallengeState();
	}

	// Token: 0x060055B2 RID: 21938 RVA: 0x001C2450 File Offset: 0x001C0650
	public bool CheckIfHaveChallenge(int challengeId)
	{
		return this.ChallengeMap.ContainsKey(challengeId);
	}

	// Token: 0x060055B3 RID: 21939 RVA: 0x001C2460 File Offset: 0x001C0660
	public override bool GetExDataRedPointShowState()
	{
		if (!base.GetPreGuideQuestFinishState())
		{
			return false;
		}
		foreach (LifePointChallengeDataInstance lifePointChallengeDataInstance in this.ChallengeMap.Values)
		{
			if (LifePointDrawModel.Instance.GetChallengeRedDotState(lifePointChallengeDataInstance.GetId()))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04003B6A RID: 15210
	private Dictionary<int, LifePointChallengeDataInstance> ChallengeMap = new Dictionary<int, LifePointChallengeDataInstance>();
}

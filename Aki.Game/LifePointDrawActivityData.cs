using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02001293 RID: 4755
[NullableContext(1)]
[Nullable(0)]
public class LifePointDrawActivityData : ActivityBaseData
{
	// Token: 0x0600820F RID: 33295 RVA: 0x001B939C File Offset: 0x001B759C
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

	// Token: 0x06008210 RID: 33296 RVA: 0x001B9494 File Offset: 0x001B7694
	public LifePointChallengeDataInstance GetChallengeData(int id)
	{
		LifePointChallengeDataInstance result;
		this.ChallengeMap.TryGetValue(id, out result);
		return result;
	}

	// Token: 0x06008211 RID: 33297 RVA: 0x001B94B4 File Offset: 0x001B76B4
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

	// Token: 0x06008212 RID: 33298 RVA: 0x001B94F8 File Offset: 0x001B76F8
	public int GetChallengeNumber()
	{
		return this.ChallengeMap.Count;
	}

	// Token: 0x06008213 RID: 33299 RVA: 0x001B9508 File Offset: 0x001B7708
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

	// Token: 0x06008214 RID: 33300 RVA: 0x001B9568 File Offset: 0x001B7768
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

	// Token: 0x06008215 RID: 33301 RVA: 0x001B95CC File Offset: 0x001B77CC
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

	// Token: 0x06008216 RID: 33302 RVA: 0x001B9640 File Offset: 0x001B7840
	public bool GetGroupIfOverUnlockTime(int groupId)
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		long groupUnlockTime = this.GetGroupUnlockTime(groupId);
		return serverTime >= (double)groupUnlockTime;
	}

	// Token: 0x06008217 RID: 33303 RVA: 0x001B9668 File Offset: 0x001B7868
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

	// Token: 0x06008218 RID: 33304 RVA: 0x001B96D0 File Offset: 0x001B78D0
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

	// Token: 0x06008219 RID: 33305 RVA: 0x001B9740 File Offset: 0x001B7940
	public bool GetChallengeIfGetReward(int challengeId)
	{
		LifePointChallengeDataInstance challengeData = this.GetChallengeData(challengeId);
		return challengeData != null && challengeData.GetHasGetReward();
	}

	// Token: 0x0600821A RID: 33306 RVA: 0x001B9760 File Offset: 0x001B7960
	public bool GetChallengeRequireFinishState(int challengeId)
	{
		LifePointChallengeDataInstance challengeData = this.GetChallengeData(challengeId);
		return challengeData != null && challengeData.GetPreChallengeState();
	}

	// Token: 0x0600821B RID: 33307 RVA: 0x001B9780 File Offset: 0x001B7980
	public bool CheckIfHaveChallenge(int challengeId)
	{
		return this.ChallengeMap.ContainsKey(challengeId);
	}

	// Token: 0x0600821C RID: 33308 RVA: 0x001B9790 File Offset: 0x001B7990
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

	// Token: 0x04003AD2 RID: 15058
	private Dictionary<int, LifePointChallengeDataInstance> ChallengeMap = new Dictionary<int, LifePointChallengeDataInstance>();
}

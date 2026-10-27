using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x0200655A RID: 25946
	[NullableContext(1)]
	[Nullable(0)]
	public class LineCrossActivityData : ActivityBaseData
	{
		// Token: 0x06041053 RID: 266323 RVA: 0x00FC2368 File Offset: 0x00FC0568
		protected override void PhraseEx(ActivityData data)
		{
			LineCrossActivityData lineCrossActivityData = data.LineCrossActivityData;
			if (((lineCrossActivityData != null) ? lineCrossActivityData.Challenges : null) != null)
			{
				foreach (LineCrossChallengeData lineCrossChallengeData in lineCrossActivityData.Challenges)
				{
					LineCrossChallengeData challengeData = this.GetChallengeData(lineCrossChallengeData.ChallengeId);
					if (challengeData != null)
					{
						challengeData.Phrase(lineCrossChallengeData);
					}
					else
					{
						LineCrossChallengeData lineCrossChallengeData2 = new LineCrossChallengeData();
						lineCrossChallengeData2.Phrase(lineCrossChallengeData);
						this.ChallengeMap.Add(lineCrossChallengeData2.GetId(), lineCrossChallengeData2);
					}
				}
			}
		}

		// Token: 0x06041054 RID: 266324 RVA: 0x00FC2400 File Offset: 0x00FC0600
		[NullableContext(2)]
		public LineCrossChallengeData GetChallengeData(int id)
		{
			LineCrossChallengeData result;
			this.ChallengeMap.TryGetValue(id, out result);
			return result;
		}

		// Token: 0x06041055 RID: 266325 RVA: 0x00FC2420 File Offset: 0x00FC0620
		public void OnChallengeDataUpdate(LineCrossChallengeData data)
		{
			LineCrossChallengeData challengeData = this.GetChallengeData(data.ChallengeId);
			if (challengeData != null)
			{
				challengeData.Phrase(data);
				return;
			}
			LineCrossChallengeData lineCrossChallengeData = new LineCrossChallengeData();
			lineCrossChallengeData.Phrase(data);
			this.ChallengeMap.Add(lineCrossChallengeData.GetId(), lineCrossChallengeData);
		}

		// Token: 0x06041056 RID: 266326 RVA: 0x00FC2464 File Offset: 0x00FC0664
		public int GetChallengeNumber()
		{
			return this.ChallengeMap.Count;
		}

		// Token: 0x06041057 RID: 266327 RVA: 0x00FC2474 File Offset: 0x00FC0674
		public int GetFinishChallengeNumber()
		{
			int num = 0;
			using (Dictionary<int, LineCrossChallengeData>.ValueCollection.Enumerator enumerator = this.ChallengeMap.Values.GetEnumerator())
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

		// Token: 0x06041058 RID: 266328 RVA: 0x00FC24D4 File Offset: 0x00FC06D4
		public int GetGroupChallengeNumber(int groupId)
		{
			LineCrossGroup value = LineCrossConfig.Instance.GetLineCrossGroupByGroupId(groupId).Value;
			int num = 0;
			for (int i = 0; i < value.ChallengeListLength; i++)
			{
				int id = value.ChallengeList(i);
				if (this.GetChallengeData(id) != null)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06041059 RID: 266329 RVA: 0x00FC2524 File Offset: 0x00FC0724
		public int GetGroupRewardProgress(int groupId)
		{
			LineCrossGroup value = LineCrossConfig.Instance.GetLineCrossGroupByGroupId(groupId).Value;
			int num = 0;
			for (int i = 0; i < value.ChallengeListLength; i++)
			{
				int id = value.ChallengeList(i);
				LineCrossChallengeData challengeData = this.GetChallengeData(id);
				if (challengeData != null && challengeData.GetHasGetReward())
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x0604105A RID: 266330 RVA: 0x00FC2580 File Offset: 0x00FC0780
		public long GetGroupUnlockTime(int groupId)
		{
			LineCrossGroup value = LineCrossConfig.Instance.GetLineCrossGroupByGroupId(groupId).Value;
			long num = 0L;
			for (int i = 0; i < value.ChallengeListLength; i++)
			{
				int id = value.ChallengeList(i);
				LineCrossChallengeData challengeData = this.GetChallengeData(id);
				if (challengeData != null && challengeData.GetOpenTime() > num)
				{
					num = challengeData.GetOpenTime();
				}
			}
			return num;
		}

		// Token: 0x0604105B RID: 266331 RVA: 0x00FC25E4 File Offset: 0x00FC07E4
		public bool GetGroupHasGetReward(int groupId)
		{
			LineCrossGroup value = LineCrossConfig.Instance.GetLineCrossGroupByGroupId(groupId).Value;
			for (int i = 0; i < value.ChallengeListLength; i++)
			{
				int id = value.ChallengeList(i);
				LineCrossChallengeData challengeData = this.GetChallengeData(id);
				if (challengeData != null && !challengeData.GetHasGetReward())
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0604105C RID: 266332 RVA: 0x00FC263C File Offset: 0x00FC083C
		public bool GetIfHiddenGroup(int groupId)
		{
			return LineCrossConfig.Instance.GetLineCrossGroupByGroupId(groupId).Value.NeedFinishGroupLength > 0;
		}

		// Token: 0x0604105D RID: 266333 RVA: 0x00FC2667 File Offset: 0x00FC0867
		public bool GetChallengeRequireFinishState(int challengeId)
		{
			LineCrossChallengeData challengeData = this.GetChallengeData(challengeId);
			return challengeData != null && challengeData.GetPreChallengeState();
		}

		// Token: 0x0604105E RID: 266334 RVA: 0x00FC267C File Offset: 0x00FC087C
		public bool IfGroupShow(int groupId)
		{
			if (this.GetIfHiddenGroup(groupId))
			{
				LineCrossGroup value = LineCrossConfig.Instance.GetLineCrossGroupByGroupId(groupId).Value;
				for (int i = 0; i < value.NeedFinishGroupLength; i++)
				{
					int groupId2 = value.NeedFinishGroup(i);
					if (!this.GetGroupHasGetReward(groupId2))
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0604105F RID: 266335 RVA: 0x00FC26D0 File Offset: 0x00FC08D0
		public ELineCrossGroupState GetGroupState(int groupId)
		{
			LineCrossGroup value = LineCrossConfig.Instance.GetLineCrossGroupByGroupId(groupId).Value;
			bool flag = true;
			for (int i = 0; i < value.ChallengeListLength; i++)
			{
				int id = value.ChallengeList(i);
				LineCrossChallengeData challengeData = this.GetChallengeData(id);
				if (challengeData == null || !challengeData.GetHasGetReward())
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				return ELineCrossGroupState.Passed;
			}
			if (!this.GetGroupIfOverUnlockTime(groupId))
			{
				return ELineCrossGroupState.Lock;
			}
			return ELineCrossGroupState.Normal;
		}

		// Token: 0x06041060 RID: 266336 RVA: 0x00FC273C File Offset: 0x00FC093C
		public int[] GetShowGroupList()
		{
			LineCrossEntrance value = LineCrossConfig.Instance.GetLineCrossEntranceById(base.Id).Value;
			List<int> list = new List<int>();
			for (int i = 0; i < value.GroupListLength; i++)
			{
				int num = value.GroupList(i);
				if (this.IfGroupShow(num))
				{
					list.Add(num);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06041061 RID: 266337 RVA: 0x00FC279C File Offset: 0x00FC099C
		public bool GetGroupIfOverUnlockTime(int groupId)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			long groupUnlockTime = this.GetGroupUnlockTime(groupId);
			return serverTime >= (double)groupUnlockTime;
		}

		// Token: 0x06041062 RID: 266338 RVA: 0x00FC27C2 File Offset: 0x00FC09C2
		public bool GetChallengeIfGetReward(int challengeId)
		{
			LineCrossChallengeData challengeData = this.GetChallengeData(challengeId);
			return challengeData != null && challengeData.GetHasGetReward();
		}

		// Token: 0x06041063 RID: 266339 RVA: 0x00FC27D8 File Offset: 0x00FC09D8
		private bool IfAllChallengeFinished()
		{
			using (Dictionary<int, LineCrossChallengeData>.ValueCollection.Enumerator enumerator = this.ChallengeMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.GetHasGetReward())
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06041064 RID: 266340 RVA: 0x00FC2838 File Offset: 0x00FC0A38
		protected override bool GetExDataFinishShowState()
		{
			return this.IfAllChallengeFinished();
		}

		// Token: 0x06041065 RID: 266341 RVA: 0x00FC2840 File Offset: 0x00FC0A40
		public override bool GetExDataRedPointShowState()
		{
			if (!base.GetPreGuideQuestFinishState())
			{
				return false;
			}
			foreach (LineCrossChallengeData lineCrossChallengeData in this.ChallengeMap.Values)
			{
				if (LineCrossModel.Instance.GetChallengeRedDotState(lineCrossChallengeData.GetId()))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06041066 RID: 266342 RVA: 0x00FC28B4 File Offset: 0x00FC0AB4
		public bool CheckIfHaveChallenge(int challengeId)
		{
			return this.ChallengeMap.ContainsKey(challengeId);
		}

		// Token: 0x04021E62 RID: 138850
		private readonly Dictionary<int, LineCrossChallengeData> ChallengeMap = new Dictionary<int, LineCrossChallengeData>();
	}
}

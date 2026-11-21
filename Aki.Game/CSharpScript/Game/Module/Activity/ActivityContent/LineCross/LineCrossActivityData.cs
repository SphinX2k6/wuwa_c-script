using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x020054D8 RID: 21720
	[NullableContext(1)]
	[Nullable(0)]
	public class LineCrossActivityData : ActivityBaseData
	{
		// Token: 0x06035D18 RID: 220440 RVA: 0x00F09350 File Offset: 0x00F07550
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

		// Token: 0x06035D19 RID: 220441 RVA: 0x00F093E8 File Offset: 0x00F075E8
		[NullableContext(2)]
		public LineCrossChallengeData GetChallengeData(int id)
		{
			LineCrossChallengeData result;
			this.ChallengeMap.TryGetValue(id, out result);
			return result;
		}

		// Token: 0x06035D1A RID: 220442 RVA: 0x00F09408 File Offset: 0x00F07608
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

		// Token: 0x06035D1B RID: 220443 RVA: 0x00F0944C File Offset: 0x00F0764C
		public int GetChallengeNumber()
		{
			return this.ChallengeMap.Count;
		}

		// Token: 0x06035D1C RID: 220444 RVA: 0x00F0945C File Offset: 0x00F0765C
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

		// Token: 0x06035D1D RID: 220445 RVA: 0x00F094BC File Offset: 0x00F076BC
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

		// Token: 0x06035D1E RID: 220446 RVA: 0x00F0950C File Offset: 0x00F0770C
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

		// Token: 0x06035D1F RID: 220447 RVA: 0x00F09568 File Offset: 0x00F07768
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

		// Token: 0x06035D20 RID: 220448 RVA: 0x00F095CC File Offset: 0x00F077CC
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

		// Token: 0x06035D21 RID: 220449 RVA: 0x00F09624 File Offset: 0x00F07824
		public bool GetIfHiddenGroup(int groupId)
		{
			return LineCrossConfig.Instance.GetLineCrossGroupByGroupId(groupId).Value.NeedFinishGroupLength > 0;
		}

		// Token: 0x06035D22 RID: 220450 RVA: 0x00F0964F File Offset: 0x00F0784F
		public bool GetChallengeRequireFinishState(int challengeId)
		{
			LineCrossChallengeData challengeData = this.GetChallengeData(challengeId);
			return challengeData != null && challengeData.GetPreChallengeState();
		}

		// Token: 0x06035D23 RID: 220451 RVA: 0x00F09664 File Offset: 0x00F07864
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

		// Token: 0x06035D24 RID: 220452 RVA: 0x00F096B8 File Offset: 0x00F078B8
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

		// Token: 0x06035D25 RID: 220453 RVA: 0x00F09724 File Offset: 0x00F07924
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

		// Token: 0x06035D26 RID: 220454 RVA: 0x00F09784 File Offset: 0x00F07984
		public bool GetGroupIfOverUnlockTime(int groupId)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			long groupUnlockTime = this.GetGroupUnlockTime(groupId);
			return serverTime >= (double)groupUnlockTime;
		}

		// Token: 0x06035D27 RID: 220455 RVA: 0x00F097AA File Offset: 0x00F079AA
		public bool GetChallengeIfGetReward(int challengeId)
		{
			LineCrossChallengeData challengeData = this.GetChallengeData(challengeId);
			return challengeData != null && challengeData.GetHasGetReward();
		}

		// Token: 0x06035D28 RID: 220456 RVA: 0x00F097C0 File Offset: 0x00F079C0
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

		// Token: 0x06035D29 RID: 220457 RVA: 0x00F09820 File Offset: 0x00F07A20
		protected override bool GetExDataFinishShowState()
		{
			return this.IfAllChallengeFinished();
		}

		// Token: 0x06035D2A RID: 220458 RVA: 0x00F09828 File Offset: 0x00F07A28
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

		// Token: 0x06035D2B RID: 220459 RVA: 0x00F0989C File Offset: 0x00F07A9C
		public bool CheckIfHaveChallenge(int challengeId)
		{
			return this.ChallengeMap.ContainsKey(challengeId);
		}

		// Token: 0x0401C793 RID: 116627
		private readonly Dictionary<int, LineCrossChallengeData> ChallengeMap = new Dictionary<int, LineCrossChallengeData>();
	}
}

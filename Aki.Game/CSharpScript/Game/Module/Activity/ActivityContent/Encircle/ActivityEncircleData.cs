using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02006650 RID: 26192
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEncircleData : ActivityBaseData
	{
		// Token: 0x06041A89 RID: 268937 RVA: 0x00FECED0 File Offset: 0x00FEB0D0
		protected override void PhraseEx(ActivityData data)
		{
			EncircleActivityPb encircleActivityPb = data.EncircleActivityPb;
			RepeatedField<EncircleChallengePb> repeatedField = (encircleActivityPb != null) ? encircleActivityPb.Challenges : null;
			if (repeatedField == null)
			{
				return;
			}
			foreach (EncircleChallengePb encircleChallengePb in repeatedField)
			{
				this.ChallengeState[encircleChallengePb.ChallengeId] = encircleChallengePb;
			}
		}

		// Token: 0x06041A8A RID: 268938 RVA: 0x00FECF3C File Offset: 0x00FEB13C
		public bool CheckChallengeNewUnlock(int challengeId)
		{
			bool flag;
			return this.UnlockNewChallenge.TryGetValue(challengeId, out flag) && flag;
		}

		// Token: 0x06041A8B RID: 268939 RVA: 0x00FECF5C File Offset: 0x00FEB15C
		public void MarkChallengeNewUnlock(int challengeId, bool value = false)
		{
			this.UnlockNewChallenge[challengeId] = value;
		}

		// Token: 0x06041A8C RID: 268940 RVA: 0x00FECF6C File Offset: 0x00FEB16C
		public bool CheckChallengeComplete(int challengeId)
		{
			EncircleChallengePb encircleChallengePb;
			return this.ChallengeState.TryGetValue(challengeId, out encircleChallengePb) && encircleChallengePb.Pass;
		}

		// Token: 0x06041A8D RID: 268941 RVA: 0x00FECF94 File Offset: 0x00FEB194
		public bool CheckPreChallengeComplete(int challengeId)
		{
			EncircleChallenge? encircleChallengeConfig = ActivityEncircleConfig.Instance.GetEncircleChallengeConfig(challengeId);
			return encircleChallengeConfig.Value.PreId == 0 || this.CheckChallengeComplete(encircleChallengeConfig.Value.PreId);
		}

		// Token: 0x06041A8E RID: 268942 RVA: 0x00FECFD8 File Offset: 0x00FEB1D8
		public int GetCompleteChallengeCount()
		{
			int activityId = ActivityEncircleController.Instance.ActivityId;
			IReadOnlyList<EncircleChallengeGroup> encircleGroups = ActivityEncircleConfig.Instance.GetEncircleGroups(activityId);
			if (encircleGroups == null)
			{
				return 0;
			}
			int num = 0;
			foreach (EncircleChallengeGroup encircleChallengeGroup in encircleGroups)
			{
				if (this.CheckChallengeComplete(encircleChallengeGroup.Challenges(0)))
				{
					num++;
				}
				if (this.CheckChallengeComplete(encircleChallengeGroup.Challenges(1)))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06041A8F RID: 268943 RVA: 0x00FED064 File Offset: 0x00FEB264
		public int GetCurrentChallengeCount()
		{
			int activityId = ActivityEncircleController.Instance.ActivityId;
			IReadOnlyList<EncircleChallengeGroup> encircleGroups = ActivityEncircleConfig.Instance.GetEncircleGroups(activityId);
			if (encircleGroups == null)
			{
				return 0;
			}
			int num = 0;
			foreach (EncircleChallengeGroup encircleChallengeGroup in encircleGroups)
			{
				num += encircleChallengeGroup.Challenges().Length;
			}
			return num;
		}

		// Token: 0x06041A90 RID: 268944 RVA: 0x00FED0D4 File Offset: 0x00FEB2D4
		public int GetCurrentChallenge()
		{
			int activityId = ActivityEncircleController.Instance.ActivityId;
			IReadOnlyList<EncircleChallengeGroup> encircleGroups = ActivityEncircleConfig.Instance.GetEncircleGroups(activityId);
			if (encircleGroups == null)
			{
				return 0;
			}
			foreach (EncircleChallengeGroup encircleChallengeGroup in encircleGroups)
			{
				foreach (int num in encircleChallengeGroup.ChallengesIter())
				{
					if (!this.CheckChallengeComplete(num))
					{
						return num;
					}
				}
			}
			return 0;
		}

		// Token: 0x06041A91 RID: 268945 RVA: 0x00FED184 File Offset: 0x00FEB384
		public int GetCurrentGroup()
		{
			int activityId = ActivityEncircleController.Instance.ActivityId;
			IReadOnlyList<EncircleChallengeGroup> encircleGroups = ActivityEncircleConfig.Instance.GetEncircleGroups(activityId);
			if (encircleGroups == null)
			{
				return 0;
			}
			foreach (EncircleChallengeGroup encircleChallengeGroup in encircleGroups)
			{
				if (!this.CheckChallengeComplete(encircleChallengeGroup.Challenges(0)))
				{
					return encircleChallengeGroup.Id;
				}
			}
			return encircleGroups.Count;
		}

		// Token: 0x06041A92 RID: 268946 RVA: 0x00FED208 File Offset: 0x00FEB408
		public int GetChallengeRecord(int challengeId)
		{
			EncircleChallengePb encircleChallengePb;
			if (!this.ChallengeState.TryGetValue(challengeId, out encircleChallengePb))
			{
				return 0;
			}
			return encircleChallengePb.MinStep;
		}

		// Token: 0x06041A93 RID: 268947 RVA: 0x00FED230 File Offset: 0x00FEB430
		public void UpdateChallengeInfo(EncircleChallengePb challengeInfo)
		{
			bool flag;
			if ((!this.UnlockNewChallenge.TryGetValue(challengeInfo.ChallengeId, out flag) || !flag) && !this.CheckChallengeComplete(challengeInfo.ChallengeId) && ActivityEncircleConfig.Instance.GetEncircleChallengeConfig(challengeInfo.ChallengeId).Value.Difficulty == 0)
			{
				this.UnlockNewChallenge[challengeInfo.ChallengeId] = true;
			}
			this.ChallengeState[challengeInfo.ChallengeId] = challengeInfo;
			EventSystem.Instance.Emit<EncircleChallengePb>(EEventName.EncircleDataUpdate, challengeInfo);
		}

		// Token: 0x06041A94 RID: 268948 RVA: 0x00FED2BC File Offset: 0x00FEB4BC
		public bool CheckChallengeIsOpen(int challengeId)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			EncircleChallengePb encircleChallengePb;
			if (!this.ChallengeState.TryGetValue(challengeId, out encircleChallengePb))
			{
				return false;
			}
			long num = MathUtils.Instance.LongToBigInt(encircleChallengePb.OpenTime);
			return serverTime >= (double)num;
		}

		// Token: 0x06041A95 RID: 268949 RVA: 0x00FED300 File Offset: 0x00FEB500
		public string GetUnlockDesc(int challengeId)
		{
			long num = MathUtils.Instance.LongToBigInt(this.ChallengeState[challengeId].OpenTime);
			double serverTime = TimeUtil.Instance.GetServerTime();
			if (serverTime >= (double)num)
			{
				return "";
			}
			string countDownText = TimeUtil.Instance.GetRemainTimeDataFormat3((double)num - serverTime).CountDownText;
			if (countDownText == null)
			{
				return "";
			}
			return countDownText;
		}

		// Token: 0x06041A96 RID: 268950 RVA: 0x00FED360 File Offset: 0x00FEB560
		public bool CheckGroupRedPointShow(int groupId)
		{
			EncircleChallengeGroup? encircleGroup = ActivityEncircleConfig.Instance.GetEncircleGroup(groupId);
			bool result = false;
			if (this.CheckChallengeRedPointShow(encircleGroup.Value.Challenges(0)))
			{
				result = true;
			}
			if (this.CheckChallengeRedPointShow(encircleGroup.Value.Challenges(1)))
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06041A97 RID: 268951 RVA: 0x00FED3B0 File Offset: 0x00FEB5B0
		public bool CheckChallengeRedPointShow(int challengeId)
		{
			int activityId = ActivityEncircleController.Instance.ActivityId;
			EncircleChallenge? encircleChallengeConfig = ActivityEncircleConfig.Instance.GetEncircleChallengeConfig(challengeId);
			return !this.CheckChallengeComplete(challengeId) && this.CheckChallengeIsOpen(challengeId) && (encircleChallengeConfig.Value.PreId == 0 || this.CheckChallengeComplete(encircleChallengeConfig.Value.PreId)) && ActivityModel.Instance.GetActivityCacheData(activityId, 0, 10001, challengeId, 0) == 0;
		}

		// Token: 0x06041A98 RID: 268952 RVA: 0x00FED42C File Offset: 0x00FEB62C
		protected override bool GetExDataFinishShowState()
		{
			return this.GetCompleteChallengeCount() == this.GetCurrentChallengeCount();
		}

		// Token: 0x06041A99 RID: 268953 RVA: 0x00FED43C File Offset: 0x00FEB63C
		public override bool GetExDataRedPointShowState()
		{
			return ActivityEncircleController.Instance.GetRedPointShow();
		}

		// Token: 0x0402228E RID: 139918
		private readonly Dictionary<int, EncircleChallengePb> ChallengeState = new Dictionary<int, EncircleChallengePb>();

		// Token: 0x0402228F RID: 139919
		private readonly Dictionary<int, bool> UnlockNewChallenge = new Dictionary<int, bool>();
	}
}

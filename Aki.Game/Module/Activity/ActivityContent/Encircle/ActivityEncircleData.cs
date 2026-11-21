using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02002FFD RID: 12285
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEncircleData : ActivityBaseData
	{
		// Token: 0x0601D2A7 RID: 119463 RVA: 0x008E8914 File Offset: 0x008E6B14
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

		// Token: 0x0601D2A8 RID: 119464 RVA: 0x008E8980 File Offset: 0x008E6B80
		public bool CheckChallengeNewUnlock(int challengeId)
		{
			bool flag;
			return this.UnlockNewChallenge.TryGetValue(challengeId, out flag) && flag;
		}

		// Token: 0x0601D2A9 RID: 119465 RVA: 0x008E899D File Offset: 0x008E6B9D
		public void MarkChallengeNewUnlock(int challengeId, bool value = false)
		{
			this.UnlockNewChallenge[challengeId] = value;
		}

		// Token: 0x0601D2AA RID: 119466 RVA: 0x008E89AC File Offset: 0x008E6BAC
		public bool CheckChallengeComplete(int challengeId)
		{
			EncircleChallengePb encircleChallengePb;
			return this.ChallengeState.TryGetValue(challengeId, out encircleChallengePb) && encircleChallengePb.Pass;
		}

		// Token: 0x0601D2AB RID: 119467 RVA: 0x008E89D4 File Offset: 0x008E6BD4
		public bool CheckPreChallengeComplete(int challengeId)
		{
			EncircleChallenge value = ActivityEncircleConfig.Instance.GetEncircleChallengeConfig(challengeId).Value;
			return value.PreId == 0 || this.CheckChallengeComplete(value.PreId);
		}

		// Token: 0x0601D2AC RID: 119468 RVA: 0x008E8A10 File Offset: 0x008E6C10
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

		// Token: 0x0601D2AD RID: 119469 RVA: 0x008E8A9C File Offset: 0x008E6C9C
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
				num += encircleChallengeGroup.ChallengesLength;
			}
			return num;
		}

		// Token: 0x0601D2AE RID: 119470 RVA: 0x008E8B08 File Offset: 0x008E6D08
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

		// Token: 0x0601D2AF RID: 119471 RVA: 0x008E8BB8 File Offset: 0x008E6DB8
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

		// Token: 0x0601D2B0 RID: 119472 RVA: 0x008E8C3C File Offset: 0x008E6E3C
		public int GetChallengeRecord(int challengeId)
		{
			EncircleChallengePb encircleChallengePb;
			if (!this.ChallengeState.TryGetValue(challengeId, out encircleChallengePb))
			{
				return 0;
			}
			return encircleChallengePb.MinStep;
		}

		// Token: 0x0601D2B1 RID: 119473 RVA: 0x008E8C64 File Offset: 0x008E6E64
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

		// Token: 0x0601D2B2 RID: 119474 RVA: 0x008E8CF0 File Offset: 0x008E6EF0
		public bool CheckChallengeIsOpen(int challengeId)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			EncircleChallengePb encircleChallengePb;
			if (!this.ChallengeState.TryGetValue(challengeId, out encircleChallengePb))
			{
				return false;
			}
			long openTime = encircleChallengePb.OpenTime;
			return serverTime >= (double)openTime;
		}

		// Token: 0x0601D2B3 RID: 119475 RVA: 0x008E8D2C File Offset: 0x008E6F2C
		public string GetUnlockDesc(int challengeId)
		{
			long openTime = this.ChallengeState[challengeId].OpenTime;
			double serverTime = TimeUtil.Instance.GetServerTime();
			if (serverTime >= (double)openTime)
			{
				return "";
			}
			string countDownText = TimeUtil.Instance.GetRemainTimeDataFormat3((double)openTime - serverTime).CountDownText;
			if (countDownText == null)
			{
				return "";
			}
			return countDownText;
		}

		// Token: 0x0601D2B4 RID: 119476 RVA: 0x008E8D80 File Offset: 0x008E6F80
		public bool CheckGroupRedPointShow(int groupId)
		{
			EncircleChallengeGroup value = ActivityEncircleConfig.Instance.GetEncircleGroup(groupId).Value;
			return this.CheckChallengeRedPointShow(value.Challenges(0)) || this.CheckChallengeRedPointShow(value.Challenges(1));
		}

		// Token: 0x0601D2B5 RID: 119477 RVA: 0x008E8DC4 File Offset: 0x008E6FC4
		public bool CheckChallengeRedPointShow(int challengeId)
		{
			int activityId = ActivityEncircleController.Instance.ActivityId;
			return !this.CheckChallengeComplete(challengeId) && this.CheckChallengeIsOpen(challengeId) && this.CheckPreChallengeComplete(challengeId) && ActivityModel.Instance.GetActivityCacheData(activityId, 0, 10001, challengeId, 0) == 0;
		}

		// Token: 0x0601D2B6 RID: 119478 RVA: 0x008E8E15 File Offset: 0x008E7015
		protected override bool GetExDataFinishShowState()
		{
			return this.GetCompleteChallengeCount() == this.GetCurrentChallengeCount();
		}

		// Token: 0x0601D2B7 RID: 119479 RVA: 0x008E8E25 File Offset: 0x008E7025
		public override bool GetExDataRedPointShowState()
		{
			return ActivityEncircleController.Instance.GetRedPointShow();
		}

		// Token: 0x0400F598 RID: 62872
		private readonly Dictionary<int, EncircleChallengePb> ChallengeState = new Dictionary<int, EncircleChallengePb>();

		// Token: 0x0400F599 RID: 62873
		private readonly Dictionary<int, bool> UnlockNewChallenge = new Dictionary<int, bool>();
	}
}

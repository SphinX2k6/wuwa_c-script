using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FC8 RID: 24520
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityTetrisData : ActivityBaseData
	{
		// Token: 0x0603E256 RID: 254550 RVA: 0x00F024F4 File Offset: 0x00F006F4
		protected override void PhraseEx(ActivityData data)
		{
			TetrisActivityInfo tetrisActivityInfo = data.TetrisActivityInfo;
			RepeatedField<TetrisLevelInfo> repeatedField = (tetrisActivityInfo != null) ? tetrisActivityInfo.TetrisLevelInfos : null;
			if (repeatedField == null)
			{
				return;
			}
			foreach (TetrisLevelInfo tetrisLevelInfo in repeatedField)
			{
				this.ChallengeState[tetrisLevelInfo.Id] = tetrisLevelInfo;
			}
		}

		// Token: 0x0603E257 RID: 254551 RVA: 0x00F02560 File Offset: 0x00F00760
		public bool CheckChallengeComplete(int challengeId)
		{
			TetrisLevelInfo tetrisLevelInfo;
			return this.ChallengeState.TryGetValue(challengeId, out tetrisLevelInfo) && tetrisLevelInfo.State == TetrisState.TetrisFinished;
		}

		// Token: 0x0603E258 RID: 254552 RVA: 0x00F02588 File Offset: 0x00F00788
		public bool CheckPreChallengeComplete(int challengeId)
		{
			Tetris levelConfig = ActivityTetrisConfig.Instance.GetLevelConfig(challengeId);
			return levelConfig.UnlockId == 0 || this.CheckChallengeComplete(levelConfig.UnlockId);
		}

		// Token: 0x0603E259 RID: 254553 RVA: 0x00F025BC File Offset: 0x00F007BC
		public bool CheckChallengeIsOpen(int challengeId)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			if (!this.ChallengeState.ContainsKey(challengeId))
			{
				return false;
			}
			long unlockTime = this.ChallengeState[challengeId].UnlockTime;
			return serverTime >= (double)unlockTime;
		}

		// Token: 0x0603E25A RID: 254554 RVA: 0x00F02600 File Offset: 0x00F00800
		public void UpdateChallengeState(int challengeId, TetrisState state)
		{
			TetrisLevelInfo tetrisLevelInfo;
			if (!this.ChallengeState.TryGetValue(challengeId, out tetrisLevelInfo))
			{
				return;
			}
			tetrisLevelInfo.State = state;
			EventSystem.Instance.Emit<int>(EEventName.OnTetrisChallengeStateUpdate, challengeId);
		}

		// Token: 0x0603E25B RID: 254555 RVA: 0x00F02638 File Offset: 0x00F00838
		public bool CheckGroupRedPointShow(List<int> challengeIds)
		{
			foreach (int challengeId in challengeIds)
			{
				if (this.CheckChallengeRedPointShow(challengeId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603E25C RID: 254556 RVA: 0x00F02690 File Offset: 0x00F00890
		public bool CheckChallengeRedPointShow(int challengeId)
		{
			int activityId = ActivityTetrisController.Instance.ActivityId;
			Tetris levelConfig = ActivityTetrisConfig.Instance.GetLevelConfig(challengeId);
			return !this.CheckChallengeComplete(challengeId) && this.CheckChallengeIsOpen(challengeId) && (levelConfig.UnlockId == 0 || this.CheckChallengeComplete(levelConfig.UnlockId)) && ActivityModel.Instance.GetActivityCacheData(activityId, 0, 10001, challengeId, 0) == 0;
		}

		// Token: 0x0603E25D RID: 254557 RVA: 0x00F026FC File Offset: 0x00F008FC
		public string GetUnlockDesc(int challengeId)
		{
			long unlockTime = this.ChallengeState[challengeId].UnlockTime;
			double serverTime = TimeUtil.Instance.GetServerTime();
			if (serverTime >= (double)unlockTime)
			{
				return "";
			}
			string countDownText = TimeUtil.Instance.GetRemainTimeDataFormat3((double)unlockTime - serverTime).CountDownText;
			if (countDownText == null)
			{
				return "";
			}
			return countDownText;
		}

		// Token: 0x0603E25E RID: 254558 RVA: 0x00F02750 File Offset: 0x00F00950
		public int GetCompleteChallengeCount()
		{
			int num = 0;
			using (Dictionary<int, TetrisLevelInfo>.ValueCollection.Enumerator enumerator = this.ChallengeState.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.State == TetrisState.TetrisFinished)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x0603E25F RID: 254559 RVA: 0x00F027B0 File Offset: 0x00F009B0
		public int GetCurrentChallengeCount()
		{
			return this.ChallengeState.Count;
		}

		// Token: 0x0603E260 RID: 254560 RVA: 0x00F027C0 File Offset: 0x00F009C0
		public int GetDisplayChallengeCount()
		{
			int num = 0;
			foreach (int num2 in this.ChallengeState.Keys)
			{
				if (TetrisUtils.IsEggLevel(ActivityTetrisConfig.Instance.GetLevelConfig(num2)))
				{
					if (this.CheckPreChallengeComplete(num2))
					{
						num++;
					}
				}
				else
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x0603E261 RID: 254561 RVA: 0x00F0283C File Offset: 0x00F00A3C
		protected override bool GetExDataFinishShowState()
		{
			return this.GetCompleteChallengeCount() == this.GetCurrentChallengeCount();
		}

		// Token: 0x0603E262 RID: 254562 RVA: 0x00F0284C File Offset: 0x00F00A4C
		public override bool GetExDataRedPointShowState()
		{
			return base.GetPreGuideQuestFinishState() && ActivityTetrisController.Instance.GetRedPointShow();
		}

		// Token: 0x04020768 RID: 132968
		private readonly Dictionary<int, TetrisLevelInfo> ChallengeState = new Dictionary<int, TetrisLevelInfo>();
	}
}

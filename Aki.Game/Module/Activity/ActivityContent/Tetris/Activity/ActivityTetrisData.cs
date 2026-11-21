using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.Activity
{
	// Token: 0x02002FF8 RID: 12280
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityTetrisData : ActivityBaseData
	{
		// Token: 0x0601D268 RID: 119400 RVA: 0x008E7DBC File Offset: 0x008E5FBC
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

		// Token: 0x0601D269 RID: 119401 RVA: 0x008E7E28 File Offset: 0x008E6028
		public bool CheckChallengeComplete(int challengeId)
		{
			TetrisLevelInfo tetrisLevelInfo;
			return this.ChallengeState.TryGetValue(challengeId, out tetrisLevelInfo) && tetrisLevelInfo.State == TetrisState.TetrisFinished;
		}

		// Token: 0x0601D26A RID: 119402 RVA: 0x008E7E50 File Offset: 0x008E6050
		public bool CheckPreChallengeComplete(int challengeId)
		{
			Tetris levelConfig = ActivityTetrisConfig.Instance.GetLevelConfig(challengeId);
			return levelConfig.UnlockId == 0 || this.CheckChallengeComplete(levelConfig.UnlockId);
		}

		// Token: 0x0601D26B RID: 119403 RVA: 0x008E7E84 File Offset: 0x008E6084
		public bool CheckChallengeIsOpen(int challengeId)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			TetrisLevelInfo tetrisLevelInfo;
			if (!this.ChallengeState.TryGetValue(challengeId, out tetrisLevelInfo))
			{
				return false;
			}
			long unlockTime = tetrisLevelInfo.UnlockTime;
			return serverTime >= (double)unlockTime;
		}

		// Token: 0x0601D26C RID: 119404 RVA: 0x008E7EC0 File Offset: 0x008E60C0
		public bool UpdateChallengeState(int challengeId, TetrisState state)
		{
			TetrisLevelInfo tetrisLevelInfo;
			if (!this.ChallengeState.TryGetValue(challengeId, out tetrisLevelInfo))
			{
				return false;
			}
			tetrisLevelInfo.State = state;
			EventSystem.Instance.Emit<int>(EEventName.OnTetrisChallengeStateUpdate, challengeId);
			return true;
		}

		// Token: 0x0601D26D RID: 119405 RVA: 0x008E7EF8 File Offset: 0x008E60F8
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

		// Token: 0x0601D26E RID: 119406 RVA: 0x008E7F50 File Offset: 0x008E6150
		public bool CheckChallengeRedPointShow(int challengeId)
		{
			int activityId = ActivityTetrisController.Instance.ActivityId;
			Tetris levelConfig = ActivityTetrisConfig.Instance.GetLevelConfig(challengeId);
			return !this.CheckChallengeComplete(challengeId) && this.CheckChallengeIsOpen(challengeId) && (levelConfig.UnlockId == 0 || this.CheckChallengeComplete(levelConfig.UnlockId)) && ActivityModel.Instance.GetActivityCacheData(activityId, 0, 10001, challengeId, 0) == 0;
		}

		// Token: 0x0601D26F RID: 119407 RVA: 0x008E7FBC File Offset: 0x008E61BC
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

		// Token: 0x0601D270 RID: 119408 RVA: 0x008E8010 File Offset: 0x008E6210
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

		// Token: 0x0601D271 RID: 119409 RVA: 0x008E8070 File Offset: 0x008E6270
		public int GetCurrentChallengeCount()
		{
			return this.ChallengeState.Count;
		}

		// Token: 0x0601D272 RID: 119410 RVA: 0x008E8080 File Offset: 0x008E6280
		public int GetDisplayChallengeCount()
		{
			int num = 0;
			foreach (int num2 in this.ChallengeState.Keys)
			{
				if (TetrisUtils.IsActivityEggLevel(ActivityTetrisConfig.Instance.GetLevelConfig(num2)))
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

		// Token: 0x0601D273 RID: 119411 RVA: 0x008E80FC File Offset: 0x008E62FC
		public int? GetChallengeRecord(int challengeId, int key)
		{
			bool flag = key < 0 || key > 6;
			if (flag)
			{
				return null;
			}
			TetrisLevelInfo tetrisLevelInfo;
			if (!this.ChallengeState.TryGetValue(challengeId, out tetrisLevelInfo))
			{
				return null;
			}
			if (!ActivityTetrisConfig.Instance.GetLevelConfig(challengeId).NeedRecord)
			{
				return null;
			}
			return new int?(tetrisLevelInfo.Results.GetValueOrDefault(key, 0));
		}

		// Token: 0x0601D274 RID: 119412 RVA: 0x008E8170 File Offset: 0x008E6370
		public bool UpdateLocalChallengeRecords(int challengeId, Dictionary<int, int> results)
		{
			TetrisLevelInfo tetrisLevelInfo;
			if (!this.ChallengeState.TryGetValue(challengeId, out tetrisLevelInfo))
			{
				return false;
			}
			if (!ActivityTetrisConfig.Instance.GetLevelConfig(challengeId).NeedRecord)
			{
				return false;
			}
			bool result = false;
			foreach (KeyValuePair<int, int> keyValuePair in results)
			{
				int num;
				if (tetrisLevelInfo.Results.TryGetValue(keyValuePair.Key, out num))
				{
					if (num < keyValuePair.Value)
					{
						tetrisLevelInfo.Results[keyValuePair.Key] = keyValuePair.Value;
						result = true;
					}
				}
				else
				{
					tetrisLevelInfo.Results.Add(keyValuePair.Key, keyValuePair.Value);
				}
			}
			return result;
		}

		// Token: 0x0601D275 RID: 119413 RVA: 0x008E823C File Offset: 0x008E643C
		protected override bool GetExDataFinishShowState()
		{
			return this.GetCompleteChallengeCount() == this.GetCurrentChallengeCount();
		}

		// Token: 0x0601D276 RID: 119414 RVA: 0x008E824C File Offset: 0x008E644C
		public override bool GetExDataRedPointShowState()
		{
			return base.GetPreGuideQuestFinishState() && ActivityTetrisController.Instance.GetRedPointShow();
		}

		// Token: 0x0400F58E RID: 62862
		private readonly Dictionary<int, TetrisLevelInfo> ChallengeState = new Dictionary<int, TetrisLevelInfo>();
	}
}

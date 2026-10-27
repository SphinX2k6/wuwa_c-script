using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x02006680 RID: 26240
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchActivityData : ActivityBaseData
	{
		// Token: 0x06041BFD RID: 269309 RVA: 0x00FF2D7C File Offset: 0x00FF0F7C
		protected override void PhraseEx(ActivityData data)
		{
			if (data == null)
			{
				return;
			}
			DropCatchActivityInfo dropCatchActivityInfo = data.DropCatchActivityInfo;
			if (dropCatchActivityInfo == null)
			{
				return;
			}
			this.PreferredOpenLevelId = 0;
			this.OnLevelRewardUpdateNotify(dropCatchActivityInfo.DropCatchLevelInfos);
		}

		// Token: 0x06041BFE RID: 269310 RVA: 0x00FF2DAC File Offset: 0x00FF0FAC
		[NullableContext(2)]
		public DropCatchLevelData GetLevelData(int configId)
		{
			DropCatchLevelData result;
			this.LevelInfoMap.TryGetValue(configId, out result);
			return result;
		}

		// Token: 0x06041BFF RID: 269311 RVA: 0x00FF2DCC File Offset: 0x00FF0FCC
		[NullableContext(2)]
		public DropCatchLevelData GetLastLevelData(int configId)
		{
			IReadOnlyList<DropCatchGameplay> dropCatchGameplayByActivityId = DropCatchConfig.Instance.GetDropCatchGameplayByActivityId(base.Id);
			if (dropCatchGameplayByActivityId == null)
			{
				return null;
			}
			DropCatchLevelData result = null;
			foreach (DropCatchGameplay dropCatchGameplay in dropCatchGameplayByActivityId)
			{
				if (dropCatchGameplay.NextGameplayId == configId)
				{
					result = this.GetLevelData(dropCatchGameplay.Id);
					break;
				}
			}
			return result;
		}

		// Token: 0x06041C00 RID: 269312 RVA: 0x00FF2E40 File Offset: 0x00FF1040
		public EDropCatchLevelState? GetLevelStarStatus(int configId, int starIndex)
		{
			if (this.GetLevelData(configId) != null)
			{
				DropCatchLevelData dropCatchLevelData;
				this.LevelInfoMap.TryGetValue(configId, out dropCatchLevelData);
				List<EDropCatchLevelState> list = (dropCatchLevelData != null) ? dropCatchLevelData.RewardStates : null;
				if (list != null && list.Count > starIndex)
				{
					return new EDropCatchLevelState?(list[starIndex]);
				}
			}
			return new EDropCatchLevelState?(EDropCatchLevelState.Lock);
		}

		// Token: 0x06041C01 RID: 269313 RVA: 0x00FF2E94 File Offset: 0x00FF1094
		public int GetDefaultOpenCfgId()
		{
			IReadOnlyList<DropCatchGameplay> dropCatchGameplayByActivityId = DropCatchConfig.Instance.GetDropCatchGameplayByActivityId(base.Id);
			if (dropCatchGameplayByActivityId == null || dropCatchGameplayByActivityId.Count == 0)
			{
				return 0;
			}
			if (this.PreferredOpenLevelId != 0)
			{
				int preferredOpenLevelId = this.PreferredOpenLevelId;
				this.PreferredOpenLevelId = 0;
				return preferredOpenLevelId;
			}
			int count = dropCatchGameplayByActivityId.Count;
			int id = dropCatchGameplayByActivityId[count - 1].Id;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			bool flag = true;
			bool flag2 = true;
			for (int i = 0; i < count; i++)
			{
				int id2 = dropCatchGameplayByActivityId[i].Id;
				DropCatchLevelData levelData = this.GetLevelData(id2);
				if (levelData == null || !levelData.IsUnlock)
				{
					flag = false;
				}
				else
				{
					if (i > 0)
					{
						int id3 = dropCatchGameplayByActivityId[i - 1].Id;
						DropCatchLevelData levelData2 = this.GetLevelData(id3);
						if (levelData2 != null)
						{
							EDropCatchLevelState? targetStarState = levelData2.GetTargetStarState(0);
							EDropCatchLevelState edropCatchLevelState = EDropCatchLevelState.Lock;
							if (targetStarState.GetValueOrDefault() == edropCatchLevelState & targetStarState != null)
							{
								flag = false;
								goto IL_109;
							}
						}
					}
					num3 = id2;
					if (levelData.CanReceiveReward && num == 0)
					{
						num = id2;
					}
					if (!levelData.IsAllStar)
					{
						flag2 = false;
						if (num2 == 0)
						{
							num2 = id2;
						}
					}
				}
				IL_109:;
			}
			if (num != 0)
			{
				return num;
			}
			if (flag)
			{
				if (!flag2 && num2 != 0)
				{
					return num2;
				}
				return id;
			}
			else
			{
				if (num3 != 0)
				{
					return num3;
				}
				return dropCatchGameplayByActivityId[0].Id;
			}
		}

		// Token: 0x06041C02 RID: 269314 RVA: 0x00FF2FE5 File Offset: 0x00FF11E5
		public void SetPreferredOpenLevel(int levelId)
		{
			this.PreferredOpenLevelId = levelId;
		}

		// Token: 0x06041C03 RID: 269315 RVA: 0x00FF2FF0 File Offset: 0x00FF11F0
		public bool GetCanReceive()
		{
			foreach (DropCatchLevelData dropCatchLevelData in this.LevelInfoMap.Values)
			{
				if (dropCatchLevelData.RewardStates != null)
				{
					using (List<EDropCatchLevelState>.Enumerator enumerator2 = dropCatchLevelData.RewardStates.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current == EDropCatchLevelState.Unlock)
							{
								return true;
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06041C04 RID: 269316 RVA: 0x00FF3090 File Offset: 0x00FF1290
		public int GetFinishLevelCount()
		{
			int num = 0;
			using (Dictionary<int, DropCatchLevelData>.ValueCollection.Enumerator enumerator = this.LevelInfoMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsAllRewarded)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06041C05 RID: 269317 RVA: 0x00FF30F0 File Offset: 0x00FF12F0
		public void OnLevelRewardUpdateNotify(IList<DropCatchLevelInfo> levelInfos)
		{
			if (levelInfos == null || levelInfos.Count == 0)
			{
				return;
			}
			foreach (DropCatchLevelInfo info in levelInfos)
			{
				this.UpdateTargetLevelData(info);
			}
		}

		// Token: 0x06041C06 RID: 269318 RVA: 0x00FF3144 File Offset: 0x00FF1344
		public void UpdateTargetLevelData(DropCatchLevelInfo info)
		{
			if (info == null)
			{
				return;
			}
			int dropCatchId = info.DropCatchId;
			DropCatchLevelData dropCatchLevelData;
			if (!this.LevelInfoMap.TryGetValue(dropCatchId, out dropCatchLevelData))
			{
				dropCatchLevelData = new DropCatchLevelData();
			}
			if (dropCatchLevelData != null)
			{
				dropCatchLevelData.ConfigId = dropCatchId;
				dropCatchLevelData.RewardStates = new List<EDropCatchLevelState>();
				foreach (int item in info.RewardStates)
				{
					dropCatchLevelData.RewardStates.Add((EDropCatchLevelState)item);
				}
				dropCatchLevelData.UnlockTime = (double)MathUtils.Instance.LongToNumber(info.UnlockTime);
				dropCatchLevelData.HighestScore = info.Score;
				if (this.LevelInfoMap.ContainsKey(dropCatchId))
				{
					this.LevelInfoMap[dropCatchId] = dropCatchLevelData;
					return;
				}
				this.LevelInfoMap.Add(dropCatchId, dropCatchLevelData);
			}
		}

		// Token: 0x06041C07 RID: 269319 RVA: 0x00FF321C File Offset: 0x00FF141C
		public override bool GetExDataRedPointShowState()
		{
			return this.GetCanReceive();
		}

		// Token: 0x06041C08 RID: 269320 RVA: 0x00FF3224 File Offset: 0x00FF1424
		protected override bool GetExDataFinishShowState()
		{
			if (this.LevelInfoMap == null || this.LevelInfoMap.Count == 0)
			{
				return false;
			}
			foreach (KeyValuePair<int, DropCatchLevelData> keyValuePair in this.LevelInfoMap)
			{
				if (!keyValuePair.Value.IsAllRewarded)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06041C09 RID: 269321 RVA: 0x00FF329C File Offset: 0x00FF149C
		public bool CheckLevelCompleted(int levelId)
		{
			DropCatchLevelData levelData = this.GetLevelData(levelId);
			if (levelData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DropCatch;
				ELogAuthor author = ELogAuthor.CB;
				string message = "找不到对应关卡信息";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("levelId", levelId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			EDropCatchLevelState? targetStarState = levelData.GetTargetStarState(0);
			EDropCatchLevelState edropCatchLevelState = EDropCatchLevelState.Lock;
			return !(targetStarState.GetValueOrDefault() == edropCatchLevelState & targetStarState != null);
		}

		// Token: 0x06041C0A RID: 269322 RVA: 0x00FF3304 File Offset: 0x00FF1504
		[NullableContext(2)]
		public string GetLevelUnlockHintText(int configId)
		{
			DropCatchLevelData levelData = this.GetLevelData(configId);
			if (levelData == null)
			{
				return null;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			double unlockTime = levelData.UnlockTime;
			if (unlockTime > serverTime)
			{
				CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(unlockTime - serverTime);
				if (remainTimeDataFormat.CountDownText != null)
				{
					string multiTextByKey = TextConfig.Instance.GetMultiTextByKey("CoinCatch_LevelUnlockTimer_1");
					if (multiTextByKey != null)
					{
						return StringUtils.Format(multiTextByKey, new string[]
						{
							remainTimeDataFormat.CountDownText
						});
					}
				}
				return null;
			}
			DropCatchGameplay? dropCatchGameplayById = DropCatchConfig.Instance.GetDropCatchGameplayById(configId);
			if (dropCatchGameplayById != null)
			{
				string multiTextByKey2 = TextConfig.Instance.GetMultiTextByKey("CoinCatch_UnlockLevelCondition_1");
				if (multiTextByKey2 != null)
				{
					return StringUtils.Format(multiTextByKey2, new string[]
					{
						dropCatchGameplayById.Value.OpenDay.ToString()
					});
				}
			}
			return null;
		}

		// Token: 0x04022371 RID: 140145
		private readonly Dictionary<int, DropCatchLevelData> LevelInfoMap = new Dictionary<int, DropCatchLevelData>();

		// Token: 0x04022372 RID: 140146
		private int PreferredOpenLevelId;
	}
}

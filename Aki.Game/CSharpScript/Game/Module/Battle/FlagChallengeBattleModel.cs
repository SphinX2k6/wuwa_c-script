using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.FlagChallenge;
using CSharpScript.Game.Module.TrainingDegree;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C32 RID: 23602
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class FlagChallengeBattleModel : ModelBase
	{
		// Token: 0x0603B9EE RID: 244206 RVA: 0x00E39DEF File Offset: 0x00E37FEF
		protected override bool OnInit()
		{
			this.ResetLevelInfo();
			return true;
		}

		// Token: 0x17008DAC RID: 36268
		// (get) Token: 0x0603B9EF RID: 244207 RVA: 0x00E39DF8 File Offset: 0x00E37FF8
		public int ActivityId
		{
			get
			{
				return this.ActivityIdIntl;
			}
		}

		// Token: 0x17008DAD RID: 36269
		// (get) Token: 0x0603B9F0 RID: 244208 RVA: 0x00E39E00 File Offset: 0x00E38000
		public int LevelId
		{
			get
			{
				return this.LevelIdIntl;
			}
		}

		// Token: 0x17008DAE RID: 36270
		// (get) Token: 0x0603B9F1 RID: 244209 RVA: 0x00E39E08 File Offset: 0x00E38008
		public int InstanceId
		{
			get
			{
				return this.InstanceIdIntl;
			}
		}

		// Token: 0x17008DAF RID: 36271
		// (get) Token: 0x0603B9F2 RID: 244210 RVA: 0x00E39E10 File Offset: 0x00E38010
		public bool IsInFlagChallengeDungeon
		{
			get
			{
				return this.InstanceIdIntl > 0;
			}
		}

		// Token: 0x17008DB0 RID: 36272
		// (get) Token: 0x0603B9F3 RID: 244211 RVA: 0x00E39E1B File Offset: 0x00E3801B
		// (set) Token: 0x0603B9F4 RID: 244212 RVA: 0x00E39E23 File Offset: 0x00E38023
		public int StrongholdId
		{
			get
			{
				return this.StrongholdIdIntl;
			}
			set
			{
				this.StrongholdIdIntl = value;
			}
		}

		// Token: 0x17008DB1 RID: 36273
		// (get) Token: 0x0603B9F5 RID: 244213 RVA: 0x00E39E2C File Offset: 0x00E3802C
		// (set) Token: 0x0603B9F6 RID: 244214 RVA: 0x00E39E34 File Offset: 0x00E38034
		public int AreaId
		{
			get
			{
				return this.AreaIdIntl;
			}
			set
			{
				this.AreaIdIntl = value;
			}
		}

		// Token: 0x17008DB2 RID: 36274
		// (get) Token: 0x0603B9F7 RID: 244215 RVA: 0x00E39E3D File Offset: 0x00E3803D
		// (set) Token: 0x0603B9F8 RID: 244216 RVA: 0x00E39E45 File Offset: 0x00E38045
		public bool IsNeedShowMainView
		{
			get
			{
				return this.IsNeedShowMainViewIntl;
			}
			set
			{
				this.IsNeedShowMainViewIntl = value;
			}
		}

		// Token: 0x17008DB3 RID: 36275
		// (get) Token: 0x0603B9F9 RID: 244217 RVA: 0x00E39E4E File Offset: 0x00E3804E
		public FlagChallengeSettleInfo SettleInfo
		{
			get
			{
				return this.SettleInfoIntl;
			}
		}

		// Token: 0x0603B9FA RID: 244218 RVA: 0x00E39E58 File Offset: 0x00E38058
		public void HandleInstNotify(FlagChallengeInstNotify notify)
		{
			int challengeLevelId = notify.ChallengeLevelId;
			FlagChallengeLevel? levelConfig = FlagChallengeConfig.Instance.GetLevelConfig(challengeLevelId);
			this.LevelIdIntl = challengeLevelId;
			this.ActivityIdIntl = levelConfig.Value.ActivityId;
			this.InstanceIdIntl = levelConfig.Value.InstId;
			Aki.Protocol.FlagChallengeRoleLevelInfo flagChallengePerRoleLevelInfo = notify.FlagChallengePerRoleLevelInfo;
			if (flagChallengePerRoleLevelInfo != null)
			{
				this.FixedLevelInfo.Level = flagChallengePerRoleLevelInfo.PerLevel;
				this.FixedLevelInfo.Exp = flagChallengePerRoleLevelInfo.PerExp;
				this.CacheLevelInfo.Level = flagChallengePerRoleLevelInfo.PerLevel;
				this.CacheLevelInfo.Exp = flagChallengePerRoleLevelInfo.PerExp;
			}
			Aki.Protocol.FlagChallengeRoleLevelInfo flagChallengeTempRoleLevelInfo = notify.FlagChallengeTempRoleLevelInfo;
			if (flagChallengeTempRoleLevelInfo != null)
			{
				this.TempLevelInfo.Level = flagChallengeTempRoleLevelInfo.PerLevel;
				this.TempLevelInfo.Exp = flagChallengeTempRoleLevelInfo.PerExp;
			}
			this.BoxExp = notify.BoxExp;
			this.UpdateCalculatedLevelInfo();
			this.UpdatePreCalculatedLevelInfo(this.GetCalculatedLevel(), this.GetCalculatedLevelExp());
			this.UpdatePreFixedLevelInfo(this.GetFixedLevel(), this.GetFixedLevelExp());
			this.UpdatePreTempLevelData(this.GetTempLevel(), this.GetTempLevelExp());
			this.OnEnterInstance();
		}

		// Token: 0x0603B9FB RID: 244219 RVA: 0x00E39F73 File Offset: 0x00E38173
		public void OnEnterInstance()
		{
			this.SetFlagChallengeBattleActive(true);
			EventSystem.Instance.Emit<bool>(EEventName.OnFlagChallengeDungeonActiveChanged, true);
		}

		// Token: 0x0603B9FC RID: 244220 RVA: 0x00E39F8D File Offset: 0x00E3818D
		public void HandleSettleNotify(int levelId)
		{
			this.SettleInfoIntl = new FlagChallengeSettleInfo
			{
				Level = this.GetFixedLevel(),
				CacheLevel = this.GetCacheLevel(),
				BoxLevel = this.GetBoxLevel()
			};
			this.UpdateRoleTempLevelData(0, 0);
			this.UpdateBoxExp(0);
		}

		// Token: 0x0603B9FD RID: 244221 RVA: 0x00E39FCD File Offset: 0x00E381CD
		public void OnLeaveInstance()
		{
			this.BoxExp = 0;
			this.TempLevelExpRangeCache.Clear();
			this.TempExpConfigListInternal = null;
			this.LevelIdIntl = 0;
			this.ActivityIdIntl = 0;
			this.InstanceIdIntl = 0;
			this.SetFlagChallengeBattleActive(false);
		}

		// Token: 0x0603B9FE RID: 244222 RVA: 0x00E3A004 File Offset: 0x00E38204
		public bool IsFlagChallengeBattleActive()
		{
			return this.IsFlagChallengeBattleActiveIntl;
		}

		// Token: 0x0603B9FF RID: 244223 RVA: 0x00E3A00C File Offset: 0x00E3820C
		public void SetFlagChallengeBattleActive(bool active)
		{
			if (active == this.IsFlagChallengeBattleActiveIntl)
			{
				return;
			}
			this.IsFlagChallengeBattleActiveIntl = active;
			EventSystem.Instance.Emit<bool>(EEventName.OnFlagChallengeDungeonActiveChanged, active);
		}

		// Token: 0x0603BA00 RID: 244224 RVA: 0x00E3A030 File Offset: 0x00E38230
		public int GetTempFlagChallengeMaxLevel()
		{
			IReadOnlyList<BattleScoreLevelConf> tempExpConfigList = this.GetTempExpConfigList();
			if (tempExpConfigList != null)
			{
				return tempExpConfigList.Count;
			}
			return 1;
		}

		// Token: 0x0603BA01 RID: 244225 RVA: 0x00E3A050 File Offset: 0x00E38250
		[NullableContext(2)]
		private IReadOnlyList<BattleScoreLevelConf> GetTempExpConfigList()
		{
			if (this.TempExpConfigListInternal == null)
			{
				FlagChallengeActivity? activityConfig = FlagChallengeConfig.Instance.GetActivityConfig(this.ActivityId);
				int id = (activityConfig != null) ? activityConfig.GetValueOrDefault().BattleScoreId : 0;
				BattleScoreConf? battleScoreConfig = BattleScoreConfig.Instance.GetBattleScoreConfig(id);
				if (battleScoreConfig != null)
				{
					BattleScoreConf valueOrDefault = battleScoreConfig.GetValueOrDefault();
					this.TempExpConfigListInternal = BattleScoreConfig.Instance.GetBattleScoreActionConfigByGroupId(valueOrDefault.LevelGroupId);
				}
			}
			return this.TempExpConfigListInternal;
		}

		// Token: 0x0603BA02 RID: 244226 RVA: 0x00E3A0D0 File Offset: 0x00E382D0
		private void ResetLevelInfo()
		{
			this.CacheLevelInfo = new CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo
			{
				Level = 0,
				Exp = 0
			};
			this.FixedLevelInfo = new CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo
			{
				Level = 0,
				Exp = 0
			};
			this.TempLevelInfo = new CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo
			{
				Level = 0,
				Exp = 0
			};
			this.CalculatedLevelInfo = new CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo
			{
				Level = 0,
				Exp = 0
			};
			this.PreCalculatedLevelInfo = new CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo
			{
				Level = 0,
				Exp = 0
			};
			this.PreFixedLevelInfo = new CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo
			{
				Level = 0,
				Exp = 0
			};
			this.PreTempLevelInfo = new CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo
			{
				Level = 0,
				Exp = 0
			};
			this.BoxExp = 0;
		}

		// Token: 0x0603BA03 RID: 244227 RVA: 0x00E3A194 File Offset: 0x00E38394
		public IReadOnlyList<TrainingData> GetTrainingDataList()
		{
			TrainingData trainingData = new TrainingData();
			TrainingData trainingData2 = new TrainingData();
			trainingData.Icon = "SP_IconDeathKillEnemy";
			trainingData.NameId = "Morale_32_Fail_ElimatePath";
			trainingData2.Icon = "SP_IconDeathCapturePoint";
			trainingData2.NameId = "Morale_32_Fail_OccupyPath";
			return new <>z__ReadOnlyArray<TrainingData>(new TrainingData[]
			{
				trainingData2,
				trainingData
			});
		}

		// Token: 0x0603BA04 RID: 244228 RVA: 0x00E3A1EC File Offset: 0x00E383EC
		public void UpdateRoleLevelData(int level, int exp)
		{
			this.UpdatePreFixedLevelInfo(this.GetFixedLevel(), this.GetFixedLevelExp());
			this.FixedLevelInfo.Level = level;
			this.FixedLevelInfo.Exp = exp;
			this.UpdateCalculatedLevelInfo();
			int preCalculatedLevelExp = this.GetPreCalculatedLevelExp();
			int calculatedLevelExp = this.GetCalculatedLevelExp();
			int preCalculatedLevel = this.GetPreCalculatedLevel();
			int calculatedLevel = this.GetCalculatedLevel();
			if (preCalculatedLevelExp != calculatedLevelExp || preCalculatedLevel != calculatedLevel)
			{
				EventSystem.Instance.Emit<int, int, int, int>(EEventName.OnFlagChallengeExpChanged, preCalculatedLevelExp, calculatedLevelExp, preCalculatedLevel, calculatedLevel);
			}
			this.CheckIsTotalLevelChanged();
		}

		// Token: 0x0603BA05 RID: 244229 RVA: 0x00E3A268 File Offset: 0x00E38468
		public void UpdateRoleTempLevelData(int level, int exp)
		{
			this.UpdatePreTempLevelData(this.GetTempLevel(), this.GetTempLevelExp());
			this.TempLevelInfo.Level = level;
			this.TempLevelInfo.Exp = exp;
			int preTempLevelExp = this.GetPreTempLevelExp();
			int tempLevelExp = this.GetTempLevelExp();
			if (preTempLevelExp != tempLevelExp)
			{
				EventSystem.Instance.Emit<int, int, int, int>(EEventName.OnFlagChallengeTempExpChanged, preTempLevelExp, tempLevelExp, this.GetPreTempLevel(), this.GetTempLevel());
			}
			this.CheckIsTotalLevelChanged();
		}

		// Token: 0x0603BA06 RID: 244230 RVA: 0x00E3A2D8 File Offset: 0x00E384D8
		public void UpdateBoxExp(int exp)
		{
			this.BoxExp = exp;
			this.UpdateCalculatedLevelInfo();
			int preCalculatedLevelExp = this.GetPreCalculatedLevelExp();
			int calculatedLevelExp = this.GetCalculatedLevelExp();
			int preCalculatedLevel = this.GetPreCalculatedLevel();
			int calculatedLevel = this.GetCalculatedLevel();
			if (preCalculatedLevelExp != calculatedLevelExp || preCalculatedLevel != calculatedLevel)
			{
				EventSystem.Instance.Emit<int, int, int, int>(EEventName.OnFlagChallengeExpChanged, preCalculatedLevelExp, calculatedLevelExp, preCalculatedLevel, calculatedLevel);
			}
			this.CheckIsTotalLevelChanged();
		}

		// Token: 0x0603BA07 RID: 244231 RVA: 0x00E3A330 File Offset: 0x00E38530
		private void CheckIsTotalLevelChanged()
		{
			int preTotalLevel = this.GetPreTotalLevel();
			int totalLevel = this.GetTotalLevel();
			if (preTotalLevel != totalLevel)
			{
				EventSystem.Instance.Emit<int, int, int, int>(EEventName.OnFlagChallengeTotalLevelChanged, this.GetPreCalculatedLevel(), this.GetCalculatedLevel(), this.GetPreTempLevel(), this.GetTempLevel());
			}
		}

		// Token: 0x0603BA08 RID: 244232 RVA: 0x00E3A375 File Offset: 0x00E38575
		private void UpdatePreCalculatedLevelInfo(int level, int exp)
		{
			this.PreCalculatedLevelInfo.Level = level;
			this.PreCalculatedLevelInfo.Exp = exp;
		}

		// Token: 0x0603BA09 RID: 244233 RVA: 0x00E3A38F File Offset: 0x00E3858F
		private void UpdatePreFixedLevelInfo(int level, int exp)
		{
			this.PreFixedLevelInfo.Level = level;
			this.PreFixedLevelInfo.Exp = exp;
		}

		// Token: 0x0603BA0A RID: 244234 RVA: 0x00E3A3A9 File Offset: 0x00E385A9
		private void UpdatePreTempLevelData(int level, int exp)
		{
			this.PreTempLevelInfo.Level = level;
			this.PreTempLevelInfo.Exp = exp;
		}

		// Token: 0x0603BA0B RID: 244235 RVA: 0x00E3A3C3 File Offset: 0x00E385C3
		public int GetFixedLevel()
		{
			return this.FixedLevelInfo.Level;
		}

		// Token: 0x0603BA0C RID: 244236 RVA: 0x00E3A3D0 File Offset: 0x00E385D0
		public int GetFixedLevelExp()
		{
			return this.FixedLevelInfo.Exp;
		}

		// Token: 0x0603BA0D RID: 244237 RVA: 0x00E3A3DD File Offset: 0x00E385DD
		public int GetTempLevel()
		{
			return this.TempLevelInfo.Level;
		}

		// Token: 0x0603BA0E RID: 244238 RVA: 0x00E3A3EA File Offset: 0x00E385EA
		public int GetTempLevelExp()
		{
			return this.TempLevelInfo.Exp;
		}

		// Token: 0x0603BA0F RID: 244239 RVA: 0x00E3A3F7 File Offset: 0x00E385F7
		public int GetBoxLevel()
		{
			return this.GetCalculatedLevel() - this.GetFixedLevel();
		}

		// Token: 0x0603BA10 RID: 244240 RVA: 0x00E3A406 File Offset: 0x00E38606
		public int GetBoxExp()
		{
			return this.BoxExp;
		}

		// Token: 0x0603BA11 RID: 244241 RVA: 0x00E3A40E File Offset: 0x00E3860E
		public int GetCalculatedLevel()
		{
			return this.CalculatedLevelInfo.Level;
		}

		// Token: 0x0603BA12 RID: 244242 RVA: 0x00E3A41B File Offset: 0x00E3861B
		public int GetCalculatedLevelExp()
		{
			return this.CalculatedLevelInfo.Exp;
		}

		// Token: 0x0603BA13 RID: 244243 RVA: 0x00E3A428 File Offset: 0x00E38628
		public int GetPreCalculatedLevel()
		{
			return this.PreCalculatedLevelInfo.Level;
		}

		// Token: 0x0603BA14 RID: 244244 RVA: 0x00E3A435 File Offset: 0x00E38635
		public int GetPreCalculatedLevelExp()
		{
			return this.PreCalculatedLevelInfo.Exp;
		}

		// Token: 0x0603BA15 RID: 244245 RVA: 0x00E3A444 File Offset: 0x00E38644
		private void UpdateCalculatedLevelInfo()
		{
			this.UpdatePreCalculatedLevelInfo(this.GetCalculatedLevel(), this.GetCalculatedLevelExp());
			int i = this.GetFixedLevel();
			int num = this.GetFixedLevelExp() + this.GetBoxExp();
			int maxLevel = FlagChallengeModel.Instance.GetMaxLevel(this.ActivityId);
			while (i < maxLevel)
			{
				int levelExp = FlagChallengeModel.Instance.GetLevelExp(this.ActivityId, i + 1);
				if (num < levelExp)
				{
					break;
				}
				i++;
			}
			this.CalculatedLevelInfo.Level = i;
			this.CalculatedLevelInfo.Exp = num;
			EventSystem.Instance.Emit<int>(EEventName.OnFlagChallengeCalculatedLevelUpdate, this.GetCalculatedLevel());
		}

		// Token: 0x0603BA16 RID: 244246 RVA: 0x00E3A4D9 File Offset: 0x00E386D9
		public int GetTotalLevel()
		{
			return this.GetCalculatedLevel() + this.GetTempLevel();
		}

		// Token: 0x0603BA17 RID: 244247 RVA: 0x00E3A4E8 File Offset: 0x00E386E8
		public int GetTotalLevelExp()
		{
			return this.GetCalculatedLevelExp();
		}

		// Token: 0x0603BA18 RID: 244248 RVA: 0x00E3A4F0 File Offset: 0x00E386F0
		public int GetPreFixedLevel()
		{
			return this.PreFixedLevelInfo.Level;
		}

		// Token: 0x0603BA19 RID: 244249 RVA: 0x00E3A4FD File Offset: 0x00E386FD
		public int GetPreFixedLevelExp()
		{
			return this.PreFixedLevelInfo.Exp;
		}

		// Token: 0x0603BA1A RID: 244250 RVA: 0x00E3A50A File Offset: 0x00E3870A
		public int GetPreTempLevel()
		{
			return this.PreTempLevelInfo.Level;
		}

		// Token: 0x0603BA1B RID: 244251 RVA: 0x00E3A517 File Offset: 0x00E38717
		public int GetPreTempLevelExp()
		{
			return this.PreTempLevelInfo.Exp;
		}

		// Token: 0x0603BA1C RID: 244252 RVA: 0x00E3A524 File Offset: 0x00E38724
		public int GetPreTotalLevel()
		{
			return this.GetPreCalculatedLevel() + this.GetPreTempLevel();
		}

		// Token: 0x0603BA1D RID: 244253 RVA: 0x00E3A533 File Offset: 0x00E38733
		public int GetPreTotalLevelExp()
		{
			return this.GetPreCalculatedLevelExp();
		}

		// Token: 0x0603BA1E RID: 244254 RVA: 0x00E3A53B File Offset: 0x00E3873B
		public int GetCacheLevel()
		{
			return this.CacheLevelInfo.Level;
		}

		// Token: 0x0603BA1F RID: 244255 RVA: 0x00E3A548 File Offset: 0x00E38748
		public int GetCacheLevelExp()
		{
			return this.CacheLevelInfo.Exp;
		}

		// Token: 0x0603BA20 RID: 244256 RVA: 0x00E3A558 File Offset: 0x00E38758
		public int GetTempLevelUpExp(int? targetLevel = null)
		{
			int level = targetLevel ?? this.GetTempLevel();
			ValueTuple<int, int> tempLevelExpRange = this.GetTempLevelExpRange(level);
			return Math.Max(0, tempLevelExpRange.Item2 - tempLevelExpRange.Item1);
		}

		// Token: 0x0603BA21 RID: 244257 RVA: 0x00E3A59C File Offset: 0x00E3879C
		public float GetTempExpProgress()
		{
			ValueTuple<int, int> tempLevelExpRange = this.GetTempLevelExpRange(this.GetTempLevel());
			int num = Math.Max(0, this.GetTempLevelExp() - tempLevelExpRange.Item1);
			int tempLevelUpExp = this.GetTempLevelUpExp(null);
			if (tempLevelUpExp != 0)
			{
				return Math.Min(1f, (float)num / (float)tempLevelUpExp);
			}
			return 0f;
		}

		// Token: 0x0603BA22 RID: 244258 RVA: 0x00E3A5F4 File Offset: 0x00E387F4
		[NullableContext(0)]
		public ValueTuple<int, int> GetTempLevelExpRange(int level)
		{
			ValueTuple<int, int> result;
			if (this.TempLevelExpRangeCache.TryGetValue(level, out result))
			{
				return result;
			}
			foreach (BattleScoreLevelConf battleScoreLevelConf in this.GetTempExpConfigList())
			{
				if (battleScoreLevelConf.Level == level || (battleScoreLevelConf.Level == 1 && level == 0))
				{
					ValueTuple<int, int> valueTuple = new ValueTuple<int, int>(battleScoreLevelConf.LowerUpperLimits(0), battleScoreLevelConf.LowerUpperLimits(1));
					if (level == 0)
					{
						valueTuple.Item1 = 0;
						valueTuple.Item2 = battleScoreLevelConf.LowerUpperLimits(0);
					}
					this.TempLevelExpRangeCache[level] = valueTuple;
					return valueTuple;
				}
			}
			return new ValueTuple<int, int>(0, 0);
		}

		// Token: 0x0603BA23 RID: 244259 RVA: 0x00E3A6B0 File Offset: 0x00E388B0
		public unsafe IBattleUiHoverTipsC GetInTheBattleBuffInfo()
		{
			BattleUiHoverTipsC battleUiHoverTipsC = new BattleUiHoverTipsC();
			battleUiHoverTipsC.TitleKey = "Morale_title_15";
			int num = 1;
			List<IBattleUiHoverTipsDescInfoC> list = new List<IBattleUiHoverTipsDescInfoC>(num);
			CollectionsMarshal.SetCount<IBattleUiHoverTipsDescInfoC>(list, num);
			Span<IBattleUiHoverTipsDescInfoC> span = CollectionsMarshal.AsSpan<IBattleUiHoverTipsDescInfoC>(list);
			int index = 0;
			*span[index] = new BattleUiHoverTipsDescInfoC
			{
				DescKey = "Morale_title_23"
			};
			battleUiHoverTipsC.DescInfoList = list;
			return battleUiHoverTipsC;
		}

		// Token: 0x17008DB4 RID: 36276
		// (get) Token: 0x0603BA24 RID: 244260 RVA: 0x00E3A704 File Offset: 0x00E38904
		public static FlagChallengeBattleModel Instance
		{
			get
			{
				return FlagChallengeBattleModel._Instance;
			}
		}

		// Token: 0x0603BA25 RID: 244261 RVA: 0x00E3A70B File Offset: 0x00E3890B
		public static FlagChallengeBattleModel GetOrCreateInstance()
		{
			if (FlagChallengeBattleModel._Instance == null)
			{
				FlagChallengeBattleModel.CreateInstance();
			}
			return FlagChallengeBattleModel._Instance;
		}

		// Token: 0x0603BA26 RID: 244262 RVA: 0x00E3A71F File Offset: 0x00E3891F
		public static bool CreateInstance()
		{
			if (FlagChallengeBattleModel._Instance != null)
			{
				return true;
			}
			FlagChallengeBattleModel._Instance = new FlagChallengeBattleModel();
			return true;
		}

		// Token: 0x0603BA27 RID: 244263 RVA: 0x00E3A735 File Offset: 0x00E38935
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BA28 RID: 244264 RVA: 0x00E3A737 File Offset: 0x00E38937
		public static void ResetStaticDefaultValue()
		{
			FlagChallengeBattleModel._Instance = null;
		}

		// Token: 0x0603BA29 RID: 244265 RVA: 0x00E3A73F File Offset: 0x00E3893F
		static FlagChallengeBattleModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlagChallengeBattleModel.CreateStaticDefaultValue), new Action(FlagChallengeBattleModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401F095 RID: 127125
		private int ActivityIdIntl;

		// Token: 0x0401F096 RID: 127126
		private int LevelIdIntl;

		// Token: 0x0401F097 RID: 127127
		private int InstanceIdIntl;

		// Token: 0x0401F098 RID: 127128
		private int AreaIdIntl;

		// Token: 0x0401F099 RID: 127129
		private int StrongholdIdIntl;

		// Token: 0x0401F09A RID: 127130
		private bool IsNeedShowMainViewIntl;

		// Token: 0x0401F09B RID: 127131
		private FlagChallengeSettleInfo SettleInfoIntl;

		// Token: 0x0401F09C RID: 127132
		private CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo CacheLevelInfo;

		// Token: 0x0401F09D RID: 127133
		private CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo FixedLevelInfo;

		// Token: 0x0401F09E RID: 127134
		private CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo TempLevelInfo;

		// Token: 0x0401F09F RID: 127135
		private int BoxExp;

		// Token: 0x0401F0A0 RID: 127136
		private CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo CalculatedLevelInfo;

		// Token: 0x0401F0A1 RID: 127137
		private CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo PreCalculatedLevelInfo;

		// Token: 0x0401F0A2 RID: 127138
		private CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo PreFixedLevelInfo;

		// Token: 0x0401F0A3 RID: 127139
		private CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo PreTempLevelInfo;

		// Token: 0x0401F0A4 RID: 127140
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly Dictionary<int, ValueTuple<int, int>> TempLevelExpRangeCache = new Dictionary<int, ValueTuple<int, int>>();

		// Token: 0x0401F0A5 RID: 127141
		private bool IsFlagChallengeBattleActiveIntl;

		// Token: 0x0401F0A6 RID: 127142
		[Nullable(2)]
		private IReadOnlyList<BattleScoreLevelConf> TempExpConfigListInternal;

		// Token: 0x0401F0A7 RID: 127143
		[Nullable(2)]
		private static FlagChallengeBattleModel _Instance;
	}
}

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
	// Token: 0x02004C12 RID: 19474
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class FlagChallengeBattleModel : ModelBase
	{
		// Token: 0x06030939 RID: 198969 RVA: 0x00D8A15F File Offset: 0x00D8835F
		protected override bool OnInit()
		{
			this.ResetLevelInfo();
			return true;
		}

		// Token: 0x1700617E RID: 24958
		// (get) Token: 0x0603093A RID: 198970 RVA: 0x00D8A168 File Offset: 0x00D88368
		public int ActivityId
		{
			get
			{
				return this.ActivityIdIntl;
			}
		}

		// Token: 0x1700617F RID: 24959
		// (get) Token: 0x0603093B RID: 198971 RVA: 0x00D8A170 File Offset: 0x00D88370
		public int LevelId
		{
			get
			{
				return this.LevelIdIntl;
			}
		}

		// Token: 0x17006180 RID: 24960
		// (get) Token: 0x0603093C RID: 198972 RVA: 0x00D8A178 File Offset: 0x00D88378
		public int InstanceId
		{
			get
			{
				return this.InstanceIdIntl;
			}
		}

		// Token: 0x17006181 RID: 24961
		// (get) Token: 0x0603093D RID: 198973 RVA: 0x00D8A180 File Offset: 0x00D88380
		public bool IsInFlagChallengeDungeon
		{
			get
			{
				return this.InstanceIdIntl > 0;
			}
		}

		// Token: 0x17006182 RID: 24962
		// (get) Token: 0x0603093E RID: 198974 RVA: 0x00D8A18B File Offset: 0x00D8838B
		// (set) Token: 0x0603093F RID: 198975 RVA: 0x00D8A193 File Offset: 0x00D88393
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

		// Token: 0x17006183 RID: 24963
		// (get) Token: 0x06030940 RID: 198976 RVA: 0x00D8A19C File Offset: 0x00D8839C
		// (set) Token: 0x06030941 RID: 198977 RVA: 0x00D8A1A4 File Offset: 0x00D883A4
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

		// Token: 0x17006184 RID: 24964
		// (get) Token: 0x06030942 RID: 198978 RVA: 0x00D8A1AD File Offset: 0x00D883AD
		// (set) Token: 0x06030943 RID: 198979 RVA: 0x00D8A1B5 File Offset: 0x00D883B5
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

		// Token: 0x17006185 RID: 24965
		// (get) Token: 0x06030944 RID: 198980 RVA: 0x00D8A1BE File Offset: 0x00D883BE
		public FlagChallengeSettleInfo SettleInfo
		{
			get
			{
				return this.SettleInfoIntl;
			}
		}

		// Token: 0x06030945 RID: 198981 RVA: 0x00D8A1C8 File Offset: 0x00D883C8
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

		// Token: 0x06030946 RID: 198982 RVA: 0x00D8A2E3 File Offset: 0x00D884E3
		public void OnEnterInstance()
		{
			this.SetFlagChallengeBattleActive(true);
			EventSystem.Instance.Emit<bool>(EEventName.OnFlagChallengeDungeonActiveChanged, true);
		}

		// Token: 0x06030947 RID: 198983 RVA: 0x00D8A2FD File Offset: 0x00D884FD
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

		// Token: 0x06030948 RID: 198984 RVA: 0x00D8A33D File Offset: 0x00D8853D
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

		// Token: 0x06030949 RID: 198985 RVA: 0x00D8A374 File Offset: 0x00D88574
		public bool IsFlagChallengeBattleActive()
		{
			return this.IsFlagChallengeBattleActiveIntl;
		}

		// Token: 0x0603094A RID: 198986 RVA: 0x00D8A37C File Offset: 0x00D8857C
		public void SetFlagChallengeBattleActive(bool active)
		{
			if (active == this.IsFlagChallengeBattleActiveIntl)
			{
				return;
			}
			this.IsFlagChallengeBattleActiveIntl = active;
			EventSystem.Instance.Emit<bool>(EEventName.OnFlagChallengeDungeonActiveChanged, active);
		}

		// Token: 0x0603094B RID: 198987 RVA: 0x00D8A3A0 File Offset: 0x00D885A0
		public int GetTempFlagChallengeMaxLevel()
		{
			IReadOnlyList<BattleScoreLevelConf> tempExpConfigList = this.GetTempExpConfigList();
			if (tempExpConfigList != null)
			{
				return tempExpConfigList.Count;
			}
			return 1;
		}

		// Token: 0x0603094C RID: 198988 RVA: 0x00D8A3C0 File Offset: 0x00D885C0
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

		// Token: 0x0603094D RID: 198989 RVA: 0x00D8A440 File Offset: 0x00D88640
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

		// Token: 0x0603094E RID: 198990 RVA: 0x00D8A504 File Offset: 0x00D88704
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

		// Token: 0x0603094F RID: 198991 RVA: 0x00D8A55C File Offset: 0x00D8875C
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

		// Token: 0x06030950 RID: 198992 RVA: 0x00D8A5D8 File Offset: 0x00D887D8
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

		// Token: 0x06030951 RID: 198993 RVA: 0x00D8A648 File Offset: 0x00D88848
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

		// Token: 0x06030952 RID: 198994 RVA: 0x00D8A6A0 File Offset: 0x00D888A0
		private void CheckIsTotalLevelChanged()
		{
			int preTotalLevel = this.GetPreTotalLevel();
			int totalLevel = this.GetTotalLevel();
			if (preTotalLevel != totalLevel)
			{
				EventSystem.Instance.Emit<int, int, int, int>(EEventName.OnFlagChallengeTotalLevelChanged, this.GetPreCalculatedLevel(), this.GetCalculatedLevel(), this.GetPreTempLevel(), this.GetTempLevel());
			}
		}

		// Token: 0x06030953 RID: 198995 RVA: 0x00D8A6E5 File Offset: 0x00D888E5
		private void UpdatePreCalculatedLevelInfo(int level, int exp)
		{
			this.PreCalculatedLevelInfo.Level = level;
			this.PreCalculatedLevelInfo.Exp = exp;
		}

		// Token: 0x06030954 RID: 198996 RVA: 0x00D8A6FF File Offset: 0x00D888FF
		private void UpdatePreFixedLevelInfo(int level, int exp)
		{
			this.PreFixedLevelInfo.Level = level;
			this.PreFixedLevelInfo.Exp = exp;
		}

		// Token: 0x06030955 RID: 198997 RVA: 0x00D8A719 File Offset: 0x00D88919
		private void UpdatePreTempLevelData(int level, int exp)
		{
			this.PreTempLevelInfo.Level = level;
			this.PreTempLevelInfo.Exp = exp;
		}

		// Token: 0x06030956 RID: 198998 RVA: 0x00D8A733 File Offset: 0x00D88933
		public int GetFixedLevel()
		{
			return this.FixedLevelInfo.Level;
		}

		// Token: 0x06030957 RID: 198999 RVA: 0x00D8A740 File Offset: 0x00D88940
		public int GetFixedLevelExp()
		{
			return this.FixedLevelInfo.Exp;
		}

		// Token: 0x06030958 RID: 199000 RVA: 0x00D8A74D File Offset: 0x00D8894D
		public int GetTempLevel()
		{
			return this.TempLevelInfo.Level;
		}

		// Token: 0x06030959 RID: 199001 RVA: 0x00D8A75A File Offset: 0x00D8895A
		public int GetTempLevelExp()
		{
			return this.TempLevelInfo.Exp;
		}

		// Token: 0x0603095A RID: 199002 RVA: 0x00D8A767 File Offset: 0x00D88967
		public int GetBoxLevel()
		{
			return this.GetCalculatedLevel() - this.GetFixedLevel();
		}

		// Token: 0x0603095B RID: 199003 RVA: 0x00D8A776 File Offset: 0x00D88976
		public int GetBoxExp()
		{
			return this.BoxExp;
		}

		// Token: 0x0603095C RID: 199004 RVA: 0x00D8A77E File Offset: 0x00D8897E
		public int GetCalculatedLevel()
		{
			return this.CalculatedLevelInfo.Level;
		}

		// Token: 0x0603095D RID: 199005 RVA: 0x00D8A78B File Offset: 0x00D8898B
		public int GetCalculatedLevelExp()
		{
			return this.CalculatedLevelInfo.Exp;
		}

		// Token: 0x0603095E RID: 199006 RVA: 0x00D8A798 File Offset: 0x00D88998
		public int GetPreCalculatedLevel()
		{
			return this.PreCalculatedLevelInfo.Level;
		}

		// Token: 0x0603095F RID: 199007 RVA: 0x00D8A7A5 File Offset: 0x00D889A5
		public int GetPreCalculatedLevelExp()
		{
			return this.PreCalculatedLevelInfo.Exp;
		}

		// Token: 0x06030960 RID: 199008 RVA: 0x00D8A7B4 File Offset: 0x00D889B4
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

		// Token: 0x06030961 RID: 199009 RVA: 0x00D8A849 File Offset: 0x00D88A49
		public int GetTotalLevel()
		{
			return this.GetCalculatedLevel() + this.GetTempLevel();
		}

		// Token: 0x06030962 RID: 199010 RVA: 0x00D8A858 File Offset: 0x00D88A58
		public int GetTotalLevelExp()
		{
			return this.GetCalculatedLevelExp();
		}

		// Token: 0x06030963 RID: 199011 RVA: 0x00D8A860 File Offset: 0x00D88A60
		public int GetPreFixedLevel()
		{
			return this.PreFixedLevelInfo.Level;
		}

		// Token: 0x06030964 RID: 199012 RVA: 0x00D8A86D File Offset: 0x00D88A6D
		public int GetPreFixedLevelExp()
		{
			return this.PreFixedLevelInfo.Exp;
		}

		// Token: 0x06030965 RID: 199013 RVA: 0x00D8A87A File Offset: 0x00D88A7A
		public int GetPreTempLevel()
		{
			return this.PreTempLevelInfo.Level;
		}

		// Token: 0x06030966 RID: 199014 RVA: 0x00D8A887 File Offset: 0x00D88A87
		public int GetPreTempLevelExp()
		{
			return this.PreTempLevelInfo.Exp;
		}

		// Token: 0x06030967 RID: 199015 RVA: 0x00D8A894 File Offset: 0x00D88A94
		public int GetPreTotalLevel()
		{
			return this.GetPreCalculatedLevel() + this.GetPreTempLevel();
		}

		// Token: 0x06030968 RID: 199016 RVA: 0x00D8A8A3 File Offset: 0x00D88AA3
		public int GetPreTotalLevelExp()
		{
			return this.GetPreCalculatedLevelExp();
		}

		// Token: 0x06030969 RID: 199017 RVA: 0x00D8A8AB File Offset: 0x00D88AAB
		public int GetCacheLevel()
		{
			return this.CacheLevelInfo.Level;
		}

		// Token: 0x0603096A RID: 199018 RVA: 0x00D8A8B8 File Offset: 0x00D88AB8
		public int GetCacheLevelExp()
		{
			return this.CacheLevelInfo.Exp;
		}

		// Token: 0x0603096B RID: 199019 RVA: 0x00D8A8C8 File Offset: 0x00D88AC8
		public int GetTempLevelUpExp(int? targetLevel = null)
		{
			int level = targetLevel ?? this.GetTempLevel();
			ValueTuple<int, int> tempLevelExpRange = this.GetTempLevelExpRange(level);
			return Math.Max(0, tempLevelExpRange.Item2 - tempLevelExpRange.Item1);
		}

		// Token: 0x0603096C RID: 199020 RVA: 0x00D8A90C File Offset: 0x00D88B0C
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

		// Token: 0x0603096D RID: 199021 RVA: 0x00D8A964 File Offset: 0x00D88B64
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

		// Token: 0x0603096E RID: 199022 RVA: 0x00D8AA20 File Offset: 0x00D88C20
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

		// Token: 0x17006186 RID: 24966
		// (get) Token: 0x0603096F RID: 199023 RVA: 0x00D8AA74 File Offset: 0x00D88C74
		public static FlagChallengeBattleModel Instance
		{
			get
			{
				return FlagChallengeBattleModel._Instance;
			}
		}

		// Token: 0x06030970 RID: 199024 RVA: 0x00D8AA7B File Offset: 0x00D88C7B
		public static FlagChallengeBattleModel GetOrCreateInstance()
		{
			if (FlagChallengeBattleModel._Instance == null)
			{
				FlagChallengeBattleModel.CreateInstance();
			}
			return FlagChallengeBattleModel._Instance;
		}

		// Token: 0x06030971 RID: 199025 RVA: 0x00D8AA8F File Offset: 0x00D88C8F
		public static bool CreateInstance()
		{
			if (FlagChallengeBattleModel._Instance != null)
			{
				return true;
			}
			FlagChallengeBattleModel._Instance = new FlagChallengeBattleModel();
			return true;
		}

		// Token: 0x06030972 RID: 199026 RVA: 0x00D8AAA5 File Offset: 0x00D88CA5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030973 RID: 199027 RVA: 0x00D8AAA7 File Offset: 0x00D88CA7
		public static void ResetStaticDefaultValue()
		{
			FlagChallengeBattleModel._Instance = null;
		}

		// Token: 0x06030974 RID: 199028 RVA: 0x00D8AAAF File Offset: 0x00D88CAF
		static FlagChallengeBattleModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlagChallengeBattleModel.CreateStaticDefaultValue), new Action(FlagChallengeBattleModel.ResetStaticDefaultValue));
		}

		// Token: 0x04019B46 RID: 105286
		private int ActivityIdIntl;

		// Token: 0x04019B47 RID: 105287
		private int LevelIdIntl;

		// Token: 0x04019B48 RID: 105288
		private int InstanceIdIntl;

		// Token: 0x04019B49 RID: 105289
		private int AreaIdIntl;

		// Token: 0x04019B4A RID: 105290
		private int StrongholdIdIntl;

		// Token: 0x04019B4B RID: 105291
		private bool IsNeedShowMainViewIntl;

		// Token: 0x04019B4C RID: 105292
		private FlagChallengeSettleInfo SettleInfoIntl;

		// Token: 0x04019B4D RID: 105293
		private CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo CacheLevelInfo;

		// Token: 0x04019B4E RID: 105294
		private CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo FixedLevelInfo;

		// Token: 0x04019B4F RID: 105295
		private CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo TempLevelInfo;

		// Token: 0x04019B50 RID: 105296
		private int BoxExp;

		// Token: 0x04019B51 RID: 105297
		private CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo CalculatedLevelInfo;

		// Token: 0x04019B52 RID: 105298
		private CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo PreCalculatedLevelInfo;

		// Token: 0x04019B53 RID: 105299
		private CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo PreFixedLevelInfo;

		// Token: 0x04019B54 RID: 105300
		private CSharpScript.Game.Module.FlagChallenge.FlagChallengeRoleLevelInfo PreTempLevelInfo;

		// Token: 0x04019B55 RID: 105301
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly Dictionary<int, ValueTuple<int, int>> TempLevelExpRangeCache = new Dictionary<int, ValueTuple<int, int>>();

		// Token: 0x04019B56 RID: 105302
		private bool IsFlagChallengeBattleActiveIntl;

		// Token: 0x04019B57 RID: 105303
		[Nullable(2)]
		private IReadOnlyList<BattleScoreLevelConf> TempExpConfigListInternal;

		// Token: 0x04019B58 RID: 105304
		[Nullable(2)]
		private static FlagChallengeBattleModel _Instance;
	}
}

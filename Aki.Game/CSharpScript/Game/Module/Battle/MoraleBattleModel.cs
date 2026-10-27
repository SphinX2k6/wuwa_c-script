using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C4E RID: 23630
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class MoraleBattleModel : ModelBase
	{
		// Token: 0x0603BB75 RID: 244597 RVA: 0x00E42AB0 File Offset: 0x00E40CB0
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603BB76 RID: 244598 RVA: 0x00E42AB3 File Offset: 0x00E40CB3
		protected override bool OnLeaveLevel()
		{
			this.ExpConfigListInternal = null;
			this.TempExpConfigListInternal = null;
			this.LevelExpCache = null;
			this.TempLevelExpRangeCache = null;
			this.IsCheckTempMoraleMaxLevelBuff = false;
			return true;
		}

		// Token: 0x0603BB77 RID: 244599 RVA: 0x00E42AD9 File Offset: 0x00E40CD9
		public bool IsMoraleActive()
		{
			return this.IsMoraleActiveInternal;
		}

		// Token: 0x0603BB78 RID: 244600 RVA: 0x00E42AE1 File Offset: 0x00E40CE1
		public void SetMoraleActive(bool active)
		{
			this.IsMoraleActiveInternal = active;
		}

		// Token: 0x0603BB79 RID: 244601 RVA: 0x00E42AEA File Offset: 0x00E40CEA
		public int GetMoraleLevel()
		{
			return this.MoraleLevel;
		}

		// Token: 0x0603BB7A RID: 244602 RVA: 0x00E42AF4 File Offset: 0x00E40CF4
		public int GetMoraleMaxLevel()
		{
			IReadOnlyList<MoraleKeepLevel> expConfigList = this.GetExpConfigList();
			if (expConfigList != null)
			{
				return expConfigList.Count - 1;
			}
			return 1;
		}

		// Token: 0x0603BB7B RID: 244603 RVA: 0x00E42B15 File Offset: 0x00E40D15
		public int GetLastMoraleLevel()
		{
			return this.LastMoraleLevel;
		}

		// Token: 0x0603BB7C RID: 244604 RVA: 0x00E42B1D File Offset: 0x00E40D1D
		public int GetMoraleIndomitableLevel()
		{
			return this.MoraleIndomitableLevel;
		}

		// Token: 0x0603BB7D RID: 244605 RVA: 0x00E42B25 File Offset: 0x00E40D25
		public int GetTempMoraleLevel()
		{
			return this.TempMoraleLevel;
		}

		// Token: 0x0603BB7E RID: 244606 RVA: 0x00E42B2D File Offset: 0x00E40D2D
		public int GetTempMoraleExp()
		{
			return this.TempMoraleExp;
		}

		// Token: 0x0603BB7F RID: 244607 RVA: 0x00E42B35 File Offset: 0x00E40D35
		public int GetExpRatio()
		{
			return this.ExpRatio;
		}

		// Token: 0x0603BB80 RID: 244608 RVA: 0x00E42B40 File Offset: 0x00E40D40
		public int GetTempMoraleMaxLevel()
		{
			IReadOnlyList<BattleScoreLevelConf> tempExpConfigList = this.GetTempExpConfigList();
			if (tempExpConfigList == null)
			{
				return 1;
			}
			if (!this.IsCheckTempMoraleMaxLevelBuff)
			{
				this.IsCheckTempMoraleMaxLevelBuff = true;
				EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
				WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
				CharacterBuffComponent characterBuffComponent = (worldEntity != null) ? worldEntity.GetComponent<CharacterBuffComponent>() : null;
				if (characterBuffComponent != null && characterBuffComponent.HasBuff(632400018L, false))
				{
					this.IsUnlockTempMoraleMaxLevel = true;
				}
				else
				{
					this.IsUnlockTempMoraleMaxLevel = false;
				}
			}
			if (this.IsUnlockTempMoraleMaxLevel)
			{
				return tempExpConfigList.Count;
			}
			return Math.Max(1, tempExpConfigList.Count - 100);
		}

		// Token: 0x0603BB81 RID: 244609 RVA: 0x00E42BCD File Offset: 0x00E40DCD
		public int GetMoraleMaxExp()
		{
			if (this.MoraleMaxExp == 0)
			{
				this.MoraleMaxExp = this.GetLevelExp(this.GetMoraleMaxLevel());
			}
			return this.MoraleMaxExp;
		}

		// Token: 0x0603BB82 RID: 244610 RVA: 0x00E42BEF File Offset: 0x00E40DEF
		public void SetIsUnlockTempMoraleMaxLevel(bool isUnlock)
		{
			this.IsUnlockTempMoraleMaxLevel = isUnlock;
		}

		// Token: 0x0603BB83 RID: 244611 RVA: 0x00E42BF8 File Offset: 0x00E40DF8
		private IReadOnlyList<MoraleKeepLevel> GetExpConfigList()
		{
			if (this.ExpConfigListInternal == null)
			{
				this.ExpConfigListInternal = (MoraleBattleConfig.Instance.GetAllExpConfig() ?? Array.Empty<MoraleKeepLevel>());
			}
			return this.ExpConfigListInternal;
		}

		// Token: 0x0603BB84 RID: 244612 RVA: 0x00E42C24 File Offset: 0x00E40E24
		private IReadOnlyList<BattleScoreLevelConf> GetTempExpConfigList()
		{
			if (this.TempExpConfigListInternal == null)
			{
				MoralePlay? moraleConfig = MoraleBattleConfig.Instance.GetMoraleConfig(this.MoraleConfigId);
				int id = (moraleConfig != null) ? moraleConfig.GetValueOrDefault().BattleScoreId : 0;
				BattleScoreConf? battleScoreConfig = BattleScoreConfig.Instance.GetBattleScoreConfig(id);
				if (battleScoreConfig != null)
				{
					this.TempExpConfigListInternal = BattleScoreConfig.Instance.GetBattleScoreActionConfigByGroupId(battleScoreConfig.Value.LevelGroupId);
				}
			}
			return this.TempExpConfigListInternal;
		}

		// Token: 0x0603BB85 RID: 244613 RVA: 0x00E42CA4 File Offset: 0x00E40EA4
		public int GetLevelExp(int level)
		{
			Dictionary<int, int> levelExpCache = this.LevelExpCache;
			int result;
			if (levelExpCache != null && levelExpCache.TryGetValue(level, out result))
			{
				return result;
			}
			IReadOnlyList<MoraleKeepLevel> expConfigList = this.GetExpConfigList();
			if (level >= 0 && level < expConfigList.Count)
			{
				MoraleKeepLevel? expConfig = MoraleBattleConfig.Instance.GetExpConfig(level);
				if (expConfig != null)
				{
					if (this.LevelExpCache == null)
					{
						this.LevelExpCache = new Dictionary<int, int>();
					}
					this.LevelExpCache[level] = expConfig.Value.Experience;
					return expConfig.Value.Experience;
				}
			}
			return 0;
		}

		// Token: 0x0603BB86 RID: 244614 RVA: 0x00E42D34 File Offset: 0x00E40F34
		[NullableContext(0)]
		public ValueTuple<int, int> GetTempLevelExpRange(int level)
		{
			Dictionary<int, ValueTuple<int, int>> tempLevelExpRangeCache = this.TempLevelExpRangeCache;
			ValueTuple<int, int> result;
			if (tempLevelExpRangeCache != null && tempLevelExpRangeCache.TryGetValue(level, out result))
			{
				return result;
			}
			foreach (BattleScoreLevelConf battleScoreLevelConf in this.GetTempExpConfigList())
			{
				if (battleScoreLevelConf.Level == level || (battleScoreLevelConf.Level == 1 && level == 0))
				{
					if (this.TempLevelExpRangeCache == null)
					{
						this.TempLevelExpRangeCache = new Dictionary<int, ValueTuple<int, int>>();
					}
					ValueTuple<int, int> valueTuple;
					if (level == 0)
					{
						valueTuple.Item1 = 0;
						valueTuple.Item2 = battleScoreLevelConf.LowerUpperLimits(0);
					}
					else
					{
						valueTuple.Item1 = battleScoreLevelConf.LowerUpperLimits(0);
						valueTuple.Item2 = battleScoreLevelConf.LowerUpperLimits(1);
					}
					this.TempLevelExpRangeCache[level] = valueTuple;
					return valueTuple;
				}
			}
			return new ValueTuple<int, int>(0, 0);
		}

		// Token: 0x0603BB87 RID: 244615 RVA: 0x00E42E18 File Offset: 0x00E41018
		public int GetMoraleLevelUpExp(int? targetLevel = null)
		{
			int num = targetLevel ?? this.MoraleLevel;
			int moraleMaxLevel = this.GetMoraleMaxLevel();
			if (num >= moraleMaxLevel)
			{
				num = moraleMaxLevel - 1;
			}
			int levelExp = this.GetLevelExp(num);
			int levelExp2 = this.GetLevelExp(num + 1);
			return Math.Max(0, levelExp2 - levelExp);
		}

		// Token: 0x0603BB88 RID: 244616 RVA: 0x00E42E6C File Offset: 0x00E4106C
		public int GetMoraleCurrentLevelExp()
		{
			if (this.MoraleLevel == 1)
			{
				return this.MoraleExp;
			}
			if (this.MoraleLevel == this.GetMoraleMaxLevel())
			{
				return this.GetMoraleLevelUpExp(new int?(this.MoraleLevel - 1));
			}
			int levelExp = this.GetLevelExp(this.MoraleLevel - 1);
			return Math.Max(0, this.MoraleExp - levelExp);
		}

		// Token: 0x0603BB89 RID: 244617 RVA: 0x00E42EC8 File Offset: 0x00E410C8
		public float GetMoraleCurrentExpProgress()
		{
			if (this.MoraleLevel == this.GetMoraleMaxLevel())
			{
				return 1f;
			}
			int moraleCurrentLevelExp = this.GetMoraleCurrentLevelExp();
			int moraleLevelUpExp = this.GetMoraleLevelUpExp(null);
			if (moraleLevelUpExp != 0)
			{
				return (float)moraleCurrentLevelExp / (float)moraleLevelUpExp;
			}
			return 0f;
		}

		// Token: 0x0603BB8A RID: 244618 RVA: 0x00E42F10 File Offset: 0x00E41110
		public int GetTempMoraleLevelUpExp(int? targetLevel = null)
		{
			int level = targetLevel ?? this.TempMoraleLevel;
			ValueTuple<int, int> tempLevelExpRange = this.GetTempLevelExpRange(level);
			return Math.Max(0, tempLevelExpRange.Item2 - tempLevelExpRange.Item1);
		}

		// Token: 0x0603BB8B RID: 244619 RVA: 0x00E42F54 File Offset: 0x00E41154
		public int GetTempMoraleLevelExp()
		{
			ValueTuple<int, int> tempLevelExpRange = this.GetTempLevelExpRange(this.TempMoraleLevel);
			return Math.Max(0, this.TempMoraleExp - tempLevelExpRange.Item1);
		}

		// Token: 0x0603BB8C RID: 244620 RVA: 0x00E42F84 File Offset: 0x00E41184
		public float GetTempMoraleExpProgress()
		{
			int tempMoraleLevelExp = this.GetTempMoraleLevelExp();
			int tempMoraleLevelUpExp = this.GetTempMoraleLevelUpExp(null);
			if (tempMoraleLevelUpExp != 0)
			{
				return Math.Min(1f, (float)tempMoraleLevelExp / (float)tempMoraleLevelUpExp);
			}
			return 0f;
		}

		// Token: 0x0603BB8D RID: 244621 RVA: 0x00E42FC0 File Offset: 0x00E411C0
		[NullableContext(1)]
		public void HandleMoraleInfoNotify(MoraleInfoNotify notify)
		{
			this.MoraleConfigId = notify.MoraleConfigId;
			this.ExpRatio = notify.ExpRatio;
			bool isStart = notify.IsStart;
			if (!this.IsMoraleInited)
			{
				this.GetExpConfigList();
				this.GetMoraleMaxExp();
				this.SetMoraleInfoByNotify(notify);
				this.IsMoraleInited = true;
			}
			if (this.IsMoraleActive() != isStart)
			{
				this.SetMoraleActive(isStart);
				EventSystem.Instance.Emit<bool>(EEventName.OnMoraleActiveChanged, isStart);
			}
			if (isStart)
			{
				int moraleLevel = this.MoraleLevel;
				int tempMoraleLevel = this.TempMoraleLevel;
				int num = moraleLevel + tempMoraleLevel;
				int num2 = notify.KeepMoraleLevel + notify.TempMoraleLevel;
				bool flag = num != num2;
				int num3 = Math.Min(this.MoraleMaxExp, notify.KeepMoraleExp);
				if (this.MoraleExp != num3)
				{
					int moraleExp = this.MoraleExp;
					this.MoraleExp = num3;
					this.MoraleLevel = notify.KeepMoraleLevel;
					EventSystem.Instance.Emit<int, int, int, int>(EEventName.OnMoraleExpChanged, moraleExp, this.MoraleExp, moraleLevel, this.MoraleLevel);
				}
				if (this.TempMoraleExp != notify.TempMoraleExp)
				{
					int tempMoraleExp = this.TempMoraleExp;
					this.TempMoraleExp = notify.TempMoraleExp;
					this.TempMoraleLevel = notify.TempMoraleLevel;
					EventSystem.Instance.Emit<int, int, int, int>(EEventName.OnMoraleTempExpChanged, tempMoraleExp, this.TempMoraleExp, tempMoraleLevel, this.TempMoraleLevel);
				}
				if (flag)
				{
					EventSystem.Instance.Emit<int, int, int, int>(EEventName.OnMoraleSumLevelChanged, moraleLevel, this.MoraleLevel, tempMoraleLevel, this.TempMoraleLevel);
				}
				if (this.MoraleIndomitableLevel != notify.IndomitableLevel)
				{
					int moraleIndomitableLevel = this.MoraleIndomitableLevel;
					this.MoraleIndomitableLevel = notify.IndomitableLevel;
					EventSystem.Instance.Emit<int, int>(EEventName.OnMoraleIndomitableLevelChanged, moraleIndomitableLevel, this.MoraleIndomitableLevel);
				}
				if (notify.Reason == 1)
				{
					this.LastMoraleLevel = moraleLevel;
					EventSystem.Instance.Emit(EEventName.OnMoraleBattleFail);
					return;
				}
			}
			else
			{
				this.SetMoraleInfoByNotify(notify);
			}
		}

		// Token: 0x0603BB8E RID: 244622 RVA: 0x00E43184 File Offset: 0x00E41384
		[NullableContext(1)]
		private void SetMoraleInfoByNotify(MoraleInfoNotify notify)
		{
			this.MoraleExp = Math.Min(this.MoraleMaxExp, notify.KeepMoraleExp);
			this.MoraleLevel = notify.KeepMoraleLevel;
			this.MoraleIndomitableLevel = notify.IndomitableLevel;
			this.TempMoraleLevel = notify.TempMoraleLevel;
			this.TempMoraleExp = notify.TempMoraleExp;
		}

		// Token: 0x0603BB8F RID: 244623 RVA: 0x00E431D8 File Offset: 0x00E413D8
		public EMoraleLevelDiffType GetMoraleLevelDiffType(int compareLevel, int? playerLevel = null)
		{
			int num = (playerLevel ?? (this.GetMoraleLevel() + this.GetTempMoraleLevel())) - compareLevel;
			IReadOnlyList<MoraleLevelDiffShow> allLevelDiffShowConfig = MoraleBattleConfig.Instance.GetAllLevelDiffShowConfig();
			EMoraleLevelDiffType emoraleLevelDiffType = EMoraleLevelDiffType.Easy;
			if (allLevelDiffShowConfig == null)
			{
				return emoraleLevelDiffType;
			}
			foreach (MoraleLevelDiffShow moraleLevelDiffShow in allLevelDiffShowConfig)
			{
				if (num >= moraleLevelDiffShow.LevelDiffLower && num < moraleLevelDiffShow.LevelDiffUpper)
				{
					emoraleLevelDiffType = (EMoraleLevelDiffType)moraleLevelDiffShow.MonsterLevelPattern;
					if (emoraleLevelDiffType > EMoraleLevelDiffType.Hard)
					{
						emoraleLevelDiffType = EMoraleLevelDiffType.Hard;
						break;
					}
					if (emoraleLevelDiffType < EMoraleLevelDiffType.Easy)
					{
						emoraleLevelDiffType = EMoraleLevelDiffType.Easy;
						break;
					}
					break;
				}
			}
			return emoraleLevelDiffType;
		}

		// Token: 0x17008DBB RID: 36283
		// (get) Token: 0x0603BB90 RID: 244624 RVA: 0x00E43284 File Offset: 0x00E41484
		[Nullable(1)]
		public static MoraleBattleModel Instance
		{
			[NullableContext(1)]
			get
			{
				return MoraleBattleModel._Instance;
			}
		}

		// Token: 0x0603BB91 RID: 244625 RVA: 0x00E4328B File Offset: 0x00E4148B
		[NullableContext(1)]
		public static MoraleBattleModel GetOrCreateInstance()
		{
			if (MoraleBattleModel._Instance == null)
			{
				MoraleBattleModel.CreateInstance();
			}
			return MoraleBattleModel._Instance;
		}

		// Token: 0x0603BB92 RID: 244626 RVA: 0x00E4329F File Offset: 0x00E4149F
		public static bool CreateInstance()
		{
			if (MoraleBattleModel._Instance != null)
			{
				return true;
			}
			MoraleBattleModel._Instance = new MoraleBattleModel();
			return true;
		}

		// Token: 0x0603BB93 RID: 244627 RVA: 0x00E432B5 File Offset: 0x00E414B5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BB94 RID: 244628 RVA: 0x00E432B7 File Offset: 0x00E414B7
		public static void ResetStaticDefaultValue()
		{
			MoraleBattleModel._Instance = null;
		}

		// Token: 0x0603BB95 RID: 244629 RVA: 0x00E432BF File Offset: 0x00E414BF
		static MoraleBattleModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MoraleBattleModel.CreateStaticDefaultValue), new Action(MoraleBattleModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401F16D RID: 127341
		private const int EXTRA_TEMP_MORALE_MAX_LEVEL_BUFF_ID = 632400018;

		// Token: 0x0401F16E RID: 127342
		private const int EXTRA_TEMP_MORALE_MAX_LEVEL = 100;

		// Token: 0x0401F16F RID: 127343
		private int MoraleConfigId;

		// Token: 0x0401F170 RID: 127344
		private int MoraleExp;

		// Token: 0x0401F171 RID: 127345
		private int MoraleMaxExp;

		// Token: 0x0401F172 RID: 127346
		private int MoraleLevel = 1;

		// Token: 0x0401F173 RID: 127347
		private int TempMoraleLevel;

		// Token: 0x0401F174 RID: 127348
		private int TempMoraleExp;

		// Token: 0x0401F175 RID: 127349
		private int MoraleIndomitableLevel = 1;

		// Token: 0x0401F176 RID: 127350
		private bool IsMoraleActiveInternal;

		// Token: 0x0401F177 RID: 127351
		private bool IsMoraleInited;

		// Token: 0x0401F178 RID: 127352
		private IReadOnlyList<MoraleKeepLevel> ExpConfigListInternal;

		// Token: 0x0401F179 RID: 127353
		private IReadOnlyList<BattleScoreLevelConf> TempExpConfigListInternal;

		// Token: 0x0401F17A RID: 127354
		private Dictionary<int, int> LevelExpCache;

		// Token: 0x0401F17B RID: 127355
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private Dictionary<int, ValueTuple<int, int>> TempLevelExpRangeCache;

		// Token: 0x0401F17C RID: 127356
		private int ExpRatio;

		// Token: 0x0401F17D RID: 127357
		private int LastMoraleLevel = 1;

		// Token: 0x0401F17E RID: 127358
		private bool IsCheckTempMoraleMaxLevelBuff;

		// Token: 0x0401F17F RID: 127359
		private bool IsUnlockTempMoraleMaxLevel;

		// Token: 0x0401F180 RID: 127360
		private static MoraleBattleModel _Instance;
	}
}

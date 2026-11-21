using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C2E RID: 19502
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class MoraleBattleModel : ModelBase
	{
		// Token: 0x06030AC0 RID: 199360 RVA: 0x00D92E7C File Offset: 0x00D9107C
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06030AC1 RID: 199361 RVA: 0x00D92E7F File Offset: 0x00D9107F
		protected override bool OnLeaveLevel()
		{
			this.ExpConfigListInternal = null;
			this.TempExpConfigListInternal = null;
			this.LevelExpCache = null;
			this.TempLevelExpRangeCache = null;
			this.IsCheckTempMoraleMaxLevelBuff = false;
			return true;
		}

		// Token: 0x06030AC2 RID: 199362 RVA: 0x00D92EA5 File Offset: 0x00D910A5
		public bool IsMoraleActive()
		{
			return this.IsMoraleActiveInternal;
		}

		// Token: 0x06030AC3 RID: 199363 RVA: 0x00D92EAD File Offset: 0x00D910AD
		public void SetMoraleActive(bool active)
		{
			this.IsMoraleActiveInternal = active;
		}

		// Token: 0x06030AC4 RID: 199364 RVA: 0x00D92EB6 File Offset: 0x00D910B6
		public int GetMoraleLevel()
		{
			return this.MoraleLevel;
		}

		// Token: 0x06030AC5 RID: 199365 RVA: 0x00D92EC0 File Offset: 0x00D910C0
		public int GetMoraleMaxLevel()
		{
			IReadOnlyList<MoraleKeepLevel> expConfigList = this.GetExpConfigList();
			if (expConfigList != null)
			{
				return expConfigList.Count - 1;
			}
			return 1;
		}

		// Token: 0x06030AC6 RID: 199366 RVA: 0x00D92EE1 File Offset: 0x00D910E1
		public int GetLastMoraleLevel()
		{
			return this.LastMoraleLevel;
		}

		// Token: 0x06030AC7 RID: 199367 RVA: 0x00D92EE9 File Offset: 0x00D910E9
		public int GetMoraleIndomitableLevel()
		{
			return this.MoraleIndomitableLevel;
		}

		// Token: 0x06030AC8 RID: 199368 RVA: 0x00D92EF1 File Offset: 0x00D910F1
		public int GetTempMoraleLevel()
		{
			return this.TempMoraleLevel;
		}

		// Token: 0x06030AC9 RID: 199369 RVA: 0x00D92EF9 File Offset: 0x00D910F9
		public int GetTempMoraleExp()
		{
			return this.TempMoraleExp;
		}

		// Token: 0x06030ACA RID: 199370 RVA: 0x00D92F01 File Offset: 0x00D91101
		public int GetExpRatio()
		{
			return this.ExpRatio;
		}

		// Token: 0x06030ACB RID: 199371 RVA: 0x00D92F0C File Offset: 0x00D9110C
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

		// Token: 0x06030ACC RID: 199372 RVA: 0x00D92F99 File Offset: 0x00D91199
		public int GetMoraleMaxExp()
		{
			if (this.MoraleMaxExp == 0)
			{
				this.MoraleMaxExp = this.GetLevelExp(this.GetMoraleMaxLevel());
			}
			return this.MoraleMaxExp;
		}

		// Token: 0x06030ACD RID: 199373 RVA: 0x00D92FBB File Offset: 0x00D911BB
		public void SetIsUnlockTempMoraleMaxLevel(bool isUnlock)
		{
			this.IsUnlockTempMoraleMaxLevel = isUnlock;
		}

		// Token: 0x06030ACE RID: 199374 RVA: 0x00D92FC4 File Offset: 0x00D911C4
		private IReadOnlyList<MoraleKeepLevel> GetExpConfigList()
		{
			if (this.ExpConfigListInternal == null)
			{
				this.ExpConfigListInternal = (MoraleBattleConfig.Instance.GetAllExpConfig() ?? Array.Empty<MoraleKeepLevel>());
			}
			return this.ExpConfigListInternal;
		}

		// Token: 0x06030ACF RID: 199375 RVA: 0x00D92FF0 File Offset: 0x00D911F0
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

		// Token: 0x06030AD0 RID: 199376 RVA: 0x00D93070 File Offset: 0x00D91270
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

		// Token: 0x06030AD1 RID: 199377 RVA: 0x00D93100 File Offset: 0x00D91300
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

		// Token: 0x06030AD2 RID: 199378 RVA: 0x00D931E4 File Offset: 0x00D913E4
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

		// Token: 0x06030AD3 RID: 199379 RVA: 0x00D93238 File Offset: 0x00D91438
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

		// Token: 0x06030AD4 RID: 199380 RVA: 0x00D93294 File Offset: 0x00D91494
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

		// Token: 0x06030AD5 RID: 199381 RVA: 0x00D932DC File Offset: 0x00D914DC
		public int GetTempMoraleLevelUpExp(int? targetLevel = null)
		{
			int level = targetLevel ?? this.TempMoraleLevel;
			ValueTuple<int, int> tempLevelExpRange = this.GetTempLevelExpRange(level);
			return Math.Max(0, tempLevelExpRange.Item2 - tempLevelExpRange.Item1);
		}

		// Token: 0x06030AD6 RID: 199382 RVA: 0x00D93320 File Offset: 0x00D91520
		public int GetTempMoraleLevelExp()
		{
			ValueTuple<int, int> tempLevelExpRange = this.GetTempLevelExpRange(this.TempMoraleLevel);
			return Math.Max(0, this.TempMoraleExp - tempLevelExpRange.Item1);
		}

		// Token: 0x06030AD7 RID: 199383 RVA: 0x00D93350 File Offset: 0x00D91550
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

		// Token: 0x06030AD8 RID: 199384 RVA: 0x00D9338C File Offset: 0x00D9158C
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

		// Token: 0x06030AD9 RID: 199385 RVA: 0x00D93550 File Offset: 0x00D91750
		[NullableContext(1)]
		private void SetMoraleInfoByNotify(MoraleInfoNotify notify)
		{
			this.MoraleExp = Math.Min(this.MoraleMaxExp, notify.KeepMoraleExp);
			this.MoraleLevel = notify.KeepMoraleLevel;
			this.MoraleIndomitableLevel = notify.IndomitableLevel;
			this.TempMoraleLevel = notify.TempMoraleLevel;
			this.TempMoraleExp = notify.TempMoraleExp;
		}

		// Token: 0x06030ADA RID: 199386 RVA: 0x00D935A4 File Offset: 0x00D917A4
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

		// Token: 0x1700618D RID: 24973
		// (get) Token: 0x06030ADB RID: 199387 RVA: 0x00D93650 File Offset: 0x00D91850
		[Nullable(1)]
		public static MoraleBattleModel Instance
		{
			[NullableContext(1)]
			get
			{
				return MoraleBattleModel._Instance;
			}
		}

		// Token: 0x06030ADC RID: 199388 RVA: 0x00D93657 File Offset: 0x00D91857
		[NullableContext(1)]
		public static MoraleBattleModel GetOrCreateInstance()
		{
			if (MoraleBattleModel._Instance == null)
			{
				MoraleBattleModel.CreateInstance();
			}
			return MoraleBattleModel._Instance;
		}

		// Token: 0x06030ADD RID: 199389 RVA: 0x00D9366B File Offset: 0x00D9186B
		public static bool CreateInstance()
		{
			if (MoraleBattleModel._Instance != null)
			{
				return true;
			}
			MoraleBattleModel._Instance = new MoraleBattleModel();
			return true;
		}

		// Token: 0x06030ADE RID: 199390 RVA: 0x00D93681 File Offset: 0x00D91881
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030ADF RID: 199391 RVA: 0x00D93683 File Offset: 0x00D91883
		public static void ResetStaticDefaultValue()
		{
			MoraleBattleModel._Instance = null;
		}

		// Token: 0x06030AE0 RID: 199392 RVA: 0x00D9368B File Offset: 0x00D9188B
		static MoraleBattleModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MoraleBattleModel.CreateStaticDefaultValue), new Action(MoraleBattleModel.ResetStaticDefaultValue));
		}

		// Token: 0x04019C1E RID: 105502
		private const int EXTRA_TEMP_MORALE_MAX_LEVEL_BUFF_ID = 632400018;

		// Token: 0x04019C1F RID: 105503
		private const int EXTRA_TEMP_MORALE_MAX_LEVEL = 100;

		// Token: 0x04019C20 RID: 105504
		private int MoraleConfigId;

		// Token: 0x04019C21 RID: 105505
		private int MoraleExp;

		// Token: 0x04019C22 RID: 105506
		private int MoraleMaxExp;

		// Token: 0x04019C23 RID: 105507
		private int MoraleLevel = 1;

		// Token: 0x04019C24 RID: 105508
		private int TempMoraleLevel;

		// Token: 0x04019C25 RID: 105509
		private int TempMoraleExp;

		// Token: 0x04019C26 RID: 105510
		private int MoraleIndomitableLevel = 1;

		// Token: 0x04019C27 RID: 105511
		private bool IsMoraleActiveInternal;

		// Token: 0x04019C28 RID: 105512
		private bool IsMoraleInited;

		// Token: 0x04019C29 RID: 105513
		private IReadOnlyList<MoraleKeepLevel> ExpConfigListInternal;

		// Token: 0x04019C2A RID: 105514
		private IReadOnlyList<BattleScoreLevelConf> TempExpConfigListInternal;

		// Token: 0x04019C2B RID: 105515
		private Dictionary<int, int> LevelExpCache;

		// Token: 0x04019C2C RID: 105516
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private Dictionary<int, ValueTuple<int, int>> TempLevelExpRangeCache;

		// Token: 0x04019C2D RID: 105517
		private int ExpRatio;

		// Token: 0x04019C2E RID: 105518
		private int LastMoraleLevel = 1;

		// Token: 0x04019C2F RID: 105519
		private bool IsCheckTempMoraleMaxLevelBuff;

		// Token: 0x04019C30 RID: 105520
		private bool IsUnlockTempMoraleMaxLevel;

		// Token: 0x04019C31 RID: 105521
		private static MoraleBattleModel _Instance;
	}
}

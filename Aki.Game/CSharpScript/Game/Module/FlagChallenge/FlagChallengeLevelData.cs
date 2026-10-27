using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A27 RID: 23079
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeLevelData
	{
		// Token: 0x17008BD8 RID: 35800
		// (get) Token: 0x0603A8E7 RID: 239847 RVA: 0x00DEFF86 File Offset: 0x00DEE186
		// (set) Token: 0x0603A8E8 RID: 239848 RVA: 0x00DEFF8E File Offset: 0x00DEE18E
		public int Index
		{
			get
			{
				return this.IndexIntl;
			}
			set
			{
				this.IndexIntl = value;
			}
		}

		// Token: 0x0603A8E9 RID: 239849 RVA: 0x00DEFF98 File Offset: 0x00DEE198
		public FlagChallengeLevelData(int id)
		{
			this.Id = id;
			this.LevelConfig = FlagChallengeConfig.Instance.GetLevelConfig(id).Value;
		}

		// Token: 0x0603A8EA RID: 239850 RVA: 0x00DEFFCB File Offset: 0x00DEE1CB
		public void Refresh(FlagChallengeLevelInfo levelData)
		{
			this.UnlockTime = (double)MathUtils.Instance.LongToNumber(levelData.UnlockTime);
			this.LevelStatus = (EFlagChallengeLevelStatus)levelData.State;
		}

		// Token: 0x0603A8EB RID: 239851 RVA: 0x00DEFFF0 File Offset: 0x00DEE1F0
		public double GetUnlockTime()
		{
			return this.UnlockTime;
		}

		// Token: 0x0603A8EC RID: 239852 RVA: 0x00DEFFF8 File Offset: 0x00DEE1F8
		public double GetRemainTime()
		{
			return Math.Max(0.0, this.UnlockTime - TimeUtil.Instance.GetServerTimeStamp());
		}

		// Token: 0x0603A8ED RID: 239853 RVA: 0x00DF0019 File Offset: 0x00DEE219
		public EFlagChallengeLevelStatus GetLevelStatus()
		{
			return this.LevelStatus;
		}

		// Token: 0x0603A8EE RID: 239854 RVA: 0x00DF0021 File Offset: 0x00DEE221
		public bool IsReachUnlockTime()
		{
			return TimeUtil.Instance.GetServerTimeStamp() >= this.GetUnlockTime();
		}

		// Token: 0x0603A8EF RID: 239855 RVA: 0x00DF0038 File Offset: 0x00DEE238
		public int GetInstanceDungeonId()
		{
			return this.LevelConfig.InstId;
		}

		// Token: 0x0603A8F0 RID: 239856 RVA: 0x00DF0045 File Offset: 0x00DEE245
		public int[] GetPreLevelIds()
		{
			return this.LevelConfig.PreLevelId();
		}

		// Token: 0x0603A8F1 RID: 239857 RVA: 0x00DF0052 File Offset: 0x00DEE252
		public int GetUnlockLevel()
		{
			return this.LevelConfig.UnlockLevel;
		}

		// Token: 0x0603A8F2 RID: 239858 RVA: 0x00DF005F File Offset: 0x00DEE25F
		public EFlagChallengeUiStyleType GetUiStyle()
		{
			return (EFlagChallengeUiStyleType)this.LevelConfig.UiStyle;
		}

		// Token: 0x0603A8F3 RID: 239859 RVA: 0x00DF006C File Offset: 0x00DEE26C
		public bool IsHiddenLevel()
		{
			return this.LevelConfig.IsHiddenLevel;
		}

		// Token: 0x0603A8F4 RID: 239860 RVA: 0x00DF0079 File Offset: 0x00DEE279
		public bool IsHidden()
		{
			return this.IsHiddenLevel() && !FlagChallengeModel.Instance.GetFlagChallengeData(this.LevelConfig.ActivityId).IsAllLevelPassWithoutHidden();
		}

		// Token: 0x0603A8F5 RID: 239861 RVA: 0x00DF00A2 File Offset: 0x00DEE2A2
		public int[] GetRecommendLevel()
		{
			return this.LevelConfig.RecommendLevels();
		}

		// Token: 0x0603A8F6 RID: 239862 RVA: 0x00DF00AF File Offset: 0x00DEE2AF
		public bool IsLocked()
		{
			return this.GetLevelStatus() == EFlagChallengeLevelStatus.Locked;
		}

		// Token: 0x0603A8F7 RID: 239863 RVA: 0x00DF00BA File Offset: 0x00DEE2BA
		public bool IsCompleted()
		{
			return this.GetLevelStatus() == EFlagChallengeLevelStatus.Completed;
		}

		// Token: 0x0603A8F8 RID: 239864 RVA: 0x00DF00C5 File Offset: 0x00DEE2C5
		public bool IsUnlocked()
		{
			return this.GetLevelStatus() == EFlagChallengeLevelStatus.Unlocked;
		}

		// Token: 0x0401E7D6 RID: 124886
		public readonly int Id;

		// Token: 0x0401E7D7 RID: 124887
		public FlagChallengeLevel LevelConfig;

		// Token: 0x0401E7D8 RID: 124888
		private int IndexIntl;

		// Token: 0x0401E7D9 RID: 124889
		private double UnlockTime;

		// Token: 0x0401E7DA RID: 124890
		private EFlagChallengeLevelStatus LevelStatus;
	}
}

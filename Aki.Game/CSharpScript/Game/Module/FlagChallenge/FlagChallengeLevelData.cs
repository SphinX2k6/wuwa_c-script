using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A03 RID: 18947
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeLevelData
	{
		// Token: 0x17005FA6 RID: 24486
		// (get) Token: 0x0602F830 RID: 194608 RVA: 0x00D4050A File Offset: 0x00D3E70A
		// (set) Token: 0x0602F831 RID: 194609 RVA: 0x00D40512 File Offset: 0x00D3E712
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

		// Token: 0x0602F832 RID: 194610 RVA: 0x00D4051C File Offset: 0x00D3E71C
		public FlagChallengeLevelData(int id)
		{
			this.Id = id;
			this.LevelConfig = FlagChallengeConfig.Instance.GetLevelConfig(id).Value;
		}

		// Token: 0x0602F833 RID: 194611 RVA: 0x00D4054F File Offset: 0x00D3E74F
		public void Refresh(FlagChallengeLevelInfo levelData)
		{
			this.UnlockTime = (double)MathUtils.Instance.LongToNumber(levelData.UnlockTime);
			this.LevelStatus = (EFlagChallengeLevelStatus)levelData.State;
		}

		// Token: 0x0602F834 RID: 194612 RVA: 0x00D40574 File Offset: 0x00D3E774
		public double GetUnlockTime()
		{
			return this.UnlockTime;
		}

		// Token: 0x0602F835 RID: 194613 RVA: 0x00D4057C File Offset: 0x00D3E77C
		public double GetRemainTime()
		{
			return Math.Max(0.0, this.UnlockTime - TimeUtil.Instance.GetServerTimeStamp());
		}

		// Token: 0x0602F836 RID: 194614 RVA: 0x00D4059D File Offset: 0x00D3E79D
		public EFlagChallengeLevelStatus GetLevelStatus()
		{
			return this.LevelStatus;
		}

		// Token: 0x0602F837 RID: 194615 RVA: 0x00D405A5 File Offset: 0x00D3E7A5
		public bool IsReachUnlockTime()
		{
			return TimeUtil.Instance.GetServerTimeStamp() >= this.GetUnlockTime();
		}

		// Token: 0x0602F838 RID: 194616 RVA: 0x00D405BC File Offset: 0x00D3E7BC
		public int GetInstanceDungeonId()
		{
			return this.LevelConfig.InstId;
		}

		// Token: 0x0602F839 RID: 194617 RVA: 0x00D405C9 File Offset: 0x00D3E7C9
		public int[] GetPreLevelIds()
		{
			return this.LevelConfig.PreLevelId();
		}

		// Token: 0x0602F83A RID: 194618 RVA: 0x00D405D6 File Offset: 0x00D3E7D6
		public int GetUnlockLevel()
		{
			return this.LevelConfig.UnlockLevel;
		}

		// Token: 0x0602F83B RID: 194619 RVA: 0x00D405E3 File Offset: 0x00D3E7E3
		public EFlagChallengeUiStyleType GetUiStyle()
		{
			return (EFlagChallengeUiStyleType)this.LevelConfig.UiStyle;
		}

		// Token: 0x0602F83C RID: 194620 RVA: 0x00D405F0 File Offset: 0x00D3E7F0
		public bool IsHiddenLevel()
		{
			return this.LevelConfig.IsHiddenLevel;
		}

		// Token: 0x0602F83D RID: 194621 RVA: 0x00D405FD File Offset: 0x00D3E7FD
		public bool IsHidden()
		{
			return this.IsHiddenLevel() && !FlagChallengeModel.Instance.GetFlagChallengeData(this.LevelConfig.ActivityId).IsAllLevelPassWithoutHidden();
		}

		// Token: 0x0602F83E RID: 194622 RVA: 0x00D40626 File Offset: 0x00D3E826
		public int[] GetRecommendLevel()
		{
			return this.LevelConfig.RecommendLevels();
		}

		// Token: 0x0602F83F RID: 194623 RVA: 0x00D40633 File Offset: 0x00D3E833
		public bool IsLocked()
		{
			return this.GetLevelStatus() == EFlagChallengeLevelStatus.Locked;
		}

		// Token: 0x0602F840 RID: 194624 RVA: 0x00D4063E File Offset: 0x00D3E83E
		public bool IsCompleted()
		{
			return this.GetLevelStatus() == EFlagChallengeLevelStatus.Completed;
		}

		// Token: 0x0602F841 RID: 194625 RVA: 0x00D40649 File Offset: 0x00D3E849
		public bool IsUnlocked()
		{
			return this.GetLevelStatus() == EFlagChallengeLevelStatus.Unlocked;
		}

		// Token: 0x0401927D RID: 103037
		public readonly int Id;

		// Token: 0x0401927E RID: 103038
		public FlagChallengeLevel LevelConfig;

		// Token: 0x0401927F RID: 103039
		private int IndexIntl;

		// Token: 0x04019280 RID: 103040
		private double UnlockTime;

		// Token: 0x04019281 RID: 103041
		private EFlagChallengeLevelStatus LevelStatus;
	}
}

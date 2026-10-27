using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.ExploreLevel
{
	// Token: 0x02005A8C RID: 23180
	[NullableContext(1)]
	[Nullable(0)]
	public class CountryExploreLevelRewardData
	{
		// Token: 0x0603AB5E RID: 240478 RVA: 0x00DFC324 File Offset: 0x00DFA524
		public void Initialize(ExploreReward exploreRewardConfig)
		{
			this.ScoreName = exploreRewardConfig.ScoreName;
			this.RewardNameId = exploreRewardConfig.Reward;
			this.ScoreTexturePath = exploreRewardConfig.ScoreTexturePath;
			this.ShowItem = exploreRewardConfig.ShowItem;
			this.NeedScore = exploreRewardConfig.NeedScore;
			this.DropId = exploreRewardConfig.Drop;
			this.UnlockSpritePath = exploreRewardConfig.Pic;
			this.ExploreLevel = exploreRewardConfig.ExploreLevel;
			this.ShowUnlockSprite = exploreRewardConfig.Show;
			this.HelpId = exploreRewardConfig.Help;
			int country = exploreRewardConfig.Country;
			this.CountryNameId = InfluenceConfig.Instance.GetCountryConfig(country).Value.Title;
		}

		// Token: 0x0603AB5F RID: 240479 RVA: 0x00DFC3DC File Offset: 0x00DFA5DC
		public string GetScoreNameId()
		{
			return this.ScoreName;
		}

		// Token: 0x0603AB60 RID: 240480 RVA: 0x00DFC3E4 File Offset: 0x00DFA5E4
		public string GetRewardNameId()
		{
			return this.RewardNameId;
		}

		// Token: 0x0603AB61 RID: 240481 RVA: 0x00DFC3EC File Offset: 0x00DFA5EC
		public string GetScoreTexturePath()
		{
			return this.ScoreTexturePath;
		}

		// Token: 0x0603AB62 RID: 240482 RVA: 0x00DFC3F4 File Offset: 0x00DFA5F4
		public int GetPreviewItemConfigId()
		{
			return this.ShowItem;
		}

		// Token: 0x0603AB63 RID: 240483 RVA: 0x00DFC3FC File Offset: 0x00DFA5FC
		public int GetMaxExploreScore()
		{
			return this.NeedScore;
		}

		// Token: 0x0603AB64 RID: 240484 RVA: 0x00DFC404 File Offset: 0x00DFA604
		public string GetCountryNameId()
		{
			return this.CountryNameId;
		}

		// Token: 0x0603AB65 RID: 240485 RVA: 0x00DFC40C File Offset: 0x00DFA60C
		[NullableContext(2)]
		public Dictionary<int, int> GetDropItemNumMap()
		{
			return ExploreLevelConfig.Instance.GetDropShowInfo(this.DropId);
		}

		// Token: 0x0603AB66 RID: 240486 RVA: 0x00DFC41E File Offset: 0x00DFA61E
		public int GetExploreLevel()
		{
			return this.ExploreLevel;
		}

		// Token: 0x0603AB67 RID: 240487 RVA: 0x00DFC426 File Offset: 0x00DFA626
		public string GetUnlockSpritePath()
		{
			return this.UnlockSpritePath;
		}

		// Token: 0x0603AB68 RID: 240488 RVA: 0x00DFC42E File Offset: 0x00DFA62E
		public bool IsShowUnlockSprite()
		{
			return this.ShowUnlockSprite;
		}

		// Token: 0x0603AB69 RID: 240489 RVA: 0x00DFC436 File Offset: 0x00DFA636
		public int GetHelpId()
		{
			return this.HelpId;
		}

		// Token: 0x0401EA4F RID: 125519
		private string ScoreName = "";

		// Token: 0x0401EA50 RID: 125520
		private string RewardNameId = "";

		// Token: 0x0401EA51 RID: 125521
		private string ScoreTexturePath = "";

		// Token: 0x0401EA52 RID: 125522
		private int ShowItem;

		// Token: 0x0401EA53 RID: 125523
		private int NeedScore;

		// Token: 0x0401EA54 RID: 125524
		private int DropId;

		// Token: 0x0401EA55 RID: 125525
		private string UnlockSpritePath = "";

		// Token: 0x0401EA56 RID: 125526
		private int ExploreLevel;

		// Token: 0x0401EA57 RID: 125527
		private bool ShowUnlockSprite;

		// Token: 0x0401EA58 RID: 125528
		private int HelpId;

		// Token: 0x0401EA59 RID: 125529
		private string CountryNameId = "";
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.ExploreLevel
{
	// Token: 0x02004A68 RID: 19048
	[NullableContext(1)]
	[Nullable(0)]
	public class CountryExploreLevelRewardData
	{
		// Token: 0x0602FAA7 RID: 195239 RVA: 0x00D4C8B8 File Offset: 0x00D4AAB8
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

		// Token: 0x0602FAA8 RID: 195240 RVA: 0x00D4C970 File Offset: 0x00D4AB70
		public string GetScoreNameId()
		{
			return this.ScoreName;
		}

		// Token: 0x0602FAA9 RID: 195241 RVA: 0x00D4C978 File Offset: 0x00D4AB78
		public string GetRewardNameId()
		{
			return this.RewardNameId;
		}

		// Token: 0x0602FAAA RID: 195242 RVA: 0x00D4C980 File Offset: 0x00D4AB80
		public string GetScoreTexturePath()
		{
			return this.ScoreTexturePath;
		}

		// Token: 0x0602FAAB RID: 195243 RVA: 0x00D4C988 File Offset: 0x00D4AB88
		public int GetPreviewItemConfigId()
		{
			return this.ShowItem;
		}

		// Token: 0x0602FAAC RID: 195244 RVA: 0x00D4C990 File Offset: 0x00D4AB90
		public int GetMaxExploreScore()
		{
			return this.NeedScore;
		}

		// Token: 0x0602FAAD RID: 195245 RVA: 0x00D4C998 File Offset: 0x00D4AB98
		public string GetCountryNameId()
		{
			return this.CountryNameId;
		}

		// Token: 0x0602FAAE RID: 195246 RVA: 0x00D4C9A0 File Offset: 0x00D4ABA0
		[NullableContext(2)]
		public Dictionary<int, int> GetDropItemNumMap()
		{
			return ExploreLevelConfig.Instance.GetDropShowInfo(this.DropId);
		}

		// Token: 0x0602FAAF RID: 195247 RVA: 0x00D4C9B2 File Offset: 0x00D4ABB2
		public int GetExploreLevel()
		{
			return this.ExploreLevel;
		}

		// Token: 0x0602FAB0 RID: 195248 RVA: 0x00D4C9BA File Offset: 0x00D4ABBA
		public string GetUnlockSpritePath()
		{
			return this.UnlockSpritePath;
		}

		// Token: 0x0602FAB1 RID: 195249 RVA: 0x00D4C9C2 File Offset: 0x00D4ABC2
		public bool IsShowUnlockSprite()
		{
			return this.ShowUnlockSprite;
		}

		// Token: 0x0602FAB2 RID: 195250 RVA: 0x00D4C9CA File Offset: 0x00D4ABCA
		public int GetHelpId()
		{
			return this.HelpId;
		}

		// Token: 0x040194F6 RID: 103670
		private string ScoreName = "";

		// Token: 0x040194F7 RID: 103671
		private string RewardNameId = "";

		// Token: 0x040194F8 RID: 103672
		private string ScoreTexturePath = "";

		// Token: 0x040194F9 RID: 103673
		private int ShowItem;

		// Token: 0x040194FA RID: 103674
		private int NeedScore;

		// Token: 0x040194FB RID: 103675
		private int DropId;

		// Token: 0x040194FC RID: 103676
		private string UnlockSpritePath = "";

		// Token: 0x040194FD RID: 103677
		private int ExploreLevel;

		// Token: 0x040194FE RID: 103678
		private bool ShowUnlockSprite;

		// Token: 0x040194FF RID: 103679
		private int HelpId;

		// Token: 0x04019500 RID: 103680
		private string CountryNameId = "";
	}
}

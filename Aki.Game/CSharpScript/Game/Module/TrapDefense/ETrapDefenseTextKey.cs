using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039E5 RID: 14821
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct ETrapDefenseTextKey : IEquatable<ETrapDefenseTextKey>
	{
		// Token: 0x0602630D RID: 156429 RVA: 0x00AB5E84 File Offset: 0x00AB4084
		private ETrapDefenseTextKey(string value)
		{
			this._Value = value;
		}

		// Token: 0x0602630E RID: 156430 RVA: 0x00AB5E8D File Offset: 0x00AB408D
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0602630F RID: 156431 RVA: 0x00AB5E95 File Offset: 0x00AB4095
		public bool Equals(ETrapDefenseTextKey other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06026310 RID: 156432 RVA: 0x00AB5EA8 File Offset: 0x00AB40A8
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is ETrapDefenseTextKey)
			{
				ETrapDefenseTextKey other = (ETrapDefenseTextKey)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06026311 RID: 156433 RVA: 0x00AB5ECD File Offset: 0x00AB40CD
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06026312 RID: 156434 RVA: 0x00AB5EE0 File Offset: 0x00AB40E0
		public static bool operator ==(ETrapDefenseTextKey left, ETrapDefenseTextKey right)
		{
			return left.Equals(right);
		}

		// Token: 0x06026313 RID: 156435 RVA: 0x00AB5EEA File Offset: 0x00AB40EA
		public static bool operator !=(ETrapDefenseTextKey left, ETrapDefenseTextKey right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04014F2A RID: 85802
		private readonly string _Value;

		// Token: 0x04014F2B RID: 85803
		public static readonly ETrapDefenseTextKey BdSumTabBdProgress = new ETrapDefenseTextKey("TrapDefense_BdSumTab_BdProgress");

		// Token: 0x04014F2C RID: 85804
		public static readonly ETrapDefenseTextKey BdSumTabBuffSum = new ETrapDefenseTextKey("TrapDefense_BdSumTab_BuffSum");

		// Token: 0x04014F2D RID: 85805
		public static readonly ETrapDefenseTextKey GoToMainView = new ETrapDefenseTextKey("TrapDefense_GoToMainView");

		// Token: 0x04014F2E RID: 85806
		public static readonly ETrapDefenseTextKey BdSumBdItemProgressRichText = new ETrapDefenseTextKey("TrapDefense_BdSumBdItem_ProgressRichText");

		// Token: 0x04014F2F RID: 85807
		public static readonly ETrapDefenseTextKey BdBuffSelectRefreshDesc = new ETrapDefenseTextKey("TrapDefense_BdBuffSelect_RefreshDesc");

		// Token: 0x04014F30 RID: 85808
		public static readonly ETrapDefenseTextKey BdBuffSelectPurpleBuffToPool = new ETrapDefenseTextKey("TrapDefense_BdBuffSelect_PurpleBuffToPool");

		// Token: 0x04014F31 RID: 85809
		public static readonly ETrapDefenseTextKey BdBuffSelectGoldBuffToPool = new ETrapDefenseTextKey("TrapDefense_BdBuffSelect_GoldBuffToPool");

		// Token: 0x04014F32 RID: 85810
		public static readonly ETrapDefenseTextKey BdBuffLockShowName = new ETrapDefenseTextKey("TrapDefense_BdBuff_LockShowName");

		// Token: 0x04014F33 RID: 85811
		public static readonly ETrapDefenseTextKey MonsterType = new ETrapDefenseTextKey("TrapDefense_MonsterType");

		// Token: 0x04014F34 RID: 85812
		public static readonly ETrapDefenseTextKey MonsterWave = new ETrapDefenseTextKey("TrapDefense_MonsterWave");

		// Token: 0x04014F35 RID: 85813
		public static readonly ETrapDefenseTextKey XValueShow = new ETrapDefenseTextKey("XValueShow");

		// Token: 0x04014F36 RID: 85814
		public static readonly ETrapDefenseTextKey LevelDifficultyNormal = new ETrapDefenseTextKey("TrapDefenseLevelDifficultyNormal");

		// Token: 0x04014F37 RID: 85815
		public static readonly ETrapDefenseTextKey LevelDifficultyNightmare = new ETrapDefenseTextKey("TrapDefenseLevelDifficultyNightmare");

		// Token: 0x04014F38 RID: 85816
		public static readonly ETrapDefenseTextKey LevelDifficultyHell = new ETrapDefenseTextKey("TrapDefenseLevelDifficultyHell");

		// Token: 0x04014F39 RID: 85817
		public static readonly ETrapDefenseTextKey LevelTargetHp = new ETrapDefenseTextKey("TrapDefenseLevelTargetHp");

		// Token: 0x04014F3A RID: 85818
		public static readonly ETrapDefenseTextKey LevelTargetWave = new ETrapDefenseTextKey("TrapDefenseLevelTargetWave");

		// Token: 0x04014F3B RID: 85819
		public static readonly ETrapDefenseTextKey LevelDescTitle = new ETrapDefenseTextKey("TrapDefenseLevelDescTitle");

		// Token: 0x04014F3C RID: 85820
		public static readonly ETrapDefenseTextKey LevelRewardTitleTalent = new ETrapDefenseTextKey("TrapDefenseLevelRewardTitleTalent");

		// Token: 0x04014F3D RID: 85821
		public static readonly ETrapDefenseTextKey LevelRewardTitleMachine = new ETrapDefenseTextKey("TrapDefenseLevelRewardTitleMachine");

		// Token: 0x04014F3E RID: 85822
		public static readonly ETrapDefenseTextKey LevelRewardTitleBdBuff = new ETrapDefenseTextKey("TrapDefenseLevelRewardTitleBdBuff");

		// Token: 0x04014F3F RID: 85823
		public static readonly ETrapDefenseTextKey LevelCanSaveTitle = new ETrapDefenseTextKey("TrapDefenseLevelCanSaveTitle");

		// Token: 0x04014F40 RID: 85824
		public static readonly ETrapDefenseTextKey LevelExistSaveTitle = new ETrapDefenseTextKey("TrapDefenseLevelExistSaveTitle");

		// Token: 0x04014F41 RID: 85825
		public static readonly ETrapDefenseTextKey BdBuffSelectEmptyListTips = new ETrapDefenseTextKey("TrapDefenseBdBuffSelectEmptyListTips");

		// Token: 0x04014F42 RID: 85826
		public static readonly ETrapDefenseTextKey RougeModeNotOpen = new ETrapDefenseTextKey("TrapDefenseRougeModeNotOpen");

		// Token: 0x04014F43 RID: 85827
		public static readonly ETrapDefenseTextKey TalentNodeUnlock = new ETrapDefenseTextKey("TrapDefenseTalentNodeUnlock");

		// Token: 0x04014F44 RID: 85828
		public static readonly ETrapDefenseTextKey TalentNodeUnlocked = new ETrapDefenseTextKey("TrapDefenseTalentNodeUnlocked");

		// Token: 0x04014F45 RID: 85829
		public static readonly ETrapDefenseTextKey TalentNodeNeedUnlockPre = new ETrapDefenseTextKey("TrapDefenseTalentNodeNeedUnlockPre");

		// Token: 0x04014F46 RID: 85830
		public static readonly ETrapDefenseTextKey TalentNodeUpgradeTips = new ETrapDefenseTextKey("TrapDefenseTalentNodeUpgradeTips");

		// Token: 0x04014F47 RID: 85831
		public static readonly ETrapDefenseTextKey EndlessRogueBestRecord = new ETrapDefenseTextKey("TrapDefenseEndlessRogueBestRecord");

		// Token: 0x04014F48 RID: 85832
		public static readonly ETrapDefenseTextKey EndlessRogueBestWaves = new ETrapDefenseTextKey("TrapDefenseEndlessRogueBestWaves");

		// Token: 0x04014F49 RID: 85833
		public static readonly ETrapDefenseTextKey RougeModeUnlockTargetStar = new ETrapDefenseTextKey("TrapDefenseRougeModeUnlockTargetStar");

		// Token: 0x04014F4A RID: 85834
		public static readonly ETrapDefenseTextKey Purchase = new ETrapDefenseTextKey("TrapDefenseShopPurchase");

		// Token: 0x04014F4B RID: 85835
		public static readonly ETrapDefenseTextKey ShopGoodsItem = new ETrapDefenseTextKey("TrapDefenseShopGoodsItem");

		// Token: 0x04014F4C RID: 85836
		public static readonly ETrapDefenseTextKey ShopGoodsBuff = new ETrapDefenseTextKey("TrapDefenseShopGoodsBuff");

		// Token: 0x04014F4D RID: 85837
		public static readonly ETrapDefenseTextKey ShopBuffViewEntry = new ETrapDefenseTextKey("TrapDefenseShopBuffViewEntry");

		// Token: 0x04014F4E RID: 85838
		public static readonly ETrapDefenseTextKey ShopGoodsRefresh = new ETrapDefenseTextKey("TrapDefenseShopGoodsRefresh");

		// Token: 0x04014F4F RID: 85839
		public static readonly ETrapDefenseTextKey RogueUnlockTimeLimit = new ETrapDefenseTextKey("TrapDefense_RougeUnlock_TimeLimit");

		// Token: 0x04014F50 RID: 85840
		public static readonly ETrapDefenseTextKey RogueUnlockStageLimit = new ETrapDefenseTextKey("TrapDefense_RougeUnlock_StageLimit");

		// Token: 0x04014F51 RID: 85841
		public static readonly ETrapDefenseTextKey ShopGoodsSoldOut = new ETrapDefenseTextKey("TrapDefenseShopGoodsSoldOut");

		// Token: 0x04014F52 RID: 85842
		public static readonly ETrapDefenseTextKey ShopGoodsInventoryCountReachLimit = new ETrapDefenseTextKey("TrapDefenseShopGoodsInventoryCountReachLimit");

		// Token: 0x04014F53 RID: 85843
		public static readonly ETrapDefenseTextKey ShopPurchaseSuccess = new ETrapDefenseTextKey("TrapDefenseShopPurchaseSuccess");

		// Token: 0x04014F54 RID: 85844
		public static readonly ETrapDefenseTextKey ShopPurchaseNum = new ETrapDefenseTextKey("Text_ItemSelectShopQuantityTip_text");

		// Token: 0x04014F55 RID: 85845
		public static readonly ETrapDefenseTextKey ShopRefreshSuccess = new ETrapDefenseTextKey("TrapDefenseShopRefreshSuccess");

		// Token: 0x04014F56 RID: 85846
		public static readonly ETrapDefenseTextKey TrapDefenseShopNoCost = new ETrapDefenseTextKey("TrapDefenseShopNoCost");

		// Token: 0x04014F57 RID: 85847
		public static readonly ETrapDefenseTextKey BdBuffSelectAfterTips = new ETrapDefenseTextKey("TrapDefenseBdBuffSelectAfterTips");

		// Token: 0x04014F58 RID: 85848
		public static readonly ETrapDefenseTextKey RogueUnlockCountDown = new ETrapDefenseTextKey("TrapDefense_RougeUnlock_Countdown");
	}
}

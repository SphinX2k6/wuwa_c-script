using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A3D RID: 19005
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct ETrapDefenseTextKey : IEquatable<ETrapDefenseTextKey>
	{
		// Token: 0x0603157D RID: 202109 RVA: 0x00B71F00 File Offset: 0x00B70100
		private ETrapDefenseTextKey(string value)
		{
			this._Value = value;
		}

		// Token: 0x0603157E RID: 202110 RVA: 0x00B71F09 File Offset: 0x00B70109
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0603157F RID: 202111 RVA: 0x00B71F11 File Offset: 0x00B70111
		public bool Equals(ETrapDefenseTextKey other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06031580 RID: 202112 RVA: 0x00B71F24 File Offset: 0x00B70124
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

		// Token: 0x06031581 RID: 202113 RVA: 0x00B71F49 File Offset: 0x00B70149
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06031582 RID: 202114 RVA: 0x00B71F5C File Offset: 0x00B7015C
		public static bool operator ==(ETrapDefenseTextKey left, ETrapDefenseTextKey right)
		{
			return left.Equals(right);
		}

		// Token: 0x06031583 RID: 202115 RVA: 0x00B71F66 File Offset: 0x00B70166
		public static bool operator !=(ETrapDefenseTextKey left, ETrapDefenseTextKey right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401A5D8 RID: 107992
		private readonly string _Value;

		// Token: 0x0401A5D9 RID: 107993
		public static readonly ETrapDefenseTextKey BdSumTabBdProgress = new ETrapDefenseTextKey("TrapDefense_BdSumTab_BdProgress");

		// Token: 0x0401A5DA RID: 107994
		public static readonly ETrapDefenseTextKey BdSumTabBuffSum = new ETrapDefenseTextKey("TrapDefense_BdSumTab_BuffSum");

		// Token: 0x0401A5DB RID: 107995
		public static readonly ETrapDefenseTextKey GoToMainView = new ETrapDefenseTextKey("TrapDefense_GoToMainView");

		// Token: 0x0401A5DC RID: 107996
		public static readonly ETrapDefenseTextKey BdSumBdItemProgressRichText = new ETrapDefenseTextKey("TrapDefense_BdSumBdItem_ProgressRichText");

		// Token: 0x0401A5DD RID: 107997
		public static readonly ETrapDefenseTextKey BdBuffSelectRefreshDesc = new ETrapDefenseTextKey("TrapDefense_BdBuffSelect_RefreshDesc");

		// Token: 0x0401A5DE RID: 107998
		public static readonly ETrapDefenseTextKey BdBuffSelectPurpleBuffToPool = new ETrapDefenseTextKey("TrapDefense_BdBuffSelect_PurpleBuffToPool");

		// Token: 0x0401A5DF RID: 107999
		public static readonly ETrapDefenseTextKey BdBuffSelectGoldBuffToPool = new ETrapDefenseTextKey("TrapDefense_BdBuffSelect_GoldBuffToPool");

		// Token: 0x0401A5E0 RID: 108000
		public static readonly ETrapDefenseTextKey BdBuffLockShowName = new ETrapDefenseTextKey("TrapDefense_BdBuff_LockShowName");

		// Token: 0x0401A5E1 RID: 108001
		public static readonly ETrapDefenseTextKey MonsterType = new ETrapDefenseTextKey("TrapDefense_MonsterType");

		// Token: 0x0401A5E2 RID: 108002
		public static readonly ETrapDefenseTextKey MonsterWave = new ETrapDefenseTextKey("TrapDefense_MonsterWave");

		// Token: 0x0401A5E3 RID: 108003
		public static readonly ETrapDefenseTextKey XValueShow = new ETrapDefenseTextKey("XValueShow");

		// Token: 0x0401A5E4 RID: 108004
		public static readonly ETrapDefenseTextKey LevelDifficultyNormal = new ETrapDefenseTextKey("TrapDefenseLevelDifficultyNormal");

		// Token: 0x0401A5E5 RID: 108005
		public static readonly ETrapDefenseTextKey LevelDifficultyNightmare = new ETrapDefenseTextKey("TrapDefenseLevelDifficultyNightmare");

		// Token: 0x0401A5E6 RID: 108006
		public static readonly ETrapDefenseTextKey LevelDifficultyHell = new ETrapDefenseTextKey("TrapDefenseLevelDifficultyHell");

		// Token: 0x0401A5E7 RID: 108007
		public static readonly ETrapDefenseTextKey LevelTargetHp = new ETrapDefenseTextKey("TrapDefenseLevelTargetHp");

		// Token: 0x0401A5E8 RID: 108008
		public static readonly ETrapDefenseTextKey LevelTargetWave = new ETrapDefenseTextKey("TrapDefenseLevelTargetWave");

		// Token: 0x0401A5E9 RID: 108009
		public static readonly ETrapDefenseTextKey LevelDescTitle = new ETrapDefenseTextKey("TrapDefenseLevelDescTitle");

		// Token: 0x0401A5EA RID: 108010
		public static readonly ETrapDefenseTextKey LevelRewardTitleTalent = new ETrapDefenseTextKey("TrapDefenseLevelRewardTitleTalent");

		// Token: 0x0401A5EB RID: 108011
		public static readonly ETrapDefenseTextKey LevelRewardTitleMachine = new ETrapDefenseTextKey("TrapDefenseLevelRewardTitleMachine");

		// Token: 0x0401A5EC RID: 108012
		public static readonly ETrapDefenseTextKey LevelRewardTitleBdBuff = new ETrapDefenseTextKey("TrapDefenseLevelRewardTitleBdBuff");

		// Token: 0x0401A5ED RID: 108013
		public static readonly ETrapDefenseTextKey LevelCanSaveTitle = new ETrapDefenseTextKey("TrapDefenseLevelCanSaveTitle");

		// Token: 0x0401A5EE RID: 108014
		public static readonly ETrapDefenseTextKey LevelExistSaveTitle = new ETrapDefenseTextKey("TrapDefenseLevelExistSaveTitle");

		// Token: 0x0401A5EF RID: 108015
		public static readonly ETrapDefenseTextKey BdBuffSelectEmptyListTips = new ETrapDefenseTextKey("TrapDefenseBdBuffSelectEmptyListTips");

		// Token: 0x0401A5F0 RID: 108016
		public static readonly ETrapDefenseTextKey RougeModeNotOpen = new ETrapDefenseTextKey("TrapDefenseRougeModeNotOpen");

		// Token: 0x0401A5F1 RID: 108017
		public static readonly ETrapDefenseTextKey TalentNodeUnlock = new ETrapDefenseTextKey("TrapDefenseTalentNodeUnlock");

		// Token: 0x0401A5F2 RID: 108018
		public static readonly ETrapDefenseTextKey TalentNodeUnlocked = new ETrapDefenseTextKey("TrapDefenseTalentNodeUnlocked");

		// Token: 0x0401A5F3 RID: 108019
		public static readonly ETrapDefenseTextKey TalentNodeNeedUnlockPre = new ETrapDefenseTextKey("TrapDefenseTalentNodeNeedUnlockPre");

		// Token: 0x0401A5F4 RID: 108020
		public static readonly ETrapDefenseTextKey TalentNodeUpgradeTips = new ETrapDefenseTextKey("TrapDefenseTalentNodeUpgradeTips");

		// Token: 0x0401A5F5 RID: 108021
		public static readonly ETrapDefenseTextKey EndlessRogueBestRecord = new ETrapDefenseTextKey("TrapDefenseEndlessRogueBestRecord");

		// Token: 0x0401A5F6 RID: 108022
		public static readonly ETrapDefenseTextKey EndlessRogueBestWaves = new ETrapDefenseTextKey("TrapDefenseEndlessRogueBestWaves");

		// Token: 0x0401A5F7 RID: 108023
		public static readonly ETrapDefenseTextKey RougeModeUnlockTargetStar = new ETrapDefenseTextKey("TrapDefenseRougeModeUnlockTargetStar");

		// Token: 0x0401A5F8 RID: 108024
		public static readonly ETrapDefenseTextKey Purchase = new ETrapDefenseTextKey("TrapDefenseShopPurchase");

		// Token: 0x0401A5F9 RID: 108025
		public static readonly ETrapDefenseTextKey ShopGoodsItem = new ETrapDefenseTextKey("TrapDefenseShopGoodsItem");

		// Token: 0x0401A5FA RID: 108026
		public static readonly ETrapDefenseTextKey ShopGoodsBuff = new ETrapDefenseTextKey("TrapDefenseShopGoodsBuff");

		// Token: 0x0401A5FB RID: 108027
		public static readonly ETrapDefenseTextKey ShopBuffViewEntry = new ETrapDefenseTextKey("TrapDefenseShopBuffViewEntry");

		// Token: 0x0401A5FC RID: 108028
		public static readonly ETrapDefenseTextKey ShopGoodsRefresh = new ETrapDefenseTextKey("TrapDefenseShopGoodsRefresh");

		// Token: 0x0401A5FD RID: 108029
		public static readonly ETrapDefenseTextKey RogueUnlockTimeLimit = new ETrapDefenseTextKey("TrapDefense_RougeUnlock_TimeLimit");

		// Token: 0x0401A5FE RID: 108030
		public static readonly ETrapDefenseTextKey RogueUnlockStageLimit = new ETrapDefenseTextKey("TrapDefense_RougeUnlock_StageLimit");

		// Token: 0x0401A5FF RID: 108031
		public static readonly ETrapDefenseTextKey ShopGoodsSoldOut = new ETrapDefenseTextKey("TrapDefenseShopGoodsSoldOut");

		// Token: 0x0401A600 RID: 108032
		public static readonly ETrapDefenseTextKey ShopGoodsInventoryCountReachLimit = new ETrapDefenseTextKey("TrapDefenseShopGoodsInventoryCountReachLimit");

		// Token: 0x0401A601 RID: 108033
		public static readonly ETrapDefenseTextKey ShopPurchaseSuccess = new ETrapDefenseTextKey("TrapDefenseShopPurchaseSuccess");

		// Token: 0x0401A602 RID: 108034
		public static readonly ETrapDefenseTextKey ShopPurchaseNum = new ETrapDefenseTextKey("Text_ItemSelectShopQuantityTip_text");

		// Token: 0x0401A603 RID: 108035
		public static readonly ETrapDefenseTextKey ShopRefreshSuccess = new ETrapDefenseTextKey("TrapDefenseShopRefreshSuccess");

		// Token: 0x0401A604 RID: 108036
		public static readonly ETrapDefenseTextKey TrapDefenseShopNoCost = new ETrapDefenseTextKey("TrapDefenseShopNoCost");

		// Token: 0x0401A605 RID: 108037
		public static readonly ETrapDefenseTextKey BdBuffSelectAfterTips = new ETrapDefenseTextKey("TrapDefenseBdBuffSelectAfterTips");

		// Token: 0x0401A606 RID: 108038
		public static readonly ETrapDefenseTextKey RogueUnlockCountDown = new ETrapDefenseTextKey("TrapDefense_RougeUnlock_Countdown");
	}
}

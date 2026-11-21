using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047BD RID: 18365
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemRewardDefine : IStaticVariableResetter
	{
		// Token: 0x0602E22B RID: 188971 RVA: 0x00CDF298 File Offset: 0x00CDD498
		static ItemRewardDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemRewardDefine.CreateStaticDefaultValue), new Action(ItemRewardDefine.ResetStaticDefaultValue));
		}

		// Token: 0x17005DCA RID: 24010
		// (get) Token: 0x0602E22C RID: 188972 RVA: 0x00CDF2B7 File Offset: 0x00CDD4B7
		public static int[] FillRoleDevelopStateTagReasonIdList
		{
			get
			{
				return ItemRewardDefine._fillRoleDevelopStateTagReasonIdList;
			}
		}

		// Token: 0x17005DCB RID: 24011
		// (get) Token: 0x0602E22D RID: 188973 RVA: 0x00CDF2BE File Offset: 0x00CDD4BE
		public static int[] BlockReasonIdList
		{
			get
			{
				return ItemRewardDefine._blockReasonIdList;
			}
		}

		// Token: 0x17005DCC RID: 24012
		// (get) Token: 0x0602E22E RID: 188974 RVA: 0x00CDF2C5 File Offset: 0x00CDD4C5
		public static int[] BlockObtainReasonIdList
		{
			get
			{
				return ItemRewardDefine._blockObtainReasonIdList;
			}
		}

		// Token: 0x0602E22F RID: 188975 RVA: 0x00CDF2CC File Offset: 0x00CDD4CC
		public static void CreateStaticDefaultValue()
		{
			ItemRewardDefine._fillRoleDevelopStateTagReasonIdList = new int[]
			{
				15008,
				15009,
				150010
			};
			ItemRewardDefine._blockReasonIdList = new int[]
			{
				25001,
				49011,
				49012,
				19102,
				19100,
				19101,
				51201,
				52803
			};
			ItemRewardDefine._blockObtainReasonIdList = new int[]
			{
				50600,
				51201,
				51705,
				52803,
				53512,
				54801,
				54802
			};
		}

		// Token: 0x0602E230 RID: 188976 RVA: 0x00CDF31B File Offset: 0x00CDD51B
		public static void ResetStaticDefaultValue()
		{
			ItemRewardDefine._fillRoleDevelopStateTagReasonIdList = null;
			ItemRewardDefine._blockReasonIdList = null;
			ItemRewardDefine._blockObtainReasonIdList = null;
		}

		// Token: 0x0401894E RID: 100686
		public const int ITEM_EXCHANGE_RESON = 13000;

		// Token: 0x0401894F RID: 100687
		public const int BLACK_STONE_RESON = 15008;

		// Token: 0x04018950 RID: 100688
		public const int COMPLETE_GAME_RESON = 15009;

		// Token: 0x04018951 RID: 100689
		public const int INSTANCE_EXCHANGE_RESON = 150010;

		// Token: 0x04018952 RID: 100690
		public const int BLACK_STONE_CONFIG = 3006;

		// Token: 0x04018953 RID: 100691
		public const int QUEST_SPECIAL_REWARD = 6003;

		// Token: 0x04018954 RID: 100692
		public const int EXPLORE_LEVEL_RESON = 20200;

		// Token: 0x04018955 RID: 100693
		public const int ACHIEVEMENT_RESON = 19100;

		// Token: 0x04018956 RID: 100694
		public const int ACHIEVEMENT_GROUP_REWARD_REASON = 19101;

		// Token: 0x04018957 RID: 100695
		public const int ACHIEVEMENT_MULTI_REASON = 19102;

		// Token: 0x04018958 RID: 100696
		public const int FISHING_ITEM_AUTO_CONVERT = 27002;

		// Token: 0x04018959 RID: 100697
		public const int ROGUE_INST_FIRST_REWARD_CONFIG = 3010;

		// Token: 0x0401895A RID: 100698
		public const int ROGUE_INST_FIRST_REWARD = 19707;

		// Token: 0x0401895B RID: 100699
		public const int LORD_GYM_RESULT = 3011;

		// Token: 0x0401895C RID: 100700
		public const int MOWING_RESULT = 3013;

		// Token: 0x0401895D RID: 100701
		public const int MOWING_ERROR_RESULT = 3012;

		// Token: 0x0401895E RID: 100702
		public const int ROLE_TRIAL_ERROR_RESULT = 3014;

		// Token: 0x0401895F RID: 100703
		public const int BOSS_RUSH_SUCCESS = 3016;

		// Token: 0x04018960 RID: 100704
		public const int BOSS_RUSH_FAIL = 3015;

		// Token: 0x04018961 RID: 100705
		public const int TRACK_MOON_PHASE_REWARD = 25001;

		// Token: 0x04018962 RID: 100706
		public const int FARM_GOLD_FAIL = 3021;

		// Token: 0x04018963 RID: 100707
		public const int FARM_GOLD_SUCCESS = 3022;

		// Token: 0x04018964 RID: 100708
		public const int ROLE_SKIN_TRIAL_ERROR_RESULT = 3023;

		// Token: 0x04018965 RID: 100709
		public const int SHIP_TOWER_SUCCESS = 3016;

		// Token: 0x04018966 RID: 100710
		public const int SOLAR_SPEED_SUCCESS = 3024;

		// Token: 0x04018967 RID: 100711
		public const int BABEL_TOWER_SUCCESS = 3025;

		// Token: 0x04018968 RID: 100712
		public const int BABEL_TOWER_FAIL = 3026;

		// Token: 0x04018969 RID: 100713
		public const int ABYSS_FAIL = 3027;

		// Token: 0x0401896A RID: 100714
		public const int ABYSS_SUCCESS = 3028;

		// Token: 0x0401896B RID: 100715
		public const int ROGUELIKE_BOSS_CHALLENGE_INSTANCE_SUCCESS = 3032;

		// Token: 0x0401896C RID: 100716
		public const int BATTLE_PASS_REWARD_REASON = 18500;

		// Token: 0x0401896D RID: 100717
		public const int BATTLE_PASS_REWARD_REASON1 = 18504;

		// Token: 0x0401896E RID: 100718
		public const int BATTLE_PASS_REWARD_REASON2 = 18505;

		// Token: 0x0401896F RID: 100719
		public const int DAILY_ACTIVITY_REWARD_REASON = 19600;

		// Token: 0x04018970 RID: 100720
		public const int REGRESS_BP_REASON = 48007;

		// Token: 0x04018971 RID: 100721
		public const int REGRESS_BP_PAY_ITEM_ID = 50021;

		// Token: 0x04018972 RID: 100722
		public const int PAY_REASON = 8001;

		// Token: 0x04018973 RID: 100723
		public const int CONSOLE_EXTRA_PAY_GIFT_PREVIEW_DURATION_SEC = 2592000;

		// Token: 0x04018974 RID: 100724
		public const int PHANTOM_ARENA_BATTLE_RESULT = 49011;

		// Token: 0x04018975 RID: 100725
		public const int PHANTOM_ARENA_BATTLE_FIRST = 49012;

		// Token: 0x04018976 RID: 100726
		public const int INFR_ROAD_NETWORK_SHOP_REASON = 50600;

		// Token: 0x04018977 RID: 100727
		public const int NEW_PLAYER_SUPPORT_REWARD_REASON = 51201;

		// Token: 0x04018978 RID: 100728
		public const int ENCIRCLE_REWARD_REASON = 52401;

		// Token: 0x04018979 RID: 100729
		public const int MOTOR_FIGHT_FIRST_CLEAR = 51705;

		// Token: 0x0401897A RID: 100730
		public const int FLAG_CHALLENGE_STRONGHOLD_REWARD = 52803;

		// Token: 0x0401897B RID: 100731
		public const int TETRIS_REWARD_REASON = 53101;

		// Token: 0x0401897C RID: 100732
		public const int VILLAGE_INFRA_TREE_BUILD = 53512;

		// Token: 0x0401897D RID: 100733
		public const int SHERIFF_REWARD_REASON = 54801;

		// Token: 0x0401897E RID: 100734
		public const int SHERIFF_CRIMINAL_REASON = 54802;

		// Token: 0x0401897F RID: 100735
		[Nullable(2)]
		private static int[] _fillRoleDevelopStateTagReasonIdList;

		// Token: 0x04018980 RID: 100736
		[Nullable(2)]
		private static int[] _blockReasonIdList;

		// Token: 0x04018981 RID: 100737
		[Nullable(2)]
		private static int[] _blockObtainReasonIdList;

		// Token: 0x04018982 RID: 100738
		public const int DEFAULT_REWARD_UI = 50000;
	}
}

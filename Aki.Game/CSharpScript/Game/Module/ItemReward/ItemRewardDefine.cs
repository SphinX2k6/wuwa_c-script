using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057E6 RID: 22502
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemRewardDefine : IStaticVariableResetter
	{
		// Token: 0x06039317 RID: 234263 RVA: 0x00D9044F File Offset: 0x00D8E64F
		static ItemRewardDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemRewardDefine.CreateStaticDefaultValue), new Action(ItemRewardDefine.ResetStaticDefaultValue));
		}

		// Token: 0x17008A00 RID: 35328
		// (get) Token: 0x06039318 RID: 234264 RVA: 0x00D9046E File Offset: 0x00D8E66E
		public static int[] FillRoleDevelopStateTagReasonIdList
		{
			get
			{
				return ItemRewardDefine._fillRoleDevelopStateTagReasonIdList;
			}
		}

		// Token: 0x17008A01 RID: 35329
		// (get) Token: 0x06039319 RID: 234265 RVA: 0x00D90475 File Offset: 0x00D8E675
		public static int[] BlockReasonIdList
		{
			get
			{
				return ItemRewardDefine._blockReasonIdList;
			}
		}

		// Token: 0x17008A02 RID: 35330
		// (get) Token: 0x0603931A RID: 234266 RVA: 0x00D9047C File Offset: 0x00D8E67C
		public static int[] BlockObtainReasonIdList
		{
			get
			{
				return ItemRewardDefine._blockObtainReasonIdList;
			}
		}

		// Token: 0x0603931B RID: 234267 RVA: 0x00D90484 File Offset: 0x00D8E684
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

		// Token: 0x0603931C RID: 234268 RVA: 0x00D904D3 File Offset: 0x00D8E6D3
		public static void ResetStaticDefaultValue()
		{
			ItemRewardDefine._fillRoleDevelopStateTagReasonIdList = null;
			ItemRewardDefine._blockReasonIdList = null;
			ItemRewardDefine._blockObtainReasonIdList = null;
		}

		// Token: 0x0401DEB7 RID: 122551
		public const int ITEM_EXCHANGE_RESON = 13000;

		// Token: 0x0401DEB8 RID: 122552
		public const int BLACK_STONE_RESON = 15008;

		// Token: 0x0401DEB9 RID: 122553
		public const int COMPLETE_GAME_RESON = 15009;

		// Token: 0x0401DEBA RID: 122554
		public const int INSTANCE_EXCHANGE_RESON = 150010;

		// Token: 0x0401DEBB RID: 122555
		public const int BLACK_STONE_CONFIG = 3006;

		// Token: 0x0401DEBC RID: 122556
		public const int QUEST_SPECIAL_REWARD = 6003;

		// Token: 0x0401DEBD RID: 122557
		public const int EXPLORE_LEVEL_RESON = 20200;

		// Token: 0x0401DEBE RID: 122558
		public const int ACHIEVEMENT_RESON = 19100;

		// Token: 0x0401DEBF RID: 122559
		public const int ACHIEVEMENT_GROUP_REWARD_REASON = 19101;

		// Token: 0x0401DEC0 RID: 122560
		public const int ACHIEVEMENT_MULTI_REASON = 19102;

		// Token: 0x0401DEC1 RID: 122561
		public const int FISHING_ITEM_AUTO_CONVERT = 27002;

		// Token: 0x0401DEC2 RID: 122562
		public const int ROGUE_INST_FIRST_REWARD_CONFIG = 3010;

		// Token: 0x0401DEC3 RID: 122563
		public const int ROGUE_INST_FIRST_REWARD = 19707;

		// Token: 0x0401DEC4 RID: 122564
		public const int LORD_GYM_RESULT = 3011;

		// Token: 0x0401DEC5 RID: 122565
		public const int MOWING_RESULT = 3013;

		// Token: 0x0401DEC6 RID: 122566
		public const int MOWING_ERROR_RESULT = 3012;

		// Token: 0x0401DEC7 RID: 122567
		public const int ROLE_TRIAL_ERROR_RESULT = 3014;

		// Token: 0x0401DEC8 RID: 122568
		public const int BOSS_RUSH_SUCCESS = 3016;

		// Token: 0x0401DEC9 RID: 122569
		public const int BOSS_RUSH_FAIL = 3015;

		// Token: 0x0401DECA RID: 122570
		public const int TRACK_MOON_PHASE_REWARD = 25001;

		// Token: 0x0401DECB RID: 122571
		public const int FARM_GOLD_FAIL = 3021;

		// Token: 0x0401DECC RID: 122572
		public const int FARM_GOLD_SUCCESS = 3022;

		// Token: 0x0401DECD RID: 122573
		public const int ROLE_SKIN_TRIAL_ERROR_RESULT = 3023;

		// Token: 0x0401DECE RID: 122574
		public const int SHIP_TOWER_SUCCESS = 3016;

		// Token: 0x0401DECF RID: 122575
		public const int SOLAR_SPEED_SUCCESS = 3024;

		// Token: 0x0401DED0 RID: 122576
		public const int BABEL_TOWER_SUCCESS = 3025;

		// Token: 0x0401DED1 RID: 122577
		public const int BABEL_TOWER_FAIL = 3026;

		// Token: 0x0401DED2 RID: 122578
		public const int ABYSS_FAIL = 3027;

		// Token: 0x0401DED3 RID: 122579
		public const int ABYSS_SUCCESS = 3028;

		// Token: 0x0401DED4 RID: 122580
		public const int ROGUELIKE_BOSS_CHALLENGE_INSTANCE_SUCCESS = 3032;

		// Token: 0x0401DED5 RID: 122581
		public const int BATTLE_PASS_REWARD_REASON = 18500;

		// Token: 0x0401DED6 RID: 122582
		public const int BATTLE_PASS_REWARD_REASON1 = 18504;

		// Token: 0x0401DED7 RID: 122583
		public const int BATTLE_PASS_REWARD_REASON2 = 18505;

		// Token: 0x0401DED8 RID: 122584
		public const int DAILY_ACTIVITY_REWARD_REASON = 19600;

		// Token: 0x0401DED9 RID: 122585
		public const int REGRESS_BP_REASON = 48007;

		// Token: 0x0401DEDA RID: 122586
		public const int REGRESS_BP_PAY_ITEM_ID = 50021;

		// Token: 0x0401DEDB RID: 122587
		public const int PAY_REASON = 8001;

		// Token: 0x0401DEDC RID: 122588
		public const int CONSOLE_EXTRA_PAY_GIFT_PREVIEW_DURATION_SEC = 2592000;

		// Token: 0x0401DEDD RID: 122589
		public const int PHANTOM_ARENA_BATTLE_RESULT = 49011;

		// Token: 0x0401DEDE RID: 122590
		public const int PHANTOM_ARENA_BATTLE_FIRST = 49012;

		// Token: 0x0401DEDF RID: 122591
		public const int INFR_ROAD_NETWORK_SHOP_REASON = 50600;

		// Token: 0x0401DEE0 RID: 122592
		public const int NEW_PLAYER_SUPPORT_REWARD_REASON = 51201;

		// Token: 0x0401DEE1 RID: 122593
		public const int ENCIRCLE_REWARD_REASON = 52401;

		// Token: 0x0401DEE2 RID: 122594
		public const int MOTOR_FIGHT_FIRST_CLEAR = 51705;

		// Token: 0x0401DEE3 RID: 122595
		public const int FLAG_CHALLENGE_STRONGHOLD_REWARD = 52803;

		// Token: 0x0401DEE4 RID: 122596
		public const int TETRIS_REWARD_REASON = 53101;

		// Token: 0x0401DEE5 RID: 122597
		public const int VILLAGE_INFRA_TREE_BUILD = 53512;

		// Token: 0x0401DEE6 RID: 122598
		public const int SHERIFF_REWARD_REASON = 54801;

		// Token: 0x0401DEE7 RID: 122599
		public const int SHERIFF_CRIMINAL_REASON = 54802;

		// Token: 0x0401DEE8 RID: 122600
		[Nullable(2)]
		private static int[] _fillRoleDevelopStateTagReasonIdList;

		// Token: 0x0401DEE9 RID: 122601
		[Nullable(2)]
		private static int[] _blockReasonIdList;

		// Token: 0x0401DEEA RID: 122602
		[Nullable(2)]
		private static int[] _blockObtainReasonIdList;

		// Token: 0x0401DEEB RID: 122603
		public const int DEFAULT_REWARD_UI = 50000;
	}
}

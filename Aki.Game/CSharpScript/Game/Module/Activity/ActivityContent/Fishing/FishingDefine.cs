using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006605 RID: 26117
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingDefine : IStaticVariableResetter
	{
		// Token: 0x0604174E RID: 268110 RVA: 0x00FD9C51 File Offset: 0x00FD7E51
		static FishingDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FishingDefine.CreateStaticDefaultValue), new Action(FishingDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0604174F RID: 268111 RVA: 0x00FD9C80 File Offset: 0x00FD7E80
		public static void CreateStaticDefaultValue()
		{
			FishingDefine.fishingQualityColor = new Dictionary<int, string>
			{
				{
					0,
					"FFFFFFFF"
				},
				{
					1,
					"ffffff00"
				},
				{
					2,
					"C788E9FF"
				},
				{
					3,
					"7BCDF5FF"
				},
				{
					4,
					"7BCDF5FF"
				}
			};
			FishingDefine.fishingStateText = new Dictionary<int, string>
			{
				{
					1,
					"FishingReceiving"
				},
				{
					2,
					"FishingFinishing"
				},
				{
					0,
					"FishingReceiving"
				},
				{
					3,
					"FishingDoing"
				}
			};
			FishingDefine.fishingStateColorText = new Dictionary<int, string>
			{
				{
					1,
					"#59B4D3"
				},
				{
					2,
					"#5CC35E"
				},
				{
					0,
					"#59B4D3"
				},
				{
					3,
					"#FFFFFF"
				}
			};
			FishingDefine.fishingSelectStateColorText = new Dictionary<int, string>
			{
				{
					1,
					"#59B4D3"
				},
				{
					2,
					"#5CC35E"
				},
				{
					0,
					"#59B4D3"
				},
				{
					3,
					"#5B544A"
				}
			};
			FishingDefine.fishingQuestPoolColorText = new Dictionary<int, string>
			{
				{
					1,
					"#A69B62"
				},
				{
					2,
					"#6EA079"
				},
				{
					3,
					"#A69B62"
				},
				{
					4,
					"#5F89A1"
				},
				{
					5,
					"#6EA079"
				}
			};
			FishingDefine.fishingEntrustTypeText = new Dictionary<int, string>
			{
				{
					0,
					"FishingTagFishing"
				},
				{
					1,
					"FishingTagMaterial"
				},
				{
					2,
					"FishingTagDeliver"
				}
			};
			FishingDefine.fishingItemTypeText = new Dictionary<int, string>
			{
				{
					3,
					"Fishing_FishingKing"
				},
				{
					4,
					"Fishing_FishingMaterial"
				},
				{
					1,
					"Fishing_FishingNormal"
				},
				{
					2,
					"Fishing_FishingVariation"
				}
			};
			FishingDefine.fishingItemTimeText = new Dictionary<int, string>
			{
				{
					2,
					"Fishing_OnlyDay"
				},
				{
					3,
					"Fishing_OnlyNight"
				},
				{
					1,
					"Fishing_WholeDay"
				}
			};
			FishingDefine.fishingNodeTypeText = new Dictionary<int, string>
			{
				{
					1,
					"Fishing_TechType1"
				},
				{
					2,
					"Fishing_TechType2"
				},
				{
					3,
					"Fishing_TechType3"
				}
			};
			List<int> collection = new List<int>
			{
				71510101,
				71510102,
				71510103,
				71510201,
				71510202,
				71510203
			};
			FishingDefine.fishingItemList = new List<int>
			{
				38,
				37,
				29,
				30,
				31,
				27
			};
			FishingDefine.fishingItemList.AddRange(collection);
			FishingDefine.fishingEffectList = new List<int>
			{
				880700303,
				880700310,
				880700305,
				880700307
			};
		}

		// Token: 0x06041750 RID: 268112 RVA: 0x00FD9F50 File Offset: 0x00FD8150
		public static void ResetStaticDefaultValue()
		{
			FishingDefine.fishingQualityColor = null;
			FishingDefine.fishingStateText = null;
			FishingDefine.fishingStateColorText = null;
			FishingDefine.fishingSelectStateColorText = null;
			FishingDefine.fishingQuestPoolColorText = null;
			FishingDefine.fishingEntrustTypeText = null;
			FishingDefine.fishingItemTypeText = null;
			FishingDefine.fishingItemTimeText = null;
			FishingDefine.fishingNodeTypeText = null;
			FishingDefine.fishingItemList = null;
			FishingDefine.fishingEffectList = null;
		}

		// Token: 0x040220D4 RID: 139476
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, string> fishingQualityColor;

		// Token: 0x040220D5 RID: 139477
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, string> fishingStateText;

		// Token: 0x040220D6 RID: 139478
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, string> fishingStateColorText;

		// Token: 0x040220D7 RID: 139479
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, string> fishingSelectStateColorText;

		// Token: 0x040220D8 RID: 139480
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, string> fishingQuestPoolColorText;

		// Token: 0x040220D9 RID: 139481
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, string> fishingEntrustTypeText;

		// Token: 0x040220DA RID: 139482
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, string> fishingItemTypeText;

		// Token: 0x040220DB RID: 139483
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, string> fishingItemTimeText;

		// Token: 0x040220DC RID: 139484
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, string> fishingNodeTypeText;

		// Token: 0x040220DD RID: 139485
		[Nullable(2)]
		public static List<int> fishingItemList;

		// Token: 0x040220DE RID: 139486
		[Nullable(2)]
		public static List<int> fishingEffectList;

		// Token: 0x040220DF RID: 139487
		public const int UNVALID_ITEM_BLOCK_ID = -1;

		// Token: 0x040220E0 RID: 139488
		public const int BACKPACK_ROW_COUNT = 7;

		// Token: 0x040220E1 RID: 139489
		public const int BACKPACK_COL_COUNT = 8;

		// Token: 0x040220E2 RID: 139490
		public const int INTERACT_ROW_COUNT = 3;

		// Token: 0x040220E3 RID: 139491
		public const int INTERACT_COL_COUNT = 6;

		// Token: 0x040220E4 RID: 139492
		public const string EMPTY_SPRITE = "SP_GridEmpty";

		// Token: 0x040220E5 RID: 139493
		public const string DISABLE_SPRITE = "SP_GridSellDisable";

		// Token: 0x040220E6 RID: 139494
		public const string PREVIEW_SPRITE = "SP_GridFinsh";

		// Token: 0x040220E7 RID: 139495
		public const string SINGLE_OCCUPANCY_SPRITE = "SP_GridReplace";

		// Token: 0x040220E8 RID: 139496
		public const string MULTI_OCCUPANCY_SPRITE = "SP_GridError";

		// Token: 0x040220E9 RID: 139497
		public const string PROHIBIT_SPRITE = "SP_GridError";

		// Token: 0x040220EA RID: 139498
		public const string FINISH_SPRITE = "SP_GridQuality";

		// Token: 0x040220EB RID: 139499
		public const string OUTLINE_SPRITE = "SP_GridFinsh";

		// Token: 0x040220EC RID: 139500
		public const string PREVIEW_ERROR_SPRITE = "SP_GridError";

		// Token: 0x040220ED RID: 139501
		public const string PREVIEW_OCCUPANCY_SPRITE = "SP_GridReplace";

		// Token: 0x040220EE RID: 139502
		public const string PREVIEW_MATCH_SPRITE = "SP_GridFinsh";

		// Token: 0x040220EF RID: 139503
		public const string MATCH_SPRITE = "SP_GridFinsh";

		// Token: 0x040220F0 RID: 139504
		public const int FISHING_CURRENCY_ITEMID = 27;

		// Token: 0x040220F1 RID: 139505
		public const int FISHING_ENTRUST_ITEMID = 28;

		// Token: 0x040220F2 RID: 139506
		public const int FISHING_TECH_SHOW_ITEM_ONE = 38;

		// Token: 0x040220F3 RID: 139507
		public const int FISHING_TECH_SHOW_ITEM_TWO = 37;

		// Token: 0x040220F4 RID: 139508
		public const int FISHING_TECH_SHOW_ITEM_THREE = 29;

		// Token: 0x040220F5 RID: 139509
		public const int FISHING_TECH_SHOW_ITEM_FOUR = 30;

		// Token: 0x040220F6 RID: 139510
		public const int FISHING_TECH_SHOW_ITEM_FIVE = 31;

		// Token: 0x040220F7 RID: 139511
		public const int FISHING_DELEGATE_CURRENCY_ITEMID = 8;

		// Token: 0x040220F8 RID: 139512
		public const int BOMB_ITEMID = 32;

		// Token: 0x040220F9 RID: 139513
		public const int BAIT_ITEMID = 33;

		// Token: 0x040220FA RID: 139514
		public const string SILVER_CUP_ICON = "T_IconCupSilver";

		// Token: 0x040220FB RID: 139515
		public const string GOLD_CUP_ICON = "T_IconCupGold";

		// Token: 0x040220FC RID: 139516
		public const string TIPS_ICON = "T_TipsWorldNavigation";

		// Token: 0x040220FD RID: 139517
		public const int SAILING_TIME_HELP_ID = 185;

		// Token: 0x040220FE RID: 139518
		public const int SAILING_DURABILITY_HELP_ID = 186;

		// Token: 0x040220FF RID: 139519
		public const int SAILING_REPUTATION_HELP_ID = 188;

		// Token: 0x04022100 RID: 139520
		public const int SAILING_QUEST_HELP_ID = 191;

		// Token: 0x04022101 RID: 139521
		public const int SAILING_DAY_TIME = 18000;

		// Token: 0x04022102 RID: 139522
		public const int SAILING_NIGHT_TIME = 68400;

		// Token: 0x04022103 RID: 139523
		public const int FISHING_TECH_FIRST_NODE_AREA = 0;

		// Token: 0x04022104 RID: 139524
		public const int FISHING_TECH_BEHIND_NODE_AREA = 3;

		// Token: 0x04022105 RID: 139525
		public const int FISHING_TECH_LAST_NODE_AREA = 4;

		// Token: 0x04022106 RID: 139526
		public const int PHOEBE_ID = 1506;

		// Token: 0x04022107 RID: 139527
		public const int PLAYER_TECH_TYPE = 4;

		// Token: 0x04022108 RID: 139528
		public const int PHOEBE_TECH_TYPE = 5;

		// Token: 0x04022109 RID: 139529
		public const string FISHING_FEMALE_TEXTURE = "T_NavigationRoleFemale";

		// Token: 0x0402210A RID: 139530
		public const string FISHING_MALE_TEXTURE = "T_NavigationRoleMale";

		// Token: 0x0402210B RID: 139531
		public const string FISHING_PHOEBE_TEXTURE = "T_NavigationRoleFeibi";

		// Token: 0x0402210C RID: 139532
		public const string FISHING_FEMALE_ICON_SPRITE = "SP_RoleFemale";

		// Token: 0x0402210D RID: 139533
		public const string FISHING_MALE_ICON_SPRITE = "SP_RoleMale";

		// Token: 0x0402210E RID: 139534
		public const string FISHING_PHOEBE_ICON_SPRITE = "SP_RoleFeibi";

		// Token: 0x0402210F RID: 139535
		public const int QUEST_ROW_COUNT = 3;

		// Token: 0x04022110 RID: 139536
		public const int QUEST_COL_COUNT = 5;

		// Token: 0x04022111 RID: 139537
		public const int FISHING_POINT_MARK_ID = 9;

		// Token: 0x04022112 RID: 139538
		public const int FISHING_POINT_QUEST_MARK_ID = 20;

		// Token: 0x04022113 RID: 139539
		public const int FISHING_QUICK_SAIL_POOL = 3;

		// Token: 0x04022114 RID: 139540
		public const int FISHING_SIZE_TYPE = 3;

		// Token: 0x04022115 RID: 139541
		public const int CAGE_LIST_HELPID = 193;

		// Token: 0x04022116 RID: 139542
		public const int TRAWL_LIST_HELPID = 194;

		// Token: 0x04022117 RID: 139543
		public const int TRAWL_TECH_TYPE = 12;

		// Token: 0x04022118 RID: 139544
		public const int FISHING_CAGE_TECH = 6;

		// Token: 0x04022119 RID: 139545
		public static readonly FName materialProgressName = new FName("Progress");

		// Token: 0x0402211A RID: 139546
		public const string FISHING_FEMALE_TECH_AUDIO = "play_vo_nvzhu_sys_fishing_techupgrade0";

		// Token: 0x0402211B RID: 139547
		public const string FISHING_MALE_TECH_AUDIO = "play_vo_nanzhu_sys_fishing_techupgrade0";

		// Token: 0x0402211C RID: 139548
		public const string FISHING_PHOEBE_TECH_AUDIO = "play_vo_feibi_sys_fishing_techupgrade0";

		// Token: 0x0402211D RID: 139549
		public const int FISHING_TECH_AUDIO_SIZE = 3;

		// Token: 0x0402211E RID: 139550
		public const string FISHING_TECH_MATERIAL_NOT_ENOUGHT = "<color=#c25757>{0}</color>";

		// Token: 0x0402211F RID: 139551
		public const string FISHING_TECH_MATERIAL_ENOUGHT = "<color=#81764c>{0}</color>";

		// Token: 0x04022120 RID: 139552
		public const string FISHING_TECH_MATERIAL_WHITE_ENOUGHT = "<color=#ffffff>{0}</color>";

		// Token: 0x04022121 RID: 139553
		public const string FISHING_SKILL_BOMB_NOT_ENOUGH = "Fishing_SkillTip1";

		// Token: 0x04022122 RID: 139554
		public const string FISHING_SKILL_IN_CD = "Fishing_SkillTip2";

		// Token: 0x04022123 RID: 139555
		public const string FISHING_SKILL_BAIT_NOT_ENOUGH = "Fishing_SkillTip3";

		// Token: 0x04022124 RID: 139556
		public const string FISHING_SKILL_BAIT_SUCCESS = "Fishing_SkillTip4";

		// Token: 0x04022125 RID: 139557
		public const string FISHING_SKILL_BOMB_SUCCESS = "Fishing_SkillTip5";

		// Token: 0x04022126 RID: 139558
		public const string FISHING_SKILL_BAIT_LIMIT = "Fishing_SkillTip6";

		// Token: 0x04022127 RID: 139559
		public const int FISHING_NORMAL_ENTRUST_POOL = 4;

		// Token: 0x04022128 RID: 139560
		public const int FISHING_HIGHT_VALUE_ENTRUST_POOL = 2;

		// Token: 0x04022129 RID: 139561
		public const string FISHING_GLODEN_TEXTURE = "/Game/Aki/UI/UIResources/UiActivity/Image/Navigation/T_IconCupGold.T_IconCupGold";

		// Token: 0x0402212A RID: 139562
		public const string FISHING_SILVER_TEXTURE = "/Game/Aki/UI/UIResources/UiActivity/Image/Navigation/T_IconCupSilver.T_IconCupSilver";
	}
}

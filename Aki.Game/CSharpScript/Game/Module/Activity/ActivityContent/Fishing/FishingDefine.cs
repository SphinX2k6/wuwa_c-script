using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005583 RID: 21891
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingDefine : IStaticVariableResetter
	{
		// Token: 0x06036413 RID: 222227 RVA: 0x00F20CD1 File Offset: 0x00F1EED1
		static FishingDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FishingDefine.CreateStaticDefaultValue), new Action(FishingDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06036414 RID: 222228 RVA: 0x00F20D00 File Offset: 0x00F1EF00
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

		// Token: 0x06036415 RID: 222229 RVA: 0x00F20FD0 File Offset: 0x00F1F1D0
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

		// Token: 0x0401CA05 RID: 117253
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, string> fishingQualityColor;

		// Token: 0x0401CA06 RID: 117254
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, string> fishingStateText;

		// Token: 0x0401CA07 RID: 117255
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, string> fishingStateColorText;

		// Token: 0x0401CA08 RID: 117256
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, string> fishingSelectStateColorText;

		// Token: 0x0401CA09 RID: 117257
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, string> fishingQuestPoolColorText;

		// Token: 0x0401CA0A RID: 117258
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, string> fishingEntrustTypeText;

		// Token: 0x0401CA0B RID: 117259
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, string> fishingItemTypeText;

		// Token: 0x0401CA0C RID: 117260
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, string> fishingItemTimeText;

		// Token: 0x0401CA0D RID: 117261
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<int, string> fishingNodeTypeText;

		// Token: 0x0401CA0E RID: 117262
		[Nullable(2)]
		public static List<int> fishingItemList;

		// Token: 0x0401CA0F RID: 117263
		[Nullable(2)]
		public static List<int> fishingEffectList;

		// Token: 0x0401CA10 RID: 117264
		public const int UNVALID_ITEM_BLOCK_ID = -1;

		// Token: 0x0401CA11 RID: 117265
		public const int BACKPACK_ROW_COUNT = 7;

		// Token: 0x0401CA12 RID: 117266
		public const int BACKPACK_COL_COUNT = 8;

		// Token: 0x0401CA13 RID: 117267
		public const int INTERACT_ROW_COUNT = 3;

		// Token: 0x0401CA14 RID: 117268
		public const int INTERACT_COL_COUNT = 6;

		// Token: 0x0401CA15 RID: 117269
		public const string EMPTY_SPRITE = "SP_GridEmpty";

		// Token: 0x0401CA16 RID: 117270
		public const string DISABLE_SPRITE = "SP_GridSellDisable";

		// Token: 0x0401CA17 RID: 117271
		public const string PREVIEW_SPRITE = "SP_GridFinsh";

		// Token: 0x0401CA18 RID: 117272
		public const string SINGLE_OCCUPANCY_SPRITE = "SP_GridReplace";

		// Token: 0x0401CA19 RID: 117273
		public const string MULTI_OCCUPANCY_SPRITE = "SP_GridError";

		// Token: 0x0401CA1A RID: 117274
		public const string PROHIBIT_SPRITE = "SP_GridError";

		// Token: 0x0401CA1B RID: 117275
		public const string FINISH_SPRITE = "SP_GridQuality";

		// Token: 0x0401CA1C RID: 117276
		public const string OUTLINE_SPRITE = "SP_GridFinsh";

		// Token: 0x0401CA1D RID: 117277
		public const string PREVIEW_ERROR_SPRITE = "SP_GridError";

		// Token: 0x0401CA1E RID: 117278
		public const string PREVIEW_OCCUPANCY_SPRITE = "SP_GridReplace";

		// Token: 0x0401CA1F RID: 117279
		public const string PREVIEW_MATCH_SPRITE = "SP_GridFinsh";

		// Token: 0x0401CA20 RID: 117280
		public const string MATCH_SPRITE = "SP_GridFinsh";

		// Token: 0x0401CA21 RID: 117281
		public const int FISHING_CURRENCY_ITEMID = 27;

		// Token: 0x0401CA22 RID: 117282
		public const int FISHING_ENTRUST_ITEMID = 28;

		// Token: 0x0401CA23 RID: 117283
		public const int FISHING_TECH_SHOW_ITEM_ONE = 38;

		// Token: 0x0401CA24 RID: 117284
		public const int FISHING_TECH_SHOW_ITEM_TWO = 37;

		// Token: 0x0401CA25 RID: 117285
		public const int FISHING_TECH_SHOW_ITEM_THREE = 29;

		// Token: 0x0401CA26 RID: 117286
		public const int FISHING_TECH_SHOW_ITEM_FOUR = 30;

		// Token: 0x0401CA27 RID: 117287
		public const int FISHING_TECH_SHOW_ITEM_FIVE = 31;

		// Token: 0x0401CA28 RID: 117288
		public const int FISHING_DELEGATE_CURRENCY_ITEMID = 8;

		// Token: 0x0401CA29 RID: 117289
		public const int BOMB_ITEMID = 32;

		// Token: 0x0401CA2A RID: 117290
		public const int BAIT_ITEMID = 33;

		// Token: 0x0401CA2B RID: 117291
		public const string SILVER_CUP_ICON = "T_IconCupSilver";

		// Token: 0x0401CA2C RID: 117292
		public const string GOLD_CUP_ICON = "T_IconCupGold";

		// Token: 0x0401CA2D RID: 117293
		public const string TIPS_ICON = "T_TipsWorldNavigation";

		// Token: 0x0401CA2E RID: 117294
		public const int SAILING_TIME_HELP_ID = 185;

		// Token: 0x0401CA2F RID: 117295
		public const int SAILING_DURABILITY_HELP_ID = 186;

		// Token: 0x0401CA30 RID: 117296
		public const int SAILING_REPUTATION_HELP_ID = 188;

		// Token: 0x0401CA31 RID: 117297
		public const int SAILING_QUEST_HELP_ID = 191;

		// Token: 0x0401CA32 RID: 117298
		public const int SAILING_DAY_TIME = 18000;

		// Token: 0x0401CA33 RID: 117299
		public const int SAILING_NIGHT_TIME = 68400;

		// Token: 0x0401CA34 RID: 117300
		public const int FISHING_TECH_FIRST_NODE_AREA = 0;

		// Token: 0x0401CA35 RID: 117301
		public const int FISHING_TECH_BEHIND_NODE_AREA = 3;

		// Token: 0x0401CA36 RID: 117302
		public const int FISHING_TECH_LAST_NODE_AREA = 4;

		// Token: 0x0401CA37 RID: 117303
		public const int PHOEBE_ID = 1506;

		// Token: 0x0401CA38 RID: 117304
		public const int PLAYER_TECH_TYPE = 4;

		// Token: 0x0401CA39 RID: 117305
		public const int PHOEBE_TECH_TYPE = 5;

		// Token: 0x0401CA3A RID: 117306
		public const string FISHING_FEMALE_TEXTURE = "T_NavigationRoleFemale";

		// Token: 0x0401CA3B RID: 117307
		public const string FISHING_MALE_TEXTURE = "T_NavigationRoleMale";

		// Token: 0x0401CA3C RID: 117308
		public const string FISHING_PHOEBE_TEXTURE = "T_NavigationRoleFeibi";

		// Token: 0x0401CA3D RID: 117309
		public const string FISHING_FEMALE_ICON_SPRITE = "SP_RoleFemale";

		// Token: 0x0401CA3E RID: 117310
		public const string FISHING_MALE_ICON_SPRITE = "SP_RoleMale";

		// Token: 0x0401CA3F RID: 117311
		public const string FISHING_PHOEBE_ICON_SPRITE = "SP_RoleFeibi";

		// Token: 0x0401CA40 RID: 117312
		public const int QUEST_ROW_COUNT = 3;

		// Token: 0x0401CA41 RID: 117313
		public const int QUEST_COL_COUNT = 5;

		// Token: 0x0401CA42 RID: 117314
		public const int FISHING_POINT_MARK_ID = 9;

		// Token: 0x0401CA43 RID: 117315
		public const int FISHING_POINT_QUEST_MARK_ID = 20;

		// Token: 0x0401CA44 RID: 117316
		public const int FISHING_QUICK_SAIL_POOL = 3;

		// Token: 0x0401CA45 RID: 117317
		public const int FISHING_SIZE_TYPE = 3;

		// Token: 0x0401CA46 RID: 117318
		public const int CAGE_LIST_HELPID = 193;

		// Token: 0x0401CA47 RID: 117319
		public const int TRAWL_LIST_HELPID = 194;

		// Token: 0x0401CA48 RID: 117320
		public const int TRAWL_TECH_TYPE = 12;

		// Token: 0x0401CA49 RID: 117321
		public const int FISHING_CAGE_TECH = 6;

		// Token: 0x0401CA4A RID: 117322
		public static readonly FName materialProgressName = new FName("Progress");

		// Token: 0x0401CA4B RID: 117323
		public const string FISHING_FEMALE_TECH_AUDIO = "play_vo_nvzhu_sys_fishing_techupgrade0";

		// Token: 0x0401CA4C RID: 117324
		public const string FISHING_MALE_TECH_AUDIO = "play_vo_nanzhu_sys_fishing_techupgrade0";

		// Token: 0x0401CA4D RID: 117325
		public const string FISHING_PHOEBE_TECH_AUDIO = "play_vo_feibi_sys_fishing_techupgrade0";

		// Token: 0x0401CA4E RID: 117326
		public const int FISHING_TECH_AUDIO_SIZE = 3;

		// Token: 0x0401CA4F RID: 117327
		public const string FISHING_TECH_MATERIAL_NOT_ENOUGHT = "<color=#c25757>{0}</color>";

		// Token: 0x0401CA50 RID: 117328
		public const string FISHING_TECH_MATERIAL_ENOUGHT = "<color=#81764c>{0}</color>";

		// Token: 0x0401CA51 RID: 117329
		public const string FISHING_TECH_MATERIAL_WHITE_ENOUGHT = "<color=#ffffff>{0}</color>";

		// Token: 0x0401CA52 RID: 117330
		public const string FISHING_SKILL_BOMB_NOT_ENOUGH = "Fishing_SkillTip1";

		// Token: 0x0401CA53 RID: 117331
		public const string FISHING_SKILL_IN_CD = "Fishing_SkillTip2";

		// Token: 0x0401CA54 RID: 117332
		public const string FISHING_SKILL_BAIT_NOT_ENOUGH = "Fishing_SkillTip3";

		// Token: 0x0401CA55 RID: 117333
		public const string FISHING_SKILL_BAIT_SUCCESS = "Fishing_SkillTip4";

		// Token: 0x0401CA56 RID: 117334
		public const string FISHING_SKILL_BOMB_SUCCESS = "Fishing_SkillTip5";

		// Token: 0x0401CA57 RID: 117335
		public const string FISHING_SKILL_BAIT_LIMIT = "Fishing_SkillTip6";

		// Token: 0x0401CA58 RID: 117336
		public const int FISHING_NORMAL_ENTRUST_POOL = 4;

		// Token: 0x0401CA59 RID: 117337
		public const int FISHING_HIGHT_VALUE_ENTRUST_POOL = 2;

		// Token: 0x0401CA5A RID: 117338
		public const string FISHING_GLODEN_TEXTURE = "/Game/Aki/UI/UIResources/UiActivity/Image/Navigation/T_IconCupGold.T_IconCupGold";

		// Token: 0x0401CA5B RID: 117339
		public const string FISHING_SILVER_TEXTURE = "/Game/Aki/UI/UIResources/UiActivity/Image/Navigation/T_IconCupSilver.T_IconCupSilver";
	}
}

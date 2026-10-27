using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DA1 RID: 19873
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeDefine : IStaticVariableResetter
	{
		// Token: 0x06033517 RID: 210199 RVA: 0x00BFA131 File Offset: 0x00BF8331
		static RoguelikeDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoguelikeDefine.CreateStaticDefaultValue), new Action(RoguelikeDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06033518 RID: 210200 RVA: 0x00BFA150 File Offset: 0x00BF8350
		public static void CreateStaticDefaultValue()
		{
			RoguelikeDefine.sortElementArray = new EElementType[]
			{
				EElementType.Element1,
				EElementType.Element2,
				EElementType.Element3,
				EElementType.Element4
			};
		}

		// Token: 0x06033519 RID: 210201 RVA: 0x00BFA168 File Offset: 0x00BF8368
		public static void ResetStaticDefaultValue()
		{
			RoguelikeDefine.sortElementArray = null;
		}

		// Token: 0x0401B418 RID: 111640
		[Nullable(2)]
		public static EElementType[] sortElementArray;

		// Token: 0x0401B419 RID: 111641
		public const int ROGUELIKE_FORMATION_COUNT = 3;

		// Token: 0x0401B41A RID: 111642
		public const int ROGUELIKE_FORMATION_MAIN_INDEX = 0;

		// Token: 0x0401B41B RID: 111643
		public const int OUTSIDE_CURRENCY_ID = 80100001;

		// Token: 0x0401B41C RID: 111644
		public const int INSIDE_CURRENCY_ID = 80100000;

		// Token: 0x0401B41D RID: 111645
		public const int COLLECT_SCORE_ID = 80100002;

		// Token: 0x0401B41E RID: 111646
		public const int SKILL_POINT_ID = 80100003;

		// Token: 0x0401B41F RID: 111647
		public const int ROGUE_DETECTION_TAB_ID = 18;

		// Token: 0x0401B420 RID: 111648
		public const int ROGUELIKE_HELP_ID = 76;

		// Token: 0x0401B421 RID: 111649
		public const int DEFAULT_ROGUELIKE_ENTRY_RATE = 10000;

		// Token: 0x0401B422 RID: 111650
		public const string PHANTOM_SELECT_ITEM = "UiItem_PhantomSelectItem_Prefab";

		// Token: 0x0401B423 RID: 111651
		public const string ROLE_SELECT_ITEM = "UiItem_RoleSelectItem_Prefab";

		// Token: 0x0401B424 RID: 111652
		public const string COMMON_SELECT_ITEM = "UiItem_CommonSelectItem_Prefab";

		// Token: 0x0401B425 RID: 111653
		public const string ROGUELIKEVIEW_1_TEXT = "RoguelikeView_1_Text";

		// Token: 0x0401B426 RID: 111654
		public const string ROGUELIKEVIEW_2_TEXT = "RoguelikeView_2_Text";

		// Token: 0x0401B427 RID: 111655
		public const string ROGUELIKEVIEW_3_TEXT = "RoguelikeView_3_Text";

		// Token: 0x0401B428 RID: 111656
		public const string ROGUELIKEVIEW_4_TEXT = "RoguelikeView_4_Text";

		// Token: 0x0401B429 RID: 111657
		public const string ROGUELIKEVIEW_5_TEXT = "RoguelikeView_5_Text";

		// Token: 0x0401B42A RID: 111658
		public const string ROGUELIKEVIEW_6_TEXT = "RoguelikeView_6_Text";

		// Token: 0x0401B42B RID: 111659
		public const string ROGUELIKEVIEW_7_TEXT = "RoguelikeView_7_Text";

		// Token: 0x0401B42C RID: 111660
		public const string ROGUELIKEVIEW_8_TEXT = "RoguelikeView_8_Text";

		// Token: 0x0401B42D RID: 111661
		public const string ROGUELIKEVIEW_9_TEXT = "RoguelikeView_9_Text";

		// Token: 0x0401B42E RID: 111662
		public const string ROGUELIKEVIEW_10_TEXT = "RoguelikeView_10_Text";

		// Token: 0x0401B42F RID: 111663
		public const string ROGUELIKEVIEW_11_TEXT = "RoguelikeView_11_Text";

		// Token: 0x0401B430 RID: 111664
		public const string ROGUELIKEVIEW_12_TEXT = "RoguelikeView_12_Text";

		// Token: 0x0401B431 RID: 111665
		public const string ROGUELIKEVIEW_13_TEXT = "RoguelikeView_13_Text";

		// Token: 0x0401B432 RID: 111666
		public const string ROGUELIKEVIEW_14_TEXT = "RoguelikeView_14_Text";

		// Token: 0x0401B433 RID: 111667
		public const string ROGUELIKEVIEW_15_TEXT = "RoguelikeView_15_Text";

		// Token: 0x0401B434 RID: 111668
		public const string ROGUELIKEVIEW_16_TEXT = "RoguelikeView_16_Text";

		// Token: 0x0401B435 RID: 111669
		public const string ROGUELIKEVIEW_17_TEXT = "RoguelikeView_17_Text";

		// Token: 0x0401B436 RID: 111670
		public const string ROGUELIKEVIEW_18_TEXT = "RoguelikeView_18_Text";

		// Token: 0x0401B437 RID: 111671
		public const string ROGUELIKEVIEW_19_TEXT = "RoguelikeView_19_Text";

		// Token: 0x0401B438 RID: 111672
		public const string ROGUELIKEVIEW_20_TEXT = "RoguelikeView_20_Text";

		// Token: 0x0401B439 RID: 111673
		public const string ROGUELIKEVIEW_21_TEXT = "RoguelikeView_21_Text";

		// Token: 0x0401B43A RID: 111674
		public const string ROGUELIKEVIEW_22_TEXT = "RoguelikeView_22_Text";

		// Token: 0x0401B43B RID: 111675
		public const string ROGUELIKEVIEW_23_TEXT = "RoguelikeView_23_Text";

		// Token: 0x0401B43C RID: 111676
		public const string ROGUELIKEVIEW_24_TEXT = "RoguelikeView_24_Text";

		// Token: 0x0401B43D RID: 111677
		public const string ROGUELIKEVIEW_25_TEXT = "RoguelikeView_25_Text";

		// Token: 0x0401B43E RID: 111678
		public const string COMPLETE = "Complete";

		// Token: 0x0401B43F RID: 111679
		public const string ROGUELIKEVIEW_NOTFINIST_TEXT = "RoguelikeView_NotFinish_Text";

		// Token: 0x0401B440 RID: 111680
		public const string ROGUELIKEVIEW_PREVIEW_TEXT = "RoguelikeView_Preview_Text";

		// Token: 0x0401B441 RID: 111681
		public const string ROGUELIKEVIEW_FINIST_TEXT = "RoguelikeView_Finish_Text";

		// Token: 0x0401B442 RID: 111682
		public const string T_ROGUELIKETOTALELEMENT = "T_RoguelikeTotalElement";

		// Token: 0x0401B443 RID: 111683
		public const float ROGUELIKE_SPECIAL_ITEM_UNLOCK_ALPHA = 1f;

		// Token: 0x0401B444 RID: 111684
		public const float ROGUELIKE_SPECIAL_ITEM_LOCK_ALPHA = 0.6f;
	}
}

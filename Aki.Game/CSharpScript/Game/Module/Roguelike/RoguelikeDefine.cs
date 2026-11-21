using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D6A RID: 15722
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeDefine : IStaticVariableResetter
	{
		// Token: 0x06028384 RID: 164740 RVA: 0x00B4372D File Offset: 0x00B4192D
		static RoguelikeDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoguelikeDefine.CreateStaticDefaultValue), new Action(RoguelikeDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06028385 RID: 164741 RVA: 0x00B4374C File Offset: 0x00B4194C
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

		// Token: 0x06028386 RID: 164742 RVA: 0x00B43764 File Offset: 0x00B41964
		public static void ResetStaticDefaultValue()
		{
			RoguelikeDefine.sortElementArray = null;
		}

		// Token: 0x04015DEB RID: 89579
		[Nullable(2)]
		public static EElementType[] sortElementArray;

		// Token: 0x04015DEC RID: 89580
		public const int ROGUELIKE_FORMATION_COUNT = 3;

		// Token: 0x04015DED RID: 89581
		public const int ROGUELIKE_FORMATION_MAIN_INDEX = 0;

		// Token: 0x04015DEE RID: 89582
		public const int OUTSIDE_CURRENCY_ID = 80100001;

		// Token: 0x04015DEF RID: 89583
		public const int INSIDE_CURRENCY_ID = 80100000;

		// Token: 0x04015DF0 RID: 89584
		public const int COLLECT_SCORE_ID = 80100002;

		// Token: 0x04015DF1 RID: 89585
		public const int SKILL_POINT_ID = 80100003;

		// Token: 0x04015DF2 RID: 89586
		public const int ROGUE_DETECTION_TAB_ID = 18;

		// Token: 0x04015DF3 RID: 89587
		public const int ROGUELIKE_HELP_ID = 76;

		// Token: 0x04015DF4 RID: 89588
		public const int DEFAULT_ROGUELIKE_ENTRY_RATE = 10000;

		// Token: 0x04015DF5 RID: 89589
		public const string PHANTOM_SELECT_ITEM = "UiItem_PhantomSelectItem_Prefab";

		// Token: 0x04015DF6 RID: 89590
		public const string ROLE_SELECT_ITEM = "UiItem_RoleSelectItem_Prefab";

		// Token: 0x04015DF7 RID: 89591
		public const string COMMON_SELECT_ITEM = "UiItem_CommonSelectItem_Prefab";

		// Token: 0x04015DF8 RID: 89592
		public const string ROGUELIKEVIEW_1_TEXT = "RoguelikeView_1_Text";

		// Token: 0x04015DF9 RID: 89593
		public const string ROGUELIKEVIEW_2_TEXT = "RoguelikeView_2_Text";

		// Token: 0x04015DFA RID: 89594
		public const string ROGUELIKEVIEW_3_TEXT = "RoguelikeView_3_Text";

		// Token: 0x04015DFB RID: 89595
		public const string ROGUELIKEVIEW_4_TEXT = "RoguelikeView_4_Text";

		// Token: 0x04015DFC RID: 89596
		public const string ROGUELIKEVIEW_5_TEXT = "RoguelikeView_5_Text";

		// Token: 0x04015DFD RID: 89597
		public const string ROGUELIKEVIEW_6_TEXT = "RoguelikeView_6_Text";

		// Token: 0x04015DFE RID: 89598
		public const string ROGUELIKEVIEW_7_TEXT = "RoguelikeView_7_Text";

		// Token: 0x04015DFF RID: 89599
		public const string ROGUELIKEVIEW_8_TEXT = "RoguelikeView_8_Text";

		// Token: 0x04015E00 RID: 89600
		public const string ROGUELIKEVIEW_9_TEXT = "RoguelikeView_9_Text";

		// Token: 0x04015E01 RID: 89601
		public const string ROGUELIKEVIEW_10_TEXT = "RoguelikeView_10_Text";

		// Token: 0x04015E02 RID: 89602
		public const string ROGUELIKEVIEW_11_TEXT = "RoguelikeView_11_Text";

		// Token: 0x04015E03 RID: 89603
		public const string ROGUELIKEVIEW_12_TEXT = "RoguelikeView_12_Text";

		// Token: 0x04015E04 RID: 89604
		public const string ROGUELIKEVIEW_13_TEXT = "RoguelikeView_13_Text";

		// Token: 0x04015E05 RID: 89605
		public const string ROGUELIKEVIEW_14_TEXT = "RoguelikeView_14_Text";

		// Token: 0x04015E06 RID: 89606
		public const string ROGUELIKEVIEW_15_TEXT = "RoguelikeView_15_Text";

		// Token: 0x04015E07 RID: 89607
		public const string ROGUELIKEVIEW_16_TEXT = "RoguelikeView_16_Text";

		// Token: 0x04015E08 RID: 89608
		public const string ROGUELIKEVIEW_17_TEXT = "RoguelikeView_17_Text";

		// Token: 0x04015E09 RID: 89609
		public const string ROGUELIKEVIEW_18_TEXT = "RoguelikeView_18_Text";

		// Token: 0x04015E0A RID: 89610
		public const string ROGUELIKEVIEW_19_TEXT = "RoguelikeView_19_Text";

		// Token: 0x04015E0B RID: 89611
		public const string ROGUELIKEVIEW_20_TEXT = "RoguelikeView_20_Text";

		// Token: 0x04015E0C RID: 89612
		public const string ROGUELIKEVIEW_21_TEXT = "RoguelikeView_21_Text";

		// Token: 0x04015E0D RID: 89613
		public const string ROGUELIKEVIEW_22_TEXT = "RoguelikeView_22_Text";

		// Token: 0x04015E0E RID: 89614
		public const string ROGUELIKEVIEW_23_TEXT = "RoguelikeView_23_Text";

		// Token: 0x04015E0F RID: 89615
		public const string ROGUELIKEVIEW_24_TEXT = "RoguelikeView_24_Text";

		// Token: 0x04015E10 RID: 89616
		public const string ROGUELIKEVIEW_25_TEXT = "RoguelikeView_25_Text";

		// Token: 0x04015E11 RID: 89617
		public const string COMPLETE = "Complete";

		// Token: 0x04015E12 RID: 89618
		public const string ROGUELIKEVIEW_NOTFINIST_TEXT = "RoguelikeView_NotFinish_Text";

		// Token: 0x04015E13 RID: 89619
		public const string ROGUELIKEVIEW_PREVIEW_TEXT = "RoguelikeView_Preview_Text";

		// Token: 0x04015E14 RID: 89620
		public const string ROGUELIKEVIEW_FINIST_TEXT = "RoguelikeView_Finish_Text";

		// Token: 0x04015E15 RID: 89621
		public const string T_ROGUELIKETOTALELEMENT = "T_RoguelikeTotalElement";

		// Token: 0x04015E16 RID: 89622
		public const float ROGUELIKE_SPECIAL_ITEM_UNLOCK_ALPHA = 1f;

		// Token: 0x04015E17 RID: 89623
		public const float ROGUELIKE_SPECIAL_ITEM_LOCK_ALPHA = 0.6f;
	}
}

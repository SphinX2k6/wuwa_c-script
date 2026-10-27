using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001737 RID: 5943
[NullableContext(1)]
[Nullable(0)]
public class CalabashDefine : IStaticVariableResetter
{
	// Token: 0x0600ABB0 RID: 43952 RVA: 0x00267ECA File Offset: 0x002660CA
	static CalabashDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CalabashDefine.CreateStaticDefaultValue), new Action(CalabashDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600ABB1 RID: 43953 RVA: 0x00267EEC File Offset: 0x002660EC
	public static void CreateStaticDefaultValue()
	{
		CalabashDefine.visionRecoveryTabViewTypeName = new Dictionary<EVisionRecoveryTabViewType, string>
		{
			{
				EVisionRecoveryTabViewType.NormalFusion,
				"PhantomRecycle_RandomModel"
			},
			{
				EVisionRecoveryTabViewType.DirectionalFusion,
				"PhantomRecycle_AimModel"
			}
		};
		CalabashDefine.visionRefineCostMap = new Dictionary<EVisionRefineCostType, string>
		{
			{
				EVisionRefineCostType.Cost4,
				"Cost4"
			},
			{
				EVisionRefineCostType.Cost3,
				"Cost3"
			},
			{
				EVisionRefineCostType.Cost1,
				"Cost1"
			}
		};
		CalabashDefine.visionRefineRefineMap = new Dictionary<EVisionRefineRefineType, string>
		{
			{
				EVisionRefineRefineType.Main,
				"PrefabTextItem_PhantomMainAttribute_Text"
			},
			{
				EVisionRefineRefineType.Sub,
				"PrefabTextItem_PhantomSubAttribute_Text"
			}
		};
	}

	// Token: 0x0600ABB2 RID: 43954 RVA: 0x00267F6B File Offset: 0x0026616B
	public static void ResetStaticDefaultValue()
	{
		CalabashDefine.visionRecoveryTabViewTypeName = null;
		CalabashDefine.visionRefineCostMap = null;
		CalabashDefine.visionRefineRefineMap = null;
	}

	// Token: 0x04004DCE RID: 19918
	public const int VISION_RECOVERY_SLOT_MAX_NUM = 5;

	// Token: 0x04004DCF RID: 19919
	public const int VISION_RECOVERY_SORT_GROUP_ID = 31;

	// Token: 0x04004DD0 RID: 19920
	public const int VISION_RECOVERT_FILTER_UNDEPERCATE = 0;

	// Token: 0x04004DD1 RID: 19921
	public const int VISION_RECOVERT_FILTER_DEPERCATE = 1;

	// Token: 0x04004DD2 RID: 19922
	public const int VISION_RECOVERT_FILTER_LOCK = 2;

	// Token: 0x04004DD3 RID: 19923
	public const int VISION_REFINE_FILTER_QUALITY = 5;

	// Token: 0x04004DD4 RID: 19924
	public const int VISION_REFINE_MAIN_SLOT_MAX_NUM = 10;

	// Token: 0x04004DD5 RID: 19925
	public const int CALABASH_SPECIALUI_LEVEL = 26;

	// Token: 0x04004DD6 RID: 19926
	public const int VISION_GOLD_QUALITY = 5;

	// Token: 0x04004DD7 RID: 19927
	public const string VISION_REFINE_TAB_COST1_TEXT_ID = "Cost1";

	// Token: 0x04004DD8 RID: 19928
	public const string VISION_REFINE_TAB_COST3_TEXT_ID = "Cost3";

	// Token: 0x04004DD9 RID: 19929
	public const string VISION_REFINE_TAB_COST4_TEXT_ID = "Cost4";

	// Token: 0x04004DDA RID: 19930
	public const string VISION_REFINE_TAB_MAIN_TEXT_ID = "PrefabTextItem_PhantomMainAttribute_Text";

	// Token: 0x04004DDB RID: 19931
	public const string VISION_REFINE_TAB_SUB_TEXT_ID = "PrefabTextItem_PhantomSubAttribute_Text";

	// Token: 0x04004DDC RID: 19932
	public const string VISION_REFINE_SELECTED_TEXT_ID = "Text_ItemRecycleChosenTotal_text";

	// Token: 0x04004DDD RID: 19933
	public const string VISION_REFINE_UNSELECTED_TEXT_ID = "ErrorCode_200347_Text";

	// Token: 0x04004DDE RID: 19934
	public const string VISION_REFINE_DIRECT_VALUE_TEXT_ID = "RogueInfoViewShopPrice";

	// Token: 0x04004DDF RID: 19935
	public const string VISION_REFINE_PERCENTAGE_TEXT_ID = "Text_ExplorationDegree_Text";

	// Token: 0x04004DE0 RID: 19936
	public const string VISION_REFINE_NON_UPGRADE_TEXT_ID = "Text_VisionRefineSubAttriLocked_Text";

	// Token: 0x04004DE1 RID: 19937
	public const string VISION_REFINE_CAN_REFINE_WITH_NUMBER_TEXT_ID = "Text_VisionRefine_CanRefineWithNumber_Text";

	// Token: 0x04004DE2 RID: 19938
	public const string VISION_REFINE_MAIN_INVALID_REASON_TEXT_ID = "Text_VisionRefineMain_InvalidReason_Text";

	// Token: 0x04004DE3 RID: 19939
	public const string VISION_REFINE_SUB_INVALID_REASON_TEXT_ID = "Text_VisionRefineSub_InvalidReason_Text";

	// Token: 0x04004DE4 RID: 19940
	public const string VISION_REFINE_ATTRIBUTE_PANEL_TITLE_TEXT_ID = "Text_VisionRefineAttributePanelTitle_Text";

	// Token: 0x04004DE5 RID: 19941
	public const string VISION_REFINE_NO_NEED_CONFIRM_BOX_TEXT_ID = "Text_PlotSkipConfirmToggle_Text";

	// Token: 0x04004DE6 RID: 19942
	public const string VISION_REFINE_SUB_ONLY_FULL_LEVEL_TIP_TEXT_ID = "Text_VisionRefineSub_InvalidTips_Text";

	// Token: 0x04004DE7 RID: 19943
	public const string VISION_REFINE_ONLY_FIVE_STAR_TIP_TEXT_ID = "VisionRefineChooseCheck";

	// Token: 0x04004DE8 RID: 19944
	public const string VISION_REFINE_CHOOSE_LIST_IS_FULL_TIP_TEXT_ID = "Text_VisionRefineChooseListFull_Text";

	// Token: 0x04004DE9 RID: 19945
	public const string VISION_REFINE_SUB_LOCK_ALL_TIP_TEXT_ID = "Text_VisionRefineSubLockAll_Text";

	// Token: 0x04004DEA RID: 19946
	public const string VISION_REFINE_CHOSEN_LACK_TIP_TEXT_ID = "PrefabTextItem_PhantomRefineLackTip_Text";

	// Token: 0x04004DEB RID: 19947
	public const string VISION_REFINE_MATERIAL_LACK_TIP_TEXT_ID = "PrefabTextItem_PhantomRefineMaterialLackTip_Text";

	// Token: 0x04004DEC RID: 19948
	public const string VISION_REFINE_FUNCTION_NOT_OPEN_TIP_TEXT_ID = "Text_UnlockNotice_Text";

	// Token: 0x04004DED RID: 19949
	public const string VISION_REFINE_MAIN_NOT_CHOOSE_ATTRIBUTE_TIP_TEXT_ID = "PrefabTextItem_PhantomRefineAttributeLackTip_Text";

	// Token: 0x04004DEE RID: 19950
	public const string VISION_REFINE_MAIN_NON_VALID_TIP_TEXT_ID = "Text_VisionRefineMain_BlockedTips_Text";

	// Token: 0x04004DEF RID: 19951
	public const string HAVE_AVAILABLE_ATTR_TEXT_ID = "Text_Refresh_HaveAvailableAttr";

	// Token: 0x04004DF0 RID: 19952
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Dictionary<EVisionRecoveryTabViewType, string> visionRecoveryTabViewTypeName;

	// Token: 0x04004DF1 RID: 19953
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Dictionary<EVisionRefineCostType, string> visionRefineCostMap;

	// Token: 0x04004DF2 RID: 19954
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Dictionary<EVisionRefineRefineType, string> visionRefineRefineMap;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000BF0 RID: 3056
[NullableContext(1)]
[Nullable(0)]
public class CalabashDefine : IStaticVariableResetter
{
	// Token: 0x06007F97 RID: 32663 RVA: 0x002722CA File Offset: 0x002704CA
	static CalabashDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CalabashDefine.CreateStaticDefaultValue), new Action(CalabashDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06007F98 RID: 32664 RVA: 0x002722EC File Offset: 0x002704EC
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

	// Token: 0x06007F99 RID: 32665 RVA: 0x0027236B File Offset: 0x0027056B
	public static void ResetStaticDefaultValue()
	{
		CalabashDefine.visionRecoveryTabViewTypeName = null;
		CalabashDefine.visionRefineCostMap = null;
		CalabashDefine.visionRefineRefineMap = null;
	}

	// Token: 0x04004E77 RID: 20087
	public const int VISION_RECOVERY_SLOT_MAX_NUM = 5;

	// Token: 0x04004E78 RID: 20088
	public const int VISION_RECOVERY_SORT_GROUP_ID = 31;

	// Token: 0x04004E79 RID: 20089
	public const int VISION_RECOVERT_FILTER_UNDEPERCATE = 0;

	// Token: 0x04004E7A RID: 20090
	public const int VISION_RECOVERT_FILTER_DEPERCATE = 1;

	// Token: 0x04004E7B RID: 20091
	public const int VISION_RECOVERT_FILTER_LOCK = 2;

	// Token: 0x04004E7C RID: 20092
	public const int VISION_REFINE_FILTER_QUALITY = 5;

	// Token: 0x04004E7D RID: 20093
	public const int VISION_REFINE_MAIN_SLOT_MAX_NUM = 10;

	// Token: 0x04004E7E RID: 20094
	public const int CALABASH_SPECIALUI_LEVEL = 26;

	// Token: 0x04004E7F RID: 20095
	public const int VISION_GOLD_QUALITY = 5;

	// Token: 0x04004E80 RID: 20096
	public const string VISION_REFINE_TAB_COST1_TEXT_ID = "Cost1";

	// Token: 0x04004E81 RID: 20097
	public const string VISION_REFINE_TAB_COST3_TEXT_ID = "Cost3";

	// Token: 0x04004E82 RID: 20098
	public const string VISION_REFINE_TAB_COST4_TEXT_ID = "Cost4";

	// Token: 0x04004E83 RID: 20099
	public const string VISION_REFINE_TAB_MAIN_TEXT_ID = "PrefabTextItem_PhantomMainAttribute_Text";

	// Token: 0x04004E84 RID: 20100
	public const string VISION_REFINE_TAB_SUB_TEXT_ID = "PrefabTextItem_PhantomSubAttribute_Text";

	// Token: 0x04004E85 RID: 20101
	public const string VISION_REFINE_SELECTED_TEXT_ID = "Text_ItemRecycleChosenTotal_text";

	// Token: 0x04004E86 RID: 20102
	public const string VISION_REFINE_UNSELECTED_TEXT_ID = "ErrorCode_200347_Text";

	// Token: 0x04004E87 RID: 20103
	public const string VISION_REFINE_DIRECT_VALUE_TEXT_ID = "RogueInfoViewShopPrice";

	// Token: 0x04004E88 RID: 20104
	public const string VISION_REFINE_PERCENTAGE_TEXT_ID = "Text_ExplorationDegree_Text";

	// Token: 0x04004E89 RID: 20105
	public const string VISION_REFINE_NON_UPGRADE_TEXT_ID = "Text_VisionRefineSubAttriLocked_Text";

	// Token: 0x04004E8A RID: 20106
	public const string VISION_REFINE_CAN_REFINE_WITH_NUMBER_TEXT_ID = "Text_VisionRefine_CanRefineWithNumber_Text";

	// Token: 0x04004E8B RID: 20107
	public const string VISION_REFINE_MAIN_INVALID_REASON_TEXT_ID = "Text_VisionRefineMain_InvalidReason_Text";

	// Token: 0x04004E8C RID: 20108
	public const string VISION_REFINE_SUB_INVALID_REASON_TEXT_ID = "Text_VisionRefineSub_InvalidReason_Text";

	// Token: 0x04004E8D RID: 20109
	public const string VISION_REFINE_ATTRIBUTE_PANEL_TITLE_TEXT_ID = "Text_VisionRefineAttributePanelTitle_Text";

	// Token: 0x04004E8E RID: 20110
	public const string VISION_REFINE_NO_NEED_CONFIRM_BOX_TEXT_ID = "Text_PlotSkipConfirmToggle_Text";

	// Token: 0x04004E8F RID: 20111
	public const string VISION_REFINE_SUB_ONLY_FULL_LEVEL_TIP_TEXT_ID = "Text_VisionRefineSub_InvalidTips_Text";

	// Token: 0x04004E90 RID: 20112
	public const string VISION_REFINE_ONLY_FIVE_STAR_TIP_TEXT_ID = "VisionRefineChooseCheck";

	// Token: 0x04004E91 RID: 20113
	public const string VISION_REFINE_CHOOSE_LIST_IS_FULL_TIP_TEXT_ID = "Text_VisionRefineChooseListFull_Text";

	// Token: 0x04004E92 RID: 20114
	public const string VISION_REFINE_SUB_LOCK_ALL_TIP_TEXT_ID = "Text_VisionRefineSubLockAll_Text";

	// Token: 0x04004E93 RID: 20115
	public const string VISION_REFINE_CHOSEN_LACK_TIP_TEXT_ID = "PrefabTextItem_PhantomRefineLackTip_Text";

	// Token: 0x04004E94 RID: 20116
	public const string VISION_REFINE_MATERIAL_LACK_TIP_TEXT_ID = "PrefabTextItem_PhantomRefineMaterialLackTip_Text";

	// Token: 0x04004E95 RID: 20117
	public const string VISION_REFINE_FUNCTION_NOT_OPEN_TIP_TEXT_ID = "Text_UnlockNotice_Text";

	// Token: 0x04004E96 RID: 20118
	public const string VISION_REFINE_MAIN_NOT_CHOOSE_ATTRIBUTE_TIP_TEXT_ID = "PrefabTextItem_PhantomRefineAttributeLackTip_Text";

	// Token: 0x04004E97 RID: 20119
	public const string VISION_REFINE_MAIN_NON_VALID_TIP_TEXT_ID = "Text_VisionRefineMain_BlockedTips_Text";

	// Token: 0x04004E98 RID: 20120
	public const string HAVE_AVAILABLE_ATTR_TEXT_ID = "Text_Refresh_HaveAvailableAttr";

	// Token: 0x04004E99 RID: 20121
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Dictionary<EVisionRecoveryTabViewType, string> visionRecoveryTabViewTypeName;

	// Token: 0x04004E9A RID: 20122
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Dictionary<EVisionRefineCostType, string> visionRefineCostMap;

	// Token: 0x04004E9B RID: 20123
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Dictionary<EVisionRefineRefineType, string> visionRefineRefineMap;
}

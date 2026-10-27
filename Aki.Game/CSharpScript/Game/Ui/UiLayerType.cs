using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004669 RID: 18025
	public class UiLayerType
	{
		// Token: 0x040194CA RID: 103626
		public const int TIP_LAYER_UNIT_COUNT = 3;

		// Token: 0x040194CB RID: 103627
		public const int LOADING_LAYER_UNIT_COUNT = 2;

		// Token: 0x040194CC RID: 103628
		public const int BATTLE_VIEW_UNIT_COUNT = 3;

		// Token: 0x040194CD RID: 103629
		public const int NORMAL_CONTAINER_TYPE = 4098;

		// Token: 0x040194CE RID: 103630
		public const int PLOT_CONTAINER_TYPE = 4;

		// Token: 0x040194CF RID: 103631
		public const int NORMAL_PLOT_CONTAINER_TYPE = 4102;

		// Token: 0x040194D0 RID: 103632
		public const int IGNORE_MASK_TYPE = 384;

		// Token: 0x040194D1 RID: 103633
		public const int UIBLUR_TYPE = 70;

		// Token: 0x040194D2 RID: 103634
		public const int BLOCKCLICK_TYPE = 70;

		// Token: 0x040194D3 RID: 103635
		public const int MULTIPLE_VIEW_TYPE = 128;

		// Token: 0x040194D4 RID: 103636
		public const int MOBILE_SWITCH_ALLOW_VIEW_TYPE = 6144;

		// Token: 0x040194D5 RID: 103637
		public const int LOADING_VIEW_NODE_TYPE = 0;

		// Token: 0x040194D6 RID: 103638
		public const int SE_COVER_LOADING_VIEW_NODE_TYPE = 1;

		// Token: 0x040194D7 RID: 103639
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly ELayerType[] LayerTypeEnumValues = Enum.GetValues<ELayerType>();
	}
}

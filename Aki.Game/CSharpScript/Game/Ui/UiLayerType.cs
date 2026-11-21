using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200359A RID: 13722
	public class UiLayerType
	{
		// Token: 0x04013B71 RID: 80753
		public const int TIP_LAYER_UNIT_COUNT = 3;

		// Token: 0x04013B72 RID: 80754
		public const int LOADING_LAYER_UNIT_COUNT = 2;

		// Token: 0x04013B73 RID: 80755
		public const int BATTLE_VIEW_UNIT_COUNT = 3;

		// Token: 0x04013B74 RID: 80756
		public const int NORMAL_CONTAINER_TYPE = 4098;

		// Token: 0x04013B75 RID: 80757
		public const int PLOT_CONTAINER_TYPE = 4;

		// Token: 0x04013B76 RID: 80758
		public const int NORMAL_PLOT_CONTAINER_TYPE = 4102;

		// Token: 0x04013B77 RID: 80759
		public const int IGNORE_MASK_TYPE = 384;

		// Token: 0x04013B78 RID: 80760
		public const int UIBLUR_TYPE = 70;

		// Token: 0x04013B79 RID: 80761
		public const int BLOCKCLICK_TYPE = 70;

		// Token: 0x04013B7A RID: 80762
		public const int MULTIPLE_VIEW_TYPE = 128;

		// Token: 0x04013B7B RID: 80763
		public const int MOBILE_SWITCH_ALLOW_VIEW_TYPE = 6144;

		// Token: 0x04013B7C RID: 80764
		public const int LOADING_VIEW_NODE_TYPE = 0;

		// Token: 0x04013B7D RID: 80765
		public const int SE_COVER_LOADING_VIEW_NODE_TYPE = 1;

		// Token: 0x04013B7E RID: 80766
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly ELayerType[] LayerTypeEnumValues = Enum.GetValues<ELayerType>();
	}
}

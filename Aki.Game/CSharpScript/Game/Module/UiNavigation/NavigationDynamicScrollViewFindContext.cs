using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048F0 RID: 18672
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationDynamicScrollViewFindContext
	{
		// Token: 0x0401A393 RID: 107411
		public Vector LastListenerPosition = Vector.Create();

		// Token: 0x0401A394 RID: 107412
		public UINavigationWrapMode WrapMode;

		// Token: 0x0401A395 RID: 107413
		public UINavigationPriorityMode PriorityMode = UINavigationPriorityMode.Direction;

		// Token: 0x0401A396 RID: 107414
		public bool IsVertical;

		// Token: 0x0401A397 RID: 107415
		public double NavigateTolerance;

		// Token: 0x0401A398 RID: 107416
		public double NavigateToleranceReverse;

		// Token: 0x0401A399 RID: 107417
		public UUIScrollViewWithScrollbarComponent ScrollView;

		// Token: 0x0401A39A RID: 107418
		public NavigationGroup GroupConfig;

		// Token: 0x0401A39B RID: 107419
		public bool NegativeDirection;

		// Token: 0x0401A39C RID: 107420
		public bool Reversed;

		// Token: 0x0401A39D RID: 107421
		[Nullable(2)]
		public TsUiNavigationBehaviorListener LastListener;

		// Token: 0x0401A39E RID: 107422
		public EDynamicScrollViewFindNextType NextType;

		// Token: 0x0401A39F RID: 107423
		public bool NeedWaitScroll;

		// Token: 0x0401A3A0 RID: 107424
		public bool IsScrollToEdge;

		// Token: 0x0401A3A1 RID: 107425
		public float VerticalScrollValue;

		// Token: 0x0401A3A2 RID: 107426
		public float HorizontalScrollValue;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003867 RID: 14439
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationDynamicScrollViewFindContext
	{
		// Token: 0x04014C06 RID: 84998
		public Vector LastListenerPosition = Vector.Create();

		// Token: 0x04014C07 RID: 84999
		public UINavigationWrapMode WrapMode;

		// Token: 0x04014C08 RID: 85000
		public UINavigationPriorityMode PriorityMode = UINavigationPriorityMode.Direction;

		// Token: 0x04014C09 RID: 85001
		public bool IsVertical;

		// Token: 0x04014C0A RID: 85002
		public double NavigateTolerance;

		// Token: 0x04014C0B RID: 85003
		public double NavigateToleranceReverse;

		// Token: 0x04014C0C RID: 85004
		public UUIScrollViewWithScrollbarComponent ScrollView;

		// Token: 0x04014C0D RID: 85005
		public NavigationGroup GroupConfig;

		// Token: 0x04014C0E RID: 85006
		public bool NegativeDirection;

		// Token: 0x04014C0F RID: 85007
		public bool Reversed;

		// Token: 0x04014C10 RID: 85008
		[Nullable(2)]
		public TsUiNavigationBehaviorListener LastListener;

		// Token: 0x04014C11 RID: 85009
		public EDynamicScrollViewFindNextType NextType;

		// Token: 0x04014C12 RID: 85010
		public bool NeedWaitScroll;

		// Token: 0x04014C13 RID: 85011
		public bool IsScrollToEdge;

		// Token: 0x04014C14 RID: 85012
		public float VerticalScrollValue;

		// Token: 0x04014C15 RID: 85013
		public float HorizontalScrollValue;
	}
}

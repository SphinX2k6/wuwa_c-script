using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction
{
	// Token: 0x020057B9 RID: 22457
	[NullableContext(2)]
	[Nullable(0)]
	public class InteractionPayload
	{
		// Token: 0x0401D456 RID: 119894
		[Nullable(1)]
		public IDragSourceAdapter Adapter;

		// Token: 0x0401D457 RID: 119895
		[Nullable(1)]
		public IDragVisual Visual;

		// Token: 0x0401D458 RID: 119896
		public IDangoBrawlDraggableView SourceView;

		// Token: 0x0401D459 RID: 119897
		public ItemSucAnchor LastSucAnchor;

		// Token: 0x0401D45A RID: 119898
		public DragTarget LastTarget;
	}
}

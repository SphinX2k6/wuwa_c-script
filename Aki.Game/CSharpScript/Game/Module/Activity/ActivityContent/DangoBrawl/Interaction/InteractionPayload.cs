using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction
{
	// Token: 0x02006869 RID: 26729
	[NullableContext(2)]
	[Nullable(0)]
	public class InteractionPayload
	{
		// Token: 0x04022BF9 RID: 142329
		[Nullable(1)]
		public IDragSourceAdapter Adapter;

		// Token: 0x04022BFA RID: 142330
		[Nullable(1)]
		public IDragVisual Visual;

		// Token: 0x04022BFB RID: 142331
		public IDangoBrawlDraggableView SourceView;

		// Token: 0x04022BFC RID: 142332
		public ItemSucAnchor LastSucAnchor;

		// Token: 0x04022BFD RID: 142333
		public DragTarget LastTarget;
	}
}

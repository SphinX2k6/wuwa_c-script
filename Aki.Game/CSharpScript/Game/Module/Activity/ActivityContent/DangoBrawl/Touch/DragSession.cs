using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x02006856 RID: 26710
	[NullableContext(1)]
	[Nullable(0)]
	internal class DragSession
	{
		// Token: 0x06042AE7 RID: 273127 RVA: 0x010387A0 File Offset: 0x010369A0
		public DragSession(IDragSourceAdapter adapter, IDragVisual visual, [Nullable(2)] IDangoBrawlDraggableView sourceView = null)
		{
			this.Adapter = adapter;
			this.Visual = visual;
			this.SourceView = sourceView;
		}

		// Token: 0x04022B7E RID: 142206
		public readonly IDragSourceAdapter Adapter;

		// Token: 0x04022B7F RID: 142207
		public readonly IDragVisual Visual;

		// Token: 0x04022B80 RID: 142208
		[Nullable(2)]
		public readonly IDangoBrawlDraggableView SourceView;

		// Token: 0x04022B81 RID: 142209
		public FVector LastPointerPos;
	}
}

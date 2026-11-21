using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x020057A6 RID: 22438
	[NullableContext(1)]
	[Nullable(0)]
	internal class DragSession
	{
		// Token: 0x0603763C RID: 226876 RVA: 0x00F79CEC File Offset: 0x00F77EEC
		public DragSession(IDragSourceAdapter adapter, IDragVisual visual, [Nullable(2)] IDangoBrawlDraggableView sourceView = null)
		{
			this.Adapter = adapter;
			this.Visual = visual;
			this.SourceView = sourceView;
		}

		// Token: 0x0401D3DB RID: 119771
		public readonly IDragSourceAdapter Adapter;

		// Token: 0x0401D3DC RID: 119772
		public readonly IDragVisual Visual;

		// Token: 0x0401D3DD RID: 119773
		[Nullable(2)]
		public readonly IDangoBrawlDraggableView SourceView;

		// Token: 0x0401D3DE RID: 119774
		public FVector LastPointerPos;
	}
}

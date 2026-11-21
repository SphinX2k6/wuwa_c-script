using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056E6 RID: 22246
	[NullableContext(1)]
	public interface IDangoBrawlBagDropZoneExtra
	{
		// Token: 0x06036D3F RID: 224575
		[NullableContext(2)]
		UUIItem GetGridContainer();

		// Token: 0x06036D40 RID: 224576
		void HighlightGrids(PanelPos[] positions, EDangoBrawlGridState state);

		// Token: 0x06036D41 RID: 224577
		void HighlightGrids(PanelPos[] positions, EDangoBrawlGridState[] states);

		// Token: 0x06036D42 RID: 224578
		void ClearHighlight();
	}
}

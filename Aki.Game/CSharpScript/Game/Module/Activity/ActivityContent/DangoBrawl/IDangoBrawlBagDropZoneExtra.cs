using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006796 RID: 26518
	[NullableContext(1)]
	public interface IDangoBrawlBagDropZoneExtra
	{
		// Token: 0x060421E9 RID: 270825
		[NullableContext(2)]
		UUIItem GetGridContainer();

		// Token: 0x060421EA RID: 270826
		void HighlightGrids(PanelPos[] positions, EDangoBrawlGridState state);

		// Token: 0x060421EB RID: 270827
		void HighlightGrids(PanelPos[] positions, EDangoBrawlGridState[] states);

		// Token: 0x060421EC RID: 270828
		void ClearHighlight();
	}
}

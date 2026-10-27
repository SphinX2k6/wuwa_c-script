using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067DB RID: 26587
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class DangoBrawlPlacementResult
	{
		// Token: 0x040228F3 RID: 141555
		public EDangoBrawlPlaceMode Mode;

		// Token: 0x040228F4 RID: 141556
		public EDangoBrawlPlaceMode PrimaryMode;

		// Token: 0x040228F5 RID: 141557
		public DangoBrawlFollowerVerdict[] FollowerVerdicts = Array.Empty<DangoBrawlFollowerVerdict>();

		// Token: 0x040228F6 RID: 141558
		public DangoBrawlPlacedCell[] PlacedCells = Array.Empty<DangoBrawlPlacedCell>();

		// Token: 0x040228F7 RID: 141559
		public PanelPos PrimaryLeftTop;

		// Token: 0x040228F8 RID: 141560
		public EDangoBrawlRotate PrimaryRotate;

		// Token: 0x040228F9 RID: 141561
		public PanelPos[] PrimaryDraggingPos = Array.Empty<PanelPos>();

		// Token: 0x040228FA RID: 141562
		public DangoBrawlReplacedItem[] ItemsToReplace = Array.Empty<DangoBrawlReplacedItem>();
	}
}

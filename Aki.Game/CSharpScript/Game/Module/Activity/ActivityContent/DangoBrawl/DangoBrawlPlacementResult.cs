using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200572B RID: 22315
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class DangoBrawlPlacementResult
	{
		// Token: 0x0401D150 RID: 119120
		public EDangoBrawlPlaceMode Mode;

		// Token: 0x0401D151 RID: 119121
		public EDangoBrawlPlaceMode PrimaryMode;

		// Token: 0x0401D152 RID: 119122
		public DangoBrawlFollowerVerdict[] FollowerVerdicts = Array.Empty<DangoBrawlFollowerVerdict>();

		// Token: 0x0401D153 RID: 119123
		public DangoBrawlPlacedCell[] PlacedCells = Array.Empty<DangoBrawlPlacedCell>();

		// Token: 0x0401D154 RID: 119124
		public PanelPos PrimaryLeftTop;

		// Token: 0x0401D155 RID: 119125
		public EDangoBrawlRotate PrimaryRotate;

		// Token: 0x0401D156 RID: 119126
		public PanelPos[] PrimaryDraggingPos = Array.Empty<PanelPos>();

		// Token: 0x0401D157 RID: 119127
		public DangoBrawlReplacedItem[] ItemsToReplace = Array.Empty<DangoBrawlReplacedItem>();
	}
}

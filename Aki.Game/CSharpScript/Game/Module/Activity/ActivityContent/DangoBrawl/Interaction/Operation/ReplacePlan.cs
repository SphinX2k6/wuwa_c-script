using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation
{
	// Token: 0x020057C3 RID: 22467
	[NullableContext(1)]
	[Nullable(0)]
	public class ReplacePlan
	{
		// Token: 0x0401D470 RID: 119920
		public List<DangoBrawlBackpackItemData> AllItemsToMove;

		// Token: 0x0401D471 RID: 119921
		public PanelPos[] DraggingPos;

		// Token: 0x0401D472 RID: 119922
		public PanelPos LeftTopPos;

		// Token: 0x0401D473 RID: 119923
		public int PrimaryExclude;
	}
}

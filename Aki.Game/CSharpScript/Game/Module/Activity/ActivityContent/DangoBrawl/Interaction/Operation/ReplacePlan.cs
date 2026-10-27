using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation
{
	// Token: 0x02006873 RID: 26739
	[NullableContext(1)]
	[Nullable(0)]
	public class ReplacePlan
	{
		// Token: 0x04022C13 RID: 142355
		public List<DangoBrawlBackpackItemData> AllItemsToMove;

		// Token: 0x04022C14 RID: 142356
		public PanelPos[] DraggingPos;

		// Token: 0x04022C15 RID: 142357
		public PanelPos LeftTopPos;

		// Token: 0x04022C16 RID: 142358
		public int PrimaryExclude;
	}
}

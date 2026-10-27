using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FEE RID: 20462
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotReviewViewData
	{
		// Token: 0x17007FD8 RID: 32728
		// (get) Token: 0x060345C8 RID: 214472 RVA: 0x00C4D959 File Offset: 0x00C4BB59
		// (set) Token: 0x060345C9 RID: 214473 RVA: 0x00C4D961 File Offset: 0x00C4BB61
		public List<PlotReviewItemData> PlotReviewItemDataList { get; set; }

		// Token: 0x060345CA RID: 214474 RVA: 0x00C4D96A File Offset: 0x00C4BB6A
		public PlotReviewViewData()
		{
			this.PlotReviewItemDataList = new List<PlotReviewItemData>();
		}
	}
}

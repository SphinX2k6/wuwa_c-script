using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FB8 RID: 16312
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotReviewViewData
	{
		// Token: 0x1700538D RID: 21389
		// (get) Token: 0x06029453 RID: 169043 RVA: 0x00B979B9 File Offset: 0x00B95BB9
		// (set) Token: 0x06029454 RID: 169044 RVA: 0x00B979C1 File Offset: 0x00B95BC1
		public List<PlotReviewItemData> PlotReviewItemDataList { get; set; }

		// Token: 0x06029455 RID: 169045 RVA: 0x00B979CA File Offset: 0x00B95BCA
		public PlotReviewViewData()
		{
			this.PlotReviewItemDataList = new List<PlotReviewItemData>();
		}
	}
}

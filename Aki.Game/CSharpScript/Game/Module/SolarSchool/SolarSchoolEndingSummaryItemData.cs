using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A44 RID: 23108
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct SolarSchoolEndingSummaryItemData
	{
		// Token: 0x06038F67 RID: 233319 RVA: 0x00FF5E4F File Offset: 0x00FF404F
		public SolarSchoolEndingSummaryItemData(string titleTextId, string contentTextId, IReadOnlyList<string> contentParams)
		{
			this.TitleTextId = titleTextId;
			this.ContentTextId = contentTextId;
			this.ContentParams = contentParams;
		}

		// Token: 0x0401DFAE RID: 122798
		public readonly string TitleTextId;

		// Token: 0x0401DFAF RID: 122799
		public readonly string ContentTextId;

		// Token: 0x0401DFB0 RID: 122800
		public readonly IReadOnlyList<string> ContentParams;
	}
}

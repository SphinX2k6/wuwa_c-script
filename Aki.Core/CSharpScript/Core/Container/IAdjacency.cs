using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x0200015E RID: 350
	[NullableContext(1)]
	public interface IAdjacency
	{
		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000C43 RID: 3139
		// (set) Token: 0x06000C44 RID: 3140
		Dictionary<int, int> Degree { get; set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000C45 RID: 3141
		// (set) Token: 0x06000C46 RID: 3142
		Dictionary<int, List<IAdjItem>> Adj { get; set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000C47 RID: 3143
		// (set) Token: 0x06000C48 RID: 3144
		List<int> NodeIds { get; set; }
	}
}

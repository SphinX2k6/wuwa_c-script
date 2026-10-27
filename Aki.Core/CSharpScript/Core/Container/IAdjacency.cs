using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000159 RID: 345
	[NullableContext(1)]
	public interface IAdjacency
	{
		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000BE4 RID: 3044
		// (set) Token: 0x06000BE5 RID: 3045
		Dictionary<int, int> Degree { get; set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000BE6 RID: 3046
		// (set) Token: 0x06000BE7 RID: 3047
		Dictionary<int, List<IAdjItem>> Adj { get; set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000BE8 RID: 3048
		// (set) Token: 0x06000BE9 RID: 3049
		List<int> NodeIds { get; set; }
	}
}

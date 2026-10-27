using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x0200015B RID: 347
	[NullableContext(1)]
	public interface IComponent
	{
		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000BF1 RID: 3057
		// (set) Token: 0x06000BF2 RID: 3058
		Dictionary<int, int> Degree { get; set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000BF3 RID: 3059
		// (set) Token: 0x06000BF4 RID: 3060
		Dictionary<int, List<IAdjItem>> Adj { get; set; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000BF5 RID: 3061
		// (set) Token: 0x06000BF6 RID: 3062
		int EdgeCount { get; set; }
	}
}

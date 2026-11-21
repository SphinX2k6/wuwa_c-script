using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000160 RID: 352
	[NullableContext(1)]
	public interface IComponent
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000C50 RID: 3152
		// (set) Token: 0x06000C51 RID: 3153
		Dictionary<int, int> Degree { get; set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000C52 RID: 3154
		// (set) Token: 0x06000C53 RID: 3155
		Dictionary<int, List<IAdjItem>> Adj { get; set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000C54 RID: 3156
		// (set) Token: 0x06000C55 RID: 3157
		int EdgeCount { get; set; }
	}
}

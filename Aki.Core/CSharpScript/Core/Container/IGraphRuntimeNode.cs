using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x0200014F RID: 335
	[NullableContext(1)]
	public interface IGraphRuntimeNode<[Nullable(2)] TVec>
	{
		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000BE6 RID: 3046
		// (set) Token: 0x06000BE7 RID: 3047
		int Id { get; set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000BE8 RID: 3048
		// (set) Token: 0x06000BE9 RID: 3049
		TVec Location { get; set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000BEA RID: 3050
		// (set) Token: 0x06000BEB RID: 3051
		HashSet<int> OutNeighbors { get; set; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000BEC RID: 3052
		// (set) Token: 0x06000BED RID: 3053
		HashSet<int> Neighbors { get; set; }
	}
}

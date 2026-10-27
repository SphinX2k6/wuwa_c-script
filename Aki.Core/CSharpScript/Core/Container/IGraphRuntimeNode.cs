using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x0200014B RID: 331
	[NullableContext(1)]
	public interface IGraphRuntimeNode<[Nullable(2)] TVec>
	{
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000B8A RID: 2954
		// (set) Token: 0x06000B8B RID: 2955
		int Id { get; set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000B8C RID: 2956
		// (set) Token: 0x06000B8D RID: 2957
		TVec Location { get; set; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000B8E RID: 2958
		// (set) Token: 0x06000B8F RID: 2959
		HashSet<int> OutNeighbors { get; set; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000B90 RID: 2960
		// (set) Token: 0x06000B91 RID: 2961
		HashSet<int> Neighbors { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000150 RID: 336
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class GraphRuntimeNode<[Nullable(2)] TVec> : IGraphRuntimeNode<TVec>
	{
		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x000384A2 File Offset: 0x000366A2
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x000384AA File Offset: 0x000366AA
		[RequiredMember]
		public int Id { get; set; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x000384B3 File Offset: 0x000366B3
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x000384BB File Offset: 0x000366BB
		[RequiredMember]
		public TVec Location { get; set; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x000384C4 File Offset: 0x000366C4
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x000384CC File Offset: 0x000366CC
		[RequiredMember]
		public HashSet<int> OutNeighbors { get; set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x000384D5 File Offset: 0x000366D5
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x000384DD File Offset: 0x000366DD
		[RequiredMember]
		public HashSet<int> Neighbors { get; set; }

		// Token: 0x06000BF6 RID: 3062 RVA: 0x000384E6 File Offset: 0x000366E6
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GraphRuntimeNode()
		{
		}
	}
}

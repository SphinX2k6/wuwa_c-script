using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x0200014C RID: 332
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class GraphRuntimeNode<[Nullable(2)] TVec> : IGraphRuntimeNode<TVec>
	{
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x000378D2 File Offset: 0x00035AD2
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x000378DA File Offset: 0x00035ADA
		[RequiredMember]
		public int Id { get; set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x000378E3 File Offset: 0x00035AE3
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x000378EB File Offset: 0x00035AEB
		[RequiredMember]
		public TVec Location { get; set; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x000378F4 File Offset: 0x00035AF4
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x000378FC File Offset: 0x00035AFC
		[RequiredMember]
		public HashSet<int> OutNeighbors { get; set; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x00037905 File Offset: 0x00035B05
		// (set) Token: 0x06000B99 RID: 2969 RVA: 0x0003790D File Offset: 0x00035B0D
		[RequiredMember]
		public HashSet<int> Neighbors { get; set; }

		// Token: 0x06000B9A RID: 2970 RVA: 0x00037916 File Offset: 0x00035B16
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GraphRuntimeNode()
		{
		}
	}
}

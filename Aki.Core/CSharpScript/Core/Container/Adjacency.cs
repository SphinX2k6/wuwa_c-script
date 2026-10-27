using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x0200015A RID: 346
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class Adjacency : IAdjacency
	{
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00038164 File Offset: 0x00036364
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x0003816C File Offset: 0x0003636C
		[RequiredMember]
		public Dictionary<int, int> Degree { get; set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00038175 File Offset: 0x00036375
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x0003817D File Offset: 0x0003637D
		[RequiredMember]
		public Dictionary<int, List<IAdjItem>> Adj { get; set; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00038186 File Offset: 0x00036386
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x0003818E File Offset: 0x0003638E
		[RequiredMember]
		public List<int> NodeIds { get; set; }

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00038197 File Offset: 0x00036397
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public Adjacency()
		{
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x0200015F RID: 351
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class Adjacency : IAdjacency
	{
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x00038EA7 File Offset: 0x000370A7
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x00038EAF File Offset: 0x000370AF
		[RequiredMember]
		public Dictionary<int, int> Degree { get; set; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x00038EB8 File Offset: 0x000370B8
		// (set) Token: 0x06000C4C RID: 3148 RVA: 0x00038EC0 File Offset: 0x000370C0
		[RequiredMember]
		public Dictionary<int, List<IAdjItem>> Adj { get; set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x00038EC9 File Offset: 0x000370C9
		// (set) Token: 0x06000C4E RID: 3150 RVA: 0x00038ED1 File Offset: 0x000370D1
		[RequiredMember]
		public List<int> NodeIds { get; set; }

		// Token: 0x06000C4F RID: 3151 RVA: 0x00038EDA File Offset: 0x000370DA
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public Adjacency()
		{
		}
	}
}

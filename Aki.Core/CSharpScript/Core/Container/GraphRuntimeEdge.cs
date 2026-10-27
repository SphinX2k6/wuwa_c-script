using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x0200014E RID: 334
	[RequiredMember]
	public class GraphRuntimeEdge : IGraphRuntimeEdge
	{
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x0003791E File Offset: 0x00035B1E
		// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x00037926 File Offset: 0x00035B26
		[RequiredMember]
		public int Id { get; set; }

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x0003792F File Offset: 0x00035B2F
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x00037937 File Offset: 0x00035B37
		[RequiredMember]
		public int From { get; set; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x00037940 File Offset: 0x00035B40
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x00037948 File Offset: 0x00035B48
		[RequiredMember]
		public int To { get; set; }

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00037951 File Offset: 0x00035B51
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GraphRuntimeEdge()
		{
		}
	}
}

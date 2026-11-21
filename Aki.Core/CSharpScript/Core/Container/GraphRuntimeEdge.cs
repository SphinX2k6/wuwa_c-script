using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000152 RID: 338
	[RequiredMember]
	public class GraphRuntimeEdge : IGraphRuntimeEdge
	{
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x000384EE File Offset: 0x000366EE
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x000384F6 File Offset: 0x000366F6
		[RequiredMember]
		public int Id { get; set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x000384FF File Offset: 0x000366FF
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x00038507 File Offset: 0x00036707
		[RequiredMember]
		public int From { get; set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x00038510 File Offset: 0x00036710
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x00038518 File Offset: 0x00036718
		[RequiredMember]
		public int To { get; set; }

		// Token: 0x06000C03 RID: 3075 RVA: 0x00038521 File Offset: 0x00036721
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GraphRuntimeEdge()
		{
		}
	}
}

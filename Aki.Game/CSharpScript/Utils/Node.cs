using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02004511 RID: 17681
	[NullableContext(1)]
	[Nullable(0)]
	public class Node : INode
	{
		// Token: 0x170073EB RID: 29675
		// (get) Token: 0x0602D814 RID: 186388 RVA: 0x00A44EFB File Offset: 0x00A430FB
		// (set) Token: 0x0602D815 RID: 186389 RVA: 0x00A44F03 File Offset: 0x00A43103
		public ENodeType NodeType { get; set; }

		// Token: 0x170073EC RID: 29676
		// (get) Token: 0x0602D816 RID: 186390 RVA: 0x00A44F0C File Offset: 0x00A4310C
		// (set) Token: 0x0602D817 RID: 186391 RVA: 0x00A44F14 File Offset: 0x00A43114
		public string Name { get; set; } = string.Empty;

		// Token: 0x170073ED RID: 29677
		// (get) Token: 0x0602D818 RID: 186392 RVA: 0x00A44F1D File Offset: 0x00A4311D
		// (set) Token: 0x0602D819 RID: 186393 RVA: 0x00A44F25 File Offset: 0x00A43125
		public TFormulaValue Value { get; set; }

		// Token: 0x170073EE RID: 29678
		// (get) Token: 0x0602D81A RID: 186394 RVA: 0x00A44F2E File Offset: 0x00A4312E
		// (set) Token: 0x0602D81B RID: 186395 RVA: 0x00A44F36 File Offset: 0x00A43136
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<INode> Children { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}

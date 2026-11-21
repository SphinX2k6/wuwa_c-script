using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003423 RID: 13347
	[NullableContext(1)]
	[Nullable(0)]
	public class ArrayNode : IAstNode, IArrayNode
	{
		// Token: 0x1700468A RID: 18058
		// (get) Token: 0x06021E83 RID: 138883 RVA: 0x0096F9F9 File Offset: 0x0096DBF9
		// (set) Token: 0x06021E84 RID: 138884 RVA: 0x0096FA01 File Offset: 0x0096DC01
		public EAstNodeType NodeType { get; set; }

		// Token: 0x1700468B RID: 18059
		// (get) Token: 0x06021E85 RID: 138885 RVA: 0x0096FA0A File Offset: 0x0096DC0A
		// (set) Token: 0x06021E86 RID: 138886 RVA: 0x0096FA12 File Offset: 0x0096DC12
		public IAstNode[] Value { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02004504 RID: 17668
	[NullableContext(1)]
	[Nullable(0)]
	public class IdentifierNode : IAstNode, IIdentifierNode
	{
		// Token: 0x170073DA RID: 29658
		// (get) Token: 0x0602D7C6 RID: 186310 RVA: 0x00A43C89 File Offset: 0x00A41E89
		// (set) Token: 0x0602D7C7 RID: 186311 RVA: 0x00A43C91 File Offset: 0x00A41E91
		public EAstNodeType NodeType { get; set; }

		// Token: 0x170073DB RID: 29659
		// (get) Token: 0x0602D7C8 RID: 186312 RVA: 0x00A43C9A File Offset: 0x00A41E9A
		// (set) Token: 0x0602D7C9 RID: 186313 RVA: 0x00A43CA2 File Offset: 0x00A41EA2
		public string Value { get; set; }
	}
}

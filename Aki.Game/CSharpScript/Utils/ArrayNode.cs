using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02004501 RID: 17665
	[NullableContext(1)]
	[Nullable(0)]
	public class ArrayNode : IAstNode, IArrayNode
	{
		// Token: 0x170073D2 RID: 29650
		// (get) Token: 0x0602D7B3 RID: 186291 RVA: 0x00A43BE9 File Offset: 0x00A41DE9
		// (set) Token: 0x0602D7B4 RID: 186292 RVA: 0x00A43BF1 File Offset: 0x00A41DF1
		public EAstNodeType NodeType { get; set; }

		// Token: 0x170073D3 RID: 29651
		// (get) Token: 0x0602D7B5 RID: 186293 RVA: 0x00A43BFA File Offset: 0x00A41DFA
		// (set) Token: 0x0602D7B6 RID: 186294 RVA: 0x00A43C02 File Offset: 0x00A41E02
		public IAstNode[] Value { get; set; }
	}
}

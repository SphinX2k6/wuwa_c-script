using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02004505 RID: 17669
	[NullableContext(1)]
	[Nullable(0)]
	public class FunctionCallNode : IAstNode, IFunctionCallNode
	{
		// Token: 0x170073DC RID: 29660
		// (get) Token: 0x0602D7CB RID: 186315 RVA: 0x00A43CB3 File Offset: 0x00A41EB3
		// (set) Token: 0x0602D7CC RID: 186316 RVA: 0x00A43CBB File Offset: 0x00A41EBB
		public EAstNodeType NodeType { get; set; }

		// Token: 0x170073DD RID: 29661
		// (get) Token: 0x0602D7CD RID: 186317 RVA: 0x00A43CC4 File Offset: 0x00A41EC4
		// (set) Token: 0x0602D7CE RID: 186318 RVA: 0x00A43CCC File Offset: 0x00A41ECC
		public string Value { get; set; }

		// Token: 0x170073DE RID: 29662
		// (get) Token: 0x0602D7CF RID: 186319 RVA: 0x00A43CD5 File Offset: 0x00A41ED5
		// (set) Token: 0x0602D7D0 RID: 186320 RVA: 0x00A43CDD File Offset: 0x00A41EDD
		public IAstNode[] Args { get; set; }
	}
}

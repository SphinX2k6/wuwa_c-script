using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02004500 RID: 17664
	[NullableContext(1)]
	[Nullable(0)]
	public class ParenthesizedExpressionNode : IAstNode, IParenthesizedExpressionNode
	{
		// Token: 0x170073D0 RID: 29648
		// (get) Token: 0x0602D7AE RID: 186286 RVA: 0x00A43BBF File Offset: 0x00A41DBF
		// (set) Token: 0x0602D7AF RID: 186287 RVA: 0x00A43BC7 File Offset: 0x00A41DC7
		public EAstNodeType NodeType { get; set; }

		// Token: 0x170073D1 RID: 29649
		// (get) Token: 0x0602D7B0 RID: 186288 RVA: 0x00A43BD0 File Offset: 0x00A41DD0
		// (set) Token: 0x0602D7B1 RID: 186289 RVA: 0x00A43BD8 File Offset: 0x00A41DD8
		public IAstNode Value { get; set; }
	}
}

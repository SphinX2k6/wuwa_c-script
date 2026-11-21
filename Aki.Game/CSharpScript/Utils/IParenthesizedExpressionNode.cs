using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003416 RID: 13334
	[NullableContext(1)]
	public interface IParenthesizedExpressionNode
	{
		// Token: 0x17004670 RID: 18032
		// (get) Token: 0x06021E36 RID: 138806
		// (set) Token: 0x06021E37 RID: 138807
		EAstNodeType NodeType { get; set; }

		// Token: 0x17004671 RID: 18033
		// (get) Token: 0x06021E38 RID: 138808
		// (set) Token: 0x06021E39 RID: 138809
		IAstNode Value { get; set; }
	}
}

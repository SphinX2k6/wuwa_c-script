using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x020044F4 RID: 17652
	[NullableContext(1)]
	public interface IParenthesizedExpressionNode
	{
		// Token: 0x170073B8 RID: 29624
		// (get) Token: 0x0602D766 RID: 186214
		// (set) Token: 0x0602D767 RID: 186215
		EAstNodeType NodeType { get; set; }

		// Token: 0x170073B9 RID: 29625
		// (get) Token: 0x0602D768 RID: 186216
		// (set) Token: 0x0602D769 RID: 186217
		IAstNode Value { get; set; }
	}
}

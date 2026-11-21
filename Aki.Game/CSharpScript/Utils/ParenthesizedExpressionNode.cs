using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003422 RID: 13346
	[NullableContext(1)]
	[Nullable(0)]
	public class ParenthesizedExpressionNode : IAstNode, IParenthesizedExpressionNode
	{
		// Token: 0x17004688 RID: 18056
		// (get) Token: 0x06021E7E RID: 138878 RVA: 0x0096F9CF File Offset: 0x0096DBCF
		// (set) Token: 0x06021E7F RID: 138879 RVA: 0x0096F9D7 File Offset: 0x0096DBD7
		public EAstNodeType NodeType { get; set; }

		// Token: 0x17004689 RID: 18057
		// (get) Token: 0x06021E80 RID: 138880 RVA: 0x0096F9E0 File Offset: 0x0096DBE0
		// (set) Token: 0x06021E81 RID: 138881 RVA: 0x0096F9E8 File Offset: 0x0096DBE8
		public IAstNode Value { get; set; }
	}
}

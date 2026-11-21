using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003418 RID: 13336
	[NullableContext(1)]
	public interface IBinaryOperatorNode
	{
		// Token: 0x17004674 RID: 18036
		// (get) Token: 0x06021E3E RID: 138814
		// (set) Token: 0x06021E3F RID: 138815
		EAstNodeType NodeType { get; set; }

		// Token: 0x17004675 RID: 18037
		// (get) Token: 0x06021E40 RID: 138816
		// (set) Token: 0x06021E41 RID: 138817
		string Operator { get; set; }

		// Token: 0x17004676 RID: 18038
		// (get) Token: 0x06021E42 RID: 138818
		// (set) Token: 0x06021E43 RID: 138819
		IAstNode[] Args { get; set; }
	}
}

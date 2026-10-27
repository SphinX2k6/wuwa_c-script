using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x020044F6 RID: 17654
	[NullableContext(1)]
	public interface IBinaryOperatorNode
	{
		// Token: 0x170073BC RID: 29628
		// (get) Token: 0x0602D76E RID: 186222
		// (set) Token: 0x0602D76F RID: 186223
		EAstNodeType NodeType { get; set; }

		// Token: 0x170073BD RID: 29629
		// (get) Token: 0x0602D770 RID: 186224
		// (set) Token: 0x0602D771 RID: 186225
		string Operator { get; set; }

		// Token: 0x170073BE RID: 29630
		// (get) Token: 0x0602D772 RID: 186226
		// (set) Token: 0x0602D773 RID: 186227
		IAstNode[] Args { get; set; }
	}
}

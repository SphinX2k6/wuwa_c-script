using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x020044F5 RID: 17653
	[NullableContext(1)]
	public interface IArrayNode
	{
		// Token: 0x170073BA RID: 29626
		// (get) Token: 0x0602D76A RID: 186218
		// (set) Token: 0x0602D76B RID: 186219
		EAstNodeType NodeType { get; set; }

		// Token: 0x170073BB RID: 29627
		// (get) Token: 0x0602D76C RID: 186220
		// (set) Token: 0x0602D76D RID: 186221
		IAstNode[] Value { get; set; }
	}
}

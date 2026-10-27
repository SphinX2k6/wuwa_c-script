using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x020044F9 RID: 17657
	[NullableContext(1)]
	public interface IFunctionCallNode
	{
		// Token: 0x170073C4 RID: 29636
		// (get) Token: 0x0602D77E RID: 186238
		// (set) Token: 0x0602D77F RID: 186239
		EAstNodeType NodeType { get; set; }

		// Token: 0x170073C5 RID: 29637
		// (get) Token: 0x0602D780 RID: 186240
		// (set) Token: 0x0602D781 RID: 186241
		string Value { get; set; }

		// Token: 0x170073C6 RID: 29638
		// (get) Token: 0x0602D782 RID: 186242
		// (set) Token: 0x0602D783 RID: 186243
		IAstNode[] Args { get; set; }
	}
}

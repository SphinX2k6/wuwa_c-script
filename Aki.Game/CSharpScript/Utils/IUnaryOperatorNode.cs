using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x020044F7 RID: 17655
	[NullableContext(1)]
	public interface IUnaryOperatorNode
	{
		// Token: 0x170073BF RID: 29631
		// (get) Token: 0x0602D774 RID: 186228
		// (set) Token: 0x0602D775 RID: 186229
		EAstNodeType NodeType { get; set; }

		// Token: 0x170073C0 RID: 29632
		// (get) Token: 0x0602D776 RID: 186230
		// (set) Token: 0x0602D777 RID: 186231
		string Operator { get; set; }

		// Token: 0x170073C1 RID: 29633
		// (get) Token: 0x0602D778 RID: 186232
		// (set) Token: 0x0602D779 RID: 186233
		IAstNode[] Args { get; set; }
	}
}

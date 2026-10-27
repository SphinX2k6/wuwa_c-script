using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x020044FA RID: 17658
	[NullableContext(1)]
	public interface IIndexNode
	{
		// Token: 0x170073C7 RID: 29639
		// (get) Token: 0x0602D784 RID: 186244
		// (set) Token: 0x0602D785 RID: 186245
		EAstNodeType NodeType { get; set; }

		// Token: 0x170073C8 RID: 29640
		// (get) Token: 0x0602D786 RID: 186246
		// (set) Token: 0x0602D787 RID: 186247
		IAstNode Value { get; set; }

		// Token: 0x170073C9 RID: 29641
		// (get) Token: 0x0602D788 RID: 186248
		// (set) Token: 0x0602D789 RID: 186249
		IAstNode Index { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x0200341C RID: 13340
	[NullableContext(1)]
	public interface IIndexNode
	{
		// Token: 0x1700467F RID: 18047
		// (get) Token: 0x06021E54 RID: 138836
		// (set) Token: 0x06021E55 RID: 138837
		EAstNodeType NodeType { get; set; }

		// Token: 0x17004680 RID: 18048
		// (get) Token: 0x06021E56 RID: 138838
		// (set) Token: 0x06021E57 RID: 138839
		IAstNode Value { get; set; }

		// Token: 0x17004681 RID: 18049
		// (get) Token: 0x06021E58 RID: 138840
		// (set) Token: 0x06021E59 RID: 138841
		IAstNode Index { get; set; }
	}
}

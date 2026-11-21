using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x0200341B RID: 13339
	[NullableContext(1)]
	public interface IFunctionCallNode
	{
		// Token: 0x1700467C RID: 18044
		// (get) Token: 0x06021E4E RID: 138830
		// (set) Token: 0x06021E4F RID: 138831
		EAstNodeType NodeType { get; set; }

		// Token: 0x1700467D RID: 18045
		// (get) Token: 0x06021E50 RID: 138832
		// (set) Token: 0x06021E51 RID: 138833
		string Value { get; set; }

		// Token: 0x1700467E RID: 18046
		// (get) Token: 0x06021E52 RID: 138834
		// (set) Token: 0x06021E53 RID: 138835
		IAstNode[] Args { get; set; }
	}
}

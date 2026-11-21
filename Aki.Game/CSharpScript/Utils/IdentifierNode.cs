using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003426 RID: 13350
	[NullableContext(1)]
	[Nullable(0)]
	public class IdentifierNode : IAstNode, IIdentifierNode
	{
		// Token: 0x17004692 RID: 18066
		// (get) Token: 0x06021E96 RID: 138902 RVA: 0x0096FA99 File Offset: 0x0096DC99
		// (set) Token: 0x06021E97 RID: 138903 RVA: 0x0096FAA1 File Offset: 0x0096DCA1
		public EAstNodeType NodeType { get; set; }

		// Token: 0x17004693 RID: 18067
		// (get) Token: 0x06021E98 RID: 138904 RVA: 0x0096FAAA File Offset: 0x0096DCAA
		// (set) Token: 0x06021E99 RID: 138905 RVA: 0x0096FAB2 File Offset: 0x0096DCB2
		public string Value { get; set; }
	}
}

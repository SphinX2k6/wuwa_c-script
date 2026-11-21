using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003428 RID: 13352
	[NullableContext(1)]
	[Nullable(0)]
	public class IndexNode : IAstNode, IIndexNode
	{
		// Token: 0x17004697 RID: 18071
		// (get) Token: 0x06021EA2 RID: 138914 RVA: 0x0096FAFE File Offset: 0x0096DCFE
		// (set) Token: 0x06021EA3 RID: 138915 RVA: 0x0096FB06 File Offset: 0x0096DD06
		public EAstNodeType NodeType { get; set; }

		// Token: 0x17004698 RID: 18072
		// (get) Token: 0x06021EA4 RID: 138916 RVA: 0x0096FB0F File Offset: 0x0096DD0F
		// (set) Token: 0x06021EA5 RID: 138917 RVA: 0x0096FB17 File Offset: 0x0096DD17
		public IAstNode Value { get; set; }

		// Token: 0x17004699 RID: 18073
		// (get) Token: 0x06021EA6 RID: 138918 RVA: 0x0096FB20 File Offset: 0x0096DD20
		// (set) Token: 0x06021EA7 RID: 138919 RVA: 0x0096FB28 File Offset: 0x0096DD28
		public IAstNode Index { get; set; }
	}
}

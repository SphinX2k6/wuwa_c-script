using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003425 RID: 13349
	[NullableContext(1)]
	[Nullable(0)]
	public class UnaryOperatorNode : IAstNode, IUnaryOperatorNode
	{
		// Token: 0x1700468F RID: 18063
		// (get) Token: 0x06021E8F RID: 138895 RVA: 0x0096FA5E File Offset: 0x0096DC5E
		// (set) Token: 0x06021E90 RID: 138896 RVA: 0x0096FA66 File Offset: 0x0096DC66
		public EAstNodeType NodeType { get; set; }

		// Token: 0x17004690 RID: 18064
		// (get) Token: 0x06021E91 RID: 138897 RVA: 0x0096FA6F File Offset: 0x0096DC6F
		// (set) Token: 0x06021E92 RID: 138898 RVA: 0x0096FA77 File Offset: 0x0096DC77
		public string Operator { get; set; }

		// Token: 0x17004691 RID: 18065
		// (get) Token: 0x06021E93 RID: 138899 RVA: 0x0096FA80 File Offset: 0x0096DC80
		// (set) Token: 0x06021E94 RID: 138900 RVA: 0x0096FA88 File Offset: 0x0096DC88
		public IAstNode[] Args { get; set; }
	}
}

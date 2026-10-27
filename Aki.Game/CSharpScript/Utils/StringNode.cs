using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x020044FF RID: 17663
	[NullableContext(1)]
	[Nullable(0)]
	public class StringNode : IAstNode, IStringNode
	{
		// Token: 0x170073CE RID: 29646
		// (get) Token: 0x0602D7A9 RID: 186281 RVA: 0x00A43B95 File Offset: 0x00A41D95
		// (set) Token: 0x0602D7AA RID: 186282 RVA: 0x00A43B9D File Offset: 0x00A41D9D
		public EAstNodeType NodeType { get; set; }

		// Token: 0x170073CF RID: 29647
		// (get) Token: 0x0602D7AB RID: 186283 RVA: 0x00A43BA6 File Offset: 0x00A41DA6
		// (set) Token: 0x0602D7AC RID: 186284 RVA: 0x00A43BAE File Offset: 0x00A41DAE
		public string Value { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02004502 RID: 17666
	[NullableContext(1)]
	[Nullable(0)]
	public class BinaryOperatorNode : IAstNode, IBinaryOperatorNode
	{
		// Token: 0x170073D4 RID: 29652
		// (get) Token: 0x0602D7B8 RID: 186296 RVA: 0x00A43C13 File Offset: 0x00A41E13
		// (set) Token: 0x0602D7B9 RID: 186297 RVA: 0x00A43C1B File Offset: 0x00A41E1B
		public EAstNodeType NodeType { get; set; }

		// Token: 0x170073D5 RID: 29653
		// (get) Token: 0x0602D7BA RID: 186298 RVA: 0x00A43C24 File Offset: 0x00A41E24
		// (set) Token: 0x0602D7BB RID: 186299 RVA: 0x00A43C2C File Offset: 0x00A41E2C
		public string Operator { get; set; }

		// Token: 0x170073D6 RID: 29654
		// (get) Token: 0x0602D7BC RID: 186300 RVA: 0x00A43C35 File Offset: 0x00A41E35
		// (set) Token: 0x0602D7BD RID: 186301 RVA: 0x00A43C3D File Offset: 0x00A41E3D
		public IAstNode[] Args { get; set; }
	}
}

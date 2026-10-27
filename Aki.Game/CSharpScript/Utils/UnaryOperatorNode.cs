using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02004503 RID: 17667
	[NullableContext(1)]
	[Nullable(0)]
	public class UnaryOperatorNode : IAstNode, IUnaryOperatorNode
	{
		// Token: 0x170073D7 RID: 29655
		// (get) Token: 0x0602D7BF RID: 186303 RVA: 0x00A43C4E File Offset: 0x00A41E4E
		// (set) Token: 0x0602D7C0 RID: 186304 RVA: 0x00A43C56 File Offset: 0x00A41E56
		public EAstNodeType NodeType { get; set; }

		// Token: 0x170073D8 RID: 29656
		// (get) Token: 0x0602D7C1 RID: 186305 RVA: 0x00A43C5F File Offset: 0x00A41E5F
		// (set) Token: 0x0602D7C2 RID: 186306 RVA: 0x00A43C67 File Offset: 0x00A41E67
		public string Operator { get; set; }

		// Token: 0x170073D9 RID: 29657
		// (get) Token: 0x0602D7C3 RID: 186307 RVA: 0x00A43C70 File Offset: 0x00A41E70
		// (set) Token: 0x0602D7C4 RID: 186308 RVA: 0x00A43C78 File Offset: 0x00A41E78
		public IAstNode[] Args { get; set; }
	}
}

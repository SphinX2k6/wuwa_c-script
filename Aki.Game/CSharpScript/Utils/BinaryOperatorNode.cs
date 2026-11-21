using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003424 RID: 13348
	[NullableContext(1)]
	[Nullable(0)]
	public class BinaryOperatorNode : IAstNode, IBinaryOperatorNode
	{
		// Token: 0x1700468C RID: 18060
		// (get) Token: 0x06021E88 RID: 138888 RVA: 0x0096FA23 File Offset: 0x0096DC23
		// (set) Token: 0x06021E89 RID: 138889 RVA: 0x0096FA2B File Offset: 0x0096DC2B
		public EAstNodeType NodeType { get; set; }

		// Token: 0x1700468D RID: 18061
		// (get) Token: 0x06021E8A RID: 138890 RVA: 0x0096FA34 File Offset: 0x0096DC34
		// (set) Token: 0x06021E8B RID: 138891 RVA: 0x0096FA3C File Offset: 0x0096DC3C
		public string Operator { get; set; }

		// Token: 0x1700468E RID: 18062
		// (get) Token: 0x06021E8C RID: 138892 RVA: 0x0096FA45 File Offset: 0x0096DC45
		// (set) Token: 0x06021E8D RID: 138893 RVA: 0x0096FA4D File Offset: 0x0096DC4D
		public IAstNode[] Args { get; set; }
	}
}

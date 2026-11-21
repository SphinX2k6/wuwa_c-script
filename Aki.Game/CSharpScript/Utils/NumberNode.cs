using System;

namespace CSharpScript.Utils
{
	// Token: 0x02003420 RID: 13344
	public class NumberNode : IAstNode, INumberNode
	{
		// Token: 0x17004684 RID: 18052
		// (get) Token: 0x06021E74 RID: 138868 RVA: 0x0096F97B File Offset: 0x0096DB7B
		// (set) Token: 0x06021E75 RID: 138869 RVA: 0x0096F983 File Offset: 0x0096DB83
		public EAstNodeType NodeType { get; set; }

		// Token: 0x17004685 RID: 18053
		// (get) Token: 0x06021E76 RID: 138870 RVA: 0x0096F98C File Offset: 0x0096DB8C
		// (set) Token: 0x06021E77 RID: 138871 RVA: 0x0096F994 File Offset: 0x0096DB94
		public TFormulaValue Value { get; set; }
	}
}

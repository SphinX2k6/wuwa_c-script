using System;

namespace CSharpScript.Utils
{
	// Token: 0x020044FE RID: 17662
	public class NumberNode : IAstNode, INumberNode
	{
		// Token: 0x170073CC RID: 29644
		// (get) Token: 0x0602D7A4 RID: 186276 RVA: 0x00A43B6B File Offset: 0x00A41D6B
		// (set) Token: 0x0602D7A5 RID: 186277 RVA: 0x00A43B73 File Offset: 0x00A41D73
		public EAstNodeType NodeType { get; set; }

		// Token: 0x170073CD RID: 29645
		// (get) Token: 0x0602D7A6 RID: 186278 RVA: 0x00A43B7C File Offset: 0x00A41D7C
		// (set) Token: 0x0602D7A7 RID: 186279 RVA: 0x00A43B84 File Offset: 0x00A41D84
		public TFormulaValue Value { get; set; }
	}
}

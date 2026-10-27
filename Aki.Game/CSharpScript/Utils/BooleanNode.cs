using System;

namespace CSharpScript.Utils
{
	// Token: 0x020044FD RID: 17661
	public class BooleanNode : IAstNode, IBooleanNode
	{
		// Token: 0x170073CA RID: 29642
		// (get) Token: 0x0602D79F RID: 186271 RVA: 0x00A43B41 File Offset: 0x00A41D41
		// (set) Token: 0x0602D7A0 RID: 186272 RVA: 0x00A43B49 File Offset: 0x00A41D49
		public EAstNodeType NodeType { get; set; }

		// Token: 0x170073CB RID: 29643
		// (get) Token: 0x0602D7A1 RID: 186273 RVA: 0x00A43B52 File Offset: 0x00A41D52
		// (set) Token: 0x0602D7A2 RID: 186274 RVA: 0x00A43B5A File Offset: 0x00A41D5A
		public bool Value { get; set; }
	}
}

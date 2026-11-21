using System;

namespace CSharpScript.Utils
{
	// Token: 0x0200341F RID: 13343
	public class BooleanNode : IAstNode, IBooleanNode
	{
		// Token: 0x17004682 RID: 18050
		// (get) Token: 0x06021E6F RID: 138863 RVA: 0x0096F951 File Offset: 0x0096DB51
		// (set) Token: 0x06021E70 RID: 138864 RVA: 0x0096F959 File Offset: 0x0096DB59
		public EAstNodeType NodeType { get; set; }

		// Token: 0x17004683 RID: 18051
		// (get) Token: 0x06021E71 RID: 138865 RVA: 0x0096F962 File Offset: 0x0096DB62
		// (set) Token: 0x06021E72 RID: 138866 RVA: 0x0096F96A File Offset: 0x0096DB6A
		public bool Value { get; set; }
	}
}

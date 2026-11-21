using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003427 RID: 13351
	[NullableContext(1)]
	[Nullable(0)]
	public class FunctionCallNode : IAstNode, IFunctionCallNode
	{
		// Token: 0x17004694 RID: 18068
		// (get) Token: 0x06021E9B RID: 138907 RVA: 0x0096FAC3 File Offset: 0x0096DCC3
		// (set) Token: 0x06021E9C RID: 138908 RVA: 0x0096FACB File Offset: 0x0096DCCB
		public EAstNodeType NodeType { get; set; }

		// Token: 0x17004695 RID: 18069
		// (get) Token: 0x06021E9D RID: 138909 RVA: 0x0096FAD4 File Offset: 0x0096DCD4
		// (set) Token: 0x06021E9E RID: 138910 RVA: 0x0096FADC File Offset: 0x0096DCDC
		public string Value { get; set; }

		// Token: 0x17004696 RID: 18070
		// (get) Token: 0x06021E9F RID: 138911 RVA: 0x0096FAE5 File Offset: 0x0096DCE5
		// (set) Token: 0x06021EA0 RID: 138912 RVA: 0x0096FAED File Offset: 0x0096DCED
		public IAstNode[] Args { get; set; }
	}
}

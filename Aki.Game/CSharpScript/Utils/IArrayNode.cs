using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003417 RID: 13335
	[NullableContext(1)]
	public interface IArrayNode
	{
		// Token: 0x17004672 RID: 18034
		// (get) Token: 0x06021E3A RID: 138810
		// (set) Token: 0x06021E3B RID: 138811
		EAstNodeType NodeType { get; set; }

		// Token: 0x17004673 RID: 18035
		// (get) Token: 0x06021E3C RID: 138812
		// (set) Token: 0x06021E3D RID: 138813
		IAstNode[] Value { get; set; }
	}
}

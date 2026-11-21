using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003419 RID: 13337
	[NullableContext(1)]
	public interface IUnaryOperatorNode
	{
		// Token: 0x17004677 RID: 18039
		// (get) Token: 0x06021E44 RID: 138820
		// (set) Token: 0x06021E45 RID: 138821
		EAstNodeType NodeType { get; set; }

		// Token: 0x17004678 RID: 18040
		// (get) Token: 0x06021E46 RID: 138822
		// (set) Token: 0x06021E47 RID: 138823
		string Operator { get; set; }

		// Token: 0x17004679 RID: 18041
		// (get) Token: 0x06021E48 RID: 138824
		// (set) Token: 0x06021E49 RID: 138825
		IAstNode[] Args { get; set; }
	}
}

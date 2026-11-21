using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003415 RID: 13333
	[NullableContext(1)]
	public interface IStringNode
	{
		// Token: 0x1700466E RID: 18030
		// (get) Token: 0x06021E32 RID: 138802
		// (set) Token: 0x06021E33 RID: 138803
		EAstNodeType NodeType { get; set; }

		// Token: 0x1700466F RID: 18031
		// (get) Token: 0x06021E34 RID: 138804
		// (set) Token: 0x06021E35 RID: 138805
		string Value { get; set; }
	}
}

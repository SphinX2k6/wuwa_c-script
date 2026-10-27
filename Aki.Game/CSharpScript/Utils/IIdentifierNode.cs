using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x020044F8 RID: 17656
	[NullableContext(1)]
	public interface IIdentifierNode
	{
		// Token: 0x170073C2 RID: 29634
		// (get) Token: 0x0602D77A RID: 186234
		// (set) Token: 0x0602D77B RID: 186235
		EAstNodeType NodeType { get; set; }

		// Token: 0x170073C3 RID: 29635
		// (get) Token: 0x0602D77C RID: 186236
		// (set) Token: 0x0602D77D RID: 186237
		string Value { get; set; }
	}
}

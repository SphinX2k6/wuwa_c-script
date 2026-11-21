using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x0200341A RID: 13338
	[NullableContext(1)]
	public interface IIdentifierNode
	{
		// Token: 0x1700467A RID: 18042
		// (get) Token: 0x06021E4A RID: 138826
		// (set) Token: 0x06021E4B RID: 138827
		EAstNodeType NodeType { get; set; }

		// Token: 0x1700467B RID: 18043
		// (get) Token: 0x06021E4C RID: 138828
		// (set) Token: 0x06021E4D RID: 138829
		string Value { get; set; }
	}
}

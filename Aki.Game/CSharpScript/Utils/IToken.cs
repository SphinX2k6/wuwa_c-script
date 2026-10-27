using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x020044ED RID: 17645
	[NullableContext(1)]
	public interface IToken
	{
		// Token: 0x170073AE RID: 29614
		// (get) Token: 0x0602D74B RID: 186187
		// (set) Token: 0x0602D74C RID: 186188
		ETokenType TokenType { get; set; }

		// Token: 0x170073AF RID: 29615
		// (get) Token: 0x0602D74D RID: 186189
		// (set) Token: 0x0602D74E RID: 186190
		string TokenString { get; set; }
	}
}

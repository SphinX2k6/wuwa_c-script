using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x0200340F RID: 13327
	[NullableContext(1)]
	public interface IToken
	{
		// Token: 0x17004666 RID: 18022
		// (get) Token: 0x06021E1B RID: 138779
		// (set) Token: 0x06021E1C RID: 138780
		ETokenType TokenType { get; set; }

		// Token: 0x17004667 RID: 18023
		// (get) Token: 0x06021E1D RID: 138781
		// (set) Token: 0x06021E1E RID: 138782
		string TokenString { get; set; }
	}
}

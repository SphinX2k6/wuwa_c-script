using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003410 RID: 13328
	[NullableContext(1)]
	[Nullable(0)]
	public class Token : IToken
	{
		// Token: 0x17004668 RID: 18024
		// (get) Token: 0x06021E1F RID: 138783 RVA: 0x0096EB89 File Offset: 0x0096CD89
		// (set) Token: 0x06021E20 RID: 138784 RVA: 0x0096EB91 File Offset: 0x0096CD91
		public ETokenType TokenType { get; set; }

		// Token: 0x17004669 RID: 18025
		// (get) Token: 0x06021E21 RID: 138785 RVA: 0x0096EB9A File Offset: 0x0096CD9A
		// (set) Token: 0x06021E22 RID: 138786 RVA: 0x0096EBA2 File Offset: 0x0096CDA2
		public string TokenString { get; set; }
	}
}

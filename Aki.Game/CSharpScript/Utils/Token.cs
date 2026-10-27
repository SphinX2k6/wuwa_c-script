using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x020044EE RID: 17646
	[NullableContext(1)]
	[Nullable(0)]
	public class Token : IToken
	{
		// Token: 0x170073B0 RID: 29616
		// (get) Token: 0x0602D74F RID: 186191 RVA: 0x00A42D79 File Offset: 0x00A40F79
		// (set) Token: 0x0602D750 RID: 186192 RVA: 0x00A42D81 File Offset: 0x00A40F81
		public ETokenType TokenType { get; set; }

		// Token: 0x170073B1 RID: 29617
		// (get) Token: 0x0602D751 RID: 186193 RVA: 0x00A42D8A File Offset: 0x00A40F8A
		// (set) Token: 0x0602D752 RID: 186194 RVA: 0x00A42D92 File Offset: 0x00A40F92
		public string TokenString { get; set; }
	}
}

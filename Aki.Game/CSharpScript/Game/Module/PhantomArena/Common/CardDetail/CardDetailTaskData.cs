using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005227 RID: 21031
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailTaskData : ICardDetailTaskData
	{
		// Token: 0x17008233 RID: 33331
		// (get) Token: 0x06035C33 RID: 220211 RVA: 0x00CB95E7 File Offset: 0x00CB77E7
		// (set) Token: 0x06035C34 RID: 220212 RVA: 0x00CB95EF File Offset: 0x00CB77EF
		public string Desc { get; set; }

		// Token: 0x17008234 RID: 33332
		// (get) Token: 0x06035C35 RID: 220213 RVA: 0x00CB95F8 File Offset: 0x00CB77F8
		// (set) Token: 0x06035C36 RID: 220214 RVA: 0x00CB9600 File Offset: 0x00CB7800
		public int CurrentProgress { get; set; }
	}
}

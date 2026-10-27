using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005216 RID: 21014
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailLockData : ICardDetailLockData
	{
		// Token: 0x1700820F RID: 33295
		// (get) Token: 0x06035BD6 RID: 220118 RVA: 0x00CB9060 File Offset: 0x00CB7260
		// (set) Token: 0x06035BD7 RID: 220119 RVA: 0x00CB9068 File Offset: 0x00CB7268
		public string Desc { get; set; }

		// Token: 0x17008210 RID: 33296
		// (get) Token: 0x06035BD8 RID: 220120 RVA: 0x00CB9071 File Offset: 0x00CB7271
		// (set) Token: 0x06035BD9 RID: 220121 RVA: 0x00CB9079 File Offset: 0x00CB7279
		public int RemainRound { get; set; }
	}
}

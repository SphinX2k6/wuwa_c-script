using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005215 RID: 21013
	[NullableContext(1)]
	public interface ICardDetailLockData
	{
		// Token: 0x1700820D RID: 33293
		// (get) Token: 0x06035BD2 RID: 220114
		// (set) Token: 0x06035BD3 RID: 220115
		string Desc { get; set; }

		// Token: 0x1700820E RID: 33294
		// (get) Token: 0x06035BD4 RID: 220116
		// (set) Token: 0x06035BD5 RID: 220117
		int RemainRound { get; set; }
	}
}

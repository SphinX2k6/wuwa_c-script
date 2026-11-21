using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041E5 RID: 16869
	[NullableContext(1)]
	public interface ICardDetailLockData
	{
		// Token: 0x170055CD RID: 21965
		// (get) Token: 0x0602AACD RID: 174797
		// (set) Token: 0x0602AACE RID: 174798
		string Desc { get; set; }

		// Token: 0x170055CE RID: 21966
		// (get) Token: 0x0602AACF RID: 174799
		// (set) Token: 0x0602AAD0 RID: 174800
		int RemainRound { get; set; }
	}
}

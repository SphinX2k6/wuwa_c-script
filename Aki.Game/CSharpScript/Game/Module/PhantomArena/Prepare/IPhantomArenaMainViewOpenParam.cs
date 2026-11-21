using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x02004112 RID: 16658
	[NullableContext(2)]
	public interface IPhantomArenaMainViewOpenParam
	{
		// Token: 0x17005462 RID: 21602
		// (get) Token: 0x0602A145 RID: 172357
		// (set) Token: 0x0602A146 RID: 172358
		int ChallengeId { get; set; }

		// Token: 0x17005463 RID: 21603
		// (get) Token: 0x0602A147 RID: 172359
		// (set) Token: 0x0602A148 RID: 172360
		EPhantomArenaChildViewName OpenView { get; set; }

		// Token: 0x17005464 RID: 21604
		// (get) Token: 0x0602A149 RID: 172361
		// (set) Token: 0x0602A14A RID: 172362
		int ActivityId { get; set; }

		// Token: 0x17005465 RID: 21605
		// (get) Token: 0x0602A14B RID: 172363
		// (set) Token: 0x0602A14C RID: 172364
		DeckInfo RecommendDeck { get; set; }
	}
}

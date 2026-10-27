using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x02005142 RID: 20802
	[NullableContext(2)]
	public interface IPhantomArenaMainViewOpenParam
	{
		// Token: 0x170080A2 RID: 32930
		// (get) Token: 0x06035249 RID: 217673
		// (set) Token: 0x0603524A RID: 217674
		int ChallengeId { get; set; }

		// Token: 0x170080A3 RID: 32931
		// (get) Token: 0x0603524B RID: 217675
		// (set) Token: 0x0603524C RID: 217676
		EPhantomArenaChildViewName OpenView { get; set; }

		// Token: 0x170080A4 RID: 32932
		// (get) Token: 0x0603524D RID: 217677
		// (set) Token: 0x0603524E RID: 217678
		int ActivityId { get; set; }

		// Token: 0x170080A5 RID: 32933
		// (get) Token: 0x0603524F RID: 217679
		// (set) Token: 0x06035250 RID: 217680
		DeckInfo RecommendDeck { get; set; }
	}
}

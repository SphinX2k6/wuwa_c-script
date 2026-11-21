using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x02004113 RID: 16659
	[NullableContext(2)]
	[Nullable(0)]
	public class PhantomArenaMainViewOpenParam : IPhantomArenaMainViewOpenParam
	{
		// Token: 0x17005466 RID: 21606
		// (get) Token: 0x0602A14D RID: 172365 RVA: 0x00BE5D16 File Offset: 0x00BE3F16
		// (set) Token: 0x0602A14E RID: 172366 RVA: 0x00BE5D1E File Offset: 0x00BE3F1E
		public int ChallengeId { get; set; }

		// Token: 0x17005467 RID: 21607
		// (get) Token: 0x0602A14F RID: 172367 RVA: 0x00BE5D27 File Offset: 0x00BE3F27
		// (set) Token: 0x0602A150 RID: 172368 RVA: 0x00BE5D2F File Offset: 0x00BE3F2F
		public EPhantomArenaChildViewName OpenView { get; set; }

		// Token: 0x17005468 RID: 21608
		// (get) Token: 0x0602A151 RID: 172369 RVA: 0x00BE5D38 File Offset: 0x00BE3F38
		// (set) Token: 0x0602A152 RID: 172370 RVA: 0x00BE5D40 File Offset: 0x00BE3F40
		public int ActivityId { get; set; }

		// Token: 0x17005469 RID: 21609
		// (get) Token: 0x0602A153 RID: 172371 RVA: 0x00BE5D49 File Offset: 0x00BE3F49
		// (set) Token: 0x0602A154 RID: 172372 RVA: 0x00BE5D51 File Offset: 0x00BE3F51
		public DeckInfo RecommendDeck { get; set; }
	}
}

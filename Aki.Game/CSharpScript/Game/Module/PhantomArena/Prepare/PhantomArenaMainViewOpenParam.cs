using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x02005143 RID: 20803
	[NullableContext(2)]
	[Nullable(0)]
	public class PhantomArenaMainViewOpenParam : IPhantomArenaMainViewOpenParam
	{
		// Token: 0x170080A6 RID: 32934
		// (get) Token: 0x06035251 RID: 217681 RVA: 0x00C98816 File Offset: 0x00C96A16
		// (set) Token: 0x06035252 RID: 217682 RVA: 0x00C9881E File Offset: 0x00C96A1E
		public int ChallengeId { get; set; }

		// Token: 0x170080A7 RID: 32935
		// (get) Token: 0x06035253 RID: 217683 RVA: 0x00C98827 File Offset: 0x00C96A27
		// (set) Token: 0x06035254 RID: 217684 RVA: 0x00C9882F File Offset: 0x00C96A2F
		public EPhantomArenaChildViewName OpenView { get; set; }

		// Token: 0x170080A8 RID: 32936
		// (get) Token: 0x06035255 RID: 217685 RVA: 0x00C98838 File Offset: 0x00C96A38
		// (set) Token: 0x06035256 RID: 217686 RVA: 0x00C98840 File Offset: 0x00C96A40
		public int ActivityId { get; set; }

		// Token: 0x170080A9 RID: 32937
		// (get) Token: 0x06035257 RID: 217687 RVA: 0x00C98849 File Offset: 0x00C96A49
		// (set) Token: 0x06035258 RID: 217688 RVA: 0x00C98851 File Offset: 0x00C96A51
		public DeckInfo RecommendDeck { get; set; }
	}
}

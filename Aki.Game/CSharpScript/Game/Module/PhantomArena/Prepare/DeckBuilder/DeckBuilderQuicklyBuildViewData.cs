using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004171 RID: 16753
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderQuicklyBuildViewData : IDeckBuilderQuicklyBuildViewData
	{
		// Token: 0x1700555F RID: 21855
		// (get) Token: 0x0602A672 RID: 173682 RVA: 0x00BF5A18 File Offset: 0x00BF3C18
		// (set) Token: 0x0602A673 RID: 173683 RVA: 0x00BF5A20 File Offset: 0x00BF3C20
		public int ActivityId { get; set; }

		// Token: 0x17005560 RID: 21856
		// (get) Token: 0x0602A674 RID: 173684 RVA: 0x00BF5A29 File Offset: 0x00BF3C29
		// (set) Token: 0x0602A675 RID: 173685 RVA: 0x00BF5A31 File Offset: 0x00BF3C31
		public Action<DeckInfo> ConfirmCallback { get; set; }
	}
}

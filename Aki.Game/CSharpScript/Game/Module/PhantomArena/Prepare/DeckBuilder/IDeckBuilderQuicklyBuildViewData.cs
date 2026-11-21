using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004170 RID: 16752
	[NullableContext(1)]
	public interface IDeckBuilderQuicklyBuildViewData
	{
		// Token: 0x1700555D RID: 21853
		// (get) Token: 0x0602A66E RID: 173678
		// (set) Token: 0x0602A66F RID: 173679
		int ActivityId { get; set; }

		// Token: 0x1700555E RID: 21854
		// (get) Token: 0x0602A670 RID: 173680
		// (set) Token: 0x0602A671 RID: 173681
		Action<DeckInfo> ConfirmCallback { get; set; }
	}
}

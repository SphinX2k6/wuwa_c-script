using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x020051A0 RID: 20896
	[NullableContext(1)]
	public interface IDeckBuilderQuicklyBuildViewData
	{
		// Token: 0x1700819D RID: 33181
		// (get) Token: 0x06035773 RID: 218995
		// (set) Token: 0x06035774 RID: 218996
		int ActivityId { get; set; }

		// Token: 0x1700819E RID: 33182
		// (get) Token: 0x06035775 RID: 218997
		// (set) Token: 0x06035776 RID: 218998
		Action<DeckInfo> ConfirmCallback { get; set; }
	}
}

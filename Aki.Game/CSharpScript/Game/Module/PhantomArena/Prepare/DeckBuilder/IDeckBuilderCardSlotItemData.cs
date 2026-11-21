using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004164 RID: 16740
	[NullableContext(1)]
	public interface IDeckBuilderCardSlotItemData
	{
		// Token: 0x17005519 RID: 21785
		// (get) Token: 0x0602A581 RID: 173441
		// (set) Token: 0x0602A582 RID: 173442
		DeckCardSlotInfo SlotInfo { get; set; }

		// Token: 0x1700551A RID: 21786
		// (get) Token: 0x0602A583 RID: 173443
		// (set) Token: 0x0602A584 RID: 173444
		bool Locked { get; set; }

		// Token: 0x1700551B RID: 21787
		// (get) Token: 0x0602A585 RID: 173445
		// (set) Token: 0x0602A586 RID: 173446
		bool RedDotState { get; set; }

		// Token: 0x1700551C RID: 21788
		// (get) Token: 0x0602A587 RID: 173447
		// (set) Token: 0x0602A588 RID: 173448
		bool OutlookUnlocked { get; set; }

		// Token: 0x1700551D RID: 21789
		// (get) Token: 0x0602A589 RID: 173449
		// (set) Token: 0x0602A58A RID: 173450
		bool NeedPlayAddAnim { get; set; }
	}
}

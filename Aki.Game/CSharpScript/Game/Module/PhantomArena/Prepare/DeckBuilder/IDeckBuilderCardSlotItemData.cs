using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02005194 RID: 20884
	[NullableContext(1)]
	public interface IDeckBuilderCardSlotItemData
	{
		// Token: 0x17008159 RID: 33113
		// (get) Token: 0x06035686 RID: 218758
		// (set) Token: 0x06035687 RID: 218759
		DeckCardSlotInfo SlotInfo { get; set; }

		// Token: 0x1700815A RID: 33114
		// (get) Token: 0x06035688 RID: 218760
		// (set) Token: 0x06035689 RID: 218761
		bool Locked { get; set; }

		// Token: 0x1700815B RID: 33115
		// (get) Token: 0x0603568A RID: 218762
		// (set) Token: 0x0603568B RID: 218763
		bool RedDotState { get; set; }

		// Token: 0x1700815C RID: 33116
		// (get) Token: 0x0603568C RID: 218764
		// (set) Token: 0x0603568D RID: 218765
		bool OutlookUnlocked { get; set; }

		// Token: 0x1700815D RID: 33117
		// (get) Token: 0x0603568E RID: 218766
		// (set) Token: 0x0603568F RID: 218767
		bool NeedPlayAddAnim { get; set; }
	}
}

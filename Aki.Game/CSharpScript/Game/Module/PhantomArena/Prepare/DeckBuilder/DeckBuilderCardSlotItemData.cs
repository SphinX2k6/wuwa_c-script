using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004165 RID: 16741
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderCardSlotItemData : IDeckBuilderCardSlotItemData
	{
		// Token: 0x1700551E RID: 21790
		// (get) Token: 0x0602A58B RID: 173451 RVA: 0x00BF38FF File Offset: 0x00BF1AFF
		// (set) Token: 0x0602A58C RID: 173452 RVA: 0x00BF3907 File Offset: 0x00BF1B07
		public DeckCardSlotInfo SlotInfo { get; set; }

		// Token: 0x1700551F RID: 21791
		// (get) Token: 0x0602A58D RID: 173453 RVA: 0x00BF3910 File Offset: 0x00BF1B10
		// (set) Token: 0x0602A58E RID: 173454 RVA: 0x00BF3918 File Offset: 0x00BF1B18
		public bool Locked { get; set; }

		// Token: 0x17005520 RID: 21792
		// (get) Token: 0x0602A58F RID: 173455 RVA: 0x00BF3921 File Offset: 0x00BF1B21
		// (set) Token: 0x0602A590 RID: 173456 RVA: 0x00BF3929 File Offset: 0x00BF1B29
		public bool RedDotState { get; set; }

		// Token: 0x17005521 RID: 21793
		// (get) Token: 0x0602A591 RID: 173457 RVA: 0x00BF3932 File Offset: 0x00BF1B32
		// (set) Token: 0x0602A592 RID: 173458 RVA: 0x00BF393A File Offset: 0x00BF1B3A
		public bool OutlookUnlocked { get; set; }

		// Token: 0x17005522 RID: 21794
		// (get) Token: 0x0602A593 RID: 173459 RVA: 0x00BF3943 File Offset: 0x00BF1B43
		// (set) Token: 0x0602A594 RID: 173460 RVA: 0x00BF394B File Offset: 0x00BF1B4B
		public bool NeedPlayAddAnim { get; set; }
	}
}

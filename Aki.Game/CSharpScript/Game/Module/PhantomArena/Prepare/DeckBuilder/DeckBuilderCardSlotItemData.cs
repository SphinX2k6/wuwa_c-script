using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02005195 RID: 20885
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderCardSlotItemData : IDeckBuilderCardSlotItemData
	{
		// Token: 0x1700815E RID: 33118
		// (get) Token: 0x06035690 RID: 218768 RVA: 0x00CA634B File Offset: 0x00CA454B
		// (set) Token: 0x06035691 RID: 218769 RVA: 0x00CA6353 File Offset: 0x00CA4553
		public DeckCardSlotInfo SlotInfo { get; set; }

		// Token: 0x1700815F RID: 33119
		// (get) Token: 0x06035692 RID: 218770 RVA: 0x00CA635C File Offset: 0x00CA455C
		// (set) Token: 0x06035693 RID: 218771 RVA: 0x00CA6364 File Offset: 0x00CA4564
		public bool Locked { get; set; }

		// Token: 0x17008160 RID: 33120
		// (get) Token: 0x06035694 RID: 218772 RVA: 0x00CA636D File Offset: 0x00CA456D
		// (set) Token: 0x06035695 RID: 218773 RVA: 0x00CA6375 File Offset: 0x00CA4575
		public bool RedDotState { get; set; }

		// Token: 0x17008161 RID: 33121
		// (get) Token: 0x06035696 RID: 218774 RVA: 0x00CA637E File Offset: 0x00CA457E
		// (set) Token: 0x06035697 RID: 218775 RVA: 0x00CA6386 File Offset: 0x00CA4586
		public bool OutlookUnlocked { get; set; }

		// Token: 0x17008162 RID: 33122
		// (get) Token: 0x06035698 RID: 218776 RVA: 0x00CA638F File Offset: 0x00CA458F
		// (set) Token: 0x06035699 RID: 218777 RVA: 0x00CA6397 File Offset: 0x00CA4597
		public bool NeedPlayAddAnim { get; set; }
	}
}

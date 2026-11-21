using System;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004157 RID: 16727
	public class DeckBuilderCardDeleteFilterItemData : IDeckBuilderCardDeleteFilterItemData
	{
		// Token: 0x17005500 RID: 21760
		// (get) Token: 0x0602A516 RID: 173334 RVA: 0x00BF2627 File Offset: 0x00BF0827
		// (set) Token: 0x0602A517 RID: 173335 RVA: 0x00BF262F File Offset: 0x00BF082F
		public ECardElement Element { get; set; }

		// Token: 0x17005501 RID: 21761
		// (get) Token: 0x0602A518 RID: 173336 RVA: 0x00BF2638 File Offset: 0x00BF0838
		// (set) Token: 0x0602A519 RID: 173337 RVA: 0x00BF2640 File Offset: 0x00BF0840
		public bool Enabled { get; set; }

		// Token: 0x17005502 RID: 21762
		// (get) Token: 0x0602A51A RID: 173338 RVA: 0x00BF2649 File Offset: 0x00BF0849
		// (set) Token: 0x0602A51B RID: 173339 RVA: 0x00BF2651 File Offset: 0x00BF0851
		public bool Selected { get; set; }
	}
}

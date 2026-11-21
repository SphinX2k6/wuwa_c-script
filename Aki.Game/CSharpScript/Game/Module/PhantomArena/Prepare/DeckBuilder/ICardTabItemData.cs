using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200416B RID: 16747
	[NullableContext(1)]
	public interface ICardTabItemData
	{
		// Token: 0x1700554F RID: 21839
		// (get) Token: 0x0602A637 RID: 173623
		// (set) Token: 0x0602A638 RID: 173624
		ECardTabType TabType { get; set; }

		// Token: 0x17005550 RID: 21840
		// (get) Token: 0x0602A639 RID: 173625
		// (set) Token: 0x0602A63A RID: 173626
		ECardElement? ElementConfigId { get; set; }

		// Token: 0x17005551 RID: 21841
		// (get) Token: 0x0602A63B RID: 173627
		// (set) Token: 0x0602A63C RID: 173628
		string TabTexturePath { get; set; }

		// Token: 0x17005552 RID: 21842
		// (get) Token: 0x0602A63D RID: 173629
		// (set) Token: 0x0602A63E RID: 173630
		string TabElementColor { get; set; }

		// Token: 0x17005553 RID: 21843
		// (get) Token: 0x0602A63F RID: 173631
		// (set) Token: 0x0602A640 RID: 173632
		bool ShowRedDot { get; set; }

		// Token: 0x17005554 RID: 21844
		// (get) Token: 0x0602A641 RID: 173633
		// (set) Token: 0x0602A642 RID: 173634
		bool IsDisable { get; set; }

		// Token: 0x17005555 RID: 21845
		// (get) Token: 0x0602A643 RID: 173635
		// (set) Token: 0x0602A644 RID: 173636
		bool IsArrivedMax { get; set; }
	}
}

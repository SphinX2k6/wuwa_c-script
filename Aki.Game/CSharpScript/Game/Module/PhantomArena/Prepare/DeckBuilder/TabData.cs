using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200518E RID: 20878
	[NullableContext(2)]
	[Nullable(0)]
	public class TabData
	{
		// Token: 0x0401C601 RID: 116225
		public int TabIndex;

		// Token: 0x0401C602 RID: 116226
		[Nullable(1)]
		public string TabNameTextId = string.Empty;

		// Token: 0x0401C603 RID: 116227
		public UiPanelBase Panel;

		// Token: 0x0401C604 RID: 116228
		public IDeckBuilderCardInfoViewPanelSequencePlayer SequencePlayer;

		// Token: 0x0401C605 RID: 116229
		public Action OnShow;
	}
}

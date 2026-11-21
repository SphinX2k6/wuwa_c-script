using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200415E RID: 16734
	[NullableContext(2)]
	[Nullable(0)]
	public class TabData
	{
		// Token: 0x04017036 RID: 94262
		public int TabIndex;

		// Token: 0x04017037 RID: 94263
		[Nullable(1)]
		public string TabNameTextId = string.Empty;

		// Token: 0x04017038 RID: 94264
		public UiPanelBase Panel;

		// Token: 0x04017039 RID: 94265
		public IDeckBuilderCardInfoViewPanelSequencePlayer SequencePlayer;

		// Token: 0x0401703A RID: 94266
		public Action OnShow;
	}
}

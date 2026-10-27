using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200518B RID: 20875
	public class DeckBuilderCardInfoTabItemData
	{
		// Token: 0x0401C5FD RID: 116221
		public int TabIndex;

		// Token: 0x0401C5FE RID: 116222
		[Nullable(1)]
		public string TabNameTextId = string.Empty;

		// Token: 0x0401C5FF RID: 116223
		[Nullable(2)]
		public Action<int> OnSelect;
	}
}

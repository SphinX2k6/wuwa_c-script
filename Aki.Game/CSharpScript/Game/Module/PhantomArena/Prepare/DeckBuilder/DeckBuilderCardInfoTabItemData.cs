using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200415B RID: 16731
	public class DeckBuilderCardInfoTabItemData
	{
		// Token: 0x04017032 RID: 94258
		public int TabIndex;

		// Token: 0x04017033 RID: 94259
		[Nullable(1)]
		public string TabNameTextId = string.Empty;

		// Token: 0x04017034 RID: 94260
		[Nullable(2)]
		public Action<int> OnSelect;
	}
}

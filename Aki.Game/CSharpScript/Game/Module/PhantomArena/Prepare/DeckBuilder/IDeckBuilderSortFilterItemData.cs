using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004175 RID: 16757
	[NullableContext(1)]
	public interface IDeckBuilderSortFilterItemData
	{
		// Token: 0x17005563 RID: 21859
		// (get) Token: 0x0602A698 RID: 173720
		int ConfigId { get; }

		// Token: 0x17005564 RID: 21860
		// (get) Token: 0x0602A699 RID: 173721
		string Name { get; }
	}
}

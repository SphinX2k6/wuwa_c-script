using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x020051A5 RID: 20901
	[NullableContext(1)]
	public interface IDeckBuilderSortFilterItemData
	{
		// Token: 0x170081A3 RID: 33187
		// (get) Token: 0x0603579D RID: 219037
		int ConfigId { get; }

		// Token: 0x170081A4 RID: 33188
		// (get) Token: 0x0603579E RID: 219038
		string Name { get; }
	}
}

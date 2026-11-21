using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004174 RID: 16756
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderSortFilterItemData : IDeckBuilderSortFilterItemData
	{
		// Token: 0x17005561 RID: 21857
		// (get) Token: 0x0602A693 RID: 173715 RVA: 0x00BF60EC File Offset: 0x00BF42EC
		// (set) Token: 0x0602A694 RID: 173716 RVA: 0x00BF60F4 File Offset: 0x00BF42F4
		public int ConfigId { get; set; }

		// Token: 0x17005562 RID: 21858
		// (get) Token: 0x0602A695 RID: 173717 RVA: 0x00BF60FD File Offset: 0x00BF42FD
		// (set) Token: 0x0602A696 RID: 173718 RVA: 0x00BF6105 File Offset: 0x00BF4305
		public string Name { get; set; } = string.Empty;
	}
}

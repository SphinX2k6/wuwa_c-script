using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x020051A4 RID: 20900
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderSortFilterItemData : IDeckBuilderSortFilterItemData
	{
		// Token: 0x170081A1 RID: 33185
		// (get) Token: 0x06035798 RID: 219032 RVA: 0x00CA8AB4 File Offset: 0x00CA6CB4
		// (set) Token: 0x06035799 RID: 219033 RVA: 0x00CA8ABC File Offset: 0x00CA6CBC
		public int ConfigId { get; set; }

		// Token: 0x170081A2 RID: 33186
		// (get) Token: 0x0603579A RID: 219034 RVA: 0x00CA8AC5 File Offset: 0x00CA6CC5
		// (set) Token: 0x0603579B RID: 219035 RVA: 0x00CA8ACD File Offset: 0x00CA6CCD
		public string Name { get; set; } = string.Empty;
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x020051A1 RID: 20897
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderQuicklyBuildViewData : IDeckBuilderQuicklyBuildViewData
	{
		// Token: 0x1700819F RID: 33183
		// (get) Token: 0x06035777 RID: 218999 RVA: 0x00CA83FC File Offset: 0x00CA65FC
		// (set) Token: 0x06035778 RID: 219000 RVA: 0x00CA8404 File Offset: 0x00CA6604
		public int ActivityId { get; set; }

		// Token: 0x170081A0 RID: 33184
		// (get) Token: 0x06035779 RID: 219001 RVA: 0x00CA840D File Offset: 0x00CA660D
		// (set) Token: 0x0603577A RID: 219002 RVA: 0x00CA8415 File Offset: 0x00CA6615
		public Action<DeckInfo> ConfirmCallback { get; set; }
	}
}

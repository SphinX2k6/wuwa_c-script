using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020051E1 RID: 20961
	[NullableContext(1)]
	[Nullable(0)]
	public class CardCheckComponentData : ICardCheckComponentData
	{
		// Token: 0x170081C1 RID: 33217
		// (get) Token: 0x06035A21 RID: 219681 RVA: 0x00CB4B07 File Offset: 0x00CB2D07
		// (set) Token: 0x06035A22 RID: 219682 RVA: 0x00CB4B0F File Offset: 0x00CB2D0F
		public int LeftCount { get; set; }

		// Token: 0x170081C2 RID: 33218
		// (get) Token: 0x06035A23 RID: 219683 RVA: 0x00CB4B18 File Offset: 0x00CB2D18
		// (set) Token: 0x06035A24 RID: 219684 RVA: 0x00CB4B20 File Offset: 0x00CB2D20
		public int MaxCount { get; set; }

		// Token: 0x170081C3 RID: 33219
		// (get) Token: 0x06035A25 RID: 219685 RVA: 0x00CB4B29 File Offset: 0x00CB2D29
		// (set) Token: 0x06035A26 RID: 219686 RVA: 0x00CB4B31 File Offset: 0x00CB2D31
		public Action OnCheckBtnClick { get; set; }
	}
}

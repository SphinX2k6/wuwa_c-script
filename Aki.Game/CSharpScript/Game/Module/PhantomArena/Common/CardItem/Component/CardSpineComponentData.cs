using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020051F3 RID: 20979
	[NullableContext(1)]
	[Nullable(0)]
	public class CardSpineComponentData : ICardSpineComponentData
	{
		// Token: 0x170081D8 RID: 33240
		// (get) Token: 0x06035A89 RID: 219785 RVA: 0x00CB56A2 File Offset: 0x00CB38A2
		// (set) Token: 0x06035A8A RID: 219786 RVA: 0x00CB56AA File Offset: 0x00CB38AA
		public CardSpineData CardSpineData { get; set; }

		// Token: 0x170081D9 RID: 33241
		// (get) Token: 0x06035A8B RID: 219787 RVA: 0x00CB56B3 File Offset: 0x00CB38B3
		// (set) Token: 0x06035A8C RID: 219788 RVA: 0x00CB56BB File Offset: 0x00CB38BB
		public bool ShowSpine { get; set; }
	}
}

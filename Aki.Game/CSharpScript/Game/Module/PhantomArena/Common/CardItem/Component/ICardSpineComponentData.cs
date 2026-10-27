using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020051F2 RID: 20978
	[NullableContext(1)]
	public interface ICardSpineComponentData
	{
		// Token: 0x170081D6 RID: 33238
		// (get) Token: 0x06035A85 RID: 219781
		// (set) Token: 0x06035A86 RID: 219782
		CardSpineData CardSpineData { get; set; }

		// Token: 0x170081D7 RID: 33239
		// (get) Token: 0x06035A87 RID: 219783
		// (set) Token: 0x06035A88 RID: 219784
		bool ShowSpine { get; set; }
	}
}

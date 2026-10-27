using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02005199 RID: 20889
	[NullableContext(1)]
	[Nullable(0)]
	public class SlotAreaInfo
	{
		// Token: 0x0401C647 RID: 116295
		public EPhantomArenaDeckSlotType SlotType;

		// Token: 0x0401C648 RID: 116296
		public UUIExtendToggle Toggle;

		// Token: 0x0401C649 RID: 116297
		public UUIItem MaskItem;

		// Token: 0x0401C64A RID: 116298
		public bool Enabled;
	}
}

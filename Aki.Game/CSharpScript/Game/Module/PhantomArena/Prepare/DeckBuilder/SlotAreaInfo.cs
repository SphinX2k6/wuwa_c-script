using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004169 RID: 16745
	[NullableContext(1)]
	[Nullable(0)]
	public class SlotAreaInfo
	{
		// Token: 0x0401707C RID: 94332
		public EPhantomArenaDeckSlotType SlotType;

		// Token: 0x0401707D RID: 94333
		public UUIExtendToggle Toggle;

		// Token: 0x0401707E RID: 94334
		public UUIItem MaskItem;

		// Token: 0x0401707F RID: 94335
		public bool Enabled;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B53 RID: 6995
	public class IInteractPoint_SetValue
	{
		// Token: 0x04005BA6 RID: 23462
		public int Tag;

		// Token: 0x04005BA7 RID: 23463
		[Nullable(1)]
		public List<IInteractEffect> InteractEffects;

		// Token: 0x04005BA8 RID: 23464
		public bool IsValidPoint;

		// Token: 0x04005BA9 RID: 23465
		public float? ProtectTime;

		// Token: 0x04005BAA RID: 23466
		public bool? CancelRaycast;

		// Token: 0x04005BAB RID: 23467
		[Nullable(2)]
		public IDragInteractPointInteraction InteractionConfig;
	}
}

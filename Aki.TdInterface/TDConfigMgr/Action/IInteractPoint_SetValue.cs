using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D02 RID: 7426
	public class IInteractPoint_SetValue
	{
		// Token: 0x04006045 RID: 24645
		public int Tag;

		// Token: 0x04006046 RID: 24646
		public List<IInteractEffect> InteractEffects;

		// Token: 0x04006047 RID: 24647
		public bool IsValidPoint;

		// Token: 0x04006048 RID: 24648
		public float? ProtectTime;

		// Token: 0x04006049 RID: 24649
		public bool? CancelRaycast;

		// Token: 0x0400604A RID: 24650
		[Nullable(2)]
		public IDragInteractPointInteraction InteractionConfig;
	}
}

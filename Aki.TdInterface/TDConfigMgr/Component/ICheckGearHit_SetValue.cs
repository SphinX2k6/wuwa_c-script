using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200023A RID: 570
	public class ICheckGearHit_SetValue
	{
		// Token: 0x04000A37 RID: 2615
		public int HitIndex;

		// Token: 0x04000A38 RID: 2616
		[Nullable(1)]
		public List<int> AffectIndex;

		// Token: 0x04000A39 RID: 2617
		public EGearHitAffectType AffectType;
	}
}

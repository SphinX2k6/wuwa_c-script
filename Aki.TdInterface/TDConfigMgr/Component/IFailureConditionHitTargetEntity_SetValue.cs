using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200036D RID: 877
	public class IFailureConditionHitTargetEntity_SetValue
	{
		// Token: 0x04000E53 RID: 3667
		public ETargetGearGroupFailureCondition Type;

		// Token: 0x04000E54 RID: 3668
		[Nullable(1)]
		public List<int> EntityIds;
	}
}

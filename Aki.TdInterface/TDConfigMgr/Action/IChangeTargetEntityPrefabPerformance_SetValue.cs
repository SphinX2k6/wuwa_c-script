using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001879 RID: 6265
	public class IChangeTargetEntityPrefabPerformance_SetValue
	{
		// Token: 0x040054E1 RID: 21729
		public EChangeEntityPrefabPerformanceType Type;

		// Token: 0x040054E2 RID: 21730
		public int EntityId;

		// Token: 0x040054E3 RID: 21731
		[Nullable(1)]
		public string PerformanceTag;
	}
}

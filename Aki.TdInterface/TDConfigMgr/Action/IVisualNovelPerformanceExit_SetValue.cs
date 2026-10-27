using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002086 RID: 8326
	public class IVisualNovelPerformanceExit_SetValue
	{
		// Token: 0x04006DDD RID: 28125
		public EVisualNovelPerformanceType Type;

		// Token: 0x04006DDE RID: 28126
		public float? StartTime;

		// Token: 0x04006DDF RID: 28127
		public int WhoId;

		// Token: 0x04006DE0 RID: 28128
		public bool? AllExit;

		// Token: 0x04006DE1 RID: 28129
		public float? FadeOutTime;

		// Token: 0x04006DE2 RID: 28130
		[Nullable(2)]
		public IVisualNovelRoleConfig RoleConfig;
	}
}

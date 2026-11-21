using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022D1 RID: 8913
	public class IVisualNovelPerformanceExit_SetValue
	{
		// Token: 0x040073EA RID: 29674
		public EVisualNovelPerformanceType Type;

		// Token: 0x040073EB RID: 29675
		public float? StartTime;

		// Token: 0x040073EC RID: 29676
		public int WhoId;

		// Token: 0x040073ED RID: 29677
		public bool? AllExit;

		// Token: 0x040073EE RID: 29678
		public float? FadeOutTime;

		// Token: 0x040073EF RID: 29679
		[Nullable(2)]
		public IVisualNovelRoleConfig RoleConfig;
	}
}

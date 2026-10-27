using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002082 RID: 8322
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelPerformanceEnter_SetValue
	{
		// Token: 0x04006DCC RID: 28108
		public EVisualNovelPerformanceType Type;

		// Token: 0x04006DCD RID: 28109
		public float? StartTime;

		// Token: 0x04006DCE RID: 28110
		public int WhoId;

		// Token: 0x04006DCF RID: 28111
		public IVisualNovelPortraitTransform Transform;

		// Token: 0x04006DD0 RID: 28112
		public float? FadeInTime;

		// Token: 0x04006DD1 RID: 28113
		public IVisualNovelRoleConfig RoleConfig;
	}
}

using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200208A RID: 8330
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelPerformanceModifyRole_SetValue
	{
		// Token: 0x04006DEF RID: 28143
		public EVisualNovelPerformanceType Type;

		// Token: 0x04006DF0 RID: 28144
		public float? StartTime;

		// Token: 0x04006DF1 RID: 28145
		public int WhoId;

		// Token: 0x04006DF2 RID: 28146
		public IVisualNovelPortraitTransform Transform;

		// Token: 0x04006DF3 RID: 28147
		public IVisualNovelRoleConfig RoleConfig;
	}
}

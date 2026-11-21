using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022CD RID: 8909
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelPerformanceEnter_SetValue
	{
		// Token: 0x040073D9 RID: 29657
		public EVisualNovelPerformanceType Type;

		// Token: 0x040073DA RID: 29658
		public float? StartTime;

		// Token: 0x040073DB RID: 29659
		public int WhoId;

		// Token: 0x040073DC RID: 29660
		public IVisualNovelPortraitTransform Transform;

		// Token: 0x040073DD RID: 29661
		public float? FadeInTime;

		// Token: 0x040073DE RID: 29662
		public IVisualNovelRoleConfig RoleConfig;
	}
}

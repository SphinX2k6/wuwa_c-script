using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022D5 RID: 8917
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelPerformanceModifyRole_SetValue
	{
		// Token: 0x040073FC RID: 29692
		public EVisualNovelPerformanceType Type;

		// Token: 0x040073FD RID: 29693
		public float? StartTime;

		// Token: 0x040073FE RID: 29694
		public int WhoId;

		// Token: 0x040073FF RID: 29695
		public IVisualNovelPortraitTransform Transform;

		// Token: 0x04007400 RID: 29696
		public IVisualNovelRoleConfig RoleConfig;
	}
}

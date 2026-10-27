using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014A4 RID: 5284
	public class AvgMoveRole_SetValue
	{
		// Token: 0x040045EE RID: 17902
		public int RoleId;

		// Token: 0x040045EF RID: 17903
		public EAvgRoleAnimationType AnimationType;

		// Token: 0x040045F0 RID: 17904
		public bool? IsAnimationLoop;

		// Token: 0x040045F1 RID: 17905
		public EAvgRolePosition TargetPosition;

		// Token: 0x040045F2 RID: 17906
		[Nullable(1)]
		public IEaseData EaseCurve;
	}
}

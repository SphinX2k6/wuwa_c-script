using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015FD RID: 5629
	public class AvgMoveRole_SetValue
	{
		// Token: 0x04004989 RID: 18825
		public int RoleId;

		// Token: 0x0400498A RID: 18826
		public EAvgRoleAnimationType AnimationType;

		// Token: 0x0400498B RID: 18827
		public bool? IsAnimationLoop;

		// Token: 0x0400498C RID: 18828
		public EAvgRolePosition TargetPosition;

		// Token: 0x0400498D RID: 18829
		public IEaseData EaseCurve;
	}
}

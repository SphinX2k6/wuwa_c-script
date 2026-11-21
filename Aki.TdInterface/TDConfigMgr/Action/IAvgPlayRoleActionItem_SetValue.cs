using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001978 RID: 6520
	public class IAvgPlayRoleActionItem_SetValue
	{
		// Token: 0x040057BD RID: 22461
		public EAvgPlayRoleActionType ActionType;

		// Token: 0x040057BE RID: 22462
		public int RoleId;

		// Token: 0x040057BF RID: 22463
		public EAvgRolePosition? PositionConfig;

		// Token: 0x040057C0 RID: 22464
		public EAvgRoleAnimationType AnimationType;

		// Token: 0x040057C1 RID: 22465
		public bool? IsAnimationLoop;

		// Token: 0x040057C2 RID: 22466
		public EAvgVisualEffect? VisualEffect;
	}
}

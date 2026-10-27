using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017EF RID: 6127
	public class IAvgPlayRoleActionItem_SetValue
	{
		// Token: 0x04005375 RID: 21365
		public EAvgPlayRoleActionType ActionType;

		// Token: 0x04005376 RID: 21366
		public int RoleId;

		// Token: 0x04005377 RID: 21367
		public EAvgRolePosition? PositionConfig;

		// Token: 0x04005378 RID: 21368
		public EAvgRoleAnimationType AnimationType;

		// Token: 0x04005379 RID: 21369
		public bool? IsAnimationLoop;

		// Token: 0x0400537A RID: 21370
		public EAvgVisualEffect? VisualEffect;
	}
}

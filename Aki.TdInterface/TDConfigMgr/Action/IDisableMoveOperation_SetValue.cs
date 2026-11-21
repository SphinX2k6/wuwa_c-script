using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B3C RID: 6972
	public class IDisableMoveOperation_SetValue
	{
		// Token: 0x04005BEA RID: 23530
		public EMoveOperationType Type;

		// Token: 0x04005BEB RID: 23531
		public bool Forward;

		// Token: 0x04005BEC RID: 23532
		public bool Back;

		// Token: 0x04005BED RID: 23533
		public bool Left;

		// Token: 0x04005BEE RID: 23534
		public bool Right;

		// Token: 0x04005BEF RID: 23535
		public bool? ForceWalk;

		// Token: 0x04005BF0 RID: 23536
		public bool? ForceJog;

		// Token: 0x04005BF1 RID: 23537
		public bool? ForbidSprint;

		// Token: 0x04005BF2 RID: 23538
		public bool? ForbidAndDisableSprint;

		// Token: 0x04005BF3 RID: 23539
		public bool? ForbidAndDisableMotorcycleSprint;

		// Token: 0x04005BF4 RID: 23540
		public bool? DisableClimbAndStep;
	}
}

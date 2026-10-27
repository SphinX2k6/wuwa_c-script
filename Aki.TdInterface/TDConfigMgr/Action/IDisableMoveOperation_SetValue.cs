using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019B3 RID: 6579
	public class IDisableMoveOperation_SetValue
	{
		// Token: 0x0400579B RID: 22427
		public EMoveOperationType Type;

		// Token: 0x0400579C RID: 22428
		public bool Forward;

		// Token: 0x0400579D RID: 22429
		public bool Back;

		// Token: 0x0400579E RID: 22430
		public bool Left;

		// Token: 0x0400579F RID: 22431
		public bool Right;

		// Token: 0x040057A0 RID: 22432
		public bool? ForceWalk;

		// Token: 0x040057A1 RID: 22433
		public bool? ForceJog;

		// Token: 0x040057A2 RID: 22434
		public bool? ForbidSprint;

		// Token: 0x040057A3 RID: 22435
		public bool? ForbidAndDisableSprint;

		// Token: 0x040057A4 RID: 22436
		public bool? ForbidAndDisableMotorcycleSprint;

		// Token: 0x040057A5 RID: 22437
		public bool? DisableClimbAndStep;
	}
}

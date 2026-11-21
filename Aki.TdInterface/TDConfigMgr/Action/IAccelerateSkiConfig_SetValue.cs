using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018D4 RID: 6356
	public class IAccelerateSkiConfig_SetValue
	{
		// Token: 0x040054B6 RID: 21686
		public ESkiConfig Type;

		// Token: 0x040054B7 RID: 21687
		public ITargetEntityType Target;

		// Token: 0x040054B8 RID: 21688
		public int Duration;

		// Token: 0x040054B9 RID: 21689
		public int LimitSpeed;

		// Token: 0x040054BA RID: 21690
		public int Acceleration;

		// Token: 0x040054BB RID: 21691
		public int? InstantSpeed;
	}
}

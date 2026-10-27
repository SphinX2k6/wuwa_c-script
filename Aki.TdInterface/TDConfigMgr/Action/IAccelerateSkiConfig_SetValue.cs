using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001753 RID: 5971
	public class IAccelerateSkiConfig_SetValue
	{
		// Token: 0x04005080 RID: 20608
		public ESkiConfig Type;

		// Token: 0x04005081 RID: 20609
		[Nullable(1)]
		public ITargetEntityType Target;

		// Token: 0x04005082 RID: 20610
		public int Duration;

		// Token: 0x04005083 RID: 20611
		public int LimitSpeed;

		// Token: 0x04005084 RID: 20612
		public int Acceleration;

		// Token: 0x04005085 RID: 20613
		public int? InstantSpeed;
	}
}

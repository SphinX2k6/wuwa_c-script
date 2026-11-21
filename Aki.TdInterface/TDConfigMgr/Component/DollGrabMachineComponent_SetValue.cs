using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000053 RID: 83
	public class DollGrabMachineComponent_SetValue
	{
		// Token: 0x040001CC RID: 460
		public bool? Disabled;

		// Token: 0x040001CD RID: 461
		public bool? EdIsLocked;

		// Token: 0x040001CE RID: 462
		public EDollGrabShowcaseBelongType BelongType;

		// Token: 0x040001CF RID: 463
		public float TimeLimit;

		// Token: 0x040001D0 RID: 464
		public float? PlayCost;

		// Token: 0x040001D1 RID: 465
		public List<IDollGrabItem> Items;

		// Token: 0x040001D2 RID: 466
		[Nullable(2)]
		public IDollGrabInfiniteModeData InfiniteModeData;

		// Token: 0x040001D3 RID: 467
		[Nullable(2)]
		public string AkEvent;
	}
}

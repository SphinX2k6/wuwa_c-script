using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000053 RID: 83
	[NullableContext(2)]
	[Nullable(0)]
	public class DollGrabMachineComponent_SetValue
	{
		// Token: 0x040001C7 RID: 455
		public bool? Disabled;

		// Token: 0x040001C8 RID: 456
		public bool? EdIsLocked;

		// Token: 0x040001C9 RID: 457
		public EDollGrabShowcaseBelongType BelongType;

		// Token: 0x040001CA RID: 458
		public float TimeLimit;

		// Token: 0x040001CB RID: 459
		public float? PlayCost;

		// Token: 0x040001CC RID: 460
		[Nullable(1)]
		public List<IDollGrabItem> Items;

		// Token: 0x040001CD RID: 461
		public IDollGrabInfiniteModeData InfiniteModeData;

		// Token: 0x040001CE RID: 462
		public string AkEvent;
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Common.Event
{
	// Token: 0x02006415 RID: 25621
	[NullableContext(1)]
	internal interface IEventSystemCacheKeyNode
	{
		// Token: 0x1700765C RID: 30300
		// (get) Token: 0x0603E2AF RID: 254639
		// (set) Token: 0x0603E2B0 RID: 254640
		object Key { get; set; }

		// Token: 0x1700765D RID: 30301
		// (get) Token: 0x0603E2B1 RID: 254641
		// (set) Token: 0x0603E2B2 RID: 254642
		object Target { get; set; }

		// Token: 0x1700765E RID: 30302
		// (get) Token: 0x0603E2B3 RID: 254643
		// (set) Token: 0x0603E2B4 RID: 254644
		Delegate Handle { get; set; }

		// Token: 0x1700765F RID: 30303
		// (get) Token: 0x0603E2B5 RID: 254645
		// (set) Token: 0x0603E2B6 RID: 254646
		EEventName EventName { get; set; }
	}
}

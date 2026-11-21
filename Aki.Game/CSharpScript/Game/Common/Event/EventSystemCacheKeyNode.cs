using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Common.Event
{
	// Token: 0x02006416 RID: 25622
	[NullableContext(1)]
	[Nullable(0)]
	internal class EventSystemCacheKeyNode : IEventSystemCacheKeyNode
	{
		// Token: 0x17007660 RID: 30304
		// (get) Token: 0x0603E2B7 RID: 254647 RVA: 0x0120FC22 File Offset: 0x0120DE22
		// (set) Token: 0x0603E2B8 RID: 254648 RVA: 0x0120FC2A File Offset: 0x0120DE2A
		public object Key { get; set; }

		// Token: 0x17007661 RID: 30305
		// (get) Token: 0x0603E2B9 RID: 254649 RVA: 0x0120FC33 File Offset: 0x0120DE33
		// (set) Token: 0x0603E2BA RID: 254650 RVA: 0x0120FC3B File Offset: 0x0120DE3B
		public object Target { get; set; }

		// Token: 0x17007662 RID: 30306
		// (get) Token: 0x0603E2BB RID: 254651 RVA: 0x0120FC44 File Offset: 0x0120DE44
		// (set) Token: 0x0603E2BC RID: 254652 RVA: 0x0120FC4C File Offset: 0x0120DE4C
		public Delegate Handle { get; set; }

		// Token: 0x17007663 RID: 30307
		// (get) Token: 0x0603E2BD RID: 254653 RVA: 0x0120FC55 File Offset: 0x0120DE55
		// (set) Token: 0x0603E2BE RID: 254654 RVA: 0x0120FC5D File Offset: 0x0120DE5D
		public EEventName EventName { get; set; }
	}
}

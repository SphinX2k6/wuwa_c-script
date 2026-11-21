using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C27 RID: 31783
	public class ITrackingEventTypeBaseT
	{
		// Token: 0x1700EDFD RID: 60925
		// (get) Token: 0x060394A1 RID: 234657 RVA: 0x007BCACA File Offset: 0x007BACCA
		// (set) Token: 0x060394A2 RID: 234658 RVA: 0x007BCAD2 File Offset: 0x007BACD2
		public ETrackingEventType Type { get; set; }

		// Token: 0x060394A3 RID: 234659 RVA: 0x007BCADB File Offset: 0x007BACDB
		public ITrackingEventTypeBaseT()
		{
			this.Type = ETrackingEventType.EasterEgg;
		}
	}
}

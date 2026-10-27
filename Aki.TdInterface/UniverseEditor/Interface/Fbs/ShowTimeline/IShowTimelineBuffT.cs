using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BAE RID: 15278
	public class IShowTimelineBuffT
	{
		// Token: 0x170068B7 RID: 26807
		// (get) Token: 0x06014F27 RID: 85799 RVA: 0x00309A73 File Offset: 0x00307C73
		// (set) Token: 0x06014F28 RID: 85800 RVA: 0x00309A7B File Offset: 0x00307C7B
		public EShowTimelineType Type { get; set; }

		// Token: 0x170068B8 RID: 26808
		// (get) Token: 0x06014F29 RID: 85801 RVA: 0x00309A84 File Offset: 0x00307C84
		// (set) Token: 0x06014F2A RID: 85802 RVA: 0x00309A8C File Offset: 0x00307C8C
		public List<long> BuffIds { get; set; }

		// Token: 0x06014F2B RID: 85803 RVA: 0x00309A95 File Offset: 0x00307C95
		public IShowTimelineBuffT()
		{
			this.Type = EShowTimelineType.Checkpoint;
			this.BuffIds = null;
		}
	}
}

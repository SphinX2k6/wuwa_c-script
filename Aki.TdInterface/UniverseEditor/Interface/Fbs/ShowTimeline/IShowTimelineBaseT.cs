using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BA8 RID: 15272
	public class IShowTimelineBaseT
	{
		// Token: 0x170068B1 RID: 26801
		// (get) Token: 0x06014EF7 RID: 85751 RVA: 0x0030955A File Offset: 0x0030775A
		// (set) Token: 0x06014EF8 RID: 85752 RVA: 0x00309562 File Offset: 0x00307762
		public EShowTimelineType Type { get; set; }

		// Token: 0x06014EF9 RID: 85753 RVA: 0x0030956B File Offset: 0x0030776B
		public IShowTimelineBaseT()
		{
			this.Type = EShowTimelineType.Checkpoint;
		}
	}
}

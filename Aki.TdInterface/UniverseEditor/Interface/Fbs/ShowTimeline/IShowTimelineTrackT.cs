using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BCF RID: 15311
	public class IShowTimelineTrackT
	{
		// Token: 0x17006916 RID: 26902
		// (get) Token: 0x060150D5 RID: 86229 RVA: 0x0030D451 File Offset: 0x0030B651
		// (set) Token: 0x060150D6 RID: 86230 RVA: 0x0030D459 File Offset: 0x0030B659
		public List<IShowTimelineFrameT> Frames { get; set; }

		// Token: 0x060150D7 RID: 86231 RVA: 0x0030D462 File Offset: 0x0030B662
		public IShowTimelineTrackT()
		{
			this.Frames = null;
		}
	}
}

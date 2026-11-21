using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FDA RID: 16346
	public class IShowTimelineTrackT
	{
		// Token: 0x17006EBE RID: 28350
		// (get) Token: 0x060165CB RID: 91595 RVA: 0x00333FD9 File Offset: 0x003321D9
		// (set) Token: 0x060165CC RID: 91596 RVA: 0x00333FE1 File Offset: 0x003321E1
		public List<IShowTimelineFrameT> Frames { get; set; }

		// Token: 0x060165CD RID: 91597 RVA: 0x00333FEA File Offset: 0x003321EA
		public IShowTimelineTrackT()
		{
			this.Frames = null;
		}
	}
}

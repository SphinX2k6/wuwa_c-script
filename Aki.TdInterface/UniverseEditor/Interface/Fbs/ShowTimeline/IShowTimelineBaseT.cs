using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FB0 RID: 16304
	public class IShowTimelineBaseT
	{
		// Token: 0x17006E50 RID: 28240
		// (get) Token: 0x060163C1 RID: 91073 RVA: 0x0032FAF2 File Offset: 0x0032DCF2
		// (set) Token: 0x060163C2 RID: 91074 RVA: 0x0032FAFA File Offset: 0x0032DCFA
		public EShowTimelineType Type { get; set; }

		// Token: 0x060163C3 RID: 91075 RVA: 0x0032FB03 File Offset: 0x0032DD03
		public IShowTimelineBaseT()
		{
			this.Type = EShowTimelineType.Checkpoint;
		}
	}
}

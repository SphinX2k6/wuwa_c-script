using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FC5 RID: 16325
	public class IShowTimelineGuideT
	{
		// Token: 0x17006E8A RID: 28298
		// (get) Token: 0x060164BF RID: 91327 RVA: 0x00331E94 File Offset: 0x00330094
		// (set) Token: 0x060164C0 RID: 91328 RVA: 0x00331E9C File Offset: 0x0033009C
		public EShowTimelineType Type { get; set; }

		// Token: 0x17006E8B RID: 28299
		// (get) Token: 0x060164C1 RID: 91329 RVA: 0x00331EA5 File Offset: 0x003300A5
		// (set) Token: 0x060164C2 RID: 91330 RVA: 0x00331EAD File Offset: 0x003300AD
		public int GuideStepId { get; set; }

		// Token: 0x060164C3 RID: 91331 RVA: 0x00331EB6 File Offset: 0x003300B6
		public IShowTimelineGuideT()
		{
			this.Type = EShowTimelineType.Checkpoint;
			this.GuideStepId = 0;
		}
	}
}

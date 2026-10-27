using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BBD RID: 15293
	public class IShowTimelineGuideT
	{
		// Token: 0x170068E7 RID: 26855
		// (get) Token: 0x06014FE7 RID: 85991 RVA: 0x0030B638 File Offset: 0x00309838
		// (set) Token: 0x06014FE8 RID: 85992 RVA: 0x0030B640 File Offset: 0x00309840
		public EShowTimelineType Type { get; set; }

		// Token: 0x170068E8 RID: 26856
		// (get) Token: 0x06014FE9 RID: 85993 RVA: 0x0030B649 File Offset: 0x00309849
		// (set) Token: 0x06014FEA RID: 85994 RVA: 0x0030B651 File Offset: 0x00309851
		public int GuideStepId { get; set; }

		// Token: 0x06014FEB RID: 85995 RVA: 0x0030B65A File Offset: 0x0030985A
		public IShowTimelineGuideT()
		{
			this.Type = EShowTimelineType.Checkpoint;
			this.GuideStepId = 0;
		}
	}
}

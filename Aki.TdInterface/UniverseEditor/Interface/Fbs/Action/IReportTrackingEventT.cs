using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075FB RID: 30203
	public class IReportTrackingEventT
	{
		// Token: 0x1700DDFC RID: 56828
		// (get) Token: 0x06034FFD RID: 217085 RVA: 0x0071ED09 File Offset: 0x0071CF09
		// (set) Token: 0x06034FFE RID: 217086 RVA: 0x0071ED11 File Offset: 0x0071CF11
		public TTrackingEventTypeUnion TrackingEventType { get; set; }

		// Token: 0x06034FFF RID: 217087 RVA: 0x0071ED1A File Offset: 0x0071CF1A
		public IReportTrackingEventT()
		{
			this.TrackingEventType = null;
		}
	}
}

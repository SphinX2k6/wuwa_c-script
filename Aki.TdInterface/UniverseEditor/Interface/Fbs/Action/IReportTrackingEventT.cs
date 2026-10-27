using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E77 RID: 28279
	public class IReportTrackingEventT
	{
		// Token: 0x1700D2A5 RID: 53925
		// (get) Token: 0x06031FBD RID: 204733 RVA: 0x006C2FD5 File Offset: 0x006C11D5
		// (set) Token: 0x06031FBE RID: 204734 RVA: 0x006C2FDD File Offset: 0x006C11DD
		public TTrackingEventTypeUnion TrackingEventType { get; set; }

		// Token: 0x06031FBF RID: 204735 RVA: 0x006C2FE6 File Offset: 0x006C11E6
		public IReportTrackingEventT()
		{
			this.TrackingEventType = null;
		}
	}
}

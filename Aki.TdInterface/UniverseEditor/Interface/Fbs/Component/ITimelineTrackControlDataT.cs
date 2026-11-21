using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200608D RID: 24717
	public class ITimelineTrackControlDataT
	{
		// Token: 0x1700B7BB RID: 47035
		// (get) Token: 0x06029CE1 RID: 171233 RVA: 0x005B5222 File Offset: 0x005B3422
		// (set) Token: 0x06029CE2 RID: 171234 RVA: 0x005B522A File Offset: 0x005B342A
		public ETrackControlMode Type { get; set; }

		// Token: 0x06029CE3 RID: 171235 RVA: 0x005B5233 File Offset: 0x005B3433
		public ITimelineTrackControlDataT()
		{
			this.Type = ETrackControlMode.Sequence;
		}
	}
}

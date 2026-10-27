using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A80 RID: 23168
	public class ITimelineTrackControlDataT
	{
		// Token: 0x1700AE83 RID: 44675
		// (get) Token: 0x06027769 RID: 161641 RVA: 0x0056E216 File Offset: 0x0056C416
		// (set) Token: 0x0602776A RID: 161642 RVA: 0x0056E21E File Offset: 0x0056C41E
		public ETrackControlMode Type { get; set; }

		// Token: 0x0602776B RID: 161643 RVA: 0x0056E227 File Offset: 0x0056C427
		public ITimelineTrackControlDataT()
		{
			this.Type = ETrackControlMode.Sequence;
		}
	}
}

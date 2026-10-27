using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005725 RID: 22309
	public class IPetalGrabEventT
	{
		// Token: 0x1700A634 RID: 42548
		// (get) Token: 0x0602553C RID: 152892 RVA: 0x0052679B File Offset: 0x0052499B
		// (set) Token: 0x0602553D RID: 152893 RVA: 0x005267A3 File Offset: 0x005249A3
		public EPetalGrabEventType EventType { get; set; }

		// Token: 0x1700A635 RID: 42549
		// (get) Token: 0x0602553E RID: 152894 RVA: 0x005267AC File Offset: 0x005249AC
		// (set) Token: 0x0602553F RID: 152895 RVA: 0x005267B4 File Offset: 0x005249B4
		public string State { get; set; }

		// Token: 0x06025540 RID: 152896 RVA: 0x005267BD File Offset: 0x005249BD
		public IPetalGrabEventT()
		{
			this.EventType = EPetalGrabEventType.Grabbed;
			this.State = null;
		}
	}
}

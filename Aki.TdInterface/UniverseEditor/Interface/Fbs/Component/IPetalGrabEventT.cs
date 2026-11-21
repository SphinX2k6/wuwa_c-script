using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D2C RID: 23852
	public class IPetalGrabEventT
	{
		// Token: 0x1700AF54 RID: 44884
		// (get) Token: 0x06027A4B RID: 162379 RVA: 0x0056C4A3 File Offset: 0x0056A6A3
		// (set) Token: 0x06027A4C RID: 162380 RVA: 0x0056C4AB File Offset: 0x0056A6AB
		public EPetalGrabEventType EventType { get; set; }

		// Token: 0x1700AF55 RID: 44885
		// (get) Token: 0x06027A4D RID: 162381 RVA: 0x0056C4B4 File Offset: 0x0056A6B4
		// (set) Token: 0x06027A4E RID: 162382 RVA: 0x0056C4BC File Offset: 0x0056A6BC
		public string State { get; set; }

		// Token: 0x06027A4F RID: 162383 RVA: 0x0056C4C5 File Offset: 0x0056A6C5
		public IPetalGrabEventT()
		{
			this.EventType = EPetalGrabEventType.Grabbed;
			this.State = null;
		}
	}
}

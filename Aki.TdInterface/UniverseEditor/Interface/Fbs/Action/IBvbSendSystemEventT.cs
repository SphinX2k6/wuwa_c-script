using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068D2 RID: 26834
	public class IBvbSendSystemEventT
	{
		// Token: 0x1700C53A RID: 50490
		// (get) Token: 0x0602DEB1 RID: 188081 RVA: 0x00646A01 File Offset: 0x00644C01
		// (set) Token: 0x0602DEB2 RID: 188082 RVA: 0x00646A09 File Offset: 0x00644C09
		public TBvbEventDataUnion EventData { get; set; }

		// Token: 0x0602DEB3 RID: 188083 RVA: 0x00646A12 File Offset: 0x00644C12
		public IBvbSendSystemEventT()
		{
			this.EventData = null;
		}
	}
}

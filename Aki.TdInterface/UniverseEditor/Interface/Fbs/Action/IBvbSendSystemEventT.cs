using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006261 RID: 25185
	public class IBvbSendSystemEventT
	{
		// Token: 0x1700BBB2 RID: 48050
		// (get) Token: 0x0602B750 RID: 178000 RVA: 0x005FBBF9 File Offset: 0x005F9DF9
		// (set) Token: 0x0602B751 RID: 178001 RVA: 0x005FBC01 File Offset: 0x005F9E01
		public TBvbEventDataUnion EventData { get; set; }

		// Token: 0x0602B752 RID: 178002 RVA: 0x005FBC0A File Offset: 0x005F9E0A
		public IBvbSendSystemEventT()
		{
			this.EventData = null;
		}
	}
}

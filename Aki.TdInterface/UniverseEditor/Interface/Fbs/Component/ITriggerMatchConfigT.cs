using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060F8 RID: 24824
	public class ITriggerMatchConfigT
	{
		// Token: 0x1700B8CE RID: 47310
		// (get) Token: 0x0602A138 RID: 172344 RVA: 0x005BE755 File Offset: 0x005BC955
		// (set) Token: 0x0602A139 RID: 172345 RVA: 0x005BE75D File Offset: 0x005BC95D
		public TEntityMatchUnion EntityMatch { get; set; }

		// Token: 0x1700B8CF RID: 47311
		// (get) Token: 0x0602A13A RID: 172346 RVA: 0x005BE766 File Offset: 0x005BC966
		// (set) Token: 0x0602A13B RID: 172347 RVA: 0x005BE76E File Offset: 0x005BC96E
		public int EntityMatchCount { get; set; }

		// Token: 0x1700B8D0 RID: 47312
		// (get) Token: 0x0602A13C RID: 172348 RVA: 0x005BE777 File Offset: 0x005BC977
		// (set) Token: 0x0602A13D RID: 172349 RVA: 0x005BE77F File Offset: 0x005BC97F
		public byte NullMask { get; set; }

		// Token: 0x0602A13E RID: 172350 RVA: 0x005BE788 File Offset: 0x005BC988
		public ITriggerMatchConfigT()
		{
			this.EntityMatch = null;
			this.EntityMatchCount = 0;
			this.NullMask = 0;
		}
	}
}

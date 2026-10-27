using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C41 RID: 19521
	public class IHourToHourT
	{
		// Token: 0x17008DD1 RID: 36305
		// (get) Token: 0x0601EF13 RID: 126739 RVA: 0x00454252 File Offset: 0x00452452
		// (set) Token: 0x0601EF14 RID: 126740 RVA: 0x0045425A File Offset: 0x0045245A
		public IHourT Start { get; set; }

		// Token: 0x17008DD2 RID: 36306
		// (get) Token: 0x0601EF15 RID: 126741 RVA: 0x00454263 File Offset: 0x00452463
		// (set) Token: 0x0601EF16 RID: 126742 RVA: 0x0045426B File Offset: 0x0045246B
		public IHourT End { get; set; }

		// Token: 0x0601EF17 RID: 126743 RVA: 0x00454274 File Offset: 0x00452474
		public IHourToHourT()
		{
			this.Start = null;
			this.End = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007699 RID: 30361
	public class TCsvCommonBtOverrideDataT
	{
		// Token: 0x1700E5FC RID: 58876
		// (get) Token: 0x060373E8 RID: 226280 RVA: 0x0077C8EB File Offset: 0x0077AAEB
		// (set) Token: 0x060373E9 RID: 226281 RVA: 0x0077C8F3 File Offset: 0x0077AAF3
		public int Id { get; set; }

		// Token: 0x1700E5FD RID: 58877
		// (get) Token: 0x060373EA RID: 226282 RVA: 0x0077C8FC File Offset: 0x0077AAFC
		// (set) Token: 0x060373EB RID: 226283 RVA: 0x0077C904 File Offset: 0x0077AB04
		public ICommonBtOverrideT Data { get; set; }

		// Token: 0x060373EC RID: 226284 RVA: 0x0077C90D File Offset: 0x0077AB0D
		public TCsvCommonBtOverrideDataT()
		{
			this.Id = 0;
			this.Data = null;
		}
	}
}

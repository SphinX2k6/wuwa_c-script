using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DFB RID: 24059
	public class IRandomPoolConfigT
	{
		// Token: 0x1700B151 RID: 45393
		// (get) Token: 0x0602829C RID: 164508 RVA: 0x0057E250 File Offset: 0x0057C450
		// (set) Token: 0x0602829D RID: 164509 RVA: 0x0057E258 File Offset: 0x0057C458
		public int Id { get; set; }

		// Token: 0x1700B152 RID: 45394
		// (get) Token: 0x0602829E RID: 164510 RVA: 0x0057E261 File Offset: 0x0057C461
		// (set) Token: 0x0602829F RID: 164511 RVA: 0x0057E269 File Offset: 0x0057C469
		public int Count { get; set; }

		// Token: 0x060282A0 RID: 164512 RVA: 0x0057E272 File Offset: 0x0057C472
		public IRandomPoolConfigT()
		{
			this.Id = 0;
			this.Count = 0;
		}
	}
}

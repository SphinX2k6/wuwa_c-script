using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A05 RID: 31237
	public class ISummonEntityT
	{
		// Token: 0x1700E4ED RID: 58605
		// (get) Token: 0x060370A4 RID: 225444 RVA: 0x0075B4D5 File Offset: 0x007596D5
		// (set) Token: 0x060370A5 RID: 225445 RVA: 0x0075B4DD File Offset: 0x007596DD
		public ISummonVehicleT SummonEntityConfig { get; set; }

		// Token: 0x060370A6 RID: 225446 RVA: 0x0075B4E6 File Offset: 0x007596E6
		public ISummonEntityT()
		{
			this.SummonEntityConfig = null;
		}
	}
}

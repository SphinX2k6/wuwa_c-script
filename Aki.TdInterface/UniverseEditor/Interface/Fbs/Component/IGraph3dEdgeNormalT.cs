using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005893 RID: 22675
	public class IGraph3dEdgeNormalT
	{
		// Token: 0x1700A458 RID: 42072
		// (get) Token: 0x06024C72 RID: 150642 RVA: 0x0050D046 File Offset: 0x0050B246
		// (set) Token: 0x06024C73 RID: 150643 RVA: 0x0050D04E File Offset: 0x0050B24E
		public int Id { get; set; }

		// Token: 0x1700A459 RID: 42073
		// (get) Token: 0x06024C74 RID: 150644 RVA: 0x0050D057 File Offset: 0x0050B257
		// (set) Token: 0x06024C75 RID: 150645 RVA: 0x0050D05F File Offset: 0x0050B25F
		public int From { get; set; }

		// Token: 0x1700A45A RID: 42074
		// (get) Token: 0x06024C76 RID: 150646 RVA: 0x0050D068 File Offset: 0x0050B268
		// (set) Token: 0x06024C77 RID: 150647 RVA: 0x0050D070 File Offset: 0x0050B270
		public int To { get; set; }

		// Token: 0x06024C78 RID: 150648 RVA: 0x0050D079 File Offset: 0x0050B279
		public IGraph3dEdgeNormalT()
		{
			this.Id = 0;
			this.From = 0;
			this.To = 0;
		}
	}
}

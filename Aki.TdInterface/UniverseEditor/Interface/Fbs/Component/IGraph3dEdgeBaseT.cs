using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005890 RID: 22672
	public class IGraph3dEdgeBaseT
	{
		// Token: 0x1700A451 RID: 42065
		// (get) Token: 0x06024C58 RID: 150616 RVA: 0x0050CDB6 File Offset: 0x0050AFB6
		// (set) Token: 0x06024C59 RID: 150617 RVA: 0x0050CDBE File Offset: 0x0050AFBE
		public int Id { get; set; }

		// Token: 0x1700A452 RID: 42066
		// (get) Token: 0x06024C5A RID: 150618 RVA: 0x0050CDC7 File Offset: 0x0050AFC7
		// (set) Token: 0x06024C5B RID: 150619 RVA: 0x0050CDCF File Offset: 0x0050AFCF
		public int From { get; set; }

		// Token: 0x1700A453 RID: 42067
		// (get) Token: 0x06024C5C RID: 150620 RVA: 0x0050CDD8 File Offset: 0x0050AFD8
		// (set) Token: 0x06024C5D RID: 150621 RVA: 0x0050CDE0 File Offset: 0x0050AFE0
		public int To { get; set; }

		// Token: 0x06024C5E RID: 150622 RVA: 0x0050CDE9 File Offset: 0x0050AFE9
		public IGraph3dEdgeBaseT()
		{
			this.Id = 0;
			this.From = 0;
			this.To = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007766 RID: 30566
	public class ISetAreaStateT
	{
		// Token: 0x1700E00B RID: 57355
		// (get) Token: 0x06035A63 RID: 219747 RVA: 0x00730A60 File Offset: 0x0072EC60
		// (set) Token: 0x06035A64 RID: 219748 RVA: 0x00730A68 File Offset: 0x0072EC68
		public int AreaId { get; set; }

		// Token: 0x1700E00C RID: 57356
		// (get) Token: 0x06035A65 RID: 219749 RVA: 0x00730A71 File Offset: 0x0072EC71
		// (set) Token: 0x06035A66 RID: 219750 RVA: 0x00730A79 File Offset: 0x0072EC79
		public int State { get; set; }

		// Token: 0x06035A67 RID: 219751 RVA: 0x00730A82 File Offset: 0x0072EC82
		public ISetAreaStateT()
		{
			this.AreaId = 0;
			this.State = 0;
		}
	}
}

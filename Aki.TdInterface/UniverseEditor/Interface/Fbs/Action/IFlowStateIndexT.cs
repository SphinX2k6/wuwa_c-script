using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006820 RID: 26656
	public class IFlowStateIndexT
	{
		// Token: 0x1700C601 RID: 50689
		// (get) Token: 0x0602E77A RID: 190330 RVA: 0x00657845 File Offset: 0x00655A45
		// (set) Token: 0x0602E77B RID: 190331 RVA: 0x0065784D File Offset: 0x00655A4D
		public string FlowListName { get; set; }

		// Token: 0x1700C602 RID: 50690
		// (get) Token: 0x0602E77C RID: 190332 RVA: 0x00657856 File Offset: 0x00655A56
		// (set) Token: 0x0602E77D RID: 190333 RVA: 0x0065785E File Offset: 0x00655A5E
		public int FlowId { get; set; }

		// Token: 0x1700C603 RID: 50691
		// (get) Token: 0x0602E77E RID: 190334 RVA: 0x00657867 File Offset: 0x00655A67
		// (set) Token: 0x0602E77F RID: 190335 RVA: 0x0065786F File Offset: 0x00655A6F
		public int StateId { get; set; }

		// Token: 0x0602E780 RID: 190336 RVA: 0x00657878 File Offset: 0x00655A78
		public IFlowStateIndexT()
		{
			this.FlowListName = null;
			this.FlowId = 0;
			this.StateId = 0;
		}
	}
}

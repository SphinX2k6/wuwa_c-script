using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006814 RID: 26644
	public class IFlowIndexT
	{
		// Token: 0x1700C5C2 RID: 50626
		// (get) Token: 0x0602E67A RID: 190074 RVA: 0x0065518F File Offset: 0x0065338F
		// (set) Token: 0x0602E67B RID: 190075 RVA: 0x00655197 File Offset: 0x00653397
		public string FlowListName { get; set; }

		// Token: 0x1700C5C3 RID: 50627
		// (get) Token: 0x0602E67C RID: 190076 RVA: 0x006551A0 File Offset: 0x006533A0
		// (set) Token: 0x0602E67D RID: 190077 RVA: 0x006551A8 File Offset: 0x006533A8
		public int FlowId { get; set; }

		// Token: 0x0602E67E RID: 190078 RVA: 0x006551B1 File Offset: 0x006533B1
		public IFlowIndexT()
		{
			this.FlowListName = null;
			this.FlowId = 0;
		}
	}
}

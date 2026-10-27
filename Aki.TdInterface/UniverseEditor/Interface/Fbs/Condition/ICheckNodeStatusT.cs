using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AD0 RID: 19152
	public class ICheckNodeStatusT
	{
		// Token: 0x17008ADC RID: 35548
		// (get) Token: 0x0601E13C RID: 123196 RVA: 0x0043833E File Offset: 0x0043653E
		// (set) Token: 0x0601E13D RID: 123197 RVA: 0x00438346 File Offset: 0x00436546
		public ECondition Type { get; set; }

		// Token: 0x17008ADD RID: 35549
		// (get) Token: 0x0601E13E RID: 123198 RVA: 0x0043834F File Offset: 0x0043654F
		// (set) Token: 0x0601E13F RID: 123199 RVA: 0x00438357 File Offset: 0x00436557
		public int NodeId { get; set; }

		// Token: 0x17008ADE RID: 35550
		// (get) Token: 0x0601E140 RID: 123200 RVA: 0x00438360 File Offset: 0x00436560
		// (set) Token: 0x0601E141 RID: 123201 RVA: 0x00438368 File Offset: 0x00436568
		public ENodeStatusType Status { get; set; }

		// Token: 0x0601E142 RID: 123202 RVA: 0x00438371 File Offset: 0x00436571
		public ICheckNodeStatusT()
		{
			this.Type = ECondition.CompareVar;
			this.NodeId = 0;
			this.Status = ENodeStatusType.NotActive;
		}
	}
}

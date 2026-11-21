using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FA2 RID: 20386
	public class ICheckNodeStatusT
	{
		// Token: 0x170091CE RID: 37326
		// (get) Token: 0x0601FC3B RID: 130107 RVA: 0x00469DEA File Offset: 0x00467FEA
		// (set) Token: 0x0601FC3C RID: 130108 RVA: 0x00469DF2 File Offset: 0x00467FF2
		public ECondition Type { get; set; }

		// Token: 0x170091CF RID: 37327
		// (get) Token: 0x0601FC3D RID: 130109 RVA: 0x00469DFB File Offset: 0x00467FFB
		// (set) Token: 0x0601FC3E RID: 130110 RVA: 0x00469E03 File Offset: 0x00468003
		public int NodeId { get; set; }

		// Token: 0x170091D0 RID: 37328
		// (get) Token: 0x0601FC3F RID: 130111 RVA: 0x00469E0C File Offset: 0x0046800C
		// (set) Token: 0x0601FC40 RID: 130112 RVA: 0x00469E14 File Offset: 0x00468014
		public ENodeStatusType Status { get; set; }

		// Token: 0x0601FC41 RID: 130113 RVA: 0x00469E1D File Offset: 0x0046801D
		public ICheckNodeStatusT()
		{
			this.Type = ECondition.CompareVar;
			this.NodeId = 0;
			this.Status = ENodeStatusType.NotActive;
		}
	}
}

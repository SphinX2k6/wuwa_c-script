using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200499E RID: 18846
	public class ICheckChildQuestStatusT
	{
		// Token: 0x17008831 RID: 34865
		// (get) Token: 0x0601D666 RID: 120422 RVA: 0x00424BB2 File Offset: 0x00422DB2
		// (set) Token: 0x0601D667 RID: 120423 RVA: 0x00424BBA File Offset: 0x00422DBA
		public ECondition Type { get; set; }

		// Token: 0x17008832 RID: 34866
		// (get) Token: 0x0601D668 RID: 120424 RVA: 0x00424BC3 File Offset: 0x00422DC3
		// (set) Token: 0x0601D669 RID: 120425 RVA: 0x00424BCB File Offset: 0x00422DCB
		public int NodeId { get; set; }

		// Token: 0x17008833 RID: 34867
		// (get) Token: 0x0601D66A RID: 120426 RVA: 0x00424BD4 File Offset: 0x00422DD4
		// (set) Token: 0x0601D66B RID: 120427 RVA: 0x00424BDC File Offset: 0x00422DDC
		public EQuestNodeStatusType Status { get; set; }

		// Token: 0x0601D66C RID: 120428 RVA: 0x00424BE5 File Offset: 0x00422DE5
		public ICheckChildQuestStatusT()
		{
			this.Type = ECondition.CompareVar;
			this.NodeId = 0;
			this.Status = EQuestNodeStatusType.CqnsNotActive;
		}
	}
}

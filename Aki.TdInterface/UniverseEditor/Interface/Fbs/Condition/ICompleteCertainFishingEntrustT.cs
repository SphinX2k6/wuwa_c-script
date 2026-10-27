using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BD5 RID: 19413
	public class ICompleteCertainFishingEntrustT
	{
		// Token: 0x17008D0D RID: 36109
		// (get) Token: 0x0601EA7D RID: 125565 RVA: 0x0044997A File Offset: 0x00447B7A
		// (set) Token: 0x0601EA7E RID: 125566 RVA: 0x00449982 File Offset: 0x00447B82
		public ECondition Type { get; set; }

		// Token: 0x17008D0E RID: 36110
		// (get) Token: 0x0601EA7F RID: 125567 RVA: 0x0044998B File Offset: 0x00447B8B
		// (set) Token: 0x0601EA80 RID: 125568 RVA: 0x00449993 File Offset: 0x00447B93
		public int Id { get; set; }

		// Token: 0x17008D0F RID: 36111
		// (get) Token: 0x0601EA81 RID: 125569 RVA: 0x0044999C File Offset: 0x00447B9C
		// (set) Token: 0x0601EA82 RID: 125570 RVA: 0x004499A4 File Offset: 0x00447BA4
		public int Count { get; set; }

		// Token: 0x0601EA83 RID: 125571 RVA: 0x004499AD File Offset: 0x00447BAD
		public ICompleteCertainFishingEntrustT()
		{
			this.Type = ECondition.CompareVar;
			this.Id = 0;
			this.Count = 0;
		}
	}
}

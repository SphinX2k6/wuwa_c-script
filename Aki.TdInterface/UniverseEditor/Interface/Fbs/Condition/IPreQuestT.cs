using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C9B RID: 19611
	public class IPreQuestT
	{
		// Token: 0x17008E65 RID: 36453
		// (get) Token: 0x0601F1BD RID: 127421 RVA: 0x00458A12 File Offset: 0x00456C12
		// (set) Token: 0x0601F1BE RID: 127422 RVA: 0x00458A1A File Offset: 0x00456C1A
		public EVisibleCondition Type { get; set; }

		// Token: 0x17008E66 RID: 36454
		// (get) Token: 0x0601F1BF RID: 127423 RVA: 0x00458A23 File Offset: 0x00456C23
		// (set) Token: 0x0601F1C0 RID: 127424 RVA: 0x00458A2B File Offset: 0x00456C2B
		public ECompare Compare { get; set; }

		// Token: 0x17008E67 RID: 36455
		// (get) Token: 0x0601F1C1 RID: 127425 RVA: 0x00458A34 File Offset: 0x00456C34
		// (set) Token: 0x0601F1C2 RID: 127426 RVA: 0x00458A3C File Offset: 0x00456C3C
		public int PreQuestId { get; set; }

		// Token: 0x0601F1C3 RID: 127427 RVA: 0x00458A45 File Offset: 0x00456C45
		public IPreQuestT()
		{
			this.Type = EVisibleCondition.Weather;
			this.Compare = ECompare.Eq;
			this.PreQuestId = 0;
		}
	}
}

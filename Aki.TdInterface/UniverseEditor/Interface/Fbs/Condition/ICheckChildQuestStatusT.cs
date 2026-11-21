using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E55 RID: 20053
	public class ICheckChildQuestStatusT
	{
		// Token: 0x17008EEC RID: 36588
		// (get) Token: 0x0601F08B RID: 127115 RVA: 0x00455066 File Offset: 0x00453266
		// (set) Token: 0x0601F08C RID: 127116 RVA: 0x0045506E File Offset: 0x0045326E
		public ECondition Type { get; set; }

		// Token: 0x17008EED RID: 36589
		// (get) Token: 0x0601F08D RID: 127117 RVA: 0x00455077 File Offset: 0x00453277
		// (set) Token: 0x0601F08E RID: 127118 RVA: 0x0045507F File Offset: 0x0045327F
		public int NodeId { get; set; }

		// Token: 0x17008EEE RID: 36590
		// (get) Token: 0x0601F08F RID: 127119 RVA: 0x00455088 File Offset: 0x00453288
		// (set) Token: 0x0601F090 RID: 127120 RVA: 0x00455090 File Offset: 0x00453290
		public EQuestNodeStatusType Status { get; set; }

		// Token: 0x0601F091 RID: 127121 RVA: 0x00455099 File Offset: 0x00453299
		public ICheckChildQuestStatusT()
		{
			this.Type = ECondition.CompareVar;
			this.NodeId = 0;
			this.Status = EQuestNodeStatusType.CqnsNotActive;
		}
	}
}

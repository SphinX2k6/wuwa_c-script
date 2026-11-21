using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E52 RID: 20050
	public class ICheckChildQuestFinishedT
	{
		// Token: 0x17008EE3 RID: 36579
		// (get) Token: 0x0601F06D RID: 127085 RVA: 0x00454D86 File Offset: 0x00452F86
		// (set) Token: 0x0601F06E RID: 127086 RVA: 0x00454D8E File Offset: 0x00452F8E
		public ECondition Type { get; set; }

		// Token: 0x17008EE4 RID: 36580
		// (get) Token: 0x0601F06F RID: 127087 RVA: 0x00454D97 File Offset: 0x00452F97
		// (set) Token: 0x0601F070 RID: 127088 RVA: 0x00454D9F File Offset: 0x00452F9F
		public int QuestId { get; set; }

		// Token: 0x17008EE5 RID: 36581
		// (get) Token: 0x0601F071 RID: 127089 RVA: 0x00454DA8 File Offset: 0x00452FA8
		// (set) Token: 0x0601F072 RID: 127090 RVA: 0x00454DB0 File Offset: 0x00452FB0
		public int ChildQuestId { get; set; }

		// Token: 0x17008EE6 RID: 36582
		// (get) Token: 0x0601F073 RID: 127091 RVA: 0x00454DB9 File Offset: 0x00452FB9
		// (set) Token: 0x0601F074 RID: 127092 RVA: 0x00454DC1 File Offset: 0x00452FC1
		public ECompare Compare { get; set; }

		// Token: 0x17008EE7 RID: 36583
		// (get) Token: 0x0601F075 RID: 127093 RVA: 0x00454DCA File Offset: 0x00452FCA
		// (set) Token: 0x0601F076 RID: 127094 RVA: 0x00454DD2 File Offset: 0x00452FD2
		public byte NullMask { get; set; }

		// Token: 0x0601F077 RID: 127095 RVA: 0x00454DDB File Offset: 0x00452FDB
		public ICheckChildQuestFinishedT()
		{
			this.Type = ECondition.CompareVar;
			this.QuestId = 0;
			this.ChildQuestId = 0;
			this.Compare = ECompare.Eq;
			this.NullMask = 0;
		}
	}
}

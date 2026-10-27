using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B39 RID: 19257
	public class ICheckSyncLevelPlayCompleteNumberT
	{
		// Token: 0x17008BB6 RID: 35766
		// (get) Token: 0x0601E4E8 RID: 124136 RVA: 0x0043F1F8 File Offset: 0x0043D3F8
		// (set) Token: 0x0601E4E9 RID: 124137 RVA: 0x0043F200 File Offset: 0x0043D400
		public ECondition Type { get; set; }

		// Token: 0x17008BB7 RID: 35767
		// (get) Token: 0x0601E4EA RID: 124138 RVA: 0x0043F209 File Offset: 0x0043D409
		// (set) Token: 0x0601E4EB RID: 124139 RVA: 0x0043F211 File Offset: 0x0043D411
		public int SyncId { get; set; }

		// Token: 0x17008BB8 RID: 35768
		// (get) Token: 0x0601E4EC RID: 124140 RVA: 0x0043F21A File Offset: 0x0043D41A
		// (set) Token: 0x0601E4ED RID: 124141 RVA: 0x0043F222 File Offset: 0x0043D422
		public ECompare Compare { get; set; }

		// Token: 0x17008BB9 RID: 35769
		// (get) Token: 0x0601E4EE RID: 124142 RVA: 0x0043F22B File Offset: 0x0043D42B
		// (set) Token: 0x0601E4EF RID: 124143 RVA: 0x0043F233 File Offset: 0x0043D433
		public int Number { get; set; }

		// Token: 0x0601E4F0 RID: 124144 RVA: 0x0043F23C File Offset: 0x0043D43C
		public ICheckSyncLevelPlayCompleteNumberT()
		{
			this.Type = ECondition.CompareVar;
			this.SyncId = 0;
			this.Compare = ECompare.Eq;
			this.Number = 0;
		}
	}
}

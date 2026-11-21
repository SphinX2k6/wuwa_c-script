using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005146 RID: 20806
	public class IMapThemedActivityReachRankT
	{
		// Token: 0x17009522 RID: 38178
		// (get) Token: 0x06020BBD RID: 134077 RVA: 0x00488F54 File Offset: 0x00487154
		// (set) Token: 0x06020BBE RID: 134078 RVA: 0x00488F5C File Offset: 0x0048715C
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17009523 RID: 38179
		// (get) Token: 0x06020BBF RID: 134079 RVA: 0x00488F65 File Offset: 0x00487165
		// (set) Token: 0x06020BC0 RID: 134080 RVA: 0x00488F6D File Offset: 0x0048716D
		public int TargetRank { get; set; }

		// Token: 0x06020BC1 RID: 134081 RVA: 0x00488F76 File Offset: 0x00487176
		public IMapThemedActivityReachRankT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.TargetRank = 0;
		}
	}
}

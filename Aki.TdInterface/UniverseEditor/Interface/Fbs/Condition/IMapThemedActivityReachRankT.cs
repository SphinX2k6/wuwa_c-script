using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C53 RID: 19539
	public class IMapThemedActivityReachRankT
	{
		// Token: 0x17008DF9 RID: 36345
		// (get) Token: 0x0601EFB9 RID: 126905 RVA: 0x00455678 File Offset: 0x00453878
		// (set) Token: 0x0601EFBA RID: 126906 RVA: 0x00455680 File Offset: 0x00453880
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17008DFA RID: 36346
		// (get) Token: 0x0601EFBB RID: 126907 RVA: 0x00455689 File Offset: 0x00453889
		// (set) Token: 0x0601EFBC RID: 126908 RVA: 0x00455691 File Offset: 0x00453891
		public int TargetRank { get; set; }

		// Token: 0x0601EFBD RID: 126909 RVA: 0x0045569A File Offset: 0x0045389A
		public IMapThemedActivityReachRankT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.TargetRank = 0;
		}
	}
}

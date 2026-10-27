using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004005 RID: 16389
	public class IQuestPlayerHitStatisticsTypeT
	{
		// Token: 0x1700732E RID: 29486
		// (get) Token: 0x06017A70 RID: 96880 RVA: 0x0036979E File Offset: 0x0036799E
		// (set) Token: 0x06017A71 RID: 96881 RVA: 0x003697A6 File Offset: 0x003679A6
		public EPlayerHitStatisticsType Type { get; set; }

		// Token: 0x06017A72 RID: 96882 RVA: 0x003697AF File Offset: 0x003679AF
		public IQuestPlayerHitStatisticsTypeT()
		{
			this.Type = EPlayerHitStatisticsType.HitCount;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200443D RID: 17469
	public class IQuestPlayerBeDamageT
	{
		// Token: 0x1700791A RID: 31002
		// (get) Token: 0x0601909E RID: 102558 RVA: 0x00392744 File Offset: 0x00390944
		// (set) Token: 0x0601909F RID: 102559 RVA: 0x0039274C File Offset: 0x0039094C
		public EPlayerHitStatisticsType Type { get; set; }

		// Token: 0x1700791B RID: 31003
		// (get) Token: 0x060190A0 RID: 102560 RVA: 0x00392755 File Offset: 0x00390955
		// (set) Token: 0x060190A1 RID: 102561 RVA: 0x0039275D File Offset: 0x0039095D
		public EPlayerDamageInfoType StatisticsType { get; set; }

		// Token: 0x060190A2 RID: 102562 RVA: 0x00392766 File Offset: 0x00390966
		public IQuestPlayerBeDamageT()
		{
			this.Type = EPlayerHitStatisticsType.HitCount;
			this.StatisticsType = EPlayerDamageInfoType.DamagePoint;
		}
	}
}

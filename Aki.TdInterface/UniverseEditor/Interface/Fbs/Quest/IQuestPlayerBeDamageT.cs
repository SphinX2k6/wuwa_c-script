using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FFC RID: 16380
	public class IQuestPlayerBeDamageT
	{
		// Token: 0x17007318 RID: 29464
		// (get) Token: 0x06017A05 RID: 96773 RVA: 0x00368950 File Offset: 0x00366B50
		// (set) Token: 0x06017A06 RID: 96774 RVA: 0x00368958 File Offset: 0x00366B58
		public EPlayerHitStatisticsType Type { get; set; }

		// Token: 0x17007319 RID: 29465
		// (get) Token: 0x06017A07 RID: 96775 RVA: 0x00368961 File Offset: 0x00366B61
		// (set) Token: 0x06017A08 RID: 96776 RVA: 0x00368969 File Offset: 0x00366B69
		public EPlayerDamageInfoType StatisticsType { get; set; }

		// Token: 0x06017A09 RID: 96777 RVA: 0x00368972 File Offset: 0x00366B72
		public IQuestPlayerBeDamageT()
		{
			this.Type = EPlayerHitStatisticsType.HitCount;
			this.StatisticsType = EPlayerDamageInfoType.DamagePoint;
		}
	}
}

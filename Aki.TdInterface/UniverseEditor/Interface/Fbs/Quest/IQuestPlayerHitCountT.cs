using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FFF RID: 16383
	public class IQuestPlayerHitCountT
	{
		// Token: 0x17007320 RID: 29472
		// (get) Token: 0x06017A31 RID: 96817 RVA: 0x00368EDA File Offset: 0x003670DA
		// (set) Token: 0x06017A32 RID: 96818 RVA: 0x00368EE2 File Offset: 0x003670E2
		public EPlayerHitStatisticsType Type { get; set; }

		// Token: 0x17007321 RID: 29473
		// (get) Token: 0x06017A33 RID: 96819 RVA: 0x00368EEB File Offset: 0x003670EB
		// (set) Token: 0x06017A34 RID: 96820 RVA: 0x00368EF3 File Offset: 0x003670F3
		public float Cd { get; set; }

		// Token: 0x17007322 RID: 29474
		// (get) Token: 0x06017A35 RID: 96821 RVA: 0x00368EFC File Offset: 0x003670FC
		// (set) Token: 0x06017A36 RID: 96822 RVA: 0x00368F04 File Offset: 0x00367104
		public List<int> EntityIds { get; set; }

		// Token: 0x17007323 RID: 29475
		// (get) Token: 0x06017A37 RID: 96823 RVA: 0x00368F0D File Offset: 0x0036710D
		// (set) Token: 0x06017A38 RID: 96824 RVA: 0x00368F15 File Offset: 0x00367115
		public List<int> SkillIds { get; set; }

		// Token: 0x17007324 RID: 29476
		// (get) Token: 0x06017A39 RID: 96825 RVA: 0x00368F1E File Offset: 0x0036711E
		// (set) Token: 0x06017A3A RID: 96826 RVA: 0x00368F26 File Offset: 0x00367126
		public byte NullMask { get; set; }

		// Token: 0x06017A3B RID: 96827 RVA: 0x00368F2F File Offset: 0x0036712F
		public IQuestPlayerHitCountT()
		{
			this.Type = EPlayerHitStatisticsType.HitCount;
			this.Cd = 0f;
			this.EntityIds = null;
			this.SkillIds = null;
			this.NullMask = 0;
		}
	}
}

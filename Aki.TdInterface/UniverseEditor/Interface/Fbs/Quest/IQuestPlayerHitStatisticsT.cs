using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004443 RID: 17475
	public class IQuestPlayerHitStatisticsT
	{
		// Token: 0x1700792B RID: 31019
		// (get) Token: 0x060190F3 RID: 102643 RVA: 0x0039336D File Offset: 0x0039156D
		// (set) Token: 0x060190F4 RID: 102644 RVA: 0x00393375 File Offset: 0x00391575
		public EStatisticsEventType Type { get; set; }

		// Token: 0x1700792C RID: 31020
		// (get) Token: 0x060190F5 RID: 102645 RVA: 0x0039337E File Offset: 0x0039157E
		// (set) Token: 0x060190F6 RID: 102646 RVA: 0x00393386 File Offset: 0x00391586
		public TVarRefUnion Var { get; set; }

		// Token: 0x1700792D RID: 31021
		// (get) Token: 0x060190F7 RID: 102647 RVA: 0x0039338F File Offset: 0x0039158F
		// (set) Token: 0x060190F8 RID: 102648 RVA: 0x00393397 File Offset: 0x00391597
		public TQuestPlayerHitStatisticsUnion Config { get; set; }

		// Token: 0x060190F9 RID: 102649 RVA: 0x003933A0 File Offset: 0x003915A0
		public IQuestPlayerHitStatisticsT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.Config = null;
		}
	}
}

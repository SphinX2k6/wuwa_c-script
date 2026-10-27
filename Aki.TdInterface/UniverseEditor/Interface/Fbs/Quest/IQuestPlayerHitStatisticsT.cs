using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004002 RID: 16386
	public class IQuestPlayerHitStatisticsT
	{
		// Token: 0x17007329 RID: 29481
		// (get) Token: 0x06017A5A RID: 96858 RVA: 0x00369579 File Offset: 0x00367779
		// (set) Token: 0x06017A5B RID: 96859 RVA: 0x00369581 File Offset: 0x00367781
		public EStatisticsEventType Type { get; set; }

		// Token: 0x1700732A RID: 29482
		// (get) Token: 0x06017A5C RID: 96860 RVA: 0x0036958A File Offset: 0x0036778A
		// (set) Token: 0x06017A5D RID: 96861 RVA: 0x00369592 File Offset: 0x00367792
		public TVarRefUnion Var { get; set; }

		// Token: 0x1700732B RID: 29483
		// (get) Token: 0x06017A5E RID: 96862 RVA: 0x0036959B File Offset: 0x0036779B
		// (set) Token: 0x06017A5F RID: 96863 RVA: 0x003695A3 File Offset: 0x003677A3
		public TQuestPlayerHitStatisticsUnion Config { get; set; }

		// Token: 0x06017A60 RID: 96864 RVA: 0x003695AC File Offset: 0x003677AC
		public IQuestPlayerHitStatisticsT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.Config = null;
		}
	}
}

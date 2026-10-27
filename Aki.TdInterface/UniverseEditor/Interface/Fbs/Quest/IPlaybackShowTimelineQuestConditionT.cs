using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F9F RID: 16287
	public class IPlaybackShowTimelineQuestConditionT
	{
		// Token: 0x170071B7 RID: 29111
		// (get) Token: 0x06017458 RID: 95320 RVA: 0x0035B1AD File Offset: 0x003593AD
		// (set) Token: 0x06017459 RID: 95321 RVA: 0x0035B1B5 File Offset: 0x003593B5
		public EChildQuest Type { get; set; }

		// Token: 0x170071B8 RID: 29112
		// (get) Token: 0x0601745A RID: 95322 RVA: 0x0035B1BE File Offset: 0x003593BE
		// (set) Token: 0x0601745B RID: 95323 RVA: 0x0035B1C6 File Offset: 0x003593C6
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170071B9 RID: 29113
		// (get) Token: 0x0601745C RID: 95324 RVA: 0x0035B1CF File Offset: 0x003593CF
		// (set) Token: 0x0601745D RID: 95325 RVA: 0x0035B1D7 File Offset: 0x003593D7
		public string ShowTimelineFileName { get; set; }

		// Token: 0x0601745E RID: 95326 RVA: 0x0035B1E0 File Offset: 0x003593E0
		public IPlaybackShowTimelineQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.ShowTimelineFileName = null;
		}
	}
}

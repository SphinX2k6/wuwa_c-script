using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200415E RID: 16734
	public class ICheckClientConditionGroupQuestConditionT
	{
		// Token: 0x1700715D RID: 29021
		// (get) Token: 0x06017031 RID: 94257 RVA: 0x0034828C File Offset: 0x0034648C
		// (set) Token: 0x06017032 RID: 94258 RVA: 0x00348294 File Offset: 0x00346494
		public EChildQuest Type { get; set; }

		// Token: 0x1700715E RID: 29022
		// (get) Token: 0x06017033 RID: 94259 RVA: 0x0034829D File Offset: 0x0034649D
		// (set) Token: 0x06017034 RID: 94260 RVA: 0x003482A5 File Offset: 0x003464A5
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x1700715F RID: 29023
		// (get) Token: 0x06017035 RID: 94261 RVA: 0x003482AE File Offset: 0x003464AE
		// (set) Token: 0x06017036 RID: 94262 RVA: 0x003482B6 File Offset: 0x003464B6
		public IConditionGroupT Condition { get; set; }

		// Token: 0x06017037 RID: 94263 RVA: 0x003482BF File Offset: 0x003464BF
		public ICheckClientConditionGroupQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Condition = null;
		}
	}
}

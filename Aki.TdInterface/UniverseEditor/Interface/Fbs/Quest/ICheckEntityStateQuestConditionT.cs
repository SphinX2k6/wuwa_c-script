using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004164 RID: 16740
	public class ICheckEntityStateQuestConditionT
	{
		// Token: 0x1700716B RID: 29035
		// (get) Token: 0x0601706B RID: 94315 RVA: 0x00348ADE File Offset: 0x00346CDE
		// (set) Token: 0x0601706C RID: 94316 RVA: 0x00348AE6 File Offset: 0x00346CE6
		public EChildQuest Type { get; set; }

		// Token: 0x1700716C RID: 29036
		// (get) Token: 0x0601706D RID: 94317 RVA: 0x00348AEF File Offset: 0x00346CEF
		// (set) Token: 0x0601706E RID: 94318 RVA: 0x00348AF7 File Offset: 0x00346CF7
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x1700716D RID: 29037
		// (get) Token: 0x0601706F RID: 94319 RVA: 0x00348B00 File Offset: 0x00346D00
		// (set) Token: 0x06017070 RID: 94320 RVA: 0x00348B08 File Offset: 0x00346D08
		public List<IEntityStateConditionT> Conditions { get; set; }

		// Token: 0x06017071 RID: 94321 RVA: 0x00348B11 File Offset: 0x00346D11
		public ICheckEntityStateQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Conditions = null;
		}
	}
}

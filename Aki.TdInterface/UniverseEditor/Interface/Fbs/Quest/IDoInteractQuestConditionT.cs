using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200421B RID: 16923
	public class IDoInteractQuestConditionT
	{
		// Token: 0x17007345 RID: 29509
		// (get) Token: 0x0601782E RID: 96302 RVA: 0x0035B582 File Offset: 0x00359782
		// (set) Token: 0x0601782F RID: 96303 RVA: 0x0035B58A File Offset: 0x0035978A
		public EChildQuest Type { get; set; }

		// Token: 0x17007346 RID: 29510
		// (get) Token: 0x06017830 RID: 96304 RVA: 0x0035B593 File Offset: 0x00359793
		// (set) Token: 0x06017831 RID: 96305 RVA: 0x0035B59B File Offset: 0x0035979B
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007347 RID: 29511
		// (get) Token: 0x06017832 RID: 96306 RVA: 0x0035B5A4 File Offset: 0x003597A4
		// (set) Token: 0x06017833 RID: 96307 RVA: 0x0035B5AC File Offset: 0x003597AC
		public List<IAddInteractOptionT> AddOptions { get; set; }

		// Token: 0x06017834 RID: 96308 RVA: 0x0035B5B5 File Offset: 0x003597B5
		public IDoInteractQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.AddOptions = null;
		}
	}
}

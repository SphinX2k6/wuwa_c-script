using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042B4 RID: 17076
	public class IGetItemQuestConditionT
	{
		// Token: 0x170074D1 RID: 29905
		// (get) Token: 0x06017EC6 RID: 97990 RVA: 0x0036A85E File Offset: 0x00368A5E
		// (set) Token: 0x06017EC7 RID: 97991 RVA: 0x0036A866 File Offset: 0x00368A66
		public EChildQuest Type { get; set; }

		// Token: 0x170074D2 RID: 29906
		// (get) Token: 0x06017EC8 RID: 97992 RVA: 0x0036A86F File Offset: 0x00368A6F
		// (set) Token: 0x06017EC9 RID: 97993 RVA: 0x0036A877 File Offset: 0x00368A77
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170074D3 RID: 29907
		// (get) Token: 0x06017ECA RID: 97994 RVA: 0x0036A880 File Offset: 0x00368A80
		// (set) Token: 0x06017ECB RID: 97995 RVA: 0x0036A888 File Offset: 0x00368A88
		public List<IItemConfigT> Items { get; set; }

		// Token: 0x06017ECC RID: 97996 RVA: 0x0036A891 File Offset: 0x00368A91
		public IGetItemQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Items = null;
		}
	}
}

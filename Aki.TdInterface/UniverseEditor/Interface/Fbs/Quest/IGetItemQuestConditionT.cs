using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E79 RID: 15993
	public class IGetItemQuestConditionT
	{
		// Token: 0x17006EE9 RID: 28393
		// (get) Token: 0x0601688F RID: 92303 RVA: 0x00341ADA File Offset: 0x0033FCDA
		// (set) Token: 0x06016890 RID: 92304 RVA: 0x00341AE2 File Offset: 0x0033FCE2
		public EChildQuest Type { get; set; }

		// Token: 0x17006EEA RID: 28394
		// (get) Token: 0x06016891 RID: 92305 RVA: 0x00341AEB File Offset: 0x0033FCEB
		// (set) Token: 0x06016892 RID: 92306 RVA: 0x00341AF3 File Offset: 0x0033FCF3
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006EEB RID: 28395
		// (get) Token: 0x06016893 RID: 92307 RVA: 0x00341AFC File Offset: 0x0033FCFC
		// (set) Token: 0x06016894 RID: 92308 RVA: 0x00341B04 File Offset: 0x0033FD04
		public List<IItemConfigT> Items { get; set; }

		// Token: 0x06016895 RID: 92309 RVA: 0x00341B0D File Offset: 0x0033FD0D
		public IGetItemQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Items = null;
		}
	}
}

using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DE0 RID: 15840
	public class IDoInteractQuestConditionT
	{
		// Token: 0x17006D65 RID: 28005
		// (get) Token: 0x0601620F RID: 90639 RVA: 0x00332B7E File Offset: 0x00330D7E
		// (set) Token: 0x06016210 RID: 90640 RVA: 0x00332B86 File Offset: 0x00330D86
		public EChildQuest Type { get; set; }

		// Token: 0x17006D66 RID: 28006
		// (get) Token: 0x06016211 RID: 90641 RVA: 0x00332B8F File Offset: 0x00330D8F
		// (set) Token: 0x06016212 RID: 90642 RVA: 0x00332B97 File Offset: 0x00330D97
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006D67 RID: 28007
		// (get) Token: 0x06016213 RID: 90643 RVA: 0x00332BA0 File Offset: 0x00330DA0
		// (set) Token: 0x06016214 RID: 90644 RVA: 0x00332BA8 File Offset: 0x00330DA8
		public List<IAddInteractOptionT> AddOptions { get; set; }

		// Token: 0x06016215 RID: 90645 RVA: 0x00332BB1 File Offset: 0x00330DB1
		public IDoInteractQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.AddOptions = null;
		}
	}
}

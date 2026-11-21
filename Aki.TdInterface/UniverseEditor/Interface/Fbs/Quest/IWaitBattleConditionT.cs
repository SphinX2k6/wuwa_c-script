using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046DD RID: 18141
	public class IWaitBattleConditionT
	{
		// Token: 0x17007F09 RID: 32521
		// (get) Token: 0x0601AAC2 RID: 109250 RVA: 0x003CAA67 File Offset: 0x003C8C67
		// (set) Token: 0x0601AAC3 RID: 109251 RVA: 0x003CAA6F File Offset: 0x003C8C6F
		public EChildQuest Type { get; set; }

		// Token: 0x17007F0A RID: 32522
		// (get) Token: 0x0601AAC4 RID: 109252 RVA: 0x003CAA78 File Offset: 0x003C8C78
		// (set) Token: 0x0601AAC5 RID: 109253 RVA: 0x003CAA80 File Offset: 0x003C8C80
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007F0B RID: 32523
		// (get) Token: 0x0601AAC6 RID: 109254 RVA: 0x003CAA89 File Offset: 0x003C8C89
		// (set) Token: 0x0601AAC7 RID: 109255 RVA: 0x003CAA91 File Offset: 0x003C8C91
		public EConditionCount Count { get; set; }

		// Token: 0x17007F0C RID: 32524
		// (get) Token: 0x0601AAC8 RID: 109256 RVA: 0x003CAA9A File Offset: 0x003C8C9A
		// (set) Token: 0x0601AAC9 RID: 109257 RVA: 0x003CAAA2 File Offset: 0x003C8CA2
		public List<TBattleConditionUnion> Option { get; set; }

		// Token: 0x0601AACA RID: 109258 RVA: 0x003CAAAB File Offset: 0x003C8CAB
		public IWaitBattleConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Count = EConditionCount.All;
			this.Option = null;
		}
	}
}

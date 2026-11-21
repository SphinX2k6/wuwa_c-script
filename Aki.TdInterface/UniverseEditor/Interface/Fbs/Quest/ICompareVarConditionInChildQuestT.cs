using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041B8 RID: 16824
	public class ICompareVarConditionInChildQuestT
	{
		// Token: 0x17007245 RID: 29253
		// (get) Token: 0x06017416 RID: 95254 RVA: 0x00351E20 File Offset: 0x00350020
		// (set) Token: 0x06017417 RID: 95255 RVA: 0x00351E28 File Offset: 0x00350028
		public EChildQuest Type { get; set; }

		// Token: 0x17007246 RID: 29254
		// (get) Token: 0x06017418 RID: 95256 RVA: 0x00351E31 File Offset: 0x00350031
		// (set) Token: 0x06017419 RID: 95257 RVA: 0x00351E39 File Offset: 0x00350039
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007247 RID: 29255
		// (get) Token: 0x0601741A RID: 95258 RVA: 0x00351E42 File Offset: 0x00350042
		// (set) Token: 0x0601741B RID: 95259 RVA: 0x00351E4A File Offset: 0x0035004A
		public EConditionCount Count { get; set; }

		// Token: 0x17007248 RID: 29256
		// (get) Token: 0x0601741C RID: 95260 RVA: 0x00351E53 File Offset: 0x00350053
		// (set) Token: 0x0601741D RID: 95261 RVA: 0x00351E5B File Offset: 0x0035005B
		public List<ICompareVarInChildQuestT> Conditions { get; set; }

		// Token: 0x0601741E RID: 95262 RVA: 0x00351E64 File Offset: 0x00350064
		public ICompareVarConditionInChildQuestT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Count = EConditionCount.All;
			this.Conditions = null;
		}
	}
}

using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DCE RID: 15822
	public class IDetectCombatState2ConditionT
	{
		// Token: 0x17006D3C RID: 27964
		// (get) Token: 0x06016165 RID: 90469 RVA: 0x00331768 File Offset: 0x0032F968
		// (set) Token: 0x06016166 RID: 90470 RVA: 0x00331770 File Offset: 0x0032F970
		public EChildQuest Type { get; set; }

		// Token: 0x17006D3D RID: 27965
		// (get) Token: 0x06016167 RID: 90471 RVA: 0x00331779 File Offset: 0x0032F979
		// (set) Token: 0x06016168 RID: 90472 RVA: 0x00331781 File Offset: 0x0032F981
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006D3E RID: 27966
		// (get) Token: 0x06016169 RID: 90473 RVA: 0x0033178A File Offset: 0x0032F98A
		// (set) Token: 0x0601616A RID: 90474 RVA: 0x00331792 File Offset: 0x0032F992
		public EConditionCount Count { get; set; }

		// Token: 0x17006D3F RID: 27967
		// (get) Token: 0x0601616B RID: 90475 RVA: 0x0033179B File Offset: 0x0032F99B
		// (set) Token: 0x0601616C RID: 90476 RVA: 0x003317A3 File Offset: 0x0032F9A3
		public List<ICombatState2ConditionT> Conditions { get; set; }

		// Token: 0x0601616D RID: 90477 RVA: 0x003317AC File Offset: 0x0032F9AC
		public IDetectCombatState2ConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Count = EConditionCount.All;
			this.Conditions = null;
		}
	}
}

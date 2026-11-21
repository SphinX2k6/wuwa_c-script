using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004209 RID: 16905
	public class IDetectCombatState2ConditionT
	{
		// Token: 0x1700731C RID: 29468
		// (get) Token: 0x06017784 RID: 96132 RVA: 0x0035A16C File Offset: 0x0035836C
		// (set) Token: 0x06017785 RID: 96133 RVA: 0x0035A174 File Offset: 0x00358374
		public EChildQuest Type { get; set; }

		// Token: 0x1700731D RID: 29469
		// (get) Token: 0x06017786 RID: 96134 RVA: 0x0035A17D File Offset: 0x0035837D
		// (set) Token: 0x06017787 RID: 96135 RVA: 0x0035A185 File Offset: 0x00358385
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x1700731E RID: 29470
		// (get) Token: 0x06017788 RID: 96136 RVA: 0x0035A18E File Offset: 0x0035838E
		// (set) Token: 0x06017789 RID: 96137 RVA: 0x0035A196 File Offset: 0x00358396
		public EConditionCount Count { get; set; }

		// Token: 0x1700731F RID: 29471
		// (get) Token: 0x0601778A RID: 96138 RVA: 0x0035A19F File Offset: 0x0035839F
		// (set) Token: 0x0601778B RID: 96139 RVA: 0x0035A1A7 File Offset: 0x003583A7
		public List<ICombatState2ConditionT> Conditions { get; set; }

		// Token: 0x0601778C RID: 96140 RVA: 0x0035A1B0 File Offset: 0x003583B0
		public IDetectCombatState2ConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Count = EConditionCount.All;
			this.Conditions = null;
		}
	}
}

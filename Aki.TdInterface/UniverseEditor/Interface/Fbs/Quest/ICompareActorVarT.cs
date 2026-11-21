using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041B2 RID: 16818
	public class ICompareActorVarT
	{
		// Token: 0x17007233 RID: 29235
		// (get) Token: 0x060173CB RID: 95179 RVA: 0x00351270 File Offset: 0x0034F470
		// (set) Token: 0x060173CC RID: 95180 RVA: 0x00351278 File Offset: 0x0034F478
		public EChildQuest Type { get; set; }

		// Token: 0x17007234 RID: 29236
		// (get) Token: 0x060173CD RID: 95181 RVA: 0x00351281 File Offset: 0x0034F481
		// (set) Token: 0x060173CE RID: 95182 RVA: 0x00351289 File Offset: 0x0034F489
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007235 RID: 29237
		// (get) Token: 0x060173CF RID: 95183 RVA: 0x00351292 File Offset: 0x0034F492
		// (set) Token: 0x060173D0 RID: 95184 RVA: 0x0035129A File Offset: 0x0034F49A
		public EConditionCount Count { get; set; }

		// Token: 0x17007236 RID: 29238
		// (get) Token: 0x060173D1 RID: 95185 RVA: 0x003512A3 File Offset: 0x0034F4A3
		// (set) Token: 0x060173D2 RID: 95186 RVA: 0x003512AB File Offset: 0x0034F4AB
		public List<ICompareActorVarInChildQuestT> Conditions { get; set; }

		// Token: 0x060173D3 RID: 95187 RVA: 0x003512B4 File Offset: 0x0034F4B4
		public ICompareActorVarT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Count = EConditionCount.All;
			this.Conditions = null;
		}
	}
}

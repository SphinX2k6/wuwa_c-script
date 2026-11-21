using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004305 RID: 17157
	public class IKillChildQuestConditionT
	{
		// Token: 0x1700757F RID: 30079
		// (get) Token: 0x060181EC RID: 98796 RVA: 0x00371252 File Offset: 0x0036F452
		// (set) Token: 0x060181ED RID: 98797 RVA: 0x0037125A File Offset: 0x0036F45A
		public EChildQuest Type { get; set; }

		// Token: 0x17007580 RID: 30080
		// (get) Token: 0x060181EE RID: 98798 RVA: 0x00371263 File Offset: 0x0036F463
		// (set) Token: 0x060181EF RID: 98799 RVA: 0x0037126B File Offset: 0x0036F46B
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007581 RID: 30081
		// (get) Token: 0x060181F0 RID: 98800 RVA: 0x00371274 File Offset: 0x0036F474
		// (set) Token: 0x060181F1 RID: 98801 RVA: 0x0037127C File Offset: 0x0036F47C
		public List<int> ExistTargets { get; set; }

		// Token: 0x17007582 RID: 30082
		// (get) Token: 0x060181F2 RID: 98802 RVA: 0x00371285 File Offset: 0x0036F485
		// (set) Token: 0x060181F3 RID: 98803 RVA: 0x0037128D File Offset: 0x0036F48D
		public List<int> TargetsToAwake { get; set; }

		// Token: 0x17007583 RID: 30083
		// (get) Token: 0x060181F4 RID: 98804 RVA: 0x00371296 File Offset: 0x0036F496
		// (set) Token: 0x060181F5 RID: 98805 RVA: 0x0037129E File Offset: 0x0036F49E
		public TVarRefUnion PrefabVar { get; set; }

		// Token: 0x17007584 RID: 30084
		// (get) Token: 0x060181F6 RID: 98806 RVA: 0x003712A7 File Offset: 0x0036F4A7
		// (set) Token: 0x060181F7 RID: 98807 RVA: 0x003712AF File Offset: 0x0036F4AF
		public List<IEntityDeadPositionT> EntityDeadPositions { get; set; }

		// Token: 0x17007585 RID: 30085
		// (get) Token: 0x060181F8 RID: 98808 RVA: 0x003712B8 File Offset: 0x0036F4B8
		// (set) Token: 0x060181F9 RID: 98809 RVA: 0x003712C0 File Offset: 0x0036F4C0
		public List<ISpecificMonsterDeadPositionT> SpecificMonsterDeadPositions { get; set; }

		// Token: 0x17007586 RID: 30086
		// (get) Token: 0x060181FA RID: 98810 RVA: 0x003712C9 File Offset: 0x0036F4C9
		// (set) Token: 0x060181FB RID: 98811 RVA: 0x003712D1 File Offset: 0x0036F4D1
		public byte NullMask { get; set; }

		// Token: 0x060181FC RID: 98812 RVA: 0x003712DA File Offset: 0x0036F4DA
		public IKillChildQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.ExistTargets = null;
			this.TargetsToAwake = null;
			this.PrefabVar = null;
			this.EntityDeadPositions = null;
			this.SpecificMonsterDeadPositions = null;
			this.NullMask = 0;
		}
	}
}

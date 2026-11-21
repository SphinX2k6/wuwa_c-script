using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004167 RID: 16743
	public class ICheckLevelPlayQuestConditionT
	{
		// Token: 0x17007173 RID: 29043
		// (get) Token: 0x0601708F RID: 94351 RVA: 0x00348F9C File Offset: 0x0034719C
		// (set) Token: 0x06017090 RID: 94352 RVA: 0x00348FA4 File Offset: 0x003471A4
		public EChildQuest Type { get; set; }

		// Token: 0x17007174 RID: 29044
		// (get) Token: 0x06017091 RID: 94353 RVA: 0x00348FAD File Offset: 0x003471AD
		// (set) Token: 0x06017092 RID: 94354 RVA: 0x00348FB5 File Offset: 0x003471B5
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007175 RID: 29045
		// (get) Token: 0x06017093 RID: 94355 RVA: 0x00348FBE File Offset: 0x003471BE
		// (set) Token: 0x06017094 RID: 94356 RVA: 0x00348FC6 File Offset: 0x003471C6
		public List<int> LevelPlayIds { get; set; }

		// Token: 0x17007176 RID: 29046
		// (get) Token: 0x06017095 RID: 94357 RVA: 0x00348FCF File Offset: 0x003471CF
		// (set) Token: 0x06017096 RID: 94358 RVA: 0x00348FD7 File Offset: 0x003471D7
		public int CompleteNumber { get; set; }

		// Token: 0x06017097 RID: 94359 RVA: 0x00348FE0 File Offset: 0x003471E0
		public ICheckLevelPlayQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.LevelPlayIds = null;
			this.CompleteNumber = 0;
		}
	}
}

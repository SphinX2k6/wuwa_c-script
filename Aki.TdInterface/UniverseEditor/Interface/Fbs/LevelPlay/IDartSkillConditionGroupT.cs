using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048EB RID: 18667
	public class IDartSkillConditionGroupT
	{
		// Token: 0x1700820A RID: 33290
		// (get) Token: 0x0601BA57 RID: 113239 RVA: 0x003E8D3B File Offset: 0x003E6F3B
		// (set) Token: 0x0601BA58 RID: 113240 RVA: 0x003E8D43 File Offset: 0x003E6F43
		public EConditionCount Type { get; set; }

		// Token: 0x1700820B RID: 33291
		// (get) Token: 0x0601BA59 RID: 113241 RVA: 0x003E8D4C File Offset: 0x003E6F4C
		// (set) Token: 0x0601BA5A RID: 113242 RVA: 0x003E8D54 File Offset: 0x003E6F54
		public List<TDartSkillConditionUnion> Conditions { get; set; }

		// Token: 0x0601BA5B RID: 113243 RVA: 0x003E8D5D File Offset: 0x003E6F5D
		public IDartSkillConditionGroupT()
		{
			this.Type = EConditionCount.All;
			this.Conditions = null;
		}
	}
}

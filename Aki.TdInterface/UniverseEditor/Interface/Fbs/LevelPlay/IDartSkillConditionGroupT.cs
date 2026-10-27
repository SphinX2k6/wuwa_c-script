using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004483 RID: 17539
	public class IDartSkillConditionGroupT
	{
		// Token: 0x17007BCB RID: 31691
		// (get) Token: 0x0601A286 RID: 107142 RVA: 0x003BCB2F File Offset: 0x003BAD2F
		// (set) Token: 0x0601A287 RID: 107143 RVA: 0x003BCB37 File Offset: 0x003BAD37
		public EConditionCount Type { get; set; }

		// Token: 0x17007BCC RID: 31692
		// (get) Token: 0x0601A288 RID: 107144 RVA: 0x003BCB40 File Offset: 0x003BAD40
		// (set) Token: 0x0601A289 RID: 107145 RVA: 0x003BCB48 File Offset: 0x003BAD48
		public List<TDartSkillConditionUnion> Conditions { get; set; }

		// Token: 0x0601A28A RID: 107146 RVA: 0x003BCB51 File Offset: 0x003BAD51
		public IDartSkillConditionGroupT()
		{
			this.Type = EConditionCount.All;
			this.Conditions = null;
		}
	}
}

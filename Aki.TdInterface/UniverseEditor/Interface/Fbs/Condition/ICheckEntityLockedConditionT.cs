using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ECD RID: 20173
	public class ICheckEntityLockedConditionT
	{
		// Token: 0x17009006 RID: 36870
		// (get) Token: 0x0601F4E9 RID: 128233 RVA: 0x0045D091 File Offset: 0x0045B291
		// (set) Token: 0x0601F4EA RID: 128234 RVA: 0x0045D099 File Offset: 0x0045B299
		public ECondition Type { get; set; }

		// Token: 0x17009007 RID: 36871
		// (get) Token: 0x0601F4EB RID: 128235 RVA: 0x0045D0A2 File Offset: 0x0045B2A2
		// (set) Token: 0x0601F4EC RID: 128236 RVA: 0x0045D0AA File Offset: 0x0045B2AA
		public List<int> Entities { get; set; }

		// Token: 0x17009008 RID: 36872
		// (get) Token: 0x0601F4ED RID: 128237 RVA: 0x0045D0B3 File Offset: 0x0045B2B3
		// (set) Token: 0x0601F4EE RID: 128238 RVA: 0x0045D0BB File Offset: 0x0045B2BB
		public bool IsLocked { get; set; }

		// Token: 0x0601F4EF RID: 128239 RVA: 0x0045D0C4 File Offset: 0x0045B2C4
		public ICheckEntityLockedConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Entities = null;
			this.IsLocked = false;
		}
	}
}

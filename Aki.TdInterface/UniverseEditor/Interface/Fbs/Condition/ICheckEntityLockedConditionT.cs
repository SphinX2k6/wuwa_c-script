using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A0D RID: 18957
	public class ICheckEntityLockedConditionT
	{
		// Token: 0x17008936 RID: 35126
		// (get) Token: 0x0601DA76 RID: 121462 RVA: 0x0042C425 File Offset: 0x0042A625
		// (set) Token: 0x0601DA77 RID: 121463 RVA: 0x0042C42D File Offset: 0x0042A62D
		public ECondition Type { get; set; }

		// Token: 0x17008937 RID: 35127
		// (get) Token: 0x0601DA78 RID: 121464 RVA: 0x0042C436 File Offset: 0x0042A636
		// (set) Token: 0x0601DA79 RID: 121465 RVA: 0x0042C43E File Offset: 0x0042A63E
		public List<int> Entities { get; set; }

		// Token: 0x17008938 RID: 35128
		// (get) Token: 0x0601DA7A RID: 121466 RVA: 0x0042C447 File Offset: 0x0042A647
		// (set) Token: 0x0601DA7B RID: 121467 RVA: 0x0042C44F File Offset: 0x0042A64F
		public bool IsLocked { get; set; }

		// Token: 0x0601DA7C RID: 121468 RVA: 0x0042C458 File Offset: 0x0042A658
		public ICheckEntityLockedConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Entities = null;
			this.IsLocked = false;
		}
	}
}

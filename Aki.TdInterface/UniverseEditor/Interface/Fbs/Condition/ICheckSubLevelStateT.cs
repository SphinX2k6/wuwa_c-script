using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005017 RID: 20503
	public class ICheckSubLevelStateT
	{
		// Token: 0x170092B4 RID: 37556
		// (get) Token: 0x06020029 RID: 131113 RVA: 0x00471265 File Offset: 0x0046F465
		// (set) Token: 0x0602002A RID: 131114 RVA: 0x0047126D File Offset: 0x0046F46D
		public ECondition Type { get; set; }

		// Token: 0x170092B5 RID: 37557
		// (get) Token: 0x0602002B RID: 131115 RVA: 0x00471276 File Offset: 0x0046F476
		// (set) Token: 0x0602002C RID: 131116 RVA: 0x0047127E File Offset: 0x0046F47E
		public EConditionCount ConditionCount { get; set; }

		// Token: 0x170092B6 RID: 37558
		// (get) Token: 0x0602002D RID: 131117 RVA: 0x00471287 File Offset: 0x0046F487
		// (set) Token: 0x0602002E RID: 131118 RVA: 0x0047128F File Offset: 0x0046F48F
		public List<ICheckSubLevelStateConfigT> CheckList { get; set; }

		// Token: 0x0602002F RID: 131119 RVA: 0x00471298 File Offset: 0x0046F498
		public ICheckSubLevelStateT()
		{
			this.Type = ECondition.CompareVar;
			this.ConditionCount = EConditionCount.All;
			this.CheckList = null;
		}
	}
}

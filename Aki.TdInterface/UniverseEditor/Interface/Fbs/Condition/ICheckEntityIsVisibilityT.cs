using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A0A RID: 18954
	public class ICheckEntityIsVisibilityT
	{
		// Token: 0x1700892F RID: 35119
		// (get) Token: 0x0601DA54 RID: 121428 RVA: 0x0042C062 File Offset: 0x0042A262
		// (set) Token: 0x0601DA55 RID: 121429 RVA: 0x0042C06A File Offset: 0x0042A26A
		public ECondition Type { get; set; }

		// Token: 0x17008930 RID: 35120
		// (get) Token: 0x0601DA56 RID: 121430 RVA: 0x0042C073 File Offset: 0x0042A273
		// (set) Token: 0x0601DA57 RID: 121431 RVA: 0x0042C07B File Offset: 0x0042A27B
		public int EntityId { get; set; }

		// Token: 0x17008931 RID: 35121
		// (get) Token: 0x0601DA58 RID: 121432 RVA: 0x0042C084 File Offset: 0x0042A284
		// (set) Token: 0x0601DA59 RID: 121433 RVA: 0x0042C08C File Offset: 0x0042A28C
		public bool IsVisible { get; set; }

		// Token: 0x0601DA5A RID: 121434 RVA: 0x0042C095 File Offset: 0x0042A295
		public ICheckEntityIsVisibilityT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityId = 0;
			this.IsVisible = false;
		}
	}
}

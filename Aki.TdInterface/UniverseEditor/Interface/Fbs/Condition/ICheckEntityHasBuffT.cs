using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A04 RID: 18948
	public class ICheckEntityHasBuffT
	{
		// Token: 0x1700891E RID: 35102
		// (get) Token: 0x0601DA12 RID: 121362 RVA: 0x0042B943 File Offset: 0x00429B43
		// (set) Token: 0x0601DA13 RID: 121363 RVA: 0x0042B94B File Offset: 0x00429B4B
		public ECondition Type { get; set; }

		// Token: 0x1700891F RID: 35103
		// (get) Token: 0x0601DA14 RID: 121364 RVA: 0x0042B954 File Offset: 0x00429B54
		// (set) Token: 0x0601DA15 RID: 121365 RVA: 0x0042B95C File Offset: 0x00429B5C
		public IMonsterBuffContainerT Target { get; set; }

		// Token: 0x17008920 RID: 35104
		// (get) Token: 0x0601DA16 RID: 121366 RVA: 0x0042B965 File Offset: 0x00429B65
		// (set) Token: 0x0601DA17 RID: 121367 RVA: 0x0042B96D File Offset: 0x00429B6D
		public long BuffId { get; set; }

		// Token: 0x17008921 RID: 35105
		// (get) Token: 0x0601DA18 RID: 121368 RVA: 0x0042B976 File Offset: 0x00429B76
		// (set) Token: 0x0601DA19 RID: 121369 RVA: 0x0042B97E File Offset: 0x00429B7E
		public bool HasBuff { get; set; }

		// Token: 0x0601DA1A RID: 121370 RVA: 0x0042B987 File Offset: 0x00429B87
		public ICheckEntityHasBuffT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
			this.BuffId = 0L;
			this.HasBuff = false;
		}
	}
}

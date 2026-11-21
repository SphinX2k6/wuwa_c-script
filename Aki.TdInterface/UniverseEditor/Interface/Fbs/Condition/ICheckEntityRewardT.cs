using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ED6 RID: 20182
	public class ICheckEntityRewardT
	{
		// Token: 0x1700901F RID: 36895
		// (get) Token: 0x0601F546 RID: 128326 RVA: 0x0045DB5E File Offset: 0x0045BD5E
		// (set) Token: 0x0601F547 RID: 128327 RVA: 0x0045DB66 File Offset: 0x0045BD66
		public ECondition Type { get; set; }

		// Token: 0x17009020 RID: 36896
		// (get) Token: 0x0601F548 RID: 128328 RVA: 0x0045DB6F File Offset: 0x0045BD6F
		// (set) Token: 0x0601F549 RID: 128329 RVA: 0x0045DB77 File Offset: 0x0045BD77
		public int EntityId { get; set; }

		// Token: 0x17009021 RID: 36897
		// (get) Token: 0x0601F54A RID: 128330 RVA: 0x0045DB80 File Offset: 0x0045BD80
		// (set) Token: 0x0601F54B RID: 128331 RVA: 0x0045DB88 File Offset: 0x0045BD88
		public byte NullMask { get; set; }

		// Token: 0x0601F54C RID: 128332 RVA: 0x0045DB91 File Offset: 0x0045BD91
		public ICheckEntityRewardT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityId = 0;
			this.NullMask = 0;
		}
	}
}

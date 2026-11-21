using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C4C RID: 23628
	public class IOnThrowTriggerTimeConditionT
	{
		// Token: 0x1700AD8E RID: 44430
		// (get) Token: 0x060272C3 RID: 160451 RVA: 0x0055DD22 File Offset: 0x0055BF22
		// (set) Token: 0x060272C4 RID: 160452 RVA: 0x0055DD2A File Offset: 0x0055BF2A
		public EBulletCreateCondition Type { get; set; }

		// Token: 0x1700AD8F RID: 44431
		// (get) Token: 0x060272C5 RID: 160453 RVA: 0x0055DD33 File Offset: 0x0055BF33
		// (set) Token: 0x060272C6 RID: 160454 RVA: 0x0055DD3B File Offset: 0x0055BF3B
		public long BulletId { get; set; }

		// Token: 0x1700AD90 RID: 44432
		// (get) Token: 0x060272C7 RID: 160455 RVA: 0x0055DD44 File Offset: 0x0055BF44
		// (set) Token: 0x060272C8 RID: 160456 RVA: 0x0055DD4C File Offset: 0x0055BF4C
		public float TriggerTime { get; set; }

		// Token: 0x060272C9 RID: 160457 RVA: 0x0055DD55 File Offset: 0x0055BF55
		public IOnThrowTriggerTimeConditionT()
		{
			this.Type = EBulletCreateCondition.OnHit;
			this.BulletId = 0L;
			this.TriggerTime = 0f;
		}
	}
}

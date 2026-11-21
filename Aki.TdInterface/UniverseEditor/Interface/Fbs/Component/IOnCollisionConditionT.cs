using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C37 RID: 23607
	public class IOnCollisionConditionT
	{
		// Token: 0x1700AD63 RID: 44387
		// (get) Token: 0x0602720F RID: 160271 RVA: 0x0055CA11 File Offset: 0x0055AC11
		// (set) Token: 0x06027210 RID: 160272 RVA: 0x0055CA19 File Offset: 0x0055AC19
		public EBulletCreateCondition Type { get; set; }

		// Token: 0x1700AD64 RID: 44388
		// (get) Token: 0x06027211 RID: 160273 RVA: 0x0055CA22 File Offset: 0x0055AC22
		// (set) Token: 0x06027212 RID: 160274 RVA: 0x0055CA2A File Offset: 0x0055AC2A
		public long BulletId { get; set; }

		// Token: 0x1700AD65 RID: 44389
		// (get) Token: 0x06027213 RID: 160275 RVA: 0x0055CA33 File Offset: 0x0055AC33
		// (set) Token: 0x06027214 RID: 160276 RVA: 0x0055CA3B File Offset: 0x0055AC3B
		public ITriggerCountConfigT TriggerCount { get; set; }

		// Token: 0x06027215 RID: 160277 RVA: 0x0055CA44 File Offset: 0x0055AC44
		public IOnCollisionConditionT()
		{
			this.Type = EBulletCreateCondition.OnHit;
			this.BulletId = 0L;
			this.TriggerCount = null;
		}
	}
}

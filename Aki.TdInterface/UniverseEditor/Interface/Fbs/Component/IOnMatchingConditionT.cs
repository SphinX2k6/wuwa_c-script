using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C43 RID: 23619
	public class IOnMatchingConditionT
	{
		// Token: 0x1700AD7E RID: 44414
		// (get) Token: 0x0602727F RID: 160383 RVA: 0x0055D6B4 File Offset: 0x0055B8B4
		// (set) Token: 0x06027280 RID: 160384 RVA: 0x0055D6BC File Offset: 0x0055B8BC
		public EBulletCreateCondition Type { get; set; }

		// Token: 0x1700AD7F RID: 44415
		// (get) Token: 0x06027281 RID: 160385 RVA: 0x0055D6C5 File Offset: 0x0055B8C5
		// (set) Token: 0x06027282 RID: 160386 RVA: 0x0055D6CD File Offset: 0x0055B8CD
		public long BulletId { get; set; }

		// Token: 0x06027283 RID: 160387 RVA: 0x0055D6D6 File Offset: 0x0055B8D6
		public IOnMatchingConditionT()
		{
			this.Type = EBulletCreateCondition.OnHit;
			this.BulletId = 0L;
		}
	}
}

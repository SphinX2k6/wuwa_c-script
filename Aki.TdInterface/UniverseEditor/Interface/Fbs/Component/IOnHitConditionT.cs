using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C40 RID: 23616
	public class IOnHitConditionT
	{
		// Token: 0x1700AD79 RID: 44409
		// (get) Token: 0x06027269 RID: 160361 RVA: 0x0055D4B4 File Offset: 0x0055B6B4
		// (set) Token: 0x0602726A RID: 160362 RVA: 0x0055D4BC File Offset: 0x0055B6BC
		public EBulletCreateCondition Type { get; set; }

		// Token: 0x1700AD7A RID: 44410
		// (get) Token: 0x0602726B RID: 160363 RVA: 0x0055D4C5 File Offset: 0x0055B6C5
		// (set) Token: 0x0602726C RID: 160364 RVA: 0x0055D4CD File Offset: 0x0055B6CD
		public long BulletId { get; set; }

		// Token: 0x0602726D RID: 160365 RVA: 0x0055D4D6 File Offset: 0x0055B6D6
		public IOnHitConditionT()
		{
			this.Type = EBulletCreateCondition.OnHit;
			this.BulletId = 0L;
		}
	}
}

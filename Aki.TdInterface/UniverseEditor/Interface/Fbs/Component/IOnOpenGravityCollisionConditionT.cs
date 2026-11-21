using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C49 RID: 23625
	public class IOnOpenGravityCollisionConditionT
	{
		// Token: 0x1700AD88 RID: 44424
		// (get) Token: 0x060272AB RID: 160427 RVA: 0x0055DAB4 File Offset: 0x0055BCB4
		// (set) Token: 0x060272AC RID: 160428 RVA: 0x0055DABC File Offset: 0x0055BCBC
		public EBulletCreateCondition Type { get; set; }

		// Token: 0x1700AD89 RID: 44425
		// (get) Token: 0x060272AD RID: 160429 RVA: 0x0055DAC5 File Offset: 0x0055BCC5
		// (set) Token: 0x060272AE RID: 160430 RVA: 0x0055DACD File Offset: 0x0055BCCD
		public long BulletId { get; set; }

		// Token: 0x060272AF RID: 160431 RVA: 0x0055DAD6 File Offset: 0x0055BCD6
		public IOnOpenGravityCollisionConditionT()
		{
			this.Type = EBulletCreateCondition.OnHit;
			this.BulletId = 0L;
		}
	}
}

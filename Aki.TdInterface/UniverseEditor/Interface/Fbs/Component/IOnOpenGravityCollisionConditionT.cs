using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056A5 RID: 22181
	public class IOnOpenGravityCollisionConditionT
	{
		// Token: 0x1700A4F4 RID: 42228
		// (get) Token: 0x06025056 RID: 151638 RVA: 0x0051CB6C File Offset: 0x0051AD6C
		// (set) Token: 0x06025057 RID: 151639 RVA: 0x0051CB74 File Offset: 0x0051AD74
		public EBulletCreateCondition Type { get; set; }

		// Token: 0x1700A4F5 RID: 42229
		// (get) Token: 0x06025058 RID: 151640 RVA: 0x0051CB7D File Offset: 0x0051AD7D
		// (set) Token: 0x06025059 RID: 151641 RVA: 0x0051CB85 File Offset: 0x0051AD85
		public long BulletId { get; set; }

		// Token: 0x0602505A RID: 151642 RVA: 0x0051CB8E File Offset: 0x0051AD8E
		public IOnOpenGravityCollisionConditionT()
		{
			this.Type = EBulletCreateCondition.OnHit;
			this.BulletId = 0L;
		}
	}
}

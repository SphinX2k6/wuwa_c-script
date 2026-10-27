using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200569C RID: 22172
	public class IOnHitConditionT
	{
		// Token: 0x1700A4E5 RID: 42213
		// (get) Token: 0x06025014 RID: 151572 RVA: 0x0051C56C File Offset: 0x0051A76C
		// (set) Token: 0x06025015 RID: 151573 RVA: 0x0051C574 File Offset: 0x0051A774
		public EBulletCreateCondition Type { get; set; }

		// Token: 0x1700A4E6 RID: 42214
		// (get) Token: 0x06025016 RID: 151574 RVA: 0x0051C57D File Offset: 0x0051A77D
		// (set) Token: 0x06025017 RID: 151575 RVA: 0x0051C585 File Offset: 0x0051A785
		public long BulletId { get; set; }

		// Token: 0x06025018 RID: 151576 RVA: 0x0051C58E File Offset: 0x0051A78E
		public IOnHitConditionT()
		{
			this.Type = EBulletCreateCondition.OnHit;
			this.BulletId = 0L;
		}
	}
}

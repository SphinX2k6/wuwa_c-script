using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007745 RID: 30533
	public class ISeqEventFireBulletT
	{
		// Token: 0x1700DFCF RID: 57295
		// (get) Token: 0x06035930 RID: 219440 RVA: 0x0072E2FA File Offset: 0x0072C4FA
		// (set) Token: 0x06035931 RID: 219441 RVA: 0x0072E302 File Offset: 0x0072C502
		public long BulletId { get; set; }

		// Token: 0x06035932 RID: 219442 RVA: 0x0072E30B File Offset: 0x0072C50B
		public ISeqEventFireBulletT()
		{
			this.BulletId = 0L;
		}
	}
}

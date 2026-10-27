using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F7F RID: 28543
	public class ISeqEventFireBulletT
	{
		// Token: 0x1700D400 RID: 54272
		// (get) Token: 0x060326E0 RID: 206560 RVA: 0x006CE942 File Offset: 0x006CCB42
		// (set) Token: 0x060326E1 RID: 206561 RVA: 0x006CE94A File Offset: 0x006CCB4A
		public long BulletId { get; set; }

		// Token: 0x060326E2 RID: 206562 RVA: 0x006CE953 File Offset: 0x006CCB53
		public ISeqEventFireBulletT()
		{
			this.BulletId = 0L;
		}
	}
}

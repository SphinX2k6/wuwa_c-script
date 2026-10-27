using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005696 RID: 22166
	public class IOnCollisionConditionT
	{
		// Token: 0x1700A4D4 RID: 42196
		// (get) Token: 0x06024FD6 RID: 151510 RVA: 0x0051BE75 File Offset: 0x0051A075
		// (set) Token: 0x06024FD7 RID: 151511 RVA: 0x0051BE7D File Offset: 0x0051A07D
		public EBulletCreateCondition Type { get; set; }

		// Token: 0x1700A4D5 RID: 42197
		// (get) Token: 0x06024FD8 RID: 151512 RVA: 0x0051BE86 File Offset: 0x0051A086
		// (set) Token: 0x06024FD9 RID: 151513 RVA: 0x0051BE8E File Offset: 0x0051A08E
		public long BulletId { get; set; }

		// Token: 0x1700A4D6 RID: 42198
		// (get) Token: 0x06024FDA RID: 151514 RVA: 0x0051BE97 File Offset: 0x0051A097
		// (set) Token: 0x06024FDB RID: 151515 RVA: 0x0051BE9F File Offset: 0x0051A09F
		public ITriggerCountConfigT TriggerCount { get; set; }

		// Token: 0x06024FDC RID: 151516 RVA: 0x0051BEA8 File Offset: 0x0051A0A8
		public IOnCollisionConditionT()
		{
			this.Type = EBulletCreateCondition.OnHit;
			this.BulletId = 0L;
			this.TriggerCount = null;
		}
	}
}

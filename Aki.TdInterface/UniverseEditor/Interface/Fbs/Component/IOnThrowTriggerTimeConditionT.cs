using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056A8 RID: 22184
	public class IOnThrowTriggerTimeConditionT
	{
		// Token: 0x1700A4FA RID: 42234
		// (get) Token: 0x0602506E RID: 151662 RVA: 0x0051CDDA File Offset: 0x0051AFDA
		// (set) Token: 0x0602506F RID: 151663 RVA: 0x0051CDE2 File Offset: 0x0051AFE2
		public EBulletCreateCondition Type { get; set; }

		// Token: 0x1700A4FB RID: 42235
		// (get) Token: 0x06025070 RID: 151664 RVA: 0x0051CDEB File Offset: 0x0051AFEB
		// (set) Token: 0x06025071 RID: 151665 RVA: 0x0051CDF3 File Offset: 0x0051AFF3
		public long BulletId { get; set; }

		// Token: 0x1700A4FC RID: 42236
		// (get) Token: 0x06025072 RID: 151666 RVA: 0x0051CDFC File Offset: 0x0051AFFC
		// (set) Token: 0x06025073 RID: 151667 RVA: 0x0051CE04 File Offset: 0x0051B004
		public float TriggerTime { get; set; }

		// Token: 0x06025074 RID: 151668 RVA: 0x0051CE0D File Offset: 0x0051B00D
		public IOnThrowTriggerTimeConditionT()
		{
			this.Type = EBulletCreateCondition.OnHit;
			this.BulletId = 0L;
			this.TriggerTime = 0f;
		}
	}
}

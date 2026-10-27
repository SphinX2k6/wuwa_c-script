using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200569F RID: 22175
	public class IOnMatchingConditionT
	{
		// Token: 0x1700A4EA RID: 42218
		// (get) Token: 0x0602502A RID: 151594 RVA: 0x0051C76C File Offset: 0x0051A96C
		// (set) Token: 0x0602502B RID: 151595 RVA: 0x0051C774 File Offset: 0x0051A974
		public EBulletCreateCondition Type { get; set; }

		// Token: 0x1700A4EB RID: 42219
		// (get) Token: 0x0602502C RID: 151596 RVA: 0x0051C77D File Offset: 0x0051A97D
		// (set) Token: 0x0602502D RID: 151597 RVA: 0x0051C785 File Offset: 0x0051A985
		public long BulletId { get; set; }

		// Token: 0x0602502E RID: 151598 RVA: 0x0051C78E File Offset: 0x0051A98E
		public IOnMatchingConditionT()
		{
			this.Type = EBulletCreateCondition.OnHit;
			this.BulletId = 0L;
		}
	}
}

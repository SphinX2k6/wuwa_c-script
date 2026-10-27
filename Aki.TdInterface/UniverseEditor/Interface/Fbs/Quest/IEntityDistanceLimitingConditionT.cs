using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E0A RID: 15882
	public class IEntityDistanceLimitingConditionT
	{
		// Token: 0x17006DC4 RID: 28100
		// (get) Token: 0x06016392 RID: 91026 RVA: 0x00335706 File Offset: 0x00333906
		// (set) Token: 0x06016393 RID: 91027 RVA: 0x0033570E File Offset: 0x0033390E
		public int EntityId { get; set; }

		// Token: 0x17006DC5 RID: 28101
		// (get) Token: 0x06016394 RID: 91028 RVA: 0x00335717 File Offset: 0x00333917
		// (set) Token: 0x06016395 RID: 91029 RVA: 0x0033571F File Offset: 0x0033391F
		public float MaxDistance { get; set; }

		// Token: 0x17006DC6 RID: 28102
		// (get) Token: 0x06016396 RID: 91030 RVA: 0x00335728 File Offset: 0x00333928
		// (set) Token: 0x06016397 RID: 91031 RVA: 0x00335730 File Offset: 0x00333930
		public float OverMaxCountdown { get; set; }

		// Token: 0x06016398 RID: 91032 RVA: 0x00335739 File Offset: 0x00333939
		public IEntityDistanceLimitingConditionT()
		{
			this.EntityId = 0;
			this.MaxDistance = 0f;
			this.OverMaxCountdown = 0f;
		}
	}
}

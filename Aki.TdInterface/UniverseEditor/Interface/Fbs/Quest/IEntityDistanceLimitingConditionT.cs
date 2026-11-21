using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004245 RID: 16965
	public class IEntityDistanceLimitingConditionT
	{
		// Token: 0x170073AA RID: 29610
		// (get) Token: 0x060179BF RID: 96703 RVA: 0x0035E2FE File Offset: 0x0035C4FE
		// (set) Token: 0x060179C0 RID: 96704 RVA: 0x0035E306 File Offset: 0x0035C506
		public int EntityId { get; set; }

		// Token: 0x170073AB RID: 29611
		// (get) Token: 0x060179C1 RID: 96705 RVA: 0x0035E30F File Offset: 0x0035C50F
		// (set) Token: 0x060179C2 RID: 96706 RVA: 0x0035E317 File Offset: 0x0035C517
		public float MaxDistance { get; set; }

		// Token: 0x170073AC RID: 29612
		// (get) Token: 0x060179C3 RID: 96707 RVA: 0x0035E320 File Offset: 0x0035C520
		// (set) Token: 0x060179C4 RID: 96708 RVA: 0x0035E328 File Offset: 0x0035C528
		public float OverMaxCountdown { get; set; }

		// Token: 0x060179C5 RID: 96709 RVA: 0x0035E331 File Offset: 0x0035C531
		public IEntityDistanceLimitingConditionT()
		{
			this.EntityId = 0;
			this.MaxDistance = 0f;
			this.OverMaxCountdown = 0f;
		}
	}
}

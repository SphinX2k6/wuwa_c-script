using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057C7 RID: 22471
	public class IQuantityRefillConditionT
	{
		// Token: 0x1700A7B6 RID: 42934
		// (get) Token: 0x06025B76 RID: 154486 RVA: 0x00533888 File Offset: 0x00531A88
		// (set) Token: 0x06025B77 RID: 154487 RVA: 0x00533890 File Offset: 0x00531A90
		public ESpawnMonsterCompleteCondition Type { get; set; }

		// Token: 0x1700A7B7 RID: 42935
		// (get) Token: 0x06025B78 RID: 154488 RVA: 0x00533899 File Offset: 0x00531A99
		// (set) Token: 0x06025B79 RID: 154489 RVA: 0x005338A1 File Offset: 0x00531AA1
		public int Quantity { get; set; }

		// Token: 0x1700A7B8 RID: 42936
		// (get) Token: 0x06025B7A RID: 154490 RVA: 0x005338AA File Offset: 0x00531AAA
		// (set) Token: 0x06025B7B RID: 154491 RVA: 0x005338B2 File Offset: 0x00531AB2
		public float DelayRefill { get; set; }

		// Token: 0x1700A7B9 RID: 42937
		// (get) Token: 0x06025B7C RID: 154492 RVA: 0x005338BB File Offset: 0x00531ABB
		// (set) Token: 0x06025B7D RID: 154493 RVA: 0x005338C3 File Offset: 0x00531AC3
		public byte NullMask { get; set; }

		// Token: 0x06025B7E RID: 154494 RVA: 0x005338CC File Offset: 0x00531ACC
		public IQuantityRefillConditionT()
		{
			this.Type = ESpawnMonsterCompleteCondition.AllKill;
			this.Quantity = 0;
			this.DelayRefill = 0f;
			this.NullMask = 0;
		}
	}
}

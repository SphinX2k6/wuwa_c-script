using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050D0 RID: 20688
	public class IDurationConditionT
	{
		// Token: 0x17009691 RID: 38545
		// (get) Token: 0x0602148B RID: 136331 RVA: 0x0049F7EC File Offset: 0x0049D9EC
		// (set) Token: 0x0602148C RID: 136332 RVA: 0x0049F7F4 File Offset: 0x0049D9F4
		public ESpawnMonsterCompleteCondition Type { get; set; }

		// Token: 0x17009692 RID: 38546
		// (get) Token: 0x0602148D RID: 136333 RVA: 0x0049F7FD File Offset: 0x0049D9FD
		// (set) Token: 0x0602148E RID: 136334 RVA: 0x0049F805 File Offset: 0x0049DA05
		public float Duration { get; set; }

		// Token: 0x17009693 RID: 38547
		// (get) Token: 0x0602148F RID: 136335 RVA: 0x0049F80E File Offset: 0x0049DA0E
		// (set) Token: 0x06021490 RID: 136336 RVA: 0x0049F816 File Offset: 0x0049DA16
		public bool Refill { get; set; }

		// Token: 0x17009694 RID: 38548
		// (get) Token: 0x06021491 RID: 136337 RVA: 0x0049F81F File Offset: 0x0049DA1F
		// (set) Token: 0x06021492 RID: 136338 RVA: 0x0049F827 File Offset: 0x0049DA27
		public byte NullMask { get; set; }

		// Token: 0x06021493 RID: 136339 RVA: 0x0049F830 File Offset: 0x0049DA30
		public IDurationConditionT()
		{
			this.Type = ESpawnMonsterCompleteCondition.AllKill;
			this.Duration = 0f;
			this.Refill = false;
			this.NullMask = 0;
		}
	}
}

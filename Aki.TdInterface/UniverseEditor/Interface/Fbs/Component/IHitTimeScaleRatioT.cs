using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200592E RID: 22830
	public class IHitTimeScaleRatioT
	{
		// Token: 0x1700A58F RID: 42383
		// (get) Token: 0x060251FC RID: 152060 RVA: 0x00518290 File Offset: 0x00516490
		// (set) Token: 0x060251FD RID: 152061 RVA: 0x00518298 File Offset: 0x00516498
		public float TimeRatio { get; set; }

		// Token: 0x1700A590 RID: 42384
		// (get) Token: 0x060251FE RID: 152062 RVA: 0x005182A1 File Offset: 0x005164A1
		// (set) Token: 0x060251FF RID: 152063 RVA: 0x005182A9 File Offset: 0x005164A9
		public float MaxExtraTime { get; set; }

		// Token: 0x1700A591 RID: 42385
		// (get) Token: 0x06025200 RID: 152064 RVA: 0x005182B2 File Offset: 0x005164B2
		// (set) Token: 0x06025201 RID: 152065 RVA: 0x005182BA File Offset: 0x005164BA
		public float ValueRatio { get; set; }

		// Token: 0x1700A592 RID: 42386
		// (get) Token: 0x06025202 RID: 152066 RVA: 0x005182C3 File Offset: 0x005164C3
		// (set) Token: 0x06025203 RID: 152067 RVA: 0x005182CB File Offset: 0x005164CB
		public byte NullMask { get; set; }

		// Token: 0x06025204 RID: 152068 RVA: 0x005182D4 File Offset: 0x005164D4
		public IHitTimeScaleRatioT()
		{
			this.TimeRatio = 0f;
			this.MaxExtraTime = 0f;
			this.ValueRatio = 0f;
			this.NullMask = 0;
		}
	}
}

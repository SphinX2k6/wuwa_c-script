using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C1B RID: 31771
	public class ITraceSplineT
	{
		// Token: 0x1700EDDF RID: 60895
		// (get) Token: 0x06039427 RID: 234535 RVA: 0x007BBBED File Offset: 0x007B9DED
		// (set) Token: 0x06039428 RID: 234536 RVA: 0x007BBBF5 File Offset: 0x007B9DF5
		public string EffectPath { get; set; }

		// Token: 0x1700EDE0 RID: 60896
		// (get) Token: 0x06039429 RID: 234537 RVA: 0x007BBBFE File Offset: 0x007B9DFE
		// (set) Token: 0x0603942A RID: 234538 RVA: 0x007BBC06 File Offset: 0x007B9E06
		public int Duration { get; set; }

		// Token: 0x1700EDE1 RID: 60897
		// (get) Token: 0x0603942B RID: 234539 RVA: 0x007BBC0F File Offset: 0x007B9E0F
		// (set) Token: 0x0603942C RID: 234540 RVA: 0x007BBC17 File Offset: 0x007B9E17
		public int SplineEntityId { get; set; }

		// Token: 0x0603942D RID: 234541 RVA: 0x007BBC20 File Offset: 0x007B9E20
		public ITraceSplineT()
		{
			this.EffectPath = null;
			this.Duration = 0;
			this.SplineEntityId = 0;
		}
	}
}

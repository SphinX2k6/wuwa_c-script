using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BA6 RID: 31654
	public class ITeleportTransitionWithPlayFlowT
	{
		// Token: 0x1700ED14 RID: 60692
		// (get) Token: 0x06039089 RID: 233609 RVA: 0x007B5388 File Offset: 0x007B3588
		// (set) Token: 0x0603908A RID: 233610 RVA: 0x007B5390 File Offset: 0x007B3590
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700ED15 RID: 60693
		// (get) Token: 0x0603908B RID: 233611 RVA: 0x007B5399 File Offset: 0x007B3599
		// (set) Token: 0x0603908C RID: 233612 RVA: 0x007B53A1 File Offset: 0x007B35A1
		public IPlayFlowT Flow { get; set; }

		// Token: 0x1700ED16 RID: 60694
		// (get) Token: 0x0603908D RID: 233613 RVA: 0x007B53AA File Offset: 0x007B35AA
		// (set) Token: 0x0603908E RID: 233614 RVA: 0x007B53B2 File Offset: 0x007B35B2
		public IFadeBackgroundFadeInEffectT FadeInEffect { get; set; }

		// Token: 0x1700ED17 RID: 60695
		// (get) Token: 0x0603908F RID: 233615 RVA: 0x007B53BB File Offset: 0x007B35BB
		// (set) Token: 0x06039090 RID: 233616 RVA: 0x007B53C3 File Offset: 0x007B35C3
		public IFadeBackgroundFadeOutEffectT FadeOutEffect { get; set; }

		// Token: 0x06039091 RID: 233617 RVA: 0x007B53CC File Offset: 0x007B35CC
		public ITeleportTransitionWithPlayFlowT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.Flow = null;
			this.FadeInEffect = null;
			this.FadeOutEffect = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DFB RID: 28155
	public class IFadeBackgroundImageT
	{
		// Token: 0x1700CE57 RID: 52823
		// (get) Token: 0x060309AF RID: 199087 RVA: 0x00699548 File Offset: 0x00697748
		// (set) Token: 0x060309B0 RID: 199088 RVA: 0x00699550 File Offset: 0x00697750
		public EFadeBackgroundType Type { get; set; }

		// Token: 0x1700CE58 RID: 52824
		// (get) Token: 0x060309B1 RID: 199089 RVA: 0x00699559 File Offset: 0x00697759
		// (set) Token: 0x060309B2 RID: 199090 RVA: 0x00699561 File Offset: 0x00697761
		public string BackgroundImage { get; set; }

		// Token: 0x1700CE59 RID: 52825
		// (get) Token: 0x060309B3 RID: 199091 RVA: 0x0069956A File Offset: 0x0069776A
		// (set) Token: 0x060309B4 RID: 199092 RVA: 0x00699572 File Offset: 0x00697772
		public IFadeBackgroundFadeInEffectT FadeInEffect { get; set; }

		// Token: 0x1700CE5A RID: 52826
		// (get) Token: 0x060309B5 RID: 199093 RVA: 0x0069957B File Offset: 0x0069777B
		// (set) Token: 0x060309B6 RID: 199094 RVA: 0x00699583 File Offset: 0x00697783
		public IFadeBackgroundFadeOutEffectT FadeOutEffect { get; set; }

		// Token: 0x060309B7 RID: 199095 RVA: 0x0069958C File Offset: 0x0069778C
		public IFadeBackgroundImageT()
		{
			this.Type = EFadeBackgroundType.Spine;
			this.BackgroundImage = null;
			this.FadeInEffect = null;
			this.FadeOutEffect = null;
		}
	}
}

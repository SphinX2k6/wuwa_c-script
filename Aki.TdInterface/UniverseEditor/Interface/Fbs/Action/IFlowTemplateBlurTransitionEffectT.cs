using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006823 RID: 26659
	public class IFlowTemplateBlurTransitionEffectT
	{
		// Token: 0x1700C609 RID: 50697
		// (get) Token: 0x0602E796 RID: 190358 RVA: 0x00657B4C File Offset: 0x00655D4C
		// (set) Token: 0x0602E797 RID: 190359 RVA: 0x00657B54 File Offset: 0x00655D54
		public EFlowTemplateTransitionEffectType Type { get; set; }

		// Token: 0x1700C60A RID: 50698
		// (get) Token: 0x0602E798 RID: 190360 RVA: 0x00657B5D File Offset: 0x00655D5D
		// (set) Token: 0x0602E799 RID: 190361 RVA: 0x00657B65 File Offset: 0x00655D65
		public float Aperture { get; set; }

		// Token: 0x1700C60B RID: 50699
		// (get) Token: 0x0602E79A RID: 190362 RVA: 0x00657B6E File Offset: 0x00655D6E
		// (set) Token: 0x0602E79B RID: 190363 RVA: 0x00657B76 File Offset: 0x00655D76
		public float FadeInTime { get; set; }

		// Token: 0x1700C60C RID: 50700
		// (get) Token: 0x0602E79C RID: 190364 RVA: 0x00657B7F File Offset: 0x00655D7F
		// (set) Token: 0x0602E79D RID: 190365 RVA: 0x00657B87 File Offset: 0x00655D87
		public float FadeOutTime { get; set; }

		// Token: 0x0602E79E RID: 190366 RVA: 0x00657B90 File Offset: 0x00655D90
		public IFlowTemplateBlurTransitionEffectT()
		{
			this.Type = EFlowTemplateTransitionEffectType.Blur;
			this.Aperture = 0f;
			this.FadeInTime = 0f;
			this.FadeOutTime = 0f;
		}
	}
}

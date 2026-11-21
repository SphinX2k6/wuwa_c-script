using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EA9 RID: 28329
	public class IFlowTemplateBlurTransitionEffectT
	{
		// Token: 0x1700CFCD RID: 53197
		// (get) Token: 0x0603101E RID: 200734 RVA: 0x006A5A8C File Offset: 0x006A3C8C
		// (set) Token: 0x0603101F RID: 200735 RVA: 0x006A5A94 File Offset: 0x006A3C94
		public EFlowTemplateTransitionEffectType Type { get; set; }

		// Token: 0x1700CFCE RID: 53198
		// (get) Token: 0x06031020 RID: 200736 RVA: 0x006A5A9D File Offset: 0x006A3C9D
		// (set) Token: 0x06031021 RID: 200737 RVA: 0x006A5AA5 File Offset: 0x006A3CA5
		public float Aperture { get; set; }

		// Token: 0x1700CFCF RID: 53199
		// (get) Token: 0x06031022 RID: 200738 RVA: 0x006A5AAE File Offset: 0x006A3CAE
		// (set) Token: 0x06031023 RID: 200739 RVA: 0x006A5AB6 File Offset: 0x006A3CB6
		public float FadeInTime { get; set; }

		// Token: 0x1700CFD0 RID: 53200
		// (get) Token: 0x06031024 RID: 200740 RVA: 0x006A5ABF File Offset: 0x006A3CBF
		// (set) Token: 0x06031025 RID: 200741 RVA: 0x006A5AC7 File Offset: 0x006A3CC7
		public float FadeOutTime { get; set; }

		// Token: 0x06031026 RID: 200742 RVA: 0x006A5AD0 File Offset: 0x006A3CD0
		public IFlowTemplateBlurTransitionEffectT()
		{
			this.Type = EFlowTemplateTransitionEffectType.Blur;
			this.Aperture = 0f;
			this.FadeInTime = 0f;
			this.FadeOutTime = 0f;
		}
	}
}

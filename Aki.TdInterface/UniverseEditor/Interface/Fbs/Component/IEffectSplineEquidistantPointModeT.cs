using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200511E RID: 20766
	public class IEffectSplineEquidistantPointModeT
	{
		// Token: 0x17009749 RID: 38729
		// (get) Token: 0x0602176E RID: 137070 RVA: 0x004A53F0 File Offset: 0x004A35F0
		// (set) Token: 0x0602176F RID: 137071 RVA: 0x004A53F8 File Offset: 0x004A35F8
		public EEffectSplineCreateMode Type { get; set; }

		// Token: 0x1700974A RID: 38730
		// (get) Token: 0x06021770 RID: 137072 RVA: 0x004A5401 File Offset: 0x004A3601
		// (set) Token: 0x06021771 RID: 137073 RVA: 0x004A5409 File Offset: 0x004A3609
		public int Space { get; set; }

		// Token: 0x06021772 RID: 137074 RVA: 0x004A5412 File Offset: 0x004A3612
		public IEffectSplineEquidistantPointModeT()
		{
			this.Type = EEffectSplineCreateMode.WholeLine;
			this.Space = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005121 RID: 20769
	public class IEffectSplineWholeLineModeT
	{
		// Token: 0x1700974D RID: 38733
		// (get) Token: 0x06021782 RID: 137090 RVA: 0x004A558E File Offset: 0x004A378E
		// (set) Token: 0x06021783 RID: 137091 RVA: 0x004A5596 File Offset: 0x004A3796
		public EEffectSplineCreateMode Type { get; set; }

		// Token: 0x06021784 RID: 137092 RVA: 0x004A559F File Offset: 0x004A379F
		public IEffectSplineWholeLineModeT()
		{
			this.Type = EEffectSplineCreateMode.WholeLine;
		}
	}
}

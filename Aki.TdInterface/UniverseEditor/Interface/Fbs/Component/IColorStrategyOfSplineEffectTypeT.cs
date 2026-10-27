using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FBF RID: 20415
	public class IColorStrategyOfSplineEffectTypeT
	{
		// Token: 0x170093DF RID: 37855
		// (get) Token: 0x0602080D RID: 133133 RVA: 0x0048567A File Offset: 0x0048387A
		// (set) Token: 0x0602080E RID: 133134 RVA: 0x00485682 File Offset: 0x00483882
		public EColorChangeStrategyOfSplineEffect Type { get; set; }

		// Token: 0x0602080F RID: 133135 RVA: 0x0048568B File Offset: 0x0048388B
		public IColorStrategyOfSplineEffectTypeT()
		{
			this.Type = EColorChangeStrategyOfSplineEffect.RGB;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200760D RID: 30221
	public class IResetFocusConfigT
	{
		// Token: 0x1700DE0E RID: 56846
		// (get) Token: 0x0603506B RID: 217195 RVA: 0x0071F8BB File Offset: 0x0071DABB
		// (set) Token: 0x0603506C RID: 217196 RVA: 0x0071F8C3 File Offset: 0x0071DAC3
		public float FadeInTime { get; set; }

		// Token: 0x1700DE0F RID: 56847
		// (get) Token: 0x0603506D RID: 217197 RVA: 0x0071F8CC File Offset: 0x0071DACC
		// (set) Token: 0x0603506E RID: 217198 RVA: 0x0071F8D4 File Offset: 0x0071DAD4
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x0603506F RID: 217199 RVA: 0x0071F8DD File Offset: 0x0071DADD
		public IResetFocusConfigT()
		{
			this.FadeInTime = 0f;
			this.FadeInCurve = null;
		}
	}
}

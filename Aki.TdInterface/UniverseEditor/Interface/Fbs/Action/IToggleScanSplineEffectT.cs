using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C09 RID: 31753
	public class IToggleScanSplineEffectT
	{
		// Token: 0x1700EDCA RID: 60874
		// (get) Token: 0x060393B4 RID: 234420 RVA: 0x007BB1A6 File Offset: 0x007B93A6
		// (set) Token: 0x060393B5 RID: 234421 RVA: 0x007BB1AE File Offset: 0x007B93AE
		public ETraceSplineOptionType Type { get; set; }

		// Token: 0x060393B6 RID: 234422 RVA: 0x007BB1B7 File Offset: 0x007B93B7
		public IToggleScanSplineEffectT()
		{
			this.Type = ETraceSplineOptionType.Open;
		}
	}
}

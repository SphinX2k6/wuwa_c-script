using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006839 RID: 26681
	public class IAvgShakeUiT
	{
		// Token: 0x1700C431 RID: 50225
		// (get) Token: 0x0602D9A1 RID: 186785 RVA: 0x0063D510 File Offset: 0x0063B710
		// (set) Token: 0x0602D9A2 RID: 186786 RVA: 0x0063D518 File Offset: 0x0063B718
		public EAvgShakeUiIntensity Intensity { get; set; }

		// Token: 0x1700C432 RID: 50226
		// (get) Token: 0x0602D9A3 RID: 186787 RVA: 0x0063D521 File Offset: 0x0063B721
		// (set) Token: 0x0602D9A4 RID: 186788 RVA: 0x0063D529 File Offset: 0x0063B729
		public int RepeatCount { get; set; }

		// Token: 0x0602D9A5 RID: 186789 RVA: 0x0063D532 File Offset: 0x0063B732
		public IAvgShakeUiT()
		{
			this.Intensity = EAvgShakeUiIntensity.Weak;
			this.RepeatCount = 0;
		}
	}
}

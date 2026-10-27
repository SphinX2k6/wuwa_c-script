using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061CB RID: 25035
	public class IAvgShakeUiT
	{
		// Token: 0x1700BAAE RID: 47790
		// (get) Token: 0x0602B25A RID: 176730 RVA: 0x005F2A9C File Offset: 0x005F0C9C
		// (set) Token: 0x0602B25B RID: 176731 RVA: 0x005F2AA4 File Offset: 0x005F0CA4
		public EAvgShakeUiIntensity Intensity { get; set; }

		// Token: 0x1700BAAF RID: 47791
		// (get) Token: 0x0602B25C RID: 176732 RVA: 0x005F2AAD File Offset: 0x005F0CAD
		// (set) Token: 0x0602B25D RID: 176733 RVA: 0x005F2AB5 File Offset: 0x005F0CB5
		public int RepeatCount { get; set; }

		// Token: 0x0602B25E RID: 176734 RVA: 0x005F2ABE File Offset: 0x005F0CBE
		public IAvgShakeUiT()
		{
			this.Intensity = EAvgShakeUiIntensity.Weak;
			this.RepeatCount = 0;
		}
	}
}

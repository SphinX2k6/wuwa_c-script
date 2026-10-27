using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055E2 RID: 21986
	public class IMovementVehicleFeatureT
	{
		// Token: 0x1700A2B2 RID: 41650
		// (get) Token: 0x06024799 RID: 149401 RVA: 0x005090CB File Offset: 0x005072CB
		// (set) Token: 0x0602479A RID: 149402 RVA: 0x005090D3 File Offset: 0x005072D3
		public EVehicleFeatureFlag Type { get; set; }

		// Token: 0x1700A2B3 RID: 41651
		// (get) Token: 0x0602479B RID: 149403 RVA: 0x005090DC File Offset: 0x005072DC
		// (set) Token: 0x0602479C RID: 149404 RVA: 0x005090E4 File Offset: 0x005072E4
		public int MoveSpline { get; set; }

		// Token: 0x1700A2B4 RID: 41652
		// (get) Token: 0x0602479D RID: 149405 RVA: 0x005090ED File Offset: 0x005072ED
		// (set) Token: 0x0602479E RID: 149406 RVA: 0x005090F5 File Offset: 0x005072F5
		public IMovementPerformConfigT MovePerformConfig { get; set; }

		// Token: 0x1700A2B5 RID: 41653
		// (get) Token: 0x0602479F RID: 149407 RVA: 0x005090FE File Offset: 0x005072FE
		// (set) Token: 0x060247A0 RID: 149408 RVA: 0x00509106 File Offset: 0x00507306
		public byte NullMask { get; set; }

		// Token: 0x060247A1 RID: 149409 RVA: 0x0050910F File Offset: 0x0050730F
		public IMovementVehicleFeatureT()
		{
			this.Type = EVehicleFeatureFlag.None;
			this.MoveSpline = 0;
			this.MovePerformConfig = null;
			this.NullMask = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DB0 RID: 28080
	public class IExitVehicleSeatStandUpT
	{
		// Token: 0x1700CDE4 RID: 52708
		// (get) Token: 0x06030781 RID: 198529 RVA: 0x00695852 File Offset: 0x00693A52
		// (set) Token: 0x06030782 RID: 198530 RVA: 0x0069585A File Offset: 0x00693A5A
		public EExitVehicleType Type { get; set; }

		// Token: 0x06030783 RID: 198531 RVA: 0x00695863 File Offset: 0x00693A63
		public IExitVehicleSeatStandUpT()
		{
			this.Type = EExitVehicleType.Launch;
		}
	}
}

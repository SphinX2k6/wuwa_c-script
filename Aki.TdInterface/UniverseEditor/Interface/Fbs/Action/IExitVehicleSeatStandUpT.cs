using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006730 RID: 26416
	public class IExitVehicleSeatStandUpT
	{
		// Token: 0x1700C42E RID: 50222
		// (get) Token: 0x0602DF3B RID: 188219 RVA: 0x0064810E File Offset: 0x0064630E
		// (set) Token: 0x0602DF3C RID: 188220 RVA: 0x00648116 File Offset: 0x00646316
		public EExitVehicleType Type { get; set; }

		// Token: 0x0602DF3D RID: 188221 RVA: 0x0064811F File Offset: 0x0064631F
		public IExitVehicleSeatStandUpT()
		{
			this.Type = EExitVehicleType.Launch;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006733 RID: 26419
	public class IExitVehicleStandUpT
	{
		// Token: 0x1700C431 RID: 50225
		// (get) Token: 0x0602DF4D RID: 188237 RVA: 0x00648286 File Offset: 0x00646486
		// (set) Token: 0x0602DF4E RID: 188238 RVA: 0x0064828E File Offset: 0x0064648E
		public EExitVehicleType Type { get; set; }

		// Token: 0x0602DF4F RID: 188239 RVA: 0x00648297 File Offset: 0x00646497
		public IExitVehicleStandUpT()
		{
			this.Type = EExitVehicleType.Launch;
		}
	}
}

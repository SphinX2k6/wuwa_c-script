using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DB9 RID: 28089
	public class IExitVehicleTypeT
	{
		// Token: 0x1700CDF1 RID: 52721
		// (get) Token: 0x060307BF RID: 198591 RVA: 0x00695ED6 File Offset: 0x006940D6
		// (set) Token: 0x060307C0 RID: 198592 RVA: 0x00695EDE File Offset: 0x006940DE
		public EExitVehicleType Type { get; set; }

		// Token: 0x060307C1 RID: 198593 RVA: 0x00695EE7 File Offset: 0x006940E7
		public IExitVehicleTypeT()
		{
			this.Type = EExitVehicleType.Launch;
		}
	}
}

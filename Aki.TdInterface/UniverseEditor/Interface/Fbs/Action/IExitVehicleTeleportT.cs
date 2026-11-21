using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DB6 RID: 28086
	public class IExitVehicleTeleportT
	{
		// Token: 0x1700CDEC RID: 52716
		// (get) Token: 0x060307A9 RID: 198569 RVA: 0x00695CD8 File Offset: 0x00693ED8
		// (set) Token: 0x060307AA RID: 198570 RVA: 0x00695CE0 File Offset: 0x00693EE0
		public EExitVehicleType Type { get; set; }

		// Token: 0x1700CDED RID: 52717
		// (get) Token: 0x060307AB RID: 198571 RVA: 0x00695CE9 File Offset: 0x00693EE9
		// (set) Token: 0x060307AC RID: 198572 RVA: 0x00695CF1 File Offset: 0x00693EF1
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700CDEE RID: 52718
		// (get) Token: 0x060307AD RID: 198573 RVA: 0x00695CFA File Offset: 0x00693EFA
		// (set) Token: 0x060307AE RID: 198574 RVA: 0x00695D02 File Offset: 0x00693F02
		public IVectorInfoT Rot { get; set; }

		// Token: 0x060307AF RID: 198575 RVA: 0x00695D0B File Offset: 0x00693F0B
		public IExitVehicleTeleportT()
		{
			this.Type = EExitVehicleType.Launch;
			this.Pos = null;
			this.Rot = null;
		}
	}
}

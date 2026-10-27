using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007503 RID: 29955
	public class IVehicleEnterT
	{
		// Token: 0x1700E34A RID: 58186
		// (get) Token: 0x06036798 RID: 223128 RVA: 0x007668D1 File Offset: 0x00764AD1
		// (set) Token: 0x06036799 RID: 223129 RVA: 0x007668D9 File Offset: 0x00764AD9
		public TVehicleEnteringTargetUnion EnteringTarget { get; set; }

		// Token: 0x1700E34B RID: 58187
		// (get) Token: 0x0603679A RID: 223130 RVA: 0x007668E2 File Offset: 0x00764AE2
		// (set) Token: 0x0603679B RID: 223131 RVA: 0x007668EA File Offset: 0x00764AEA
		public TTargetVehicleUnion VehicleTarget { get; set; }

		// Token: 0x1700E34C RID: 58188
		// (get) Token: 0x0603679C RID: 223132 RVA: 0x007668F3 File Offset: 0x00764AF3
		// (set) Token: 0x0603679D RID: 223133 RVA: 0x007668FB File Offset: 0x00764AFB
		public EVehicleSeat Seat { get; set; }

		// Token: 0x1700E34D RID: 58189
		// (get) Token: 0x0603679E RID: 223134 RVA: 0x00766904 File Offset: 0x00764B04
		// (set) Token: 0x0603679F RID: 223135 RVA: 0x0076690C File Offset: 0x00764B0C
		public bool ForceExitLastVehicle { get; set; }

		// Token: 0x1700E34E RID: 58190
		// (get) Token: 0x060367A0 RID: 223136 RVA: 0x00766915 File Offset: 0x00764B15
		// (set) Token: 0x060367A1 RID: 223137 RVA: 0x0076691D File Offset: 0x00764B1D
		public byte NullMask { get; set; }

		// Token: 0x060367A2 RID: 223138 RVA: 0x00766926 File Offset: 0x00764B26
		public IVehicleEnterT()
		{
			this.EnteringTarget = null;
			this.VehicleTarget = null;
			this.Seat = EVehicleSeat.Seat0;
			this.ForceExitLastVehicle = false;
			this.NullMask = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007521 RID: 29985
	public class IVehicleMoveWithPathLineT
	{
		// Token: 0x1700E389 RID: 58249
		// (get) Token: 0x060368BD RID: 223421 RVA: 0x007692C9 File Offset: 0x007674C9
		// (set) Token: 0x060368BE RID: 223422 RVA: 0x007692D1 File Offset: 0x007674D1
		public TTargetVehicleUnion TargetVehicle { get; set; }

		// Token: 0x1700E38A RID: 58250
		// (get) Token: 0x060368BF RID: 223423 RVA: 0x007692DA File Offset: 0x007674DA
		// (set) Token: 0x060368C0 RID: 223424 RVA: 0x007692E2 File Offset: 0x007674E2
		public int SplineEntityId { get; set; }

		// Token: 0x1700E38B RID: 58251
		// (get) Token: 0x060368C1 RID: 223425 RVA: 0x007692EB File Offset: 0x007674EB
		// (set) Token: 0x060368C2 RID: 223426 RVA: 0x007692F3 File Offset: 0x007674F3
		public TVehicleControlTypeUnion ControlType { get; set; }

		// Token: 0x060368C3 RID: 223427 RVA: 0x007692FC File Offset: 0x007674FC
		public IVehicleMoveWithPathLineT()
		{
			this.TargetVehicle = null;
			this.SplineEntityId = 0;
			this.ControlType = null;
		}
	}
}

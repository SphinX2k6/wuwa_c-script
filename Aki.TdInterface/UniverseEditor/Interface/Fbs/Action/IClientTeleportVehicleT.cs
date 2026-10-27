using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063FE RID: 25598
	public class IClientTeleportVehicleT
	{
		// Token: 0x1700BE9C RID: 48796
		// (get) Token: 0x0602C490 RID: 181392 RVA: 0x00614096 File Offset: 0x00612296
		// (set) Token: 0x0602C491 RID: 181393 RVA: 0x0061409E File Offset: 0x0061229E
		public TTargetVehicleUnion TargetVehicle { get; set; }

		// Token: 0x1700BE9D RID: 48797
		// (get) Token: 0x0602C492 RID: 181394 RVA: 0x006140A7 File Offset: 0x006122A7
		// (set) Token: 0x0602C493 RID: 181395 RVA: 0x006140AF File Offset: 0x006122AF
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700BE9E RID: 48798
		// (get) Token: 0x0602C494 RID: 181396 RVA: 0x006140B8 File Offset: 0x006122B8
		// (set) Token: 0x0602C495 RID: 181397 RVA: 0x006140C0 File Offset: 0x006122C0
		public IVectorInfoT Rot { get; set; }

		// Token: 0x0602C496 RID: 181398 RVA: 0x006140C9 File Offset: 0x006122C9
		public IClientTeleportVehicleT()
		{
			this.TargetVehicle = null;
			this.Pos = null;
			this.Rot = null;
		}
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006736 RID: 26422
	public class IExitVehicleTeleportT
	{
		// Token: 0x1700C436 RID: 50230
		// (get) Token: 0x0602DF63 RID: 188259 RVA: 0x00648594 File Offset: 0x00646794
		// (set) Token: 0x0602DF64 RID: 188260 RVA: 0x0064859C File Offset: 0x0064679C
		public EExitVehicleType Type { get; set; }

		// Token: 0x1700C437 RID: 50231
		// (get) Token: 0x0602DF65 RID: 188261 RVA: 0x006485A5 File Offset: 0x006467A5
		// (set) Token: 0x0602DF66 RID: 188262 RVA: 0x006485AD File Offset: 0x006467AD
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700C438 RID: 50232
		// (get) Token: 0x0602DF67 RID: 188263 RVA: 0x006485B6 File Offset: 0x006467B6
		// (set) Token: 0x0602DF68 RID: 188264 RVA: 0x006485BE File Offset: 0x006467BE
		public IVectorInfoT Rot { get; set; }

		// Token: 0x0602DF69 RID: 188265 RVA: 0x006485C7 File Offset: 0x006467C7
		public IExitVehicleTeleportT()
		{
			this.Type = EExitVehicleType.Launch;
			this.Pos = null;
			this.Rot = null;
		}
	}
}

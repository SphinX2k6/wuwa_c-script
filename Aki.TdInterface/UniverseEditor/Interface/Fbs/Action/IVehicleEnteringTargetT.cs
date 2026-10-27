using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200750C RID: 29964
	public class IVehicleEnteringTargetT
	{
		// Token: 0x1700E363 RID: 58211
		// (get) Token: 0x060367EE RID: 223214 RVA: 0x007671B2 File Offset: 0x007653B2
		// (set) Token: 0x060367EF RID: 223215 RVA: 0x007671BA File Offset: 0x007653BA
		public EVehicleEnteringTarget Type { get; set; }

		// Token: 0x1700E364 RID: 58212
		// (get) Token: 0x060367F0 RID: 223216 RVA: 0x007671C3 File Offset: 0x007653C3
		// (set) Token: 0x060367F1 RID: 223217 RVA: 0x007671CB File Offset: 0x007653CB
		public int TargetVehicle { get; set; }

		// Token: 0x1700E365 RID: 58213
		// (get) Token: 0x060367F2 RID: 223218 RVA: 0x007671D4 File Offset: 0x007653D4
		// (set) Token: 0x060367F3 RID: 223219 RVA: 0x007671DC File Offset: 0x007653DC
		public byte NullMask { get; set; }

		// Token: 0x060367F4 RID: 223220 RVA: 0x007671E5 File Offset: 0x007653E5
		public IVehicleEnteringTargetT()
		{
			this.Type = EVehicleEnteringTarget.Player;
			this.TargetVehicle = 0;
			this.NullMask = 0;
		}
	}
}

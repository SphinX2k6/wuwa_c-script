using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077CB RID: 30667
	public class ISetHorizontalVerticalSpeedImmediatelyT
	{
		// Token: 0x1700E0D1 RID: 57553
		// (get) Token: 0x06035DFB RID: 220667 RVA: 0x00737F19 File Offset: 0x00736119
		// (set) Token: 0x06035DFC RID: 220668 RVA: 0x00737F21 File Offset: 0x00736121
		public ESetVehicleSpeedImmediatelyType Type { get; set; }

		// Token: 0x1700E0D2 RID: 57554
		// (get) Token: 0x06035DFD RID: 220669 RVA: 0x00737F2A File Offset: 0x0073612A
		// (set) Token: 0x06035DFE RID: 220670 RVA: 0x00737F32 File Offset: 0x00736132
		public TProcessedValueUnion HorizontalSpeed { get; set; }

		// Token: 0x1700E0D3 RID: 57555
		// (get) Token: 0x06035DFF RID: 220671 RVA: 0x00737F3B File Offset: 0x0073613B
		// (set) Token: 0x06035E00 RID: 220672 RVA: 0x00737F43 File Offset: 0x00736143
		public TProcessedValueUnion VerticalSpeed { get; set; }

		// Token: 0x06035E01 RID: 220673 RVA: 0x00737F4C File Offset: 0x0073614C
		public ISetHorizontalVerticalSpeedImmediatelyT()
		{
			this.Type = ESetVehicleSpeedImmediatelyType.TotalSpeed;
			this.HorizontalSpeed = null;
			this.VerticalSpeed = null;
		}
	}
}

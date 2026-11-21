using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054F1 RID: 21745
	public class ICircuitConnectPowerPortLayoutT
	{
		// Token: 0x17009B52 RID: 39762
		// (get) Token: 0x0602255D RID: 140637 RVA: 0x004BB800 File Offset: 0x004B9A00
		// (set) Token: 0x0602255E RID: 140638 RVA: 0x004BB808 File Offset: 0x004B9A08
		public ECircuitConnectElementType Type { get; set; }

		// Token: 0x17009B53 RID: 39763
		// (get) Token: 0x0602255F RID: 140639 RVA: 0x004BB811 File Offset: 0x004B9A11
		// (set) Token: 0x06022560 RID: 140640 RVA: 0x004BB819 File Offset: 0x004B9A19
		public ETurntableConnectorDisk Disk { get; set; }

		// Token: 0x06022561 RID: 140641 RVA: 0x004BB822 File Offset: 0x004B9A22
		public ICircuitConnectPowerPortLayoutT()
		{
			this.Type = ECircuitConnectElementType.Straight;
			this.Disk = ETurntableConnectorDisk.Disk0;
		}
	}
}

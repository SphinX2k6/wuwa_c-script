using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054D6 RID: 21718
	public class ICircuitConnectCurveLayoutT
	{
		// Token: 0x17009B29 RID: 39721
		// (get) Token: 0x06022481 RID: 140417 RVA: 0x004B9C84 File Offset: 0x004B7E84
		// (set) Token: 0x06022482 RID: 140418 RVA: 0x004B9C8C File Offset: 0x004B7E8C
		public ECircuitConnectElementType Type { get; set; }

		// Token: 0x17009B2A RID: 39722
		// (get) Token: 0x06022483 RID: 140419 RVA: 0x004B9C95 File Offset: 0x004B7E95
		// (set) Token: 0x06022484 RID: 140420 RVA: 0x004B9C9D File Offset: 0x004B7E9D
		public ETurntableConnectorDisk Disk { get; set; }

		// Token: 0x06022485 RID: 140421 RVA: 0x004B9CA6 File Offset: 0x004B7EA6
		public ICircuitConnectCurveLayoutT()
		{
			this.Type = ECircuitConnectElementType.Straight;
			this.Disk = ETurntableConnectorDisk.Disk0;
		}
	}
}

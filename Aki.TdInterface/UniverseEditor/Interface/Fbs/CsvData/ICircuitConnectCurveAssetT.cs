using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D74 RID: 19828
	public class ICircuitConnectCurveAssetT
	{
		// Token: 0x17008DDF RID: 36319
		// (get) Token: 0x0601EBC1 RID: 125889 RVA: 0x0044C7EC File Offset: 0x0044A9EC
		// (set) Token: 0x0601EBC2 RID: 125890 RVA: 0x0044C7F4 File Offset: 0x0044A9F4
		public ECircuitConnectElementType Type { get; set; }

		// Token: 0x17008DE0 RID: 36320
		// (get) Token: 0x0601EBC3 RID: 125891 RVA: 0x0044C7FD File Offset: 0x0044A9FD
		// (set) Token: 0x0601EBC4 RID: 125892 RVA: 0x0044C805 File Offset: 0x0044AA05
		public ETurntableConnectorDisk Disk { get; set; }

		// Token: 0x0601EBC5 RID: 125893 RVA: 0x0044C80E File Offset: 0x0044AA0E
		public ICircuitConnectCurveAssetT()
		{
			this.Type = ECircuitConnectElementType.Straight;
			this.Disk = ETurntableConnectorDisk.Disk0;
		}
	}
}

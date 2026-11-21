using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D71 RID: 19825
	public class ICircuitConnectAssetsT
	{
		// Token: 0x17008DDA RID: 36314
		// (get) Token: 0x0601EBAB RID: 125867 RVA: 0x0044C5CB File Offset: 0x0044A7CB
		// (set) Token: 0x0601EBAC RID: 125868 RVA: 0x0044C5D3 File Offset: 0x0044A7D3
		public ETurntableConnectorGameplayType Type { get; set; }

		// Token: 0x17008DDB RID: 36315
		// (get) Token: 0x0601EBAD RID: 125869 RVA: 0x0044C5DC File Offset: 0x0044A7DC
		// (set) Token: 0x0601EBAE RID: 125870 RVA: 0x0044C5E4 File Offset: 0x0044A7E4
		public List<ICircuitConnectAssetConfigT> Assets { get; set; }

		// Token: 0x0601EBAF RID: 125871 RVA: 0x0044C5ED File Offset: 0x0044A7ED
		public ICircuitConnectAssetsT()
		{
			this.Type = ETurntableConnectorGameplayType.CircuitConnect;
			this.Assets = null;
		}
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D7D RID: 19837
	public class ICircuitConnectStraightAssetT
	{
		// Token: 0x17008DE9 RID: 36329
		// (get) Token: 0x0601EBF9 RID: 125945 RVA: 0x0044CC7A File Offset: 0x0044AE7A
		// (set) Token: 0x0601EBFA RID: 125946 RVA: 0x0044CC82 File Offset: 0x0044AE82
		public ECircuitConnectElementType Type { get; set; }

		// Token: 0x0601EBFB RID: 125947 RVA: 0x0044CC8B File Offset: 0x0044AE8B
		public ICircuitConnectStraightAssetT()
		{
			this.Type = ECircuitConnectElementType.Straight;
		}
	}
}

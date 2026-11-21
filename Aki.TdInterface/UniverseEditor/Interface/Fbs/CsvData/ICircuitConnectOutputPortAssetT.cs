using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D77 RID: 19831
	public class ICircuitConnectOutputPortAssetT
	{
		// Token: 0x17008DE3 RID: 36323
		// (get) Token: 0x0601EBD5 RID: 125909 RVA: 0x0044C98A File Offset: 0x0044AB8A
		// (set) Token: 0x0601EBD6 RID: 125910 RVA: 0x0044C992 File Offset: 0x0044AB92
		public ECircuitConnectElementType Type { get; set; }

		// Token: 0x0601EBD7 RID: 125911 RVA: 0x0044C99B File Offset: 0x0044AB9B
		public ICircuitConnectOutputPortAssetT()
		{
			this.Type = ECircuitConnectElementType.Straight;
		}
	}
}

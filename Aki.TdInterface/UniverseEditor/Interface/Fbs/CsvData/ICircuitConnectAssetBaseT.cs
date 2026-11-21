using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D68 RID: 19816
	public class ICircuitConnectAssetBaseT
	{
		// Token: 0x17008DCF RID: 36303
		// (get) Token: 0x0601EB61 RID: 125793 RVA: 0x0044BC36 File Offset: 0x00449E36
		// (set) Token: 0x0601EB62 RID: 125794 RVA: 0x0044BC3E File Offset: 0x00449E3E
		public ECircuitConnectElementType Type { get; set; }

		// Token: 0x0601EB63 RID: 125795 RVA: 0x0044BC47 File Offset: 0x00449E47
		public ICircuitConnectAssetBaseT()
		{
			this.Type = ECircuitConnectElementType.Straight;
		}
	}
}

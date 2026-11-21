using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DB3 RID: 19891
	public class ITurntableConnectorAssetsBaseT
	{
		// Token: 0x17008E56 RID: 36438
		// (get) Token: 0x0601EDD7 RID: 126423 RVA: 0x00450346 File Offset: 0x0044E546
		// (set) Token: 0x0601EDD8 RID: 126424 RVA: 0x0045034E File Offset: 0x0044E54E
		public ETurntableConnectorGameplayType Type { get; set; }

		// Token: 0x0601EDD9 RID: 126425 RVA: 0x00450357 File Offset: 0x0044E557
		public ITurntableConnectorAssetsBaseT()
		{
			this.Type = ETurntableConnectorGameplayType.CircuitConnect;
		}
	}
}

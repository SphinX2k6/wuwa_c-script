using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D7A RID: 19834
	public class ICircuitConnectPowerPortAssetT
	{
		// Token: 0x17008DE6 RID: 36326
		// (get) Token: 0x0601EBE7 RID: 125927 RVA: 0x0044CB02 File Offset: 0x0044AD02
		// (set) Token: 0x0601EBE8 RID: 125928 RVA: 0x0044CB0A File Offset: 0x0044AD0A
		public ECircuitConnectElementType Type { get; set; }

		// Token: 0x0601EBE9 RID: 125929 RVA: 0x0044CB13 File Offset: 0x0044AD13
		public ICircuitConnectPowerPortAssetT()
		{
			this.Type = ECircuitConnectElementType.Straight;
		}
	}
}

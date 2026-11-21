using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054D3 RID: 21715
	public class ICircuitConnectT
	{
		// Token: 0x17009B23 RID: 39715
		// (get) Token: 0x06022469 RID: 140393 RVA: 0x004B9A39 File Offset: 0x004B7C39
		// (set) Token: 0x0602246A RID: 140394 RVA: 0x004B9A41 File Offset: 0x004B7C41
		public ETurntableConnectorGameplayType Type { get; set; }

		// Token: 0x17009B24 RID: 39716
		// (get) Token: 0x0602246B RID: 140395 RVA: 0x004B9A4A File Offset: 0x004B7C4A
		// (set) Token: 0x0602246C RID: 140396 RVA: 0x004B9A52 File Offset: 0x004B7C52
		public int AssetConfigId { get; set; }

		// Token: 0x17009B25 RID: 39717
		// (get) Token: 0x0602246D RID: 140397 RVA: 0x004B9A5B File Offset: 0x004B7C5B
		// (set) Token: 0x0602246E RID: 140398 RVA: 0x004B9A63 File Offset: 0x004B7C63
		public ICircuitConnectLevelDataT LevelData { get; set; }

		// Token: 0x0602246F RID: 140399 RVA: 0x004B9A6C File Offset: 0x004B7C6C
		public ICircuitConnectT()
		{
			this.Type = ETurntableConnectorGameplayType.CircuitConnect;
			this.AssetConfigId = 0;
			this.LevelData = null;
		}
	}
}

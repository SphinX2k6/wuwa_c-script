using System;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DBC RID: 19900
	public class ITurntableConnectorDiskSocketsBaseT
	{
		// Token: 0x17008E60 RID: 36448
		// (get) Token: 0x0601EE0D RID: 126477 RVA: 0x004507EE File Offset: 0x0044E9EE
		// (set) Token: 0x0601EE0E RID: 126478 RVA: 0x004507F6 File Offset: 0x0044E9F6
		public ETurntableConnectorDiskLayout Type { get; set; }

		// Token: 0x0601EE0F RID: 126479 RVA: 0x004507FF File Offset: 0x0044E9FF
		public ITurntableConnectorDiskSocketsBaseT()
		{
			this.Type = ETurntableConnectorDiskLayout.Normal;
		}
	}
}

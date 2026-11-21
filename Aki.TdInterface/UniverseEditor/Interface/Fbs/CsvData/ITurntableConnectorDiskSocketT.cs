using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DB9 RID: 19897
	public class ITurntableConnectorDiskSocketT
	{
		// Token: 0x17008E5C RID: 36444
		// (get) Token: 0x0601EDF9 RID: 126457 RVA: 0x00450653 File Offset: 0x0044E853
		// (set) Token: 0x0601EDFA RID: 126458 RVA: 0x0045065B File Offset: 0x0044E85B
		public ETurntableConnectorDisk Disk { get; set; }

		// Token: 0x17008E5D RID: 36445
		// (get) Token: 0x0601EDFB RID: 126459 RVA: 0x00450664 File Offset: 0x0044E864
		// (set) Token: 0x0601EDFC RID: 126460 RVA: 0x0045066C File Offset: 0x0044E86C
		public string Socket { get; set; }

		// Token: 0x0601EDFD RID: 126461 RVA: 0x00450675 File Offset: 0x0044E875
		public ITurntableConnectorDiskSocketT()
		{
			this.Disk = ETurntableConnectorDisk.Disk0;
			this.Socket = null;
		}
	}
}

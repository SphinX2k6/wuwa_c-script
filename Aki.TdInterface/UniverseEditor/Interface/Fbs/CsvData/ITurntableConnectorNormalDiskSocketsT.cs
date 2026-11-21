using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DC2 RID: 19906
	public class ITurntableConnectorNormalDiskSocketsT
	{
		// Token: 0x17008E66 RID: 36454
		// (get) Token: 0x0601EE33 RID: 126515 RVA: 0x00450C4F File Offset: 0x0044EE4F
		// (set) Token: 0x0601EE34 RID: 126516 RVA: 0x00450C57 File Offset: 0x0044EE57
		public ETurntableConnectorDiskLayout Type { get; set; }

		// Token: 0x17008E67 RID: 36455
		// (get) Token: 0x0601EE35 RID: 126517 RVA: 0x00450C60 File Offset: 0x0044EE60
		// (set) Token: 0x0601EE36 RID: 126518 RVA: 0x00450C68 File Offset: 0x0044EE68
		public List<ITurntableConnectorDiskSocketT> Sockets { get; set; }

		// Token: 0x0601EE37 RID: 126519 RVA: 0x00450C71 File Offset: 0x0044EE71
		public ITurntableConnectorNormalDiskSocketsT()
		{
			this.Type = ETurntableConnectorDiskLayout.Normal;
			this.Sockets = null;
		}
	}
}

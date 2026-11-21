using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D89 RID: 19849
	public class IFrequencyDetectGraphicsLineT
	{
		// Token: 0x17008E05 RID: 36357
		// (get) Token: 0x0601EC71 RID: 126065 RVA: 0x0044DB82 File Offset: 0x0044BD82
		// (set) Token: 0x0601EC72 RID: 126066 RVA: 0x0044DB8A File Offset: 0x0044BD8A
		public string Id { get; set; }

		// Token: 0x17008E06 RID: 36358
		// (get) Token: 0x0601EC73 RID: 126067 RVA: 0x0044DB93 File Offset: 0x0044BD93
		// (set) Token: 0x0601EC74 RID: 126068 RVA: 0x0044DB9B File Offset: 0x0044BD9B
		public bool Closed { get; set; }

		// Token: 0x17008E07 RID: 36359
		// (get) Token: 0x0601EC75 RID: 126069 RVA: 0x0044DBA4 File Offset: 0x0044BDA4
		// (set) Token: 0x0601EC76 RID: 126070 RVA: 0x0044DBAC File Offset: 0x0044BDAC
		public List<IFrequencyDetectGraphicsSegmentT> Segments { get; set; }

		// Token: 0x0601EC77 RID: 126071 RVA: 0x0044DBB5 File Offset: 0x0044BDB5
		public IFrequencyDetectGraphicsLineT()
		{
			this.Id = null;
			this.Closed = false;
			this.Segments = null;
		}
	}
}

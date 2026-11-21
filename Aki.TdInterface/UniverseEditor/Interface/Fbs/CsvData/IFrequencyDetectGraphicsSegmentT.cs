using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D8C RID: 19852
	public class IFrequencyDetectGraphicsSegmentT
	{
		// Token: 0x17008E0A RID: 36362
		// (get) Token: 0x0601EC8D RID: 126093 RVA: 0x0044DEAD File Offset: 0x0044C0AD
		// (set) Token: 0x0601EC8E RID: 126094 RVA: 0x0044DEB5 File Offset: 0x0044C0B5
		public List<string> Points { get; set; }

		// Token: 0x0601EC8F RID: 126095 RVA: 0x0044DEBE File Offset: 0x0044C0BE
		public IFrequencyDetectGraphicsSegmentT()
		{
			this.Points = null;
		}
	}
}

using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D83 RID: 19843
	public class IFrequencyDetectGraphicsConfigT
	{
		// Token: 0x17008DFA RID: 36346
		// (get) Token: 0x0601EC3B RID: 126011 RVA: 0x0044D4F8 File Offset: 0x0044B6F8
		// (set) Token: 0x0601EC3C RID: 126012 RVA: 0x0044D500 File Offset: 0x0044B700
		public IFrequencyDetectGraphicsConfig_CanvasT Canvas { get; set; }

		// Token: 0x17008DFB RID: 36347
		// (get) Token: 0x0601EC3D RID: 126013 RVA: 0x0044D509 File Offset: 0x0044B709
		// (set) Token: 0x0601EC3E RID: 126014 RVA: 0x0044D511 File Offset: 0x0044B711
		public List<IFrequencyDetectGraphicsLineT> Lines { get; set; }

		// Token: 0x0601EC3F RID: 126015 RVA: 0x0044D51A File Offset: 0x0044B71A
		public IFrequencyDetectGraphicsConfigT()
		{
			this.Canvas = null;
			this.Lines = null;
		}
	}
}

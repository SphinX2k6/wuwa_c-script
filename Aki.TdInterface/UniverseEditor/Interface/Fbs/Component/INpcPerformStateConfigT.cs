using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BDD RID: 23517
	public class INpcPerformStateConfigT
	{
		// Token: 0x1700AC1C RID: 44060
		// (get) Token: 0x06026D60 RID: 159072 RVA: 0x0055179D File Offset: 0x0054F99D
		// (set) Token: 0x06026D61 RID: 159073 RVA: 0x005517A5 File Offset: 0x0054F9A5
		public string State { get; set; }

		// Token: 0x1700AC1D RID: 44061
		// (get) Token: 0x06026D62 RID: 159074 RVA: 0x005517AE File Offset: 0x0054F9AE
		// (set) Token: 0x06026D63 RID: 159075 RVA: 0x005517B6 File Offset: 0x0054F9B6
		public string MaterialDa { get; set; }

		// Token: 0x1700AC1E RID: 44062
		// (get) Token: 0x06026D64 RID: 159076 RVA: 0x005517BF File Offset: 0x0054F9BF
		// (set) Token: 0x06026D65 RID: 159077 RVA: 0x005517C7 File Offset: 0x0054F9C7
		public List<int> BuffEffectIds { get; set; }

		// Token: 0x1700AC1F RID: 44063
		// (get) Token: 0x06026D66 RID: 159078 RVA: 0x005517D0 File Offset: 0x0054F9D0
		// (set) Token: 0x06026D67 RID: 159079 RVA: 0x005517D8 File Offset: 0x0054F9D8
		public byte NullMask { get; set; }

		// Token: 0x06026D68 RID: 159080 RVA: 0x005517E1 File Offset: 0x0054F9E1
		public INpcPerformStateConfigT()
		{
			this.State = null;
			this.MaterialDa = null;
			this.BuffEffectIds = null;
			this.NullMask = 0;
		}
	}
}

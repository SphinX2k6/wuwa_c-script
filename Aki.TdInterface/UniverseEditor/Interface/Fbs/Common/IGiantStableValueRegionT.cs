using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006414 RID: 25620
	public class IGiantStableValueRegionT
	{
		// Token: 0x1700BD3E RID: 48446
		// (get) Token: 0x0602B878 RID: 178296 RVA: 0x005ED9B1 File Offset: 0x005EBBB1
		// (set) Token: 0x0602B879 RID: 178297 RVA: 0x005ED9B9 File Offset: 0x005EBBB9
		public EGiantStableValueType Type { get; set; }

		// Token: 0x1700BD3F RID: 48447
		// (get) Token: 0x0602B87A RID: 178298 RVA: 0x005ED9C2 File Offset: 0x005EBBC2
		// (set) Token: 0x0602B87B RID: 178299 RVA: 0x005ED9CA File Offset: 0x005EBBCA
		public EGiantEcoType EcoType { get; set; }

		// Token: 0x1700BD40 RID: 48448
		// (get) Token: 0x0602B87C RID: 178300 RVA: 0x005ED9D3 File Offset: 0x005EBBD3
		// (set) Token: 0x0602B87D RID: 178301 RVA: 0x005ED9DB File Offset: 0x005EBBDB
		public IGiantStableValueRangeT Range { get; set; }

		// Token: 0x0602B87E RID: 178302 RVA: 0x005ED9E4 File Offset: 0x005EBBE4
		public IGiantStableValueRegionT()
		{
			this.Type = EGiantStableValueType.Region;
			this.EcoType = EGiantEcoType.Fire;
			this.Range = null;
		}
	}
}

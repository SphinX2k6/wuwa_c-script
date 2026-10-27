using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007065 RID: 28773
	public class ISetRegionMpcT
	{
		// Token: 0x1700D5DD RID: 54749
		// (get) Token: 0x06032F24 RID: 208676 RVA: 0x006DF864 File Offset: 0x006DDA64
		// (set) Token: 0x06032F25 RID: 208677 RVA: 0x006DF86C File Offset: 0x006DDA6C
		public ERegionConfigType Type { get; set; }

		// Token: 0x1700D5DE RID: 54750
		// (get) Token: 0x06032F26 RID: 208678 RVA: 0x006DF875 File Offset: 0x006DDA75
		// (set) Token: 0x06032F27 RID: 208679 RVA: 0x006DF87D File Offset: 0x006DDA7D
		public int RegionMpcId { get; set; }

		// Token: 0x06032F28 RID: 208680 RVA: 0x006DF886 File Offset: 0x006DDA86
		public ISetRegionMpcT()
		{
			this.Type = ERegionConfigType.Mpc;
			this.RegionMpcId = 0;
		}
	}
}

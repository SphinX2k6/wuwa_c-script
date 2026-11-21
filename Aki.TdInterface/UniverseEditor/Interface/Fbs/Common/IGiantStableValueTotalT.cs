using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006417 RID: 25623
	public class IGiantStableValueTotalT
	{
		// Token: 0x1700BD44 RID: 48452
		// (get) Token: 0x0602B890 RID: 178320 RVA: 0x005EDC67 File Offset: 0x005EBE67
		// (set) Token: 0x0602B891 RID: 178321 RVA: 0x005EDC6F File Offset: 0x005EBE6F
		public EGiantStableValueType Type { get; set; }

		// Token: 0x1700BD45 RID: 48453
		// (get) Token: 0x0602B892 RID: 178322 RVA: 0x005EDC78 File Offset: 0x005EBE78
		// (set) Token: 0x0602B893 RID: 178323 RVA: 0x005EDC80 File Offset: 0x005EBE80
		public IGiantStableValueRangeT Range { get; set; }

		// Token: 0x0602B894 RID: 178324 RVA: 0x005EDC89 File Offset: 0x005EBE89
		public IGiantStableValueTotalT()
		{
			this.Type = EGiantStableValueType.Region;
			this.Range = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A99 RID: 27289
	public class ICloseGlobalTimeScaleT
	{
		// Token: 0x1700C86D RID: 51309
		// (get) Token: 0x0602ED53 RID: 191827 RVA: 0x00661CEE File Offset: 0x0065FEEE
		// (set) Token: 0x0602ED54 RID: 191828 RVA: 0x00661CF6 File Offset: 0x0065FEF6
		public ESetTimeScaleType Type { get; set; }

		// Token: 0x1700C86E RID: 51310
		// (get) Token: 0x0602ED55 RID: 191829 RVA: 0x00661CFF File Offset: 0x0065FEFF
		// (set) Token: 0x0602ED56 RID: 191830 RVA: 0x00661D07 File Offset: 0x0065FF07
		public ETimeScaleCloseSource TimeScaleCloseSource { get; set; }

		// Token: 0x1700C86F RID: 51311
		// (get) Token: 0x0602ED57 RID: 191831 RVA: 0x00661D10 File Offset: 0x0065FF10
		// (set) Token: 0x0602ED58 RID: 191832 RVA: 0x00661D18 File Offset: 0x0065FF18
		public byte NullMask { get; set; }

		// Token: 0x0602ED59 RID: 191833 RVA: 0x00661D21 File Offset: 0x0065FF21
		public ICloseGlobalTimeScaleT()
		{
			this.Type = ESetTimeScaleType.Open;
			this.TimeScaleCloseSource = ETimeScaleCloseSource.All;
			this.NullMask = 0;
		}
	}
}

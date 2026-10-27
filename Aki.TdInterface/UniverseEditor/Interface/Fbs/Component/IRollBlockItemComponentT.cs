using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005889 RID: 22665
	public class IRollBlockItemComponentT
	{
		// Token: 0x1700A97F RID: 43391
		// (get) Token: 0x0602630C RID: 156428 RVA: 0x00543AD4 File Offset: 0x00541CD4
		// (set) Token: 0x0602630D RID: 156429 RVA: 0x00543ADC File Offset: 0x00541CDC
		public bool Disabled { get; set; }

		// Token: 0x1700A980 RID: 43392
		// (get) Token: 0x0602630E RID: 156430 RVA: 0x00543AE5 File Offset: 0x00541CE5
		// (set) Token: 0x0602630F RID: 156431 RVA: 0x00543AED File Offset: 0x00541CED
		public byte NullMask { get; set; }

		// Token: 0x06026310 RID: 156432 RVA: 0x00543AF6 File Offset: 0x00541CF6
		public IRollBlockItemComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}

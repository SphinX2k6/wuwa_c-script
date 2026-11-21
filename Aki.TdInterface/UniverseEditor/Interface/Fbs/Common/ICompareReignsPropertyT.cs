using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063B1 RID: 25521
	public class ICompareReignsPropertyT
	{
		// Token: 0x1700BC96 RID: 48278
		// (get) Token: 0x0602B562 RID: 177506 RVA: 0x005E8026 File Offset: 0x005E6226
		// (set) Token: 0x0602B563 RID: 177507 RVA: 0x005E802E File Offset: 0x005E622E
		public int PropertyId { get; set; }

		// Token: 0x1700BC97 RID: 48279
		// (get) Token: 0x0602B564 RID: 177508 RVA: 0x005E8037 File Offset: 0x005E6237
		// (set) Token: 0x0602B565 RID: 177509 RVA: 0x005E803F File Offset: 0x005E623F
		public EReignsPropertyCompare Compare { get; set; }

		// Token: 0x1700BC98 RID: 48280
		// (get) Token: 0x0602B566 RID: 177510 RVA: 0x005E8048 File Offset: 0x005E6248
		// (set) Token: 0x0602B567 RID: 177511 RVA: 0x005E8050 File Offset: 0x005E6250
		public int Target { get; set; }

		// Token: 0x0602B568 RID: 177512 RVA: 0x005E8059 File Offset: 0x005E6259
		public ICompareReignsPropertyT()
		{
			this.PropertyId = 0;
			this.Compare = EReignsPropertyCompare.Eq;
			this.Target = 0;
		}
	}
}

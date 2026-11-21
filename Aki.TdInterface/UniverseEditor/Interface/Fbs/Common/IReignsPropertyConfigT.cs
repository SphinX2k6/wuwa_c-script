using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006498 RID: 25752
	public class IReignsPropertyConfigT
	{
		// Token: 0x1700BE06 RID: 48646
		// (get) Token: 0x0602BC6D RID: 179309 RVA: 0x005F49D4 File Offset: 0x005F2BD4
		// (set) Token: 0x0602BC6E RID: 179310 RVA: 0x005F49DC File Offset: 0x005F2BDC
		public int Id { get; set; }

		// Token: 0x1700BE07 RID: 48647
		// (get) Token: 0x0602BC6F RID: 179311 RVA: 0x005F49E5 File Offset: 0x005F2BE5
		// (set) Token: 0x0602BC70 RID: 179312 RVA: 0x005F49ED File Offset: 0x005F2BED
		public int BaseValue { get; set; }

		// Token: 0x1700BE08 RID: 48648
		// (get) Token: 0x0602BC71 RID: 179313 RVA: 0x005F49F6 File Offset: 0x005F2BF6
		// (set) Token: 0x0602BC72 RID: 179314 RVA: 0x005F49FE File Offset: 0x005F2BFE
		public int MaxValue { get; set; }

		// Token: 0x1700BE09 RID: 48649
		// (get) Token: 0x0602BC73 RID: 179315 RVA: 0x005F4A07 File Offset: 0x005F2C07
		// (set) Token: 0x0602BC74 RID: 179316 RVA: 0x005F4A0F File Offset: 0x005F2C0F
		public bool IsDefaultEnable { get; set; }

		// Token: 0x0602BC75 RID: 179317 RVA: 0x005F4A18 File Offset: 0x005F2C18
		public IReignsPropertyConfigT()
		{
			this.Id = 0;
			this.BaseValue = 0;
			this.MaxValue = 0;
			this.IsDefaultEnable = false;
		}
	}
}

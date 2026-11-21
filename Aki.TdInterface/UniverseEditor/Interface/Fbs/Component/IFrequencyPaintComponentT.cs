using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005845 RID: 22597
	public class IFrequencyPaintComponentT
	{
		// Token: 0x1700A3AD RID: 41901
		// (get) Token: 0x060249AF RID: 149935 RVA: 0x00507A62 File Offset: 0x00505C62
		// (set) Token: 0x060249B0 RID: 149936 RVA: 0x00507A6A File Offset: 0x00505C6A
		public bool Disabled { get; set; }

		// Token: 0x1700A3AE RID: 41902
		// (get) Token: 0x060249B1 RID: 149937 RVA: 0x00507A73 File Offset: 0x00505C73
		// (set) Token: 0x060249B2 RID: 149938 RVA: 0x00507A7B File Offset: 0x00505C7B
		public bool EnableGuide { get; set; }

		// Token: 0x1700A3AF RID: 41903
		// (get) Token: 0x060249B3 RID: 149939 RVA: 0x00507A84 File Offset: 0x00505C84
		// (set) Token: 0x060249B4 RID: 149940 RVA: 0x00507A8C File Offset: 0x00505C8C
		public List<TFrequencyPaintRangeUnion> Ranges { get; set; }

		// Token: 0x1700A3B0 RID: 41904
		// (get) Token: 0x060249B5 RID: 149941 RVA: 0x00507A95 File Offset: 0x00505C95
		// (set) Token: 0x060249B6 RID: 149942 RVA: 0x00507A9D File Offset: 0x00505C9D
		public List<IFrequencyPaintConfigT> PaintConfigs { get; set; }

		// Token: 0x1700A3B1 RID: 41905
		// (get) Token: 0x060249B7 RID: 149943 RVA: 0x00507AA6 File Offset: 0x00505CA6
		// (set) Token: 0x060249B8 RID: 149944 RVA: 0x00507AAE File Offset: 0x00505CAE
		public byte NullMask { get; set; }

		// Token: 0x060249B9 RID: 149945 RVA: 0x00507AB7 File Offset: 0x00505CB7
		public IFrequencyPaintComponentT()
		{
			this.Disabled = false;
			this.EnableGuide = false;
			this.Ranges = null;
			this.PaintConfigs = null;
			this.NullMask = 0;
		}
	}
}

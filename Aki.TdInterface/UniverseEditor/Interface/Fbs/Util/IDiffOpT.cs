using System;

namespace Aki.UniverseEditor.Interface.Fbs.Util
{
	// Token: 0x02003F75 RID: 16245
	public class IDiffOpT
	{
		// Token: 0x17006DD5 RID: 28117
		// (get) Token: 0x060161CD RID: 90573 RVA: 0x0032C309 File Offset: 0x0032A509
		// (set) Token: 0x060161CE RID: 90574 RVA: 0x0032C311 File Offset: 0x0032A511
		public EDiffOp Type { get; set; }

		// Token: 0x17006DD6 RID: 28118
		// (get) Token: 0x060161CF RID: 90575 RVA: 0x0032C31A File Offset: 0x0032A51A
		// (set) Token: 0x060161D0 RID: 90576 RVA: 0x0032C322 File Offset: 0x0032A522
		public int Length { get; set; }

		// Token: 0x17006DD7 RID: 28119
		// (get) Token: 0x060161D1 RID: 90577 RVA: 0x0032C32B File Offset: 0x0032A52B
		// (set) Token: 0x060161D2 RID: 90578 RVA: 0x0032C333 File Offset: 0x0032A533
		public IDiffOpT PreOp { get; set; }

		// Token: 0x060161D3 RID: 90579 RVA: 0x0032C33C File Offset: 0x0032A53C
		public IDiffOpT()
		{
			this.Type = EDiffOp.Same;
			this.Length = 0;
			this.PreOp = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005883 RID: 22659
	public class IRollBlockComponentT
	{
		// Token: 0x1700A975 RID: 43381
		// (get) Token: 0x060262E0 RID: 156384 RVA: 0x005436CC File Offset: 0x005418CC
		// (set) Token: 0x060262E1 RID: 156385 RVA: 0x005436D4 File Offset: 0x005418D4
		public bool Disabled { get; set; }

		// Token: 0x1700A976 RID: 43382
		// (get) Token: 0x060262E2 RID: 156386 RVA: 0x005436DD File Offset: 0x005418DD
		// (set) Token: 0x060262E3 RID: 156387 RVA: 0x005436E5 File Offset: 0x005418E5
		public byte NullMask { get; set; }

		// Token: 0x060262E4 RID: 156388 RVA: 0x005436EE File Offset: 0x005418EE
		public IRollBlockComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}

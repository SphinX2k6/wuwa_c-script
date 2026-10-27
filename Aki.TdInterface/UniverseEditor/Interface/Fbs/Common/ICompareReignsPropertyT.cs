using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D74 RID: 23924
	public class ICompareReignsPropertyT
	{
		// Token: 0x1700B330 RID: 45872
		// (get) Token: 0x06028ED8 RID: 167640 RVA: 0x0059F2F6 File Offset: 0x0059D4F6
		// (set) Token: 0x06028ED9 RID: 167641 RVA: 0x0059F2FE File Offset: 0x0059D4FE
		public int PropertyId { get; set; }

		// Token: 0x1700B331 RID: 45873
		// (get) Token: 0x06028EDA RID: 167642 RVA: 0x0059F307 File Offset: 0x0059D507
		// (set) Token: 0x06028EDB RID: 167643 RVA: 0x0059F30F File Offset: 0x0059D50F
		public EReignsPropertyCompare Compare { get; set; }

		// Token: 0x1700B332 RID: 45874
		// (get) Token: 0x06028EDC RID: 167644 RVA: 0x0059F318 File Offset: 0x0059D518
		// (set) Token: 0x06028EDD RID: 167645 RVA: 0x0059F320 File Offset: 0x0059D520
		public int Target { get; set; }

		// Token: 0x06028EDE RID: 167646 RVA: 0x0059F329 File Offset: 0x0059D529
		public ICompareReignsPropertyT()
		{
			this.PropertyId = 0;
			this.Compare = EReignsPropertyCompare.Eq;
			this.Target = 0;
		}
	}
}

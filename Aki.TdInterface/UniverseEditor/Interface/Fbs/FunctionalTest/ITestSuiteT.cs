using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.FunctionalTest
{
	// Token: 0x02004B8A RID: 19338
	public class ITestSuiteT
	{
		// Token: 0x170088C4 RID: 35012
		// (get) Token: 0x0601D770 RID: 120688 RVA: 0x0042321B File Offset: 0x0042141B
		// (set) Token: 0x0601D771 RID: 120689 RVA: 0x00423223 File Offset: 0x00421423
		public string Id { get; set; }

		// Token: 0x170088C5 RID: 35013
		// (get) Token: 0x0601D772 RID: 120690 RVA: 0x0042322C File Offset: 0x0042142C
		// (set) Token: 0x0601D773 RID: 120691 RVA: 0x00423234 File Offset: 0x00421434
		public string Name { get; set; }

		// Token: 0x170088C6 RID: 35014
		// (get) Token: 0x0601D774 RID: 120692 RVA: 0x0042323D File Offset: 0x0042143D
		// (set) Token: 0x0601D775 RID: 120693 RVA: 0x00423245 File Offset: 0x00421445
		public List<ITestCaseT> Cases { get; set; }

		// Token: 0x0601D776 RID: 120694 RVA: 0x0042324E File Offset: 0x0042144E
		public ITestSuiteT()
		{
			this.Id = null;
			this.Name = null;
			this.Cases = null;
		}
	}
}

using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.FunctionalTest
{
	// Token: 0x02004725 RID: 18213
	public class ITestSuiteCollectionT
	{
		// Token: 0x1700828A RID: 33418
		// (get) Token: 0x0601BFBD RID: 114621 RVA: 0x003F73EE File Offset: 0x003F55EE
		// (set) Token: 0x0601BFBE RID: 114622 RVA: 0x003F73F6 File Offset: 0x003F55F6
		public string Id { get; set; }

		// Token: 0x1700828B RID: 33419
		// (get) Token: 0x0601BFBF RID: 114623 RVA: 0x003F73FF File Offset: 0x003F55FF
		// (set) Token: 0x0601BFC0 RID: 114624 RVA: 0x003F7407 File Offset: 0x003F5607
		public int LevelId { get; set; }

		// Token: 0x1700828C RID: 33420
		// (get) Token: 0x0601BFC1 RID: 114625 RVA: 0x003F7410 File Offset: 0x003F5610
		// (set) Token: 0x0601BFC2 RID: 114626 RVA: 0x003F7418 File Offset: 0x003F5618
		public List<ITestSuiteT> Suites { get; set; }

		// Token: 0x0601BFC3 RID: 114627 RVA: 0x003F7421 File Offset: 0x003F5621
		public ITestSuiteCollectionT()
		{
			this.Id = null;
			this.LevelId = 0;
			this.Suites = null;
		}
	}
}

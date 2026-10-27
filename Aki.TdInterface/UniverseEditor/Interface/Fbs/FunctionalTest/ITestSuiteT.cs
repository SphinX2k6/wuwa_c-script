using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.FunctionalTest
{
	// Token: 0x02004722 RID: 18210
	public class ITestSuiteT
	{
		// Token: 0x17008283 RID: 33411
		// (get) Token: 0x0601BF9B RID: 114587 RVA: 0x003F6F7F File Offset: 0x003F517F
		// (set) Token: 0x0601BF9C RID: 114588 RVA: 0x003F6F87 File Offset: 0x003F5187
		public string Id { get; set; }

		// Token: 0x17008284 RID: 33412
		// (get) Token: 0x0601BF9D RID: 114589 RVA: 0x003F6F90 File Offset: 0x003F5190
		// (set) Token: 0x0601BF9E RID: 114590 RVA: 0x003F6F98 File Offset: 0x003F5198
		public string Name { get; set; }

		// Token: 0x17008285 RID: 33413
		// (get) Token: 0x0601BF9F RID: 114591 RVA: 0x003F6FA1 File Offset: 0x003F51A1
		// (set) Token: 0x0601BFA0 RID: 114592 RVA: 0x003F6FA9 File Offset: 0x003F51A9
		public List<ITestCaseT> Cases { get; set; }

		// Token: 0x0601BFA1 RID: 114593 RVA: 0x003F6FB2 File Offset: 0x003F51B2
		public ITestSuiteT()
		{
			this.Id = null;
			this.Name = null;
			this.Cases = null;
		}
	}
}

using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.FunctionalTest
{
	// Token: 0x02004B8D RID: 19341
	public class ITestSuiteCollectionT
	{
		// Token: 0x170088CB RID: 35019
		// (get) Token: 0x0601D792 RID: 120722 RVA: 0x0042368A File Offset: 0x0042188A
		// (set) Token: 0x0601D793 RID: 120723 RVA: 0x00423692 File Offset: 0x00421892
		public string Id { get; set; }

		// Token: 0x170088CC RID: 35020
		// (get) Token: 0x0601D794 RID: 120724 RVA: 0x0042369B File Offset: 0x0042189B
		// (set) Token: 0x0601D795 RID: 120725 RVA: 0x004236A3 File Offset: 0x004218A3
		public int LevelId { get; set; }

		// Token: 0x170088CD RID: 35021
		// (get) Token: 0x0601D796 RID: 120726 RVA: 0x004236AC File Offset: 0x004218AC
		// (set) Token: 0x0601D797 RID: 120727 RVA: 0x004236B4 File Offset: 0x004218B4
		public List<ITestSuiteT> Suites { get; set; }

		// Token: 0x0601D798 RID: 120728 RVA: 0x004236BD File Offset: 0x004218BD
		public ITestSuiteCollectionT()
		{
			this.Id = null;
			this.LevelId = 0;
			this.Suites = null;
		}
	}
}

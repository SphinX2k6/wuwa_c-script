using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Test
{
	// Token: 0x02003B73 RID: 15219
	public class ITestReportT
	{
		// Token: 0x17006843 RID: 26691
		// (get) Token: 0x06014D37 RID: 85303 RVA: 0x00306502 File Offset: 0x00304702
		// (set) Token: 0x06014D38 RID: 85304 RVA: 0x0030650A File Offset: 0x0030470A
		public string Name { get; set; }

		// Token: 0x17006844 RID: 26692
		// (get) Token: 0x06014D39 RID: 85305 RVA: 0x00306513 File Offset: 0x00304713
		// (set) Token: 0x06014D3A RID: 85306 RVA: 0x0030651B File Offset: 0x0030471B
		public int RunTime { get; set; }

		// Token: 0x17006845 RID: 26693
		// (get) Token: 0x06014D3B RID: 85307 RVA: 0x00306524 File Offset: 0x00304724
		// (set) Token: 0x06014D3C RID: 85308 RVA: 0x0030652C File Offset: 0x0030472C
		public string File { get; set; }

		// Token: 0x17006846 RID: 26694
		// (get) Token: 0x06014D3D RID: 85309 RVA: 0x00306535 File Offset: 0x00304735
		// (set) Token: 0x06014D3E RID: 85310 RVA: 0x0030653D File Offset: 0x0030473D
		public string Follower { get; set; }

		// Token: 0x17006847 RID: 26695
		// (get) Token: 0x06014D3F RID: 85311 RVA: 0x00306546 File Offset: 0x00304746
		// (set) Token: 0x06014D40 RID: 85312 RVA: 0x0030654E File Offset: 0x0030474E
		public bool PackageNeedPass { get; set; }

		// Token: 0x17006848 RID: 26696
		// (get) Token: 0x06014D41 RID: 85313 RVA: 0x00306557 File Offset: 0x00304757
		// (set) Token: 0x06014D42 RID: 85314 RVA: 0x0030655F File Offset: 0x0030475F
		public bool Resolving { get; set; }

		// Token: 0x17006849 RID: 26697
		// (get) Token: 0x06014D43 RID: 85315 RVA: 0x00306568 File Offset: 0x00304768
		// (set) Token: 0x06014D44 RID: 85316 RVA: 0x00306570 File Offset: 0x00304770
		public string ErrorMsg { get; set; }

		// Token: 0x1700684A RID: 26698
		// (get) Token: 0x06014D45 RID: 85317 RVA: 0x00306579 File Offset: 0x00304779
		// (set) Token: 0x06014D46 RID: 85318 RVA: 0x00306581 File Offset: 0x00304781
		public List<ITestReportT> SubReports { get; set; }

		// Token: 0x1700684B RID: 26699
		// (get) Token: 0x06014D47 RID: 85319 RVA: 0x0030658A File Offset: 0x0030478A
		// (set) Token: 0x06014D48 RID: 85320 RVA: 0x00306592 File Offset: 0x00304792
		public byte NullMask { get; set; }

		// Token: 0x06014D49 RID: 85321 RVA: 0x0030659C File Offset: 0x0030479C
		public ITestReportT()
		{
			this.Name = null;
			this.RunTime = 0;
			this.File = null;
			this.Follower = null;
			this.PackageNeedPass = false;
			this.Resolving = false;
			this.ErrorMsg = null;
			this.SubReports = null;
			this.NullMask = 0;
		}
	}
}

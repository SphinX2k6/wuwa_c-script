using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Test
{
	// Token: 0x02003F7B RID: 16251
	public class ITestReportT
	{
		// Token: 0x17006DE2 RID: 28130
		// (get) Token: 0x06016201 RID: 90625 RVA: 0x0032CA9A File Offset: 0x0032AC9A
		// (set) Token: 0x06016202 RID: 90626 RVA: 0x0032CAA2 File Offset: 0x0032ACA2
		public string Name { get; set; }

		// Token: 0x17006DE3 RID: 28131
		// (get) Token: 0x06016203 RID: 90627 RVA: 0x0032CAAB File Offset: 0x0032ACAB
		// (set) Token: 0x06016204 RID: 90628 RVA: 0x0032CAB3 File Offset: 0x0032ACB3
		public int RunTime { get; set; }

		// Token: 0x17006DE4 RID: 28132
		// (get) Token: 0x06016205 RID: 90629 RVA: 0x0032CABC File Offset: 0x0032ACBC
		// (set) Token: 0x06016206 RID: 90630 RVA: 0x0032CAC4 File Offset: 0x0032ACC4
		public string File { get; set; }

		// Token: 0x17006DE5 RID: 28133
		// (get) Token: 0x06016207 RID: 90631 RVA: 0x0032CACD File Offset: 0x0032ACCD
		// (set) Token: 0x06016208 RID: 90632 RVA: 0x0032CAD5 File Offset: 0x0032ACD5
		public string Follower { get; set; }

		// Token: 0x17006DE6 RID: 28134
		// (get) Token: 0x06016209 RID: 90633 RVA: 0x0032CADE File Offset: 0x0032ACDE
		// (set) Token: 0x0601620A RID: 90634 RVA: 0x0032CAE6 File Offset: 0x0032ACE6
		public bool PackageNeedPass { get; set; }

		// Token: 0x17006DE7 RID: 28135
		// (get) Token: 0x0601620B RID: 90635 RVA: 0x0032CAEF File Offset: 0x0032ACEF
		// (set) Token: 0x0601620C RID: 90636 RVA: 0x0032CAF7 File Offset: 0x0032ACF7
		public bool Resolving { get; set; }

		// Token: 0x17006DE8 RID: 28136
		// (get) Token: 0x0601620D RID: 90637 RVA: 0x0032CB00 File Offset: 0x0032AD00
		// (set) Token: 0x0601620E RID: 90638 RVA: 0x0032CB08 File Offset: 0x0032AD08
		public string ErrorMsg { get; set; }

		// Token: 0x17006DE9 RID: 28137
		// (get) Token: 0x0601620F RID: 90639 RVA: 0x0032CB11 File Offset: 0x0032AD11
		// (set) Token: 0x06016210 RID: 90640 RVA: 0x0032CB19 File Offset: 0x0032AD19
		public List<ITestReportT> SubReports { get; set; }

		// Token: 0x17006DEA RID: 28138
		// (get) Token: 0x06016211 RID: 90641 RVA: 0x0032CB22 File Offset: 0x0032AD22
		// (set) Token: 0x06016212 RID: 90642 RVA: 0x0032CB2A File Offset: 0x0032AD2A
		public byte NullMask { get; set; }

		// Token: 0x06016213 RID: 90643 RVA: 0x0032CB34 File Offset: 0x0032AD34
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

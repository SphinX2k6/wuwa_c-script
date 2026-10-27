using System;

namespace Aki.UniverseEditor.Interface.Fbs.Test
{
	// Token: 0x02003B76 RID: 15222
	public class ITestSummaryT
	{
		// Token: 0x17006854 RID: 26708
		// (get) Token: 0x06014D67 RID: 85351 RVA: 0x00306A81 File Offset: 0x00304C81
		// (set) Token: 0x06014D68 RID: 85352 RVA: 0x00306A89 File Offset: 0x00304C89
		public int Total { get; set; }

		// Token: 0x17006855 RID: 26709
		// (get) Token: 0x06014D69 RID: 85353 RVA: 0x00306A92 File Offset: 0x00304C92
		// (set) Token: 0x06014D6A RID: 85354 RVA: 0x00306A9A File Offset: 0x00304C9A
		public int Passed { get; set; }

		// Token: 0x17006856 RID: 26710
		// (get) Token: 0x06014D6B RID: 85355 RVA: 0x00306AA3 File Offset: 0x00304CA3
		// (set) Token: 0x06014D6C RID: 85356 RVA: 0x00306AAB File Offset: 0x00304CAB
		public int Failed { get; set; }

		// Token: 0x17006857 RID: 26711
		// (get) Token: 0x06014D6D RID: 85357 RVA: 0x00306AB4 File Offset: 0x00304CB4
		// (set) Token: 0x06014D6E RID: 85358 RVA: 0x00306ABC File Offset: 0x00304CBC
		public bool IsRequiredCaseAllPassed { get; set; }

		// Token: 0x17006858 RID: 26712
		// (get) Token: 0x06014D6F RID: 85359 RVA: 0x00306AC5 File Offset: 0x00304CC5
		// (set) Token: 0x06014D70 RID: 85360 RVA: 0x00306ACD File Offset: 0x00304CCD
		public int Time { get; set; }

		// Token: 0x17006859 RID: 26713
		// (get) Token: 0x06014D71 RID: 85361 RVA: 0x00306AD6 File Offset: 0x00304CD6
		// (set) Token: 0x06014D72 RID: 85362 RVA: 0x00306ADE File Offset: 0x00304CDE
		public string ErrorMsg { get; set; }

		// Token: 0x1700685A RID: 26714
		// (get) Token: 0x06014D73 RID: 85363 RVA: 0x00306AE7 File Offset: 0x00304CE7
		// (set) Token: 0x06014D74 RID: 85364 RVA: 0x00306AEF File Offset: 0x00304CEF
		public byte NullMask { get; set; }

		// Token: 0x06014D75 RID: 85365 RVA: 0x00306AF8 File Offset: 0x00304CF8
		public ITestSummaryT()
		{
			this.Total = 0;
			this.Passed = 0;
			this.Failed = 0;
			this.IsRequiredCaseAllPassed = false;
			this.Time = 0;
			this.ErrorMsg = null;
			this.NullMask = 0;
		}
	}
}

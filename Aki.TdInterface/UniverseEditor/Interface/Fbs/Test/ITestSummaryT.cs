using System;

namespace Aki.UniverseEditor.Interface.Fbs.Test
{
	// Token: 0x02003F7E RID: 16254
	public class ITestSummaryT
	{
		// Token: 0x17006DF3 RID: 28147
		// (get) Token: 0x06016231 RID: 90673 RVA: 0x0032D019 File Offset: 0x0032B219
		// (set) Token: 0x06016232 RID: 90674 RVA: 0x0032D021 File Offset: 0x0032B221
		public int Total { get; set; }

		// Token: 0x17006DF4 RID: 28148
		// (get) Token: 0x06016233 RID: 90675 RVA: 0x0032D02A File Offset: 0x0032B22A
		// (set) Token: 0x06016234 RID: 90676 RVA: 0x0032D032 File Offset: 0x0032B232
		public int Passed { get; set; }

		// Token: 0x17006DF5 RID: 28149
		// (get) Token: 0x06016235 RID: 90677 RVA: 0x0032D03B File Offset: 0x0032B23B
		// (set) Token: 0x06016236 RID: 90678 RVA: 0x0032D043 File Offset: 0x0032B243
		public int Failed { get; set; }

		// Token: 0x17006DF6 RID: 28150
		// (get) Token: 0x06016237 RID: 90679 RVA: 0x0032D04C File Offset: 0x0032B24C
		// (set) Token: 0x06016238 RID: 90680 RVA: 0x0032D054 File Offset: 0x0032B254
		public bool IsRequiredCaseAllPassed { get; set; }

		// Token: 0x17006DF7 RID: 28151
		// (get) Token: 0x06016239 RID: 90681 RVA: 0x0032D05D File Offset: 0x0032B25D
		// (set) Token: 0x0601623A RID: 90682 RVA: 0x0032D065 File Offset: 0x0032B265
		public int Time { get; set; }

		// Token: 0x17006DF8 RID: 28152
		// (get) Token: 0x0601623B RID: 90683 RVA: 0x0032D06E File Offset: 0x0032B26E
		// (set) Token: 0x0601623C RID: 90684 RVA: 0x0032D076 File Offset: 0x0032B276
		public string ErrorMsg { get; set; }

		// Token: 0x17006DF9 RID: 28153
		// (get) Token: 0x0601623D RID: 90685 RVA: 0x0032D07F File Offset: 0x0032B27F
		// (set) Token: 0x0601623E RID: 90686 RVA: 0x0032D087 File Offset: 0x0032B287
		public byte NullMask { get; set; }

		// Token: 0x0601623F RID: 90687 RVA: 0x0032D090 File Offset: 0x0032B290
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

using System;

namespace CSharpScript.Game.Module.PerformanceExceed
{
	// Token: 0x0200432F RID: 17199
	public class PerfExceedSessionLimiter
	{
		// Token: 0x0602B6E3 RID: 177891 RVA: 0x00C356B4 File Offset: 0x00C338B4
		public PerfExceedSessionLimiter(int limit = 50)
		{
			this.Limit = limit;
		}

		// Token: 0x170056F3 RID: 22259
		// (get) Token: 0x0602B6E4 RID: 177892 RVA: 0x00C356C3 File Offset: 0x00C338C3
		public bool CanReport
		{
			get
			{
				return this.ReportCount < this.Limit;
			}
		}

		// Token: 0x0602B6E5 RID: 177893 RVA: 0x00C356D3 File Offset: 0x00C338D3
		public void OnReported()
		{
			this.ReportCount++;
		}

		// Token: 0x170056F4 RID: 22260
		// (get) Token: 0x0602B6E6 RID: 177894 RVA: 0x00C356E3 File Offset: 0x00C338E3
		public int Remaining
		{
			get
			{
				return this.Limit - this.ReportCount;
			}
		}

		// Token: 0x040177BE RID: 96190
		private int ReportCount;

		// Token: 0x040177BF RID: 96191
		public readonly int Limit;
	}
}

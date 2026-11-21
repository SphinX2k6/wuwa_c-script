using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher
{
	// Token: 0x0200004F RID: 79
	[NullableContext(1)]
	[Nullable(0)]
	public class InitialResDownloadStateLog : HotPatchLogData
	{
		// Token: 0x0600026B RID: 619 RVA: 0x0000C5E0 File Offset: 0x0000A7E0
		public InitialResDownloadStateLog(int downloadType, int downloadTime, int downloadStatus, string uniqueId, string traceId, int chooseByUser, int remainingSpace, int requiredSpace, [Nullable(2)] string playerId = null) : base("1700", uniqueId, playerId)
		{
			this.i_download_type = downloadType;
			this.i_download_time = downloadTime;
			this.i_download_status = downloadStatus;
			this.s_trace_id = traceId;
			this.i_type = chooseByUser;
			this.i_remaining_space = remainingSpace;
			this.i_required_space = requiredSpace;
		}

		// Token: 0x04000146 RID: 326
		public int i_download_type;

		// Token: 0x04000147 RID: 327
		public int i_download_time;

		// Token: 0x04000148 RID: 328
		public int i_download_status;

		// Token: 0x04000149 RID: 329
		public string s_trace_id = "";

		// Token: 0x0400014A RID: 330
		public int i_type;

		// Token: 0x0400014B RID: 331
		public int i_remaining_space;

		// Token: 0x0400014C RID: 332
		public int i_required_space;

		// Token: 0x0400014D RID: 333
		public int i_download_pkg;

		// Token: 0x0400014E RID: 334
		public int i_recommand_pkg;

		// Token: 0x0400014F RID: 335
		public int i_storage_bef;
	}
}

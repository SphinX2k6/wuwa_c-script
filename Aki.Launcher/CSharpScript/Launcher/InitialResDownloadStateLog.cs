using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher
{
	// Token: 0x0200004F RID: 79
	[NullableContext(1)]
	[Nullable(0)]
	public class InitialResDownloadStateLog : HotPatchLogData
	{
		// Token: 0x0600026B RID: 619 RVA: 0x0000C570 File Offset: 0x0000A770
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

		// Token: 0x0400013F RID: 319
		public int i_download_type;

		// Token: 0x04000140 RID: 320
		public int i_download_time;

		// Token: 0x04000141 RID: 321
		public int i_download_status;

		// Token: 0x04000142 RID: 322
		public string s_trace_id = "";

		// Token: 0x04000143 RID: 323
		public int i_type;

		// Token: 0x04000144 RID: 324
		public int i_remaining_space;

		// Token: 0x04000145 RID: 325
		public int i_required_space;

		// Token: 0x04000146 RID: 326
		public int i_download_pkg;

		// Token: 0x04000147 RID: 327
		public int i_recommand_pkg;

		// Token: 0x04000148 RID: 328
		public int i_storage_bef;
	}
}

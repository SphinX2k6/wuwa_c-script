using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher
{
	// Token: 0x02000050 RID: 80
	[NullableContext(1)]
	[Nullable(0)]
	public class ResDownloadDeviceStorageState : HotPatchLogData
	{
		// Token: 0x0600026C RID: 620 RVA: 0x0000C63C File Offset: 0x0000A83C
		public ResDownloadDeviceStorageState(int downloadType, bool ifStorageAlert, int requiredSpace, int remainingSpace, string uniqueId, string traceId, int chooseByUser, [Nullable(2)] string playerId = null) : base("1702", uniqueId, playerId)
		{
			this.i_download_type = downloadType;
			this.b_if_storage_alert = ifStorageAlert;
			if (ifStorageAlert)
			{
				this.i_required_space = requiredSpace;
				this.i_remaining_space = remainingSpace;
			}
			else
			{
				this.i_required_space = 0;
				this.i_remaining_space = 0;
			}
			this.s_trace_id = traceId;
			this.i_type = chooseByUser;
		}

		// Token: 0x04000150 RID: 336
		public int i_download_type;

		// Token: 0x04000151 RID: 337
		public bool b_if_storage_alert;

		// Token: 0x04000152 RID: 338
		public int i_required_space;

		// Token: 0x04000153 RID: 339
		public int i_remaining_space;

		// Token: 0x04000154 RID: 340
		public string s_trace_id = "";

		// Token: 0x04000155 RID: 341
		public int i_type;
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CCB RID: 19659
	public class IEditorRestartInfoT
	{
		// Token: 0x17008BC5 RID: 35781
		// (get) Token: 0x0601E413 RID: 123923 RVA: 0x0043D2EC File Offset: 0x0043B4EC
		// (set) Token: 0x0601E414 RID: 123924 RVA: 0x0043D2F4 File Offset: 0x0043B4F4
		public bool IsRestarting { get; set; }

		// Token: 0x17008BC6 RID: 35782
		// (get) Token: 0x0601E415 RID: 123925 RVA: 0x0043D2FD File Offset: 0x0043B4FD
		// (set) Token: 0x0601E416 RID: 123926 RVA: 0x0043D305 File Offset: 0x0043B505
		public bool IsUseIdleLoad { get; set; }

		// Token: 0x17008BC7 RID: 35783
		// (get) Token: 0x0601E417 RID: 123927 RVA: 0x0043D30E File Offset: 0x0043B50E
		// (set) Token: 0x0601E418 RID: 123928 RVA: 0x0043D316 File Offset: 0x0043B516
		public TEditorRestartReason Reason { get; set; }

		// Token: 0x17008BC8 RID: 35784
		// (get) Token: 0x0601E419 RID: 123929 RVA: 0x0043D31F File Offset: 0x0043B51F
		// (set) Token: 0x0601E41A RID: 123930 RVA: 0x0043D327 File Offset: 0x0043B527
		public long Timestamp { get; set; }

		// Token: 0x0601E41B RID: 123931 RVA: 0x0043D330 File Offset: 0x0043B530
		public IEditorRestartInfoT()
		{
			this.IsRestarting = false;
			this.IsUseIdleLoad = false;
			this.Reason = TEditorRestartReason.ChangeMap;
			this.Timestamp = 0L;
		}
	}
}

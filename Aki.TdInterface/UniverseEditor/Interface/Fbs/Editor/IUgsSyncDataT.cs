using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D22 RID: 19746
	public class IUgsSyncDataT
	{
		// Token: 0x17008D59 RID: 36185
		// (get) Token: 0x0601E951 RID: 125265 RVA: 0x00447D2C File Offset: 0x00445F2C
		// (set) Token: 0x0601E952 RID: 125266 RVA: 0x00447D34 File Offset: 0x00445F34
		public EP4SyncMethodType Type { get; set; }

		// Token: 0x17008D5A RID: 36186
		// (get) Token: 0x0601E953 RID: 125267 RVA: 0x00447D3D File Offset: 0x00445F3D
		// (set) Token: 0x0601E954 RID: 125268 RVA: 0x00447D45 File Offset: 0x00445F45
		public string ClientName { get; set; }

		// Token: 0x17008D5B RID: 36187
		// (get) Token: 0x0601E955 RID: 125269 RVA: 0x00447D4E File Offset: 0x00445F4E
		// (set) Token: 0x0601E956 RID: 125270 RVA: 0x00447D56 File Offset: 0x00445F56
		public string StreamName { get; set; }

		// Token: 0x17008D5C RID: 36188
		// (get) Token: 0x0601E957 RID: 125271 RVA: 0x00447D5F File Offset: 0x00445F5F
		// (set) Token: 0x0601E958 RID: 125272 RVA: 0x00447D67 File Offset: 0x00445F67
		public int CurrentChangeNumber { get; set; }

		// Token: 0x17008D5D RID: 36189
		// (get) Token: 0x0601E959 RID: 125273 RVA: 0x00447D70 File Offset: 0x00445F70
		// (set) Token: 0x0601E95A RID: 125274 RVA: 0x00447D78 File Offset: 0x00445F78
		public string LastSyncTime { get; set; }

		// Token: 0x17008D5E RID: 36190
		// (get) Token: 0x0601E95B RID: 125275 RVA: 0x00447D81 File Offset: 0x00445F81
		// (set) Token: 0x0601E95C RID: 125276 RVA: 0x00447D89 File Offset: 0x00445F89
		public int Timestamp { get; set; }

		// Token: 0x0601E95D RID: 125277 RVA: 0x00447D92 File Offset: 0x00445F92
		public IUgsSyncDataT()
		{
			this.Type = EP4SyncMethodType.EditorSavior;
			this.ClientName = null;
			this.StreamName = null;
			this.CurrentChangeNumber = 0;
			this.LastSyncTime = null;
			this.Timestamp = 0;
		}
	}
}

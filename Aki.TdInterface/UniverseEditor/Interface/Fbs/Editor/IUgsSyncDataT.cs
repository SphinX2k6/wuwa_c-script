using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048BD RID: 18621
	public class IUgsSyncDataT
	{
		// Token: 0x17008711 RID: 34577
		// (get) Token: 0x0601D164 RID: 119140 RVA: 0x0041B590 File Offset: 0x00419790
		// (set) Token: 0x0601D165 RID: 119141 RVA: 0x0041B598 File Offset: 0x00419798
		public EP4SyncMethodType Type { get; set; }

		// Token: 0x17008712 RID: 34578
		// (get) Token: 0x0601D166 RID: 119142 RVA: 0x0041B5A1 File Offset: 0x004197A1
		// (set) Token: 0x0601D167 RID: 119143 RVA: 0x0041B5A9 File Offset: 0x004197A9
		public string ClientName { get; set; }

		// Token: 0x17008713 RID: 34579
		// (get) Token: 0x0601D168 RID: 119144 RVA: 0x0041B5B2 File Offset: 0x004197B2
		// (set) Token: 0x0601D169 RID: 119145 RVA: 0x0041B5BA File Offset: 0x004197BA
		public string StreamName { get; set; }

		// Token: 0x17008714 RID: 34580
		// (get) Token: 0x0601D16A RID: 119146 RVA: 0x0041B5C3 File Offset: 0x004197C3
		// (set) Token: 0x0601D16B RID: 119147 RVA: 0x0041B5CB File Offset: 0x004197CB
		public int CurrentChangeNumber { get; set; }

		// Token: 0x17008715 RID: 34581
		// (get) Token: 0x0601D16C RID: 119148 RVA: 0x0041B5D4 File Offset: 0x004197D4
		// (set) Token: 0x0601D16D RID: 119149 RVA: 0x0041B5DC File Offset: 0x004197DC
		public string LastSyncTime { get; set; }

		// Token: 0x17008716 RID: 34582
		// (get) Token: 0x0601D16E RID: 119150 RVA: 0x0041B5E5 File Offset: 0x004197E5
		// (set) Token: 0x0601D16F RID: 119151 RVA: 0x0041B5ED File Offset: 0x004197ED
		public int Timestamp { get; set; }

		// Token: 0x0601D170 RID: 119152 RVA: 0x0041B5F6 File Offset: 0x004197F6
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

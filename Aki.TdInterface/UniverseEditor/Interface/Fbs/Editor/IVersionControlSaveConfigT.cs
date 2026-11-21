using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D25 RID: 19749
	public class IVersionControlSaveConfigT
	{
		// Token: 0x17008D69 RID: 36201
		// (get) Token: 0x0601E991 RID: 125329 RVA: 0x0044880E File Offset: 0x00446A0E
		// (set) Token: 0x0601E992 RID: 125330 RVA: 0x00448816 File Offset: 0x00446A16
		public bool IsSwarmPassAutoSync { get; set; }

		// Token: 0x17008D6A RID: 36202
		// (get) Token: 0x0601E993 RID: 125331 RVA: 0x0044881F File Offset: 0x00446A1F
		// (set) Token: 0x0601E994 RID: 125332 RVA: 0x00448827 File Offset: 0x00446A27
		public List<ICommitLogT> CommitLogs { get; set; }

		// Token: 0x17008D6B RID: 36203
		// (get) Token: 0x0601E995 RID: 125333 RVA: 0x00448830 File Offset: 0x00446A30
		// (set) Token: 0x0601E996 RID: 125334 RVA: 0x00448838 File Offset: 0x00446A38
		public string CommitLogInputCache { get; set; }

		// Token: 0x17008D6C RID: 36204
		// (get) Token: 0x0601E997 RID: 125335 RVA: 0x00448841 File Offset: 0x00446A41
		// (set) Token: 0x0601E998 RID: 125336 RVA: 0x00448849 File Offset: 0x00446A49
		public List<string> IgnoreCols { get; set; }

		// Token: 0x17008D6D RID: 36205
		// (get) Token: 0x0601E999 RID: 125337 RVA: 0x00448852 File Offset: 0x00446A52
		// (set) Token: 0x0601E99A RID: 125338 RVA: 0x0044885A File Offset: 0x00446A5A
		public bool IsFastScan { get; set; }

		// Token: 0x17008D6E RID: 36206
		// (get) Token: 0x0601E99B RID: 125339 RVA: 0x00448863 File Offset: 0x00446A63
		// (set) Token: 0x0601E99C RID: 125340 RVA: 0x0044886B File Offset: 0x00446A6B
		public ISpecificLevelScanDataT SpecificLevelScanData { get; set; }

		// Token: 0x17008D6F RID: 36207
		// (get) Token: 0x0601E99D RID: 125341 RVA: 0x00448874 File Offset: 0x00446A74
		// (set) Token: 0x0601E99E RID: 125342 RVA: 0x0044887C File Offset: 0x00446A7C
		public ICustomScanDirectoryDataT CustomScanDirectoryData { get; set; }

		// Token: 0x17008D70 RID: 36208
		// (get) Token: 0x0601E99F RID: 125343 RVA: 0x00448885 File Offset: 0x00446A85
		// (set) Token: 0x0601E9A0 RID: 125344 RVA: 0x0044888D File Offset: 0x00446A8D
		public List<IVersionControlSaveConfig_CommitTasksT> CommitTasks { get; set; }

		// Token: 0x17008D71 RID: 36209
		// (get) Token: 0x0601E9A1 RID: 125345 RVA: 0x00448896 File Offset: 0x00446A96
		// (set) Token: 0x0601E9A2 RID: 125346 RVA: 0x0044889E File Offset: 0x00446A9E
		public byte NullMask { get; set; }

		// Token: 0x0601E9A3 RID: 125347 RVA: 0x004488A8 File Offset: 0x00446AA8
		public IVersionControlSaveConfigT()
		{
			this.IsSwarmPassAutoSync = false;
			this.CommitLogs = null;
			this.CommitLogInputCache = null;
			this.IgnoreCols = null;
			this.IsFastScan = false;
			this.SpecificLevelScanData = null;
			this.CustomScanDirectoryData = null;
			this.CommitTasks = null;
			this.NullMask = 0;
		}
	}
}

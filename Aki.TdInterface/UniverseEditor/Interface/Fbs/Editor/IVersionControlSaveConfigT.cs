using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048C0 RID: 18624
	public class IVersionControlSaveConfigT
	{
		// Token: 0x17008721 RID: 34593
		// (get) Token: 0x0601D1A4 RID: 119204 RVA: 0x0041C072 File Offset: 0x0041A272
		// (set) Token: 0x0601D1A5 RID: 119205 RVA: 0x0041C07A File Offset: 0x0041A27A
		public bool IsSwarmPassAutoSync { get; set; }

		// Token: 0x17008722 RID: 34594
		// (get) Token: 0x0601D1A6 RID: 119206 RVA: 0x0041C083 File Offset: 0x0041A283
		// (set) Token: 0x0601D1A7 RID: 119207 RVA: 0x0041C08B File Offset: 0x0041A28B
		public List<ICommitLogT> CommitLogs { get; set; }

		// Token: 0x17008723 RID: 34595
		// (get) Token: 0x0601D1A8 RID: 119208 RVA: 0x0041C094 File Offset: 0x0041A294
		// (set) Token: 0x0601D1A9 RID: 119209 RVA: 0x0041C09C File Offset: 0x0041A29C
		public string CommitLogInputCache { get; set; }

		// Token: 0x17008724 RID: 34596
		// (get) Token: 0x0601D1AA RID: 119210 RVA: 0x0041C0A5 File Offset: 0x0041A2A5
		// (set) Token: 0x0601D1AB RID: 119211 RVA: 0x0041C0AD File Offset: 0x0041A2AD
		public List<string> IgnoreCols { get; set; }

		// Token: 0x17008725 RID: 34597
		// (get) Token: 0x0601D1AC RID: 119212 RVA: 0x0041C0B6 File Offset: 0x0041A2B6
		// (set) Token: 0x0601D1AD RID: 119213 RVA: 0x0041C0BE File Offset: 0x0041A2BE
		public bool IsFastScan { get; set; }

		// Token: 0x17008726 RID: 34598
		// (get) Token: 0x0601D1AE RID: 119214 RVA: 0x0041C0C7 File Offset: 0x0041A2C7
		// (set) Token: 0x0601D1AF RID: 119215 RVA: 0x0041C0CF File Offset: 0x0041A2CF
		public ISpecificLevelScanDataT SpecificLevelScanData { get; set; }

		// Token: 0x17008727 RID: 34599
		// (get) Token: 0x0601D1B0 RID: 119216 RVA: 0x0041C0D8 File Offset: 0x0041A2D8
		// (set) Token: 0x0601D1B1 RID: 119217 RVA: 0x0041C0E0 File Offset: 0x0041A2E0
		public ICustomScanDirectoryDataT CustomScanDirectoryData { get; set; }

		// Token: 0x17008728 RID: 34600
		// (get) Token: 0x0601D1B2 RID: 119218 RVA: 0x0041C0E9 File Offset: 0x0041A2E9
		// (set) Token: 0x0601D1B3 RID: 119219 RVA: 0x0041C0F1 File Offset: 0x0041A2F1
		public List<IVersionControlSaveConfig_CommitTasksT> CommitTasks { get; set; }

		// Token: 0x17008729 RID: 34601
		// (get) Token: 0x0601D1B4 RID: 119220 RVA: 0x0041C0FA File Offset: 0x0041A2FA
		// (set) Token: 0x0601D1B5 RID: 119221 RVA: 0x0041C102 File Offset: 0x0041A302
		public byte NullMask { get; set; }

		// Token: 0x0601D1B6 RID: 119222 RVA: 0x0041C10C File Offset: 0x0041A30C
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

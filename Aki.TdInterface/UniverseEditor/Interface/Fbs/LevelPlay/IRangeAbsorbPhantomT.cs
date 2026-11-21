using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049A2 RID: 18850
	public class IRangeAbsorbPhantomT
	{
		// Token: 0x170083F3 RID: 33779
		// (get) Token: 0x0601C254 RID: 115284 RVA: 0x003F9DA9 File Offset: 0x003F7FA9
		// (set) Token: 0x0601C255 RID: 115285 RVA: 0x003F9DB1 File Offset: 0x003F7FB1
		public int PlayerActiveFuncRangeEntity { get; set; }

		// Token: 0x170083F4 RID: 33780
		// (get) Token: 0x0601C256 RID: 115286 RVA: 0x003F9DBA File Offset: 0x003F7FBA
		// (set) Token: 0x0601C257 RID: 115287 RVA: 0x003F9DC2 File Offset: 0x003F7FC2
		public int AutoAbsorbRangeEntity { get; set; }

		// Token: 0x170083F5 RID: 33781
		// (get) Token: 0x0601C258 RID: 115288 RVA: 0x003F9DCB File Offset: 0x003F7FCB
		// (set) Token: 0x0601C259 RID: 115289 RVA: 0x003F9DD3 File Offset: 0x003F7FD3
		public List<int> IntervalKillNumber { get; set; }

		// Token: 0x170083F6 RID: 33782
		// (get) Token: 0x0601C25A RID: 115290 RVA: 0x003F9DDC File Offset: 0x003F7FDC
		// (set) Token: 0x0601C25B RID: 115291 RVA: 0x003F9DE4 File Offset: 0x003F7FE4
		public float DelayTime { get; set; }

		// Token: 0x170083F7 RID: 33783
		// (get) Token: 0x0601C25C RID: 115292 RVA: 0x003F9DED File Offset: 0x003F7FED
		// (set) Token: 0x0601C25D RID: 115293 RVA: 0x003F9DF5 File Offset: 0x003F7FF5
		public byte NullMask { get; set; }

		// Token: 0x0601C25E RID: 115294 RVA: 0x003F9DFE File Offset: 0x003F7FFE
		public IRangeAbsorbPhantomT()
		{
			this.PlayerActiveFuncRangeEntity = 0;
			this.AutoAbsorbRangeEntity = 0;
			this.IntervalKillNumber = null;
			this.DelayTime = 0f;
			this.NullMask = 0;
		}
	}
}

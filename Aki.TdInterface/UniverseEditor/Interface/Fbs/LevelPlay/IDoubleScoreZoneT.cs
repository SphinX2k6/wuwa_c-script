using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200449E RID: 17566
	public class IDoubleScoreZoneT
	{
		// Token: 0x17007BF5 RID: 31733
		// (get) Token: 0x0601A396 RID: 107414 RVA: 0x003BF3CA File Offset: 0x003BD5CA
		// (set) Token: 0x0601A397 RID: 107415 RVA: 0x003BF3D2 File Offset: 0x003BD5D2
		public EDartboardZoneType Type { get; set; }

		// Token: 0x17007BF6 RID: 31734
		// (get) Token: 0x0601A398 RID: 107416 RVA: 0x003BF3DB File Offset: 0x003BD5DB
		// (set) Token: 0x0601A399 RID: 107417 RVA: 0x003BF3E3 File Offset: 0x003BD5E3
		public int Score { get; set; }

		// Token: 0x17007BF7 RID: 31735
		// (get) Token: 0x0601A39A RID: 107418 RVA: 0x003BF3EC File Offset: 0x003BD5EC
		// (set) Token: 0x0601A39B RID: 107419 RVA: 0x003BF3F4 File Offset: 0x003BD5F4
		public byte NullMask { get; set; }

		// Token: 0x0601A39C RID: 107420 RVA: 0x003BF3FD File Offset: 0x003BD5FD
		public IDoubleScoreZoneT()
		{
			this.Type = EDartboardZoneType.CenterBull;
			this.Score = 0;
			this.NullMask = 0;
		}
	}
}

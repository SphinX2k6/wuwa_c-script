using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A1A RID: 18970
	public class ISingleScoreZoneT
	{
		// Token: 0x17008513 RID: 34067
		// (get) Token: 0x0601C77C RID: 116604 RVA: 0x004050BA File Offset: 0x004032BA
		// (set) Token: 0x0601C77D RID: 116605 RVA: 0x004050C2 File Offset: 0x004032C2
		public EDartboardZoneType Type { get; set; }

		// Token: 0x17008514 RID: 34068
		// (get) Token: 0x0601C77E RID: 116606 RVA: 0x004050CB File Offset: 0x004032CB
		// (set) Token: 0x0601C77F RID: 116607 RVA: 0x004050D3 File Offset: 0x004032D3
		public int Score { get; set; }

		// Token: 0x17008515 RID: 34069
		// (get) Token: 0x0601C780 RID: 116608 RVA: 0x004050DC File Offset: 0x004032DC
		// (set) Token: 0x0601C781 RID: 116609 RVA: 0x004050E4 File Offset: 0x004032E4
		public byte NullMask { get; set; }

		// Token: 0x0601C782 RID: 116610 RVA: 0x004050ED File Offset: 0x004032ED
		public ISingleScoreZoneT()
		{
			this.Type = EDartboardZoneType.CenterBull;
			this.Score = 0;
			this.NullMask = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045D6 RID: 17878
	public class ITripleScoreZoneT
	{
		// Token: 0x17007F18 RID: 32536
		// (get) Token: 0x0601B0DF RID: 110815 RVA: 0x003DB036 File Offset: 0x003D9236
		// (set) Token: 0x0601B0E0 RID: 110816 RVA: 0x003DB03E File Offset: 0x003D923E
		public EDartboardZoneType Type { get; set; }

		// Token: 0x17007F19 RID: 32537
		// (get) Token: 0x0601B0E1 RID: 110817 RVA: 0x003DB047 File Offset: 0x003D9247
		// (set) Token: 0x0601B0E2 RID: 110818 RVA: 0x003DB04F File Offset: 0x003D924F
		public int Score { get; set; }

		// Token: 0x17007F1A RID: 32538
		// (get) Token: 0x0601B0E3 RID: 110819 RVA: 0x003DB058 File Offset: 0x003D9258
		// (set) Token: 0x0601B0E4 RID: 110820 RVA: 0x003DB060 File Offset: 0x003D9260
		public byte NullMask { get; set; }

		// Token: 0x0601B0E5 RID: 110821 RVA: 0x003DB069 File Offset: 0x003D9269
		public ITripleScoreZoneT()
		{
			this.Type = EDartboardZoneType.CenterBull;
			this.Score = 0;
			this.NullMask = 0;
		}
	}
}

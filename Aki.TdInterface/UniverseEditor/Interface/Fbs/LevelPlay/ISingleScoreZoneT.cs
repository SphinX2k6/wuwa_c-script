using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045B2 RID: 17842
	public class ISingleScoreZoneT
	{
		// Token: 0x17007ED2 RID: 32466
		// (get) Token: 0x0601AFA7 RID: 110503 RVA: 0x003D8E1E File Offset: 0x003D701E
		// (set) Token: 0x0601AFA8 RID: 110504 RVA: 0x003D8E26 File Offset: 0x003D7026
		public EDartboardZoneType Type { get; set; }

		// Token: 0x17007ED3 RID: 32467
		// (get) Token: 0x0601AFA9 RID: 110505 RVA: 0x003D8E2F File Offset: 0x003D702F
		// (set) Token: 0x0601AFAA RID: 110506 RVA: 0x003D8E37 File Offset: 0x003D7037
		public int Score { get; set; }

		// Token: 0x17007ED4 RID: 32468
		// (get) Token: 0x0601AFAB RID: 110507 RVA: 0x003D8E40 File Offset: 0x003D7040
		// (set) Token: 0x0601AFAC RID: 110508 RVA: 0x003D8E48 File Offset: 0x003D7048
		public byte NullMask { get; set; }

		// Token: 0x0601AFAD RID: 110509 RVA: 0x003D8E51 File Offset: 0x003D7051
		public ISingleScoreZoneT()
		{
			this.Type = EDartboardZoneType.CenterBull;
			this.Score = 0;
			this.NullMask = 0;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004906 RID: 18694
	public class IDoubleScoreZoneT
	{
		// Token: 0x17008234 RID: 33332
		// (get) Token: 0x0601BB67 RID: 113511 RVA: 0x003EB5D6 File Offset: 0x003E97D6
		// (set) Token: 0x0601BB68 RID: 113512 RVA: 0x003EB5DE File Offset: 0x003E97DE
		public EDartboardZoneType Type { get; set; }

		// Token: 0x17008235 RID: 33333
		// (get) Token: 0x0601BB69 RID: 113513 RVA: 0x003EB5E7 File Offset: 0x003E97E7
		// (set) Token: 0x0601BB6A RID: 113514 RVA: 0x003EB5EF File Offset: 0x003E97EF
		public int Score { get; set; }

		// Token: 0x17008236 RID: 33334
		// (get) Token: 0x0601BB6B RID: 113515 RVA: 0x003EB5F8 File Offset: 0x003E97F8
		// (set) Token: 0x0601BB6C RID: 113516 RVA: 0x003EB600 File Offset: 0x003E9800
		public byte NullMask { get; set; }

		// Token: 0x0601BB6D RID: 113517 RVA: 0x003EB609 File Offset: 0x003E9809
		public IDoubleScoreZoneT()
		{
			this.Type = EDartboardZoneType.CenterBull;
			this.Score = 0;
			this.NullMask = 0;
		}
	}
}

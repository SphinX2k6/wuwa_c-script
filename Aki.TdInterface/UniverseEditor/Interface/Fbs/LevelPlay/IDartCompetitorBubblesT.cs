using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200446B RID: 17515
	public class IDartCompetitorBubblesT
	{
		// Token: 0x17007B9A RID: 31642
		// (get) Token: 0x0601A1AC RID: 106924 RVA: 0x003BAD85 File Offset: 0x003B8F85
		// (set) Token: 0x0601A1AD RID: 106925 RVA: 0x003BAD8D File Offset: 0x003B8F8D
		public IBubbleIndexT PlayerRoundScoreOver150 { get; set; }

		// Token: 0x17007B9B RID: 31643
		// (get) Token: 0x0601A1AE RID: 106926 RVA: 0x003BAD96 File Offset: 0x003B8F96
		// (set) Token: 0x0601A1AF RID: 106927 RVA: 0x003BAD9E File Offset: 0x003B8F9E
		public IBubbleIndexT CompetitorRoundScoreOver150 { get; set; }

		// Token: 0x17007B9C RID: 31644
		// (get) Token: 0x0601A1B0 RID: 106928 RVA: 0x003BADA7 File Offset: 0x003B8FA7
		// (set) Token: 0x0601A1B1 RID: 106929 RVA: 0x003BADAF File Offset: 0x003B8FAF
		public IBubbleIndexT CompetitorRoundScore100To149 { get; set; }

		// Token: 0x17007B9D RID: 31645
		// (get) Token: 0x0601A1B2 RID: 106930 RVA: 0x003BADB8 File Offset: 0x003B8FB8
		// (set) Token: 0x0601A1B3 RID: 106931 RVA: 0x003BADC0 File Offset: 0x003B8FC0
		public IBubbleIndexT CompetitorHitZeroScore { get; set; }

		// Token: 0x0601A1B4 RID: 106932 RVA: 0x003BADC9 File Offset: 0x003B8FC9
		public IDartCompetitorBubblesT()
		{
			this.PlayerRoundScoreOver150 = null;
			this.CompetitorRoundScoreOver150 = null;
			this.CompetitorRoundScore100To149 = null;
			this.CompetitorHitZeroScore = null;
		}
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048D3 RID: 18643
	public class IDartCompetitorBubblesT
	{
		// Token: 0x170081D9 RID: 33241
		// (get) Token: 0x0601B97D RID: 113021 RVA: 0x003E6F91 File Offset: 0x003E5191
		// (set) Token: 0x0601B97E RID: 113022 RVA: 0x003E6F99 File Offset: 0x003E5199
		public IBubbleIndexT PlayerRoundScoreOver150 { get; set; }

		// Token: 0x170081DA RID: 33242
		// (get) Token: 0x0601B97F RID: 113023 RVA: 0x003E6FA2 File Offset: 0x003E51A2
		// (set) Token: 0x0601B980 RID: 113024 RVA: 0x003E6FAA File Offset: 0x003E51AA
		public IBubbleIndexT CompetitorRoundScoreOver150 { get; set; }

		// Token: 0x170081DB RID: 33243
		// (get) Token: 0x0601B981 RID: 113025 RVA: 0x003E6FB3 File Offset: 0x003E51B3
		// (set) Token: 0x0601B982 RID: 113026 RVA: 0x003E6FBB File Offset: 0x003E51BB
		public IBubbleIndexT CompetitorRoundScore100To149 { get; set; }

		// Token: 0x170081DC RID: 33244
		// (get) Token: 0x0601B983 RID: 113027 RVA: 0x003E6FC4 File Offset: 0x003E51C4
		// (set) Token: 0x0601B984 RID: 113028 RVA: 0x003E6FCC File Offset: 0x003E51CC
		public IBubbleIndexT CompetitorHitZeroScore { get; set; }

		// Token: 0x0601B985 RID: 113029 RVA: 0x003E6FD5 File Offset: 0x003E51D5
		public IDartCompetitorBubblesT()
		{
			this.PlayerRoundScoreOver150 = null;
			this.CompetitorRoundScoreOver150 = null;
			this.CompetitorRoundScore100To149 = null;
			this.CompetitorHitZeroScore = null;
		}
	}
}

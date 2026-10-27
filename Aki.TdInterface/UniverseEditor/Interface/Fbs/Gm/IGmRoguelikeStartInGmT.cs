using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004667 RID: 18023
	public class IGmRoguelikeStartInGmT
	{
		// Token: 0x17007FF3 RID: 32755
		// (get) Token: 0x0601B59B RID: 112027 RVA: 0x003E39AA File Offset: 0x003E1BAA
		// (set) Token: 0x0601B59C RID: 112028 RVA: 0x003E39B2 File Offset: 0x003E1BB2
		public EGmCommand Type { get; set; }

		// Token: 0x17007FF4 RID: 32756
		// (get) Token: 0x0601B59D RID: 112029 RVA: 0x003E39BB File Offset: 0x003E1BBB
		// (set) Token: 0x0601B59E RID: 112030 RVA: 0x003E39C3 File Offset: 0x003E1BC3
		public int DungeonId { get; set; }

		// Token: 0x17007FF5 RID: 32757
		// (get) Token: 0x0601B59F RID: 112031 RVA: 0x003E39CC File Offset: 0x003E1BCC
		// (set) Token: 0x0601B5A0 RID: 112032 RVA: 0x003E39D4 File Offset: 0x003E1BD4
		public int SeasonId { get; set; }

		// Token: 0x17007FF6 RID: 32758
		// (get) Token: 0x0601B5A1 RID: 112033 RVA: 0x003E39DD File Offset: 0x003E1BDD
		// (set) Token: 0x0601B5A2 RID: 112034 RVA: 0x003E39E5 File Offset: 0x003E1BE5
		public int Inherit { get; set; }

		// Token: 0x17007FF7 RID: 32759
		// (get) Token: 0x0601B5A3 RID: 112035 RVA: 0x003E39EE File Offset: 0x003E1BEE
		// (set) Token: 0x0601B5A4 RID: 112036 RVA: 0x003E39F6 File Offset: 0x003E1BF6
		public int RoleId { get; set; }

		// Token: 0x0601B5A5 RID: 112037 RVA: 0x003E39FF File Offset: 0x003E1BFF
		public IGmRoguelikeStartInGmT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.DungeonId = 0;
			this.SeasonId = 0;
			this.Inherit = 0;
			this.RoleId = 0;
		}
	}
}

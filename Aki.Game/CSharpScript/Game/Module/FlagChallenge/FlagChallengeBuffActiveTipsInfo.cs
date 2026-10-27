using System;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A35 RID: 23093
	public class FlagChallengeBuffActiveTipsInfo : IFlagChallengeBuffActiveTipsInfo
	{
		// Token: 0x17008BE2 RID: 35810
		// (get) Token: 0x0603A95A RID: 239962 RVA: 0x00DF12B7 File Offset: 0x00DEF4B7
		// (set) Token: 0x0603A95B RID: 239963 RVA: 0x00DF12BF File Offset: 0x00DEF4BF
		public int BuffId { get; set; }

		// Token: 0x17008BE3 RID: 35811
		// (get) Token: 0x0603A95C RID: 239964 RVA: 0x00DF12C8 File Offset: 0x00DEF4C8
		// (set) Token: 0x0603A95D RID: 239965 RVA: 0x00DF12D0 File Offset: 0x00DEF4D0
		public EFlagChallengeBuffStatus State { get; set; }
	}
}

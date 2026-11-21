using System;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A15 RID: 18965
	public class FlagChallengeSettleInfo : IFlagChallengeSettleInfo
	{
		// Token: 0x17005FBB RID: 24507
		// (get) Token: 0x0602F8BB RID: 194747 RVA: 0x00D418A0 File Offset: 0x00D3FAA0
		// (set) Token: 0x0602F8BC RID: 194748 RVA: 0x00D418A8 File Offset: 0x00D3FAA8
		public int Level { get; set; }

		// Token: 0x17005FBC RID: 24508
		// (get) Token: 0x0602F8BD RID: 194749 RVA: 0x00D418B1 File Offset: 0x00D3FAB1
		// (set) Token: 0x0602F8BE RID: 194750 RVA: 0x00D418B9 File Offset: 0x00D3FAB9
		public int CacheLevel { get; set; }

		// Token: 0x17005FBD RID: 24509
		// (get) Token: 0x0602F8BF RID: 194751 RVA: 0x00D418C2 File Offset: 0x00D3FAC2
		// (set) Token: 0x0602F8C0 RID: 194752 RVA: 0x00D418CA File Offset: 0x00D3FACA
		public int BoxLevel { get; set; }
	}
}

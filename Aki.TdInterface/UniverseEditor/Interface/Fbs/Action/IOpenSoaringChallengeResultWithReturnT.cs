using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C31 RID: 27697
	public class IOpenSoaringChallengeResultWithReturnT
	{
		// Token: 0x1700CE0A RID: 52746
		// (get) Token: 0x06030BC8 RID: 199624 RVA: 0x0069E447 File Offset: 0x0069C647
		// (set) Token: 0x06030BC9 RID: 199625 RVA: 0x0069E44F File Offset: 0x0069C64F
		public ESystemType Type { get; set; }

		// Token: 0x1700CE0B RID: 52747
		// (get) Token: 0x06030BCA RID: 199626 RVA: 0x0069E458 File Offset: 0x0069C658
		// (set) Token: 0x06030BCB RID: 199627 RVA: 0x0069E460 File Offset: 0x0069C660
		public TVarRefUnion Score { get; set; }

		// Token: 0x1700CE0C RID: 52748
		// (get) Token: 0x06030BCC RID: 199628 RVA: 0x0069E469 File Offset: 0x0069C669
		// (set) Token: 0x06030BCD RID: 199629 RVA: 0x0069E471 File Offset: 0x0069C671
		public int RankS { get; set; }

		// Token: 0x1700CE0D RID: 52749
		// (get) Token: 0x06030BCE RID: 199630 RVA: 0x0069E47A File Offset: 0x0069C67A
		// (set) Token: 0x06030BCF RID: 199631 RVA: 0x0069E482 File Offset: 0x0069C682
		public int RankA { get; set; }

		// Token: 0x1700CE0E RID: 52750
		// (get) Token: 0x06030BD0 RID: 199632 RVA: 0x0069E48B File Offset: 0x0069C68B
		// (set) Token: 0x06030BD1 RID: 199633 RVA: 0x0069E493 File Offset: 0x0069C693
		public int RankB { get; set; }

		// Token: 0x1700CE0F RID: 52751
		// (get) Token: 0x06030BD2 RID: 199634 RVA: 0x0069E49C File Offset: 0x0069C69C
		// (set) Token: 0x06030BD3 RID: 199635 RVA: 0x0069E4A4 File Offset: 0x0069C6A4
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x06030BD4 RID: 199636 RVA: 0x0069E4AD File Offset: 0x0069C6AD
		public IOpenSoaringChallengeResultWithReturnT()
		{
			this.Type = ESystemType.Shop;
			this.Score = null;
			this.RankS = 0;
			this.RankA = 0;
			this.RankB = 0;
			this.ReturnVar = null;
		}
	}
}

using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007374 RID: 29556
	public class IOpenMechaStuntTrackChallengeResultWithReturnT
	{
		// Token: 0x1700D8D0 RID: 55504
		// (get) Token: 0x0603398D RID: 211341 RVA: 0x006F48EF File Offset: 0x006F2AEF
		// (set) Token: 0x0603398E RID: 211342 RVA: 0x006F48F7 File Offset: 0x006F2AF7
		public ESystemType Type { get; set; }

		// Token: 0x1700D8D1 RID: 55505
		// (get) Token: 0x0603398F RID: 211343 RVA: 0x006F4900 File Offset: 0x006F2B00
		// (set) Token: 0x06033990 RID: 211344 RVA: 0x006F4908 File Offset: 0x006F2B08
		public TVarRefUnion Score { get; set; }

		// Token: 0x1700D8D2 RID: 55506
		// (get) Token: 0x06033991 RID: 211345 RVA: 0x006F4911 File Offset: 0x006F2B11
		// (set) Token: 0x06033992 RID: 211346 RVA: 0x006F4919 File Offset: 0x006F2B19
		public int RankS { get; set; }

		// Token: 0x1700D8D3 RID: 55507
		// (get) Token: 0x06033993 RID: 211347 RVA: 0x006F4922 File Offset: 0x006F2B22
		// (set) Token: 0x06033994 RID: 211348 RVA: 0x006F492A File Offset: 0x006F2B2A
		public int RankA { get; set; }

		// Token: 0x1700D8D4 RID: 55508
		// (get) Token: 0x06033995 RID: 211349 RVA: 0x006F4933 File Offset: 0x006F2B33
		// (set) Token: 0x06033996 RID: 211350 RVA: 0x006F493B File Offset: 0x006F2B3B
		public int RankB { get; set; }

		// Token: 0x1700D8D5 RID: 55509
		// (get) Token: 0x06033997 RID: 211351 RVA: 0x006F4944 File Offset: 0x006F2B44
		// (set) Token: 0x06033998 RID: 211352 RVA: 0x006F494C File Offset: 0x006F2B4C
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x06033999 RID: 211353 RVA: 0x006F4955 File Offset: 0x006F2B55
		public IOpenMechaStuntTrackChallengeResultWithReturnT()
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

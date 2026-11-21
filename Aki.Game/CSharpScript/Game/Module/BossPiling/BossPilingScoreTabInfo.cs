using System;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02004BE0 RID: 19424
	public class BossPilingScoreTabInfo : IBossPilingScoreTabInfo
	{
		// Token: 0x1700615A RID: 24922
		// (get) Token: 0x060307B9 RID: 198585 RVA: 0x00D8247E File Offset: 0x00D8067E
		// (set) Token: 0x060307BA RID: 198586 RVA: 0x00D82486 File Offset: 0x00D80686
		public int BossHp { get; set; }

		// Token: 0x1700615B RID: 24923
		// (get) Token: 0x060307BB RID: 198587 RVA: 0x00D8248F File Offset: 0x00D8068F
		// (set) Token: 0x060307BC RID: 198588 RVA: 0x00D82497 File Offset: 0x00D80697
		public int Quality { get; set; }

		// Token: 0x1700615C RID: 24924
		// (get) Token: 0x060307BD RID: 198589 RVA: 0x00D824A0 File Offset: 0x00D806A0
		// (set) Token: 0x060307BE RID: 198590 RVA: 0x00D824A8 File Offset: 0x00D806A8
		public bool IsAchieve { get; set; }
	}
}

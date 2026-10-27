using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004ECC RID: 20172
	public class RogueBattleMapRoleGridInfo : IRogueBattleMapRoleGridInfo
	{
		// Token: 0x17007F04 RID: 32516
		// (get) Token: 0x06033C9B RID: 212123 RVA: 0x00C20F70 File Offset: 0x00C1F170
		// (set) Token: 0x06033C9C RID: 212124 RVA: 0x00C20F78 File Offset: 0x00C1F178
		public int ConfigId { get; set; }

		// Token: 0x17007F05 RID: 32517
		// (get) Token: 0x06033C9D RID: 212125 RVA: 0x00C20F81 File Offset: 0x00C1F181
		// (set) Token: 0x06033C9E RID: 212126 RVA: 0x00C20F89 File Offset: 0x00C1F189
		public bool IsGain { get; set; }

		// Token: 0x17007F06 RID: 32518
		// (get) Token: 0x06033C9F RID: 212127 RVA: 0x00C20F92 File Offset: 0x00C1F192
		// (set) Token: 0x06033CA0 RID: 212128 RVA: 0x00C20F9A File Offset: 0x00C1F19A
		public bool NeedLevel { get; set; }
	}
}

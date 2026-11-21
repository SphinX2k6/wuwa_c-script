using System;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E95 RID: 16021
	public class RogueBattleMapRoleGridInfo : IRogueBattleMapRoleGridInfo
	{
		// Token: 0x170052B4 RID: 21172
		// (get) Token: 0x06028B06 RID: 166662 RVA: 0x00B6A488 File Offset: 0x00B68688
		// (set) Token: 0x06028B07 RID: 166663 RVA: 0x00B6A490 File Offset: 0x00B68690
		public int ConfigId { get; set; }

		// Token: 0x170052B5 RID: 21173
		// (get) Token: 0x06028B08 RID: 166664 RVA: 0x00B6A499 File Offset: 0x00B68699
		// (set) Token: 0x06028B09 RID: 166665 RVA: 0x00B6A4A1 File Offset: 0x00B686A1
		public bool IsGain { get; set; }

		// Token: 0x170052B6 RID: 21174
		// (get) Token: 0x06028B0A RID: 166666 RVA: 0x00B6A4AA File Offset: 0x00B686AA
		// (set) Token: 0x06028B0B RID: 166667 RVA: 0x00B6A4B2 File Offset: 0x00B686B2
		public bool NeedLevel { get; set; }
	}
}

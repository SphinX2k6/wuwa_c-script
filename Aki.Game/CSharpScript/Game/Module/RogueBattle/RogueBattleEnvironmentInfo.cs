using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003EA0 RID: 16032
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleEnvironmentInfo : IRogueBattleEnvironmentInfo
	{
		// Token: 0x170052D2 RID: 21202
		// (get) Token: 0x06028B47 RID: 166727 RVA: 0x00B6A5D0 File Offset: 0x00B687D0
		// (set) Token: 0x06028B48 RID: 166728 RVA: 0x00B6A5D8 File Offset: 0x00B687D8
		public string Icon { get; set; } = string.Empty;

		// Token: 0x170052D3 RID: 21203
		// (get) Token: 0x06028B49 RID: 166729 RVA: 0x00B6A5E1 File Offset: 0x00B687E1
		// (set) Token: 0x06028B4A RID: 166730 RVA: 0x00B6A5E9 File Offset: 0x00B687E9
		public string TextId { get; set; } = string.Empty;

		// Token: 0x170052D4 RID: 21204
		// (get) Token: 0x06028B4B RID: 166731 RVA: 0x00B6A5F2 File Offset: 0x00B687F2
		// (set) Token: 0x06028B4C RID: 166732 RVA: 0x00B6A5FA File Offset: 0x00B687FA
		public List<string> Param { get; set; } = new List<string>();
	}
}

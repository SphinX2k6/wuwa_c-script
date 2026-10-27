using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004ECE RID: 20174
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleRoleAffixDetailOpenParam : IRogueBattleRoleAffixDetailOpenParam
	{
		// Token: 0x17007F0A RID: 32522
		// (get) Token: 0x06033CA8 RID: 212136 RVA: 0x00C20FAB File Offset: 0x00C1F1AB
		// (set) Token: 0x06033CA9 RID: 212137 RVA: 0x00C20FB3 File Offset: 0x00C1F1B3
		public int Index { get; set; }

		// Token: 0x17007F0B RID: 32523
		// (get) Token: 0x06033CAA RID: 212138 RVA: 0x00C20FBC File Offset: 0x00C1F1BC
		// (set) Token: 0x06033CAB RID: 212139 RVA: 0x00C20FC4 File Offset: 0x00C1F1C4
		public List<int> AffixIds { get; set; } = new List<int>();

		// Token: 0x17007F0C RID: 32524
		// (get) Token: 0x06033CAC RID: 212140 RVA: 0x00C20FCD File Offset: 0x00C1F1CD
		// (set) Token: 0x06033CAD RID: 212141 RVA: 0x00C20FD5 File Offset: 0x00C1F1D5
		public int RoleId { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AC6 RID: 15046
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRankPlayerName : ITowerDefenseRankPlayerName
	{
		// Token: 0x17004EFF RID: 20223
		// (get) Token: 0x06026A8D RID: 158349 RVA: 0x00AD442C File Offset: 0x00AD262C
		// (set) Token: 0x06026A8E RID: 158350 RVA: 0x00AD4434 File Offset: 0x00AD2634
		public int PlayerId { get; set; }

		// Token: 0x17004F00 RID: 20224
		// (get) Token: 0x06026A8F RID: 158351 RVA: 0x00AD443D File Offset: 0x00AD263D
		// (set) Token: 0x06026A90 RID: 158352 RVA: 0x00AD4445 File Offset: 0x00AD2645
		public string PlayerName { get; set; }
	}
}

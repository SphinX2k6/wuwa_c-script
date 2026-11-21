using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AC5 RID: 15045
	[NullableContext(1)]
	public interface ITowerDefenseRankPlayerName
	{
		// Token: 0x17004EFD RID: 20221
		// (get) Token: 0x06026A89 RID: 158345
		// (set) Token: 0x06026A8A RID: 158346
		int PlayerId { get; set; }

		// Token: 0x17004EFE RID: 20222
		// (get) Token: 0x06026A8B RID: 158347
		// (set) Token: 0x06026A8C RID: 158348
		string PlayerName { get; set; }
	}
}

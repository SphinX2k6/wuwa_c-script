using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B1D RID: 19229
	[NullableContext(1)]
	public interface ITowerDefenseRankPlayerName
	{
		// Token: 0x17007B50 RID: 31568
		// (get) Token: 0x06031CF9 RID: 204025
		// (set) Token: 0x06031CFA RID: 204026
		int PlayerId { get; set; }

		// Token: 0x17007B51 RID: 31569
		// (get) Token: 0x06031CFB RID: 204027
		// (set) Token: 0x06031CFC RID: 204028
		string PlayerName { get; set; }
	}
}

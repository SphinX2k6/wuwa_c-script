using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B1E RID: 19230
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRankPlayerName : ITowerDefenseRankPlayerName
	{
		// Token: 0x17007B52 RID: 31570
		// (get) Token: 0x06031CFD RID: 204029 RVA: 0x00B903C8 File Offset: 0x00B8E5C8
		// (set) Token: 0x06031CFE RID: 204030 RVA: 0x00B903D0 File Offset: 0x00B8E5D0
		public int PlayerId { get; set; }

		// Token: 0x17007B53 RID: 31571
		// (get) Token: 0x06031CFF RID: 204031 RVA: 0x00B903D9 File Offset: 0x00B8E5D9
		// (set) Token: 0x06031D00 RID: 204032 RVA: 0x00B903E1 File Offset: 0x00B8E5E1
		public string PlayerName { get; set; }
	}
}

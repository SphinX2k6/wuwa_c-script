using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.GravityFlip
{
	// Token: 0x02006E1D RID: 28189
	[NullableContext(2)]
	[Nullable(0)]
	public class GravityFlipViewOpenParam : IGravityFlipViewOpenParam
	{
		// Token: 0x170099FC RID: 39420
		// (get) Token: 0x06044B96 RID: 281494 RVA: 0x010F63AA File Offset: 0x010F45AA
		// (set) Token: 0x06044B97 RID: 281495 RVA: 0x010F63B2 File Offset: 0x010F45B2
		public Action<int> SelectCallback { get; set; }
	}
}

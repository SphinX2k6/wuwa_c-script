using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D03 RID: 23811
	[NullableContext(1)]
	[Nullable(0)]
	internal class TsScreenEffectContext : IEffectContext
	{
		// Token: 0x17006E9A RID: 28314
		// (get) Token: 0x0603A3E8 RID: 238568 RVA: 0x010751D1 File Offset: 0x010733D1
		// (set) Token: 0x0603A3E9 RID: 238569 RVA: 0x010751D9 File Offset: 0x010733D9
		public string AssetPath { get; set; }

		// Token: 0x0603A3EA RID: 238570 RVA: 0x010751E2 File Offset: 0x010733E2
		public TsScreenEffectContext(string assetPath)
		{
			this.AssetPath = assetPath;
		}
	}
}

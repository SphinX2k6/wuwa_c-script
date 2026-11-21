using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D06 RID: 23814
	[NullableContext(1)]
	[Nullable(0)]
	internal class TsSwitchEffectStateContext : IEffectContext
	{
		// Token: 0x17006E9D RID: 28317
		// (get) Token: 0x0603A3F1 RID: 238577 RVA: 0x01075231 File Offset: 0x01073431
		// (set) Token: 0x0603A3F2 RID: 238578 RVA: 0x01075239 File Offset: 0x01073439
		public string AssetPath { get; set; }

		// Token: 0x0603A3F3 RID: 238579 RVA: 0x01075242 File Offset: 0x01073442
		public TsSwitchEffectStateContext(string assetPath)
		{
			this.AssetPath = assetPath;
		}
	}
}

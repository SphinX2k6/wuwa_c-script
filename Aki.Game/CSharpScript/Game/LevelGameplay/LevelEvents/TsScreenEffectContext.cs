using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B8B RID: 27531
	[NullableContext(1)]
	[Nullable(0)]
	internal class TsScreenEffectContext : IEffectContext
	{
		// Token: 0x17009997 RID: 39319
		// (get) Token: 0x06044296 RID: 279190 RVA: 0x010CB539 File Offset: 0x010C9739
		// (set) Token: 0x06044297 RID: 279191 RVA: 0x010CB541 File Offset: 0x010C9741
		public string AssetPath { get; set; }

		// Token: 0x06044298 RID: 279192 RVA: 0x010CB54A File Offset: 0x010C974A
		public TsScreenEffectContext(string assetPath)
		{
			this.AssetPath = assetPath;
		}
	}
}

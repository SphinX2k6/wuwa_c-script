using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B8D RID: 27533
	[NullableContext(1)]
	[Nullable(0)]
	internal class TsMpcEffectContext : IEffectContext
	{
		// Token: 0x17009999 RID: 39321
		// (get) Token: 0x0604429C RID: 279196 RVA: 0x010CB579 File Offset: 0x010C9779
		// (set) Token: 0x0604429D RID: 279197 RVA: 0x010CB581 File Offset: 0x010C9781
		public string AssetPath { get; set; }

		// Token: 0x0604429E RID: 279198 RVA: 0x010CB58A File Offset: 0x010C978A
		public TsMpcEffectContext(string assetPath)
		{
			this.AssetPath = assetPath;
		}
	}
}

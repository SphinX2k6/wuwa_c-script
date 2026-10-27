using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B8C RID: 27532
	[NullableContext(1)]
	[Nullable(0)]
	internal class TsDissolveEffectContext : IEffectContext
	{
		// Token: 0x17009998 RID: 39320
		// (get) Token: 0x06044299 RID: 279193 RVA: 0x010CB559 File Offset: 0x010C9759
		// (set) Token: 0x0604429A RID: 279194 RVA: 0x010CB561 File Offset: 0x010C9761
		public string AssetPath { get; set; }

		// Token: 0x0604429B RID: 279195 RVA: 0x010CB56A File Offset: 0x010C976A
		public TsDissolveEffectContext(string assetPath)
		{
			this.AssetPath = assetPath;
		}
	}
}

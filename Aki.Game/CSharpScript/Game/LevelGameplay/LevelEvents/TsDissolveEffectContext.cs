using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D04 RID: 23812
	[NullableContext(1)]
	[Nullable(0)]
	internal class TsDissolveEffectContext : IEffectContext
	{
		// Token: 0x17006E9B RID: 28315
		// (get) Token: 0x0603A3EB RID: 238571 RVA: 0x010751F1 File Offset: 0x010733F1
		// (set) Token: 0x0603A3EC RID: 238572 RVA: 0x010751F9 File Offset: 0x010733F9
		public string AssetPath { get; set; }

		// Token: 0x0603A3ED RID: 238573 RVA: 0x01075202 File Offset: 0x01073402
		public TsDissolveEffectContext(string assetPath)
		{
			this.AssetPath = assetPath;
		}
	}
}

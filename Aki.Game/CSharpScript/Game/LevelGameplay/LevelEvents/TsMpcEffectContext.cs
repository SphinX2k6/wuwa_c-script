using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D05 RID: 23813
	[NullableContext(1)]
	[Nullable(0)]
	internal class TsMpcEffectContext : IEffectContext
	{
		// Token: 0x17006E9C RID: 28316
		// (get) Token: 0x0603A3EE RID: 238574 RVA: 0x01075211 File Offset: 0x01073411
		// (set) Token: 0x0603A3EF RID: 238575 RVA: 0x01075219 File Offset: 0x01073419
		public string AssetPath { get; set; }

		// Token: 0x0603A3F0 RID: 238576 RVA: 0x01075222 File Offset: 0x01073422
		public TsMpcEffectContext(string assetPath)
		{
			this.AssetPath = assetPath;
		}
	}
}

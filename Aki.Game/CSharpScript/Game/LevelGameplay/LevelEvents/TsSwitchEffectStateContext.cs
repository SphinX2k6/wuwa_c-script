using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B8E RID: 27534
	[NullableContext(1)]
	[Nullable(0)]
	internal class TsSwitchEffectStateContext : IEffectContext
	{
		// Token: 0x1700999A RID: 39322
		// (get) Token: 0x0604429F RID: 279199 RVA: 0x010CB599 File Offset: 0x010C9799
		// (set) Token: 0x060442A0 RID: 279200 RVA: 0x010CB5A1 File Offset: 0x010C97A1
		public string AssetPath { get; set; }

		// Token: 0x060442A1 RID: 279201 RVA: 0x010CB5AA File Offset: 0x010C97AA
		public TsSwitchEffectStateContext(string assetPath)
		{
			this.AssetPath = assetPath;
		}
	}
}

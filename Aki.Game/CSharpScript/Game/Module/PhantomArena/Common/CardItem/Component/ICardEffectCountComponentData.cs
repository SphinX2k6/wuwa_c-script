using System;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020051E7 RID: 20967
	public interface ICardEffectCountComponentData
	{
		// Token: 0x170081C8 RID: 33224
		// (get) Token: 0x06035A40 RID: 219712
		// (set) Token: 0x06035A41 RID: 219713
		int EffectCount { get; set; }

		// Token: 0x170081C9 RID: 33225
		// (get) Token: 0x06035A42 RID: 219714
		// (set) Token: 0x06035A43 RID: 219715
		int EffectCountMax { get; set; }

		// Token: 0x170081CA RID: 33226
		// (get) Token: 0x06035A44 RID: 219716
		// (set) Token: 0x06035A45 RID: 219717
		bool InFight { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DAF RID: 15791
	[NullableContext(1)]
	public interface IPhantomAttrItemData
	{
		// Token: 0x1700526D RID: 21101
		// (get) Token: 0x060285E2 RID: 165346
		// (set) Token: 0x060285E3 RID: 165347
		AffixEntry AffixEntry { get; set; }

		// Token: 0x1700526E RID: 21102
		// (get) Token: 0x060285E4 RID: 165348
		// (set) Token: 0x060285E5 RID: 165349
		RoguelikeInfo RoguelikeInfo { get; set; }
	}
}

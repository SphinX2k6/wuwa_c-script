using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DB6 RID: 15798
	[NullableContext(1)]
	public interface IPhantomSelectItemContextData
	{
		// Token: 0x17005271 RID: 21105
		// (get) Token: 0x06028617 RID: 165399
		// (set) Token: 0x06028618 RID: 165400
		RogueGainEntry RogueGainEntry { get; set; }

		// Token: 0x17005272 RID: 21106
		// (get) Token: 0x06028619 RID: 165401
		// (set) Token: 0x0602861A RID: 165402
		RoguelikeInfo RoguelikeInfo { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DED RID: 19949
	[NullableContext(1)]
	public interface IPhantomSelectItemContextData
	{
		// Token: 0x17007EC1 RID: 32449
		// (get) Token: 0x060337AC RID: 210860
		// (set) Token: 0x060337AD RID: 210861
		RogueGainEntry RogueGainEntry { get; set; }

		// Token: 0x17007EC2 RID: 32450
		// (get) Token: 0x060337AE RID: 210862
		// (set) Token: 0x060337AF RID: 210863
		RoguelikeInfo RoguelikeInfo { get; set; }
	}
}

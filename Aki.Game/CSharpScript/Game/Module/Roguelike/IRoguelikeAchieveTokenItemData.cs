using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DAD RID: 19885
	[NullableContext(1)]
	public interface IRoguelikeAchieveTokenItemData
	{
		// Token: 0x17007EA3 RID: 32419
		// (get) Token: 0x06033585 RID: 210309
		// (set) Token: 0x06033586 RID: 210310
		RogueGainEntry GainEntry { get; set; }
	}
}

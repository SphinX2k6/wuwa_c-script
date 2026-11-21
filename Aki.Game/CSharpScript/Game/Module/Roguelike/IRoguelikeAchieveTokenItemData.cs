using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D76 RID: 15734
	[NullableContext(1)]
	public interface IRoguelikeAchieveTokenItemData
	{
		// Token: 0x17005253 RID: 21075
		// (get) Token: 0x060283F2 RID: 164850
		// (set) Token: 0x060283F3 RID: 164851
		RogueGainEntry GainEntry { get; set; }
	}
}

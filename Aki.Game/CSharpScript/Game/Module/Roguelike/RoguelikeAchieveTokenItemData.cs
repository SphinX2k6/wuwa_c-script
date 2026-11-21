using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D77 RID: 15735
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeAchieveTokenItemData : IRoguelikeAchieveTokenItemData
	{
		// Token: 0x17005254 RID: 21076
		// (get) Token: 0x060283F4 RID: 164852 RVA: 0x00B46272 File Offset: 0x00B44472
		// (set) Token: 0x060283F5 RID: 164853 RVA: 0x00B4627A File Offset: 0x00B4447A
		public RogueGainEntry GainEntry { get; set; }
	}
}

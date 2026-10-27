using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DAE RID: 19886
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeAchieveTokenItemData : IRoguelikeAchieveTokenItemData
	{
		// Token: 0x17007EA4 RID: 32420
		// (get) Token: 0x06033587 RID: 210311 RVA: 0x00BFCD40 File Offset: 0x00BFAF40
		// (set) Token: 0x06033588 RID: 210312 RVA: 0x00BFCD48 File Offset: 0x00BFAF48
		public RogueGainEntry GainEntry { get; set; }
	}
}

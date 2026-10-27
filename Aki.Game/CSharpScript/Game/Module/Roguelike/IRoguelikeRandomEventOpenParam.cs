using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004D8F RID: 19855
	[NullableContext(2)]
	public interface IRoguelikeRandomEventOpenParam
	{
		// Token: 0x17007E8A RID: 32394
		// (get) Token: 0x060334EE RID: 210158
		// (set) Token: 0x060334EF RID: 210159
		int BindId { get; set; }

		// Token: 0x17007E8B RID: 32395
		// (get) Token: 0x060334F0 RID: 210160
		// (set) Token: 0x060334F1 RID: 210161
		Action<int> SelectCallback { get; set; }
	}
}

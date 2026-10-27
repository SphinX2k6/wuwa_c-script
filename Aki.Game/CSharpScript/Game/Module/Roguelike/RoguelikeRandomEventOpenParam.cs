using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004D90 RID: 19856
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeRandomEventOpenParam : IRoguelikeRandomEventOpenParam
	{
		// Token: 0x17007E8C RID: 32396
		// (get) Token: 0x060334F2 RID: 210162 RVA: 0x00BFA054 File Offset: 0x00BF8254
		// (set) Token: 0x060334F3 RID: 210163 RVA: 0x00BFA05C File Offset: 0x00BF825C
		public int BindId { get; set; }

		// Token: 0x17007E8D RID: 32397
		// (get) Token: 0x060334F4 RID: 210164 RVA: 0x00BFA065 File Offset: 0x00BF8265
		// (set) Token: 0x060334F5 RID: 210165 RVA: 0x00BFA06D File Offset: 0x00BF826D
		public Action<int> SelectCallback { get; set; }
	}
}

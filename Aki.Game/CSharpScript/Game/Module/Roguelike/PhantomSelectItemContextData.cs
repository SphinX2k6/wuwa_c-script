using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DEE RID: 19950
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomSelectItemContextData : IPhantomSelectItemContextData
	{
		// Token: 0x17007EC3 RID: 32451
		// (get) Token: 0x060337B0 RID: 210864 RVA: 0x00C07599 File Offset: 0x00C05799
		// (set) Token: 0x060337B1 RID: 210865 RVA: 0x00C075A1 File Offset: 0x00C057A1
		public RogueGainEntry RogueGainEntry { get; set; }

		// Token: 0x17007EC4 RID: 32452
		// (get) Token: 0x060337B2 RID: 210866 RVA: 0x00C075AA File Offset: 0x00C057AA
		// (set) Token: 0x060337B3 RID: 210867 RVA: 0x00C075B2 File Offset: 0x00C057B2
		public RoguelikeInfo RoguelikeInfo { get; set; }
	}
}

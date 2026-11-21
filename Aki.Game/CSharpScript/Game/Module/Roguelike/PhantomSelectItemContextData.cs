using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DB7 RID: 15799
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomSelectItemContextData : IPhantomSelectItemContextData
	{
		// Token: 0x17005273 RID: 21107
		// (get) Token: 0x0602861B RID: 165403 RVA: 0x00B50AA9 File Offset: 0x00B4ECA9
		// (set) Token: 0x0602861C RID: 165404 RVA: 0x00B50AB1 File Offset: 0x00B4ECB1
		public RogueGainEntry RogueGainEntry { get; set; }

		// Token: 0x17005274 RID: 21108
		// (get) Token: 0x0602861D RID: 165405 RVA: 0x00B50ABA File Offset: 0x00B4ECBA
		// (set) Token: 0x0602861E RID: 165406 RVA: 0x00B50AC2 File Offset: 0x00B4ECC2
		public RoguelikeInfo RoguelikeInfo { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004154 RID: 16724
	[NullableContext(1)]
	public interface IDeckBuilderCardDeleteViewData
	{
		// Token: 0x170054FC RID: 21756
		// (get) Token: 0x0602A505 RID: 173317
		// (set) Token: 0x0602A506 RID: 173318
		HashSet<ECardElement> EnabledElementSet { get; set; }

		// Token: 0x170054FD RID: 21757
		// (get) Token: 0x0602A507 RID: 173319
		// (set) Token: 0x0602A508 RID: 173320
		Action<HashSet<ECardElement>> DeleteFunc { get; set; }
	}
}

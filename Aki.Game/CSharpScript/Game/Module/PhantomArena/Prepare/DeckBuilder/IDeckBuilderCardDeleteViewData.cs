using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02005184 RID: 20868
	[NullableContext(1)]
	public interface IDeckBuilderCardDeleteViewData
	{
		// Token: 0x1700813C RID: 33084
		// (get) Token: 0x0603560A RID: 218634
		// (set) Token: 0x0603560B RID: 218635
		HashSet<ECardElement> EnabledElementSet { get; set; }

		// Token: 0x1700813D RID: 33085
		// (get) Token: 0x0603560C RID: 218636
		// (set) Token: 0x0603560D RID: 218637
		Action<HashSet<ECardElement>> DeleteFunc { get; set; }
	}
}

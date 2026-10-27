using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02005185 RID: 20869
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderCardDeleteViewData : IDeckBuilderCardDeleteViewData
	{
		// Token: 0x1700813E RID: 33086
		// (get) Token: 0x0603560E RID: 218638 RVA: 0x00CA4E25 File Offset: 0x00CA3025
		// (set) Token: 0x0603560F RID: 218639 RVA: 0x00CA4E2D File Offset: 0x00CA302D
		public HashSet<ECardElement> EnabledElementSet { get; set; }

		// Token: 0x1700813F RID: 33087
		// (get) Token: 0x06035610 RID: 218640 RVA: 0x00CA4E36 File Offset: 0x00CA3036
		// (set) Token: 0x06035611 RID: 218641 RVA: 0x00CA4E3E File Offset: 0x00CA303E
		public Action<HashSet<ECardElement>> DeleteFunc { get; set; }
	}
}

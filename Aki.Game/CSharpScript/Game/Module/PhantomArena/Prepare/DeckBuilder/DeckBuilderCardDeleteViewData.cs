using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004155 RID: 16725
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderCardDeleteViewData : IDeckBuilderCardDeleteViewData
	{
		// Token: 0x170054FE RID: 21758
		// (get) Token: 0x0602A509 RID: 173321 RVA: 0x00BF23DD File Offset: 0x00BF05DD
		// (set) Token: 0x0602A50A RID: 173322 RVA: 0x00BF23E5 File Offset: 0x00BF05E5
		public HashSet<ECardElement> EnabledElementSet { get; set; }

		// Token: 0x170054FF RID: 21759
		// (get) Token: 0x0602A50B RID: 173323 RVA: 0x00BF23EE File Offset: 0x00BF05EE
		// (set) Token: 0x0602A50C RID: 173324 RVA: 0x00BF23F6 File Offset: 0x00BF05F6
		public Action<HashSet<ECardElement>> DeleteFunc { get; set; }
	}
}

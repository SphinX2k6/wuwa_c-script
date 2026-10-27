using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005136 RID: 20790
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class PhantomArenaReportDeckUpdateContext
	{
		// Token: 0x0603516B RID: 217451 RVA: 0x00C94272 File Offset: 0x00C92472
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public PhantomArenaReportDeckUpdateContext()
		{
		}

		// Token: 0x0401C4B9 RID: 115897
		[RequiredMember]
		public int ActivityId;

		// Token: 0x0401C4BA RID: 115898
		[RequiredMember]
		public DeckInfo DeckInfo;

		// Token: 0x0401C4BB RID: 115899
		[RequiredMember]
		public EPhantomArenaReportDeckOperation Operation;

		// Token: 0x0401C4BC RID: 115900
		[RequiredMember]
		public Dictionary<int, int> QuicklyBuildDeckUseTimes;

		// Token: 0x0401C4BD RID: 115901
		[RequiredMember]
		public int LastQuicklyBuildId;
	}
}

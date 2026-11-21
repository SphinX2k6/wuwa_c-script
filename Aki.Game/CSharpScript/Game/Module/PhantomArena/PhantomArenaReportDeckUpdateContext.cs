using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02004106 RID: 16646
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class PhantomArenaReportDeckUpdateContext
	{
		// Token: 0x0602A064 RID: 172132 RVA: 0x00BE1686 File Offset: 0x00BDF886
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public PhantomArenaReportDeckUpdateContext()
		{
		}

		// Token: 0x04016EEE RID: 93934
		[RequiredMember]
		public int ActivityId;

		// Token: 0x04016EEF RID: 93935
		[RequiredMember]
		public DeckInfo DeckInfo;

		// Token: 0x04016EF0 RID: 93936
		[RequiredMember]
		public EPhantomArenaReportDeckOperation Operation;

		// Token: 0x04016EF1 RID: 93937
		[RequiredMember]
		public Dictionary<int, int> QuicklyBuildDeckUseTimes;

		// Token: 0x04016EF2 RID: 93938
		[RequiredMember]
		public int LastQuicklyBuildId;
	}
}

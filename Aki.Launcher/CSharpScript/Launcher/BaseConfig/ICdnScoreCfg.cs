using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000261 RID: 609
	[NullableContext(1)]
	[Nullable(0)]
	public class ICdnScoreCfg
	{
		// Token: 0x04000A24 RID: 2596
		public string UsedCandidate = string.Empty;

		// Token: 0x04000A25 RID: 2597
		public List<ICdnScoreFormula> Candidates = new List<ICdnScoreFormula>();
	}
}

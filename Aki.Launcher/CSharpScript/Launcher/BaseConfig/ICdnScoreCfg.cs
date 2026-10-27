using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200025C RID: 604
	[NullableContext(1)]
	[Nullable(0)]
	public class ICdnScoreCfg
	{
		// Token: 0x040009D8 RID: 2520
		public string UsedCandidate = string.Empty;

		// Token: 0x040009D9 RID: 2521
		public List<ICdnScoreFormula> Candidates = new List<ICdnScoreFormula>();
	}
}

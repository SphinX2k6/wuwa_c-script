using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000260 RID: 608
	[NullableContext(1)]
	[Nullable(0)]
	public class ICdnScoreFormula
	{
		// Token: 0x04000A1F RID: 2591
		public string Name = string.Empty;

		// Token: 0x04000A20 RID: 2592
		public List<ICdnScoreStep> Steps = new List<ICdnScoreStep>();

		// Token: 0x04000A21 RID: 2593
		public string Output = string.Empty;

		// Token: 0x04000A22 RID: 2594
		public string Order = string.Empty;

		// Token: 0x04000A23 RID: 2595
		[Nullable(2)]
		public string Note;
	}
}

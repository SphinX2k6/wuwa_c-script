using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200025B RID: 603
	[NullableContext(1)]
	[Nullable(0)]
	public class ICdnScoreFormula
	{
		// Token: 0x040009D3 RID: 2515
		public string Name = string.Empty;

		// Token: 0x040009D4 RID: 2516
		public List<ICdnScoreStep> Steps = new List<ICdnScoreStep>();

		// Token: 0x040009D5 RID: 2517
		public string Output = string.Empty;

		// Token: 0x040009D6 RID: 2518
		public string Order = string.Empty;

		// Token: 0x040009D7 RID: 2519
		[Nullable(2)]
		public string Note;
	}
}

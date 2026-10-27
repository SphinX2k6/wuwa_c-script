using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x020001F3 RID: 499
	public sealed class CdnScoreSelectionResult
	{
		// Token: 0x04000803 RID: 2051
		[Nullable(2)]
		public ICdnScoreFormula Formula;

		// Token: 0x04000804 RID: 2052
		[Nullable(1)]
		public string Reason = string.Empty;
	}
}

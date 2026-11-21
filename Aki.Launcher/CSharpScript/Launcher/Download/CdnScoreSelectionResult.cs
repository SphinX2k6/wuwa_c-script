using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x020001F8 RID: 504
	public sealed class CdnScoreSelectionResult
	{
		// Token: 0x04000843 RID: 2115
		[Nullable(2)]
		public ICdnScoreFormula Formula;

		// Token: 0x04000844 RID: 2116
		[Nullable(1)]
		public string Reason = string.Empty;
	}
}

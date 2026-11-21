using System;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000685 RID: 1669
	[StructLayout(LayoutKind.Auto)]
	public readonly struct ConfiguredAsyncDisposable
	{
		// Token: 0x060073C2 RID: 29634 RVA: 0x00114057 File Offset: 0x00112257
		internal ConfiguredAsyncDisposable(IAsyncDisposable source, bool continueOnCapturedContext)
		{
			this._source = source;
			this._continueOnCapturedContext = continueOnCapturedContext;
		}

		// Token: 0x060073C3 RID: 29635 RVA: 0x00114068 File Offset: 0x00112268
		public ConfiguredValueTaskAwaitable DisposeAsync()
		{
			return this._source.DisposeAsync().ConfigureAwait(this._continueOnCapturedContext);
		}

		// Token: 0x0400149F RID: 5279
		private readonly IAsyncDisposable _source;

		// Token: 0x040014A0 RID: 5280
		private readonly bool _continueOnCapturedContext;
	}
}

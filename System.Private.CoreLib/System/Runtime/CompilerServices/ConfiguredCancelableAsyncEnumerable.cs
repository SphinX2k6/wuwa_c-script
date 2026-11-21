using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000686 RID: 1670
	[StructLayout(LayoutKind.Auto)]
	public readonly struct ConfiguredCancelableAsyncEnumerable<[Nullable(2)] T>
	{
		// Token: 0x060073C4 RID: 29636 RVA: 0x0011408E File Offset: 0x0011228E
		internal ConfiguredCancelableAsyncEnumerable(IAsyncEnumerable<T> enumerable, bool continueOnCapturedContext, CancellationToken cancellationToken)
		{
			this._enumerable = enumerable;
			this._continueOnCapturedContext = continueOnCapturedContext;
			this._cancellationToken = cancellationToken;
		}

		// Token: 0x060073C5 RID: 29637 RVA: 0x001140A5 File Offset: 0x001122A5
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ConfiguredCancelableAsyncEnumerable<T> ConfigureAwait(bool continueOnCapturedContext)
		{
			return new ConfiguredCancelableAsyncEnumerable<T>(this._enumerable, continueOnCapturedContext, this._cancellationToken);
		}

		// Token: 0x060073C6 RID: 29638 RVA: 0x001140B9 File Offset: 0x001122B9
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ConfiguredCancelableAsyncEnumerable<T> WithCancellation(CancellationToken cancellationToken)
		{
			return new ConfiguredCancelableAsyncEnumerable<T>(this._enumerable, this._continueOnCapturedContext, cancellationToken);
		}

		// Token: 0x060073C7 RID: 29639 RVA: 0x001140CD File Offset: 0x001122CD
		public ConfiguredCancelableAsyncEnumerable<T>.Enumerator GetAsyncEnumerator()
		{
			return new ConfiguredCancelableAsyncEnumerable<T>.Enumerator(this._enumerable.GetAsyncEnumerator(this._cancellationToken), this._continueOnCapturedContext);
		}

		// Token: 0x040014A1 RID: 5281
		private readonly IAsyncEnumerable<T> _enumerable;

		// Token: 0x040014A2 RID: 5282
		private readonly CancellationToken _cancellationToken;

		// Token: 0x040014A3 RID: 5283
		private readonly bool _continueOnCapturedContext;

		// Token: 0x02000687 RID: 1671
		[StructLayout(LayoutKind.Auto)]
		public readonly struct Enumerator
		{
			// Token: 0x060073C8 RID: 29640 RVA: 0x001140EB File Offset: 0x001122EB
			internal Enumerator(IAsyncEnumerator<T> enumerator, bool continueOnCapturedContext)
			{
				this._enumerator = enumerator;
				this._continueOnCapturedContext = continueOnCapturedContext;
			}

			// Token: 0x060073C9 RID: 29641 RVA: 0x001140FC File Offset: 0x001122FC
			public ConfiguredValueTaskAwaitable<bool> MoveNextAsync()
			{
				return this._enumerator.MoveNextAsync().ConfigureAwait(this._continueOnCapturedContext);
			}

			// Token: 0x17000E33 RID: 3635
			// (get) Token: 0x060073CA RID: 29642 RVA: 0x00114122 File Offset: 0x00112322
			[Nullable(1)]
			public T Current
			{
				[NullableContext(1)]
				get
				{
					return this._enumerator.Current;
				}
			}

			// Token: 0x060073CB RID: 29643 RVA: 0x00114130 File Offset: 0x00112330
			public ConfiguredValueTaskAwaitable DisposeAsync()
			{
				return this._enumerator.DisposeAsync().ConfigureAwait(this._continueOnCapturedContext);
			}

			// Token: 0x040014A4 RID: 5284
			private readonly IAsyncEnumerator<T> _enumerator;

			// Token: 0x040014A5 RID: 5285
			private readonly bool _continueOnCapturedContext;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System.Threading.Tasks
{
	// Token: 0x020004C2 RID: 1218
	[NullableContext(1)]
	[Nullable(0)]
	public static class TaskAsyncEnumerableExtensions
	{
		// Token: 0x0600467D RID: 18045 RVA: 0x000EC0A9 File Offset: 0x000EA2A9
		public static ConfiguredAsyncDisposable ConfigureAwait(this IAsyncDisposable source, bool continueOnCapturedContext)
		{
			return new ConfiguredAsyncDisposable(source, continueOnCapturedContext);
		}

		// Token: 0x0600467E RID: 18046 RVA: 0x000EC0B4 File Offset: 0x000EA2B4
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static ConfiguredCancelableAsyncEnumerable<T> ConfigureAwait<[Nullable(2)] T>(this IAsyncEnumerable<T> source, bool continueOnCapturedContext)
		{
			return new ConfiguredCancelableAsyncEnumerable<T>(source, continueOnCapturedContext, default(CancellationToken));
		}

		// Token: 0x0600467F RID: 18047 RVA: 0x000EC0D1 File Offset: 0x000EA2D1
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static ConfiguredCancelableAsyncEnumerable<T> WithCancellation<[Nullable(2)] T>(this IAsyncEnumerable<T> source, CancellationToken cancellationToken)
		{
			return new ConfiguredCancelableAsyncEnumerable<T>(source, true, cancellationToken);
		}

		// Token: 0x06004680 RID: 18048 RVA: 0x000EC0DB File Offset: 0x000EA2DB
		[UnsupportedOSPlatform("browser")]
		public static IEnumerable<T> ToBlockingEnumerable<[Nullable(2)] T>(this IAsyncEnumerable<T> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			IAsyncEnumerator<T> enumerator = source.GetAsyncEnumerator(cancellationToken);
			TaskAsyncEnumerableExtensions.ManualResetEventWithAwaiterSupport mres = null;
			try
			{
				for (;;)
				{
					ValueTask<bool> valueTask = enumerator.MoveNextAsync();
					if (!valueTask.IsCompleted)
					{
						TaskAsyncEnumerableExtensions.ManualResetEventWithAwaiterSupport manualResetEventWithAwaiterSupport;
						if ((manualResetEventWithAwaiterSupport = mres) == null)
						{
							manualResetEventWithAwaiterSupport = (mres = new TaskAsyncEnumerableExtensions.ManualResetEventWithAwaiterSupport());
						}
						manualResetEventWithAwaiterSupport.Wait<ConfiguredValueTaskAwaitable<bool>.ConfiguredValueTaskAwaiter>(valueTask.ConfigureAwait(false).GetAwaiter());
					}
					if (!valueTask.Result)
					{
						break;
					}
					yield return enumerator.Current;
				}
				yield break;
			}
			finally
			{
				ValueTask valueTask2 = enumerator.DisposeAsync();
				if (!valueTask2.IsCompleted)
				{
					(mres ?? new TaskAsyncEnumerableExtensions.ManualResetEventWithAwaiterSupport()).Wait<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>(valueTask2.ConfigureAwait(false).GetAwaiter());
				}
				valueTask2.GetAwaiter().GetResult();
			}
			yield break;
			yield break;
		}

		// Token: 0x020004C3 RID: 1219
		private sealed class ManualResetEventWithAwaiterSupport : ManualResetEventSlim
		{
			// Token: 0x06004681 RID: 18049 RVA: 0x000EC0F2 File Offset: 0x000EA2F2
			public ManualResetEventWithAwaiterSupport()
			{
				this._onCompleted = new Action(base.Set);
			}

			// Token: 0x06004682 RID: 18050 RVA: 0x000EC10C File Offset: 0x000EA30C
			[UnsupportedOSPlatform("browser")]
			public void Wait<TAwaiter>(TAwaiter awaiter) where TAwaiter : ICriticalNotifyCompletion
			{
				awaiter.UnsafeOnCompleted(this._onCompleted);
				base.Wait();
				base.Reset();
			}

			// Token: 0x04001080 RID: 4224
			private readonly Action _onCompleted;
		}
	}
}

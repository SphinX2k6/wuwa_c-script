using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006D8 RID: 1752
	public readonly struct ConfiguredTaskAwaitable<[Nullable(2)] TResult>
	{
		// Token: 0x060074B5 RID: 29877 RVA: 0x00115E53 File Offset: 0x00114053
		internal ConfiguredTaskAwaitable(Task<TResult> task, ConfigureAwaitOptions options)
		{
			this.m_configuredTaskAwaiter = new ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter(task, options);
		}

		// Token: 0x060074B6 RID: 29878 RVA: 0x00115E62 File Offset: 0x00114062
		public ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter GetAwaiter()
		{
			return this.m_configuredTaskAwaiter;
		}

		// Token: 0x040014FA RID: 5370
		private readonly ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter m_configuredTaskAwaiter;

		// Token: 0x020006D9 RID: 1753
		public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion, IConfiguredTaskAwaiter
		{
			// Token: 0x060074B7 RID: 29879 RVA: 0x00115E6A File Offset: 0x0011406A
			internal ConfiguredTaskAwaiter(Task<TResult> task, ConfigureAwaitOptions options)
			{
				this.m_task = task;
				this.m_options = options;
			}

			// Token: 0x17000E5E RID: 3678
			// (get) Token: 0x060074B8 RID: 29880 RVA: 0x00115E7A File Offset: 0x0011407A
			public bool IsCompleted
			{
				get
				{
					return (this.m_options & ConfigureAwaitOptions.ForceYielding) == ConfigureAwaitOptions.None && this.m_task.IsCompleted;
				}
			}

			// Token: 0x060074B9 RID: 29881 RVA: 0x00115E93 File Offset: 0x00114093
			[NullableContext(1)]
			public void OnCompleted(Action continuation)
			{
				TaskAwaiter.OnCompletedInternal(this.m_task, continuation, (this.m_options & ConfigureAwaitOptions.ContinueOnCapturedContext) > ConfigureAwaitOptions.None, true);
			}

			// Token: 0x060074BA RID: 29882 RVA: 0x00115EAD File Offset: 0x001140AD
			[NullableContext(1)]
			public void UnsafeOnCompleted(Action continuation)
			{
				TaskAwaiter.OnCompletedInternal(this.m_task, continuation, (this.m_options & ConfigureAwaitOptions.ContinueOnCapturedContext) > ConfigureAwaitOptions.None, false);
			}

			// Token: 0x060074BB RID: 29883 RVA: 0x00115EC7 File Offset: 0x001140C7
			[NullableContext(1)]
			[StackTraceHidden]
			public TResult GetResult()
			{
				TaskAwaiter.ValidateEnd(this.m_task, ConfigureAwaitOptions.None);
				return this.m_task.ResultOnSuccess;
			}

			// Token: 0x040014FB RID: 5371
			private readonly Task<TResult> m_task;

			// Token: 0x040014FC RID: 5372
			internal readonly ConfigureAwaitOptions m_options;
		}
	}
}

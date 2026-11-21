using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006D6 RID: 1750
	public readonly struct ConfiguredTaskAwaitable
	{
		// Token: 0x060074AE RID: 29870 RVA: 0x00115DCC File Offset: 0x00113FCC
		internal ConfiguredTaskAwaitable(Task task, ConfigureAwaitOptions options)
		{
			this.m_configuredTaskAwaiter = new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(task, options);
		}

		// Token: 0x060074AF RID: 29871 RVA: 0x00115DDB File Offset: 0x00113FDB
		public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter()
		{
			return this.m_configuredTaskAwaiter;
		}

		// Token: 0x040014F7 RID: 5367
		private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter m_configuredTaskAwaiter;

		// Token: 0x020006D7 RID: 1751
		public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion, IConfiguredTaskAwaiter
		{
			// Token: 0x060074B0 RID: 29872 RVA: 0x00115DE3 File Offset: 0x00113FE3
			internal ConfiguredTaskAwaiter(Task task, ConfigureAwaitOptions options)
			{
				this.m_task = task;
				this.m_options = options;
			}

			// Token: 0x17000E5D RID: 3677
			// (get) Token: 0x060074B1 RID: 29873 RVA: 0x00115DF3 File Offset: 0x00113FF3
			public bool IsCompleted
			{
				get
				{
					return (this.m_options & ConfigureAwaitOptions.ForceYielding) == ConfigureAwaitOptions.None && this.m_task.IsCompleted;
				}
			}

			// Token: 0x060074B2 RID: 29874 RVA: 0x00115E0C File Offset: 0x0011400C
			[NullableContext(1)]
			public void OnCompleted(Action continuation)
			{
				TaskAwaiter.OnCompletedInternal(this.m_task, continuation, (this.m_options & ConfigureAwaitOptions.ContinueOnCapturedContext) > ConfigureAwaitOptions.None, true);
			}

			// Token: 0x060074B3 RID: 29875 RVA: 0x00115E26 File Offset: 0x00114026
			[NullableContext(1)]
			public void UnsafeOnCompleted(Action continuation)
			{
				TaskAwaiter.OnCompletedInternal(this.m_task, continuation, (this.m_options & ConfigureAwaitOptions.ContinueOnCapturedContext) > ConfigureAwaitOptions.None, false);
			}

			// Token: 0x060074B4 RID: 29876 RVA: 0x00115E40 File Offset: 0x00114040
			[StackTraceHidden]
			public void GetResult()
			{
				TaskAwaiter.ValidateEnd(this.m_task, this.m_options);
			}

			// Token: 0x040014F8 RID: 5368
			internal readonly Task m_task;

			// Token: 0x040014F9 RID: 5369
			internal readonly ConfigureAwaitOptions m_options;
		}
	}
}

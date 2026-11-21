using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;

namespace Sharphereal.UniTaskExtensions.Threading.Tasks
{
	// Token: 0x02000008 RID: 8
	public readonly struct YieldAwaitable
	{
		// Token: 0x06000025 RID: 37 RVA: 0x0000257B File Offset: 0x0000077B
		public YieldAwaitable(PlayerLoopTiming timing)
		{
			this.timing = timing;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002584 File Offset: 0x00000784
		public YieldAwaitable.Awaiter GetAwaiter()
		{
			return new YieldAwaitable.Awaiter(this.timing);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002591 File Offset: 0x00000791
		public UniTask ToUniTask()
		{
			return UniTaskEx.Yield(this.timing, CancellationToken.None, false);
		}

		// Token: 0x04000012 RID: 18
		private readonly PlayerLoopTiming timing;

		// Token: 0x0200001B RID: 27
		public readonly struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			// Token: 0x060000A1 RID: 161 RVA: 0x0000462D File Offset: 0x0000282D
			public Awaiter(PlayerLoopTiming timing)
			{
				this.timing = timing;
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x060000A2 RID: 162 RVA: 0x00004636 File Offset: 0x00002836
			public bool IsCompleted
			{
				get
				{
					return false;
				}
			}

			// Token: 0x060000A3 RID: 163 RVA: 0x00004639 File Offset: 0x00002839
			public void GetResult()
			{
			}

			// Token: 0x060000A4 RID: 164 RVA: 0x0000463B File Offset: 0x0000283B
			[NullableContext(1)]
			public void OnCompleted(Action continuation)
			{
				TickHelper.AddContinuation(this.timing, continuation);
			}

			// Token: 0x060000A5 RID: 165 RVA: 0x00004649 File Offset: 0x00002849
			[NullableContext(1)]
			public void UnsafeOnCompleted(Action continuation)
			{
				TickHelper.AddContinuation(this.timing, continuation);
			}

			// Token: 0x0400007E RID: 126
			private readonly PlayerLoopTiming timing;
		}
	}
}

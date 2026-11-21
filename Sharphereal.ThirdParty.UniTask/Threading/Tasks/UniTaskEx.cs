using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks.Sources;
using Cysharp.Threading.Tasks;
using Sharphereal.Core;
using Sharphereal.UniTaskExtensions.Threading.Tasks.Internal;

namespace Sharphereal.UniTaskExtensions.Threading.Tasks
{
	// Token: 0x02000007 RID: 7
	public static class UniTaskEx
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002362 File Offset: 0x00000562
		public static YieldAwaitable Yield()
		{
			return new YieldAwaitable(PlayerLoopTiming.PrePhysics);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000236A File Offset: 0x0000056A
		public static YieldAwaitable Yield(PlayerLoopTiming timing)
		{
			return new YieldAwaitable(timing);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002374 File Offset: 0x00000574
		public static UniTask Yield(CancellationToken cancellationToken, bool cancelImmediately = false)
		{
			short token;
			return new UniTask(UniTaskEx.YieldPromise.Create(PlayerLoopTiming.PrePhysics, cancellationToken, cancelImmediately, out token), token);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002394 File Offset: 0x00000594
		public static UniTask Yield(PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately = false)
		{
			short token;
			return new UniTask(UniTaskEx.YieldPromise.Create(timing, cancellationToken, cancelImmediately, out token), token);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000023B4 File Offset: 0x000005B4
		public static UniTask NextFrame()
		{
			short token;
			return new UniTask(UniTaskEx.NextFramePromise.Create(PlayerLoopTiming.PrePhysics, CancellationToken.None, false, out token), token);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000023D8 File Offset: 0x000005D8
		public static UniTask NextFrame(PlayerLoopTiming timing)
		{
			short token;
			return new UniTask(UniTaskEx.NextFramePromise.Create(timing, CancellationToken.None, false, out token), token);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000023FC File Offset: 0x000005FC
		public static UniTask NextFrame(CancellationToken cancellationToken, bool cancelImmediately = false)
		{
			short token;
			return new UniTask(UniTaskEx.NextFramePromise.Create(PlayerLoopTiming.PrePhysics, cancellationToken, cancelImmediately, out token), token);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000241C File Offset: 0x0000061C
		public static UniTask NextFrame(PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately = false)
		{
			short token;
			return new UniTask(UniTaskEx.NextFramePromise.Create(timing, cancellationToken, cancelImmediately, out token), token);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002439 File Offset: 0x00000639
		public static YieldAwaitable WaitForEndOfFrame()
		{
			return UniTaskEx.Yield(PlayerLoopTiming.PostUpdateWork);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002441 File Offset: 0x00000641
		public static UniTask WaitForEndOfFrame(CancellationToken cancellationToken, bool cancelImmediately = false)
		{
			return UniTaskEx.Yield(PlayerLoopTiming.PostUpdateWork, cancellationToken, cancelImmediately);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000244B File Offset: 0x0000064B
		public static UniTask WaitForSeconds(float duration, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = PlayerLoopTiming.PrePhysics, CancellationToken cancellationToken = default(CancellationToken), bool cancelImmediately = false)
		{
			return UniTaskEx.Delay((int)Math.Round((double)(1000f * duration)), ignoreTimeScale, delayTiming, cancellationToken, cancelImmediately);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002465 File Offset: 0x00000665
		public static UniTask WaitForSeconds(int duration, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = PlayerLoopTiming.PrePhysics, CancellationToken cancellationToken = default(CancellationToken), bool cancelImmediately = false)
		{
			return UniTaskEx.Delay(1000 * duration, ignoreTimeScale, delayTiming, cancellationToken, cancelImmediately);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002478 File Offset: 0x00000678
		public static UniTask DelayFrame(int delayFrameCount, PlayerLoopTiming delayTiming = PlayerLoopTiming.PrePhysics, CancellationToken cancellationToken = default(CancellationToken), bool cancelImmediately = false)
		{
			if (delayFrameCount < 0)
			{
				throw new ArgumentOutOfRangeException("Delay does not allow minus delayFrameCount. delayFrameCount:" + delayFrameCount.ToString());
			}
			short token;
			return new UniTask(UniTaskEx.DelayFramePromise.Create(delayFrameCount, delayTiming, cancellationToken, cancelImmediately, out token), token);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000024B1 File Offset: 0x000006B1
		public static UniTask Delay(int millisecondsDelay, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = PlayerLoopTiming.PrePhysics, CancellationToken cancellationToken = default(CancellationToken), bool cancelImmediately = false)
		{
			return UniTaskEx.Delay(TimeSpan.FromMilliseconds((double)millisecondsDelay), ignoreTimeScale, delayTiming, cancellationToken, cancelImmediately);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000024C4 File Offset: 0x000006C4
		public static UniTask Delay(TimeSpan delayTimeSpan, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = PlayerLoopTiming.PrePhysics, CancellationToken cancellationToken = default(CancellationToken), bool cancelImmediately = false)
		{
			DelayType delayType = ignoreTimeScale ? DelayType.UnscaledDeltaTime : DelayType.DeltaTime;
			return UniTaskEx.Delay(delayTimeSpan, delayType, delayTiming, cancellationToken, cancelImmediately);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000024E4 File Offset: 0x000006E4
		public static UniTask Delay(int millisecondsDelay, DelayType delayType, PlayerLoopTiming delayTiming = PlayerLoopTiming.PrePhysics, CancellationToken cancellationToken = default(CancellationToken), bool cancelImmediately = false)
		{
			return UniTaskEx.Delay(TimeSpan.FromMilliseconds((double)millisecondsDelay), delayType, delayTiming, cancellationToken, cancelImmediately);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000024F8 File Offset: 0x000006F8
		public static UniTask Delay(TimeSpan delayTimeSpan, DelayType delayType, PlayerLoopTiming delayTiming = PlayerLoopTiming.PrePhysics, CancellationToken cancellationToken = default(CancellationToken), bool cancelImmediately = false)
		{
			if (delayTimeSpan < TimeSpan.Zero)
			{
				throw new ArgumentOutOfRangeException("Delay does not allow minus delayTimeSpan. delayTimeSpan:" + delayTimeSpan.ToString());
			}
			switch (delayType)
			{
			case DelayType.UnscaledDeltaTime:
			{
				short token;
				return new UniTask(UniTaskEx.DelayIgnoreTimeScalePromise.Create(delayTimeSpan, delayTiming, cancellationToken, cancelImmediately, out token), token);
			}
			case DelayType.Realtime:
			{
				short token2;
				return new UniTask(UniTaskEx.DelayRealtimePromise.Create(delayTimeSpan, delayTiming, cancellationToken, cancelImmediately, out token2), token2);
			}
			}
			short token3;
			return new UniTask(UniTaskEx.DelayPromise.Create(delayTimeSpan, delayTiming, cancellationToken, cancelImmediately, out token3), token3);
		}

		// Token: 0x02000015 RID: 21
		private sealed class YieldPromise : IUniTaskSource, IValueTaskSource, IPlayerLoopItem, ITaskPoolNode<UniTaskEx.YieldPromise>
		{
			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000065 RID: 101 RVA: 0x000039FE File Offset: 0x00001BFE
			[Nullable(1)]
			public ref UniTaskEx.YieldPromise NextNode
			{
				[NullableContext(1)]
				get
				{
					return ref this.nextNode;
				}
			}

			// Token: 0x06000066 RID: 102 RVA: 0x00003A06 File Offset: 0x00001C06
			static YieldPromise()
			{
				TaskPool.RegisterSizeGetter(typeof(UniTaskEx.YieldPromise), () => UniTaskEx.YieldPromise.pool.Size);
			}

			// Token: 0x06000067 RID: 103 RVA: 0x00003A27 File Offset: 0x00001C27
			private YieldPromise()
			{
			}

			// Token: 0x06000068 RID: 104 RVA: 0x00003A30 File Offset: 0x00001C30
			[NullableContext(1)]
			public static IUniTaskSource Create(PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately, out short token)
			{
				if (cancellationToken.IsCancellationRequested)
				{
					return AutoResetUniTaskCompletionSource.CreateFromCanceled(cancellationToken, out token);
				}
				UniTaskEx.YieldPromise yieldPromise;
				if (!UniTaskEx.YieldPromise.pool.TryPop(out yieldPromise))
				{
					yieldPromise = new UniTaskEx.YieldPromise();
				}
				yieldPromise.cancellationToken = cancellationToken;
				yieldPromise.cancelImmediately = cancelImmediately;
				if (cancelImmediately && cancellationToken.CanBeCanceled)
				{
					yieldPromise.cancellationTokenRegistration = cancellationToken.RegisterWithoutCaptureExecutionContext(delegate(object state)
					{
						UniTaskEx.YieldPromise yieldPromise2 = (UniTaskEx.YieldPromise)state;
						yieldPromise2.core.TrySetCanceled(yieldPromise2.cancellationToken);
					}, yieldPromise);
				}
				TickHelper.AddAction(timing, yieldPromise);
				token = yieldPromise.core.Version;
				return yieldPromise;
			}

			// Token: 0x06000069 RID: 105 RVA: 0x00003AC0 File Offset: 0x00001CC0
			public void GetResult(short token)
			{
				try
				{
					this.core.GetResult(token);
				}
				finally
				{
					if (!this.cancelImmediately || !this.cancellationToken.IsCancellationRequested)
					{
						this.TryReturn();
					}
				}
			}

			// Token: 0x0600006A RID: 106 RVA: 0x00003B0C File Offset: 0x00001D0C
			public UniTaskStatus GetStatus(short token)
			{
				return this.core.GetStatus(token);
			}

			// Token: 0x0600006B RID: 107 RVA: 0x00003B1A File Offset: 0x00001D1A
			public UniTaskStatus UnsafeGetStatus()
			{
				return this.core.UnsafeGetStatus();
			}

			// Token: 0x0600006C RID: 108 RVA: 0x00003B27 File Offset: 0x00001D27
			[NullableContext(1)]
			public void OnCompleted(Action<object> continuation, object state, short token)
			{
				this.core.OnCompleted(continuation, state, token);
			}

			// Token: 0x0600006D RID: 109 RVA: 0x00003B37 File Offset: 0x00001D37
			public bool MoveNext()
			{
				if (this.cancellationToken.IsCancellationRequested)
				{
					this.core.TrySetCanceled(this.cancellationToken);
					return false;
				}
				this.core.TrySetResult(null);
				return false;
			}

			// Token: 0x0600006E RID: 110 RVA: 0x00003B68 File Offset: 0x00001D68
			private bool TryReturn()
			{
				this.core.Reset();
				this.cancellationToken = default(CancellationToken);
				this.cancellationTokenRegistration.Dispose();
				this.cancelImmediately = false;
				return UniTaskEx.YieldPromise.pool.TryPush(this);
			}

			// Token: 0x0400004E RID: 78
			[Nullable(new byte[]
			{
				0,
				1
			})]
			private static TaskPool<UniTaskEx.YieldPromise> pool;

			// Token: 0x0400004F RID: 79
			[Nullable(2)]
			private UniTaskEx.YieldPromise nextNode;

			// Token: 0x04000050 RID: 80
			private CancellationToken cancellationToken;

			// Token: 0x04000051 RID: 81
			private CancellationTokenRegistration cancellationTokenRegistration;

			// Token: 0x04000052 RID: 82
			private bool cancelImmediately;

			// Token: 0x04000053 RID: 83
			[Nullable(new byte[]
			{
				0,
				2
			})]
			private UniTaskCompletionSourceCore<object> core;
		}

		// Token: 0x02000016 RID: 22
		private sealed class NextFramePromise : IUniTaskSource, IValueTaskSource, IPlayerLoopItem, ITaskPoolNode<UniTaskEx.NextFramePromise>
		{
			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600006F RID: 111 RVA: 0x00003B9E File Offset: 0x00001D9E
			[Nullable(1)]
			public ref UniTaskEx.NextFramePromise NextNode
			{
				[NullableContext(1)]
				get
				{
					return ref this.nextNode;
				}
			}

			// Token: 0x06000070 RID: 112 RVA: 0x00003BA6 File Offset: 0x00001DA6
			static NextFramePromise()
			{
				TaskPool.RegisterSizeGetter(typeof(UniTaskEx.NextFramePromise), () => UniTaskEx.NextFramePromise.pool.Size);
			}

			// Token: 0x06000071 RID: 113 RVA: 0x00003BC7 File Offset: 0x00001DC7
			private NextFramePromise()
			{
			}

			// Token: 0x06000072 RID: 114 RVA: 0x00003BD0 File Offset: 0x00001DD0
			[NullableContext(1)]
			public static IUniTaskSource Create(PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately, out short token)
			{
				if (cancellationToken.IsCancellationRequested)
				{
					return AutoResetUniTaskCompletionSource.CreateFromCanceled(cancellationToken, out token);
				}
				UniTaskEx.NextFramePromise nextFramePromise;
				if (!UniTaskEx.NextFramePromise.pool.TryPop(out nextFramePromise))
				{
					nextFramePromise = new UniTaskEx.NextFramePromise();
				}
				nextFramePromise.frameCount = (TickHelper.IsMainThread ? Time.frameCount : -1);
				nextFramePromise.cancellationToken = cancellationToken;
				nextFramePromise.cancelImmediately = cancelImmediately;
				if (cancelImmediately && cancellationToken.CanBeCanceled)
				{
					nextFramePromise.cancellationTokenRegistration = cancellationToken.RegisterWithoutCaptureExecutionContext(delegate(object state)
					{
						UniTaskEx.NextFramePromise nextFramePromise2 = (UniTaskEx.NextFramePromise)state;
						nextFramePromise2.core.TrySetCanceled(nextFramePromise2.cancellationToken);
					}, nextFramePromise);
				}
				TickHelper.AddAction(timing, nextFramePromise);
				token = nextFramePromise.core.Version;
				return nextFramePromise;
			}

			// Token: 0x06000073 RID: 115 RVA: 0x00003C74 File Offset: 0x00001E74
			public void GetResult(short token)
			{
				try
				{
					this.core.GetResult(token);
				}
				finally
				{
					if (!this.cancelImmediately || !this.cancellationToken.IsCancellationRequested)
					{
						this.TryReturn();
					}
				}
			}

			// Token: 0x06000074 RID: 116 RVA: 0x00003CC0 File Offset: 0x00001EC0
			public UniTaskStatus GetStatus(short token)
			{
				return this.core.GetStatus(token);
			}

			// Token: 0x06000075 RID: 117 RVA: 0x00003CCE File Offset: 0x00001ECE
			public UniTaskStatus UnsafeGetStatus()
			{
				return this.core.UnsafeGetStatus();
			}

			// Token: 0x06000076 RID: 118 RVA: 0x00003CDB File Offset: 0x00001EDB
			[NullableContext(1)]
			public void OnCompleted(Action<object> continuation, object state, short token)
			{
				this.core.OnCompleted(continuation, state, token);
			}

			// Token: 0x06000077 RID: 119 RVA: 0x00003CEC File Offset: 0x00001EEC
			public bool MoveNext()
			{
				if (this.cancellationToken.IsCancellationRequested)
				{
					this.core.TrySetCanceled(this.cancellationToken);
					return false;
				}
				if (this.frameCount == Time.frameCount)
				{
					return true;
				}
				this.core.TrySetResult(AsyncUnit.Default);
				return false;
			}

			// Token: 0x06000078 RID: 120 RVA: 0x00003D3B File Offset: 0x00001F3B
			private bool TryReturn()
			{
				this.core.Reset();
				this.cancellationToken = default(CancellationToken);
				this.cancellationTokenRegistration.Dispose();
				return UniTaskEx.NextFramePromise.pool.TryPush(this);
			}

			// Token: 0x04000054 RID: 84
			[Nullable(new byte[]
			{
				0,
				1
			})]
			private static TaskPool<UniTaskEx.NextFramePromise> pool;

			// Token: 0x04000055 RID: 85
			[Nullable(2)]
			private UniTaskEx.NextFramePromise nextNode;

			// Token: 0x04000056 RID: 86
			private int frameCount;

			// Token: 0x04000057 RID: 87
			private UniTaskCompletionSourceCore<AsyncUnit> core;

			// Token: 0x04000058 RID: 88
			private CancellationToken cancellationToken;

			// Token: 0x04000059 RID: 89
			private CancellationTokenRegistration cancellationTokenRegistration;

			// Token: 0x0400005A RID: 90
			private bool cancelImmediately;
		}

		// Token: 0x02000017 RID: 23
		private sealed class DelayFramePromise : IUniTaskSource, IValueTaskSource, IPlayerLoopItem, ITaskPoolNode<UniTaskEx.DelayFramePromise>
		{
			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000079 RID: 121 RVA: 0x00003D6A File Offset: 0x00001F6A
			[Nullable(1)]
			public ref UniTaskEx.DelayFramePromise NextNode
			{
				[NullableContext(1)]
				get
				{
					return ref this.nextNode;
				}
			}

			// Token: 0x0600007A RID: 122 RVA: 0x00003D72 File Offset: 0x00001F72
			static DelayFramePromise()
			{
				TaskPool.RegisterSizeGetter(typeof(UniTaskEx.DelayFramePromise), () => UniTaskEx.DelayFramePromise.pool.Size);
			}

			// Token: 0x0600007B RID: 123 RVA: 0x00003D93 File Offset: 0x00001F93
			private DelayFramePromise()
			{
			}

			// Token: 0x0600007C RID: 124 RVA: 0x00003D9C File Offset: 0x00001F9C
			[NullableContext(1)]
			public static IUniTaskSource Create(int delayFrameCount, PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately, out short token)
			{
				if (cancellationToken.IsCancellationRequested)
				{
					return AutoResetUniTaskCompletionSource.CreateFromCanceled(cancellationToken, out token);
				}
				UniTaskEx.DelayFramePromise delayFramePromise;
				if (!UniTaskEx.DelayFramePromise.pool.TryPop(out delayFramePromise))
				{
					delayFramePromise = new UniTaskEx.DelayFramePromise();
				}
				delayFramePromise.delayFrameCount = delayFrameCount;
				delayFramePromise.cancellationToken = cancellationToken;
				delayFramePromise.initialFrame = (TickHelper.IsMainThread ? Time.frameCount : -1);
				delayFramePromise.cancelImmediately = cancelImmediately;
				if (cancelImmediately && cancellationToken.CanBeCanceled)
				{
					delayFramePromise.cancellationTokenRegistration = cancellationToken.RegisterWithoutCaptureExecutionContext(delegate(object state)
					{
						UniTaskEx.DelayFramePromise delayFramePromise2 = (UniTaskEx.DelayFramePromise)state;
						delayFramePromise2.core.TrySetCanceled(delayFramePromise2.cancellationToken);
					}, delayFramePromise);
				}
				TickHelper.AddAction(timing, delayFramePromise);
				token = delayFramePromise.core.Version;
				return delayFramePromise;
			}

			// Token: 0x0600007D RID: 125 RVA: 0x00003E48 File Offset: 0x00002048
			public void GetResult(short token)
			{
				try
				{
					this.core.GetResult(token);
				}
				finally
				{
					if (!this.cancelImmediately || !this.cancellationToken.IsCancellationRequested)
					{
						this.TryReturn();
					}
				}
			}

			// Token: 0x0600007E RID: 126 RVA: 0x00003E94 File Offset: 0x00002094
			public UniTaskStatus GetStatus(short token)
			{
				return this.core.GetStatus(token);
			}

			// Token: 0x0600007F RID: 127 RVA: 0x00003EA2 File Offset: 0x000020A2
			public UniTaskStatus UnsafeGetStatus()
			{
				return this.core.UnsafeGetStatus();
			}

			// Token: 0x06000080 RID: 128 RVA: 0x00003EAF File Offset: 0x000020AF
			[NullableContext(1)]
			public void OnCompleted(Action<object> continuation, object state, short token)
			{
				this.core.OnCompleted(continuation, state, token);
			}

			// Token: 0x06000081 RID: 129 RVA: 0x00003EC0 File Offset: 0x000020C0
			public bool MoveNext()
			{
				if (this.cancellationToken.IsCancellationRequested)
				{
					this.core.TrySetCanceled(this.cancellationToken);
					return false;
				}
				if (this.currentFrameCount == 0)
				{
					if (this.delayFrameCount == 0)
					{
						this.core.TrySetResult(AsyncUnit.Default);
						return false;
					}
					if (this.initialFrame == Time.frameCount)
					{
						return true;
					}
				}
				int num = this.currentFrameCount + 1;
				this.currentFrameCount = num;
				if (num >= this.delayFrameCount)
				{
					this.core.TrySetResult(AsyncUnit.Default);
					return false;
				}
				return true;
			}

			// Token: 0x06000082 RID: 130 RVA: 0x00003F50 File Offset: 0x00002150
			private bool TryReturn()
			{
				this.core.Reset();
				this.currentFrameCount = 0;
				this.delayFrameCount = 0;
				this.cancellationToken = default(CancellationToken);
				this.cancellationTokenRegistration.Dispose();
				this.cancelImmediately = false;
				return UniTaskEx.DelayFramePromise.pool.TryPush(this);
			}

			// Token: 0x0400005B RID: 91
			[Nullable(new byte[]
			{
				0,
				1
			})]
			private static TaskPool<UniTaskEx.DelayFramePromise> pool;

			// Token: 0x0400005C RID: 92
			[Nullable(2)]
			private UniTaskEx.DelayFramePromise nextNode;

			// Token: 0x0400005D RID: 93
			private int initialFrame;

			// Token: 0x0400005E RID: 94
			private int delayFrameCount;

			// Token: 0x0400005F RID: 95
			private CancellationToken cancellationToken;

			// Token: 0x04000060 RID: 96
			private CancellationTokenRegistration cancellationTokenRegistration;

			// Token: 0x04000061 RID: 97
			private bool cancelImmediately;

			// Token: 0x04000062 RID: 98
			private int currentFrameCount;

			// Token: 0x04000063 RID: 99
			private UniTaskCompletionSourceCore<AsyncUnit> core;
		}

		// Token: 0x02000018 RID: 24
		private sealed class DelayPromise : IUniTaskSource, IValueTaskSource, IPlayerLoopItem, ITaskPoolNode<UniTaskEx.DelayPromise>
		{
			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000083 RID: 131 RVA: 0x00003F9F File Offset: 0x0000219F
			[Nullable(1)]
			public ref UniTaskEx.DelayPromise NextNode
			{
				[NullableContext(1)]
				get
				{
					return ref this.nextNode;
				}
			}

			// Token: 0x06000084 RID: 132 RVA: 0x00003FA7 File Offset: 0x000021A7
			static DelayPromise()
			{
				TaskPool.RegisterSizeGetter(typeof(UniTaskEx.DelayPromise), () => UniTaskEx.DelayPromise.pool.Size);
			}

			// Token: 0x06000085 RID: 133 RVA: 0x00003FC8 File Offset: 0x000021C8
			private DelayPromise()
			{
			}

			// Token: 0x06000086 RID: 134 RVA: 0x00003FD0 File Offset: 0x000021D0
			[NullableContext(1)]
			public static IUniTaskSource Create(TimeSpan delayTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately, out short token)
			{
				if (cancellationToken.IsCancellationRequested)
				{
					return AutoResetUniTaskCompletionSource.CreateFromCanceled(cancellationToken, out token);
				}
				UniTaskEx.DelayPromise delayPromise;
				if (!UniTaskEx.DelayPromise.pool.TryPop(out delayPromise))
				{
					delayPromise = new UniTaskEx.DelayPromise();
				}
				delayPromise.elapsed = 0f;
				delayPromise.delayTimeSpan = (float)delayTimeSpan.TotalSeconds;
				delayPromise.cancellationToken = cancellationToken;
				delayPromise.initialFrame = (TickHelper.IsMainThread ? Time.frameCount : -1);
				delayPromise.cancelImmediately = cancelImmediately;
				if (cancelImmediately && cancellationToken.CanBeCanceled)
				{
					delayPromise.cancellationTokenRegistration = cancellationToken.RegisterWithoutCaptureExecutionContext(delegate(object state)
					{
						UniTaskEx.DelayPromise delayPromise2 = (UniTaskEx.DelayPromise)state;
						delayPromise2.core.TrySetCanceled(delayPromise2.cancellationToken);
					}, delayPromise);
				}
				TickHelper.AddAction(timing, delayPromise);
				token = delayPromise.core.Version;
				return delayPromise;
			}

			// Token: 0x06000087 RID: 135 RVA: 0x00004090 File Offset: 0x00002290
			public void GetResult(short token)
			{
				try
				{
					this.core.GetResult(token);
				}
				finally
				{
					if (!this.cancelImmediately || !this.cancellationToken.IsCancellationRequested)
					{
						this.TryReturn();
					}
				}
			}

			// Token: 0x06000088 RID: 136 RVA: 0x000040DC File Offset: 0x000022DC
			public UniTaskStatus GetStatus(short token)
			{
				return this.core.GetStatus(token);
			}

			// Token: 0x06000089 RID: 137 RVA: 0x000040EA File Offset: 0x000022EA
			public UniTaskStatus UnsafeGetStatus()
			{
				return this.core.UnsafeGetStatus();
			}

			// Token: 0x0600008A RID: 138 RVA: 0x000040F7 File Offset: 0x000022F7
			[NullableContext(1)]
			public void OnCompleted(Action<object> continuation, object state, short token)
			{
				this.core.OnCompleted(continuation, state, token);
			}

			// Token: 0x0600008B RID: 139 RVA: 0x00004108 File Offset: 0x00002308
			public bool MoveNext()
			{
				if (this.cancellationToken.IsCancellationRequested)
				{
					this.core.TrySetCanceled(this.cancellationToken);
					return false;
				}
				if (this.elapsed == 0f && this.initialFrame == Time.frameCount)
				{
					return true;
				}
				this.elapsed += Time.deltaTime;
				if (this.elapsed >= this.delayTimeSpan)
				{
					this.core.TrySetResult(null);
					return false;
				}
				return true;
			}

			// Token: 0x0600008C RID: 140 RVA: 0x00004184 File Offset: 0x00002384
			private bool TryReturn()
			{
				this.core.Reset();
				this.delayTimeSpan = 0f;
				this.elapsed = 0f;
				this.cancellationToken = default(CancellationToken);
				this.cancellationTokenRegistration.Dispose();
				this.cancelImmediately = false;
				return UniTaskEx.DelayPromise.pool.TryPush(this);
			}

			// Token: 0x04000064 RID: 100
			[Nullable(new byte[]
			{
				0,
				1
			})]
			private static TaskPool<UniTaskEx.DelayPromise> pool;

			// Token: 0x04000065 RID: 101
			[Nullable(2)]
			private UniTaskEx.DelayPromise nextNode;

			// Token: 0x04000066 RID: 102
			private int initialFrame;

			// Token: 0x04000067 RID: 103
			private float delayTimeSpan;

			// Token: 0x04000068 RID: 104
			private float elapsed;

			// Token: 0x04000069 RID: 105
			private CancellationToken cancellationToken;

			// Token: 0x0400006A RID: 106
			private CancellationTokenRegistration cancellationTokenRegistration;

			// Token: 0x0400006B RID: 107
			private bool cancelImmediately;

			// Token: 0x0400006C RID: 108
			[Nullable(new byte[]
			{
				0,
				2
			})]
			private UniTaskCompletionSourceCore<object> core;
		}

		// Token: 0x02000019 RID: 25
		private sealed class DelayIgnoreTimeScalePromise : IUniTaskSource, IValueTaskSource, IPlayerLoopItem, ITaskPoolNode<UniTaskEx.DelayIgnoreTimeScalePromise>
		{
			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600008D RID: 141 RVA: 0x000041DB File Offset: 0x000023DB
			[Nullable(1)]
			public ref UniTaskEx.DelayIgnoreTimeScalePromise NextNode
			{
				[NullableContext(1)]
				get
				{
					return ref this.nextNode;
				}
			}

			// Token: 0x0600008E RID: 142 RVA: 0x000041E3 File Offset: 0x000023E3
			static DelayIgnoreTimeScalePromise()
			{
				TaskPool.RegisterSizeGetter(typeof(UniTaskEx.DelayIgnoreTimeScalePromise), () => UniTaskEx.DelayIgnoreTimeScalePromise.pool.Size);
			}

			// Token: 0x0600008F RID: 143 RVA: 0x00004204 File Offset: 0x00002404
			private DelayIgnoreTimeScalePromise()
			{
			}

			// Token: 0x06000090 RID: 144 RVA: 0x0000420C File Offset: 0x0000240C
			[NullableContext(1)]
			public static IUniTaskSource Create(TimeSpan delayFrameTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately, out short token)
			{
				if (cancellationToken.IsCancellationRequested)
				{
					return AutoResetUniTaskCompletionSource.CreateFromCanceled(cancellationToken, out token);
				}
				UniTaskEx.DelayIgnoreTimeScalePromise delayIgnoreTimeScalePromise;
				if (!UniTaskEx.DelayIgnoreTimeScalePromise.pool.TryPop(out delayIgnoreTimeScalePromise))
				{
					delayIgnoreTimeScalePromise = new UniTaskEx.DelayIgnoreTimeScalePromise();
				}
				delayIgnoreTimeScalePromise.elapsed = 0f;
				delayIgnoreTimeScalePromise.delayFrameTimeSpan = (float)delayFrameTimeSpan.TotalSeconds;
				delayIgnoreTimeScalePromise.initialFrame = (TickHelper.IsMainThread ? Time.frameCount : -1);
				delayIgnoreTimeScalePromise.cancellationToken = cancellationToken;
				delayIgnoreTimeScalePromise.cancelImmediately = cancelImmediately;
				if (cancelImmediately && cancellationToken.CanBeCanceled)
				{
					delayIgnoreTimeScalePromise.cancellationTokenRegistration = cancellationToken.RegisterWithoutCaptureExecutionContext(delegate(object state)
					{
						UniTaskEx.DelayIgnoreTimeScalePromise delayIgnoreTimeScalePromise2 = (UniTaskEx.DelayIgnoreTimeScalePromise)state;
						delayIgnoreTimeScalePromise2.core.TrySetCanceled(delayIgnoreTimeScalePromise2.cancellationToken);
					}, delayIgnoreTimeScalePromise);
				}
				TickHelper.AddAction(timing, delayIgnoreTimeScalePromise);
				token = delayIgnoreTimeScalePromise.core.Version;
				return delayIgnoreTimeScalePromise;
			}

			// Token: 0x06000091 RID: 145 RVA: 0x000042CC File Offset: 0x000024CC
			public void GetResult(short token)
			{
				try
				{
					this.core.GetResult(token);
				}
				finally
				{
					if (!this.cancelImmediately || !this.cancellationToken.IsCancellationRequested)
					{
						this.TryReturn();
					}
				}
			}

			// Token: 0x06000092 RID: 146 RVA: 0x00004318 File Offset: 0x00002518
			public UniTaskStatus GetStatus(short token)
			{
				return this.core.GetStatus(token);
			}

			// Token: 0x06000093 RID: 147 RVA: 0x00004326 File Offset: 0x00002526
			public UniTaskStatus UnsafeGetStatus()
			{
				return this.core.UnsafeGetStatus();
			}

			// Token: 0x06000094 RID: 148 RVA: 0x00004333 File Offset: 0x00002533
			[NullableContext(1)]
			public void OnCompleted(Action<object> continuation, object state, short token)
			{
				this.core.OnCompleted(continuation, state, token);
			}

			// Token: 0x06000095 RID: 149 RVA: 0x00004344 File Offset: 0x00002544
			public bool MoveNext()
			{
				if (this.cancellationToken.IsCancellationRequested)
				{
					this.core.TrySetCanceled(this.cancellationToken);
					return false;
				}
				if (this.elapsed == 0f && this.initialFrame == Time.frameCount)
				{
					return true;
				}
				this.elapsed += Time.unscaledDeltaTime;
				if (this.elapsed >= this.delayFrameTimeSpan)
				{
					this.core.TrySetResult(null);
					return false;
				}
				return true;
			}

			// Token: 0x06000096 RID: 150 RVA: 0x000043C0 File Offset: 0x000025C0
			private bool TryReturn()
			{
				this.core.Reset();
				this.delayFrameTimeSpan = 0f;
				this.elapsed = 0f;
				this.cancellationToken = default(CancellationToken);
				this.cancellationTokenRegistration.Dispose();
				this.cancelImmediately = false;
				return UniTaskEx.DelayIgnoreTimeScalePromise.pool.TryPush(this);
			}

			// Token: 0x0400006D RID: 109
			[Nullable(new byte[]
			{
				0,
				1
			})]
			private static TaskPool<UniTaskEx.DelayIgnoreTimeScalePromise> pool;

			// Token: 0x0400006E RID: 110
			[Nullable(2)]
			private UniTaskEx.DelayIgnoreTimeScalePromise nextNode;

			// Token: 0x0400006F RID: 111
			private float delayFrameTimeSpan;

			// Token: 0x04000070 RID: 112
			private float elapsed;

			// Token: 0x04000071 RID: 113
			private int initialFrame;

			// Token: 0x04000072 RID: 114
			private CancellationToken cancellationToken;

			// Token: 0x04000073 RID: 115
			private CancellationTokenRegistration cancellationTokenRegistration;

			// Token: 0x04000074 RID: 116
			private bool cancelImmediately;

			// Token: 0x04000075 RID: 117
			[Nullable(new byte[]
			{
				0,
				2
			})]
			private UniTaskCompletionSourceCore<object> core;
		}

		// Token: 0x0200001A RID: 26
		private sealed class DelayRealtimePromise : IUniTaskSource, IValueTaskSource, IPlayerLoopItem, ITaskPoolNode<UniTaskEx.DelayRealtimePromise>
		{
			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000097 RID: 151 RVA: 0x00004417 File Offset: 0x00002617
			[Nullable(1)]
			public ref UniTaskEx.DelayRealtimePromise NextNode
			{
				[NullableContext(1)]
				get
				{
					return ref this.nextNode;
				}
			}

			// Token: 0x06000098 RID: 152 RVA: 0x0000441F File Offset: 0x0000261F
			static DelayRealtimePromise()
			{
				TaskPool.RegisterSizeGetter(typeof(UniTaskEx.DelayRealtimePromise), () => UniTaskEx.DelayRealtimePromise.pool.Size);
			}

			// Token: 0x06000099 RID: 153 RVA: 0x00004440 File Offset: 0x00002640
			private DelayRealtimePromise()
			{
			}

			// Token: 0x0600009A RID: 154 RVA: 0x00004448 File Offset: 0x00002648
			[NullableContext(1)]
			public static IUniTaskSource Create(TimeSpan delayTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken, bool cancelImmediately, out short token)
			{
				if (cancellationToken.IsCancellationRequested)
				{
					return AutoResetUniTaskCompletionSource.CreateFromCanceled(cancellationToken, out token);
				}
				UniTaskEx.DelayRealtimePromise delayRealtimePromise;
				if (!UniTaskEx.DelayRealtimePromise.pool.TryPop(out delayRealtimePromise))
				{
					delayRealtimePromise = new UniTaskEx.DelayRealtimePromise();
				}
				delayRealtimePromise.stopwatch = ValueStopwatch.StartNew();
				delayRealtimePromise.delayTimeSpanTicks = delayTimeSpan.Ticks;
				delayRealtimePromise.cancellationToken = cancellationToken;
				delayRealtimePromise.cancelImmediately = cancelImmediately;
				if (cancelImmediately && cancellationToken.CanBeCanceled)
				{
					delayRealtimePromise.cancellationTokenRegistration = cancellationToken.RegisterWithoutCaptureExecutionContext(delegate(object state)
					{
						UniTaskEx.DelayRealtimePromise delayRealtimePromise2 = (UniTaskEx.DelayRealtimePromise)state;
						delayRealtimePromise2.core.TrySetCanceled(delayRealtimePromise2.cancellationToken);
					}, delayRealtimePromise);
				}
				TickHelper.AddAction(timing, delayRealtimePromise);
				token = delayRealtimePromise.core.Version;
				return delayRealtimePromise;
			}

			// Token: 0x0600009B RID: 155 RVA: 0x000044F0 File Offset: 0x000026F0
			public void GetResult(short token)
			{
				try
				{
					this.core.GetResult(token);
				}
				finally
				{
					if (!this.cancelImmediately || !this.cancellationToken.IsCancellationRequested)
					{
						this.TryReturn();
					}
				}
			}

			// Token: 0x0600009C RID: 156 RVA: 0x0000453C File Offset: 0x0000273C
			public UniTaskStatus GetStatus(short token)
			{
				return this.core.GetStatus(token);
			}

			// Token: 0x0600009D RID: 157 RVA: 0x0000454A File Offset: 0x0000274A
			public UniTaskStatus UnsafeGetStatus()
			{
				return this.core.UnsafeGetStatus();
			}

			// Token: 0x0600009E RID: 158 RVA: 0x00004557 File Offset: 0x00002757
			[NullableContext(1)]
			public void OnCompleted(Action<object> continuation, object state, short token)
			{
				this.core.OnCompleted(continuation, state, token);
			}

			// Token: 0x0600009F RID: 159 RVA: 0x00004568 File Offset: 0x00002768
			public bool MoveNext()
			{
				if (this.cancellationToken.IsCancellationRequested)
				{
					this.core.TrySetCanceled(this.cancellationToken);
					return false;
				}
				if (this.stopwatch.IsInvalid)
				{
					this.core.TrySetResult(AsyncUnit.Default);
					return false;
				}
				if (this.stopwatch.ElapsedTicks >= this.delayTimeSpanTicks)
				{
					this.core.TrySetResult(AsyncUnit.Default);
					return false;
				}
				return true;
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x000045E0 File Offset: 0x000027E0
			private bool TryReturn()
			{
				this.core.Reset();
				this.stopwatch = default(ValueStopwatch);
				this.cancellationToken = default(CancellationToken);
				this.cancellationTokenRegistration.Dispose();
				this.cancelImmediately = false;
				return UniTaskEx.DelayRealtimePromise.pool.TryPush(this);
			}

			// Token: 0x04000076 RID: 118
			[Nullable(new byte[]
			{
				0,
				1
			})]
			private static TaskPool<UniTaskEx.DelayRealtimePromise> pool;

			// Token: 0x04000077 RID: 119
			[Nullable(1)]
			private UniTaskEx.DelayRealtimePromise nextNode;

			// Token: 0x04000078 RID: 120
			private long delayTimeSpanTicks;

			// Token: 0x04000079 RID: 121
			private ValueStopwatch stopwatch;

			// Token: 0x0400007A RID: 122
			private CancellationToken cancellationToken;

			// Token: 0x0400007B RID: 123
			private CancellationTokenRegistration cancellationTokenRegistration;

			// Token: 0x0400007C RID: 124
			private bool cancelImmediately;

			// Token: 0x0400007D RID: 125
			private UniTaskCompletionSourceCore<AsyncUnit> core;
		}
	}
}

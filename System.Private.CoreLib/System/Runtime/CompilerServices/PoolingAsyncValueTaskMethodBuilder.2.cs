using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using Internal;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006BC RID: 1724
	[NullableContext(1)]
	[Nullable(0)]
	[StructLayout(LayoutKind.Auto)]
	public struct PoolingAsyncValueTaskMethodBuilder<[Nullable(2)] TResult>
	{
		// Token: 0x0600744F RID: 29775 RVA: 0x00115320 File Offset: 0x00113520
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static PoolingAsyncValueTaskMethodBuilder<TResult> Create()
		{
			return default(PoolingAsyncValueTaskMethodBuilder<TResult>);
		}

		// Token: 0x06007450 RID: 29776 RVA: 0x00112656 File Offset: 0x00110856
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Start<[Nullable(0)] TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			AsyncMethodBuilderCore.Start<TStateMachine>(ref stateMachine);
		}

		// Token: 0x06007451 RID: 29777 RVA: 0x0011292E File Offset: 0x00110B2E
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			AsyncMethodBuilderCore.SetStateMachine(stateMachine, null);
		}

		// Token: 0x06007452 RID: 29778 RVA: 0x00115336 File Offset: 0x00113536
		public void SetResult(TResult result)
		{
			if (this.m_task == null)
			{
				this._result = result;
				this.m_task = PoolingAsyncValueTaskMethodBuilder<TResult>.s_syncSuccessSentinel;
				return;
			}
			this.m_task.SetResult(result);
		}

		// Token: 0x06007453 RID: 29779 RVA: 0x0011535F File Offset: 0x0011355F
		public void SetException(Exception exception)
		{
			PoolingAsyncValueTaskMethodBuilder<TResult>.SetException(exception, ref this.m_task);
		}

		// Token: 0x06007454 RID: 29780 RVA: 0x00115370 File Offset: 0x00113570
		internal static void SetException(Exception exception, [NotNull] ref PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox boxFieldRef)
		{
			if (exception == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.exception);
			}
			PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox stateMachineBox;
			if ((stateMachineBox = boxFieldRef) == null)
			{
				PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox stateMachineBox2;
				boxFieldRef = (stateMachineBox2 = PoolingAsyncValueTaskMethodBuilder<TResult>.CreateWeaklyTypedStateMachineBox());
				stateMachineBox = stateMachineBox2;
			}
			stateMachineBox.SetException(exception);
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06007455 RID: 29781 RVA: 0x001153A0 File Offset: 0x001135A0
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public ValueTask<TResult> Task
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				if (this.m_task == PoolingAsyncValueTaskMethodBuilder<TResult>.s_syncSuccessSentinel)
				{
					return new ValueTask<TResult>(this._result);
				}
				PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox stateMachineBox;
				if ((stateMachineBox = this.m_task) == null)
				{
					stateMachineBox = (this.m_task = PoolingAsyncValueTaskMethodBuilder<TResult>.CreateWeaklyTypedStateMachineBox());
				}
				PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox stateMachineBox2 = stateMachineBox;
				return new ValueTask<TResult>(stateMachineBox2, stateMachineBox2.Version);
			}
		}

		// Token: 0x06007456 RID: 29782 RVA: 0x001153EB File Offset: 0x001135EB
		public void AwaitOnCompleted<[Nullable(0)] TAwaiter, [Nullable(0)] TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			PoolingAsyncValueTaskMethodBuilder<TResult>.AwaitOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine, ref this.m_task);
		}

		// Token: 0x06007457 RID: 29783 RVA: 0x001153FC File Offset: 0x001135FC
		internal static void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine, ref PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox box) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			try
			{
				ref TAwaiter ptr = ref awaiter;
				if (default(TAwaiter) == null)
				{
					TAwaiter tawaiter = awaiter;
					ptr = ref tawaiter;
				}
				ptr.OnCompleted(PoolingAsyncValueTaskMethodBuilder<TResult>.GetStateMachineBox<TStateMachine>(ref stateMachine, ref box).MoveNextAction);
			}
			catch (Exception exception)
			{
				System.Threading.Tasks.Task.ThrowAsync(exception, null);
			}
		}

		// Token: 0x06007458 RID: 29784 RVA: 0x00115454 File Offset: 0x00113654
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void AwaitUnsafeOnCompleted<[Nullable(0)] TAwaiter, [Nullable(0)] TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			PoolingAsyncValueTaskMethodBuilder<TResult>.AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine, ref this.m_task);
		}

		// Token: 0x06007459 RID: 29785 RVA: 0x00115464 File Offset: 0x00113664
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine, [NotNull] ref PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox boxRef) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			IAsyncStateMachineBox stateMachineBox = PoolingAsyncValueTaskMethodBuilder<TResult>.GetStateMachineBox<TStateMachine>(ref stateMachine, ref boxRef);
			AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TAwaiter>(ref awaiter, stateMachineBox);
		}

		// Token: 0x0600745A RID: 29786 RVA: 0x00115480 File Offset: 0x00113680
		private static IAsyncStateMachineBox GetStateMachineBox<TStateMachine>(ref TStateMachine stateMachine, [NotNull] ref PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox boxFieldRef) where TStateMachine : IAsyncStateMachine
		{
			ExecutionContext executionContext = ExecutionContext.Capture();
			PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine> stateMachineBox = boxFieldRef as PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine>;
			if (stateMachineBox != null)
			{
				if (stateMachineBox.Context != executionContext)
				{
					stateMachineBox.Context = executionContext;
				}
				return stateMachineBox;
			}
			PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<IAsyncStateMachine> stateMachineBox2 = boxFieldRef as PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<IAsyncStateMachine>;
			if (stateMachineBox2 != null)
			{
				if (stateMachineBox2.StateMachine == null)
				{
					Debugger.NotifyOfCrossThreadDependency();
					stateMachineBox2.StateMachine = stateMachine;
				}
				stateMachineBox2.Context = executionContext;
				return stateMachineBox2;
			}
			Debugger.NotifyOfCrossThreadDependency();
			PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine> stateMachineBox3 = PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine>.RentFromCache();
			boxFieldRef = stateMachineBox3;
			stateMachineBox3.StateMachine = stateMachine;
			stateMachineBox3.Context = executionContext;
			return stateMachineBox3;
		}

		// Token: 0x0600745B RID: 29787 RVA: 0x00115504 File Offset: 0x00113704
		internal static PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox CreateWeaklyTypedStateMachineBox()
		{
			return new PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<IAsyncStateMachine>();
		}

		// Token: 0x040014D9 RID: 5337
		internal static readonly PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox s_syncSuccessSentinel = new PoolingAsyncValueTaskMethodBuilder<TResult>.SyncSuccessSentinelStateMachineBox();

		// Token: 0x040014DA RID: 5338
		private PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox m_task;

		// Token: 0x040014DB RID: 5339
		private TResult _result;

		// Token: 0x020006BD RID: 1725
		internal abstract class StateMachineBox : IValueTaskSource<TResult>, IValueTaskSource
		{
			// Token: 0x0600745D RID: 29789 RVA: 0x00115517 File Offset: 0x00113717
			public void SetResult(TResult result)
			{
				this._valueTaskSource.SetResult(result);
			}

			// Token: 0x0600745E RID: 29790 RVA: 0x00115525 File Offset: 0x00113725
			public void SetException(Exception error)
			{
				this._valueTaskSource.SetException(error);
			}

			// Token: 0x0600745F RID: 29791 RVA: 0x00115533 File Offset: 0x00113733
			public ValueTaskSourceStatus GetStatus(short token)
			{
				return this._valueTaskSource.GetStatus(token);
			}

			// Token: 0x06007460 RID: 29792 RVA: 0x00115541 File Offset: 0x00113741
			public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
			{
				this._valueTaskSource.OnCompleted(continuation, state, token, flags);
			}

			// Token: 0x17000E4D RID: 3661
			// (get) Token: 0x06007461 RID: 29793 RVA: 0x00115553 File Offset: 0x00113753
			public short Version
			{
				get
				{
					return this._valueTaskSource.Version;
				}
			}

			// Token: 0x06007462 RID: 29794 RVA: 0x00115560 File Offset: 0x00113760
			TResult IValueTaskSource<!0>.GetResult(short token)
			{
				throw NotImplemented.ByDesign;
			}

			// Token: 0x06007463 RID: 29795 RVA: 0x0001A4BD File Offset: 0x000186BD
			void IValueTaskSource.GetResult(short token)
			{
				throw NotImplemented.ByDesign;
			}

			// Token: 0x040014DC RID: 5340
			protected Action _moveNextAction;

			// Token: 0x040014DD RID: 5341
			public ExecutionContext Context;

			// Token: 0x040014DE RID: 5342
			protected ManualResetValueTaskSourceCore<TResult> _valueTaskSource;
		}

		// Token: 0x020006BE RID: 1726
		private sealed class SyncSuccessSentinelStateMachineBox : PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox
		{
			// Token: 0x06007465 RID: 29797 RVA: 0x00115574 File Offset: 0x00113774
			public SyncSuccessSentinelStateMachineBox()
			{
				base.SetResult(default(TResult));
			}
		}

		// Token: 0x020006BF RID: 1727
		private sealed class StateMachineBox<TStateMachine> : PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox, IValueTaskSource<!0>, IValueTaskSource, IAsyncStateMachineBox, IThreadPoolWorkItem where TStateMachine : IAsyncStateMachine
		{
			// Token: 0x06007466 RID: 29798 RVA: 0x00115598 File Offset: 0x00113798
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal static PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine> RentFromCache()
			{
				PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine> stateMachineBox = PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine>.t_tlsCache;
				if (stateMachineBox != null)
				{
					PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine>.t_tlsCache = null;
				}
				else
				{
					ref PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine> perCoreCacheSlot = ref PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine>.PerCoreCacheSlot;
					if (perCoreCacheSlot == null || (stateMachineBox = Interlocked.Exchange<PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine>>(ref perCoreCacheSlot, null)) == null)
					{
						stateMachineBox = new PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine>();
					}
				}
				return stateMachineBox;
			}

			// Token: 0x06007467 RID: 29799 RVA: 0x001155D4 File Offset: 0x001137D4
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private void ReturnToCache()
			{
				this.ClearStateUponCompletion();
				this._valueTaskSource.Reset();
				if (PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine>.t_tlsCache == null)
				{
					PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine>.t_tlsCache = this;
					return;
				}
				ref PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine> perCoreCacheSlot = ref PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine>.PerCoreCacheSlot;
				if (perCoreCacheSlot == null)
				{
					Volatile.Write<PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine>>(ref perCoreCacheSlot, this);
				}
			}

			// Token: 0x17000E4E RID: 3662
			// (get) Token: 0x06007468 RID: 29800 RVA: 0x00115614 File Offset: 0x00113814
			private static ref PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine> PerCoreCacheSlot
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					int num = Thread.GetCurrentProcessorId() % Environment.ProcessorCount;
					return Unsafe.As<object, PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine>>(ref PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine>.s_perCoreCache[num].Object);
				}
			}

			// Token: 0x06007469 RID: 29801 RVA: 0x00115642 File Offset: 0x00113842
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void ClearStateUponCompletion()
			{
				this.StateMachine = default(TStateMachine);
				this.Context = null;
			}

			// Token: 0x0600746A RID: 29802 RVA: 0x00115657 File Offset: 0x00113857
			private static void ExecutionContextCallback(object s)
			{
				Unsafe.As<PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine>>(s).StateMachine.MoveNext();
			}

			// Token: 0x17000E4F RID: 3663
			// (get) Token: 0x0600746B RID: 29803 RVA: 0x00115670 File Offset: 0x00113870
			public Action MoveNextAction
			{
				get
				{
					Action result;
					if ((result = this._moveNextAction) == null)
					{
						result = (this._moveNextAction = new Action(this.MoveNext));
					}
					return result;
				}
			}

			// Token: 0x0600746C RID: 29804 RVA: 0x0011569D File Offset: 0x0011389D
			void IThreadPoolWorkItem.Execute()
			{
				this.MoveNext();
			}

			// Token: 0x0600746D RID: 29805 RVA: 0x001156A8 File Offset: 0x001138A8
			public void MoveNext()
			{
				ExecutionContext context = this.Context;
				if (context == null)
				{
					this.StateMachine.MoveNext();
					return;
				}
				ExecutionContext.RunInternal(context, PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine>.s_callback, this);
			}

			// Token: 0x0600746E RID: 29806 RVA: 0x001156E0 File Offset: 0x001138E0
			TResult IValueTaskSource<!0>.GetResult(short token)
			{
				TResult result;
				try
				{
					result = this._valueTaskSource.GetResult(token);
				}
				finally
				{
					this.ReturnToCache();
				}
				return result;
			}

			// Token: 0x0600746F RID: 29807 RVA: 0x00115714 File Offset: 0x00113914
			void IValueTaskSource.GetResult(short token)
			{
				try
				{
					this._valueTaskSource.GetResult(token);
				}
				finally
				{
					this.ReturnToCache();
				}
			}

			// Token: 0x06007470 RID: 29808 RVA: 0x00115748 File Offset: 0x00113948
			IAsyncStateMachine IAsyncStateMachineBox.GetStateMachineObject()
			{
				return this.StateMachine;
			}

			// Token: 0x040014DF RID: 5343
			private static readonly ContextCallback s_callback = new ContextCallback(PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine>.ExecutionContextCallback);

			// Token: 0x040014E0 RID: 5344
			private static readonly PaddedReference[] s_perCoreCache = new PaddedReference[Environment.ProcessorCount];

			// Token: 0x040014E1 RID: 5345
			[ThreadStatic]
			private static PoolingAsyncValueTaskMethodBuilder<TResult>.StateMachineBox<TStateMachine> t_tlsCache;

			// Token: 0x040014E2 RID: 5346
			public TStateMachine StateMachine;
		}
	}
}

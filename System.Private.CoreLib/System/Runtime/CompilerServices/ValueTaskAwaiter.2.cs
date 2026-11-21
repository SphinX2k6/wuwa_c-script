using System;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006E3 RID: 1763
	public readonly struct ValueTaskAwaiter<[Nullable(2)] TResult> : ICriticalNotifyCompletion, INotifyCompletion, IStateMachineBoxAwareAwaiter
	{
		// Token: 0x060074FD RID: 29949 RVA: 0x0011626C File Offset: 0x0011446C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ValueTaskAwaiter(in ValueTask<TResult> value)
		{
			this._value = value;
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x060074FE RID: 29950 RVA: 0x0011627A File Offset: 0x0011447A
		public bool IsCompleted
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this._value.IsCompleted;
			}
		}

		// Token: 0x060074FF RID: 29951 RVA: 0x00116287 File Offset: 0x00114487
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public TResult GetResult()
		{
			return this._value.Result;
		}

		// Token: 0x06007500 RID: 29952 RVA: 0x00116294 File Offset: 0x00114494
		[NullableContext(1)]
		public void OnCompleted(Action continuation)
		{
			object obj = this._value._obj;
			Task<TResult> task = obj as Task<TResult>;
			if (task != null)
			{
				task.GetAwaiter().OnCompleted(continuation);
				return;
			}
			if (obj != null)
			{
				Unsafe.As<IValueTaskSource<TResult>>(obj).OnCompleted(ValueTaskAwaiter.s_invokeActionDelegate, continuation, this._value._token, ValueTaskSourceOnCompletedFlags.UseSchedulingContext | ValueTaskSourceOnCompletedFlags.FlowExecutionContext);
				return;
			}
			Task.CompletedTask.GetAwaiter().OnCompleted(continuation);
		}

		// Token: 0x06007501 RID: 29953 RVA: 0x001162FC File Offset: 0x001144FC
		[NullableContext(1)]
		public void UnsafeOnCompleted(Action continuation)
		{
			object obj = this._value._obj;
			Task<TResult> task = obj as Task<TResult>;
			if (task != null)
			{
				task.GetAwaiter().UnsafeOnCompleted(continuation);
				return;
			}
			if (obj != null)
			{
				Unsafe.As<IValueTaskSource<TResult>>(obj).OnCompleted(ValueTaskAwaiter.s_invokeActionDelegate, continuation, this._value._token, ValueTaskSourceOnCompletedFlags.UseSchedulingContext);
				return;
			}
			Task.CompletedTask.GetAwaiter().UnsafeOnCompleted(continuation);
		}

		// Token: 0x06007502 RID: 29954 RVA: 0x00116364 File Offset: 0x00114564
		void IStateMachineBoxAwareAwaiter.AwaitUnsafeOnCompleted(IAsyncStateMachineBox box)
		{
			object obj = this._value._obj;
			Task<TResult> task = obj as Task<TResult>;
			if (task != null)
			{
				TaskAwaiter.UnsafeOnCompletedInternal(task, box, true);
				return;
			}
			if (obj != null)
			{
				Unsafe.As<IValueTaskSource<TResult>>(obj).OnCompleted(ThreadPool.s_invokeAsyncStateMachineBox, box, this._value._token, ValueTaskSourceOnCompletedFlags.UseSchedulingContext);
				return;
			}
			TaskAwaiter.UnsafeOnCompletedInternal(Task.CompletedTask, box, true);
		}

		// Token: 0x0400150B RID: 5387
		private readonly ValueTask<TResult> _value;
	}
}

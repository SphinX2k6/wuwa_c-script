using System;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006E1 RID: 1761
	public readonly struct ValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion, IStateMachineBoxAwareAwaiter
	{
		// Token: 0x060074F3 RID: 29939 RVA: 0x001160D1 File Offset: 0x001142D1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ValueTaskAwaiter(in ValueTask value)
		{
			this._value = value;
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x060074F4 RID: 29940 RVA: 0x001160DF File Offset: 0x001142DF
		public bool IsCompleted
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this._value.IsCompleted;
			}
		}

		// Token: 0x060074F5 RID: 29941 RVA: 0x001160EC File Offset: 0x001142EC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void GetResult()
		{
			this._value.ThrowIfCompletedUnsuccessfully();
		}

		// Token: 0x060074F6 RID: 29942 RVA: 0x001160FC File Offset: 0x001142FC
		[NullableContext(1)]
		public void OnCompleted(Action continuation)
		{
			object obj = this._value._obj;
			Task task = obj as Task;
			if (task != null)
			{
				task.GetAwaiter().OnCompleted(continuation);
				return;
			}
			if (obj != null)
			{
				Unsafe.As<IValueTaskSource>(obj).OnCompleted(ValueTaskAwaiter.s_invokeActionDelegate, continuation, this._value._token, ValueTaskSourceOnCompletedFlags.UseSchedulingContext | ValueTaskSourceOnCompletedFlags.FlowExecutionContext);
				return;
			}
			Task.CompletedTask.GetAwaiter().OnCompleted(continuation);
		}

		// Token: 0x060074F7 RID: 29943 RVA: 0x00116164 File Offset: 0x00114364
		[NullableContext(1)]
		public void UnsafeOnCompleted(Action continuation)
		{
			object obj = this._value._obj;
			Task task = obj as Task;
			if (task != null)
			{
				task.GetAwaiter().UnsafeOnCompleted(continuation);
				return;
			}
			if (obj != null)
			{
				Unsafe.As<IValueTaskSource>(obj).OnCompleted(ValueTaskAwaiter.s_invokeActionDelegate, continuation, this._value._token, ValueTaskSourceOnCompletedFlags.UseSchedulingContext);
				return;
			}
			Task.CompletedTask.GetAwaiter().UnsafeOnCompleted(continuation);
		}

		// Token: 0x060074F8 RID: 29944 RVA: 0x001161CC File Offset: 0x001143CC
		void IStateMachineBoxAwareAwaiter.AwaitUnsafeOnCompleted(IAsyncStateMachineBox box)
		{
			object obj = this._value._obj;
			Task task = obj as Task;
			if (task != null)
			{
				TaskAwaiter.UnsafeOnCompletedInternal(task, box, true);
				return;
			}
			if (obj != null)
			{
				Unsafe.As<IValueTaskSource>(obj).OnCompleted(ThreadPool.s_invokeAsyncStateMachineBox, box, this._value._token, ValueTaskSourceOnCompletedFlags.UseSchedulingContext);
				return;
			}
			TaskAwaiter.UnsafeOnCompletedInternal(Task.CompletedTask, box, true);
		}

		// Token: 0x04001508 RID: 5384
		internal static readonly Action<object> s_invokeActionDelegate = delegate(object state)
		{
			Action action = state as Action;
			if (action != null)
			{
				action();
				return;
			}
			ThrowHelper.ThrowUnexpectedStateForKnownCallback(state);
		};

		// Token: 0x04001509 RID: 5385
		private readonly ValueTask _value;
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	// Token: 0x02000465 RID: 1125
	internal sealed class AsyncOverSyncWithIoCancellation
	{
		// Token: 0x06004330 RID: 17200 RVA: 0x000E00D8 File Offset: 0x000DE2D8
		private AsyncOverSyncWithIoCancellation()
		{
			SafeThreadHandle safeThreadHandle = Interop.Kernel32.OpenThread(1, false, Interop.Kernel32.GetCurrentThreadId());
			if (!safeThreadHandle.IsInvalid)
			{
				this._threadHandle = safeThreadHandle;
				return;
			}
			safeThreadHandle.Dispose();
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x000E010E File Offset: 0x000DE30E
		private void Reset()
		{
			this._finishedCancellationRegistration = false;
			this._continueTryingToCancel = true;
			this._callbackCompleted = null;
		}

		// Token: 0x06004332 RID: 17202 RVA: 0x000E0128 File Offset: 0x000DE328
		[AsyncMethodBuilder(typeof(PoolingAsyncValueTaskMethodBuilder))]
		public static ValueTask InvokeAsync<TState>(Action<TState> action, TState state, CancellationToken cancellationToken)
		{
			AsyncOverSyncWithIoCancellation.<InvokeAsync>d__7<TState> <InvokeAsync>d__;
			<InvokeAsync>d__.<>t__builder = PoolingAsyncValueTaskMethodBuilder.Create();
			<InvokeAsync>d__.action = action;
			<InvokeAsync>d__.state = state;
			<InvokeAsync>d__.cancellationToken = cancellationToken;
			<InvokeAsync>d__.<>1__state = -1;
			<InvokeAsync>d__.<>t__builder.Start<AsyncOverSyncWithIoCancellation.<InvokeAsync>d__7<TState>>(ref <InvokeAsync>d__);
			return <InvokeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x000E017C File Offset: 0x000DE37C
		[AsyncMethodBuilder(typeof(PoolingAsyncValueTaskMethodBuilder<>))]
		public static ValueTask<TResult> InvokeAsync<TState, TResult>(Func<TState, TResult> func, TState state, CancellationToken cancellationToken)
		{
			AsyncOverSyncWithIoCancellation.<InvokeAsync>d__8<TState, TResult> <InvokeAsync>d__;
			<InvokeAsync>d__.<>t__builder = PoolingAsyncValueTaskMethodBuilder<TResult>.Create();
			<InvokeAsync>d__.func = func;
			<InvokeAsync>d__.state = state;
			<InvokeAsync>d__.cancellationToken = cancellationToken;
			<InvokeAsync>d__.<>1__state = -1;
			<InvokeAsync>d__.<>t__builder.Start<AsyncOverSyncWithIoCancellation.<InvokeAsync>d__8<TState, TResult>>(ref <InvokeAsync>d__);
			return <InvokeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06004334 RID: 17204 RVA: 0x000E01D0 File Offset: 0x000DE3D0
		private static OperationCanceledException CreateAppropriateCancellationException(CancellationToken cancellationToken, OperationCanceledException originalOce)
		{
			OperationCanceledException ex = new OperationCanceledException(cancellationToken);
			string stackTrace = originalOce.StackTrace;
			if (stackTrace != null)
			{
				ExceptionDispatchInfo.SetRemoteStackTrace(ex, stackTrace);
			}
			return ex;
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x000E01F8 File Offset: 0x000DE3F8
		private static AsyncOverSyncWithIoCancellation.SyncAsyncWorkItemRegistration RegisterCancellation(CancellationToken cancellationToken)
		{
			if (!cancellationToken.CanBeCanceled)
			{
				return default(AsyncOverSyncWithIoCancellation.SyncAsyncWorkItemRegistration);
			}
			cancellationToken.ThrowIfCancellationRequested();
			AsyncOverSyncWithIoCancellation asyncOverSyncWithIoCancellation;
			if ((asyncOverSyncWithIoCancellation = AsyncOverSyncWithIoCancellation.t_instance) == null)
			{
				asyncOverSyncWithIoCancellation = (AsyncOverSyncWithIoCancellation.t_instance = new AsyncOverSyncWithIoCancellation());
			}
			AsyncOverSyncWithIoCancellation asyncOverSyncWithIoCancellation2 = asyncOverSyncWithIoCancellation;
			if (asyncOverSyncWithIoCancellation2._threadHandle == null)
			{
				return default(AsyncOverSyncWithIoCancellation.SyncAsyncWorkItemRegistration);
			}
			asyncOverSyncWithIoCancellation2.Reset();
			AsyncOverSyncWithIoCancellation.SyncAsyncWorkItemRegistration result = default(AsyncOverSyncWithIoCancellation.SyncAsyncWorkItemRegistration);
			result.WorkItem = asyncOverSyncWithIoCancellation2;
			result.CancellationRegistration = cancellationToken.UnsafeRegister(delegate(object s)
			{
				AsyncOverSyncWithIoCancellation asyncOverSyncWithIoCancellation3 = (AsyncOverSyncWithIoCancellation)s;
				if (!Volatile.Read(ref asyncOverSyncWithIoCancellation3._finishedCancellationRegistration))
				{
					return;
				}
				asyncOverSyncWithIoCancellation3._callbackCompleted = Task.Factory.StartNew(delegate(object s)
				{
					AsyncOverSyncWithIoCancellation asyncOverSyncWithIoCancellation4 = (AsyncOverSyncWithIoCancellation)s;
					SpinWait spinWait = default(SpinWait);
					while (Volatile.Read(ref asyncOverSyncWithIoCancellation4._continueTryingToCancel) && !Interop.Kernel32.CancelSynchronousIo(asyncOverSyncWithIoCancellation4._threadHandle) && Marshal.GetLastPInvokeError() == 1168)
					{
						spinWait.SpinOnce();
					}
				}, asyncOverSyncWithIoCancellation3, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
			}, asyncOverSyncWithIoCancellation2);
			Volatile.Write(ref asyncOverSyncWithIoCancellation2._finishedCancellationRegistration, true);
			if (cancellationToken.IsCancellationRequested)
			{
				result.Dispose();
				throw new OperationCanceledException(cancellationToken);
			}
			return result;
		}

		// Token: 0x04000ED3 RID: 3795
		[ThreadStatic]
		private static AsyncOverSyncWithIoCancellation t_instance;

		// Token: 0x04000ED4 RID: 3796
		private readonly SafeThreadHandle _threadHandle;

		// Token: 0x04000ED5 RID: 3797
		private bool _finishedCancellationRegistration;

		// Token: 0x04000ED6 RID: 3798
		private bool _continueTryingToCancel;

		// Token: 0x04000ED7 RID: 3799
		private Task _callbackCompleted;

		// Token: 0x02000466 RID: 1126
		private struct SyncAsyncWorkItemRegistration : IDisposable
		{
			// Token: 0x06004336 RID: 17206 RVA: 0x000E02B0 File Offset: 0x000DE4B0
			public void Dispose()
			{
				if (this.WorkItem == null)
				{
					return;
				}
				Volatile.Write(ref this.WorkItem._continueTryingToCancel, false);
				this.CancellationRegistration.Dispose();
				Task callbackCompleted = this.WorkItem._callbackCompleted;
				if (callbackCompleted == null)
				{
					return;
				}
				callbackCompleted.GetAwaiter().GetResult();
			}

			// Token: 0x04000ED8 RID: 3800
			public AsyncOverSyncWithIoCancellation WorkItem;

			// Token: 0x04000ED9 RID: 3801
			public CancellationTokenRegistration CancellationRegistration;
		}
	}
}

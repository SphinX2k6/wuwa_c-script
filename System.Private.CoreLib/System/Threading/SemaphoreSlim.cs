using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Threading.Tasks;

namespace System.Threading
{
	// Token: 0x0200040A RID: 1034
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerDisplay("Current Count = {m_currentCount}")]
	public class SemaphoreSlim : IDisposable
	{
		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x0600413B RID: 16699 RVA: 0x000D990E File Offset: 0x000D7B0E
		public int CurrentCount
		{
			get
			{
				return this.m_currentCount;
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x0600413C RID: 16700 RVA: 0x000D9918 File Offset: 0x000D7B18
		public WaitHandle AvailableWaitHandle
		{
			get
			{
				this.CheckDispose();
				if (this.m_waitHandle == null)
				{
					StrongBox<bool> lockObjAndDisposed = this.m_lockObjAndDisposed;
					lock (lockObjAndDisposed)
					{
						if (this.m_waitHandle == null)
						{
							this.m_waitHandle = new ManualResetEvent(this.m_currentCount != 0);
						}
					}
				}
				return this.m_waitHandle;
			}
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x000D998C File Offset: 0x000D7B8C
		public SemaphoreSlim(int initialCount) : this(initialCount, int.MaxValue)
		{
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x000D999C File Offset: 0x000D7B9C
		public SemaphoreSlim(int initialCount, int maxCount)
		{
			if (initialCount < 0 || initialCount > maxCount)
			{
				throw new ArgumentOutOfRangeException("initialCount", initialCount, SR.SemaphoreSlim_ctor_InitialCountWrong);
			}
			if (maxCount <= 0)
			{
				throw new ArgumentOutOfRangeException("maxCount", maxCount, SR.SemaphoreSlim_ctor_MaxCountWrong);
			}
			this.m_maxCount = maxCount;
			this.m_currentCount = initialCount;
			this.m_lockObjAndDisposed = new StrongBox<bool>();
		}

		// Token: 0x0600413F RID: 16703 RVA: 0x000D9A02 File Offset: 0x000D7C02
		[UnsupportedOSPlatform("browser")]
		public void Wait()
		{
			this.Wait(-1, CancellationToken.None);
		}

		// Token: 0x06004140 RID: 16704 RVA: 0x000D9A11 File Offset: 0x000D7C11
		[UnsupportedOSPlatform("browser")]
		public void Wait(CancellationToken cancellationToken)
		{
			this.Wait(-1, cancellationToken);
		}

		// Token: 0x06004141 RID: 16705 RVA: 0x000D9A1C File Offset: 0x000D7C1C
		[UnsupportedOSPlatform("browser")]
		public bool Wait(TimeSpan timeout)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout", timeout, SR.SemaphoreSlim_Wait_TimeoutWrong);
			}
			return this.Wait((int)timeout.TotalMilliseconds, CancellationToken.None);
		}

		// Token: 0x06004142 RID: 16706 RVA: 0x000D9A6C File Offset: 0x000D7C6C
		[UnsupportedOSPlatform("browser")]
		public bool Wait(TimeSpan timeout, CancellationToken cancellationToken)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout", timeout, SR.SemaphoreSlim_Wait_TimeoutWrong);
			}
			return this.Wait((int)timeout.TotalMilliseconds, cancellationToken);
		}

		// Token: 0x06004143 RID: 16707 RVA: 0x000D9AB5 File Offset: 0x000D7CB5
		[UnsupportedOSPlatform("browser")]
		public bool Wait(int millisecondsTimeout)
		{
			return this.Wait(millisecondsTimeout, CancellationToken.None);
		}

		// Token: 0x06004144 RID: 16708 RVA: 0x000D9AC4 File Offset: 0x000D7CC4
		[UnsupportedOSPlatform("browser")]
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			this.CheckDispose();
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout", millisecondsTimeout, SR.SemaphoreSlim_Wait_TimeoutWrong);
			}
			cancellationToken.ThrowIfCancellationRequested();
			if (millisecondsTimeout == 0 && this.m_currentCount == 0)
			{
				return false;
			}
			uint startTime = 0U;
			if (millisecondsTimeout != -1 && millisecondsTimeout > 0)
			{
				startTime = TimeoutHelper.GetTime();
			}
			bool result = false;
			Task<bool> task = null;
			bool flag = false;
			CancellationTokenRegistration cancellationTokenRegistration = cancellationToken.UnsafeRegister(SemaphoreSlim.s_cancellationTokenCanceledEventHandler, this);
			try
			{
				if (this.m_currentCount == 0)
				{
					int num = SpinWait.SpinCountforSpinBeforeWait * 4;
					SpinWait spinWait = default(SpinWait);
					while (spinWait.Count < num)
					{
						spinWait.SpinOnce(-1);
						if (this.m_currentCount != 0)
						{
							break;
						}
					}
				}
				Monitor.Enter(this.m_lockObjAndDisposed, ref flag);
				this.m_waitCount++;
				if (this.m_asyncHead != null)
				{
					task = this.WaitAsync(millisecondsTimeout, cancellationToken);
				}
				else
				{
					OperationCanceledException ex = null;
					if (this.m_currentCount == 0)
					{
						if (millisecondsTimeout == 0)
						{
							return false;
						}
						try
						{
							result = this.WaitUntilCountOrTimeout(millisecondsTimeout, startTime, cancellationToken);
						}
						catch (OperationCanceledException ex)
						{
						}
					}
					if (this.m_currentCount > 0)
					{
						result = true;
						this.m_currentCount--;
					}
					else if (ex != null)
					{
						throw ex;
					}
					if (this.m_waitHandle != null && this.m_currentCount == 0)
					{
						this.m_waitHandle.Reset();
					}
				}
			}
			finally
			{
				if (flag)
				{
					this.m_waitCount--;
					Monitor.Exit(this.m_lockObjAndDisposed);
				}
				cancellationTokenRegistration.Dispose();
			}
			if (task == null)
			{
				return result;
			}
			return task.GetAwaiter().GetResult();
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x000D9C64 File Offset: 0x000D7E64
		[UnsupportedOSPlatform("browser")]
		private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken)
		{
			int num = -1;
			while (this.m_currentCount == 0)
			{
				cancellationToken.ThrowIfCancellationRequested();
				if (millisecondsTimeout != -1)
				{
					num = TimeoutHelper.UpdateTimeOut(startTime, millisecondsTimeout);
					if (num <= 0)
					{
						return false;
					}
				}
				bool flag = Monitor.Wait(this.m_lockObjAndDisposed, num);
				if (this.m_countOfWaitersPulsedToWake != 0)
				{
					this.m_countOfWaitersPulsedToWake--;
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x000D9CC0 File Offset: 0x000D7EC0
		public Task WaitAsync()
		{
			return this.WaitAsync(-1, default(CancellationToken));
		}

		// Token: 0x06004147 RID: 16711 RVA: 0x000D9CDD File Offset: 0x000D7EDD
		public Task WaitAsync(CancellationToken cancellationToken)
		{
			return this.WaitAsync(-1, cancellationToken);
		}

		// Token: 0x06004148 RID: 16712 RVA: 0x000D9CE8 File Offset: 0x000D7EE8
		public Task<bool> WaitAsync(int millisecondsTimeout)
		{
			return this.WaitAsync(millisecondsTimeout, default(CancellationToken));
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x000D9D08 File Offset: 0x000D7F08
		public Task<bool> WaitAsync(TimeSpan timeout)
		{
			return this.WaitAsync(timeout, default(CancellationToken));
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x000D9D28 File Offset: 0x000D7F28
		public Task<bool> WaitAsync(TimeSpan timeout, CancellationToken cancellationToken)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout", timeout, SR.SemaphoreSlim_Wait_TimeoutWrong);
			}
			return this.WaitAsync((int)timeout.TotalMilliseconds, cancellationToken);
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x000D9D74 File Offset: 0x000D7F74
		public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			this.CheckDispose();
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout", millisecondsTimeout, SR.SemaphoreSlim_Wait_TimeoutWrong);
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<bool>(cancellationToken);
			}
			StrongBox<bool> lockObjAndDisposed = this.m_lockObjAndDisposed;
			Task<bool> result;
			lock (lockObjAndDisposed)
			{
				if (this.m_currentCount > 0)
				{
					this.m_currentCount--;
					if (this.m_waitHandle != null && this.m_currentCount == 0)
					{
						this.m_waitHandle.Reset();
					}
					result = Task.FromResult<bool>(true);
				}
				else if (millisecondsTimeout == 0)
				{
					result = Task.FromResult<bool>(false);
				}
				else
				{
					SemaphoreSlim.TaskNode taskNode = this.CreateAndAddAsyncWaiter();
					result = ((millisecondsTimeout == -1 && !cancellationToken.CanBeCanceled) ? taskNode : this.WaitUntilCountOrTimeoutAsync(taskNode, millisecondsTimeout, cancellationToken));
				}
			}
			return result;
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x000D9E54 File Offset: 0x000D8054
		private SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter()
		{
			SemaphoreSlim.TaskNode taskNode = new SemaphoreSlim.TaskNode();
			if (this.m_asyncHead == null)
			{
				this.m_asyncHead = taskNode;
				this.m_asyncTail = taskNode;
			}
			else
			{
				this.m_asyncTail.Next = taskNode;
				taskNode.Prev = this.m_asyncTail;
				this.m_asyncTail = taskNode;
			}
			return taskNode;
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x000D9EA0 File Offset: 0x000D80A0
		private bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task)
		{
			bool result = this.m_asyncHead == task || task.Prev != null;
			if (task.Next != null)
			{
				task.Next.Prev = task.Prev;
			}
			if (task.Prev != null)
			{
				task.Prev.Next = task.Next;
			}
			if (this.m_asyncHead == task)
			{
				this.m_asyncHead = task.Next;
			}
			if (this.m_asyncTail == task)
			{
				this.m_asyncTail = task.Prev;
			}
			task.Next = (task.Prev = null);
			return result;
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x000D9F34 File Offset: 0x000D8134
		private Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31 <WaitUntilCountOrTimeoutAsync>d__;
			<WaitUntilCountOrTimeoutAsync>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<WaitUntilCountOrTimeoutAsync>d__.<>4__this = this;
			<WaitUntilCountOrTimeoutAsync>d__.asyncWaiter = asyncWaiter;
			<WaitUntilCountOrTimeoutAsync>d__.millisecondsTimeout = millisecondsTimeout;
			<WaitUntilCountOrTimeoutAsync>d__.cancellationToken = cancellationToken;
			<WaitUntilCountOrTimeoutAsync>d__.<>1__state = -1;
			<WaitUntilCountOrTimeoutAsync>d__.<>t__builder.Start<SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>(ref <WaitUntilCountOrTimeoutAsync>d__);
			return <WaitUntilCountOrTimeoutAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x000D9F8F File Offset: 0x000D818F
		public int Release()
		{
			return this.Release(1);
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x000D9F98 File Offset: 0x000D8198
		public int Release(int releaseCount)
		{
			this.CheckDispose();
			if (releaseCount < 1)
			{
				throw new ArgumentOutOfRangeException("releaseCount", releaseCount, SR.SemaphoreSlim_Release_CountWrong);
			}
			StrongBox<bool> lockObjAndDisposed = this.m_lockObjAndDisposed;
			int num2;
			lock (lockObjAndDisposed)
			{
				int num = this.m_currentCount;
				num2 = num;
				if (this.m_maxCount - num < releaseCount)
				{
					throw new SemaphoreFullException();
				}
				num += releaseCount;
				int waitCount = this.m_waitCount;
				int num3 = Math.Min(num, waitCount) - this.m_countOfWaitersPulsedToWake;
				if (num3 > 0)
				{
					if (num3 > releaseCount)
					{
						num3 = releaseCount;
					}
					this.m_countOfWaitersPulsedToWake += num3;
					for (int i = 0; i < num3; i++)
					{
						Monitor.Pulse(this.m_lockObjAndDisposed);
					}
				}
				if (this.m_asyncHead != null)
				{
					int num4 = num - waitCount;
					while (num4 > 0 && this.m_asyncHead != null)
					{
						num--;
						num4--;
						SemaphoreSlim.TaskNode asyncHead = this.m_asyncHead;
						this.RemoveAsyncWaiter(asyncHead);
						asyncHead.TrySetResult(true);
					}
				}
				this.m_currentCount = num;
				if (this.m_waitHandle != null && num2 == 0 && num > 0)
				{
					this.m_waitHandle.Set();
				}
			}
			return num2;
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x000DA0D0 File Offset: 0x000D82D0
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x000DA0E0 File Offset: 0x000D82E0
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				WaitHandle waitHandle = this.m_waitHandle;
				if (waitHandle != null)
				{
					waitHandle.Dispose();
					this.m_waitHandle = null;
				}
				this.m_lockObjAndDisposed.Value = true;
				this.m_asyncHead = null;
				this.m_asyncTail = null;
			}
		}

		// Token: 0x06004153 RID: 16723 RVA: 0x000DA128 File Offset: 0x000D8328
		private static void CancellationTokenCanceledEventHandler(object obj)
		{
			SemaphoreSlim semaphoreSlim = (SemaphoreSlim)obj;
			StrongBox<bool> lockObjAndDisposed = semaphoreSlim.m_lockObjAndDisposed;
			lock (lockObjAndDisposed)
			{
				Monitor.PulseAll(semaphoreSlim.m_lockObjAndDisposed);
			}
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x000DA174 File Offset: 0x000D8374
		private void CheckDispose()
		{
			ObjectDisposedException.ThrowIf(this.m_lockObjAndDisposed.Value, this);
		}

		// Token: 0x04000DCC RID: 3532
		private volatile int m_currentCount;

		// Token: 0x04000DCD RID: 3533
		private readonly int m_maxCount;

		// Token: 0x04000DCE RID: 3534
		private int m_waitCount;

		// Token: 0x04000DCF RID: 3535
		private int m_countOfWaitersPulsedToWake;

		// Token: 0x04000DD0 RID: 3536
		private readonly StrongBox<bool> m_lockObjAndDisposed;

		// Token: 0x04000DD1 RID: 3537
		private volatile ManualResetEvent m_waitHandle;

		// Token: 0x04000DD2 RID: 3538
		private SemaphoreSlim.TaskNode m_asyncHead;

		// Token: 0x04000DD3 RID: 3539
		private SemaphoreSlim.TaskNode m_asyncTail;

		// Token: 0x04000DD4 RID: 3540
		private static readonly Action<object> s_cancellationTokenCanceledEventHandler = new Action<object>(SemaphoreSlim.CancellationTokenCanceledEventHandler);

		// Token: 0x0200040B RID: 1035
		private sealed class TaskNode : Task<bool>
		{
			// Token: 0x06004156 RID: 16726 RVA: 0x000DA19A File Offset: 0x000D839A
			internal TaskNode() : base(null, TaskCreationOptions.RunContinuationsAsynchronously)
			{
			}

			// Token: 0x04000DD5 RID: 3541
			internal SemaphoreSlim.TaskNode Prev;

			// Token: 0x04000DD6 RID: 3542
			internal SemaphoreSlim.TaskNode Next;
		}
	}
}

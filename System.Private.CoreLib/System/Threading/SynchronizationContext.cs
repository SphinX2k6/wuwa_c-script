using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x02000411 RID: 1041
	[NullableContext(1)]
	[Nullable(0)]
	public class SynchronizationContext
	{
		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x0600417C RID: 16764 RVA: 0x000DAB02 File Offset: 0x000D8D02
		[Nullable(2)]
		public static SynchronizationContext Current
		{
			[NullableContext(2)]
			get
			{
				return Thread.CurrentThread._synchronizationContext;
			}
		}

		// Token: 0x0600417D RID: 16765 RVA: 0x000DAB0E File Offset: 0x000D8D0E
		protected void SetWaitNotificationRequired()
		{
			this._requireWaitNotification = true;
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x000DAB17 File Offset: 0x000D8D17
		public bool IsWaitNotificationRequired()
		{
			return this._requireWaitNotification;
		}

		// Token: 0x0600417F RID: 16767 RVA: 0x000DAB1F File Offset: 0x000D8D1F
		public virtual void Send(SendOrPostCallback d, [Nullable(2)] object state)
		{
			d(state);
		}

		// Token: 0x06004180 RID: 16768 RVA: 0x000DAB28 File Offset: 0x000D8D28
		public virtual void Post(SendOrPostCallback d, [Nullable(2)] object state)
		{
			ThreadPool.QueueUserWorkItem<KeyValuePair<SendOrPostCallback, object>>(delegate(KeyValuePair<SendOrPostCallback, object> s)
			{
				s.Key(s.Value);
			}, new KeyValuePair<SendOrPostCallback, object>(d, state), false);
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public virtual void OperationStarted()
		{
		}

		// Token: 0x06004182 RID: 16770 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public virtual void OperationCompleted()
		{
		}

		// Token: 0x06004183 RID: 16771 RVA: 0x000DAB57 File Offset: 0x000D8D57
		[CLSCompliant(false)]
		public virtual int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
		{
			return SynchronizationContext.WaitHelper(waitHandles, waitAll, millisecondsTimeout);
		}

		// Token: 0x06004184 RID: 16772 RVA: 0x000DAB61 File Offset: 0x000D8D61
		[CLSCompliant(false)]
		protected static int WaitHelper(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
		{
			ArgumentNullException.ThrowIfNull(waitHandles, "waitHandles");
			return WaitHandle.WaitMultipleIgnoringSyncContext(waitHandles, waitAll, millisecondsTimeout);
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x000DAB7B File Offset: 0x000D8D7B
		[NullableContext(2)]
		public static void SetSynchronizationContext(SynchronizationContext syncContext)
		{
			Thread.CurrentThread._synchronizationContext = syncContext;
		}

		// Token: 0x06004186 RID: 16774 RVA: 0x000DAB88 File Offset: 0x000D8D88
		public virtual SynchronizationContext CreateCopy()
		{
			return new SynchronizationContext();
		}

		// Token: 0x04000DE3 RID: 3555
		private bool _requireWaitNotification;
	}
}

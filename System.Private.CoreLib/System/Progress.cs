using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System
{
	// Token: 0x02000191 RID: 401
	[NullableContext(1)]
	[Nullable(0)]
	public class Progress<[Nullable(2)] T> : IProgress<T>
	{
		// Token: 0x06001A14 RID: 6676 RVA: 0x00055791 File Offset: 0x00053991
		public Progress()
		{
			this._synchronizationContext = (SynchronizationContext.Current ?? ProgressStatics.DefaultContext);
			this._invokeHandlers = new SendOrPostCallback(this.InvokeHandlers);
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x000557BF File Offset: 0x000539BF
		public Progress(Action<T> handler) : this()
		{
			ArgumentNullException.ThrowIfNull(handler, "handler");
			this._handler = handler;
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06001A16 RID: 6678 RVA: 0x000557DC File Offset: 0x000539DC
		// (remove) Token: 0x06001A17 RID: 6679 RVA: 0x00055814 File Offset: 0x00053A14
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event EventHandler<T> ProgressChanged;

		// Token: 0x06001A18 RID: 6680 RVA: 0x0005584C File Offset: 0x00053A4C
		protected virtual void OnReport(T value)
		{
			bool handler = this._handler != null;
			EventHandler<T> progressChanged = this.ProgressChanged;
			if (handler || progressChanged != null)
			{
				this._synchronizationContext.Post(this._invokeHandlers, value);
			}
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x00055882 File Offset: 0x00053A82
		void IProgress<!0>.Report(T value)
		{
			this.OnReport(value);
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x0005588C File Offset: 0x00053A8C
		private void InvokeHandlers(object state)
		{
			T t = (T)((object)state);
			Action<T> handler = this._handler;
			EventHandler<T> progressChanged = this.ProgressChanged;
			if (handler != null)
			{
				handler(t);
			}
			if (progressChanged != null)
			{
				progressChanged(this, t);
			}
		}

		// Token: 0x04000544 RID: 1348
		private readonly SynchronizationContext _synchronizationContext;

		// Token: 0x04000545 RID: 1349
		private readonly Action<T> _handler;

		// Token: 0x04000546 RID: 1350
		private readonly SendOrPostCallback _invokeHandlers;
	}
}

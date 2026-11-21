using System;
using System.Threading.Tasks;

namespace System.Threading
{
	// Token: 0x0200044D RID: 1101
	internal sealed class TimerHolder
	{
		// Token: 0x060042BC RID: 17084 RVA: 0x000DED69 File Offset: 0x000DCF69
		public TimerHolder(TimerQueueTimer timer)
		{
			this._timer = timer;
		}

		// Token: 0x060042BD RID: 17085 RVA: 0x000DED78 File Offset: 0x000DCF78
		~TimerHolder()
		{
			this._timer.Dispose();
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x000DEDAC File Offset: 0x000DCFAC
		public void Dispose()
		{
			this._timer.Dispose();
			GC.SuppressFinalize(this);
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x000DEDBF File Offset: 0x000DCFBF
		public bool Dispose(WaitHandle notifyObject)
		{
			bool result = this._timer.Dispose(notifyObject);
			GC.SuppressFinalize(this);
			return result;
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x000DEDD3 File Offset: 0x000DCFD3
		public ValueTask DisposeAsync()
		{
			ValueTask result = this._timer.DisposeAsync();
			GC.SuppressFinalize(this);
			return result;
		}

		// Token: 0x04000EA7 RID: 3751
		internal readonly TimerQueueTimer _timer;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace System.IO
{
	// Token: 0x02000801 RID: 2049
	internal abstract class Iterator<TSource> : IEnumerable<!0>, IEnumerable, IEnumerator<!0>, IDisposable, IEnumerator
	{
		// Token: 0x06008338 RID: 33592 RVA: 0x00138D39 File Offset: 0x00136F39
		public Iterator()
		{
			this._threadId = Environment.CurrentManagedThreadId;
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x06008339 RID: 33593 RVA: 0x00138D4C File Offset: 0x00136F4C
		public TSource Current
		{
			get
			{
				return this.current;
			}
		}

		// Token: 0x0600833A RID: 33594
		protected abstract Iterator<TSource> Clone();

		// Token: 0x0600833B RID: 33595 RVA: 0x00138D54 File Offset: 0x00136F54
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600833C RID: 33596 RVA: 0x00138D63 File Offset: 0x00136F63
		protected virtual void Dispose(bool disposing)
		{
			this.current = default(TSource);
			this.state = -1;
		}

		// Token: 0x0600833D RID: 33597 RVA: 0x00138D78 File Offset: 0x00136F78
		public IEnumerator<TSource> GetEnumerator()
		{
			if (this.state == 0 && this._threadId == Environment.CurrentManagedThreadId)
			{
				this.state = 1;
				return this;
			}
			Iterator<TSource> iterator = this.Clone();
			iterator.state = 1;
			return iterator;
		}

		// Token: 0x0600833E RID: 33598
		public abstract bool MoveNext();

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x0600833F RID: 33599 RVA: 0x00138DA5 File Offset: 0x00136FA5
		object IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		// Token: 0x06008340 RID: 33600 RVA: 0x00138DB2 File Offset: 0x00136FB2
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06008341 RID: 33601 RVA: 0x0001A563 File Offset: 0x00018763
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x04001BBF RID: 7103
		private readonly int _threadId;

		// Token: 0x04001BC0 RID: 7104
		internal int state;

		// Token: 0x04001BC1 RID: 7105
		internal TSource current;
	}
}

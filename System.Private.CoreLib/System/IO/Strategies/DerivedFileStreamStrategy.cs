using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Strategies
{
	// Token: 0x0200085C RID: 2140
	internal sealed class DerivedFileStreamStrategy : FileStreamStrategy
	{
		// Token: 0x060087D5 RID: 34773 RVA: 0x0014A2C6 File Offset: 0x001484C6
		internal DerivedFileStreamStrategy(FileStream fileStream, FileStreamStrategy strategy)
		{
			this._fileStream = fileStream;
			this._strategy = strategy;
			base.IsDerived = true;
		}

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x060087D6 RID: 34774 RVA: 0x0014A2E3 File Offset: 0x001484E3
		public override bool CanRead
		{
			get
			{
				return this._strategy.CanRead;
			}
		}

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x060087D7 RID: 34775 RVA: 0x0014A2F0 File Offset: 0x001484F0
		public override bool CanWrite
		{
			get
			{
				return this._strategy.CanWrite;
			}
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x060087D8 RID: 34776 RVA: 0x0014A2FD File Offset: 0x001484FD
		public override bool CanSeek
		{
			get
			{
				return this._strategy.CanSeek;
			}
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x060087D9 RID: 34777 RVA: 0x0014A30A File Offset: 0x0014850A
		public override long Length
		{
			get
			{
				return this._strategy.Length;
			}
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x060087DA RID: 34778 RVA: 0x0014A317 File Offset: 0x00148517
		// (set) Token: 0x060087DB RID: 34779 RVA: 0x0014A324 File Offset: 0x00148524
		public override long Position
		{
			get
			{
				return this._strategy.Position;
			}
			set
			{
				this._strategy.Position = value;
			}
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x060087DC RID: 34780 RVA: 0x0014A332 File Offset: 0x00148532
		internal override bool IsAsync
		{
			get
			{
				return this._strategy.IsAsync;
			}
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x060087DD RID: 34781 RVA: 0x0014A33F File Offset: 0x0014853F
		internal override string Name
		{
			get
			{
				return this._strategy.Name;
			}
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x060087DE RID: 34782 RVA: 0x0014A34C File Offset: 0x0014854C
		internal override SafeFileHandle SafeFileHandle
		{
			get
			{
				this._fileStream.Flush(false);
				return this._strategy.SafeFileHandle;
			}
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x060087DF RID: 34783 RVA: 0x0014A365 File Offset: 0x00148565
		internal override bool IsClosed
		{
			get
			{
				return this._strategy.IsClosed;
			}
		}

		// Token: 0x060087E0 RID: 34784 RVA: 0x0014A372 File Offset: 0x00148572
		internal override void Lock(long position, long length)
		{
			this._strategy.Lock(position, length);
		}

		// Token: 0x060087E1 RID: 34785 RVA: 0x0014A381 File Offset: 0x00148581
		internal override void Unlock(long position, long length)
		{
			this._strategy.Unlock(position, length);
		}

		// Token: 0x060087E2 RID: 34786 RVA: 0x0014A390 File Offset: 0x00148590
		public override long Seek(long offset, SeekOrigin origin)
		{
			return this._strategy.Seek(offset, origin);
		}

		// Token: 0x060087E3 RID: 34787 RVA: 0x0014A39F File Offset: 0x0014859F
		public override void SetLength(long value)
		{
			this._strategy.SetLength(value);
		}

		// Token: 0x060087E4 RID: 34788 RVA: 0x0014A3AD File Offset: 0x001485AD
		public override int ReadByte()
		{
			return this._strategy.ReadByte();
		}

		// Token: 0x060087E5 RID: 34789 RVA: 0x0014A3BA File Offset: 0x001485BA
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			if (!this._strategy.IsAsync)
			{
				return this._fileStream.BaseBeginRead(buffer, offset, count, callback, state);
			}
			return this._strategy.BeginRead(buffer, offset, count, callback, state);
		}

		// Token: 0x060087E6 RID: 34790 RVA: 0x0014A3EE File Offset: 0x001485EE
		public override int EndRead(IAsyncResult asyncResult)
		{
			if (!this._strategy.IsAsync)
			{
				return this._fileStream.BaseEndRead(asyncResult);
			}
			return this._strategy.EndRead(asyncResult);
		}

		// Token: 0x060087E7 RID: 34791 RVA: 0x0014A416 File Offset: 0x00148616
		public override int Read(byte[] buffer, int offset, int count)
		{
			return this._strategy.Read(buffer, offset, count);
		}

		// Token: 0x060087E8 RID: 34792 RVA: 0x0014A426 File Offset: 0x00148626
		public override int Read(Span<byte> buffer)
		{
			return this._fileStream.BaseRead(buffer);
		}

		// Token: 0x060087E9 RID: 34793 RVA: 0x0014A434 File Offset: 0x00148634
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return this._fileStream.BaseReadAsync(buffer, offset, count, cancellationToken);
		}

		// Token: 0x060087EA RID: 34794 RVA: 0x0014A446 File Offset: 0x00148646
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return this._fileStream.BaseReadAsync(buffer, cancellationToken);
		}

		// Token: 0x060087EB RID: 34795 RVA: 0x0014A455 File Offset: 0x00148655
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			if (!this._strategy.IsAsync)
			{
				return this._fileStream.BaseBeginWrite(buffer, offset, count, callback, state);
			}
			return this._strategy.BeginWrite(buffer, offset, count, callback, state);
		}

		// Token: 0x060087EC RID: 34796 RVA: 0x0014A489 File Offset: 0x00148689
		public override void EndWrite(IAsyncResult asyncResult)
		{
			if (this._strategy.IsAsync)
			{
				this._strategy.EndWrite(asyncResult);
				return;
			}
			this._fileStream.BaseEndWrite(asyncResult);
		}

		// Token: 0x060087ED RID: 34797 RVA: 0x0014A4B1 File Offset: 0x001486B1
		public override void WriteByte(byte value)
		{
			this._strategy.WriteByte(value);
		}

		// Token: 0x060087EE RID: 34798 RVA: 0x0014A4BF File Offset: 0x001486BF
		public override void Write(byte[] buffer, int offset, int count)
		{
			this._strategy.Write(buffer, offset, count);
		}

		// Token: 0x060087EF RID: 34799 RVA: 0x0014A4CF File Offset: 0x001486CF
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			this._fileStream.BaseWrite(buffer);
		}

		// Token: 0x060087F0 RID: 34800 RVA: 0x0014A4DD File Offset: 0x001486DD
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return this._fileStream.BaseWriteAsync(buffer, offset, count, cancellationToken);
		}

		// Token: 0x060087F1 RID: 34801 RVA: 0x0014A4EF File Offset: 0x001486EF
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return this._fileStream.BaseWriteAsync(buffer, cancellationToken);
		}

		// Token: 0x060087F2 RID: 34802 RVA: 0x0014A4FE File Offset: 0x001486FE
		public override void Flush()
		{
			throw new InvalidOperationException("FileStream should never call this method.");
		}

		// Token: 0x060087F3 RID: 34803 RVA: 0x0014A50A File Offset: 0x0014870A
		internal override void Flush(bool flushToDisk)
		{
			this._strategy.Flush(flushToDisk);
		}

		// Token: 0x060087F4 RID: 34804 RVA: 0x0014A518 File Offset: 0x00148718
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return this._fileStream.BaseFlushAsync(cancellationToken);
		}

		// Token: 0x060087F5 RID: 34805 RVA: 0x0014A526 File Offset: 0x00148726
		public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			return this._fileStream.BaseCopyToAsync(destination, bufferSize, cancellationToken);
		}

		// Token: 0x060087F6 RID: 34806 RVA: 0x0014A536 File Offset: 0x00148736
		public override ValueTask DisposeAsync()
		{
			return this._fileStream.BaseDisposeAsync();
		}

		// Token: 0x060087F7 RID: 34807 RVA: 0x0014A543 File Offset: 0x00148743
		protected sealed override void Dispose(bool disposing)
		{
			this._strategy.DisposeInternal(disposing);
		}

		// Token: 0x04001DB2 RID: 7602
		private readonly FileStreamStrategy _strategy;

		// Token: 0x04001DB3 RID: 7603
		private readonly FileStream _fileStream;
	}
}

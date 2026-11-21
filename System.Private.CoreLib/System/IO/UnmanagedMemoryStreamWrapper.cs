using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	// Token: 0x0200084E RID: 2126
	internal sealed class UnmanagedMemoryStreamWrapper : MemoryStream
	{
		// Token: 0x0600874E RID: 34638 RVA: 0x001470DC File Offset: 0x001452DC
		internal UnmanagedMemoryStreamWrapper(UnmanagedMemoryStream stream)
		{
			this._unmanagedStream = stream;
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x0600874F RID: 34639 RVA: 0x001470EB File Offset: 0x001452EB
		public override bool CanRead
		{
			get
			{
				return this._unmanagedStream.CanRead;
			}
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x06008750 RID: 34640 RVA: 0x001470F8 File Offset: 0x001452F8
		public override bool CanSeek
		{
			get
			{
				return this._unmanagedStream.CanSeek;
			}
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06008751 RID: 34641 RVA: 0x00147105 File Offset: 0x00145305
		public override bool CanWrite
		{
			get
			{
				return this._unmanagedStream.CanWrite;
			}
		}

		// Token: 0x06008752 RID: 34642 RVA: 0x00147114 File Offset: 0x00145314
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					this._unmanagedStream.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06008753 RID: 34643 RVA: 0x0014714C File Offset: 0x0014534C
		public override void Flush()
		{
			this._unmanagedStream.Flush();
		}

		// Token: 0x06008754 RID: 34644 RVA: 0x00147159 File Offset: 0x00145359
		public override byte[] GetBuffer()
		{
			throw new UnauthorizedAccessException(SR.UnauthorizedAccess_MemStreamBuffer);
		}

		// Token: 0x06008755 RID: 34645 RVA: 0x00147165 File Offset: 0x00145365
		public override bool TryGetBuffer(out ArraySegment<byte> buffer)
		{
			buffer = default(ArraySegment<byte>);
			return false;
		}

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x06008756 RID: 34646 RVA: 0x0014716F File Offset: 0x0014536F
		// (set) Token: 0x06008757 RID: 34647 RVA: 0x0014717D File Offset: 0x0014537D
		public override int Capacity
		{
			get
			{
				return (int)this._unmanagedStream.Capacity;
			}
			set
			{
				throw new IOException(SR.IO_FixedCapacity);
			}
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x06008758 RID: 34648 RVA: 0x00147189 File Offset: 0x00145389
		public override long Length
		{
			get
			{
				return this._unmanagedStream.Length;
			}
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x06008759 RID: 34649 RVA: 0x00147196 File Offset: 0x00145396
		// (set) Token: 0x0600875A RID: 34650 RVA: 0x001471A3 File Offset: 0x001453A3
		public override long Position
		{
			get
			{
				return this._unmanagedStream.Position;
			}
			set
			{
				this._unmanagedStream.Position = value;
			}
		}

		// Token: 0x0600875B RID: 34651 RVA: 0x001471B1 File Offset: 0x001453B1
		public override int Read(byte[] buffer, int offset, int count)
		{
			return this._unmanagedStream.Read(buffer, offset, count);
		}

		// Token: 0x0600875C RID: 34652 RVA: 0x001471C1 File Offset: 0x001453C1
		public override int Read(Span<byte> buffer)
		{
			return this._unmanagedStream.Read(buffer);
		}

		// Token: 0x0600875D RID: 34653 RVA: 0x001471CF File Offset: 0x001453CF
		public override int ReadByte()
		{
			return this._unmanagedStream.ReadByte();
		}

		// Token: 0x0600875E RID: 34654 RVA: 0x001471DC File Offset: 0x001453DC
		public override long Seek(long offset, SeekOrigin loc)
		{
			return this._unmanagedStream.Seek(offset, loc);
		}

		// Token: 0x0600875F RID: 34655 RVA: 0x001471EC File Offset: 0x001453EC
		public override byte[] ToArray()
		{
			byte[] array = new byte[this._unmanagedStream.Length];
			this._unmanagedStream.Read(array, 0, (int)this._unmanagedStream.Length);
			return array;
		}

		// Token: 0x06008760 RID: 34656 RVA: 0x00147226 File Offset: 0x00145426
		public override void Write(byte[] buffer, int offset, int count)
		{
			this._unmanagedStream.Write(buffer, offset, count);
		}

		// Token: 0x06008761 RID: 34657 RVA: 0x00147236 File Offset: 0x00145436
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			this._unmanagedStream.Write(buffer);
		}

		// Token: 0x06008762 RID: 34658 RVA: 0x00147244 File Offset: 0x00145444
		public override void WriteByte(byte value)
		{
			this._unmanagedStream.WriteByte(value);
		}

		// Token: 0x06008763 RID: 34659 RVA: 0x00147254 File Offset: 0x00145454
		public override void WriteTo(Stream stream)
		{
			ArgumentNullException.ThrowIfNull(stream, "stream");
			byte[] array = this.ToArray();
			stream.Write(array, 0, array.Length);
		}

		// Token: 0x06008764 RID: 34660 RVA: 0x0014727E File Offset: 0x0014547E
		public override void SetLength(long value)
		{
			base.SetLength(value);
		}

		// Token: 0x06008765 RID: 34661 RVA: 0x00147288 File Offset: 0x00145488
		public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			ArgumentNullException.ThrowIfNull(destination, "destination");
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero<int>(bufferSize, "bufferSize");
			if (!this.CanRead && !this.CanWrite)
			{
				ThrowHelper.ThrowObjectDisposedException_StreamClosed(null);
			}
			if (!destination.CanRead && !destination.CanWrite)
			{
				ThrowHelper.ThrowObjectDisposedException_StreamClosed("destination");
			}
			if (!this.CanRead)
			{
				ThrowHelper.ThrowNotSupportedException_UnreadableStream();
			}
			if (!destination.CanWrite)
			{
				ThrowHelper.ThrowNotSupportedException_UnwritableStream();
			}
			return this._unmanagedStream.CopyToAsync(destination, bufferSize, cancellationToken);
		}

		// Token: 0x06008766 RID: 34662 RVA: 0x00147303 File Offset: 0x00145503
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return this._unmanagedStream.FlushAsync(cancellationToken);
		}

		// Token: 0x06008767 RID: 34663 RVA: 0x00147311 File Offset: 0x00145511
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return this._unmanagedStream.ReadAsync(buffer, offset, count, cancellationToken);
		}

		// Token: 0x06008768 RID: 34664 RVA: 0x00147323 File Offset: 0x00145523
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return this._unmanagedStream.ReadAsync(buffer, cancellationToken);
		}

		// Token: 0x06008769 RID: 34665 RVA: 0x00147332 File Offset: 0x00145532
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return this._unmanagedStream.WriteAsync(buffer, offset, count, cancellationToken);
		}

		// Token: 0x0600876A RID: 34666 RVA: 0x00147344 File Offset: 0x00145544
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return this._unmanagedStream.WriteAsync(buffer, cancellationToken);
		}

		// Token: 0x04001D73 RID: 7539
		private readonly UnmanagedMemoryStream _unmanagedStream;
	}
}

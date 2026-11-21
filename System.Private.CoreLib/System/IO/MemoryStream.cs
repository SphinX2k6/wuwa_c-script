using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	// Token: 0x02000804 RID: 2052
	[NullableContext(1)]
	[Nullable(0)]
	public class MemoryStream : Stream
	{
		// Token: 0x06008342 RID: 33602 RVA: 0x00138DBA File Offset: 0x00136FBA
		public MemoryStream() : this(0)
		{
		}

		// Token: 0x06008343 RID: 33603 RVA: 0x00138DC4 File Offset: 0x00136FC4
		public MemoryStream(int capacity)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(capacity, "capacity");
			this._buffer = ((capacity != 0) ? new byte[capacity] : Array.Empty<byte>());
			this._capacity = capacity;
			this._expandable = true;
			this._writable = true;
			this._exposable = true;
			this._isOpen = true;
		}

		// Token: 0x06008344 RID: 33604 RVA: 0x00138E1B File Offset: 0x0013701B
		public MemoryStream(byte[] buffer) : this(buffer, true)
		{
		}

		// Token: 0x06008345 RID: 33605 RVA: 0x00138E28 File Offset: 0x00137028
		public MemoryStream(byte[] buffer, bool writable)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			this._buffer = buffer;
			this._length = (this._capacity = buffer.Length);
			this._writable = writable;
			this._isOpen = true;
		}

		// Token: 0x06008346 RID: 33606 RVA: 0x00138E6D File Offset: 0x0013706D
		public MemoryStream(byte[] buffer, int index, int count) : this(buffer, index, count, true, false)
		{
		}

		// Token: 0x06008347 RID: 33607 RVA: 0x00138E7A File Offset: 0x0013707A
		public MemoryStream(byte[] buffer, int index, int count, bool writable) : this(buffer, index, count, writable, false)
		{
		}

		// Token: 0x06008348 RID: 33608 RVA: 0x00138E88 File Offset: 0x00137088
		public MemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			this._buffer = buffer;
			this._position = index;
			this._origin = index;
			this._length = (this._capacity = index + count);
			this._writable = writable;
			this._exposable = publiclyVisible;
			this._isOpen = true;
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x06008349 RID: 33609 RVA: 0x00138F0F File Offset: 0x0013710F
		public override bool CanRead
		{
			get
			{
				return this._isOpen;
			}
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x0600834A RID: 33610 RVA: 0x00138F0F File Offset: 0x0013710F
		public override bool CanSeek
		{
			get
			{
				return this._isOpen;
			}
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x0600834B RID: 33611 RVA: 0x00138F17 File Offset: 0x00137117
		public override bool CanWrite
		{
			get
			{
				return this._writable;
			}
		}

		// Token: 0x0600834C RID: 33612 RVA: 0x00138F1F File Offset: 0x0013711F
		private void EnsureNotClosed()
		{
			if (!this._isOpen)
			{
				ThrowHelper.ThrowObjectDisposedException_StreamClosed(null);
			}
		}

		// Token: 0x0600834D RID: 33613 RVA: 0x00138F2F File Offset: 0x0013712F
		private void EnsureWriteable()
		{
			if (!this.CanWrite)
			{
				ThrowHelper.ThrowNotSupportedException_UnwritableStream();
			}
		}

		// Token: 0x0600834E RID: 33614 RVA: 0x00138F3E File Offset: 0x0013713E
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this._isOpen = false;
				this._writable = false;
				this._expandable = false;
				this._lastReadTask = default(CachedCompletedInt32Task);
			}
		}

		// Token: 0x0600834F RID: 33615 RVA: 0x00138F64 File Offset: 0x00137164
		private bool EnsureCapacity(int value)
		{
			if (value < 0)
			{
				throw new IOException(SR.IO_StreamTooLong);
			}
			if (value > this._capacity)
			{
				int num = Math.Max(value, 256);
				if (num < this._capacity * 2)
				{
					num = this._capacity * 2;
				}
				if ((ulong)(this._capacity * 2) > 2147483591UL)
				{
					num = Math.Max(value, 2147483591);
				}
				this.Capacity = num;
				return true;
			}
			return false;
		}

		// Token: 0x06008350 RID: 33616 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public override void Flush()
		{
		}

		// Token: 0x06008351 RID: 33617 RVA: 0x00138FD0 File Offset: 0x001371D0
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			Task result;
			try
			{
				this.Flush();
				result = Task.CompletedTask;
			}
			catch (Exception exception)
			{
				result = Task.FromException(exception);
			}
			return result;
		}

		// Token: 0x06008352 RID: 33618 RVA: 0x00139018 File Offset: 0x00137218
		public virtual byte[] GetBuffer()
		{
			if (!this._exposable)
			{
				throw new UnauthorizedAccessException(SR.UnauthorizedAccess_MemStreamBuffer);
			}
			return this._buffer;
		}

		// Token: 0x06008353 RID: 33619 RVA: 0x00139033 File Offset: 0x00137233
		[NullableContext(0)]
		public virtual bool TryGetBuffer(out ArraySegment<byte> buffer)
		{
			if (!this._exposable)
			{
				buffer = default(ArraySegment<byte>);
				return false;
			}
			buffer = new ArraySegment<byte>(this._buffer, this._origin, this._length - this._origin);
			return true;
		}

		// Token: 0x06008354 RID: 33620 RVA: 0x0013906B File Offset: 0x0013726B
		internal byte[] InternalGetBuffer()
		{
			return this._buffer;
		}

		// Token: 0x06008355 RID: 33621 RVA: 0x00139073 File Offset: 0x00137273
		internal int InternalGetPosition()
		{
			return this._position;
		}

		// Token: 0x06008356 RID: 33622 RVA: 0x0013907C File Offset: 0x0013727C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ReadOnlySpan<byte> InternalReadSpan(int count)
		{
			this.EnsureNotClosed();
			int position = this._position;
			int num = position + count;
			if (num > this._length)
			{
				this._position = this._length;
				ThrowHelper.ThrowEndOfFileException();
			}
			ReadOnlySpan<byte> result = new ReadOnlySpan<byte>(this._buffer, position, count);
			this._position = num;
			return result;
		}

		// Token: 0x06008357 RID: 33623 RVA: 0x001390C8 File Offset: 0x001372C8
		internal int InternalEmulateRead(int count)
		{
			this.EnsureNotClosed();
			int num = this._length - this._position;
			if (num > count)
			{
				num = count;
			}
			if (num < 0)
			{
				num = 0;
			}
			this._position += num;
			return num;
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x06008358 RID: 33624 RVA: 0x00139104 File Offset: 0x00137304
		// (set) Token: 0x06008359 RID: 33625 RVA: 0x0013911C File Offset: 0x0013731C
		public virtual int Capacity
		{
			get
			{
				this.EnsureNotClosed();
				return this._capacity - this._origin;
			}
			set
			{
				if ((long)value < this.Length)
				{
					throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_SmallCapacity);
				}
				this.EnsureNotClosed();
				if (!this._expandable && value != this.Capacity)
				{
					throw new NotSupportedException(SR.NotSupported_MemStreamNotExpandable);
				}
				if (this._expandable && value != this._capacity)
				{
					if (value > 0)
					{
						byte[] array = new byte[value];
						if (this._length > 0)
						{
							Buffer.BlockCopy(this._buffer, 0, array, 0, this._length);
						}
						this._buffer = array;
					}
					else
					{
						this._buffer = Array.Empty<byte>();
					}
					this._capacity = value;
				}
			}
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x0600835A RID: 33626 RVA: 0x001391B9 File Offset: 0x001373B9
		public override long Length
		{
			get
			{
				this.EnsureNotClosed();
				return (long)(this._length - this._origin);
			}
		}

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x0600835B RID: 33627 RVA: 0x001391CF File Offset: 0x001373CF
		// (set) Token: 0x0600835C RID: 33628 RVA: 0x001391E8 File Offset: 0x001373E8
		public override long Position
		{
			get
			{
				this.EnsureNotClosed();
				return (long)(this._position - this._origin);
			}
			set
			{
				ArgumentOutOfRangeException.ThrowIfNegative<long>(value, "value");
				this.EnsureNotClosed();
				if (value > (long)(2147483647 - this._origin))
				{
					throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_StreamLength);
				}
				this._position = this._origin + (int)value;
			}
		}

		// Token: 0x0600835D RID: 33629 RVA: 0x00139238 File Offset: 0x00137438
		public override int Read(byte[] buffer, int offset, int count)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			this.EnsureNotClosed();
			int num = this._length - this._position;
			if (num > count)
			{
				num = count;
			}
			if (num <= 0)
			{
				return 0;
			}
			if (num <= 8)
			{
				int num2 = num;
				while (--num2 >= 0)
				{
					buffer[offset + num2] = this._buffer[this._position + num2];
				}
			}
			else
			{
				Buffer.BlockCopy(this._buffer, this._position, buffer, offset, num);
			}
			this._position += num;
			return num;
		}

		// Token: 0x0600835E RID: 33630 RVA: 0x001392B8 File Offset: 0x001374B8
		[NullableContext(0)]
		public override int Read(Span<byte> buffer)
		{
			if (base.GetType() != typeof(MemoryStream))
			{
				return base.Read(buffer);
			}
			this.EnsureNotClosed();
			int num = Math.Min(this._length - this._position, buffer.Length);
			if (num <= 0)
			{
				return 0;
			}
			new Span<byte>(this._buffer, this._position, num).CopyTo(buffer);
			this._position += num;
			return num;
		}

		// Token: 0x0600835F RID: 33631 RVA: 0x00139334 File Offset: 0x00137534
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<int>(cancellationToken);
			}
			Task<int> result2;
			try
			{
				int result = this.Read(buffer, offset, count);
				result2 = this._lastReadTask.GetTask(result);
			}
			catch (OperationCanceledException exception)
			{
				result2 = Task.FromCanceled<int>(exception);
			}
			catch (Exception exception2)
			{
				result2 = Task.FromException<int>(exception2);
			}
			return result2;
		}

		// Token: 0x06008360 RID: 33632 RVA: 0x001393A4 File Offset: 0x001375A4
		[NullableContext(0)]
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return ValueTask.FromCanceled<int>(cancellationToken);
			}
			ValueTask<int> result;
			try
			{
				ArraySegment<byte> arraySegment;
				result = new ValueTask<int>(MemoryMarshal.TryGetArray<byte>(buffer, out arraySegment) ? this.Read(arraySegment.Array, arraySegment.Offset, arraySegment.Count) : this.Read(buffer.Span));
			}
			catch (OperationCanceledException exception)
			{
				result = new ValueTask<int>(Task.FromCanceled<int>(exception));
			}
			catch (Exception exception2)
			{
				result = ValueTask.FromException<int>(exception2);
			}
			return result;
		}

		// Token: 0x06008361 RID: 33633 RVA: 0x00139438 File Offset: 0x00137638
		public override int ReadByte()
		{
			this.EnsureNotClosed();
			if (this._position >= this._length)
			{
				return -1;
			}
			byte[] buffer = this._buffer;
			int position = this._position;
			this._position = position + 1;
			return buffer[position];
		}

		// Token: 0x06008362 RID: 33634 RVA: 0x00139474 File Offset: 0x00137674
		public override void CopyTo(Stream destination, int bufferSize)
		{
			if (base.GetType() != typeof(MemoryStream))
			{
				base.CopyTo(destination, bufferSize);
				return;
			}
			Stream.ValidateCopyToArguments(destination, bufferSize);
			this.EnsureNotClosed();
			int position = this._position;
			int num = this.InternalEmulateRead(this._length - position);
			if (num > 0)
			{
				destination.Write(this._buffer, position, num);
			}
		}

		// Token: 0x06008363 RID: 33635 RVA: 0x001394D8 File Offset: 0x001376D8
		public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			Stream.ValidateCopyToArguments(destination, bufferSize);
			this.EnsureNotClosed();
			if (base.GetType() != typeof(MemoryStream))
			{
				return base.CopyToAsync(destination, bufferSize, cancellationToken);
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			int position = this._position;
			int num = this.InternalEmulateRead(this._length - this._position);
			if (num == 0)
			{
				return Task.CompletedTask;
			}
			MemoryStream memoryStream = destination as MemoryStream;
			if (memoryStream == null)
			{
				return destination.WriteAsync(this._buffer, position, num, cancellationToken);
			}
			Task result;
			try
			{
				memoryStream.Write(this._buffer, position, num);
				result = Task.CompletedTask;
			}
			catch (Exception exception)
			{
				result = Task.FromException(exception);
			}
			return result;
		}

		// Token: 0x06008364 RID: 33636 RVA: 0x00139594 File Offset: 0x00137794
		public override long Seek(long offset, SeekOrigin loc)
		{
			this.EnsureNotClosed();
			int loc2;
			switch (loc)
			{
			case SeekOrigin.Begin:
				loc2 = this._origin;
				break;
			case SeekOrigin.Current:
				loc2 = this._position;
				break;
			case SeekOrigin.End:
				loc2 = this._length;
				break;
			default:
				throw new ArgumentException(SR.Argument_InvalidSeekOrigin);
			}
			return this.SeekCore(offset, loc2);
		}

		// Token: 0x06008365 RID: 33637 RVA: 0x001395EC File Offset: 0x001377EC
		private long SeekCore(long offset, int loc)
		{
			if (offset > (long)(2147483647 - loc))
			{
				throw new ArgumentOutOfRangeException("offset", SR.ArgumentOutOfRange_StreamLength);
			}
			int num = loc + (int)offset;
			if ((long)loc + offset < (long)this._origin || num < this._origin)
			{
				throw new IOException(SR.IO_SeekBeforeBegin);
			}
			this._position = num;
			return (long)(this._position - this._origin);
		}

		// Token: 0x06008366 RID: 33638 RVA: 0x00139650 File Offset: 0x00137850
		public override void SetLength(long value)
		{
			if (value < 0L || value > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_StreamLength);
			}
			this.EnsureWriteable();
			if (value > (long)(2147483647 - this._origin))
			{
				throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_StreamLength);
			}
			int num = this._origin + (int)value;
			if (!this.EnsureCapacity(num) && num > this._length)
			{
				Array.Clear(this._buffer, this._length, num - this._length);
			}
			this._length = num;
			if (this._position > num)
			{
				this._position = num;
			}
		}

		// Token: 0x06008367 RID: 33639 RVA: 0x001396F0 File Offset: 0x001378F0
		public virtual byte[] ToArray()
		{
			int num = this._length - this._origin;
			if (num == 0)
			{
				return Array.Empty<byte>();
			}
			byte[] array = GC.AllocateUninitializedArray<byte>(num, false);
			this._buffer.AsSpan(this._origin, num).CopyTo(array);
			return array;
		}

		// Token: 0x06008368 RID: 33640 RVA: 0x00139740 File Offset: 0x00137940
		public override void Write(byte[] buffer, int offset, int count)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			this.EnsureNotClosed();
			this.EnsureWriteable();
			int num = this._position + count;
			if (num < 0)
			{
				throw new IOException(SR.IO_StreamTooLong);
			}
			if (num > this._length)
			{
				bool flag = this._position > this._length;
				if (num > this._capacity && this.EnsureCapacity(num))
				{
					flag = false;
				}
				if (flag)
				{
					Array.Clear(this._buffer, this._length, num - this._length);
				}
				this._length = num;
			}
			if (count <= 8 && buffer != this._buffer)
			{
				int num2 = count;
				while (--num2 >= 0)
				{
					this._buffer[this._position + num2] = buffer[offset + num2];
				}
			}
			else
			{
				Buffer.BlockCopy(buffer, offset, this._buffer, this._position, count);
			}
			this._position = num;
		}

		// Token: 0x06008369 RID: 33641 RVA: 0x00139814 File Offset: 0x00137A14
		[NullableContext(0)]
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			if (base.GetType() != typeof(MemoryStream))
			{
				base.Write(buffer);
				return;
			}
			this.EnsureNotClosed();
			this.EnsureWriteable();
			int num = this._position + buffer.Length;
			if (num < 0)
			{
				throw new IOException(SR.IO_StreamTooLong);
			}
			if (num > this._length)
			{
				bool flag = this._position > this._length;
				if (num > this._capacity && this.EnsureCapacity(num))
				{
					flag = false;
				}
				if (flag)
				{
					Array.Clear(this._buffer, this._length, num - this._length);
				}
				this._length = num;
			}
			buffer.CopyTo(new Span<byte>(this._buffer, this._position, buffer.Length));
			this._position = num;
		}

		// Token: 0x0600836A RID: 33642 RVA: 0x001398E0 File Offset: 0x00137AE0
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			Task result;
			try
			{
				this.Write(buffer, offset, count);
				result = Task.CompletedTask;
			}
			catch (OperationCanceledException exception)
			{
				result = Task.FromCanceled(exception);
			}
			catch (Exception exception2)
			{
				result = Task.FromException(exception2);
			}
			return result;
		}

		// Token: 0x0600836B RID: 33643 RVA: 0x00139948 File Offset: 0x00137B48
		[NullableContext(0)]
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return ValueTask.FromCanceled(cancellationToken);
			}
			ValueTask valueTask;
			try
			{
				ArraySegment<byte> arraySegment;
				if (MemoryMarshal.TryGetArray<byte>(buffer, out arraySegment))
				{
					this.Write(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
				}
				else
				{
					this.Write(buffer.Span);
				}
				valueTask = default(ValueTask);
				valueTask = valueTask;
			}
			catch (OperationCanceledException exception)
			{
				valueTask = new ValueTask(Task.FromCanceled(exception));
			}
			catch (Exception exception2)
			{
				valueTask = ValueTask.FromException(exception2);
			}
			return valueTask;
		}

		// Token: 0x0600836C RID: 33644 RVA: 0x001399D8 File Offset: 0x00137BD8
		public override void WriteByte(byte value)
		{
			this.EnsureNotClosed();
			this.EnsureWriteable();
			if (this._position >= this._length)
			{
				int num = this._position + 1;
				bool flag = this._position > this._length;
				if (num >= this._capacity && this.EnsureCapacity(num))
				{
					flag = false;
				}
				if (flag)
				{
					Array.Clear(this._buffer, this._length, this._position - this._length);
				}
				this._length = num;
			}
			byte[] buffer = this._buffer;
			int position = this._position;
			this._position = position + 1;
			buffer[position] = value;
		}

		// Token: 0x0600836D RID: 33645 RVA: 0x00139A6C File Offset: 0x00137C6C
		public virtual void WriteTo(Stream stream)
		{
			ArgumentNullException.ThrowIfNull(stream, "stream");
			this.EnsureNotClosed();
			stream.Write(this._buffer, this._origin, this._length - this._origin);
		}

		// Token: 0x04001BC9 RID: 7113
		private byte[] _buffer;

		// Token: 0x04001BCA RID: 7114
		private readonly int _origin;

		// Token: 0x04001BCB RID: 7115
		private int _position;

		// Token: 0x04001BCC RID: 7116
		private int _length;

		// Token: 0x04001BCD RID: 7117
		private int _capacity;

		// Token: 0x04001BCE RID: 7118
		private bool _expandable;

		// Token: 0x04001BCF RID: 7119
		private bool _writable;

		// Token: 0x04001BD0 RID: 7120
		private readonly bool _exposable;

		// Token: 0x04001BD1 RID: 7121
		private bool _isOpen;

		// Token: 0x04001BD2 RID: 7122
		private CachedCompletedInt32Task _lastReadTask;
	}
}

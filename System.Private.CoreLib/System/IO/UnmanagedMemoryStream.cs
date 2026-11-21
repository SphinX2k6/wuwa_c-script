using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	// Token: 0x0200084D RID: 2125
	public class UnmanagedMemoryStream : Stream
	{
		// Token: 0x0600872A RID: 34602 RVA: 0x0013D7C9 File Offset: 0x0013B9C9
		protected UnmanagedMemoryStream()
		{
		}

		// Token: 0x0600872B RID: 34603 RVA: 0x001466B4 File Offset: 0x001448B4
		[NullableContext(1)]
		public UnmanagedMemoryStream(SafeBuffer buffer, long offset, long length)
		{
			this.Initialize(buffer, offset, length, FileAccess.Read);
		}

		// Token: 0x0600872C RID: 34604 RVA: 0x001466C6 File Offset: 0x001448C6
		[NullableContext(1)]
		public UnmanagedMemoryStream(SafeBuffer buffer, long offset, long length, FileAccess access)
		{
			this.Initialize(buffer, offset, length, access);
		}

		// Token: 0x0600872D RID: 34605 RVA: 0x001466DC File Offset: 0x001448DC
		[NullableContext(1)]
		protected unsafe void Initialize(SafeBuffer buffer, long offset, long length, FileAccess access)
		{
			ArgumentNullException.ThrowIfNull(buffer, "buffer");
			ArgumentOutOfRangeException.ThrowIfNegative<long>(offset, "offset");
			ArgumentOutOfRangeException.ThrowIfNegative<long>(length, "length");
			if (buffer.ByteLength < (ulong)(offset + length))
			{
				throw new ArgumentException(SR.Argument_InvalidSafeBufferOffLen);
			}
			if (access < FileAccess.Read || access > FileAccess.ReadWrite)
			{
				throw new ArgumentOutOfRangeException("access");
			}
			if (this._isOpen)
			{
				throw new InvalidOperationException(SR.InvalidOperation_CalledTwice);
			}
			byte* ptr = null;
			try
			{
				buffer.AcquirePointer(ref ptr);
				if (ptr + offset + length < ptr)
				{
					throw new ArgumentException(SR.ArgumentOutOfRange_UnmanagedMemStreamWrapAround);
				}
			}
			finally
			{
				if (ptr != null)
				{
					buffer.ReleasePointer();
				}
			}
			this._offset = (UIntPtr)offset;
			this._buffer = buffer;
			this._length = (UIntPtr)length;
			this._capacity = (UIntPtr)length;
			this._access = access;
			this._isOpen = true;
		}

		// Token: 0x0600872E RID: 34606 RVA: 0x001467B4 File Offset: 0x001449B4
		[CLSCompliant(false)]
		public unsafe UnmanagedMemoryStream(byte* pointer, long length)
		{
			this.Initialize(pointer, length, length, FileAccess.Read);
		}

		// Token: 0x0600872F RID: 34607 RVA: 0x001467C6 File Offset: 0x001449C6
		[CLSCompliant(false)]
		public unsafe UnmanagedMemoryStream(byte* pointer, long length, long capacity, FileAccess access)
		{
			this.Initialize(pointer, length, capacity, access);
		}

		// Token: 0x06008730 RID: 34608 RVA: 0x001467DC File Offset: 0x001449DC
		[CLSCompliant(false)]
		protected unsafe void Initialize(byte* pointer, long length, long capacity, FileAccess access)
		{
			ArgumentNullException.ThrowIfNull((void*)pointer, "pointer");
			ArgumentOutOfRangeException.ThrowIfNegative<long>(length, "length");
			ArgumentOutOfRangeException.ThrowIfNegative<long>(capacity, "capacity");
			if (length > capacity)
			{
				throw new ArgumentOutOfRangeException("length", SR.ArgumentOutOfRange_LengthGreaterThanCapacity);
			}
			if (pointer + capacity < pointer)
			{
				throw new ArgumentOutOfRangeException("capacity", SR.ArgumentOutOfRange_UnmanagedMemStreamWrapAround);
			}
			if (access < FileAccess.Read || access > FileAccess.ReadWrite)
			{
				throw new ArgumentOutOfRangeException("access", SR.ArgumentOutOfRange_Enum);
			}
			if (this._isOpen)
			{
				throw new InvalidOperationException(SR.InvalidOperation_CalledTwice);
			}
			this._mem = pointer;
			this._offset = (UIntPtr)((IntPtr)0);
			this._length = (UIntPtr)length;
			this._capacity = (UIntPtr)capacity;
			this._access = access;
			this._isOpen = true;
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06008731 RID: 34609 RVA: 0x00146891 File Offset: 0x00144A91
		public override bool CanRead
		{
			get
			{
				return this._isOpen && (this._access & FileAccess.Read) > (FileAccess)0;
			}
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06008732 RID: 34610 RVA: 0x001468A8 File Offset: 0x00144AA8
		public override bool CanSeek
		{
			get
			{
				return this._isOpen;
			}
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x06008733 RID: 34611 RVA: 0x001468B0 File Offset: 0x00144AB0
		public override bool CanWrite
		{
			get
			{
				return this._isOpen && (this._access & FileAccess.Write) > (FileAccess)0;
			}
		}

		// Token: 0x06008734 RID: 34612 RVA: 0x001468C7 File Offset: 0x00144AC7
		protected override void Dispose(bool disposing)
		{
			this._isOpen = false;
			this._mem = null;
			base.Dispose(disposing);
		}

		// Token: 0x06008735 RID: 34613 RVA: 0x001468DF File Offset: 0x00144ADF
		private void EnsureNotClosed()
		{
			if (!this._isOpen)
			{
				ThrowHelper.ThrowObjectDisposedException_StreamClosed(null);
			}
		}

		// Token: 0x06008736 RID: 34614 RVA: 0x001468EF File Offset: 0x00144AEF
		private void EnsureReadable()
		{
			if (!this.CanRead)
			{
				ThrowHelper.ThrowNotSupportedException_UnreadableStream();
			}
		}

		// Token: 0x06008737 RID: 34615 RVA: 0x00138F2F File Offset: 0x0013712F
		private void EnsureWriteable()
		{
			if (!this.CanWrite)
			{
				ThrowHelper.ThrowNotSupportedException_UnwritableStream();
			}
		}

		// Token: 0x06008738 RID: 34616 RVA: 0x001468FE File Offset: 0x00144AFE
		public override void Flush()
		{
			this.EnsureNotClosed();
		}

		// Token: 0x06008739 RID: 34617 RVA: 0x00146908 File Offset: 0x00144B08
		[NullableContext(1)]
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

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x0600873A RID: 34618 RVA: 0x00146950 File Offset: 0x00144B50
		public override long Length
		{
			get
			{
				this.EnsureNotClosed();
				return (long)((ulong)this._length);
			}
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x0600873B RID: 34619 RVA: 0x0014695F File Offset: 0x00144B5F
		public long Capacity
		{
			get
			{
				this.EnsureNotClosed();
				return (long)((ulong)this._capacity);
			}
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x0600873C RID: 34620 RVA: 0x0014696E File Offset: 0x00144B6E
		// (set) Token: 0x0600873D RID: 34621 RVA: 0x00146984 File Offset: 0x00144B84
		public override long Position
		{
			get
			{
				if (!this.CanSeek)
				{
					ThrowHelper.ThrowObjectDisposedException_StreamClosed(null);
				}
				return this._position;
			}
			set
			{
				ArgumentOutOfRangeException.ThrowIfNegative<long>(value, "value");
				if (!this.CanSeek)
				{
					ThrowHelper.ThrowObjectDisposedException_StreamClosed(null);
				}
				this._position = value;
			}
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x0600873E RID: 34622 RVA: 0x001469A8 File Offset: 0x00144BA8
		// (set) Token: 0x0600873F RID: 34623 RVA: 0x001469F4 File Offset: 0x00144BF4
		[CLSCompliant(false)]
		public unsafe byte* PositionPointer
		{
			get
			{
				if (this._buffer != null)
				{
					throw new NotSupportedException(SR.NotSupported_UmsSafeBuffer);
				}
				this.EnsureNotClosed();
				long position = this._position;
				if (position > (long)((ulong)this._capacity))
				{
					throw new IndexOutOfRangeException(SR.IndexOutOfRange_UMSPosition);
				}
				return this._mem + position;
			}
			set
			{
				if (this._buffer != null)
				{
					throw new NotSupportedException(SR.NotSupported_UmsSafeBuffer);
				}
				this.EnsureNotClosed();
				if (value < this._mem)
				{
					throw new IOException(SR.IO_SeekBeforeBegin);
				}
				long num = (long)(value - this._mem);
				if (num < 0L)
				{
					throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_UnmanagedMemStreamLength);
				}
				this._position = num;
			}
		}

		// Token: 0x06008740 RID: 34624 RVA: 0x00146A55 File Offset: 0x00144C55
		[NullableContext(1)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			return this.ReadCore(new Span<byte>(buffer, offset, count));
		}

		// Token: 0x06008741 RID: 34625 RVA: 0x00146A6D File Offset: 0x00144C6D
		public override int Read(Span<byte> buffer)
		{
			if (base.GetType() == typeof(UnmanagedMemoryStream))
			{
				return this.ReadCore(buffer);
			}
			return base.Read(buffer);
		}

		// Token: 0x06008742 RID: 34626 RVA: 0x00146A98 File Offset: 0x00144C98
		internal unsafe int ReadCore(Span<byte> buffer)
		{
			this.EnsureNotClosed();
			this.EnsureReadable();
			long position = this._position;
			long num = Math.Min((long)((ulong)Volatile.Read(ref this._length) - (ulong)position), (long)buffer.Length);
			if (num <= 0L)
			{
				return 0;
			}
			int num2 = (int)num;
			if (num2 < 0)
			{
				return 0;
			}
			if (this._buffer != null)
			{
				byte* ptr = null;
				try
				{
					this._buffer.AcquirePointer(ref ptr);
					SpanHelpers.Memmove(MemoryMarshal.GetReference<byte>(buffer), ref (ptr + position)[(ulong)this._offset], (UIntPtr)((IntPtr)num2));
					goto IL_9A;
				}
				finally
				{
					if (ptr != null)
					{
						this._buffer.ReleasePointer();
					}
				}
			}
			SpanHelpers.Memmove(MemoryMarshal.GetReference<byte>(buffer), ref this._mem[position], (UIntPtr)((IntPtr)num2));
			IL_9A:
			this._position = position + num;
			return num2;
		}

		// Token: 0x06008743 RID: 34627 RVA: 0x00146B5C File Offset: 0x00144D5C
		[NullableContext(1)]
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
			catch (Exception exception)
			{
				result2 = Task.FromException<int>(exception);
			}
			return result2;
		}

		// Token: 0x06008744 RID: 34628 RVA: 0x00146BB8 File Offset: 0x00144DB8
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
			catch (Exception exception)
			{
				result = ValueTask.FromException<int>(exception);
			}
			return result;
		}

		// Token: 0x06008745 RID: 34629 RVA: 0x00146C30 File Offset: 0x00144E30
		public unsafe override int ReadByte()
		{
			this.EnsureNotClosed();
			this.EnsureReadable();
			long position = this._position;
			long num = (long)((ulong)Volatile.Read(ref this._length));
			if (position >= num)
			{
				return -1;
			}
			this._position = position + 1L;
			if (this._buffer != null)
			{
				byte* ptr = null;
				try
				{
					this._buffer.AcquirePointer(ref ptr);
					return (int)(ptr + position)[(ulong)this._offset];
				}
				finally
				{
					if (ptr != null)
					{
						this._buffer.ReleasePointer();
					}
				}
			}
			return (int)this._mem[position];
		}

		// Token: 0x06008746 RID: 34630 RVA: 0x00146CC4 File Offset: 0x00144EC4
		public override long Seek(long offset, SeekOrigin loc)
		{
			this.EnsureNotClosed();
			long num;
			switch (loc)
			{
			case SeekOrigin.Begin:
				num = offset;
				if (num < 0L)
				{
					throw new IOException(SR.IO_SeekBeforeBegin);
				}
				break;
			case SeekOrigin.Current:
				num = this._position + offset;
				if (num < 0L)
				{
					throw new IOException(SR.IO_SeekBeforeBegin);
				}
				break;
			case SeekOrigin.End:
				num = (long)((ulong)this._length + (ulong)offset);
				if (num < 0L)
				{
					throw new IOException(SR.IO_SeekBeforeBegin);
				}
				break;
			default:
				throw new ArgumentException(SR.Argument_InvalidSeekOrigin);
			}
			this._position = num;
			return num;
		}

		// Token: 0x06008747 RID: 34631 RVA: 0x00146D44 File Offset: 0x00144F44
		public unsafe override void SetLength(long value)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<long>(value, "value");
			if (this._buffer != null)
			{
				throw new NotSupportedException(SR.NotSupported_UmsSafeBuffer);
			}
			this.EnsureNotClosed();
			this.EnsureWriteable();
			if (value > (long)((ulong)this._capacity))
			{
				throw new IOException(SR.IO_FixedCapacity);
			}
			long num = (long)((ulong)this._length);
			if (value > num)
			{
				NativeMemory.Clear((void*)(this._mem + num), (UIntPtr)(value - num));
			}
			Volatile.Write(ref this._length, (UIntPtr)value);
			if (this._position > value)
			{
				this._position = value;
			}
		}

		// Token: 0x06008748 RID: 34632 RVA: 0x00146DCB File Offset: 0x00144FCB
		[NullableContext(1)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			this.WriteCore(new ReadOnlySpan<byte>(buffer, offset, count));
		}

		// Token: 0x06008749 RID: 34633 RVA: 0x00146DE3 File Offset: 0x00144FE3
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			if (base.GetType() == typeof(UnmanagedMemoryStream))
			{
				this.WriteCore(buffer);
				return;
			}
			base.Write(buffer);
		}

		// Token: 0x0600874A RID: 34634 RVA: 0x00146E0C File Offset: 0x0014500C
		internal unsafe void WriteCore(ReadOnlySpan<byte> buffer)
		{
			this.EnsureNotClosed();
			this.EnsureWriteable();
			long position = this._position;
			long num = (long)((ulong)this._length);
			long num2 = position + (long)buffer.Length;
			if (num2 < 0L)
			{
				throw new IOException(SR.IO_StreamTooLong);
			}
			if (num2 > (long)((ulong)this._capacity))
			{
				throw new NotSupportedException(SR.IO_FixedCapacity);
			}
			if (this._buffer == null)
			{
				if (position > num)
				{
					NativeMemory.Clear((void*)(this._mem + num), (UIntPtr)(position - num));
				}
				if (num2 > num)
				{
					Volatile.Write(ref this._length, (UIntPtr)num2);
				}
			}
			if (this._buffer != null)
			{
				if ((ulong)this._capacity - (ulong)position < (ulong)((long)buffer.Length))
				{
					throw new ArgumentException(SR.Arg_BufferTooSmall);
				}
				byte* ptr = null;
				try
				{
					this._buffer.AcquirePointer(ref ptr);
					SpanHelpers.Memmove(ref (ptr + position)[(ulong)this._offset], MemoryMarshal.GetReference<byte>(buffer), (UIntPtr)((IntPtr)buffer.Length));
					goto IL_FF;
				}
				finally
				{
					if (ptr != null)
					{
						this._buffer.ReleasePointer();
					}
				}
			}
			SpanHelpers.Memmove(ref this._mem[position], MemoryMarshal.GetReference<byte>(buffer), (UIntPtr)((IntPtr)buffer.Length));
			IL_FF:
			this._position = num2;
		}

		// Token: 0x0600874B RID: 34635 RVA: 0x00146F30 File Offset: 0x00145130
		[NullableContext(1)]
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
			catch (Exception exception)
			{
				result = Task.FromException(exception);
			}
			return result;
		}

		// Token: 0x0600874C RID: 34636 RVA: 0x00146F84 File Offset: 0x00145184
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
			catch (Exception exception)
			{
				valueTask = ValueTask.FromException(exception);
			}
			return valueTask;
		}

		// Token: 0x0600874D RID: 34637 RVA: 0x00146FFC File Offset: 0x001451FC
		public unsafe override void WriteByte(byte value)
		{
			this.EnsureNotClosed();
			this.EnsureWriteable();
			long position = this._position;
			long num = (long)((ulong)this._length);
			long num2 = position + 1L;
			if (position >= num)
			{
				if (num2 < 0L)
				{
					throw new IOException(SR.IO_StreamTooLong);
				}
				if (num2 > (long)((ulong)this._capacity))
				{
					throw new NotSupportedException(SR.IO_FixedCapacity);
				}
				if (this._buffer == null)
				{
					if (position > num)
					{
						NativeMemory.Clear((void*)(this._mem + num), (UIntPtr)(position - num));
					}
					Volatile.Write(ref this._length, (UIntPtr)num2);
				}
			}
			if (this._buffer != null)
			{
				byte* ptr = null;
				try
				{
					this._buffer.AcquirePointer(ref ptr);
					(ptr + position)[(ulong)this._offset] = value;
					goto IL_B9;
				}
				finally
				{
					if (ptr != null)
					{
						this._buffer.ReleasePointer();
					}
				}
			}
			this._mem[position] = value;
			IL_B9:
			this._position = num2;
		}

		// Token: 0x04001D6A RID: 7530
		private SafeBuffer _buffer;

		// Token: 0x04001D6B RID: 7531
		private unsafe byte* _mem;

		// Token: 0x04001D6C RID: 7532
		private UIntPtr _capacity;

		// Token: 0x04001D6D RID: 7533
		private UIntPtr _offset;

		// Token: 0x04001D6E RID: 7534
		private UIntPtr _length;

		// Token: 0x04001D6F RID: 7535
		private long _position;

		// Token: 0x04001D70 RID: 7536
		private FileAccess _access;

		// Token: 0x04001D71 RID: 7537
		private bool _isOpen;

		// Token: 0x04001D72 RID: 7538
		private CachedCompletedInt32Task _lastReadTask;
	}
}

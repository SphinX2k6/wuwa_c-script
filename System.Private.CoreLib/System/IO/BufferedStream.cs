using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	// Token: 0x020007DA RID: 2010
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class BufferedStream : Stream
	{
		// Token: 0x060080F8 RID: 33016 RVA: 0x001311D5 File Offset: 0x0012F3D5
		public BufferedStream(Stream stream) : this(stream, 4096)
		{
		}

		// Token: 0x060080F9 RID: 33017 RVA: 0x001311E4 File Offset: 0x0012F3E4
		public BufferedStream(Stream stream, int bufferSize)
		{
			if (stream == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.stream);
			}
			if (bufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize", SR.Format(SR.ArgumentOutOfRange_MustBePositive, "bufferSize"));
			}
			this._stream = stream;
			this._bufferSize = bufferSize;
			if (!this._stream.CanRead && !this._stream.CanWrite)
			{
				ThrowHelper.ThrowObjectDisposedException_StreamClosed(null);
			}
		}

		// Token: 0x060080FA RID: 33018 RVA: 0x0013124D File Offset: 0x0012F44D
		private void EnsureNotClosed()
		{
			if (this._stream == null)
			{
				ThrowHelper.ThrowObjectDisposedException_StreamClosed(null);
			}
		}

		// Token: 0x060080FB RID: 33019 RVA: 0x0013125D File Offset: 0x0012F45D
		private void EnsureCanSeek()
		{
			if (!this._stream.CanSeek)
			{
				ThrowHelper.ThrowNotSupportedException_UnseekableStream();
			}
		}

		// Token: 0x060080FC RID: 33020 RVA: 0x00131271 File Offset: 0x0012F471
		private void EnsureCanRead()
		{
			if (!this._stream.CanRead)
			{
				ThrowHelper.ThrowNotSupportedException_UnreadableStream();
			}
		}

		// Token: 0x060080FD RID: 33021 RVA: 0x00131285 File Offset: 0x0012F485
		private void EnsureCanWrite()
		{
			if (!this._stream.CanWrite)
			{
				ThrowHelper.ThrowNotSupportedException_UnwritableStream();
			}
		}

		// Token: 0x060080FE RID: 33022 RVA: 0x0013129C File Offset: 0x0012F49C
		private void EnsureShadowBufferAllocated()
		{
			if (this._buffer.Length != this._bufferSize || this._bufferSize >= 81920)
			{
				return;
			}
			byte[] array = new byte[Math.Min(this._bufferSize + this._bufferSize, 81920)];
			Buffer.BlockCopy(this._buffer, 0, array, 0, this._writePos);
			this._buffer = array;
		}

		// Token: 0x060080FF RID: 33023 RVA: 0x001312FF File Offset: 0x0012F4FF
		[MemberNotNull("_buffer")]
		private void EnsureBufferAllocated()
		{
			if (this._buffer == null)
			{
				this._buffer = new byte[this._bufferSize];
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x06008100 RID: 33024 RVA: 0x0013131A File Offset: 0x0012F51A
		public Stream UnderlyingStream
		{
			get
			{
				return this._stream;
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x06008101 RID: 33025 RVA: 0x00131322 File Offset: 0x0012F522
		public int BufferSize
		{
			get
			{
				return this._bufferSize;
			}
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x06008102 RID: 33026 RVA: 0x0013132A File Offset: 0x0012F52A
		public override bool CanRead
		{
			get
			{
				return this._stream != null && this._stream.CanRead;
			}
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x06008103 RID: 33027 RVA: 0x00131341 File Offset: 0x0012F541
		public override bool CanWrite
		{
			get
			{
				return this._stream != null && this._stream.CanWrite;
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x06008104 RID: 33028 RVA: 0x00131358 File Offset: 0x0012F558
		public override bool CanSeek
		{
			get
			{
				return this._stream != null && this._stream.CanSeek;
			}
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x06008105 RID: 33029 RVA: 0x0013136F File Offset: 0x0012F56F
		public override long Length
		{
			get
			{
				this.EnsureNotClosed();
				if (this._writePos > 0)
				{
					this.FlushWrite();
				}
				return this._stream.Length;
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06008106 RID: 33030 RVA: 0x00131391 File Offset: 0x0012F591
		// (set) Token: 0x06008107 RID: 33031 RVA: 0x001313C0 File Offset: 0x0012F5C0
		public override long Position
		{
			get
			{
				this.EnsureNotClosed();
				this.EnsureCanSeek();
				return this._stream.Position + (long)(this._readPos - this._readLen + this._writePos);
			}
			set
			{
				if (value < 0L)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
				}
				this.Seek(value, SeekOrigin.Begin);
			}
		}

		// Token: 0x06008108 RID: 33032 RVA: 0x001313D8 File Offset: 0x0012F5D8
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this._stream != null)
				{
					try
					{
						this.Flush();
					}
					finally
					{
						this._stream.Dispose();
					}
				}
			}
			finally
			{
				this._stream = null;
				this._buffer = null;
				this._writePos = 0;
				base.Dispose(disposing);
			}
		}

		// Token: 0x06008109 RID: 33033 RVA: 0x00131440 File Offset: 0x0012F640
		public override ValueTask DisposeAsync()
		{
			BufferedStream.<DisposeAsync>d__33 <DisposeAsync>d__;
			<DisposeAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder.Create();
			<DisposeAsync>d__.<>4__this = this;
			<DisposeAsync>d__.<>1__state = -1;
			<DisposeAsync>d__.<>t__builder.Start<BufferedStream.<DisposeAsync>d__33>(ref <DisposeAsync>d__);
			return <DisposeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600810A RID: 33034 RVA: 0x00131484 File Offset: 0x0012F684
		public override void Flush()
		{
			this.EnsureNotClosed();
			if (this._writePos > 0)
			{
				this.FlushWrite();
				return;
			}
			if (this._readPos < this._readLen)
			{
				if (this._stream.CanSeek)
				{
					this.FlushRead();
				}
				if (this._stream.CanWrite)
				{
					this._stream.Flush();
				}
				return;
			}
			if (this._stream.CanWrite)
			{
				this._stream.Flush();
			}
			this._writePos = (this._readPos = (this._readLen = 0));
		}

		// Token: 0x0600810B RID: 33035 RVA: 0x00131512 File Offset: 0x0012F712
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<int>(cancellationToken);
			}
			this.EnsureNotClosed();
			return this.FlushAsyncInternal(cancellationToken);
		}

		// Token: 0x0600810C RID: 33036 RVA: 0x00131534 File Offset: 0x0012F734
		private Task FlushAsyncInternal(CancellationToken cancellationToken)
		{
			BufferedStream.<FlushAsyncInternal>d__36 <FlushAsyncInternal>d__;
			<FlushAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FlushAsyncInternal>d__.<>4__this = this;
			<FlushAsyncInternal>d__.cancellationToken = cancellationToken;
			<FlushAsyncInternal>d__.<>1__state = -1;
			<FlushAsyncInternal>d__.<>t__builder.Start<BufferedStream.<FlushAsyncInternal>d__36>(ref <FlushAsyncInternal>d__);
			return <FlushAsyncInternal>d__.<>t__builder.Task;
		}

		// Token: 0x0600810D RID: 33037 RVA: 0x0013157F File Offset: 0x0012F77F
		private void FlushRead()
		{
			if (this._readPos - this._readLen != 0)
			{
				this._stream.Seek((long)(this._readPos - this._readLen), SeekOrigin.Current);
			}
			this._readPos = 0;
			this._readLen = 0;
		}

		// Token: 0x0600810E RID: 33038 RVA: 0x001315BC File Offset: 0x0012F7BC
		private void ClearReadBufferBeforeWrite()
		{
			if (this._readPos == this._readLen)
			{
				this._readPos = (this._readLen = 0);
				return;
			}
			if (!this._stream.CanSeek)
			{
				throw new NotSupportedException(SR.NotSupported_CannotWriteToBufferedStreamIfReadBufferCannotBeFlushed);
			}
			this.FlushRead();
		}

		// Token: 0x0600810F RID: 33039 RVA: 0x00131606 File Offset: 0x0012F806
		private void FlushWrite()
		{
			this._stream.Write(this._buffer, 0, this._writePos);
			this._writePos = 0;
			this._stream.Flush();
		}

		// Token: 0x06008110 RID: 33040 RVA: 0x00131634 File Offset: 0x0012F834
		private ValueTask FlushWriteAsync(CancellationToken cancellationToken)
		{
			BufferedStream.<FlushWriteAsync>d__40 <FlushWriteAsync>d__;
			<FlushWriteAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder.Create();
			<FlushWriteAsync>d__.<>4__this = this;
			<FlushWriteAsync>d__.cancellationToken = cancellationToken;
			<FlushWriteAsync>d__.<>1__state = -1;
			<FlushWriteAsync>d__.<>t__builder.Start<BufferedStream.<FlushWriteAsync>d__40>(ref <FlushWriteAsync>d__);
			return <FlushWriteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06008111 RID: 33041 RVA: 0x00131680 File Offset: 0x0012F880
		private int ReadFromBuffer(byte[] buffer, int offset, int count)
		{
			int num = this._readLen - this._readPos;
			if (num == 0)
			{
				return 0;
			}
			if (num > count)
			{
				num = count;
			}
			Buffer.BlockCopy(this._buffer, this._readPos, buffer, offset, num);
			this._readPos += num;
			return num;
		}

		// Token: 0x06008112 RID: 33042 RVA: 0x001316CC File Offset: 0x0012F8CC
		private int ReadFromBuffer(Span<byte> destination)
		{
			int num = Math.Min(this._readLen - this._readPos, destination.Length);
			if (num > 0)
			{
				new ReadOnlySpan<byte>(this._buffer, this._readPos, num).CopyTo(destination);
				this._readPos += num;
			}
			return num;
		}

		// Token: 0x06008113 RID: 33043 RVA: 0x00131724 File Offset: 0x0012F924
		private int ReadFromBuffer(byte[] buffer, int offset, int count, out Exception error)
		{
			int result;
			try
			{
				error = null;
				result = this.ReadFromBuffer(buffer, offset, count);
			}
			catch (Exception ex)
			{
				error = ex;
				result = 0;
			}
			return result;
		}

		// Token: 0x06008114 RID: 33044 RVA: 0x0013175C File Offset: 0x0012F95C
		public override int Read(byte[] buffer, int offset, int count)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			this.EnsureNotClosed();
			this.EnsureCanRead();
			int num = this.ReadFromBuffer(buffer, offset, count);
			if (num == count)
			{
				return num;
			}
			int num2 = num;
			if (num > 0)
			{
				count -= num;
				offset += num;
			}
			this._readPos = (this._readLen = 0);
			if (this._writePos > 0)
			{
				this.FlushWrite();
			}
			if (count >= this._bufferSize)
			{
				return this._stream.Read(buffer, offset, count) + num2;
			}
			this.EnsureBufferAllocated();
			this._readLen = this._stream.Read(this._buffer, 0, this._bufferSize);
			num = this.ReadFromBuffer(buffer, offset, count);
			return num + num2;
		}

		// Token: 0x06008115 RID: 33045 RVA: 0x00131808 File Offset: 0x0012FA08
		[NullableContext(0)]
		public override int Read(Span<byte> destination)
		{
			this.EnsureNotClosed();
			this.EnsureCanRead();
			int num = this.ReadFromBuffer(destination);
			if (num == destination.Length)
			{
				return num;
			}
			if (num > 0)
			{
				destination = destination.Slice(num);
			}
			this._readPos = (this._readLen = 0);
			if (this._writePos > 0)
			{
				this.FlushWrite();
			}
			if (destination.Length >= this._bufferSize)
			{
				return this._stream.Read(destination) + num;
			}
			this.EnsureBufferAllocated();
			this._readLen = this._stream.Read(this._buffer, 0, this._bufferSize);
			return this.ReadFromBuffer(destination) + num;
		}

		// Token: 0x06008116 RID: 33046 RVA: 0x001318B0 File Offset: 0x0012FAB0
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<int>(cancellationToken);
			}
			this.EnsureNotClosed();
			this.EnsureCanRead();
			int num = 0;
			SemaphoreSlim semaphoreSlim = base.EnsureAsyncActiveSemaphoreInitialized();
			Task task = semaphoreSlim.WaitAsync(cancellationToken);
			if (task.IsCompletedSuccessfully)
			{
				bool flag = true;
				try
				{
					Exception ex;
					num = this.ReadFromBuffer(buffer, offset, count, out ex);
					flag = (num == count || ex != null);
					if (flag)
					{
						return (ex == null) ? this._lastSyncCompletedReadTask.GetTask(num) : Task.FromException<int>(ex);
					}
				}
				finally
				{
					if (flag)
					{
						semaphoreSlim.Release();
					}
				}
			}
			return this.ReadFromUnderlyingStreamAsync(new Memory<byte>(buffer, offset + num, count - num), cancellationToken, num, task).AsTask();
		}

		// Token: 0x06008117 RID: 33047 RVA: 0x00131978 File Offset: 0x0012FB78
		[NullableContext(0)]
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return ValueTask.FromCanceled<int>(cancellationToken);
			}
			this.EnsureNotClosed();
			this.EnsureCanRead();
			int num = 0;
			SemaphoreSlim semaphoreSlim = base.EnsureAsyncActiveSemaphoreInitialized();
			Task task = semaphoreSlim.WaitAsync(cancellationToken);
			if (task.IsCompletedSuccessfully)
			{
				bool flag = true;
				try
				{
					num = this.ReadFromBuffer(buffer.Span);
					flag = (num == buffer.Length);
					if (flag)
					{
						return new ValueTask<int>(num);
					}
				}
				finally
				{
					if (flag)
					{
						semaphoreSlim.Release();
					}
				}
			}
			return this.ReadFromUnderlyingStreamAsync(buffer.Slice(num), cancellationToken, num, task);
		}

		// Token: 0x06008118 RID: 33048 RVA: 0x00131A14 File Offset: 0x0012FC14
		private ValueTask<int> ReadFromUnderlyingStreamAsync(Memory<byte> buffer, CancellationToken cancellationToken, int bytesAlreadySatisfied, Task semaphoreLockTask)
		{
			BufferedStream.<ReadFromUnderlyingStreamAsync>d__48 <ReadFromUnderlyingStreamAsync>d__;
			<ReadFromUnderlyingStreamAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder<int>.Create();
			<ReadFromUnderlyingStreamAsync>d__.<>4__this = this;
			<ReadFromUnderlyingStreamAsync>d__.buffer = buffer;
			<ReadFromUnderlyingStreamAsync>d__.cancellationToken = cancellationToken;
			<ReadFromUnderlyingStreamAsync>d__.bytesAlreadySatisfied = bytesAlreadySatisfied;
			<ReadFromUnderlyingStreamAsync>d__.semaphoreLockTask = semaphoreLockTask;
			<ReadFromUnderlyingStreamAsync>d__.<>1__state = -1;
			<ReadFromUnderlyingStreamAsync>d__.<>t__builder.Start<BufferedStream.<ReadFromUnderlyingStreamAsync>d__48>(ref <ReadFromUnderlyingStreamAsync>d__);
			return <ReadFromUnderlyingStreamAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06008119 RID: 33049 RVA: 0x0008A68A File Offset: 0x0008888A
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, [Nullable(2)] AsyncCallback callback, [Nullable(2)] object state)
		{
			return TaskToAsyncResult.Begin(this.ReadAsync(buffer, offset, count, CancellationToken.None), callback, state);
		}

		// Token: 0x0600811A RID: 33050 RVA: 0x0008A76D File Offset: 0x0008896D
		public override int EndRead(IAsyncResult asyncResult)
		{
			return TaskToAsyncResult.End<int>(asyncResult);
		}

		// Token: 0x0600811B RID: 33051 RVA: 0x00131A78 File Offset: 0x0012FC78
		public override int ReadByte()
		{
			if (this._readPos == this._readLen)
			{
				return this.ReadByteSlow();
			}
			byte[] buffer = this._buffer;
			int readPos = this._readPos;
			this._readPos = readPos + 1;
			return buffer[readPos];
		}

		// Token: 0x0600811C RID: 33052 RVA: 0x00131AB4 File Offset: 0x0012FCB4
		private int ReadByteSlow()
		{
			this.EnsureNotClosed();
			this.EnsureCanRead();
			if (this._writePos > 0)
			{
				this.FlushWrite();
			}
			this.EnsureBufferAllocated();
			this._readLen = this._stream.Read(this._buffer, 0, this._bufferSize);
			this._readPos = 0;
			if (this._readLen == 0)
			{
				return -1;
			}
			byte[] buffer = this._buffer;
			int readPos = this._readPos;
			this._readPos = readPos + 1;
			return buffer[readPos];
		}

		// Token: 0x0600811D RID: 33053 RVA: 0x00131B2C File Offset: 0x0012FD2C
		private void WriteToBuffer(byte[] buffer, ref int offset, ref int count)
		{
			int num = Math.Min(this._bufferSize - this._writePos, count);
			if (num <= 0)
			{
				return;
			}
			this.EnsureBufferAllocated();
			Buffer.BlockCopy(buffer, offset, this._buffer, this._writePos, num);
			this._writePos += num;
			count -= num;
			offset += num;
		}

		// Token: 0x0600811E RID: 33054 RVA: 0x00131B88 File Offset: 0x0012FD88
		private int WriteToBuffer(ReadOnlySpan<byte> buffer)
		{
			int num = Math.Min(this._bufferSize - this._writePos, buffer.Length);
			if (num > 0)
			{
				this.EnsureBufferAllocated();
				buffer.Slice(0, num).CopyTo(new Span<byte>(this._buffer, this._writePos, num));
				this._writePos += num;
			}
			return num;
		}

		// Token: 0x0600811F RID: 33055 RVA: 0x00131BEC File Offset: 0x0012FDEC
		public override void Write(byte[] buffer, int offset, int count)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			this.EnsureNotClosed();
			this.EnsureCanWrite();
			if (this._writePos == 0)
			{
				this.ClearReadBufferBeforeWrite();
			}
			int num = checked(this._writePos + count);
			if (checked(unchecked((ulong)(checked((uint)num))) + (ulong)(unchecked((long)count))) >= (ulong)((long)(checked(this._bufferSize + this._bufferSize))))
			{
				if (this._writePos > 0)
				{
					if (num <= this._bufferSize + this._bufferSize && num <= 81920)
					{
						this.EnsureShadowBufferAllocated();
						Buffer.BlockCopy(buffer, offset, this._buffer, this._writePos, count);
						this._stream.Write(this._buffer, 0, num);
						this._writePos = 0;
						return;
					}
					this._stream.Write(this._buffer, 0, this._writePos);
					this._writePos = 0;
				}
				this._stream.Write(buffer, offset, count);
				return;
			}
			this.WriteToBuffer(buffer, ref offset, ref count);
			if (this._writePos < this._bufferSize)
			{
				return;
			}
			this._stream.Write(this._buffer, 0, this._writePos);
			this._writePos = 0;
			this.WriteToBuffer(buffer, ref offset, ref count);
		}

		// Token: 0x06008120 RID: 33056 RVA: 0x00131D04 File Offset: 0x0012FF04
		[NullableContext(0)]
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			this.EnsureNotClosed();
			this.EnsureCanWrite();
			if (this._writePos == 0)
			{
				this.ClearReadBufferBeforeWrite();
			}
			int num = checked(this._writePos + buffer.Length);
			if (checked(unchecked((ulong)(checked((uint)num))) + (ulong)(unchecked((long)buffer.Length))) >= (ulong)((long)(checked(this._bufferSize + this._bufferSize))))
			{
				if (this._writePos > 0)
				{
					if (num <= this._bufferSize + this._bufferSize && num <= 81920)
					{
						this.EnsureShadowBufferAllocated();
						buffer.CopyTo(new Span<byte>(this._buffer, this._writePos, buffer.Length));
						this._stream.Write(this._buffer, 0, num);
						this._writePos = 0;
						return;
					}
					this._stream.Write(this._buffer, 0, this._writePos);
					this._writePos = 0;
				}
				this._stream.Write(buffer);
				return;
			}
			int start = this.WriteToBuffer(buffer);
			if (this._writePos < this._bufferSize)
			{
				return;
			}
			buffer = buffer.Slice(start);
			this._stream.Write(this._buffer, 0, this._writePos);
			this._writePos = 0;
			start = this.WriteToBuffer(buffer);
		}

		// Token: 0x06008121 RID: 33057 RVA: 0x00131E30 File Offset: 0x00130030
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			return this.WriteAsync(new ReadOnlyMemory<byte>(buffer, offset, count), cancellationToken).AsTask();
		}

		// Token: 0x06008122 RID: 33058 RVA: 0x00131E60 File Offset: 0x00130060
		[NullableContext(0)]
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return ValueTask.FromCanceled(cancellationToken);
			}
			this.EnsureNotClosed();
			this.EnsureCanWrite();
			SemaphoreSlim semaphoreSlim = base.EnsureAsyncActiveSemaphoreInitialized();
			Task task = semaphoreSlim.WaitAsync(cancellationToken);
			if (task.IsCompletedSuccessfully)
			{
				bool flag = true;
				try
				{
					if (this._writePos == 0)
					{
						this.ClearReadBufferBeforeWrite();
					}
					flag = (buffer.Length < this._bufferSize - this._writePos);
					if (flag)
					{
						this.WriteToBuffer(buffer.Span);
						return default(ValueTask);
					}
				}
				finally
				{
					if (flag)
					{
						semaphoreSlim.Release();
					}
				}
			}
			return this.WriteToUnderlyingStreamAsync(buffer, cancellationToken, task);
		}

		// Token: 0x06008123 RID: 33059 RVA: 0x00131F0C File Offset: 0x0013010C
		private ValueTask WriteToUnderlyingStreamAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken, Task semaphoreLockTask)
		{
			BufferedStream.<WriteToUnderlyingStreamAsync>d__59 <WriteToUnderlyingStreamAsync>d__;
			<WriteToUnderlyingStreamAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder.Create();
			<WriteToUnderlyingStreamAsync>d__.<>4__this = this;
			<WriteToUnderlyingStreamAsync>d__.buffer = buffer;
			<WriteToUnderlyingStreamAsync>d__.cancellationToken = cancellationToken;
			<WriteToUnderlyingStreamAsync>d__.semaphoreLockTask = semaphoreLockTask;
			<WriteToUnderlyingStreamAsync>d__.<>1__state = -1;
			<WriteToUnderlyingStreamAsync>d__.<>t__builder.Start<BufferedStream.<WriteToUnderlyingStreamAsync>d__59>(ref <WriteToUnderlyingStreamAsync>d__);
			return <WriteToUnderlyingStreamAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06008124 RID: 33060 RVA: 0x0008A6A3 File Offset: 0x000888A3
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, [Nullable(2)] AsyncCallback callback, [Nullable(2)] object state)
		{
			return TaskToAsyncResult.Begin(this.WriteAsync(buffer, offset, count, CancellationToken.None), callback, state);
		}

		// Token: 0x06008125 RID: 33061 RVA: 0x0008A775 File Offset: 0x00088975
		public override void EndWrite(IAsyncResult asyncResult)
		{
			TaskToAsyncResult.End(asyncResult);
		}

		// Token: 0x06008126 RID: 33062 RVA: 0x00131F68 File Offset: 0x00130168
		public override void WriteByte(byte value)
		{
			if (this._writePos > 0 && this._writePos < this._bufferSize - 1)
			{
				byte[] buffer = this._buffer;
				int writePos = this._writePos;
				this._writePos = writePos + 1;
				buffer[writePos] = value;
				return;
			}
			this.WriteByteSlow(value);
		}

		// Token: 0x06008127 RID: 33063 RVA: 0x00131FB0 File Offset: 0x001301B0
		private void WriteByteSlow(byte value)
		{
			this.EnsureNotClosed();
			if (this._writePos == 0)
			{
				this.EnsureCanWrite();
				this.ClearReadBufferBeforeWrite();
				this.EnsureBufferAllocated();
			}
			if (this._writePos >= this._bufferSize - 1)
			{
				this.FlushWrite();
			}
			byte[] buffer = this._buffer;
			int writePos = this._writePos;
			this._writePos = writePos + 1;
			buffer[writePos] = value;
		}

		// Token: 0x06008128 RID: 33064 RVA: 0x0013200C File Offset: 0x0013020C
		public override long Seek(long offset, SeekOrigin origin)
		{
			this.EnsureNotClosed();
			this.EnsureCanSeek();
			if (this._writePos > 0)
			{
				this.FlushWrite();
				return this._stream.Seek(offset, origin);
			}
			if (this._readLen - this._readPos > 0 && origin == SeekOrigin.Current)
			{
				offset -= (long)(this._readLen - this._readPos);
			}
			long position = this.Position;
			long num = this._stream.Seek(offset, origin);
			long num2 = num - (position - (long)this._readPos);
			if (0L <= num2 && num2 < (long)this._readLen)
			{
				this._readPos = (int)num2;
				this._stream.Seek((long)(this._readLen - this._readPos), SeekOrigin.Current);
				return num;
			}
			this._readPos = (this._readLen = 0);
			return num;
		}

		// Token: 0x06008129 RID: 33065 RVA: 0x001320CB File Offset: 0x001302CB
		public override void SetLength(long value)
		{
			if (value < 0L)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			this.EnsureNotClosed();
			this.EnsureCanSeek();
			this.EnsureCanWrite();
			this.Flush();
			this._stream.SetLength(value);
		}

		// Token: 0x0600812A RID: 33066 RVA: 0x00132100 File Offset: 0x00130300
		public override void CopyTo(Stream destination, int bufferSize)
		{
			Stream.ValidateCopyToArguments(destination, bufferSize);
			this.EnsureNotClosed();
			this.EnsureCanRead();
			int num = this._readLen - this._readPos;
			if (num > 0)
			{
				destination.Write(this._buffer, this._readPos, num);
				this._readPos = (this._readLen = 0);
			}
			else if (this._writePos > 0)
			{
				this.FlushWrite();
			}
			this._stream.CopyTo(destination, bufferSize);
		}

		// Token: 0x0600812B RID: 33067 RVA: 0x00132173 File Offset: 0x00130373
		public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			Stream.ValidateCopyToArguments(destination, bufferSize);
			this.EnsureNotClosed();
			this.EnsureCanRead();
			if (!cancellationToken.IsCancellationRequested)
			{
				return this.CopyToAsyncCore(destination, bufferSize, cancellationToken);
			}
			return Task.FromCanceled<int>(cancellationToken);
		}

		// Token: 0x0600812C RID: 33068 RVA: 0x001321A4 File Offset: 0x001303A4
		private Task CopyToAsyncCore(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			BufferedStream.<CopyToAsyncCore>d__68 <CopyToAsyncCore>d__;
			<CopyToAsyncCore>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CopyToAsyncCore>d__.<>4__this = this;
			<CopyToAsyncCore>d__.destination = destination;
			<CopyToAsyncCore>d__.bufferSize = bufferSize;
			<CopyToAsyncCore>d__.cancellationToken = cancellationToken;
			<CopyToAsyncCore>d__.<>1__state = -1;
			<CopyToAsyncCore>d__.<>t__builder.Start<BufferedStream.<CopyToAsyncCore>d__68>(ref <CopyToAsyncCore>d__);
			return <CopyToAsyncCore>d__.<>t__builder.Task;
		}

		// Token: 0x04001AE0 RID: 6880
		private Stream _stream;

		// Token: 0x04001AE1 RID: 6881
		private byte[] _buffer;

		// Token: 0x04001AE2 RID: 6882
		private readonly int _bufferSize;

		// Token: 0x04001AE3 RID: 6883
		private int _readPos;

		// Token: 0x04001AE4 RID: 6884
		private int _readLen;

		// Token: 0x04001AE5 RID: 6885
		private int _writePos;

		// Token: 0x04001AE6 RID: 6886
		private CachedCompletedInt32Task _lastSyncCompletedReadTask;
	}
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Strategies
{
	// Token: 0x02000854 RID: 2132
	internal sealed class BufferedFileStreamStrategy : FileStreamStrategy
	{
		// Token: 0x06008791 RID: 34705 RVA: 0x0014831D File Offset: 0x0014651D
		internal BufferedFileStreamStrategy(FileStreamStrategy strategy, int bufferSize)
		{
			this._strategy = strategy;
			this._bufferSize = bufferSize;
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x06008792 RID: 34706 RVA: 0x00148333 File Offset: 0x00146533
		public override bool CanRead
		{
			get
			{
				return this._strategy.CanRead;
			}
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x06008793 RID: 34707 RVA: 0x00148340 File Offset: 0x00146540
		public override bool CanWrite
		{
			get
			{
				return this._strategy.CanWrite;
			}
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x06008794 RID: 34708 RVA: 0x0014834D File Offset: 0x0014654D
		public override bool CanSeek
		{
			get
			{
				return this._strategy.CanSeek;
			}
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x06008795 RID: 34709 RVA: 0x0014835C File Offset: 0x0014655C
		public override long Length
		{
			get
			{
				long num = this._strategy.Length;
				if (this._writePos > 0 && this._strategy.Position + (long)this._writePos > num)
				{
					num = (long)this._writePos + this._strategy.Position;
				}
				return num;
			}
		}

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x06008796 RID: 34710 RVA: 0x001483A9 File Offset: 0x001465A9
		// (set) Token: 0x06008797 RID: 34711 RVA: 0x001483CE File Offset: 0x001465CE
		public override long Position
		{
			get
			{
				return this._strategy.Position + (long)this._readPos - (long)this._readLen + (long)this._writePos;
			}
			set
			{
				this.Seek(value, SeekOrigin.Begin);
			}
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x06008798 RID: 34712 RVA: 0x001483D9 File Offset: 0x001465D9
		internal override bool IsAsync
		{
			get
			{
				return this._strategy.IsAsync;
			}
		}

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x06008799 RID: 34713 RVA: 0x001483E6 File Offset: 0x001465E6
		internal override bool IsClosed
		{
			get
			{
				return this._strategy.IsClosed;
			}
		}

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x0600879A RID: 34714 RVA: 0x001483F3 File Offset: 0x001465F3
		internal override string Name
		{
			get
			{
				return this._strategy.Name;
			}
		}

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x0600879B RID: 34715 RVA: 0x00148400 File Offset: 0x00146600
		internal override SafeFileHandle SafeFileHandle
		{
			get
			{
				this.Flush();
				return this._strategy.SafeFileHandle;
			}
		}

		// Token: 0x0600879C RID: 34716 RVA: 0x00148414 File Offset: 0x00146614
		public override ValueTask DisposeAsync()
		{
			BufferedFileStreamStrategy.<DisposeAsync>d__27 <DisposeAsync>d__;
			<DisposeAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder.Create();
			<DisposeAsync>d__.<>4__this = this;
			<DisposeAsync>d__.<>1__state = -1;
			<DisposeAsync>d__.<>t__builder.Start<BufferedFileStreamStrategy.<DisposeAsync>d__27>(ref <DisposeAsync>d__);
			return <DisposeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600879D RID: 34717 RVA: 0x00148458 File Offset: 0x00146658
		protected sealed override void Dispose(bool disposing)
		{
			if (this._strategy.IsClosed)
			{
				return;
			}
			try
			{
				this.Flush();
			}
			catch (Exception e) when (!disposing && FileStreamHelpers.IsIoRelatedException(e))
			{
			}
			finally
			{
				this._writePos = 0;
				this._strategy.DisposeInternal(disposing);
			}
		}

		// Token: 0x0600879E RID: 34718 RVA: 0x001484D0 File Offset: 0x001466D0
		public override int Read(byte[] buffer, int offset, int count)
		{
			return this.ReadSpan(new Span<byte>(buffer, offset, count), new ArraySegment<byte>(buffer, offset, count));
		}

		// Token: 0x0600879F RID: 34719 RVA: 0x001484E8 File Offset: 0x001466E8
		public override int Read(Span<byte> destination)
		{
			this.EnsureNotClosed();
			return this.ReadSpan(destination, default(ArraySegment<byte>));
		}

		// Token: 0x060087A0 RID: 34720 RVA: 0x0014850C File Offset: 0x0014670C
		private int ReadSpan(Span<byte> destination, ArraySegment<byte> arraySegment)
		{
			bool flag = false;
			int num = this._readLen - this._readPos;
			if (num == 0)
			{
				this.EnsureCanRead();
				if (this._writePos > 0)
				{
					this.FlushWrite();
				}
				if (!this._strategy.CanSeek || destination.Length >= this._bufferSize)
				{
					num = ((arraySegment.Array != null) ? this._strategy.Read(arraySegment.Array, arraySegment.Offset, arraySegment.Count) : this._strategy.Read(destination));
					this._readPos = 0;
					this._readLen = 0;
					return num;
				}
				this.EnsureBufferAllocated();
				num = this._strategy.Read(this._buffer, 0, this._bufferSize);
				if (num == 0)
				{
					return 0;
				}
				flag = (num < this._bufferSize);
				this._readPos = 0;
				this._readLen = num;
			}
			if (num > destination.Length)
			{
				num = destination.Length;
			}
			new ReadOnlySpan<byte>(this._buffer, this._readPos, num).CopyTo(destination);
			this._readPos += num;
			if (this._strategy.CanSeek && num < destination.Length && !flag)
			{
				int num2 = (arraySegment.Array != null) ? this._strategy.Read(arraySegment.Array, arraySegment.Offset + num, arraySegment.Count - num) : this._strategy.Read(destination.Slice(num));
				num += num2;
				this._readPos = 0;
				this._readLen = 0;
			}
			return num;
		}

		// Token: 0x060087A1 RID: 34721 RVA: 0x00148690 File Offset: 0x00146890
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

		// Token: 0x060087A2 RID: 34722 RVA: 0x001486CC File Offset: 0x001468CC
		private int ReadByteSlow()
		{
			this.EnsureNotClosed();
			this.EnsureCanRead();
			if (this._writePos > 0)
			{
				this.FlushWrite();
			}
			this.EnsureBufferAllocated();
			this._readLen = this._strategy.Read(this._buffer, 0, this._bufferSize);
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

		// Token: 0x060087A3 RID: 34723 RVA: 0x00148744 File Offset: 0x00146944
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			ValueTask<int> valueTask = this.ReadAsync(new Memory<byte>(buffer, offset, count), cancellationToken);
			if (!valueTask.IsCompletedSuccessfully)
			{
				return valueTask.AsTask();
			}
			return this._lastSyncCompletedReadTask.GetTask(valueTask.Result);
		}

		// Token: 0x060087A4 RID: 34724 RVA: 0x00148788 File Offset: 0x00146988
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return ValueTask.FromCanceled<int>(cancellationToken);
			}
			this.EnsureCanRead();
			if (!this._strategy.CanSeek)
			{
				return this.ReadFromNonSeekableAsync(buffer, cancellationToken);
			}
			SemaphoreSlim semaphoreSlim = base.EnsureAsyncActiveSemaphoreInitialized();
			Task task = semaphoreSlim.WaitAsync(cancellationToken);
			if (task.IsCompletedSuccessfully && this._writePos == 0)
			{
				bool flag = true;
				try
				{
					if (this._readLen == this._readPos && buffer.Length >= this._bufferSize)
					{
						this._readPos = (this._readLen = 0);
						return this._strategy.ReadAsync(buffer, cancellationToken);
					}
					if (this._readLen - this._readPos >= buffer.Length)
					{
						this._buffer.AsSpan(this._readPos, buffer.Length).CopyTo(buffer.Span);
						this._readPos += buffer.Length;
						return new ValueTask<int>(buffer.Length);
					}
					flag = false;
				}
				finally
				{
					if (flag)
					{
						semaphoreSlim.Release();
					}
				}
			}
			return this.ReadAsyncSlowPath(task, buffer, cancellationToken);
		}

		// Token: 0x060087A5 RID: 34725 RVA: 0x001488B4 File Offset: 0x00146AB4
		private ValueTask<int> ReadFromNonSeekableAsync(Memory<byte> destination, CancellationToken cancellationToken)
		{
			BufferedFileStreamStrategy.<ReadFromNonSeekableAsync>d__36 <ReadFromNonSeekableAsync>d__;
			<ReadFromNonSeekableAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder<int>.Create();
			<ReadFromNonSeekableAsync>d__.<>4__this = this;
			<ReadFromNonSeekableAsync>d__.destination = destination;
			<ReadFromNonSeekableAsync>d__.cancellationToken = cancellationToken;
			<ReadFromNonSeekableAsync>d__.<>1__state = -1;
			<ReadFromNonSeekableAsync>d__.<>t__builder.Start<BufferedFileStreamStrategy.<ReadFromNonSeekableAsync>d__36>(ref <ReadFromNonSeekableAsync>d__);
			return <ReadFromNonSeekableAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060087A6 RID: 34726 RVA: 0x00148908 File Offset: 0x00146B08
		[AsyncMethodBuilder(typeof(PoolingAsyncValueTaskMethodBuilder<>))]
		private ValueTask<int> ReadAsyncSlowPath(Task semaphoreLockTask, Memory<byte> buffer, CancellationToken cancellationToken)
		{
			BufferedFileStreamStrategy.<ReadAsyncSlowPath>d__37 <ReadAsyncSlowPath>d__;
			<ReadAsyncSlowPath>d__.<>t__builder = PoolingAsyncValueTaskMethodBuilder<int>.Create();
			<ReadAsyncSlowPath>d__.<>4__this = this;
			<ReadAsyncSlowPath>d__.semaphoreLockTask = semaphoreLockTask;
			<ReadAsyncSlowPath>d__.buffer = buffer;
			<ReadAsyncSlowPath>d__.cancellationToken = cancellationToken;
			<ReadAsyncSlowPath>d__.<>1__state = -1;
			<ReadAsyncSlowPath>d__.<>t__builder.Start<BufferedFileStreamStrategy.<ReadAsyncSlowPath>d__37>(ref <ReadAsyncSlowPath>d__);
			return <ReadAsyncSlowPath>d__.<>t__builder.Task;
		}

		// Token: 0x060087A7 RID: 34727 RVA: 0x0008A68A File Offset: 0x0008888A
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return TaskToAsyncResult.Begin(this.ReadAsync(buffer, offset, count, CancellationToken.None), callback, state);
		}

		// Token: 0x060087A8 RID: 34728 RVA: 0x0008A76D File Offset: 0x0008896D
		public override int EndRead(IAsyncResult asyncResult)
		{
			return TaskToAsyncResult.End<int>(asyncResult);
		}

		// Token: 0x060087A9 RID: 34729 RVA: 0x00148963 File Offset: 0x00146B63
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.WriteSpan(new ReadOnlySpan<byte>(buffer, offset, count), new ArraySegment<byte>(buffer, offset, count));
		}

		// Token: 0x060087AA RID: 34730 RVA: 0x0014897C File Offset: 0x00146B7C
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			this.EnsureNotClosed();
			this.WriteSpan(buffer, default(ArraySegment<byte>));
		}

		// Token: 0x060087AB RID: 34731 RVA: 0x001489A0 File Offset: 0x00146BA0
		private void WriteSpan(ReadOnlySpan<byte> source, ArraySegment<byte> arraySegment)
		{
			if (this._writePos == 0)
			{
				this.EnsureCanWrite();
				this.ClearReadBufferBeforeWrite();
			}
			if (this._writePos > 0)
			{
				int num = this._bufferSize - this._writePos;
				if (num > 0)
				{
					if (num >= source.Length)
					{
						source.CopyTo(this._buffer.AsSpan(this._writePos));
						this._writePos += source.Length;
						return;
					}
					source.Slice(0, num).CopyTo(this._buffer.AsSpan(this._writePos));
					this._writePos += num;
					source = source.Slice(num);
					if (arraySegment.Array != null)
					{
						arraySegment = arraySegment.Slice(num);
					}
				}
				this.FlushWrite();
			}
			if (source.Length >= this._bufferSize)
			{
				if (arraySegment.Array != null)
				{
					this._strategy.Write(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
					return;
				}
				this._strategy.Write(source);
				return;
			}
			else
			{
				if (source.Length == 0)
				{
					return;
				}
				this.EnsureBufferAllocated();
				source.CopyTo(this._buffer.AsSpan(this._writePos));
				this._writePos = source.Length;
				return;
			}
		}

		// Token: 0x060087AC RID: 34732 RVA: 0x00148AE8 File Offset: 0x00146CE8
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

		// Token: 0x060087AD RID: 34733 RVA: 0x00148B30 File Offset: 0x00146D30
		private void WriteByteSlow(byte value)
		{
			if (this._writePos == 0)
			{
				this.EnsureNotClosed();
				this.EnsureCanWrite();
				this.ClearReadBufferBeforeWrite();
				this.EnsureBufferAllocated();
			}
			else
			{
				this.FlushWrite();
			}
			byte[] buffer = this._buffer;
			int writePos = this._writePos;
			this._writePos = writePos + 1;
			buffer[writePos] = value;
		}

		// Token: 0x060087AE RID: 34734 RVA: 0x00148B80 File Offset: 0x00146D80
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return this.WriteAsync(new ReadOnlyMemory<byte>(buffer, offset, count), cancellationToken).AsTask();
		}

		// Token: 0x060087AF RID: 34735 RVA: 0x00148BA8 File Offset: 0x00146DA8
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return ValueTask.FromCanceled(cancellationToken);
			}
			this.EnsureCanWrite();
			if (!this._strategy.CanSeek)
			{
				return this.WriteToNonSeekableAsync(buffer, cancellationToken);
			}
			SemaphoreSlim semaphoreSlim = base.EnsureAsyncActiveSemaphoreInitialized();
			Task task = semaphoreSlim.WaitAsync(cancellationToken);
			if (task.IsCompletedSuccessfully && this._readPos == this._readLen)
			{
				bool flag = true;
				try
				{
					if (this._writePos == 0 && buffer.Length >= this._bufferSize)
					{
						return this._strategy.WriteAsync(buffer, cancellationToken);
					}
					if (this._bufferSize - this._writePos >= buffer.Length)
					{
						this.EnsureBufferAllocated();
						buffer.Span.CopyTo(this._buffer.AsSpan(this._writePos));
						this._writePos += buffer.Length;
						return default(ValueTask);
					}
					flag = false;
				}
				finally
				{
					if (flag)
					{
						semaphoreSlim.Release();
					}
				}
			}
			return this.WriteAsyncSlowPath(task, buffer, cancellationToken);
		}

		// Token: 0x060087B0 RID: 34736 RVA: 0x00148CC0 File Offset: 0x00146EC0
		private ValueTask WriteToNonSeekableAsync(ReadOnlyMemory<byte> source, CancellationToken cancellationToken)
		{
			BufferedFileStreamStrategy.<WriteToNonSeekableAsync>d__47 <WriteToNonSeekableAsync>d__;
			<WriteToNonSeekableAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder.Create();
			<WriteToNonSeekableAsync>d__.<>4__this = this;
			<WriteToNonSeekableAsync>d__.source = source;
			<WriteToNonSeekableAsync>d__.cancellationToken = cancellationToken;
			<WriteToNonSeekableAsync>d__.<>1__state = -1;
			<WriteToNonSeekableAsync>d__.<>t__builder.Start<BufferedFileStreamStrategy.<WriteToNonSeekableAsync>d__47>(ref <WriteToNonSeekableAsync>d__);
			return <WriteToNonSeekableAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060087B1 RID: 34737 RVA: 0x00148D14 File Offset: 0x00146F14
		[AsyncMethodBuilder(typeof(PoolingAsyncValueTaskMethodBuilder))]
		private ValueTask WriteAsyncSlowPath(Task semaphoreLockTask, ReadOnlyMemory<byte> source, CancellationToken cancellationToken)
		{
			BufferedFileStreamStrategy.<WriteAsyncSlowPath>d__48 <WriteAsyncSlowPath>d__;
			<WriteAsyncSlowPath>d__.<>t__builder = PoolingAsyncValueTaskMethodBuilder.Create();
			<WriteAsyncSlowPath>d__.<>4__this = this;
			<WriteAsyncSlowPath>d__.semaphoreLockTask = semaphoreLockTask;
			<WriteAsyncSlowPath>d__.source = source;
			<WriteAsyncSlowPath>d__.cancellationToken = cancellationToken;
			<WriteAsyncSlowPath>d__.<>1__state = -1;
			<WriteAsyncSlowPath>d__.<>t__builder.Start<BufferedFileStreamStrategy.<WriteAsyncSlowPath>d__48>(ref <WriteAsyncSlowPath>d__);
			return <WriteAsyncSlowPath>d__.<>t__builder.Task;
		}

		// Token: 0x060087B2 RID: 34738 RVA: 0x0008A6A3 File Offset: 0x000888A3
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return TaskToAsyncResult.Begin(this.WriteAsync(buffer, offset, count, CancellationToken.None), callback, state);
		}

		// Token: 0x060087B3 RID: 34739 RVA: 0x0008A775 File Offset: 0x00088975
		public override void EndWrite(IAsyncResult asyncResult)
		{
			TaskToAsyncResult.End(asyncResult);
		}

		// Token: 0x060087B4 RID: 34740 RVA: 0x00148D6F File Offset: 0x00146F6F
		public override void SetLength(long value)
		{
			this.Flush();
			this._strategy.SetLength(value);
		}

		// Token: 0x060087B5 RID: 34741 RVA: 0x00148D83 File Offset: 0x00146F83
		public override void Flush()
		{
			this.Flush(false);
		}

		// Token: 0x060087B6 RID: 34742 RVA: 0x00148D8C File Offset: 0x00146F8C
		internal override void Flush(bool flushToDisk)
		{
			if (this._writePos > 0)
			{
				this.FlushWrite();
			}
			else if (this._readLen > 0 && this._strategy.CanSeek)
			{
				this.FlushRead();
			}
			this._strategy.Flush(flushToDisk);
		}

		// Token: 0x060087B7 RID: 34743 RVA: 0x00148DC7 File Offset: 0x00146FC7
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<int>(cancellationToken);
			}
			this.EnsureNotClosed();
			return this.FlushAsyncInternal(cancellationToken);
		}

		// Token: 0x060087B8 RID: 34744 RVA: 0x00148DE8 File Offset: 0x00146FE8
		private Task FlushAsyncInternal(CancellationToken cancellationToken)
		{
			BufferedFileStreamStrategy.<FlushAsyncInternal>d__55 <FlushAsyncInternal>d__;
			<FlushAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FlushAsyncInternal>d__.<>4__this = this;
			<FlushAsyncInternal>d__.cancellationToken = cancellationToken;
			<FlushAsyncInternal>d__.<>1__state = -1;
			<FlushAsyncInternal>d__.<>t__builder.Start<BufferedFileStreamStrategy.<FlushAsyncInternal>d__55>(ref <FlushAsyncInternal>d__);
			return <FlushAsyncInternal>d__.<>t__builder.Task;
		}

		// Token: 0x060087B9 RID: 34745 RVA: 0x00148E33 File Offset: 0x00147033
		public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			this.EnsureNotClosed();
			this.EnsureCanRead();
			if (!cancellationToken.IsCancellationRequested)
			{
				return this.CopyToAsyncCore(destination, bufferSize, cancellationToken);
			}
			return Task.FromCanceled<int>(cancellationToken);
		}

		// Token: 0x060087BA RID: 34746 RVA: 0x00148E5C File Offset: 0x0014705C
		private Task CopyToAsyncCore(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			BufferedFileStreamStrategy.<CopyToAsyncCore>d__57 <CopyToAsyncCore>d__;
			<CopyToAsyncCore>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CopyToAsyncCore>d__.<>4__this = this;
			<CopyToAsyncCore>d__.destination = destination;
			<CopyToAsyncCore>d__.bufferSize = bufferSize;
			<CopyToAsyncCore>d__.cancellationToken = cancellationToken;
			<CopyToAsyncCore>d__.<>1__state = -1;
			<CopyToAsyncCore>d__.<>t__builder.Start<BufferedFileStreamStrategy.<CopyToAsyncCore>d__57>(ref <CopyToAsyncCore>d__);
			return <CopyToAsyncCore>d__.<>t__builder.Task;
		}

		// Token: 0x060087BB RID: 34747 RVA: 0x00148EB8 File Offset: 0x001470B8
		public override void CopyTo(Stream destination, int bufferSize)
		{
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
			this._strategy.CopyTo(destination, bufferSize);
		}

		// Token: 0x060087BC RID: 34748 RVA: 0x00148F24 File Offset: 0x00147124
		public override long Seek(long offset, SeekOrigin origin)
		{
			if (this._writePos > 0)
			{
				this.FlushWrite();
				return this._strategy.Seek(offset, origin);
			}
			if (this._readLen - this._readPos > 0 && origin == SeekOrigin.Current)
			{
				offset -= (long)(this._readLen - this._readPos);
			}
			long position = this.Position;
			long num = this._strategy.Seek(offset, origin);
			long num2 = num - (position - (long)this._readPos);
			if (0L <= num2 && num2 < (long)this._readLen)
			{
				this._readPos = (int)num2;
				this._strategy.Seek((long)(this._readLen - this._readPos), SeekOrigin.Current);
				return num;
			}
			this._readPos = (this._readLen = 0);
			return num;
		}

		// Token: 0x060087BD RID: 34749 RVA: 0x00148FD7 File Offset: 0x001471D7
		internal override void Lock(long position, long length)
		{
			this._strategy.Lock(position, length);
		}

		// Token: 0x060087BE RID: 34750 RVA: 0x00148FE6 File Offset: 0x001471E6
		internal override void Unlock(long position, long length)
		{
			this._strategy.Unlock(position, length);
		}

		// Token: 0x060087BF RID: 34751 RVA: 0x00148FF5 File Offset: 0x001471F5
		private void FlushRead()
		{
			if (this._readPos - this._readLen != 0)
			{
				this._strategy.Seek((long)(this._readPos - this._readLen), SeekOrigin.Current);
			}
			this._readPos = 0;
			this._readLen = 0;
		}

		// Token: 0x060087C0 RID: 34752 RVA: 0x0014902F File Offset: 0x0014722F
		private void FlushWrite()
		{
			this._strategy.Write(this._buffer, 0, this._writePos);
			this._writePos = 0;
		}

		// Token: 0x060087C1 RID: 34753 RVA: 0x00149050 File Offset: 0x00147250
		private void ClearReadBufferBeforeWrite()
		{
			if (this._readPos == this._readLen)
			{
				this._readPos = (this._readLen = 0);
				return;
			}
			this.FlushRead();
		}

		// Token: 0x060087C2 RID: 34754 RVA: 0x00149082 File Offset: 0x00147282
		private void EnsureNotClosed()
		{
			if (this._strategy.IsClosed)
			{
				ThrowHelper.ThrowObjectDisposedException_StreamClosed(null);
			}
		}

		// Token: 0x060087C3 RID: 34755 RVA: 0x00149097 File Offset: 0x00147297
		private void EnsureCanRead()
		{
			if (!this._strategy.CanRead)
			{
				ThrowHelper.ThrowNotSupportedException_UnreadableStream();
			}
		}

		// Token: 0x060087C4 RID: 34756 RVA: 0x001490AB File Offset: 0x001472AB
		private void EnsureCanWrite()
		{
			if (!this._strategy.CanWrite)
			{
				ThrowHelper.ThrowNotSupportedException_UnwritableStream();
			}
		}

		// Token: 0x060087C5 RID: 34757 RVA: 0x001490BF File Offset: 0x001472BF
		[MemberNotNull("_buffer")]
		private void EnsureBufferAllocated()
		{
			if (this._buffer == null)
			{
				this.AllocateBuffer();
			}
		}

		// Token: 0x060087C6 RID: 34758 RVA: 0x001490CF File Offset: 0x001472CF
		[MemberNotNull("_buffer")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AllocateBuffer()
		{
			Interlocked.CompareExchange<byte[]>(ref this._buffer, GC.AllocateUninitializedArray<byte>(this._bufferSize, false), null);
		}

		// Token: 0x04001D76 RID: 7542
		private readonly FileStreamStrategy _strategy;

		// Token: 0x04001D77 RID: 7543
		private readonly int _bufferSize;

		// Token: 0x04001D78 RID: 7544
		private byte[] _buffer;

		// Token: 0x04001D79 RID: 7545
		private int _writePos;

		// Token: 0x04001D7A RID: 7546
		private int _readPos;

		// Token: 0x04001D7B RID: 7547
		private int _readLen;

		// Token: 0x04001D7C RID: 7548
		private CachedCompletedInt32Task _lastSyncCompletedReadTask;
	}
}

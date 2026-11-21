using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	// Token: 0x02000818 RID: 2072
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class Stream : MarshalByRefObject, IDisposable, IAsyncDisposable
	{
		// Token: 0x06008404 RID: 33796 RVA: 0x0013CBF3 File Offset: 0x0013ADF3
		[MemberNotNull("_asyncActiveSemaphore")]
		private protected SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized()
		{
			SemaphoreSlim result;
			if ((result = this._asyncActiveSemaphore) == null)
			{
				result = (Interlocked.CompareExchange<SemaphoreSlim>(ref this._asyncActiveSemaphore, new SemaphoreSlim(1, 1), null) ?? this._asyncActiveSemaphore);
			}
			return result;
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x06008405 RID: 33797
		public abstract bool CanRead { get; }

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x06008406 RID: 33798
		public abstract bool CanWrite { get; }

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x06008407 RID: 33799
		public abstract bool CanSeek { get; }

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x06008408 RID: 33800 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool CanTimeout
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x06008409 RID: 33801
		public abstract long Length { get; }

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x0600840A RID: 33802
		// (set) Token: 0x0600840B RID: 33803
		public abstract long Position { get; set; }

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x0600840C RID: 33804 RVA: 0x0013CC1C File Offset: 0x0013AE1C
		// (set) Token: 0x0600840D RID: 33805 RVA: 0x0013CC1C File Offset: 0x0013AE1C
		public virtual int ReadTimeout
		{
			get
			{
				throw new InvalidOperationException(SR.InvalidOperation_TimeoutsNotSupported);
			}
			set
			{
				throw new InvalidOperationException(SR.InvalidOperation_TimeoutsNotSupported);
			}
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x0600840E RID: 33806 RVA: 0x0013CC1C File Offset: 0x0013AE1C
		// (set) Token: 0x0600840F RID: 33807 RVA: 0x0013CC1C File Offset: 0x0013AE1C
		public virtual int WriteTimeout
		{
			get
			{
				throw new InvalidOperationException(SR.InvalidOperation_TimeoutsNotSupported);
			}
			set
			{
				throw new InvalidOperationException(SR.InvalidOperation_TimeoutsNotSupported);
			}
		}

		// Token: 0x06008410 RID: 33808 RVA: 0x0013CC28 File Offset: 0x0013AE28
		public void CopyTo(Stream destination)
		{
			this.CopyTo(destination, this.GetCopyBufferSize());
		}

		// Token: 0x06008411 RID: 33809 RVA: 0x0013CC38 File Offset: 0x0013AE38
		public virtual void CopyTo(Stream destination, int bufferSize)
		{
			Stream.ValidateCopyToArguments(destination, bufferSize);
			if (!this.CanRead)
			{
				if (this.CanWrite)
				{
					ThrowHelper.ThrowNotSupportedException_UnreadableStream();
				}
				ThrowHelper.ThrowObjectDisposedException_StreamClosed(base.GetType().Name);
			}
			byte[] array = ArrayPool<byte>.Shared.Rent(bufferSize);
			try
			{
				int count;
				while ((count = this.Read(array, 0, array.Length)) != 0)
				{
					destination.Write(array, 0, count);
				}
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x06008412 RID: 33810 RVA: 0x0013CCB8 File Offset: 0x0013AEB8
		public Task CopyToAsync(Stream destination)
		{
			return this.CopyToAsync(destination, this.GetCopyBufferSize());
		}

		// Token: 0x06008413 RID: 33811 RVA: 0x0013CCC7 File Offset: 0x0013AEC7
		public Task CopyToAsync(Stream destination, int bufferSize)
		{
			return this.CopyToAsync(destination, bufferSize, CancellationToken.None);
		}

		// Token: 0x06008414 RID: 33812 RVA: 0x0013CCD6 File Offset: 0x0013AED6
		public Task CopyToAsync(Stream destination, CancellationToken cancellationToken)
		{
			return this.CopyToAsync(destination, this.GetCopyBufferSize(), cancellationToken);
		}

		// Token: 0x06008415 RID: 33813 RVA: 0x0013CCE6 File Offset: 0x0013AEE6
		public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			Stream.ValidateCopyToArguments(destination, bufferSize);
			if (!this.CanRead)
			{
				if (this.CanWrite)
				{
					ThrowHelper.ThrowNotSupportedException_UnreadableStream();
				}
				ThrowHelper.ThrowObjectDisposedException_StreamClosed(base.GetType().Name);
			}
			return Stream.<CopyToAsync>g__Core|27_0(this, destination, bufferSize, cancellationToken);
		}

		// Token: 0x06008416 RID: 33814 RVA: 0x0013CD20 File Offset: 0x0013AF20
		private int GetCopyBufferSize()
		{
			int num = 81920;
			if (this.CanSeek)
			{
				long length = this.Length;
				long position = this.Position;
				if (length <= position)
				{
					num = 1;
				}
				else
				{
					long num2 = length - position;
					if (num2 > 0L)
					{
						num = (int)Math.Min((long)num, num2);
					}
				}
			}
			return num;
		}

		// Token: 0x06008417 RID: 33815 RVA: 0x0013CD65 File Offset: 0x0013AF65
		public void Dispose()
		{
			this.Close();
		}

		// Token: 0x06008418 RID: 33816 RVA: 0x0013CD6D File Offset: 0x0013AF6D
		public virtual void Close()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06008419 RID: 33817 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0600841A RID: 33818 RVA: 0x0013CD7C File Offset: 0x0013AF7C
		public virtual ValueTask DisposeAsync()
		{
			ValueTask valueTask;
			try
			{
				this.Dispose();
				valueTask = default(ValueTask);
				valueTask = valueTask;
			}
			catch (Exception exception)
			{
				valueTask = ValueTask.FromException(exception);
			}
			return valueTask;
		}

		// Token: 0x0600841B RID: 33819
		public abstract void Flush();

		// Token: 0x0600841C RID: 33820 RVA: 0x0013CDB4 File Offset: 0x0013AFB4
		public Task FlushAsync()
		{
			return this.FlushAsync(CancellationToken.None);
		}

		// Token: 0x0600841D RID: 33821 RVA: 0x0013CDC1 File Offset: 0x0013AFC1
		public virtual Task FlushAsync(CancellationToken cancellationToken)
		{
			return Task.Factory.StartNew(delegate(object state)
			{
				((Stream)state).Flush();
			}, this, cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		// Token: 0x0600841E RID: 33822 RVA: 0x0013CDF4 File Offset: 0x0013AFF4
		[Obsolete("CreateWaitHandle has been deprecated. Use the ManualResetEvent(false) constructor instead.")]
		protected virtual WaitHandle CreateWaitHandle()
		{
			return new ManualResetEvent(false);
		}

		// Token: 0x0600841F RID: 33823 RVA: 0x0013CDFC File Offset: 0x0013AFFC
		public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, [Nullable(2)] AsyncCallback callback, [Nullable(2)] object state)
		{
			return this.BeginReadInternal(buffer, offset, count, callback, state, false, true);
		}

		// Token: 0x06008420 RID: 33824 RVA: 0x0013CE10 File Offset: 0x0013B010
		internal Task<int> BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			if (!this.CanRead)
			{
				ThrowHelper.ThrowNotSupportedException_UnreadableStream();
			}
			SemaphoreSlim semaphoreSlim = this.EnsureAsyncActiveSemaphoreInitialized();
			Task task = null;
			if (serializeAsynchronously)
			{
				task = semaphoreSlim.WaitAsync();
			}
			else
			{
				semaphoreSlim.Wait();
			}
			Stream.ReadWriteTask readWriteTask = new Stream.ReadWriteTask(true, apm, delegate(object <p0>)
			{
				Stream.ReadWriteTask readWriteTask2 = Task.InternalCurrent as Stream.ReadWriteTask;
				int result;
				try
				{
					result = readWriteTask2._stream.Read(readWriteTask2._buffer, readWriteTask2._offset, readWriteTask2._count);
				}
				finally
				{
					if (!readWriteTask2._apm)
					{
						readWriteTask2._stream.FinishTrackingAsyncOperation(readWriteTask2);
					}
					readWriteTask2.ClearBeginState();
				}
				return result;
			}, state, this, buffer, offset, count, callback);
			if (task != null)
			{
				Stream.RunReadWriteTaskWhenReady(task, readWriteTask);
			}
			else
			{
				Stream.RunReadWriteTask(readWriteTask);
			}
			return readWriteTask;
		}

		// Token: 0x06008421 RID: 33825 RVA: 0x0013CE94 File Offset: 0x0013B094
		public virtual int EndRead(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.asyncResult);
			}
			Stream.ReadWriteTask readWriteTask = asyncResult as Stream.ReadWriteTask;
			if (readWriteTask == null || !readWriteTask._isRead)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.InvalidOperation_WrongAsyncResultOrEndCalledMultiple);
			}
			else if (readWriteTask._endCalled)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_WrongAsyncResultOrEndCalledMultiple);
			}
			int result;
			try
			{
				result = readWriteTask.GetAwaiter().GetResult();
			}
			finally
			{
				this.FinishTrackingAsyncOperation(readWriteTask);
			}
			return result;
		}

		// Token: 0x06008422 RID: 33826 RVA: 0x0013CF00 File Offset: 0x0013B100
		public Task<int> ReadAsync(byte[] buffer, int offset, int count)
		{
			return this.ReadAsync(buffer, offset, count, CancellationToken.None);
		}

		// Token: 0x06008423 RID: 33827 RVA: 0x0013CF10 File Offset: 0x0013B110
		public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return this.BeginEndReadAsync(buffer, offset, count);
			}
			return Task.FromCanceled<int>(cancellationToken);
		}

		// Token: 0x06008424 RID: 33828 RVA: 0x0013CF2C File Offset: 0x0013B12C
		[NullableContext(0)]
		public virtual ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			ArraySegment<byte> arraySegment;
			if (MemoryMarshal.TryGetArray<byte>(buffer, out arraySegment))
			{
				return new ValueTask<int>(this.ReadAsync(arraySegment.Array, arraySegment.Offset, arraySegment.Count, cancellationToken));
			}
			byte[] array = ArrayPool<byte>.Shared.Rent(buffer.Length);
			return Stream.<ReadAsync>g__FinishReadAsync|42_0(this.ReadAsync(array, 0, buffer.Length, cancellationToken), array, buffer);
		}

		// Token: 0x06008425 RID: 33829 RVA: 0x0013CF93 File Offset: 0x0013B193
		[NullableContext(0)]
		public ValueTask ReadExactlyAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return ValueTask.DangerousCreateFromTypedValueTask<int>(this.ReadAtLeastAsyncCore(buffer, buffer.Length, true, cancellationToken));
		}

		// Token: 0x06008426 RID: 33830 RVA: 0x0013CFAA File Offset: 0x0013B1AA
		public ValueTask ReadExactlyAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken = default(CancellationToken))
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			return ValueTask.DangerousCreateFromTypedValueTask<int>(this.ReadAtLeastAsyncCore(buffer.AsMemory(offset, count), count, true, cancellationToken));
		}

		// Token: 0x06008427 RID: 33831 RVA: 0x0013CFCB File Offset: 0x0013B1CB
		[NullableContext(0)]
		public ValueTask<int> ReadAtLeastAsync(Memory<byte> buffer, int minimumBytes, bool throwOnEndOfStream = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			Stream.ValidateReadAtLeastArguments(buffer.Length, minimumBytes);
			return this.ReadAtLeastAsyncCore(buffer, minimumBytes, throwOnEndOfStream, cancellationToken);
		}

		// Token: 0x06008428 RID: 33832 RVA: 0x0013CFE8 File Offset: 0x0013B1E8
		[AsyncMethodBuilder(typeof(PoolingAsyncValueTaskMethodBuilder<>))]
		private ValueTask<int> ReadAtLeastAsyncCore(Memory<byte> buffer, int minimumBytes, bool throwOnEndOfStream, CancellationToken cancellationToken)
		{
			Stream.<ReadAtLeastAsyncCore>d__46 <ReadAtLeastAsyncCore>d__;
			<ReadAtLeastAsyncCore>d__.<>t__builder = PoolingAsyncValueTaskMethodBuilder<int>.Create();
			<ReadAtLeastAsyncCore>d__.<>4__this = this;
			<ReadAtLeastAsyncCore>d__.buffer = buffer;
			<ReadAtLeastAsyncCore>d__.minimumBytes = minimumBytes;
			<ReadAtLeastAsyncCore>d__.throwOnEndOfStream = throwOnEndOfStream;
			<ReadAtLeastAsyncCore>d__.cancellationToken = cancellationToken;
			<ReadAtLeastAsyncCore>d__.<>1__state = -1;
			<ReadAtLeastAsyncCore>d__.<>t__builder.Start<Stream.<ReadAtLeastAsyncCore>d__46>(ref <ReadAtLeastAsyncCore>d__);
			return <ReadAtLeastAsyncCore>d__.<>t__builder.Task;
		}

		// Token: 0x06008429 RID: 33833
		[Intrinsic]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool HasOverriddenBeginEndRead();

		// Token: 0x0600842A RID: 33834
		[Intrinsic]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool HasOverriddenBeginEndWrite();

		// Token: 0x0600842B RID: 33835 RVA: 0x0013D04C File Offset: 0x0013B24C
		private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count)
		{
			if (!this.HasOverriddenBeginEndRead())
			{
				return this.BeginReadInternal(buffer, offset, count, null, null, true, false);
			}
			return TaskFactory<int>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>(this, new Stream.ReadWriteParameters
			{
				Buffer = buffer,
				Offset = offset,
				Count = count
			}, (Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) => stream.BeginRead(args.Buffer, args.Offset, args.Count, callback, state), (Stream stream, IAsyncResult asyncResult) => stream.EndRead(asyncResult));
		}

		// Token: 0x0600842C RID: 33836 RVA: 0x0013D0D4 File Offset: 0x0013B2D4
		public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, [Nullable(2)] AsyncCallback callback, [Nullable(2)] object state)
		{
			return this.BeginWriteInternal(buffer, offset, count, callback, state, false, true);
		}

		// Token: 0x0600842D RID: 33837 RVA: 0x0013D0E8 File Offset: 0x0013B2E8
		internal Task BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			if (!this.CanWrite)
			{
				ThrowHelper.ThrowNotSupportedException_UnwritableStream();
			}
			SemaphoreSlim semaphoreSlim = this.EnsureAsyncActiveSemaphoreInitialized();
			Task task = null;
			if (serializeAsynchronously)
			{
				task = semaphoreSlim.WaitAsync();
			}
			else
			{
				semaphoreSlim.Wait();
			}
			Stream.ReadWriteTask readWriteTask = new Stream.ReadWriteTask(false, apm, delegate(object <p0>)
			{
				Stream.ReadWriteTask readWriteTask2 = Task.InternalCurrent as Stream.ReadWriteTask;
				int result;
				try
				{
					readWriteTask2._stream.Write(readWriteTask2._buffer, readWriteTask2._offset, readWriteTask2._count);
					result = 0;
				}
				finally
				{
					if (!readWriteTask2._apm)
					{
						readWriteTask2._stream.FinishTrackingAsyncOperation(readWriteTask2);
					}
					readWriteTask2.ClearBeginState();
				}
				return result;
			}, state, this, buffer, offset, count, callback);
			if (task != null)
			{
				Stream.RunReadWriteTaskWhenReady(task, readWriteTask);
			}
			else
			{
				Stream.RunReadWriteTask(readWriteTask);
			}
			return readWriteTask;
		}

		// Token: 0x0600842E RID: 33838 RVA: 0x0013D16C File Offset: 0x0013B36C
		private static void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask)
		{
			if (asyncWaiter.IsCompleted)
			{
				Stream.RunReadWriteTask(readWriteTask);
				return;
			}
			asyncWaiter.ContinueWith(delegate(Task t, object state)
			{
				Stream.RunReadWriteTask((Stream.ReadWriteTask)state);
			}, readWriteTask, default(CancellationToken), TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
		}

		// Token: 0x0600842F RID: 33839 RVA: 0x0013D1C2 File Offset: 0x0013B3C2
		private static void RunReadWriteTask(Stream.ReadWriteTask readWriteTask)
		{
			readWriteTask.m_taskScheduler = TaskScheduler.Default;
			readWriteTask.ScheduleAndStart(false);
		}

		// Token: 0x06008430 RID: 33840 RVA: 0x0013D1D6 File Offset: 0x0013B3D6
		private void FinishTrackingAsyncOperation(Stream.ReadWriteTask task)
		{
			task._endCalled = true;
			this._asyncActiveSemaphore.Release();
		}

		// Token: 0x06008431 RID: 33841 RVA: 0x0013D1EC File Offset: 0x0013B3EC
		public virtual void EndWrite(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.asyncResult);
			}
			Stream.ReadWriteTask readWriteTask = asyncResult as Stream.ReadWriteTask;
			if (readWriteTask == null || readWriteTask._isRead)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.InvalidOperation_WrongAsyncResultOrEndCalledMultiple);
			}
			else if (readWriteTask._endCalled)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_WrongAsyncResultOrEndCalledMultiple);
			}
			try
			{
				readWriteTask.GetAwaiter().GetResult();
			}
			finally
			{
				this.FinishTrackingAsyncOperation(readWriteTask);
			}
		}

		// Token: 0x06008432 RID: 33842 RVA: 0x0013D258 File Offset: 0x0013B458
		public Task WriteAsync(byte[] buffer, int offset, int count)
		{
			return this.WriteAsync(buffer, offset, count, CancellationToken.None);
		}

		// Token: 0x06008433 RID: 33843 RVA: 0x0013D268 File Offset: 0x0013B468
		public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return this.BeginEndWriteAsync(buffer, offset, count);
			}
			return Task.FromCanceled(cancellationToken);
		}

		// Token: 0x06008434 RID: 33844 RVA: 0x0013D284 File Offset: 0x0013B484
		[NullableContext(0)]
		public virtual ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			ArraySegment<byte> arraySegment;
			if (MemoryMarshal.TryGetArray<byte>(buffer, out arraySegment))
			{
				return new ValueTask(this.WriteAsync(arraySegment.Array, arraySegment.Offset, arraySegment.Count, cancellationToken));
			}
			byte[] array = ArrayPool<byte>.Shared.Rent(buffer.Length);
			buffer.Span.CopyTo(array);
			return new ValueTask(Stream.FinishWriteAsync(this.WriteAsync(array, 0, buffer.Length, cancellationToken), array));
		}

		// Token: 0x06008435 RID: 33845 RVA: 0x0013D300 File Offset: 0x0013B500
		private static Task FinishWriteAsync(Task writeTask, byte[] localBuffer)
		{
			Stream.<FinishWriteAsync>d__61 <FinishWriteAsync>d__;
			<FinishWriteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FinishWriteAsync>d__.writeTask = writeTask;
			<FinishWriteAsync>d__.localBuffer = localBuffer;
			<FinishWriteAsync>d__.<>1__state = -1;
			<FinishWriteAsync>d__.<>t__builder.Start<Stream.<FinishWriteAsync>d__61>(ref <FinishWriteAsync>d__);
			return <FinishWriteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06008436 RID: 33846 RVA: 0x0013D34C File Offset: 0x0013B54C
		private Task BeginEndWriteAsync(byte[] buffer, int offset, int count)
		{
			if (!this.HasOverriddenBeginEndWrite())
			{
				return this.BeginWriteInternal(buffer, offset, count, null, null, true, false);
			}
			return TaskFactory<VoidTaskResult>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>(this, new Stream.ReadWriteParameters
			{
				Buffer = buffer,
				Offset = offset,
				Count = count
			}, (Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) => stream.BeginWrite(args.Buffer, args.Offset, args.Count, callback, state), delegate(Stream stream, IAsyncResult asyncResult)
			{
				stream.EndWrite(asyncResult);
				return default(VoidTaskResult);
			});
		}

		// Token: 0x06008437 RID: 33847
		public abstract long Seek(long offset, SeekOrigin origin);

		// Token: 0x06008438 RID: 33848
		public abstract void SetLength(long value);

		// Token: 0x06008439 RID: 33849
		public abstract int Read(byte[] buffer, int offset, int count);

		// Token: 0x0600843A RID: 33850 RVA: 0x0013D3D4 File Offset: 0x0013B5D4
		[NullableContext(0)]
		public virtual int Read(Span<byte> buffer)
		{
			byte[] array = ArrayPool<byte>.Shared.Rent(buffer.Length);
			int result;
			try
			{
				int num = this.Read(array, 0, buffer.Length);
				if (num > buffer.Length)
				{
					throw new IOException(SR.IO_StreamTooLong);
				}
				new ReadOnlySpan<byte>(array, 0, num).CopyTo(buffer);
				result = num;
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x0600843B RID: 33851 RVA: 0x0013D44C File Offset: 0x0013B64C
		public virtual int ReadByte()
		{
			byte[] array = new byte[1];
			if (this.Read(array, 0, 1) != 0)
			{
				return (int)array[0];
			}
			return -1;
		}

		// Token: 0x0600843C RID: 33852 RVA: 0x0013D470 File Offset: 0x0013B670
		[NullableContext(0)]
		public void ReadExactly(Span<byte> buffer)
		{
			this.ReadAtLeastCore(buffer, buffer.Length, true);
		}

		// Token: 0x0600843D RID: 33853 RVA: 0x0013D482 File Offset: 0x0013B682
		public void ReadExactly(byte[] buffer, int offset, int count)
		{
			Stream.ValidateBufferArguments(buffer, offset, count);
			this.ReadAtLeastCore(buffer.AsSpan(offset, count), count, true);
		}

		// Token: 0x0600843E RID: 33854 RVA: 0x0013D49D File Offset: 0x0013B69D
		[NullableContext(0)]
		public int ReadAtLeast(Span<byte> buffer, int minimumBytes, bool throwOnEndOfStream = true)
		{
			Stream.ValidateReadAtLeastArguments(buffer.Length, minimumBytes);
			return this.ReadAtLeastCore(buffer, minimumBytes, throwOnEndOfStream);
		}

		// Token: 0x0600843F RID: 33855 RVA: 0x0013D4B8 File Offset: 0x0013B6B8
		private int ReadAtLeastCore(Span<byte> buffer, int minimumBytes, bool throwOnEndOfStream)
		{
			int i;
			int num;
			for (i = 0; i < minimumBytes; i += num)
			{
				num = this.Read(buffer.Slice(i));
				if (num == 0)
				{
					if (throwOnEndOfStream)
					{
						ThrowHelper.ThrowEndOfFileException();
					}
					return i;
				}
			}
			return i;
		}

		// Token: 0x06008440 RID: 33856
		public abstract void Write(byte[] buffer, int offset, int count);

		// Token: 0x06008441 RID: 33857 RVA: 0x0013D4F0 File Offset: 0x0013B6F0
		[NullableContext(0)]
		public virtual void Write(ReadOnlySpan<byte> buffer)
		{
			byte[] array = ArrayPool<byte>.Shared.Rent(buffer.Length);
			try
			{
				buffer.CopyTo(array);
				this.Write(array, 0, buffer.Length);
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
		}

		// Token: 0x06008442 RID: 33858 RVA: 0x0013D54C File Offset: 0x0013B74C
		public virtual void WriteByte(byte value)
		{
			this.Write(new byte[]
			{
				value
			}, 0, 1);
		}

		// Token: 0x06008443 RID: 33859 RVA: 0x0013D560 File Offset: 0x0013B760
		public static Stream Synchronized(Stream stream)
		{
			ArgumentNullException.ThrowIfNull(stream, "stream");
			return (stream as Stream.SyncStream) ?? new Stream.SyncStream(stream);
		}

		// Token: 0x06008444 RID: 33860 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[Obsolete("Do not call or override this method.")]
		protected virtual void ObjectInvariant()
		{
		}

		// Token: 0x06008445 RID: 33861 RVA: 0x0013D57D File Offset: 0x0013B77D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected static void ValidateBufferArguments(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.buffer);
			}
			if (offset < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.offset, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if ((ulong)count > (ulong)((long)(buffer.Length - offset)))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.Argument_InvalidOffLen);
			}
		}

		// Token: 0x06008446 RID: 33862 RVA: 0x0013D5A9 File Offset: 0x0013B7A9
		private static void ValidateReadAtLeastArguments(int bufferLength, int minimumBytes)
		{
			if (minimumBytes < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.minimumBytes, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (bufferLength < minimumBytes)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.minimumBytes, ExceptionResource.ArgumentOutOfRange_NotGreaterThanBufferLength);
			}
		}

		// Token: 0x06008447 RID: 33863 RVA: 0x0013D5C5 File Offset: 0x0013B7C5
		protected static void ValidateCopyToArguments(Stream destination, int bufferSize)
		{
			ArgumentNullException.ThrowIfNull(destination, "destination");
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero<int>(bufferSize, "bufferSize");
			if (!destination.CanWrite)
			{
				if (destination.CanRead)
				{
					ThrowHelper.ThrowNotSupportedException_UnwritableStream();
				}
				ThrowHelper.ThrowObjectDisposedException_StreamClosed(destination.GetType().Name);
			}
		}

		// Token: 0x0600844A RID: 33866 RVA: 0x0013D610 File Offset: 0x0013B810
		[CompilerGenerated]
		internal static Task <CopyToAsync>g__Core|27_0(Stream source, Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			Stream.<<CopyToAsync>g__Core|27_0>d <<CopyToAsync>g__Core|27_0>d;
			<<CopyToAsync>g__Core|27_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<CopyToAsync>g__Core|27_0>d.source = source;
			<<CopyToAsync>g__Core|27_0>d.destination = destination;
			<<CopyToAsync>g__Core|27_0>d.bufferSize = bufferSize;
			<<CopyToAsync>g__Core|27_0>d.cancellationToken = cancellationToken;
			<<CopyToAsync>g__Core|27_0>d.<>1__state = -1;
			<<CopyToAsync>g__Core|27_0>d.<>t__builder.Start<Stream.<<CopyToAsync>g__Core|27_0>d>(ref <<CopyToAsync>g__Core|27_0>d);
			return <<CopyToAsync>g__Core|27_0>d.<>t__builder.Task;
		}

		// Token: 0x0600844B RID: 33867 RVA: 0x0013D66C File Offset: 0x0013B86C
		[CompilerGenerated]
		internal static ValueTask<int> <ReadAsync>g__FinishReadAsync|42_0(Task<int> readTask, byte[] localBuffer, Memory<byte> localDestination)
		{
			Stream.<<ReadAsync>g__FinishReadAsync|42_0>d <<ReadAsync>g__FinishReadAsync|42_0>d;
			<<ReadAsync>g__FinishReadAsync|42_0>d.<>t__builder = AsyncValueTaskMethodBuilder<int>.Create();
			<<ReadAsync>g__FinishReadAsync|42_0>d.readTask = readTask;
			<<ReadAsync>g__FinishReadAsync|42_0>d.localBuffer = localBuffer;
			<<ReadAsync>g__FinishReadAsync|42_0>d.localDestination = localDestination;
			<<ReadAsync>g__FinishReadAsync|42_0>d.<>1__state = -1;
			<<ReadAsync>g__FinishReadAsync|42_0>d.<>t__builder.Start<Stream.<<ReadAsync>g__FinishReadAsync|42_0>d>(ref <<ReadAsync>g__FinishReadAsync|42_0>d);
			return <<ReadAsync>g__FinishReadAsync|42_0>d.<>t__builder.Task;
		}

		// Token: 0x04001C22 RID: 7202
		public static readonly Stream Null = new Stream.NullStream();

		// Token: 0x04001C23 RID: 7203
		private protected SemaphoreSlim _asyncActiveSemaphore;

		// Token: 0x02000819 RID: 2073
		private struct ReadWriteParameters
		{
			// Token: 0x04001C24 RID: 7204
			internal byte[] Buffer;

			// Token: 0x04001C25 RID: 7205
			internal int Offset;

			// Token: 0x04001C26 RID: 7206
			internal int Count;
		}

		// Token: 0x0200081A RID: 2074
		private sealed class ReadWriteTask : Task<int>, ITaskCompletionAction
		{
			// Token: 0x0600844C RID: 33868 RVA: 0x0013D6BF File Offset: 0x0013B8BF
			internal void ClearBeginState()
			{
				this._stream = null;
				this._buffer = null;
			}

			// Token: 0x0600844D RID: 33869 RVA: 0x0013D6D0 File Offset: 0x0013B8D0
			public ReadWriteTask(bool isRead, bool apm, Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback) : base(function, state, CancellationToken.None, TaskCreationOptions.DenyChildAttach)
			{
				this._isRead = isRead;
				this._apm = apm;
				this._stream = stream;
				this._buffer = buffer;
				this._offset = offset;
				this._count = count;
				if (callback != null)
				{
					this._callback = callback;
					this._context = ExecutionContext.Capture();
					base.AddCompletionAction(this, false);
				}
			}

			// Token: 0x0600844E RID: 33870 RVA: 0x0013D73C File Offset: 0x0013B93C
			private static void InvokeAsyncCallback(object completedTask)
			{
				Stream.ReadWriteTask readWriteTask = (Stream.ReadWriteTask)completedTask;
				AsyncCallback callback = readWriteTask._callback;
				readWriteTask._callback = null;
				callback(readWriteTask);
			}

			// Token: 0x0600844F RID: 33871 RVA: 0x0013D764 File Offset: 0x0013B964
			void ITaskCompletionAction.Invoke(Task completingTask)
			{
				ExecutionContext context = this._context;
				if (context == null)
				{
					AsyncCallback callback = this._callback;
					this._callback = null;
					callback(completingTask);
					return;
				}
				this._context = null;
				ContextCallback contextCallback;
				if ((contextCallback = Stream.ReadWriteTask.s_invokeAsyncCallback) == null)
				{
					ContextCallback contextCallback2;
					if ((contextCallback2 = Stream.ReadWriteTask.<>O.<0>__InvokeAsyncCallback) == null)
					{
						contextCallback2 = (Stream.ReadWriteTask.<>O.<0>__InvokeAsyncCallback = new ContextCallback(Stream.ReadWriteTask.InvokeAsyncCallback));
					}
					contextCallback = (Stream.ReadWriteTask.s_invokeAsyncCallback = contextCallback2);
				}
				ContextCallback callback2 = contextCallback;
				ExecutionContext.RunInternal(context, callback2, this);
			}

			// Token: 0x1700119F RID: 4511
			// (get) Token: 0x06008450 RID: 33872 RVA: 0x000070DD File Offset: 0x000052DD
			bool ITaskCompletionAction.InvokeMayRunArbitraryCode
			{
				get
				{
					return true;
				}
			}

			// Token: 0x04001C27 RID: 7207
			internal readonly bool _isRead;

			// Token: 0x04001C28 RID: 7208
			internal readonly bool _apm;

			// Token: 0x04001C29 RID: 7209
			internal bool _endCalled;

			// Token: 0x04001C2A RID: 7210
			internal Stream _stream;

			// Token: 0x04001C2B RID: 7211
			internal byte[] _buffer;

			// Token: 0x04001C2C RID: 7212
			internal readonly int _offset;

			// Token: 0x04001C2D RID: 7213
			internal readonly int _count;

			// Token: 0x04001C2E RID: 7214
			private AsyncCallback _callback;

			// Token: 0x04001C2F RID: 7215
			private ExecutionContext _context;

			// Token: 0x04001C30 RID: 7216
			private static ContextCallback s_invokeAsyncCallback;

			// Token: 0x0200081B RID: 2075
			[CompilerGenerated]
			private static class <>O
			{
				// Token: 0x04001C31 RID: 7217
				public static ContextCallback <0>__InvokeAsyncCallback;
			}
		}

		// Token: 0x0200081C RID: 2076
		private sealed class NullStream : Stream
		{
			// Token: 0x06008451 RID: 33873 RVA: 0x0013D7C9 File Offset: 0x0013B9C9
			internal NullStream()
			{
			}

			// Token: 0x170011A0 RID: 4512
			// (get) Token: 0x06008452 RID: 33874 RVA: 0x000070DD File Offset: 0x000052DD
			public override bool CanRead
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170011A1 RID: 4513
			// (get) Token: 0x06008453 RID: 33875 RVA: 0x000070DD File Offset: 0x000052DD
			public override bool CanWrite
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170011A2 RID: 4514
			// (get) Token: 0x06008454 RID: 33876 RVA: 0x000070DD File Offset: 0x000052DD
			public override bool CanSeek
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170011A3 RID: 4515
			// (get) Token: 0x06008455 RID: 33877 RVA: 0x000304C1 File Offset: 0x0002E6C1
			public override long Length
			{
				get
				{
					return 0L;
				}
			}

			// Token: 0x170011A4 RID: 4516
			// (get) Token: 0x06008456 RID: 33878 RVA: 0x000304C1 File Offset: 0x0002E6C1
			// (set) Token: 0x06008457 RID: 33879 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override long Position
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			// Token: 0x06008458 RID: 33880 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void CopyTo(Stream destination, int bufferSize)
			{
			}

			// Token: 0x06008459 RID: 33881 RVA: 0x0013D7D1 File Offset: 0x0013B9D1
			public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return Task.CompletedTask;
				}
				return Task.FromCanceled(cancellationToken);
			}

			// Token: 0x0600845A RID: 33882 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x0600845B RID: 33883 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Flush()
			{
			}

			// Token: 0x0600845C RID: 33884 RVA: 0x0013D7E8 File Offset: 0x0013B9E8
			public override Task FlushAsync(CancellationToken cancellationToken)
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return Task.CompletedTask;
				}
				return Task.FromCanceled(cancellationToken);
			}

			// Token: 0x0600845D RID: 33885 RVA: 0x0013D7FF File Offset: 0x0013B9FF
			public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				return TaskToAsyncResult.Begin(Task<int>.s_defaultResultTask, callback, state);
			}

			// Token: 0x0600845E RID: 33886 RVA: 0x0008A76D File Offset: 0x0008896D
			public override int EndRead(IAsyncResult asyncResult)
			{
				return TaskToAsyncResult.End<int>(asyncResult);
			}

			// Token: 0x0600845F RID: 33887 RVA: 0x0013D80F File Offset: 0x0013BA0F
			public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				return TaskToAsyncResult.Begin(Task.CompletedTask, callback, state);
			}

			// Token: 0x06008460 RID: 33888 RVA: 0x0008A775 File Offset: 0x00088975
			public override void EndWrite(IAsyncResult asyncResult)
			{
				TaskToAsyncResult.End(asyncResult);
			}

			// Token: 0x06008461 RID: 33889 RVA: 0x00007B65 File Offset: 0x00005D65
			public override int Read(byte[] buffer, int offset, int count)
			{
				return 0;
			}

			// Token: 0x06008462 RID: 33890 RVA: 0x00007B65 File Offset: 0x00005D65
			public override int Read(Span<byte> buffer)
			{
				return 0;
			}

			// Token: 0x06008463 RID: 33891 RVA: 0x0013D81F File Offset: 0x0013BA1F
			public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return Task.FromResult<int>(0);
				}
				return Task.FromCanceled<int>(cancellationToken);
			}

			// Token: 0x06008464 RID: 33892 RVA: 0x0013D838 File Offset: 0x0013BA38
			public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken)
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return default(ValueTask<int>);
				}
				return ValueTask.FromCanceled<int>(cancellationToken);
			}

			// Token: 0x06008465 RID: 33893 RVA: 0x0003F19A File Offset: 0x0003D39A
			public override int ReadByte()
			{
				return -1;
			}

			// Token: 0x06008466 RID: 33894 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(byte[] buffer, int offset, int count)
			{
			}

			// Token: 0x06008467 RID: 33895 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void Write(ReadOnlySpan<byte> buffer)
			{
			}

			// Token: 0x06008468 RID: 33896 RVA: 0x0013D85E File Offset: 0x0013BA5E
			public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return Task.CompletedTask;
				}
				return Task.FromCanceled(cancellationToken);
			}

			// Token: 0x06008469 RID: 33897 RVA: 0x0013D878 File Offset: 0x0013BA78
			public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					return default(ValueTask);
				}
				return ValueTask.FromCanceled(cancellationToken);
			}

			// Token: 0x0600846A RID: 33898 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void WriteByte(byte value)
			{
			}

			// Token: 0x0600846B RID: 33899 RVA: 0x000304C1 File Offset: 0x0002E6C1
			public override long Seek(long offset, SeekOrigin origin)
			{
				return 0L;
			}

			// Token: 0x0600846C RID: 33900 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void SetLength(long length)
			{
			}
		}

		// Token: 0x0200081D RID: 2077
		private sealed class SyncStream : Stream, IDisposable
		{
			// Token: 0x0600846D RID: 33901 RVA: 0x0013D89E File Offset: 0x0013BA9E
			internal SyncStream(Stream stream)
			{
				this._stream = stream;
			}

			// Token: 0x170011A5 RID: 4517
			// (get) Token: 0x0600846E RID: 33902 RVA: 0x0013D8AD File Offset: 0x0013BAAD
			public override bool CanRead
			{
				get
				{
					return this._stream.CanRead;
				}
			}

			// Token: 0x170011A6 RID: 4518
			// (get) Token: 0x0600846F RID: 33903 RVA: 0x0013D8BA File Offset: 0x0013BABA
			public override bool CanWrite
			{
				get
				{
					return this._stream.CanWrite;
				}
			}

			// Token: 0x170011A7 RID: 4519
			// (get) Token: 0x06008470 RID: 33904 RVA: 0x0013D8C7 File Offset: 0x0013BAC7
			public override bool CanSeek
			{
				get
				{
					return this._stream.CanSeek;
				}
			}

			// Token: 0x170011A8 RID: 4520
			// (get) Token: 0x06008471 RID: 33905 RVA: 0x0013D8D4 File Offset: 0x0013BAD4
			public override bool CanTimeout
			{
				get
				{
					return this._stream.CanTimeout;
				}
			}

			// Token: 0x170011A9 RID: 4521
			// (get) Token: 0x06008472 RID: 33906 RVA: 0x0013D8E4 File Offset: 0x0013BAE4
			public override long Length
			{
				get
				{
					Stream stream = this._stream;
					long length;
					lock (stream)
					{
						length = this._stream.Length;
					}
					return length;
				}
			}

			// Token: 0x170011AA RID: 4522
			// (get) Token: 0x06008473 RID: 33907 RVA: 0x0013D92C File Offset: 0x0013BB2C
			// (set) Token: 0x06008474 RID: 33908 RVA: 0x0013D974 File Offset: 0x0013BB74
			public override long Position
			{
				get
				{
					Stream stream = this._stream;
					long position;
					lock (stream)
					{
						position = this._stream.Position;
					}
					return position;
				}
				set
				{
					Stream stream = this._stream;
					lock (stream)
					{
						this._stream.Position = value;
					}
				}
			}

			// Token: 0x170011AB RID: 4523
			// (get) Token: 0x06008475 RID: 33909 RVA: 0x0013D9BC File Offset: 0x0013BBBC
			// (set) Token: 0x06008476 RID: 33910 RVA: 0x0013D9C9 File Offset: 0x0013BBC9
			public override int ReadTimeout
			{
				get
				{
					return this._stream.ReadTimeout;
				}
				set
				{
					this._stream.ReadTimeout = value;
				}
			}

			// Token: 0x170011AC RID: 4524
			// (get) Token: 0x06008477 RID: 33911 RVA: 0x0013D9D7 File Offset: 0x0013BBD7
			// (set) Token: 0x06008478 RID: 33912 RVA: 0x0013D9E4 File Offset: 0x0013BBE4
			public override int WriteTimeout
			{
				get
				{
					return this._stream.WriteTimeout;
				}
				set
				{
					this._stream.WriteTimeout = value;
				}
			}

			// Token: 0x06008479 RID: 33913 RVA: 0x0013D9F4 File Offset: 0x0013BBF4
			public override void Close()
			{
				Stream stream = this._stream;
				lock (stream)
				{
					try
					{
						this._stream.Close();
					}
					finally
					{
						base.Dispose(true);
					}
				}
			}

			// Token: 0x0600847A RID: 33914 RVA: 0x0013DA50 File Offset: 0x0013BC50
			protected override void Dispose(bool disposing)
			{
				Stream stream = this._stream;
				lock (stream)
				{
					try
					{
						if (disposing)
						{
							((IDisposable)this._stream).Dispose();
						}
					}
					finally
					{
						base.Dispose(disposing);
					}
				}
			}

			// Token: 0x0600847B RID: 33915 RVA: 0x0013DAAC File Offset: 0x0013BCAC
			public override ValueTask DisposeAsync()
			{
				Stream stream = this._stream;
				ValueTask result;
				lock (stream)
				{
					result = this._stream.DisposeAsync();
				}
				return result;
			}

			// Token: 0x0600847C RID: 33916 RVA: 0x0013DAF4 File Offset: 0x0013BCF4
			public override void Flush()
			{
				Stream stream = this._stream;
				lock (stream)
				{
					this._stream.Flush();
				}
			}

			// Token: 0x0600847D RID: 33917 RVA: 0x0013DB3C File Offset: 0x0013BD3C
			public override int Read(byte[] bytes, int offset, int count)
			{
				Stream stream = this._stream;
				int result;
				lock (stream)
				{
					result = this._stream.Read(bytes, offset, count);
				}
				return result;
			}

			// Token: 0x0600847E RID: 33918 RVA: 0x0013DB88 File Offset: 0x0013BD88
			public override int Read(Span<byte> buffer)
			{
				Stream stream = this._stream;
				int result;
				lock (stream)
				{
					result = this._stream.Read(buffer);
				}
				return result;
			}

			// Token: 0x0600847F RID: 33919 RVA: 0x0013DBD0 File Offset: 0x0013BDD0
			public override int ReadByte()
			{
				Stream stream = this._stream;
				int result;
				lock (stream)
				{
					result = this._stream.ReadByte();
				}
				return result;
			}

			// Token: 0x06008480 RID: 33920 RVA: 0x0013DC18 File Offset: 0x0013BE18
			public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				bool flag = this._stream.HasOverriddenBeginEndRead();
				Stream stream = this._stream;
				IAsyncResult asyncResult;
				lock (stream)
				{
					IAsyncResult asyncResult2;
					if (!flag)
					{
						asyncResult = this._stream.BeginReadInternal(buffer, offset, count, callback, state, true, true);
						asyncResult2 = asyncResult;
					}
					else
					{
						asyncResult2 = this._stream.BeginRead(buffer, offset, count, callback, state);
					}
					asyncResult = asyncResult2;
				}
				return asyncResult;
			}

			// Token: 0x06008481 RID: 33921 RVA: 0x0013DC90 File Offset: 0x0013BE90
			public override int EndRead(IAsyncResult asyncResult)
			{
				if (asyncResult == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.asyncResult);
				}
				Stream stream = this._stream;
				int result;
				lock (stream)
				{
					result = this._stream.EndRead(asyncResult);
				}
				return result;
			}

			// Token: 0x06008482 RID: 33922 RVA: 0x0013DCE4 File Offset: 0x0013BEE4
			public override long Seek(long offset, SeekOrigin origin)
			{
				Stream stream = this._stream;
				long result;
				lock (stream)
				{
					result = this._stream.Seek(offset, origin);
				}
				return result;
			}

			// Token: 0x06008483 RID: 33923 RVA: 0x0013DD30 File Offset: 0x0013BF30
			public override void SetLength(long length)
			{
				Stream stream = this._stream;
				lock (stream)
				{
					this._stream.SetLength(length);
				}
			}

			// Token: 0x06008484 RID: 33924 RVA: 0x0013DD78 File Offset: 0x0013BF78
			public override void Write(byte[] bytes, int offset, int count)
			{
				Stream stream = this._stream;
				lock (stream)
				{
					this._stream.Write(bytes, offset, count);
				}
			}

			// Token: 0x06008485 RID: 33925 RVA: 0x0013DDC0 File Offset: 0x0013BFC0
			public override void Write(ReadOnlySpan<byte> buffer)
			{
				Stream stream = this._stream;
				lock (stream)
				{
					this._stream.Write(buffer);
				}
			}

			// Token: 0x06008486 RID: 33926 RVA: 0x0013DE08 File Offset: 0x0013C008
			public override void WriteByte(byte b)
			{
				Stream stream = this._stream;
				lock (stream)
				{
					this._stream.WriteByte(b);
				}
			}

			// Token: 0x06008487 RID: 33927 RVA: 0x0013DE50 File Offset: 0x0013C050
			public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				bool flag = this._stream.HasOverriddenBeginEndWrite();
				Stream stream = this._stream;
				IAsyncResult asyncResult;
				lock (stream)
				{
					IAsyncResult asyncResult2;
					if (!flag)
					{
						asyncResult = this._stream.BeginWriteInternal(buffer, offset, count, callback, state, true, true);
						asyncResult2 = asyncResult;
					}
					else
					{
						asyncResult2 = this._stream.BeginWrite(buffer, offset, count, callback, state);
					}
					asyncResult = asyncResult2;
				}
				return asyncResult;
			}

			// Token: 0x06008488 RID: 33928 RVA: 0x0013DEC8 File Offset: 0x0013C0C8
			public override void EndWrite(IAsyncResult asyncResult)
			{
				if (asyncResult == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.asyncResult);
				}
				Stream stream = this._stream;
				lock (stream)
				{
					this._stream.EndWrite(asyncResult);
				}
			}

			// Token: 0x04001C32 RID: 7218
			private readonly Stream _stream;
		}
	}
}
